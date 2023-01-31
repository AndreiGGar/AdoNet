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

#region PROCEDURES
/*CREATE PROCEDURE SP_GET_EMPLOYERS_DEPT (@ID INT)
AS
	SELECT * FROM EMP WHERE DEPT_NO = @ID
GO

CREATE PROCEDURE SP_GET_EMPLOYERS_SUM (@ID INT)
AS
	SELECT SUM(SALARIO) AS SUMA FROM EMP WHERE DEPT_NO = @ID
GO

CREATE PROCEDURE SP_GET_EMPLOYERS_AVG (@ID INT)
AS
	SELECT AVG(SALARIO) AS MEDIA FROM EMP WHERE DEPT_NO = @ID
GO

CREATE PROCEDURE SP_GET_EMPLOYERS_PEOPLE (@ID INT)
AS
	SELECT COUNT(*) AS PERSONAS FROM EMP WHERE DEPT_NO = @ID
GO
*/
#endregion

namespace AdoNet
{
    public partial class Form9ParamsSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form9ParamsSalida()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepts();
        }

        public void LoadDepts()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.depts.Items.Clear();
            while (this.reader.Read())
            {
                string id = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                this.depts.Items.Add(id + " / " + nombre + " / " + loc);
            }
            this.reader.Close();
            this.cn.Close();
        }

        public string GetId()
        {
            string selected = this.depts.SelectedItem.ToString();
            string[] split = selected.Split(' ');
            selected = split[0];
            return selected;
        }

        public void GetEmps()
        {
            int id = int.Parse(this.GetId());
            SqlParameter paramid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(paramid);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_GET_EMPLOYERS_DEPT";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.listEmpleados.Items.Add(apellido + " / " + oficio + " / " + salario);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        public void GetSum()
        {
            int id = int.Parse(this.GetId());
            SqlParameter paramid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(paramid);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_GET_EMPLOYERS_SUM";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string suma = this.reader["SUMA"].ToString();
                this.suma.Text = suma;
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void GetAvg()
        {
            int id = int.Parse(this.GetId());
            SqlParameter paramid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(paramid);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_GET_EMPLOYERS_AVG";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string media = this.reader["MEDIA"].ToString();
                this.media.Text = media;
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void GetPeople()
        {
            int id = int.Parse(this.GetId());
            SqlParameter paramid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(paramid);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_GET_EMPLOYERS_PEOPLE";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string personas = this.reader["PERSONAS"].ToString();
                this.personas.Text = personas;
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        private void show_Click(object sender, EventArgs e)
        {
            GetEmps();
            GetSum();
            GetAvg();
            GetPeople();
        }
    }
}
