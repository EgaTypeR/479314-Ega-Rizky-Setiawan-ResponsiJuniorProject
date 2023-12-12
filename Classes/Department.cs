using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _479314_Ega_Rizky_Setiawan_ResponsiJuniorProject.Classes
{
    public class Department
    {
        private int id_dept;
        private string nama_dep;

        public Department(string nama_dep)
        {
            this.nama_dep = nama_dep;
        }

        public int Id_dept { get => id_dept; set => id_dept = value; }
        public string Nama_dep { get => nama_dep; set => nama_dep = value; }

        public bool AddDepartment()
        {
            dbConnection connection = new dbConnection();
            try
            {
                connection.OpenConnection();
                String sql = "Insert into department (nama_dep) values (@nama_dep)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.GetConnection());
                cmd.Parameters.AddWithValue("nama_dep", this.nama_dep);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
            
        }
        public bool EditDepartment()
        {
            dbConnection connection = new dbConnection();
            try
            {
                connection.OpenConnection();
                String sql = "Update department set nama_dep = @nama_dep";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.GetConnection());
                cmd.Parameters.AddWithValue("nama_dep", this.nama_dep);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }

        }
        public bool DeleteDepartment()
        {
            dbConnection connection = new dbConnection();
            try
            {
                connection.OpenConnection();
                String sql = "Delete from department where id_dep = @id_dep";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.GetConnection());
                cmd.Parameters.AddWithValue("id_dep", this.id_dept);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }

        }
    }
}
