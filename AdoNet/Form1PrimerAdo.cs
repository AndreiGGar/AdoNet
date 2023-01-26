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
    public partial class Form1PrimerAdo : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form1PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.mensaje.Text = "La conexión está cambiando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.mensaje.BackColor = Color.LightGreen;
            }
            catch (Exception ex) { 
                this.mensaje.Text = "Error al conectar con BBDD " + ex;
            }
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.mensaje.BackColor = Color.LightCoral;
        }

        private void datos_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM EMP";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.reader = this.com.ExecuteReader();
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipo = this.reader.GetDataTypeName(i);
                this.listColumnas.Items.Add(columna);
                this.listDatos.Items.Add(tipo);
            }
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.listApellidos.Items.Add(apellido);
            }
            this.reader.Close();
        }
    }
}
