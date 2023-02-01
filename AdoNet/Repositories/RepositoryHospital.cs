using AdoNet.Helpers;
using AdoNet.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryHospital()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            List<string> hospitales = new List<string>();
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public DatosHospital GetDatosHospital(string nombre)
        {
            SqlParameter pamnombre = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(pamnombre);
            SqlParameter pamsuma = new SqlParameter("@SUMA", 0);
            pamsuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamsuma);
            SqlParameter pammedia = new SqlParameter("@MEDIA", 0);
            pammedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pammedia);
            SqlParameter pampersonas = new SqlParameter("@PERSONAS", 0);
            pampersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pampersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<EmpleadoHospital> empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                int idempleado = int.Parse(this.reader["IDEMPLEADO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                EmpleadoHospital empleado = new EmpleadoHospital();
                empleado.IdEmpleado = idempleado;
                empleado.Apellido = apellido;
                empleado.Salario = salario;
                empleados.Add(empleado);
            }
            this.reader.Close();
            DatosHospital datos = new DatosHospital();
            datos.Empleados = empleados;
            datos.SumaSalarial = int.Parse(pamsuma.Value.ToString());
            datos.MediaSalarial = int.Parse(pammedia.Value.ToString());
            datos.Personas = int.Parse(pampersonas.Value.ToString());
            this.cn.Close();
            this.com.Parameters.Clear();
            return datos;
        }
    }
}