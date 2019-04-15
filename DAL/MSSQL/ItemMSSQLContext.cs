using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                    { CommandType = CommandType.StoredProcedure })
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
            throw new NotImplementedException();
        }

        public ItemDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
