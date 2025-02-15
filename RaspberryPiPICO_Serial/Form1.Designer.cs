namespace RaspberryPiPICO_Serial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbPorts = new ComboBox();
            btConect = new Button();
            numBaudRate = new NumericUpDown();
            label2 = new Label();
            cbParity = new ComboBox();
            cbStopBits = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbMessage = new TextBox();
            tbArchive = new TextBox();
            label6 = new Label();
            btArchive = new Button();
            dlgSave = new SaveFileDialog();
            numDataBits = new NumericUpDown();
            label7 = new Label();
            cbHandShake = new ComboBox();
            chkRTS = new CheckBox();
            chkDTR = new CheckBox();
            btDisconnect = new Button();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBits).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Puerto:";
            // 
            // cbPorts
            // 
            cbPorts.FormattingEnabled = true;
            cbPorts.Location = new Point(91, 6);
            cbPorts.Name = "cbPorts";
            cbPorts.Size = new Size(121, 23);
            cbPorts.TabIndex = 1;
            // 
            // btConect
            // 
            btConect.Location = new Point(294, 212);
            btConect.Name = "btConect";
            btConect.Size = new Size(75, 23);
            btConect.TabIndex = 2;
            btConect.Text = "Conectar";
            btConect.UseVisualStyleBackColor = true;
            btConect.Click += btConect_Click;
            // 
            // numBaudRate
            // 
            numBaudRate.Location = new Point(91, 35);
            numBaudRate.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numBaudRate.Name = "numBaudRate";
            numBaudRate.Size = new Size(120, 23);
            numBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Velocidad:";
            // 
            // cbParity
            // 
            cbParity.FormattingEnabled = true;
            cbParity.Location = new Point(91, 64);
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(203, 23);
            cbParity.TabIndex = 5;
            // 
            // cbStopBits
            // 
            cbStopBits.FormattingEnabled = true;
            cbStopBits.Location = new Point(91, 122);
            cbStopBits.Name = "cbStopBits";
            cbStopBits.Size = new Size(204, 23);
            cbStopBits.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Paridad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "Bits:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 126);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Stop Bits:";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(2, 241);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.ScrollBars = ScrollBars.Vertical;
            tbMessage.Size = new Size(794, 208);
            tbMessage.TabIndex = 11;
            // 
            // tbArchive
            // 
            tbArchive.Location = new Point(91, 183);
            tbArchive.Name = "tbArchive";
            tbArchive.Size = new Size(602, 23);
            tbArchive.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Archivo:";
            // 
            // btArchive
            // 
            btArchive.Location = new Point(699, 183);
            btArchive.Name = "btArchive";
            btArchive.Size = new Size(75, 23);
            btArchive.TabIndex = 14;
            btArchive.Text = "Explorar";
            btArchive.UseVisualStyleBackColor = true;
            btArchive.Click += btArchive_Click;
            // 
            // dlgSave
            // 
            dlgSave.FileOk += dlgSave_FileOk;
            // 
            // numDataBits
            // 
            numDataBits.Location = new Point(91, 93);
            numDataBits.Name = "numDataBits";
            numDataBits.Size = new Size(121, 23);
            numDataBits.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 158);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 17;
            label7.Text = "Handshake:";
            // 
            // cbHandShake
            // 
            cbHandShake.FormattingEnabled = true;
            cbHandShake.Location = new Point(91, 154);
            cbHandShake.Name = "cbHandShake";
            cbHandShake.Size = new Size(203, 23);
            cbHandShake.TabIndex = 16;
            // 
            // chkRTS
            // 
            chkRTS.AutoSize = true;
            chkRTS.Location = new Point(404, 8);
            chkRTS.Name = "chkRTS";
            chkRTS.Size = new Size(45, 19);
            chkRTS.TabIndex = 19;
            chkRTS.Text = "RTS";
            chkRTS.UseVisualStyleBackColor = true;
            // 
            // chkDTR
            // 
            chkDTR.AutoSize = true;
            chkDTR.Location = new Point(404, 38);
            chkDTR.Name = "chkDTR";
            chkDTR.Size = new Size(47, 19);
            chkDTR.TabIndex = 20;
            chkDTR.Text = "DTR";
            chkDTR.UseVisualStyleBackColor = true;
            // 
            // btDisconnect
            // 
            btDisconnect.Location = new Point(404, 212);
            btDisconnect.Name = "btDisconnect";
            btDisconnect.Size = new Size(75, 23);
            btDisconnect.TabIndex = 21;
            btDisconnect.Text = "Terminar";
            btDisconnect.UseVisualStyleBackColor = true;
            btDisconnect.Click += btDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btDisconnect);
            Controls.Add(chkDTR);
            Controls.Add(chkRTS);
            Controls.Add(label7);
            Controls.Add(cbHandShake);
            Controls.Add(numDataBits);
            Controls.Add(btArchive);
            Controls.Add(label6);
            Controls.Add(tbArchive);
            Controls.Add(tbMessage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbStopBits);
            Controls.Add(cbParity);
            Controls.Add(label2);
            Controls.Add(numBaudRate);
            Controls.Add(btConect);
            Controls.Add(cbPorts);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conexion Serial";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numBaudRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDataBits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbPorts;
        private Button btConect;
        private NumericUpDown numBaudRate;
        private Label label2;
        private ComboBox cbParity;
        private ComboBox cbStopBits;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbMessage;
        private TextBox tbArchive;
        private Label label6;
        private Button btArchive;
        private SaveFileDialog dlgSave;
        private NumericUpDown numDataBits;
        private Label label7;
        private ComboBox cbHandShake;
        private CheckBox chkRTS;
        private CheckBox chkDTR;
        private Button btDisconnect;
    }
}
