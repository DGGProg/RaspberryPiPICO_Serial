using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace RaspberryPiPICO_Serial
{
    public partial class Form1 : Form
    {
        static bool _continue;
        static SerialPort _serialPort = new SerialPort();
        Thread readThread;
        Thread timeThread;
        static long recived, timeout, error;
        static int width = 1520;
        static int height = 615;

        public Form1()
        {
            InitializeComponent();
            cbPorts.DataSource = SerialPort.GetPortNames();
            cbPorts.SelectedIndex = 0;
            numBaudRate.Value = 9600;
            cbParity.DataSource = Enum.GetNames(typeof(Parity));
            cbParity.SelectedIndex = 0;
            numDataBits.Value = 8;
            cbStopBits.DataSource = Enum.GetNames(typeof(StopBits));
            cbStopBits.SelectedIndex = 1;
            cbHandShake.DataSource = Enum.GetNames(typeof(Handshake));
            cbHandShake.SelectedIndex = 1;
            chkRTS.Checked = true;
            chkDTR.Checked = true;

            recived = timeout = error = 0;
            chartConn.Series.Clear();
            chartConn.Titles.Add("Paquetes");

            Series series = this.chartConn.Series.Add("Recibidos");
            series.ChartType = SeriesChartType.Column;
            series.Points.AddY(recived);
            series = this.chartConn.Series.Add("Timeout");
            series.Points.AddY(timeout);
            series.ChartType = SeriesChartType.Column;
            series = this.chartConn.Series.Add("Errores");
            series.Points.AddY(error);
            series.ChartType = SeriesChartType.Column;
            chartConn.ChartAreas.First().AxisX.Title = "Estado";
            chartConn.ChartAreas.First().AxisY.Title = "Numero de eventos";

            chartTemp.Series.Clear();
            chartTemp.Titles.Add("Temperatura");

            series = this.chartTemp.Series.Add("Temperatura promedio");
            series.ChartType = SeriesChartType.Line;
            series = this.chartTemp.Series.Add("Temperatura instantanea");
            series.ChartType = SeriesChartType.Line;
            series = this.chartTemp.Series.Add("Temperatura promedio acumulada");
            series.ChartType = SeriesChartType.Line;
            chartTemp.ChartAreas.First().AxisX.Title = "Tiempo";
            chartTemp.ChartAreas.First().AxisY.Title = "Temperatura (°C)";
            this.Size = new Size(width, height);
        }
        public bool saveToFile(string text, string path)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public void Time()
        {
            while (_continue)
            {
                try
                {
                    tbMessage.Invoke((MethodInvoker)delegate
                    {
                        lbTime.Text = DateTime.Now.ToString();
                        lbTime.Visible = true;
                    });
                }
                catch (OperationCanceledException) { }
            }
        }
        public void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    tbMessage.Invoke((MethodInvoker)delegate
                    {
                        recived += 1;
                        tbMessage.AppendText(System.DateTime.Now + "\t" + message + Environment.NewLine);
                        chartTemp.Series.First().Points.AddXY(System.DateTime.Now, Double.Parse(message.Split("\t")[3]));
                        chartTemp.Series.FindByName("Temperatura instantanea").Points.AddXY(System.DateTime.Now, Double.Parse(message.Split("\t")[2]));
                        chartTemp.Series.FindByName("Temperatura promedio acumulada").Points.AddXY(System.DateTime.Now, Double.Parse(message.Split("\t")[5]));
                        if (chartTemp.Series.First().Points.Count > 60)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                chartTemp.Series.First().Points.RemoveAt(i);
                                chartTemp.Series.FindByName("Temperatura instantanea").Points.RemoveAt(i);
                                chartTemp.Series.FindByName("Temperatura promedio acumulada").Points.RemoveAt(i);
                            }
                        }
                        chartConn.Series.First().Points.AddY(recived);
                        if (chkRange.Checked)
                        {
                            chartTemp.ChartAreas.First().AxisY.Minimum = chartTemp.Series.FindByName("Temperatura instantanea").Points.FindMinByValue().YValues[0];
                            chartTemp.ChartAreas.First().AxisY.Maximum = chartTemp.Series.FindByName("Temperatura instantanea").Points.FindMaxByValue().YValues[0];
                        }
                        else
                        {
                            numRange_ValueChanged(chkRange, new System.EventArgs());
                        }
                    });
                    if (!String.IsNullOrEmpty(tbArchive.Text))
                    {
                        saveToFile(System.DateTime.Now + "\t" + message, tbArchive.Text);
                    }
                }
                catch (TimeoutException)
                {
                    timeout += 1;
                    chartConn.Series.FindByName("Timeout").Points.AddY(timeout);
                    tbMessage.Invoke((MethodInvoker)delegate
                    {
                        tbMessage.AppendText("TimeoutException" + Environment.NewLine);
                    });
                }
                catch (OperationCanceledException)
                {
                    error += 1;
                    chartConn.Series.FindByName("Errores").Points.AddY(error);
                }
                catch (InvalidOperationException)
                {
                    error += 1;
                    chartConn.Series.FindByName("Errores").Points.AddY(error);
                    //added to control the physical device disconnection
                    end_connection();
                    btConect.Invoke((MethodInvoker)delegate
                    {
                        btConect.Enabled = true;
                    });
                }
            }
        }
        private void end_connection()
        {
            _continue = false;
            Task.Run(() =>
            {
                if (readThread != null && readThread.IsAlive)
                {
                    readThread.Join();
                }
                if (timeThread != null && timeThread.IsAlive)
                {
                    timeThread.Join();
                }
            });
            _serialPort.Close();
        }

        private void btConect_Click(object sender, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = cbPorts.SelectedValue.ToString();
            _serialPort.BaudRate = (int)numBaudRate.Value;
            _serialPort.Parity = Enum.Parse<Parity>(cbParity.SelectedValue.ToString());
            _serialPort.DataBits = 8;
            _serialPort.StopBits = Enum.Parse<StopBits>(cbStopBits.SelectedValue.ToString());
            _serialPort.Handshake = Enum.Parse<Handshake>(cbHandShake.SelectedValue.ToString());
            _serialPort.ReadTimeout = 5000;
            _serialPort.WriteTimeout = 5000;

            // Indicates the device that the system is ready to recive data
            _serialPort.RtsEnable = chkRTS.Checked;
            _serialPort.DtrEnable = chkDTR.Checked;

            _serialPort.Open();
            _continue = true;

            readThread = new Thread(Read);
            readThread.IsBackground = true;
            readThread.Start();
            btConect.Enabled = false;
            timeThread = new Thread(Time);
            timeThread.IsBackground = true;
            timeThread.Start();
        }

        private void btArchive_Click(object sender, EventArgs e)
        {
            dlgSave.ShowDialog();
        }

        private void dlgSave_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tbArchive.Text = dlgSave.FileName;
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            end_connection();
            btConect.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            end_connection();
        }

        private void chkGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGraph.Checked == true)
            {
                tabControl1.Visible = true;
                this.Width = width;
            }
            else
            {
                tabControl1.Visible = false;
                this.Width = width - tabControl1.MinimumSize.Width;
            }
        }

        private void numRange_ValueChanged(object sender, EventArgs e)
        {
            if ((double)numLow.Value == (double)numHigh.Value)
            {
                numHigh.Value = numLow.Value + 1;
            }
            chartTemp.ChartAreas.First().AxisY.Minimum = (double)numLow.Value;
            chartTemp.ChartAreas.First().AxisY.Maximum = (double)numHigh.Value;
            chkRange.Checked = false;
        }

        private void chkRange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRange.Checked)
            {
                chartTemp.ChartAreas.First().AxisY.Minimum = chartTemp.Series.FindByName("Temperatura instantanea").Points.FindMinByValue().YValues[0];
                chartTemp.ChartAreas.First().AxisY.Maximum = chartTemp.Series.FindByName("Temperatura instantanea").Points.FindMaxByValue().YValues[0];
            }
            else
            {
                numRange_ValueChanged(chkRange, new System.EventArgs());
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int cambio_hor = 0;
            int cambio_ver = this.Height - this.MinimumSize.Height;          
            if (chkGraph.Checked)
            {
                cambio_hor = this.Width - (this.MinimumSize.Width+ tabControl1.MinimumSize.Width);
            }
            else
            {
                cambio_hor = this.Width - this.MinimumSize.Width;
            }

            tabControl1.Width = tabControl1.MinimumSize.Width + cambio_hor;

            tbMessage.Height = tbMessage.MinimumSize.Height + cambio_ver;
            tabControl1.Height = tabControl1.MinimumSize.Height + cambio_ver;
        }
    }
}
