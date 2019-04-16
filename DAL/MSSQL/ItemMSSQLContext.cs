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
        public void CreateItem(ItemDTO item)
        {
            using (SqlConnection con = Database.getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("CreateItem", con)
                    {CommandType = CommandType.StoredProcedure})
                {
                    cmd.Parameters.AddWithValue("@name", item.Name);
                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@bonus", item.Bonus);
                    cmd.Parameters.AddWithValue("@type", item.Type);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ItemDTO> GetAllItems()
        {
            List<ItemDTO> items = new List<ItemDTO>();
            try
            {
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("ShowAllItems", con)
                        {CommandType = CommandType.StoredProcedure})
                    {
                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            ItemDTO item = new ItemDTO(
                                record.GetInt32(record.GetOrdinal("ItemId")),
                                record.GetString(record.GetOrdinal("Name")),
                                record.GetInt32(record.GetOrdinal("Bonus")),
                                record.GetString(record.GetOrdinal("Description")),
                                record.GetString(record.GetOrdinal("Type"))
                            );
                            items.Add(item);
                        }

                        con.Close();
                    }
                }

                return items;
            }
            catch (Exception e)
            {
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
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetItemByName", con)
                        { CommandType = CommandType.StoredProcedure })
                    {
                        cmd.Parameters.AddWithValue("@itemName", name);


                        using (var reader = cmd.ExecuteReader())
                        {
                            foreach (DbDataRecord record in reader)
                            {
                                item = new ItemDTO(
                                    record.GetInt32(record.GetOrdinal("ItemId")),
                                    record.GetString(record.GetOrdinal("Name")),
                                    record.GetInt32(record.GetOrdinal("Bonus")),
                                    record.GetString(record.GetOrdinal("Description")),
                                    record.GetString(record.GetOrdinal("Type"))
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
                Console.WriteLine(e);
                throw;
            }
        }

        public void Update(ItemDTO item)
        {
            try
            {
                using (SqlConnection con = Database.getConnection())
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UpdateItem", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("Name", item.Name);
                        command.Parameters.AddWithValue("Bonus", item.Bonus);
                        command.Parameters.AddWithValue("Description", item.Description);
                        command.Parameters.AddWithValue("Type", item.Type);
                        command.ExecuteNonQuery();
                    }

                    con.Close();
                }
            }
            catch (Exception e)
            {
                //todo a good exception
                Console.WriteLine(e);
            }
        }
    }
}