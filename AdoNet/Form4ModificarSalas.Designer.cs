namespace AdoNet
{
    partial class Form4ModificarSalas
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
            this.listSalas = new System.Windows.Forms.ListBox();
            this.update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // listSalas
            // 
            this.listSalas.FormattingEnabled = true;
            this.listSalas.ItemHeight = 15;
            this.listSalas.Location = new System.Drawing.Point(40, 70);
            this.listSalas.Name = "listSalas";
            this.listSalas.Size = new System.Drawing.Size(228, 229);
            this.listSalas.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(354, 201);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(105, 34);
            this.update.TabIndex = 2;
            this.update.Text = "Modificar Salas";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 4;
            // 
            // Form4ModificarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 359);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.listSalas);
            this.Controls.Add(this.label1);
            this.Name = "Form4ModificarSalas";
            this.Text = "Form4ModificarSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listSalas;
        private Button update;
        private Label label2;
        private TextBox textBox1;
    }
}