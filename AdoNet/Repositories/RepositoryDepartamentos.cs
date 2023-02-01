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
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            cn = new SqlConnection(connectionString);
            com = new SqlCommand();
            com.Connection = cn;
        }

        public int InsertDept(string nombre, string localidad)
        {
            int id = GetMaxIdDept();
            string sql = "INSERT INTO DEPT VALUES (@NUM, @NOM, @LOC)";
            SqlParameter paramnum = new SqlParameter("@NUM", id);
            SqlParameter paramnom = new SqlParameter("@NOM", nombre);
            SqlParameter paramloc = new SqlParameter("@LOC", localidad);
            com.Parameters.Add(paramnum);
            com.Parameters.Add(paramnom);
            com.Parameters.Add(paramloc);
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            cn.Open();
            int inserted = com.ExecuteNonQuery();
            cn.Close();
            com.Parameters.Clear();
            return inserted;
        }
        public int UpdateDept(int id, string nombre, string localidad)
        {
            string sql = "UPDATE DEPT SET DNOMBRE=@NOMBRE, LOC=@LOCALIDAD WHERE DEPT_NO=@ID";
            SqlParameter paramid = new SqlParameter("@ID", id);
            SqlParameter paramnom = new SqlParameter("@NOMBRE", nombre);
            SqlParameter paramloc = new SqlParameter("@LOCALIDAD", localidad);
            com.Parameters.Add(paramid);
            com.Parameters.Add(paramnom);
            com.Parameters.Add(paramloc);
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            cn.Open();
            int updated = com.ExecuteNonQuery();
            cn.Close();
            com.Parameters.Clear();
            return updated;
        }

        public int DeleteDept(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@ID";
            SqlParameter paramid = new SqlParameter("@ID", id);
            com.Parameters.Add(paramid);
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            cn.Open();
            int deleted = com.ExecuteNonQuery();
            cn.Close();
            com.Parameters.Clear();
            return deleted;
        }

        private int GetMaxIdDept()
        {
            string sql = "SELECT MAX(DEPT_NO) +1 AS MAX FROM DEPT";
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            cn.Open();
            int max = Convert.ToInt32(com.ExecuteScalar());
            cn.Close();
            return max;
        }

        public List<Departamento> GetDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";
            List<Departamento> departamentos = new List<Departamento>();
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            cn.Open();
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["DEPT_NO"].ToString());
                string nombre = reader["DNOMBRE"].ToString();
                string localidad = reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                departamentos.Add(dept);
            }
            reader.Close();
            cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int id)
        {
            string sql = "SELECT * FROM DEPT WHERE DEPT_NO=@NUMERO";
            SqlParameter paramid = new SqlParameter("@ID", id);
            com.Parameters.Add(paramid);
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            cn.Open();
            reader = com.ExecuteReader();
            reader.Read();
            Departamento dept = new Departamento();
            dept.IdDepartamento = int.Parse(reader["DEPT_NO"].ToString());
            dept.Nombre = reader["DNOMBRE"].ToString();
            dept.Localidad = reader["LOC"].ToString();
            reader.Close();
            cn.Close();
            return dept;
        }
    }
}
