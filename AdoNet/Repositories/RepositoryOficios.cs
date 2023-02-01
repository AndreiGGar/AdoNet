using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryOficios
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryOficios()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetOficios()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_OFICIOS";
            List<string> oficios = new List<string>();
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["OFICIO"].ToString();
                oficios.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public DatosOficios GetDatosOficio(string nombre, int incremento = 0, int delete = 0)
        {
            SqlParameter pamnombre = new SqlParameter("@OFICIO", nombre);
            this.com.Parameters.Add(pamnombre);
            SqlParameter pamincremento = new SqlParameter("@SALARIO", incremento);
            this.com.Parameters.Add(pamincremento);
            SqlParameter pamdelete = new SqlParameter("@DELETE", delete);
            this.com.Parameters.Add(pamdelete);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_OFICIO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<EmpleadosOficio> empleados = new List<EmpleadosOficio>();
            while (this.reader.Read())
            {
                int idempleado = int.Parse(this.reader["EMP_NO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                string oficio = this.reader["OFICIO"].ToString();
                EmpleadosOficio empleado = new EmpleadosOficio();
                empleado.IdEmpleado = idempleado;
                empleado.Apellido = apellido;
                empleado.Salario = salario;
                empleado.Oficio = oficio;
                empleados.Add(empleado);
            }
            this.reader.Close();
            DatosOficios datos = new DatosOficios();
            datos.Empleados = empleados;
            this.cn.Close();
            this.com.Parameters.Clear();
            return datos;
        }
    }
}