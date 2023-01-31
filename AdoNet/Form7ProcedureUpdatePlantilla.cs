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
/*CREATE PROCEDURE SP_UPDATESALARIOSHOSPITAL(@NOMBRE NVARCHAR(50)) AS

	DECLARE @HOSPITALCOD INT
	DECLARE @SALARIO INT
	SELECT @HOSPITALCOD = HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE = @NOMBRE
	SELECT @SALARIO = SUM(CAST(SALARIO AS INT)) FROM PLANTILLA WHERE HOSPITAL_COD = @HOSPITALCOD

	IF (@SALARIO < 1000000)
	BEGIN
		UPDATE PLANTILLA SET SALARIO += 10000 WHERE HOSPITAL_COD = @HOSPITALCOD
		PRINT 'SUBE EL SUELDO: ' + CAST(@SALARIO AS NVARCHAR)
	END
	ELSE IF(@SALARIO > 1000000)
	BEGIN
		UPDATE PLANTILLA SET SALARIO -= 10000 WHERE HOSPITAL_COD = @HOSPITALCOD
		PRINT 'BAJA EL SUELDO: ' + CAST(@SALARIO AS NVARCHAR)
	END
	ELSE
	BEGIN
		PRINT 'SALARIO SIN MODIFICACIONES'
	END
	SELECT * FROM PLANTILLA WHERE HOSPITAL_COD = @HOSPITALCOD

GO

EXEC SP_UPDATESALARIOSHOSPITAL 'LA PAZ'*/
#endregion

namespace AdoNet
{
    public partial class Form7ProcedureUpdatePlantilla : Form
    {
		SqlConnection cn;
		SqlCommand com;
		SqlDataReader reader;
		public Form7ProcedureUpdatePlantilla()
        {
            InitializeComponent();
			string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;User ID=sa;Password=";
			this.cn = new SqlConnection(connectionString);
			this.com = new SqlCommand();
			this.com.Connection = this.cn;
			this.LoadHospitals();
		}

		public void LoadHospitals()
		{
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = "SP_HOSPITALES";
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			this.hospitals.Items.Clear();
			while (this.reader.Read())
			{
				string nombre = this.reader["NOMBRE"].ToString();
				this.hospitals.Items.Add(nombre);
			}
			this.reader.Close();
			this.cn.Close();
		}

        private void update_Click(object sender, EventArgs e)
        {
			string nombre = this.hospitals.SelectedItem.ToString();
			SqlParameter paramnombre = new SqlParameter("@NOMBRE", nombre);
			this.com.Parameters.Add(paramnombre);
			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = "SP_UPDATESALARIOSHOSPITAL";
			this.cn.Open();
			this.reader = this.com.ExecuteReader();
			this.listPlantilla.Items.Clear();
			while (this.reader.Read())
            {
				string apellido = this.reader["APELLIDO"].ToString();
				string funcion = this.reader["FUNCION"].ToString();
				string salario = this.reader["SALARIO"].ToString();
				this.listPlantilla.Items.Add(apellido + ", " + funcion + ", " + salario);
			}
			this.reader.Close();
			this.cn.Close();
			this.com.Parameters.Clear();
		}
    }
}
