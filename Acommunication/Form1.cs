using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using EasyModbus;


namespace Acommunication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //// Tab Client Program
        TcpClient mtcpClient = null;
        StreamReader ClientReader = null;
        NetworkStream Clientstream = null;

        Thread TThreadClientRead = null;
        bool TThreadClientRead_Stage = false;

        //// Tab Server Program
        TcpListener mtcpServer = null;
        TcpClient Client = null;
        NetworkStream Serverstram = null;

        Thread TThreadServerRead = null;
        bool TThreadServerRead_Stage = false;
        bool ServerStage = false;

        //// Tab Modbus Program
        Thread TThreadModbus = null;
        ModbusClient modbusClient = null;

        bool TThreadModbusRead_Stage = false;
        int register_data = 0;

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        // Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            TThreadClientRead_Stage = false;
            label7.Text = "(0)";
            label8.Text = "(0)";

            TThreadServerRead_Stage = false;
            ServerStage = false;

            TThreadModbusRead_Stage = false;
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        // Thread Client loop
        private void ThreadClientRead()
        {
            while (TThreadClientRead_Stage)
            {
                string rawMsg = ReadData(mtcpClient,Clientstream,ClientReader);
                string[] Msg = rawMsg.Split(new string[] { "\r\n" }, StringSplitOptions.None);

                tbClientRecv.Invoke(new Action (() => tbClientRecv.Text = Msg[0]));
                tbClientRecvhex.Invoke(new Action (() => tbClientRecvhex.Text = StrToHex(Msg[0])));
                label8.Invoke(new Action (() => label8.Text = '(' + Msg[0].Length.ToString() + ')'));
            }
        }
        // Tab Client Program
        private void tbClientPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }         
        }
        public void btnClientConnect_Click(object sender, EventArgs e)
        {
            String ipa = tbClientIPaddress.Text;
            Int32 nport = Convert.ToInt32(tbClientPort.Text);
            try
            {
                mtcpClient = new TcpClient();
                mtcpClient.Connect(ipa, nport);
                //MessageBox.Show("Connect", "Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableUseClient(true);
                TThreadClientRead_Stage = true;
            }    
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ipa = null;
                nport = default;
                EnableUseClient(false);
                TThreadClientRead_Stage = false;
            }

            if (mtcpClient.Client.Connected)
            {
                if (TThreadClientRead == null)
                {
                    TThreadClientRead = new Thread(new ThreadStart(ThreadClientRead));
                    TThreadClientRead.Start();
                }
            }
        }
        private void EnableUseClient(bool stage)
        {
            tbClientSend.Enabled = stage;
            btnClientSend.Enabled = stage;
            cbEndlineClient.Enabled = stage;

            tbClientPort.Enabled = !stage;
            tbClientIPaddress.Enabled = !stage;

            btnClientConnect.Enabled = !stage;
            btnClientDisconnect.Enabled = stage;

            if (stage == true)
            {
                btnClientConnect.BackColor = Color.LightGreen;
            }
            else
            {
                btnClientConnect.BackColor = Color.Transparent;
            }
        }
        private string StrToHex(string hexstring)
        {
            string data = null;
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (char i in hexstring)
                {
                    sb.Append(Convert.ToInt32(i).ToString("X") + " ");
                    data = sb.ToString();
                }         
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "StrToHex", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
        private void btnClientDisconnect_Click(object sender, EventArgs e)
        {
            TThreadClientRead.Abort();
            TThreadClientRead = null;
            mtcpClient.Close();
            EnableUseClient(false);
            tbClientSendhex.Clear();
            tbClientRecvhex.Clear();
            tbClientSend.Clear();
            tbClientRecv.Clear();
            label7.Text = "(0)";
            label8.Text = "(0)";
        }
        public void btnClientSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtcpClient != null)
                {
                    String Clientendline;
                    if (mtcpClient.Client.Connected)
                    {
                        if (cbEndlineClient.Checked == true)
                        {
                            Clientendline = "\r\n";
                        }
                        else
                        {
                            Clientendline = "";
                        }

                        String msg = tbClientSend.Text + Clientendline;
                        Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                        NetworkStream stream = mtcpClient.GetStream();
                        stream.Write(data, 0, data.Length);
                        tbClientSendhex.Text = StrToHex(msg);
                        label7.Text = '('+msg.Length.ToString()+')';
                    }
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Client Send", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ReadData(TcpClient client,NetworkStream stream,StreamReader reader)
        {
            stream = client.GetStream();
            reader = new StreamReader(stream);
            char[] readText = new char[64];
            reader.Read(readText, 0, readText.Length);
            string data = new string(readText);
            Array.Clear(readText, 0, readText.Length);
            return data;
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        // Thread Server loop
        private void ThreadServerRead()
        {
            while (TThreadServerRead_Stage)
            {
                string rawMsg = ReadData2(mtcpServer, Client, Serverstram);        
            }
        }
        // Tab Server loop
        private void EnableUseServer(bool stage)
        {
            tbServerSend.Enabled = stage;
            btnServerSend.Enabled = stage;
            cbEndlineServer.Enabled = stage;

            tbServerPort.Enabled = !stage;

            if (stage == true)
            {
                btnServerOpen.BackColor = Color.LightGreen;
            }
            else
            {
                btnServerOpen.BackColor = Color.Transparent;
            }
        }
        private void btnServerOpen_Click(object sender, EventArgs e)
        {
            ServerStage = !ServerStage;

            if (ServerStage)
            {
                Int32 nport2 = Convert.ToInt32(tbServerPort.Text);
                try
                {
                    mtcpServer = new TcpListener(IPAddress.Any, Convert.ToInt32(tbServerPort.Text));
                    mtcpServer.Start();
                    MessageBox.Show("Opening Port " + nport2.ToString(), "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EnableUseServer(true);
                    btnServerOpen.Text = "Close";

                    if (mtcpServer != null)
                    {
                        if (TThreadServerRead == null)
                        {
                            TThreadServerRead = new Thread(new ThreadStart(ThreadServerRead));
                            TThreadServerRead.Start();
                            TThreadServerRead_Stage = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nport2 = default;
                    EnableUseServer(false);
                    TThreadServerRead_Stage = false;
                    btnServerOpen.Text = "Open";
                }
            }
            else
            {
                TThreadServerRead.Abort();
                TThreadServerRead = null;
                TThreadServerRead_Stage = false;
                mtcpServer.Stop();
                mtcpServer = null;
                EnableUseServer(false);
                btnServerOpen.Text = "Open";
            }
        }
        private void btnServerSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtcpClient != null)
                {
                    String Serverendline;
                    if (mtcpClient.Client.Connected)
                    {
                        if (cbEndlineServer.Checked == true)
                        {
                            Serverendline = "\r\n";
                        }
                        else
                        {
                            Serverendline = "";
                        }

                        //String msg = tbServerSend.Text + Serverendline;
                        //Byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                        //NetworkStream stream = Client.GetStream();
                        //stream.Write(data, 0, data.Length);
                        //tbServerSendhex.Text = StrToHex(msg);
                        //label11.Text = '(' + msg.Length.ToString() + ')';

                        ServerSend(mtcpServer, Client, Serverstram, Serverendline);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Server Send", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ServerSend(TcpListener server, TcpClient client, NetworkStream stream,string Serverendline)
        {
            MessageBox.Show("ok");
            string msg = tbServerSend.Text + Serverendline;
            byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
            stream.Write(data, 0, data.Length);
            tbServerSendhex.Text = StrToHex(msg);
            label11.Text = '(' + msg.Length.ToString() + ')';
        }
        private string ReadData2(TcpListener server,TcpClient client,NetworkStream stream)
        {
            client = server.AcceptTcpClient();
            stream = client.GetStream();

            byte[] readText = new byte[1024];

            string data = null;
            int i;
            while ((i = stream.Read(readText, 0, readText.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(readText, 0, i);

                //data = data.ToUpper();
                //byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                //// Send back a response.
                //stream.Write(msg, 0, msg.Length);

                //string[] Msg = data.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                tbServerRecv.Invoke(new Action(() => tbServerRecv.Text = data));
                tbServerRecvhex.Invoke(new Action(() => tbServerRecvhex.Text = StrToHex(data)));
                label10.Invoke(new Action(() => label10.Text = '(' + data.Length.ToString() + ')'));
            }
            return data;
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
         
        // Thread Modbus loop
        private void ThreadModbus()
        {
            tbModbusRegister.Invoke(new Action(() => register_data = Convert.ToInt32(tbModbusRegister.Text) - 1));

            while (TThreadModbusRead_Stage)
            {
                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(register_data, 1); //Address

                for (int i = 0; i < readHoldingRegisters.Length; i++)
                {
                    try
                    {
                        //Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
                        tbModbusRecv.Invoke(new Action(() => tbModbusRecv.Text = readHoldingRegisters[i].ToString()));
                        Thread.Sleep(100);
                    }
                    catch
                    {
                        // non error
                    }
                }
            }
        }
        // Tab Modbus loop
        private void BtConnect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(tbModbusIPaddress.Text, Convert.ToInt32(tbModbusPort.Text));

                modbusClient.Connect();
                if (modbusClient.Connected == true)
                {
                    MessageBox.Show("Connected " + tbModbusIPaddress.Text + " " + tbModbusPort.Text, "Conencted");
                    btnModbusSend.Enabled = true;
                    EnableUseModbus(false);
                }
                else
                {
                    return;
                }

                if (TThreadModbus == null)
                {
                    TThreadModbus = new Thread(new ThreadStart(ThreadModbus));
                    TThreadModbus.Start();
                    TThreadModbusRead_Stage = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Modbus TCP",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void EnableUseModbus(bool stage)
        {
            btnModbusConnect.Enabled = stage;
            tbModbusIPaddress.Enabled = stage;
            tbModbusPort.Enabled = stage;
            tbModbusRegister.Enabled = stage;
            tbModbusRecv.Enabled = stage;

            btnModbusSend.Enabled = !stage;
            btnModbusDisconnect.Enabled = !stage;
        }
        private void BtSend_Click(object sender, EventArgs e)
        {
            modbusClient.WriteSingleRegister(register_data, Convert.ToInt32(tbModbusSend.Text));
        }
        private void btnModbusDisconnect_Click(object sender, EventArgs e)
        {
            TThreadModbusRead_Stage = false;
            modbusClient.Disconnect();
            modbusClient = null;
            TThreadModbus.Abort();
            TThreadModbus = null;
            EnableUseModbus(true);
            tbModbusRecv.Text = null;
            tbModbusSend.Text = null;
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>


    }
}
