using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class ItemMSSQLContext : IItemContext
    {
        private string _connString;

        public ItemMSSQLContext(string connString)
        {
            _connString = connString;
        }

        public void CreateItem(ItemDTO item)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CreateItem", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.AddWithValue("@name", item.Name);
                        cmd.Parameters.AddWithValue("@description", item.Description);
                        cmd.Parameters.AddWithValue("@type", item.Type);
                        cmd.Parameters.AddWithValue("@unique", item.Unique);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public List<ItemDTO> GetAllItems()
        {
            List<ItemDTO> items = new List<ItemDTO>();
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("ShowAllItems", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            ItemDTO item = new ItemDTO(
                                record.GetInt32(record.GetOrdinal("ItemId")),
                                record.GetString(record.GetOrdinal("Name")),
                                record.GetString(record.GetOrdinal("Description")),
                                record.GetString(record.GetOrdinal("Type")),
                                record.GetBoolean(record.GetOrdinal("IsUnique"))
                            );
                            items.Add(item);
                        }

                        conn.Close();
                    }
                }

                return items;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public ItemDTO GetByName(string name)
        {
            List<ItemDTO> items = new List<ItemDTO>();
            try
            {
                ItemDTO item;
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetItemByName", conn)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.AddWithValue("@itemName", name);


                        using (var reader = cmd.ExecuteReader())
                        {
                            foreach (DbDataRecord record in reader)
                            {
                                item = new ItemDTO(
                                    record.GetInt32(record.GetOrdinal("ItemId")),
                                    record.GetString(record.GetOrdinal("Name")),
                                    record.GetString(record.GetOrdinal("Description")),
                                    record.GetString(record.GetOrdinal("Type")),
                                    record.GetBoolean(record.GetOrdinal("IsUnique"))
                                );
                                items.Add(item);
                            }
                        }
                    }
                }

                item = items.Single(u => u.Name == name);
                return item;
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }

        public void Update(ItemDTO item)
        {
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateItem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("Name", item.Name);
                        cmd.Parameters.AddWithValue("Description", item.Description);
                        cmd.Parameters.AddWithValue("Type", item.Type);
                        cmd.Parameters.AddWithValue("Unique", item.Unique);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
                throw;
            }
        }
    }
}