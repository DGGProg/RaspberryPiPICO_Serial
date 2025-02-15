using System.IO.Ports;

namespace RaspberryPiPICO_Serial
{
    public partial class Form1 : Form
    {
        static bool _continue;
        static SerialPort _serialPort = new SerialPort();
        Thread readThread;

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

        public void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    tbMessage.Invoke((MethodInvoker)delegate
                    {
                        tbMessage.AppendText(message + Environment.NewLine);

                    });
                    if (!String.IsNullOrEmpty(tbArchive.Text)) 
                    {
                        saveToFile(message + Environment.NewLine, tbArchive.Text);
                    }
                }
                catch (TimeoutException) { }
                catch (OperationCanceledException) { }
            }
        }

        private void btConect_Click(object sender, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = cbPorts.SelectedValue.ToString();
            _serialPort.BaudRate = (int)numBaudRate.Value;
            _serialPort.Parity = Enum.Parse<Parity>(cbParity.SelectedValue.ToString());
            _serialPort.DataBits = 8;
            _serialPort.StopBits = Enum.Parse<StopBits>(cbStopBits.SelectedValue.ToString());
            _serialPort.Handshake = Enum.Parse<Handshake>(cbHandShake.SelectedValue.ToString());

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 5000;
            _serialPort.WriteTimeout = 5000;

            //indica al dispositivo que el programa esta listo para recibir datos
            _serialPort.RtsEnable = chkRTS.Checked;
            _serialPort.DtrEnable = chkDTR.Checked;

            _serialPort.Open();
            _continue = true;

            readThread = new Thread(Read);
            readThread.IsBackground = true;
            readThread.Start();
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
            _continue = false;
            Task.Run(() =>
            {
                if (readThread != null && readThread.IsAlive)
                {
                    readThread.Join(); 
                }
            });
            _serialPort.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _continue = false;
            Task.Run(() =>
            {
                if (readThread != null && readThread.IsAlive)
                {
                    readThread.Join(); 
                }
            });
            _serialPort.Close();
        }
    }
}
