namespace AdoNet
{
    partial class Form2BuscadorEmpleados
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
            this.buscar = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oficio = new System.Windows.Forms.TextBox();
            this.buscar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(255, 41);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(150, 36);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(29, 49);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(203, 23);
            this.text.TabIndex = 2;
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(29, 200);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(337, 199);
            this.listEmpleados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oficio";
            // 
            // oficio
            // 
            this.oficio.Location = new System.Drawing.Point(29, 108);
            this.oficio.Name = "oficio";
            this.oficio.Size = new System.Drawing.Size(203, 23);
            this.oficio.TabIndex = 6;
            // 
            // buscar2
            // 
            this.buscar2.Location = new System.Drawing.Point(255, 100);
            this.buscar2.Name = "buscar2";
            this.buscar2.Size = new System.Drawing.Size(150, 36);
            this.buscar2.TabIndex = 7;
            this.buscar2.Text = "Buscar";
            this.buscar2.UseVisualStyleBackColor = true;
            this.buscar2.Click += new System.EventHandler(this.buscar2_Click);
            // 
            // Form2BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 474);
            this.Controls.Add(this.buscar2);
            this.Controls.Add(this.oficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.text);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label1);
            this.Name = "Form2BuscadorEmpleados";
            this.Text = "Form2BuscadorEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buscar;
        private TextBox text;
        private ListBox listEmpleados;
        private Label label2;
        private Label label3;
        private TextBox oficio;
        private Button buscar2;
    }
}