using _479314_Ega_Rizky_Setiawan_ResponsiJuniorProject.Classes;
using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace _479314_Ega_Rizky_Setiawan_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(constring);
        }
        private NpgsqlConnection conn;
        string constring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"insert into public.karyawan values (:_id_karyawan, :_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", 1);
                cmd.Parameters.AddWithValue("_id_karyawan", "000000");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucessfully Insert Karyawan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                Karyawan karyawan = new Karyawan(tbNama.Text, cbDepartment.SelectedIndex);
                sql = @"update karyawan SET nama = :_name, id_dep = :_id_dep WHERE id_karyawan = :_id_karyawan;";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", karyawan.Nama);
                cmd.Parameters.AddWithValue("_id_dep", karyawan.Id_dep);
                cmd.Parameters.AddWithValue("_id_karyawan", karyawan.Id_karyawan);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucessfully Edit Karyawan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_name"].Value.ToString() + " ?", "Hapus data terkonfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"Delete from karyawan where id_karyawna = :_id_karyawan";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                    MessageBox.Show("Data User Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }
    }
}