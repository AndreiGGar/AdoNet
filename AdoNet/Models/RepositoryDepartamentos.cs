using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public int InsertDept(string nombre, string localidad)
        {
            int id = this.GetMaxIdDept();
            string sql = "INSERT INTO DEPT VALUES (@NUM, @NOM, @LOC)";
            SqlParameter paramnum = new SqlParameter("@NUM", id);
            SqlParameter paramnom = new SqlParameter("@NOM", nombre);
            SqlParameter paramloc = new SqlParameter("@LOC", localidad);
            this.com.Parameters.Add(paramnum);
            this.com.Parameters.Add(paramnom);
            this.com.Parameters.Add(paramloc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int inserted = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return inserted;
        }
        public int UpdateDept(int id, string nombre, string localidad)
        {
            string sql = "UPDATE DEPT SET DNOMBRE=@NOMBRE, LOC=@LOCALIDAD WHERE DEPT_NO=@ID";
            SqlParameter paramid = new SqlParameter("@ID", id);
            SqlParameter paramnom = new SqlParameter("@NOMBRE", nombre);
            SqlParameter paramloc = new SqlParameter("@LOCALIDAD", localidad);
            this.com.Parameters.Add(paramid);
            this.com.Parameters.Add(paramnom);
            this.com.Parameters.Add(paramloc);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int updated = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return updated;
        }

        public int DeleteDept(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@ID";
            SqlParameter paramid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(paramid);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int deleted = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return deleted;
        }

        private int GetMaxIdDept()
        {
            string sql = "SELECT MAX(DEPT_NO) +1 AS MAX FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int max = Convert.ToInt32(this.com.ExecuteScalar());
            this.cn.Close();
            return max;
        }

        public List<Departamento> GetDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";
            List<Departamento> departamentos = new List<Departamento>();
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int id)
        {
            string sql = "SELECT * FROM DEPT WHERE DEPT_NO=@NUMERO";
            SqlParameter paramid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(paramid);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            Departamento dept = new Departamento();
            dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
            dept.Nombre = this.reader["DNOMBRE"].ToString();
            dept.Localidad = this.reader["LOC"].ToString();
            this.reader.Close();
            this.cn.Close();
            return dept;
        }
    }
}
