using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _479314_Ega_Rizky_Setiawan_ResponsiJuniorProject.Classes
{
    public class Karyawan
    {
        private int id_karyawan;
        private string nama;
        private int id_dep;

        public Karyawan(string nama, int id_dep)
        {
            this.nama = nama;
            this.id_dep = id_dep;
        }

        public int Id_karyawan { get => id_karyawan; set => id_karyawan = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Id_dep { get => id_dep; set => id_dep = value; }

        public bool AddKaryawan()
        {
            dbConnection connection = new dbConnection();
            try
            {
                connection.OpenConnection();
                String sql = @"Insert into public.karyawan (nama, id_dep) values (:_nama, :_id_dep);";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.GetConnection());
                cmd.Parameters.AddWithValue("_nama", this.nama);
                cmd.Parameters.AddWithValue("_id_dep", this.id_dep);
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
                String sql = "Update karyawan set (nama = @nama, id_dep = @id_dep)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.GetConnection());
                cmd.Parameters.AddWithValue("nama", this.nama);
                cmd.Parameters.AddWithValue("id_dep", this.id_dep);
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
                String sql = "Delete from karyawan where id_karyawna = @id_karyawan";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection.GetConnection());
                cmd.Parameters.AddWithValue("id_dep", this.id_karyawan);
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
        public NpgsqlDataReader GetKaryawan()
        {
            dbConnection connection = new dbConnection();
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.CloseConnection();
            }

        }
    }
}
