namespace AdoNet
{
    partial class Form1PrimerAdo
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
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.Button();
            this.listApellidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listColumnas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(57, 45);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(88, 34);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(57, 98);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(88, 34);
            this.desconectar.TabIndex = 1;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // datos
            // 
            this.datos.Location = new System.Drawing.Point(57, 151);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(88, 34);
            this.datos.TabIndex = 2;
            this.datos.Text = "Leer datos";
            this.datos.UseVisualStyleBackColor = true;
            this.datos.Click += new System.EventHandler(this.datos_Click);
            // 
            // listApellidos
            // 
            this.listApellidos.FormattingEnabled = true;
            this.listApellidos.ItemHeight = 15;
            this.listApellidos.Location = new System.Drawing.Point(195, 82);
            this.listApellidos.Name = "listApellidos";
            this.listApellidos.Size = new System.Drawing.Size(164, 244);
            this.listApellidos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columnas";
            // 
            // listColumnas
            // 
            this.listColumnas.FormattingEnabled = true;
            this.listColumnas.ItemHeight = 15;
            this.listColumnas.Location = new System.Drawing.Point(414, 82);
            this.listColumnas.Name = "listColumnas";
            this.listColumnas.Size = new System.Drawing.Size(164, 244);
            this.listColumnas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipos datos";
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.ItemHeight = 15;
            this.listDatos.Location = new System.Drawing.Point(624, 82);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(164, 244);
            this.listDatos.TabIndex = 7;
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Location = new System.Drawing.Point(57, 366);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(51, 15);
            this.mensaje.TabIndex = 9;
            this.mensaje.Text = "Mensaje";
            // 
            // Form1PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 412);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listColumnas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listApellidos);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Name = "Form1PrimerAdo";
            this.Text = "Form1PrimerAdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button conectar;
        private Button desconectar;
        private Button datos;
        private ListBox listApellidos;
        private Label label1;
        private Label label2;
        private ListBox listColumnas;
        private Label label3;
        private ListBox listDatos;
        private Label mensaje;
    }
}