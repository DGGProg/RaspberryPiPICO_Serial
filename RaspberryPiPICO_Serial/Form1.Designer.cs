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
            tabAcc = new TabPage();
            label19 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            label13 = new Label();
            txtAccY = new TextBox();
            label12 = new Label();
            txtAccX = new TextBox();
            txtAccZ = new TextBox();
            txtGyroX = new TextBox();
            txtGyroY = new TextBox();
            txtGyroZ = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            label16 = new Label();
            chkGraph = new CheckBox();
            txtMinAccX = new TextBox();
            txtMaxAccX = new TextBox();
            txtMinAccY = new TextBox();
            txtMaxAccY = new TextBox();
            txtMinAccZ = new TextBox();
            txtMaxAccZ = new TextBox();
            txtMinGyroX = new TextBox();
            txtMaxGyroX = new TextBox();
            txtMinGyroY = new TextBox();
            txtMaxGyroY = new TextBox();
            txtMinGyroZ = new TextBox();
            txtMaxGyroZ = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numBaudRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDataBits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartConn).BeginInit();
            tabControl1.SuspendLayout();
            tabStats.SuspendLayout();
            tabTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHigh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTemp).BeginInit();
            tabAcc.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tabControl1.Controls.Add(tabAcc);
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
            // tabAcc
            // 
            tabAcc.Controls.Add(label19);
            tabAcc.Controls.Add(tableLayoutPanel1);
            tabAcc.Location = new Point(4, 24);
            tabAcc.Name = "tabAcc";
            tabAcc.Padding = new Padding(3);
            tabAcc.Size = new Size(874, 538);
            tabAcc.TabIndex = 2;
            tabAcc.Text = "Acelerometro";
            tabAcc.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(50, 63);
            label19.Name = "label19";
            label19.Size = new Size(79, 15);
            label19.TabIndex = 6;
            label19.Text = "Acelerometro";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.23232F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2323227F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.10101F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2323227F));
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Controls.Add(label13, 2, 1);
            tableLayoutPanel1.Controls.Add(txtAccY, 3, 1);
            tableLayoutPanel1.Controls.Add(label12, 0, 1);
            tableLayoutPanel1.Controls.Add(txtAccX, 1, 1);
            tableLayoutPanel1.Controls.Add(txtAccZ, 5, 1);
            tableLayoutPanel1.Controls.Add(label14, 4, 1);
            tableLayoutPanel1.Controls.Add(label16, 0, 4);
            tableLayoutPanel1.Controls.Add(txtGyroX, 1, 4);
            tableLayoutPanel1.Controls.Add(label17, 2, 4);
            tableLayoutPanel1.Controls.Add(txtGyroY, 3, 4);
            tableLayoutPanel1.Controls.Add(label18, 4, 4);
            tableLayoutPanel1.Controls.Add(txtGyroZ, 5, 4);
            tableLayoutPanel1.Controls.Add(label15, 0, 3);
            tableLayoutPanel1.Controls.Add(txtMinAccX, 0, 2);
            tableLayoutPanel1.Controls.Add(txtMaxAccX, 1, 2);
            tableLayoutPanel1.Controls.Add(txtMinAccY, 2, 2);
            tableLayoutPanel1.Controls.Add(txtMaxAccY, 3, 2);
            tableLayoutPanel1.Controls.Add(txtMinAccZ, 4, 2);
            tableLayoutPanel1.Controls.Add(txtMaxAccZ, 5, 2);
            tableLayoutPanel1.Controls.Add(txtMinGyroX, 0, 5);
            tableLayoutPanel1.Controls.Add(txtMaxGyroX, 1, 5);
            tableLayoutPanel1.Controls.Add(txtMinGyroY, 2, 5);
            tableLayoutPanel1.Controls.Add(txtMaxGyroY, 3, 5);
            tableLayoutPanel1.Controls.Add(txtMinGyroZ, 4, 5);
            tableLayoutPanel1.Controls.Add(txtMaxGyroZ, 5, 5);
            tableLayoutPanel1.Location = new Point(98, 141);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(680, 245);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 0;
            label11.Text = "Acc";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(228, 40);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 3;
            label13.Text = "Y = ";
            // 
            // txtAccY
            // 
            txtAccY.Location = new Point(296, 43);
            txtAccY.Name = "txtAccY";
            txtAccY.Size = new Size(76, 23);
            txtAccY.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 40);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 1;
            label12.Text = "X = ";
            // 
            // txtAccX
            // 
            txtAccX.Location = new Point(71, 43);
            txtAccX.Name = "txtAccX";
            txtAccX.Size = new Size(76, 23);
            txtAccX.TabIndex = 2;
            // 
            // txtAccZ
            // 
            txtAccZ.Location = new Point(521, 43);
            txtAccZ.Name = "txtAccZ";
            txtAccZ.Size = new Size(76, 23);
            txtAccZ.TabIndex = 5;
            // 
            // txtGyroX
            // 
            txtGyroX.Location = new Point(71, 163);
            txtGyroX.Name = "txtGyroX";
            txtGyroX.Size = new Size(76, 23);
            txtGyroX.TabIndex = 6;
            // 
            // txtGyroY
            // 
            txtGyroY.Location = new Point(296, 163);
            txtGyroY.Name = "txtGyroY";
            txtGyroY.Size = new Size(76, 23);
            txtGyroY.TabIndex = 7;
            // 
            // txtGyroZ
            // 
            txtGyroZ.Location = new Point(521, 163);
            txtGyroZ.Name = "txtGyroZ";
            txtGyroZ.Size = new Size(76, 23);
            txtGyroZ.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(453, 40);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 9;
            label14.Text = "Z = ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 120);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 10;
            label15.Text = "Gyro";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(228, 160);
            label17.Name = "label17";
            label17.Size = new Size(28, 15);
            label17.TabIndex = 12;
            label17.Text = "Y = ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(453, 160);
            label18.Name = "label18";
            label18.Size = new Size(28, 15);
            label18.TabIndex = 13;
            label18.Text = "Z = ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 160);
            label16.Name = "label16";
            label16.Size = new Size(28, 15);
            label16.TabIndex = 11;
            label16.Text = "X = ";
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
            // txtMinAccX
            // 
            txtMinAccX.Location = new Point(3, 83);
            txtMinAccX.Name = "txtMinAccX";
            txtMinAccX.Size = new Size(62, 23);
            txtMinAccX.TabIndex = 14;
            // 
            // txtMaxAccX
            // 
            txtMaxAccX.Location = new Point(71, 83);
            txtMaxAccX.Name = "txtMaxAccX";
            txtMaxAccX.Size = new Size(62, 23);
            txtMaxAccX.TabIndex = 15;
            // 
            // txtMinAccY
            // 
            txtMinAccY.Location = new Point(228, 83);
            txtMinAccY.Name = "txtMinAccY";
            txtMinAccY.Size = new Size(62, 23);
            txtMinAccY.TabIndex = 16;
            // 
            // txtMaxAccY
            // 
            txtMaxAccY.Location = new Point(296, 83);
            txtMaxAccY.Name = "txtMaxAccY";
            txtMaxAccY.Size = new Size(62, 23);
            txtMaxAccY.TabIndex = 17;
            // 
            // txtMinAccZ
            // 
            txtMinAccZ.Location = new Point(453, 83);
            txtMinAccZ.Name = "txtMinAccZ";
            txtMinAccZ.Size = new Size(62, 23);
            txtMinAccZ.TabIndex = 18;
            // 
            // txtMaxAccZ
            // 
            txtMaxAccZ.Location = new Point(521, 83);
            txtMaxAccZ.Name = "txtMaxAccZ";
            txtMaxAccZ.Size = new Size(62, 23);
            txtMaxAccZ.TabIndex = 19;
            // 
            // txtMinGyroX
            // 
            txtMinGyroX.Location = new Point(3, 203);
            txtMinGyroX.Name = "txtMinGyroX";
            txtMinGyroX.Size = new Size(62, 23);
            txtMinGyroX.TabIndex = 20;
            // 
            // txtMaxGyroX
            // 
            txtMaxGyroX.Location = new Point(71, 203);
            txtMaxGyroX.Name = "txtMaxGyroX";
            txtMaxGyroX.Size = new Size(62, 23);
            txtMaxGyroX.TabIndex = 21;
            // 
            // txtMinGyroY
            // 
            txtMinGyroY.Location = new Point(228, 203);
            txtMinGyroY.Name = "txtMinGyroY";
            txtMinGyroY.Size = new Size(62, 23);
            txtMinGyroY.TabIndex = 22;
            // 
            // txtMaxGyroY
            // 
            txtMaxGyroY.Location = new Point(296, 203);
            txtMaxGyroY.Name = "txtMaxGyroY";
            txtMaxGyroY.Size = new Size(62, 23);
            txtMaxGyroY.TabIndex = 23;
            // 
            // txtMinGyroZ
            // 
            txtMinGyroZ.Location = new Point(453, 203);
            txtMinGyroZ.Name = "txtMinGyroZ";
            txtMinGyroZ.Size = new Size(62, 23);
            txtMinGyroZ.TabIndex = 24;
            // 
            // txtMaxGyroZ
            // 
            txtMaxGyroZ.Location = new Point(521, 203);
            txtMaxGyroZ.Name = "txtMaxGyroZ";
            txtMaxGyroZ.Size = new Size(62, 23);
            txtMaxGyroZ.TabIndex = 25;
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
            tabAcc.ResumeLayout(false);
            tabAcc.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TabPage tabAcc;
        private TextBox txtAccY;
        private Label label13;
        private TextBox txtAccX;
        private Label label12;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label19;
        private TextBox txtAccZ;
        private TextBox txtGyroX;
        private TextBox txtGyroY;
        private TextBox txtGyroZ;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtMinAccX;
        private TextBox txtMaxAccX;
        private TextBox txtMinAccY;
        private TextBox txtMaxAccY;
        private TextBox txtMinAccZ;
        private TextBox txtMaxAccZ;
        private TextBox txtMinGyroX;
        private TextBox txtMaxGyroX;
        private TextBox txtMinGyroY;
        private TextBox txtMaxGyroY;
        private TextBox txtMinGyroZ;
        private TextBox txtMaxGyroZ;
    }
}
