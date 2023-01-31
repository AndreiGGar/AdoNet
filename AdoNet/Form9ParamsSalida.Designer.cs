namespace AdoNet
{
    partial class Form9ParamsSalida
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
            this.depts = new System.Windows.Forms.ComboBox();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.TextBox();
            this.personas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // depts
            // 
            this.depts.FormattingEnabled = true;
            this.depts.Location = new System.Drawing.Point(37, 52);
            this.depts.Name = "depts";
            this.depts.Size = new System.Drawing.Size(169, 23);
            this.depts.TabIndex = 0;
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(247, 52);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(176, 199);
            this.listEmpleados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamentos";
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(101, 155);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(105, 23);
            this.suma.TabIndex = 3;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(37, 99);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(169, 31);
            this.show.TabIndex = 4;
            this.show.Text = "Mostrar datos";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suma: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Media:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personas:";
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(101, 192);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(105, 23);
            this.media.TabIndex = 9;
            // 
            // personas
            // 
            this.personas.Location = new System.Drawing.Point(100, 228);
            this.personas.Name = "personas";
            this.personas.Size = new System.Drawing.Size(105, 23);
            this.personas.TabIndex = 10;
            // 
            // Form9ParamsSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 311);
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
            this.Controls.Add(this.depts);
            this.Name = "Form9ParamsSalida";
            this.Text = "Form9ParamsSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox depts;
        private ListBox listEmpleados;
        private Label label1;
        private TextBox suma;
        private Button show;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox media;
        private TextBox personas;
    }
}