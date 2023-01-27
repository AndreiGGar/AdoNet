namespace AdoNet
{
    partial class Form6AccionDepartamentos
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
            this.listDetps = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDetps
            // 
            this.listDetps.FormattingEnabled = true;
            this.listDetps.ItemHeight = 15;
            this.listDetps.Location = new System.Drawing.Point(47, 63);
            this.listDetps.Name = "listDetps";
            this.listDetps.Size = new System.Drawing.Size(224, 289);
            this.listDetps.TabIndex = 0;
            this.listDetps.SelectedIndexChanged += new System.EventHandler(this.listDetps_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Localidad";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(336, 51);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(58, 23);
            this.id.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(336, 118);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(131, 23);
            this.nombre.TabIndex = 6;
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(336, 178);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(131, 23);
            this.localidad.TabIndex = 7;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(336, 221);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(131, 35);
            this.insert.TabIndex = 8;
            this.insert.Text = "Nuevo Dept";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(336, 271);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(131, 35);
            this.edit.TabIndex = 9;
            this.edit.Text = "Edit Dept";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(336, 317);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(131, 35);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete Dept";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form6AccionDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 397);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDetps);
            this.Name = "Form6AccionDepartamentos";
            this.Text = "Form6AccionDepartamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listDetps;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox id;
        private TextBox nombre;
        private TextBox localidad;
        private Button insert;
        private Button edit;
        private Button delete;
    }
}