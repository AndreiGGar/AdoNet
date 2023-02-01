using AdoNet.Models;
using AdoNet.Repositories;
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
    public partial class Form10HospitalEmpleados : Form
    {
        private RepositoryHospital repo;
        public Form10HospitalEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            this.LoadHospitals();
        }

        public void LoadHospitals()
        {
            List<string> hospitales = this.repo.GetHospitales();
            foreach (string hospital in hospitales)
            {
                this.hospitals.Items.Add(hospital);
            }
        }

        private void hospitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.hospitals.SelectedIndex != -1)
            {
                string nombreHospital = this.hospitals.SelectedItem.ToString();
                DatosHospital datos = this.repo.GetDatosHospital(nombreHospital);
                this.listEmpleados.Items.Clear();
                foreach (EmpleadoHospital empleadoHospital in datos.Empleados)
                {
                    this.listEmpleados.Items.Add(empleadoHospital.Apellido + " / " + empleadoHospital.Salario);
                }
                this.suma.Text = datos.SumaSalarial.ToString();
                this.media.Text = datos.MediaSalarial.ToString();
                this.personas.Text = datos.Personas.ToString();
            }
        }
    }
}
