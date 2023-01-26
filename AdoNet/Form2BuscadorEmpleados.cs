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
    public partial class Form2BuscadorEmpleados : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form2BuscadorEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.text.Text);
            string sql = "SELECT * FROM EMP WHERE SALARIO >= " + salario;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while(this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.listEmpleados.Items.Add(apellido + " / " + sal);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void buscar2_Click(object sender, EventArgs e)
        {
            string oficio = this.oficio.Text;
            string sql = "SELECT * FROM EMP WHERE OFICIO='" + oficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.listEmpleados.Items.Add(apellido + " / " + sal);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
