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
    public partial class Form11EmpleadosOficios : Form
    {
        private RepositoryOficios repo;
        public Form11EmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryOficios();
            this.LoadOficios();
        }

        public void LoadOficios()
        {
            List<string> oficios = this.repo.GetOficios();
            foreach (string oficio in oficios)
            {
                this.oficios.Items.Add(oficio);
            }
        }

        private void LoadEmpleados()
        {
            string nombreOficio = this.oficios.SelectedItem.ToString();
            DatosOficios datos = this.repo.GetDatosOficio(nombreOficio);
            this.listEmpleados.Items.Clear();
            foreach (EmpleadosOficio empleadoOficio in datos.Empleados)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = empleadoOficio.Apellido;
                lv.SubItems.Add(empleadoOficio.Oficio);
                lv.SubItems.Add(empleadoOficio.Salario.ToString());
                lv.SubItems.Add(empleadoOficio.IdEmpleado.ToString()); //CUARTA COLUMN, SUBITEM 3
                this.listEmpleados.Items.Add(lv);
            }
        }

        private void oficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (this.oficios.SelectedIndex != -1)
            {
                string nombreOficio = this.oficios.SelectedItem.ToString();
                DatosOficios datos = this.repo.GetDatosOficio(nombreOficio);
                this.listEmpleados.Items.Clear();
                foreach (EmpleadosOficio empleadoOficio in datos.Empleados)
                {
                    MessageBox.Show(empleadoOficio.IdEmpleado.ToString());
                }
            }*/
        }

        private void listEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listEmpleados.SelectedItems.Count != 0)
            {
                string nombreOficio = this.oficios.SelectedItem.ToString();
                ListViewItem it = this.listEmpleados.SelectedItems[0];
                string idEmpleado = it.SubItems[3].Text;
                // MessageBox.Show(idEmpleado.ToString());
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (this.oficios.SelectedIndex != -1)
            {
                this.LoadEmpleados();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (this.listEmpleados.SelectedItems.Count != 0)
            {
                string nombreOficio = this.oficios.SelectedItem.ToString();
                ListViewItem it = this.listEmpleados.SelectedItems[0];
                string idEmpleado = it.SubItems[3].Text;
                DatosOficios datos = this.repo.GetDatosOficio(nombreOficio, 0, int.Parse(idEmpleado));
                MessageBox.Show("Borrado el empleado " + idEmpleado);
                this.LoadEmpleados();
            }
        }

        private void incrementar_Click(object sender, EventArgs e)
        {
            if (this.oficios.SelectedIndex != -1)
            {
                string nombreOficio = this.oficios.SelectedItem.ToString();
                string incremento = this.incremento.Text;
                DatosOficios datos = this.repo.GetDatosOficio(nombreOficio, int.Parse(incremento));
                MessageBox.Show("Sumado al salario " + incremento);
                this.LoadEmpleados();
            }
        }
    }
}
