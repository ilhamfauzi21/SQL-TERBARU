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
    public partial class Form3 : Form
    {
        private string stringConnection = "data source = TRIPLECENTRE\\Kampus;database=Data_Mahasiswa;user ID= sa; Password = 123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        private string kstr;

        private void refreshform()
        {
            tbNIM.Enabled = false;
            tbNama.Enabled = false;
            cbJenisKelamin.Enabled = false;
            tbAlamat.Enabled = false;
            dtTanggalLahir.Enabled = false;
            cbProdi.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            FormDataMahasiswa_Load();
        }



        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            this.bindingNavigator1.BindingSource = this.customersBindingSource;

        }
        private void FormDataMahasiswa_Load()
        {

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.nim, m.nama_mahasiswa, m.alamat, " +
                "m.jenis_kelamin, m.tgl_lahir,p.nama_prodi From dbo.Mahasiswa, " +
                "join dbo.Prodi p on m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.tbNIM.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "NIM", true));
            this.tbNama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.tbAlamat.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.cbJenisKelamin.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "jenis_kelamin", true));
            this.dtTanggalLahir.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.cbProdi.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_prodi", true));
            koneksi.Close();

        }
        private void clearBinding()
        {
            this.tbNIM.DataBindings.Clear();
            this.tbNama.DataBindings.Clear();
            this.tbAlamat.DataBindings.Clear();
            this.cbJenisKelamin.DataBindings.Clear();
            this.dtTanggalLahir.DataBindings.Clear();
            this.cbProdi.DataBindings.Clear();
        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
