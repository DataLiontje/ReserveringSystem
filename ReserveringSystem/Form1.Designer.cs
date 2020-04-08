namespace ReserveringSystem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reserveringen = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BinnenTafelsNum = new System.Windows.Forms.Label();
            this.BuitenTafelsNum = new System.Windows.Forms.Label();
            this.BinnenTafels = new System.Windows.Forms.Label();
            this.BuitenTafels = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TelNumLabel = new System.Windows.Forms.Label();
            this.SubmitReserveringButton = new System.Windows.Forms.Button();
            this.AantalPersInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NaamInput = new System.Windows.Forms.TextBox();
            this.TelNumInput = new System.Windows.Forms.TextBox();
            this.IsBinnenCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AantalPersInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.Reserveringen);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserveringen";
            // 
            // Reserveringen
            // 
            this.Reserveringen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Reserveringen.AutoScroll = true;
            this.Reserveringen.Location = new System.Drawing.Point(6, 21);
            this.Reserveringen.Name = "Reserveringen";
            this.Reserveringen.Size = new System.Drawing.Size(377, 281);
            this.Reserveringen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.BinnenTafelsNum);
            this.groupBox2.Controls.Add(this.BuitenTafelsNum);
            this.groupBox2.Controls.Add(this.BinnenTafels);
            this.groupBox2.Controls.Add(this.BuitenTafels);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beschikbare Tafels";
            // 
            // BinnenTafelsNum
            // 
            this.BinnenTafelsNum.AutoSize = true;
            this.BinnenTafelsNum.Location = new System.Drawing.Point(71, 75);
            this.BinnenTafelsNum.Name = "BinnenTafelsNum";
            this.BinnenTafelsNum.Size = new System.Drawing.Size(0, 17);
            this.BinnenTafelsNum.TabIndex = 3;
            // 
            // BuitenTafelsNum
            // 
            this.BuitenTafelsNum.AutoSize = true;
            this.BuitenTafelsNum.Location = new System.Drawing.Point(71, 34);
            this.BuitenTafelsNum.Name = "BuitenTafelsNum";
            this.BuitenTafelsNum.Size = new System.Drawing.Size(0, 17);
            this.BuitenTafelsNum.TabIndex = 2;
            // 
            // BinnenTafels
            // 
            this.BinnenTafels.AutoSize = true;
            this.BinnenTafels.Location = new System.Drawing.Point(6, 75);
            this.BinnenTafels.Name = "BinnenTafels";
            this.BinnenTafels.Size = new System.Drawing.Size(56, 17);
            this.BinnenTafels.TabIndex = 1;
            this.BinnenTafels.Text = "Binnen:";
            this.BinnenTafels.Click += new System.EventHandler(this.label4_Click);
            // 
            // BuitenTafels
            // 
            this.BuitenTafels.AutoSize = true;
            this.BuitenTafels.Location = new System.Drawing.Point(6, 34);
            this.BuitenTafels.Name = "BuitenTafels";
            this.BuitenTafels.Size = new System.Drawing.Size(52, 17);
            this.BuitenTafels.TabIndex = 0;
            this.BuitenTafels.Text = "Buiten:";
            this.BuitenTafels.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IsBinnenCheck);
            this.groupBox3.Controls.Add(this.TelNumInput);
            this.groupBox3.Controls.Add(this.TelNumLabel);
            this.groupBox3.Controls.Add(this.SubmitReserveringButton);
            this.groupBox3.Controls.Add(this.AantalPersInput);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NaamInput);
            this.groupBox3.Location = new System.Drawing.Point(452, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reservering Registratie";
            // 
            // TelNumLabel
            // 
            this.TelNumLabel.AutoSize = true;
            this.TelNumLabel.Location = new System.Drawing.Point(3, 91);
            this.TelNumLabel.Name = "TelNumLabel";
            this.TelNumLabel.Size = new System.Drawing.Size(125, 17);
            this.TelNumLabel.TabIndex = 6;
            this.TelNumLabel.Text = "Telefoon Nummer:";
            this.TelNumLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // SubmitReserveringButton
            // 
            this.SubmitReserveringButton.Location = new System.Drawing.Point(6, 243);
            this.SubmitReserveringButton.Name = "SubmitReserveringButton";
            this.SubmitReserveringButton.Size = new System.Drawing.Size(203, 36);
            this.SubmitReserveringButton.TabIndex = 5;
            this.SubmitReserveringButton.Text = "Plaats Reservering";
            this.SubmitReserveringButton.UseVisualStyleBackColor = true;
            this.SubmitReserveringButton.Click += new System.EventHandler(this.SubmitReserveringButton_Click);
            // 
            // AantalPersInput
            // 
            this.AantalPersInput.Location = new System.Drawing.Point(6, 169);
            this.AantalPersInput.Name = "AantalPersInput";
            this.AantalPersInput.Size = new System.Drawing.Size(203, 22);
            this.AantalPersInput.TabIndex = 4;
            this.AantalPersInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AantalPersInput.ValueChanged += new System.EventHandler(this.AantalPersInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aantal Personen:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NaamInput
            // 
            this.NaamInput.Location = new System.Drawing.Point(6, 53);
            this.NaamInput.Name = "NaamInput";
            this.NaamInput.Size = new System.Drawing.Size(203, 22);
            this.NaamInput.TabIndex = 0;
            this.NaamInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TelNumInput
            // 
            this.TelNumInput.Location = new System.Drawing.Point(6, 112);
            this.TelNumInput.Name = "TelNumInput";
            this.TelNumInput.Size = new System.Drawing.Size(203, 22);
            this.TelNumInput.TabIndex = 7;
            // 
            // IsBinnenCheck
            // 
            this.IsBinnenCheck.AutoSize = true;
            this.IsBinnenCheck.Location = new System.Drawing.Point(9, 207);
            this.IsBinnenCheck.Name = "IsBinnenCheck";
            this.IsBinnenCheck.Size = new System.Drawing.Size(74, 21);
            this.IsBinnenCheck.TabIndex = 8;
            this.IsBinnenCheck.Text = "Binnen";
            this.IsBinnenCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ReserveringsPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AantalPersInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel Reserveringen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NaamInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitReserveringButton;
        private System.Windows.Forms.NumericUpDown AantalPersInput;
        private System.Windows.Forms.Label BinnenTafels;
        private System.Windows.Forms.Label BuitenTafels;
        private System.Windows.Forms.Label BinnenTafelsNum;
        private System.Windows.Forms.Label BuitenTafelsNum;
        private System.Windows.Forms.Label TelNumLabel;
        private System.Windows.Forms.TextBox TelNumInput;
        private System.Windows.Forms.CheckBox IsBinnenCheck;
    }
}

