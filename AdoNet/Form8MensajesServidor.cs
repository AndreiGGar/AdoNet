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

#region PROCEDURE
/*CREATE PROCEDURE SP_DEPARTAMENTOS 
AS
	SELECT * FROM DEPT
GO

CREATE PROCEDURE SP_INSERT_DEPARTAMENTO(@ID INT = 1000, @NOMBRE NVARCHAR(50), @LOCALIDAD NVARCHAR(50))
AS
    INSERT INTO DEPT VALUES(@ID, @NOMBRE, @LOCALIDAD)
	PRINT 'DEPARTAMENTO INSERTADO EXITOSAMENTE'
GO*/
#endregion

namespace AdoNet
{
    public partial class Form8MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form8MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.cn.InfoMessage += Cn_InfoMessage;
            this.LoadDepts();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.mensaje.Text = e.Message;
        }

        public void LoadDepts()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.listDepts.Items.Clear();
            while (this.reader.Read())
            {
                string dept = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["DNOMBRE"].ToString();
                this.listDepts.Items.Add(dept + " / " + nombre + " / " + loc);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            this.mensaje.Text = "";
            int id = int.Parse(this.id.Text);
            string nombre = this.nombre.Text;
            string loc = this.localidad.Text;
            SqlParameter paramid = new SqlParameter("@ID", id);
            SqlParameter paramnombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter paramloc = new SqlParameter("@LOCALIDAD", loc);
            this.com.Parameters.Add(paramid);
            this.com.Parameters.Add(paramnombre);
            this.com.Parameters.Add(paramloc);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.cn.Open();
            int inserted = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Se ha insertado con éxito el registro: " + id);
            this.LoadDepts();
            this.id.Text = "";
            this.nombre.Text = "";
            this.localidad.Text = "";
        }
    }
}
