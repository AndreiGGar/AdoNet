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
    public partial class Form3EliminarEnfermo : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form3EliminarEnfermo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadEnfermos();
        }

        public void LoadEnfermos()
        {
            string sql = "SELECT * FROM ENFERMO";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.listEnfermos.Items.Add(inscripcion + " / " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int inscription = int.Parse(this.textBox1.Text);
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION";
            SqlParameter paminscripcion = new SqlParameter("@INSCRIPCION", inscription);
            /*paminscripcion.ParameterName = "@INSCRIPCION";
            paminscripcion.DbType = DbType.Int32;
            paminscripcion.SqlDbType = SqlDbType.Int;
            paminscripcion.Direction = ParameterDirection.Input;*/
            this.com.Parameters.Add(paminscripcion);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Enfermos eliminados: " + eliminados);
            this.LoadEnfermos();
        }
    }
}
