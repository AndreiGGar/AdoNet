namespace AdoNet
{
    partial class Form8MensajesServidor
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
            this.id = new System.Windows.Forms.TextBox();
            this.listDepts = new System.Windows.Forms.ListBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(31, 62);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(84, 23);
            this.id.TabIndex = 1;
            // 
            // listDepts
            // 
            this.listDepts.FormattingEnabled = true;
            this.listDepts.ItemHeight = 15;
            this.listDepts.Location = new System.Drawing.Point(269, 62);
            this.listDepts.Name = "listDepts";
            this.listDepts.Size = new System.Drawing.Size(306, 199);
            this.listDepts.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(31, 128);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(158, 23);
            this.nombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(31, 195);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(158, 23);
            this.localidad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localidad";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(71, 241);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(87, 30);
            this.insert.TabIndex = 7;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Departamentos";
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Location = new System.Drawing.Point(31, 307);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(69, 15);
            this.mensaje.TabIndex = 9;
            this.mensaje.Text = "lblMensajes";
            // 
            // Form8MensajesServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 346);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDepts);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "Form8MensajesServidor";
            this.Text = "Form8MensajesServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox id;
        private ListBox listDepts;
        private TextBox nombre;
        private Label label2;
        private TextBox localidad;
        private Label label3;
        private Button insert;
        private Label label4;
        private Label mensaje;
    }
}