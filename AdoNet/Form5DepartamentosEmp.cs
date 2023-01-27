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
    public partial class Form5DepartamentosEmp : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form5DepartamentosEmp()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepts();
        }

        public void LoadDepts()
        {
            string sql = "SELECT DNOMBRE FROM DEPT GROUP BY DNOMBRE";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listDepts.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.listDepts.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        public void LoadEmps(string dept)
        {
            string sql = "SELECT b.APELLIDO, b.SALARIO, b.OFICIO FROM DEPT a INNER JOIN EMP b ON a.DEPT_NO = b.DEPT_NO WHERE DNOMBRE = @NOMBREDEPT";
            SqlParameter param = new SqlParameter("@NOMBREDEPT", dept);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(param);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmps.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                this.listEmps.Items.Add(nombre + " | " + salario + " | " + oficio);
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.salario.Text);
            string oficio = this.oficio.Text;
            string selected = this.listEmps.SelectedItem.ToString();
            string[] split = selected.Split(' ');
            if (split.Length > 0)
            {
                for (int i = 0; i < split.Length; i++)
                {
                    selected = split[i].ToString();
                    break;
                }
            }
            if (this.salario.Text != "" && oficio != "")
            {
                string sql = "UPDATE EMP SET SALARIO=@SALARIO, OFICIO=@OFICIO WHERE APELLIDO=@OLDAPELLIDO";
                SqlParameter paramsalario = new SqlParameter("@SALARIO", salario);
                SqlParameter paramoficio = new SqlParameter("@OFICIO", oficio);
                SqlParameter paramname = new SqlParameter("@OLDAPELLIDO", selected);
                this.com.Parameters.Add(paramsalario);
                this.com.Parameters.Add(paramoficio);
                this.com.Parameters.Add(paramname);
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.cn.Open();
                int updated = this.com.ExecuteNonQuery();
                this.cn.Close();
                this.com.Parameters.Clear();
                MessageBox.Show("Se ha actualizado con éxito el registro de: " + selected);
                this.LoadEmps(this.listDepts.SelectedItem.ToString());
            }
            this.salario.Text = "";
            this.oficio.Text = "";
        }

        private void listDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listDepts.SelectedIndex != -1)
            {
                this.LoadEmps(this.listDepts.SelectedItem.ToString());
            }
        }

        private void listEmps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listEmps.SelectedIndex != -1)
            {
                string selected = this.listEmps.SelectedItem.ToString();
                string[] split = selected.Split(' ');
                selected = split[2];
                string selected2 = split[4];
                this.salario.Text = selected;
                this.oficio.Text = selected2;
            }
        }
    }
}
