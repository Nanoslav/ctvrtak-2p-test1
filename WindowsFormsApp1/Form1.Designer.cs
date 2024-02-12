namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxCars = new System.Windows.Forms.GroupBox();
            this.radioButtonCar3 = new System.Windows.Forms.RadioButton();
            this.radioButtonCar2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCar1 = new System.Windows.Forms.RadioButton();
            this.groupBoxPackets = new System.Windows.Forms.GroupBox();
            this.checkBoxPacket3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPacket2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPacket1 = new System.Windows.Forms.CheckBox();
            this.labelPaket1 = new System.Windows.Forms.Label();
            this.labelPaket2 = new System.Windows.Forms.Label();
            this.labelPaket3 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelSuma = new System.Windows.Forms.Label();
            this.groupBoxCars.SuspendLayout();
            this.groupBoxPackets.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCars
            // 
            this.groupBoxCars.Controls.Add(this.radioButtonCar3);
            this.groupBoxCars.Controls.Add(this.radioButtonCar2);
            this.groupBoxCars.Controls.Add(this.radioButtonCar1);
            this.groupBoxCars.Location = new System.Drawing.Point(62, 48);
            this.groupBoxCars.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxCars.Name = "groupBoxCars";
            this.groupBoxCars.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxCars.Size = new System.Drawing.Size(466, 231);
            this.groupBoxCars.TabIndex = 0;
            this.groupBoxCars.TabStop = false;
            this.groupBoxCars.Text = "Výběr vozidla";
            // 
            // radioButtonCar3
            // 
            this.radioButtonCar3.AutoSize = true;
            this.radioButtonCar3.Location = new System.Drawing.Point(34, 127);
            this.radioButtonCar3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonCar3.Name = "radioButtonCar3";
            this.radioButtonCar3.Size = new System.Drawing.Size(197, 29);
            this.radioButtonCar3.TabIndex = 2;
            this.radioButtonCar3.TabStop = true;
            this.radioButtonCar3.Tag = "300000";
            this.radioButtonCar3.Text = "Auto 3 (300000)";
            this.radioButtonCar3.UseVisualStyleBackColor = true;
            this.radioButtonCar3.CheckedChanged += new System.EventHandler(this.radioButtonCar3_CheckedChanged);
            // 
            // radioButtonCar2
            // 
            this.radioButtonCar2.AutoSize = true;
            this.radioButtonCar2.Location = new System.Drawing.Point(34, 83);
            this.radioButtonCar2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonCar2.Name = "radioButtonCar2";
            this.radioButtonCar2.Size = new System.Drawing.Size(197, 29);
            this.radioButtonCar2.TabIndex = 1;
            this.radioButtonCar2.TabStop = true;
            this.radioButtonCar2.Tag = "200000";
            this.radioButtonCar2.Text = "Auto 2 (200000)";
            this.radioButtonCar2.UseVisualStyleBackColor = true;
            this.radioButtonCar2.CheckedChanged += new System.EventHandler(this.radioButtonCar2_CheckedChanged);
            // 
            // radioButtonCar1
            // 
            this.radioButtonCar1.AutoSize = true;
            this.radioButtonCar1.Location = new System.Drawing.Point(34, 38);
            this.radioButtonCar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonCar1.Name = "radioButtonCar1";
            this.radioButtonCar1.Size = new System.Drawing.Size(197, 29);
            this.radioButtonCar1.TabIndex = 0;
            this.radioButtonCar1.TabStop = true;
            this.radioButtonCar1.Tag = "100000";
            this.radioButtonCar1.Text = "Auto 1 (100000)";
            this.radioButtonCar1.UseVisualStyleBackColor = true;
            this.radioButtonCar1.CheckedChanged += new System.EventHandler(this.radioButtonCar1_CheckedChanged);
            // 
            // groupBoxPackets
            // 
            this.groupBoxPackets.Controls.Add(this.checkBoxPacket3);
            this.groupBoxPackets.Controls.Add(this.checkBoxPacket2);
            this.groupBoxPackets.Controls.Add(this.checkBoxPacket1);
            this.groupBoxPackets.Location = new System.Drawing.Point(832, 48);
            this.groupBoxPackets.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxPackets.Name = "groupBoxPackets";
            this.groupBoxPackets.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxPackets.Size = new System.Drawing.Size(466, 231);
            this.groupBoxPackets.TabIndex = 1;
            this.groupBoxPackets.TabStop = false;
            this.groupBoxPackets.Text = "Doplňková výbava";
            // 
            // checkBoxPacket3
            // 
            this.checkBoxPacket3.AutoSize = true;
            this.checkBoxPacket3.Location = new System.Drawing.Point(34, 127);
            this.checkBoxPacket3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxPacket3.Name = "checkBoxPacket3";
            this.checkBoxPacket3.Size = new System.Drawing.Size(185, 29);
            this.checkBoxPacket3.TabIndex = 2;
            this.checkBoxPacket3.Tag = "3000";
            this.checkBoxPacket3.Text = "Paket 3 (3000)";
            this.checkBoxPacket3.UseVisualStyleBackColor = true;
            this.checkBoxPacket3.CheckedChanged += new System.EventHandler(this.checkBoxPacket3_CheckedChanged);
            // 
            // checkBoxPacket2
            // 
            this.checkBoxPacket2.AutoSize = true;
            this.checkBoxPacket2.Location = new System.Drawing.Point(34, 85);
            this.checkBoxPacket2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxPacket2.Name = "checkBoxPacket2";
            this.checkBoxPacket2.Size = new System.Drawing.Size(185, 29);
            this.checkBoxPacket2.TabIndex = 1;
            this.checkBoxPacket2.Tag = "2000";
            this.checkBoxPacket2.Text = "Paket 2 (2000)";
            this.checkBoxPacket2.UseVisualStyleBackColor = true;
            this.checkBoxPacket2.CheckedChanged += new System.EventHandler(this.checkBoxPacket2_CheckedChanged);
            // 
            // checkBoxPacket1
            // 
            this.checkBoxPacket1.AutoSize = true;
            this.checkBoxPacket1.Location = new System.Drawing.Point(34, 38);
            this.checkBoxPacket1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxPacket1.Name = "checkBoxPacket1";
            this.checkBoxPacket1.Size = new System.Drawing.Size(185, 29);
            this.checkBoxPacket1.TabIndex = 0;
            this.checkBoxPacket1.Tag = "1000";
            this.checkBoxPacket1.Text = "Paket 1 (1000)";
            this.checkBoxPacket1.UseVisualStyleBackColor = true;
            this.checkBoxPacket1.CheckedChanged += new System.EventHandler(this.checkBoxPacket1_CheckedChanged);
            // 
            // labelPaket1
            // 
            this.labelPaket1.AutoSize = true;
            this.labelPaket1.Location = new System.Drawing.Point(56, 327);
            this.labelPaket1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPaket1.Name = "labelPaket1";
            this.labelPaket1.Size = new System.Drawing.Size(153, 25);
            this.labelPaket1.TabIndex = 2;
            this.labelPaket1.Text = "Paket 1 (1000)";
            this.labelPaket1.Visible = false;
            // 
            // labelPaket2
            // 
            this.labelPaket2.AutoSize = true;
            this.labelPaket2.Location = new System.Drawing.Point(56, 377);
            this.labelPaket2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPaket2.Name = "labelPaket2";
            this.labelPaket2.Size = new System.Drawing.Size(153, 25);
            this.labelPaket2.TabIndex = 3;
            this.labelPaket2.Text = "Paket 2 (2000)";
            this.labelPaket2.Visible = false;
            // 
            // labelPaket3
            // 
            this.labelPaket3.AutoSize = true;
            this.labelPaket3.Location = new System.Drawing.Point(56, 423);
            this.labelPaket3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPaket3.Name = "labelPaket3";
            this.labelPaket3.Size = new System.Drawing.Size(153, 25);
            this.labelPaket3.TabIndex = 4;
            this.labelPaket3.Text = "Paket 3 (3000)";
            this.labelPaket3.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(96, 713);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(388, 104);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Spočítat";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(550, 754);
            this.labelSuma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(96, 25);
            this.labelSuma.TabIndex = 6;
            this.labelSuma.Text = "Celkem: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPaket3);
            this.Controls.Add(this.labelPaket2);
            this.Controls.Add(this.labelPaket1);
            this.Controls.Add(this.groupBoxPackets);
            this.Controls.Add(this.groupBoxCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koupě  vozidla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCars.ResumeLayout(false);
            this.groupBoxCars.PerformLayout();
            this.groupBoxPackets.ResumeLayout(false);
            this.groupBoxPackets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCars;
        private System.Windows.Forms.GroupBox groupBoxPackets;
        private System.Windows.Forms.RadioButton radioButtonCar3;
        private System.Windows.Forms.RadioButton radioButtonCar2;
        private System.Windows.Forms.RadioButton radioButtonCar1;
        private System.Windows.Forms.CheckBox checkBoxPacket3;
        private System.Windows.Forms.CheckBox checkBoxPacket2;
        private System.Windows.Forms.CheckBox checkBoxPacket1;
        private System.Windows.Forms.Label labelPaket1;
        private System.Windows.Forms.Label labelPaket2;
        private System.Windows.Forms.Label labelPaket3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelSuma;
    }
}

