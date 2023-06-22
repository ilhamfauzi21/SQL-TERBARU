using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQL_TERBARU
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source = TRIPLECENTRE\\IRAWAN_ROFI_H;" +
            "database=Data_Mahasiswa;multipleActiveResultSets=true;user ID= sa; Password = Irh081999";
        private SqlConnection koneksi;
        private string kstr;

        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            refreshForm();

        }
        private void refreshForm()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            btnsave.Enabled = false;
            btnClear.Enabled = false;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.Prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnsave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;
            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "Insert into dbo.Prodi (nama_prodi)" + "values(@id)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshForm();
            }
        }
        private void FormDataProdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

    }
}
