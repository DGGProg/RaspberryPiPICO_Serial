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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            lbTime = new Label();
            chartConn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControl1 = new TabControl();
            tabStats = new TabPage();
            tabTemp = new TabPage();
            chkRange = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            numHigh = new NumericUpDown();
            label8 = new Label();
            numLow = new NumericUpDown();
            chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chkGraph = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartConn).BeginInit();
            tabControl1.SuspendLayout();
            tabStats.SuspendLayout();
            tabTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHigh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTemp).BeginInit();
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
            btConect.Location = new Point(156, 212);
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
            tbMessage.MinimumSize = new Size(615, 216);
            tbMessage.Multiline = true;
            tbMessage.Name = "tbMessage";
            tbMessage.ScrollBars = ScrollBars.Vertical;
            tbMessage.Size = new Size(615, 331);
            tbMessage.TabIndex = 11;
            // 
            // tbArchive
            // 
            tbArchive.Location = new Point(91, 183);
            tbArchive.Name = "tbArchive";
            tbArchive.Size = new Size(445, 23);
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
            btArchive.Location = new Point(542, 183);
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
            chkRTS.Location = new Point(339, 10);
            chkRTS.Name = "chkRTS";
            chkRTS.Size = new Size(45, 19);
            chkRTS.TabIndex = 19;
            chkRTS.Text = "RTS";
            chkRTS.UseVisualStyleBackColor = true;
            // 
            // chkDTR
            // 
            chkDTR.AutoSize = true;
            chkDTR.Location = new Point(339, 40);
            chkDTR.Name = "chkDTR";
            chkDTR.Size = new Size(47, 19);
            chkDTR.TabIndex = 20;
            chkDTR.Text = "DTR";
            chkDTR.UseVisualStyleBackColor = true;
            // 
            // btDisconnect
            // 
            btDisconnect.Location = new Point(339, 212);
            btDisconnect.Name = "btDisconnect";
            btDisconnect.Size = new Size(75, 23);
            btDisconnect.TabIndex = 21;
            btDisconnect.Text = "Terminar";
            btDisconnect.UseVisualStyleBackColor = true;
            btDisconnect.Click += btDisconnect_Click;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.BackColor = SystemColors.Control;
            lbTime.ForeColor = Color.Red;
            lbTime.Location = new Point(471, 6);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(33, 15);
            lbTime.TabIndex = 22;
            lbTime.Text = "Hora";
            lbTime.Visible = false;
            // 
            // chartConn
            // 
            chartConn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartConn.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartConn.Legends.Add(legend1);
            chartConn.Location = new Point(3, 3);
            chartConn.Name = "chartConn";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartConn.Series.Add(series1);
            chartConn.Size = new Size(868, 532);
            chartConn.TabIndex = 23;
            chartConn.Text = "chart1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStats);
            tabControl1.Controls.Add(tabTemp);
            tabControl1.Location = new Point(623, 6);
            tabControl1.MinimumSize = new Size(882, 451);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 566);
            tabControl1.TabIndex = 24;
            // 
            // tabStats
            // 
            tabStats.Controls.Add(chartConn);
            tabStats.Location = new Point(4, 24);
            tabStats.Name = "tabStats";
            tabStats.Padding = new Padding(3);
            tabStats.Size = new Size(874, 538);
            tabStats.TabIndex = 0;
            tabStats.Text = "Estadísticas";
            tabStats.UseVisualStyleBackColor = true;
            // 
            // tabTemp
            // 
            tabTemp.Controls.Add(chkRange);
            tabTemp.Controls.Add(label10);
            tabTemp.Controls.Add(label9);
            tabTemp.Controls.Add(numHigh);
            tabTemp.Controls.Add(label8);
            tabTemp.Controls.Add(numLow);
            tabTemp.Controls.Add(chartTemp);
            tabTemp.Location = new Point(4, 24);
            tabTemp.Name = "tabTemp";
            tabTemp.Padding = new Padding(3);
            tabTemp.Size = new Size(874, 538);
            tabTemp.TabIndex = 1;
            tabTemp.Text = "Temperatura";
            tabTemp.UseVisualStyleBackColor = true;
            // 
            // chkRange
            // 
            chkRange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkRange.AutoSize = true;
            chkRange.Location = new Point(767, 489);
            chkRange.Name = "chkRange";
            chkRange.Size = new Size(52, 19);
            chkRange.TabIndex = 34;
            chkRange.Text = "Auto";
            chkRange.UseVisualStyleBackColor = true;
            chkRange.CheckedChanged += chkRange_CheckedChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(731, 377);
            label10.Name = "label10";
            label10.Size = new Size(125, 15);
            label10.TabIndex = 33;
            label10.Text = "Rango de temperatura";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(733, 399);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 32;
            label9.Text = "Superior";
            // 
            // numHigh
            // 
            numHigh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numHigh.DecimalPlaces = 4;
            numHigh.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numHigh.Location = new Point(733, 417);
            numHigh.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numHigh.Minimum = new decimal(new int[] { 54, 0, 0, int.MinValue });
            numHigh.Name = "numHigh";
            numHigh.Size = new Size(120, 23);
            numHigh.TabIndex = 31;
            numHigh.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numHigh.ValueChanged += numRange_ValueChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(733, 442);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 30;
            label8.Text = "Inferior";
            // 
            // numLow
            // 
            numLow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numLow.DecimalPlaces = 4;
            numLow.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numLow.Location = new Point(733, 460);
            numLow.Maximum = new decimal(new int[] { 149, 0, 0, 0 });
            numLow.Minimum = new decimal(new int[] { 55, 0, 0, int.MinValue });
            numLow.Name = "numLow";
            numLow.Size = new Size(120, 23);
            numLow.TabIndex = 29;
            numLow.ValueChanged += numRange_ValueChanged;
            // 
            // chartTemp
            // 
            chartTemp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartTemp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTemp.Legends.Add(legend2);
            chartTemp.Location = new Point(3, 3);
            chartTemp.Name = "chartTemp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTemp.Series.Add(series2);
            chartTemp.Size = new Size(868, 532);
            chartTemp.TabIndex = 0;
            chartTemp.Text = "chart1";
            // 
            // chkGraph
            // 
            chkGraph.AutoSize = true;
            chkGraph.Checked = true;
            chkGraph.CheckState = CheckState.Checked;
            chkGraph.Location = new Point(505, 154);
            chkGraph.Name = "chkGraph";
            chkGraph.Size = new Size(112, 19);
            chkGraph.TabIndex = 25;
            chkGraph.Text = "Mostrar Gráficas";
            chkGraph.UseVisualStyleBackColor = true;
            chkGraph.CheckedChanged += chkGraph_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 576);
            Controls.Add(chkGraph);
            Controls.Add(tabControl1);
            Controls.Add(lbTime);
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
            MinimumSize = new Size(638, 500);
            Name = "Form1";
            Text = "Conexion Serial";
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)numBaudRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDataBits).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartConn).EndInit();
            tabControl1.ResumeLayout(false);
            tabStats.ResumeLayout(false);
            tabTemp.ResumeLayout(false);
            tabTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHigh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLow).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTemp).EndInit();
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
        private Label lbTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConn;
        private TabControl tabControl1;
        private TabPage tabStats;
        private TabPage tabTemp;
        private CheckBox chkGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private Label label10;
        private Label label9;
        private NumericUpDown numHigh;
        private Label label8;
        private NumericUpDown numLow;
        private CheckBox chkRange;
    }
}
