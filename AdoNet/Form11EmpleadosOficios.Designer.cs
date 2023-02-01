namespace AdoNet
{
    partial class Form11EmpleadosOficios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.oficios = new System.Windows.Forms.ComboBox();
            this.incremento = new System.Windows.Forms.TextBox();
            this.listEmpleados = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.show = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.incrementar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // oficios
            // 
            this.oficios.FormattingEnabled = true;
            this.oficios.Location = new System.Drawing.Point(30, 54);
            this.oficios.Name = "oficios";
            this.oficios.Size = new System.Drawing.Size(154, 23);
            this.oficios.TabIndex = 1;
            this.oficios.SelectedIndexChanged += new System.EventHandler(this.oficios_SelectedIndexChanged);
            // 
            // incremento
            // 
            this.incremento.Location = new System.Drawing.Point(377, 51);
            this.incremento.Name = "incremento";
            this.incremento.Size = new System.Drawing.Size(122, 23);
            this.incremento.TabIndex = 2;
            // 
            // listEmpleados
            // 
            this.listEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listEmpleados.FullRowSelect = true;
            this.listEmpleados.Location = new System.Drawing.Point(30, 172);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(469, 170);
            this.listEmpleados.TabIndex = 3;
            this.listEmpleados.UseCompatibleStateImageBehavior = false;
            this.listEmpleados.View = System.Windows.Forms.View.Details;
            this.listEmpleados.SelectedIndexChanged += new System.EventHandler(this.listEmpleados_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellido";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oficio";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salario";
            this.columnHeader3.Width = 150;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(216, 27);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(111, 34);
            this.show.TabIndex = 4;
            this.show.Text = "Mostrar";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(216, 74);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 34);
            this.delete.TabIndex = 5;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incremento:";
            // 
            // incrementar
            // 
            this.incrementar.Location = new System.Drawing.Point(388, 80);
            this.incrementar.Name = "incrementar";
            this.incrementar.Size = new System.Drawing.Size(99, 23);
            this.incrementar.TabIndex = 7;
            this.incrementar.Text = "Incrementar";
            this.incrementar.UseVisualStyleBackColor = true;
            this.incrementar.Click += new System.EventHandler(this.incrementar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Empleados";
            // 
            // Form11EmpleadosOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.incrementar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.show);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.incremento);
            this.Controls.Add(this.oficios);
            this.Controls.Add(this.label1);
            this.Name = "Form11EmpleadosOficios";
            this.Text = "Form11EmpleadosOficios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox oficios;
        private TextBox incremento;
        private ListView listEmpleados;
        private Button show;
        private Button delete;
        private Label label2;
        private Button incrementar;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}