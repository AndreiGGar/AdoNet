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

namespace AdoNet
{
    public partial class Form4ModificarSalas : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form4ModificarSalas()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadSalas();
        }

        public void LoadSalas()
        {
            string sql = "SELECT NOMBRE FROM SALA GROUP BY NOMBRE";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listSalas.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.listSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string box = this.textBox1.Text;
            string selected = this.listSalas.SelectedItem.ToString();
            if (box != "")
            {
                string sql = "UPDATE SALA SET NOMBRE=@NOMBRE WHERE NOMBRE=@OLDNAME";
                SqlParameter paramnew = new SqlParameter("@NOMBRE", box);
                SqlParameter paramold = new SqlParameter("@OLDNAME", selected);
                this.com.Parameters.Add(paramnew);
                this.com.Parameters.Add(paramold);
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.cn.Open();
                int updated = this.com.ExecuteNonQuery();
                this.cn.Close();
                this.com.Parameters.Clear();
                MessageBox.Show("Se ha actualizado con éxito.");
                this.LoadSalas();
            }
            this.textBox1.Text = "";
        }
    }
}
