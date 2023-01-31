namespace AdoNet
{
    partial class Form10HospitalEmpleados
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
            this.personas = new System.Windows.Forms.TextBox();
            this.media = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.hospitals = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // personas
            // 
            this.personas.Location = new System.Drawing.Point(103, 232);
            this.personas.Name = "personas";
            this.personas.Size = new System.Drawing.Size(105, 23);
            this.personas.TabIndex = 21;
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(104, 196);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(105, 23);
            this.media.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Personas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Suma: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Empleados";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(40, 103);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(169, 31);
            this.show.TabIndex = 15;
            this.show.Text = "Mostrar datos";
            this.show.UseVisualStyleBackColor = true;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(104, 159);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(105, 23);
            this.suma.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hospitales";
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(250, 56);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(176, 199);
            this.listEmpleados.TabIndex = 12;
            // 
            // hospitals
            // 
            this.hospitals.FormattingEnabled = true;
            this.hospitals.Location = new System.Drawing.Point(40, 56);
            this.hospitals.Name = "hospitals";
            this.hospitals.Size = new System.Drawing.Size(169, 23);
            this.hospitals.TabIndex = 11;
            // 
            // Form10HospitalEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 297);
            this.Controls.Add(this.personas);
            this.Controls.Add(this.media);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.hospitals);
            this.Name = "Form10HospitalEmpleados";
            this.Text = "Form10HospitalEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox personas;
        private TextBox media;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button show;
        private TextBox suma;
        private Label label1;
        private ListBox listEmpleados;
        private ComboBox hospitals;
    }
}