using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form6AccionDepartamentos : Form
    {
        RepositoryDepartamentos Repo;
        // List<Departamento> Depts;
        public Form6AccionDepartamentos()
        {
            InitializeComponent();
            // Depts = new List<Departamento>();
            Repo = new RepositoryDepartamentos();
            this.getDepts();
        }

        public void getDepts()
        {
            List<Departamento> Depts = new List<Departamento>();
            Depts = Repo.GetDepartamentos();
            this.listDetps.Items.Clear();

            foreach (Departamento dept in Depts)
            {
                this.listDetps.Items.Add(dept.IdDepartamento + " / " + dept.Nombre + " / " + dept.Localidad);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.id.Text);
            string nombre = this.nombre.Text;
            string localidad = this.localidad.Text;
            this.Repo.InsertDept(nombre, localidad);
            this.getDepts();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.id.Text);
            string nombre = this.nombre.Text;
            string localidad = this.localidad.Text;
            this.Repo.UpdateDept(id, nombre, localidad);
            this.getDepts();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.id.Text);
            DialogResult result = MessageBox.Show("¿Confirmar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Repo.DeleteDept(id);
                this.getDepts();
            }
        }

        private void listDetps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listDetps.SelectedIndex != -1)
            {
                /*string selected = this.listDetps.SelectedItem.ToString();
                string[] split = selected.Split(' ');
                string id = split[0];
                string nombre = split[2];
                string localidad = split[4];
                this.id.Text = id;
                this.nombre.Text = nombre;
                this.localidad.Text = localidad;*/
                int idDept = int.Parse(this.listDetps.SelectedItem.ToString());
                Departamento departamento = new Departamento();
                departamento.IdDepartamento = idDept;
                departamento.Nombre = this.nombre.Text;
                departamento.Localidad = this.localidad.Text;
            } else
            {
                this.id.Text = "";
                this.nombre.Text = "";
                this.localidad.Text = "";
            }
        }
    }
}
