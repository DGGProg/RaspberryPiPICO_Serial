using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace RaspberryPiPICO_Serial
{
    public partial class Form1 : Form
    {
        static bool _continue;
        static SerialPort _serialPort = new();
        Thread readThread;
        Thread timeThread;
        static long recived, timeout, error;
        private const int width = 1520;
        private const int height = 615;

        Double maxAccX, maxAccY, maxAccZ, maxGyroX, maxGyroY, maxGyroZ;
        Double minAccX, minAccY, minAccZ, minGyroX, minGyroY, minGyroZ;

        public Form1()
        {
            InitializeComponent();
            cbPorts.DataSource = SerialPort.GetPortNames();
            cbPorts.SelectedIndex = 0;
            numBaudRate.Value = 9600;
            cbParity.DataSource = Enum.GetNames<Parity>();
            cbParity.SelectedIndex = 0;
            numDataBits.Value = 8;
            cbStopBits.DataSource = Enum.GetNames<StopBits>();
            cbStopBits.SelectedIndex = 1;
            cbHandShake.DataSource = Enum.GetNames<Handshake>();
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

            maxAccX = maxAccY = maxAccZ = maxGyroX = maxGyroY = maxGyroZ = -500;
            minAccX = minAccY = minAccZ = minGyroX = minGyroY = minGyroZ = 500;
        }
        public static bool SaveToFile(string text, string path)
        {
            try
            {
                using StreamWriter sw = File.AppendText(path);
                sw.WriteLine(text);
                sw.Close();
            }
            catch (Exception)
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
            Double AccX, AccY, AccZ, GyroX, GyroY, GyroZ;
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    tbMessage.Invoke((MethodInvoker)delegate
                    {
                        chartConn.Series.First().Points.AddY(++recived);
                        tbMessage.AppendText(System.DateTime.Now + "\t" + message + Environment.NewLine);
                        if (message.Contains("<Temp>"))
                        {
                            try
                            {
                                chartTemp.Series.First().Points.AddXY(System.DateTime.Now, Double.Parse(message.Split("\t")[3]));
                                chartTemp.Series.FindByName("Temperatura instantanea").Points.AddXY(System.DateTime.Now, Double.Parse(message.Split("\t")[2]));
                                chartTemp.Series.FindByName("Temperatura promedio acumulada").Points.AddXY(System.DateTime.Now, Double.Parse(message.Split("\t")[5]));
                            }
                            catch (Exception ex)
                            {
                                tbMessage.AppendText(System.DateTime.Now + "\t" + ex.Message.ToString() + Environment.NewLine);
                            }
                            if (chartTemp.Series.First().Points.Count > 60)
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    chartTemp.Series.First().Points.RemoveAt(i);
                                    chartTemp.Series.FindByName("Temperatura instantanea").Points.RemoveAt(i);
                                    chartTemp.Series.FindByName("Temperatura promedio acumulada").Points.RemoveAt(i);
                                }
                            }
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

                        if (message.Contains("<Acc>"))
                        {
                            try
                            {
                                AccX = Double.Parse(message.Split("\t")[1]);
                                AccY = Double.Parse(message.Split("\t")[2]);
                                AccZ = Double.Parse(message.Split("\t")[3]);
                                if (maxAccX < AccX)
                                {
                                    maxAccX = AccX;
                                }
                                if (maxAccY < AccY)
                                {
                                    maxAccY = AccY;
                                }
                                if (maxAccZ < AccZ)
                                {
                                    maxAccZ = AccZ;
                                }
                                if (minAccX > AccX)
                                {
                                    minAccX = AccX;
                                }
                                if (minAccY > AccY)
                                {
                                    minAccY = AccY;
                                }
                                if (minAccZ > AccZ)
                                {
                                    minAccZ = AccZ;
                                }
                                txtAccX.Text = AccX.ToString();
                                txtAccY.Text = AccY.ToString();
                                txtAccZ.Text = AccZ.ToString();
                                txtMaxAccX.Text = maxAccX.ToString();
                                txtMaxAccY.Text = maxAccY.ToString();
                                txtMaxAccZ.Text = maxAccZ.ToString();
                                txtMinAccX.Text = minAccX.ToString();
                                txtMinAccY.Text = minAccY.ToString();
                                txtMinAccZ.Text = minAccZ.ToString();
                            }
                            catch (Exception ex)
                            {
                                tbMessage.AppendText(System.DateTime.Now + "\t" + ex.Message.ToString() + Environment.NewLine);
                            }
                        }

                        if (message.Contains("<Gyro>"))
                        {
                            try
                            {
                                GyroX = Double.Parse(message.Split("\t")[1]);
                                GyroY = Double.Parse(message.Split("\t")[2]);
                                GyroZ = Double.Parse(message.Split("\t")[3]);
                                if (maxGyroX < GyroX)
                                {
                                    maxGyroX = GyroX;
                                }
                                if (maxGyroY < GyroY)
                                {
                                    maxGyroY = GyroY;
                                }
                                if (maxGyroZ < GyroZ)
                                {
                                    maxGyroZ = GyroZ;
                                }
                                if (minGyroX > GyroX)
                                {
                                    minGyroX = GyroX;
                                }
                                if (minGyroY > GyroY)
                                {
                                    minGyroY = GyroY;
                                }
                                if (minGyroZ > GyroZ)
                                {
                                    minGyroZ = GyroZ;
                                }
                                txtGyroX.Text = GyroX.ToString();
                                txtGyroY.Text = GyroY.ToString();
                                txtGyroZ.Text = GyroZ.ToString();
                                txtMaxGyroX.Text = maxGyroX.ToString();
                                txtMaxGyroY.Text = maxGyroY.ToString();
                                txtMaxGyroZ.Text = maxGyroZ.ToString();
                                txtMinGyroX.Text = minGyroX.ToString();
                                txtMinGyroY.Text = minGyroY.ToString();
                                txtMinGyroZ.Text = minGyroZ.ToString();
                            }
                            catch (Exception ex)
                            {
                                tbMessage.AppendText(System.DateTime.Now + "\t" + ex.Message.ToString() + Environment.NewLine);
                            }
                        }

                    });
                    if (!String.IsNullOrEmpty(tbArchive.Text))
                    {
                        SaveToFile(System.DateTime.Now + "\t" + message, tbArchive.Text);
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
                    End_connection();
                    btConect.Invoke((MethodInvoker)delegate
                    {
                        btConect.Enabled = true;
                    });
                }
            }
        }
        private void End_connection()
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

            _serialPort = new SerialPort
            {
                // Allow the user to set the appropriate properties.
                PortName = cbPorts.SelectedValue.ToString(),
                BaudRate = (int)numBaudRate.Value,
                Parity = Enum.Parse<Parity>(cbParity.SelectedValue.ToString()),
                DataBits = 8,
                StopBits = Enum.Parse<StopBits>(cbStopBits.SelectedValue.ToString()),
                Handshake = Enum.Parse<Handshake>(cbHandShake.SelectedValue.ToString()),
                ReadTimeout = 5000,
                WriteTimeout = 5000,

                // Indicates the device that the system is ready to recive data
                RtsEnable = chkRTS.Checked,
                DtrEnable = chkDTR.Checked
            };

            _serialPort.Open();
            _continue = true;

            readThread = new Thread(Read)
            {
                IsBackground = true
            };
            readThread.Start();
            btConect.Enabled = false;
            timeThread = new Thread(Time)
            {
                IsBackground = true
            };
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
            End_connection();
            btConect.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            End_connection();
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
            int cambio_hor = this.Width - this.MinimumSize.Width;
            int cambio_ver = this.Height - this.MinimumSize.Height;
            if (chkGraph.Checked)
            {
                cambio_hor = this.Width - (this.MinimumSize.Width + tabControl1.MinimumSize.Width);
            }

            tabControl1.Width = tabControl1.MinimumSize.Width + cambio_hor;

            tbMessage.Height = tbMessage.MinimumSize.Height + cambio_ver;
            tabControl1.Height = tabControl1.MinimumSize.Height + cambio_ver;
        }
    }
}
