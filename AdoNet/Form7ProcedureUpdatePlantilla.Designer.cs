namespace AdoNet
{
    partial class Form7ProcedureUpdatePlantilla
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
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hospitals = new System.Windows.Forms.ComboBox();
            this.listPlantilla = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(258, 46);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 33);
            this.update.TabIndex = 0;
            this.update.Text = "Modificar salarios";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospitales";
            // 
            // hospitals
            // 
            this.hospitals.FormattingEnabled = true;
            this.hospitals.Location = new System.Drawing.Point(39, 56);
            this.hospitals.Name = "hospitals";
            this.hospitals.Size = new System.Drawing.Size(173, 23);
            this.hospitals.TabIndex = 2;
            // 
            // listPlantilla
            // 
            this.listPlantilla.FormattingEnabled = true;
            this.listPlantilla.ItemHeight = 15;
            this.listPlantilla.Location = new System.Drawing.Point(39, 142);
            this.listPlantilla.Name = "listPlantilla";
            this.listPlantilla.Size = new System.Drawing.Size(327, 229);
            this.listPlantilla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plantilla";
            // 
            // Form7ProcedureUpdatePlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPlantilla);
            this.Controls.Add(this.hospitals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Name = "Form7ProcedureUpdatePlantilla";
            this.Text = "Form7ProcedureUpdatePlantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button update;
        private Label label1;
        private ComboBox hospitals;
        private ListBox listPlantilla;
        private Label label2;
    }
}