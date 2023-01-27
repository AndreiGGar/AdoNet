namespace AdoNet
{
    partial class Form5DepartamentosEmp
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
            this.listDepts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listEmps = new System.Windows.Forms.ListBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oficio = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // listDepts
            // 
            this.listDepts.FormattingEnabled = true;
            this.listDepts.ItemHeight = 15;
            this.listDepts.Location = new System.Drawing.Point(33, 65);
            this.listDepts.Name = "listDepts";
            this.listDepts.Size = new System.Drawing.Size(162, 199);
            this.listDepts.TabIndex = 1;
            this.listDepts.SelectedIndexChanged += new System.EventHandler(this.listDepts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados";
            // 
            // listEmps
            // 
            this.listEmps.FormattingEnabled = true;
            this.listEmps.ItemHeight = 15;
            this.listEmps.Location = new System.Drawing.Point(247, 65);
            this.listEmps.Name = "listEmps";
            this.listEmps.Size = new System.Drawing.Size(162, 289);
            this.listEmps.TabIndex = 3;
            this.listEmps.SelectedIndexChanged += new System.EventHandler(this.listEmps_SelectedIndexChanged);
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(468, 65);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(100, 23);
            this.salario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oficio";
            // 
            // oficio
            // 
            this.oficio.Location = new System.Drawing.Point(468, 139);
            this.oficio.Name = "oficio";
            this.oficio.Size = new System.Drawing.Size(100, 23);
            this.oficio.TabIndex = 7;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(468, 205);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 48);
            this.update.TabIndex = 8;
            this.update.Text = "Modificar empleado";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form5DepartamentosEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 401);
            this.Controls.Add(this.update);
            this.Controls.Add(this.oficio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.listEmps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDepts);
            this.Controls.Add(this.label1);
            this.Name = "Form5DepartamentosEmp";
            this.Text = "Form5DepartamentosEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listDepts;
        private Label label2;
        private ListBox listEmps;
        private TextBox salario;
        private Label label3;
        private Label label4;
        private TextBox oficio;
        private Button update;
    }
}