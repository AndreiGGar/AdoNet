namespace AdoNet
{
    partial class Form3EliminarEnfermo
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
            this.eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listEnfermos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(98, 110);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(81, 30);
            this.eliminar.TabIndex = 0;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscripción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enfermos";
            // 
            // listEnfermos
            // 
            this.listEnfermos.FormattingEnabled = true;
            this.listEnfermos.ItemHeight = 15;
            this.listEnfermos.Location = new System.Drawing.Point(247, 71);
            this.listEnfermos.Name = "listEnfermos";
            this.listEnfermos.Size = new System.Drawing.Size(331, 184);
            this.listEnfermos.TabIndex = 4;
            // 
            // Form3EliminarEnfermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 320);
            this.Controls.Add(this.listEnfermos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar);
            this.Name = "Form3EliminarEnfermo";
            this.Text = "Form3EliminarEnfermo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button eliminar;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listEnfermos;
    }
}