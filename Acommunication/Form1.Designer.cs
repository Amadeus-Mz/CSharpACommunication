
namespace Acommunication
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTCPclient = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEndlineClient = new System.Windows.Forms.CheckBox();
            this.btnClientDisconnect = new System.Windows.Forms.Button();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.tbClientRecvhex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClientSendhex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientRecv = new System.Windows.Forms.TextBox();
            this.tbClientSend = new System.Windows.Forms.TextBox();
            this.tbClientPort = new System.Windows.Forms.TextBox();
            this.tbClientIPaddress = new System.Windows.Forms.TextBox();
            this.tabTCPserver = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEndlineServer = new System.Windows.Forms.CheckBox();
            this.btnServerSend = new System.Windows.Forms.Button();
            this.tbServerRecvhex = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbServerSendhex = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbServerRecv = new System.Windows.Forms.TextBox();
            this.tbServerSend = new System.Windows.Forms.TextBox();
            this.btnServerOpen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tabModbusTCP = new System.Windows.Forms.TabPage();
            this.btnModbusDisconnect = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbModbusRegister = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbModbusSend = new System.Windows.Forms.TextBox();
            this.btnModbusSend = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tbModbusRecv = new System.Windows.Forms.TextBox();
            this.btnModbusConnect = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tbModbusPort = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbModbusIPaddress = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabTCPclient.SuspendLayout();
            this.tabTCPserver.SuspendLayout();
            this.tabModbusTCP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTCPclient);
            this.tabControl.Controls.Add(this.tabTCPserver);
            this.tabControl.Controls.Add(this.tabModbusTCP);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 440);
            this.tabControl.TabIndex = 0;
            // 
            // tabTCPclient
            // 
            this.tabTCPclient.Controls.Add(this.label8);
            this.tabTCPclient.Controls.Add(this.label7);
            this.tabTCPclient.Controls.Add(this.cbEndlineClient);
            this.tabTCPclient.Controls.Add(this.btnClientDisconnect);
            this.tabTCPclient.Controls.Add(this.btnClientSend);
            this.tabTCPclient.Controls.Add(this.btnClientConnect);
            this.tabTCPclient.Controls.Add(this.tbClientRecvhex);
            this.tabTCPclient.Controls.Add(this.label6);
            this.tabTCPclient.Controls.Add(this.label5);
            this.tabTCPclient.Controls.Add(this.tbClientSendhex);
            this.tabTCPclient.Controls.Add(this.label4);
            this.tabTCPclient.Controls.Add(this.label3);
            this.tabTCPclient.Controls.Add(this.label2);
            this.tabTCPclient.Controls.Add(this.label1);
            this.tabTCPclient.Controls.Add(this.tbClientRecv);
            this.tabTCPclient.Controls.Add(this.tbClientSend);
            this.tabTCPclient.Controls.Add(this.tbClientPort);
            this.tabTCPclient.Controls.Add(this.tbClientIPaddress);
            this.tabTCPclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabTCPclient.Location = new System.Drawing.Point(4, 22);
            this.tabTCPclient.Name = "tabTCPclient";
            this.tabTCPclient.Padding = new System.Windows.Forms.Padding(3);
            this.tabTCPclient.Size = new System.Drawing.Size(792, 414);
            this.tabTCPclient.TabIndex = 0;
            this.tabTCPclient.Text = "TCP Client";
            this.tabTCPclient.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "(0)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "(0)";
            // 
            // cbEndlineClient
            // 
            this.cbEndlineClient.AutoSize = true;
            this.cbEndlineClient.Enabled = false;
            this.cbEndlineClient.Location = new System.Drawing.Point(431, 101);
            this.cbEndlineClient.Name = "cbEndlineClient";
            this.cbEndlineClient.Size = new System.Drawing.Size(81, 24);
            this.cbEndlineClient.TabIndex = 15;
            this.cbEndlineClient.Text = "add \\r\\n";
            this.cbEndlineClient.UseVisualStyleBackColor = true;
            // 
            // btnClientDisconnect
            // 
            this.btnClientDisconnect.Enabled = false;
            this.btnClientDisconnect.Location = new System.Drawing.Point(353, 29);
            this.btnClientDisconnect.Name = "btnClientDisconnect";
            this.btnClientDisconnect.Size = new System.Drawing.Size(110, 49);
            this.btnClientDisconnect.TabIndex = 14;
            this.btnClientDisconnect.Text = "Disconnect";
            this.btnClientDisconnect.UseVisualStyleBackColor = true;
            this.btnClientDisconnect.Click += new System.EventHandler(this.btnClientDisconnect_Click);
            // 
            // btnClientSend
            // 
            this.btnClientSend.Enabled = false;
            this.btnClientSend.Location = new System.Drawing.Point(518, 88);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(110, 49);
            this.btnClientSend.TabIndex = 13;
            this.btnClientSend.Text = "Send";
            this.btnClientSend.UseVisualStyleBackColor = true;
            this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.Location = new System.Drawing.Point(227, 29);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(110, 49);
            this.btnClientConnect.TabIndex = 12;
            this.btnClientConnect.Text = "Connect";
            this.btnClientConnect.UseVisualStyleBackColor = true;
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // tbClientRecvhex
            // 
            this.tbClientRecvhex.Location = new System.Drawing.Point(22, 317);
            this.tbClientRecvhex.Multiline = true;
            this.tbClientRecvhex.Name = "tbClientRecvhex";
            this.tbClientRecvhex.ReadOnly = true;
            this.tbClientRecvhex.Size = new System.Drawing.Size(745, 71);
            this.tbClientRecvhex.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "DataRecv (HEX)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DataSend (HEX)";
            // 
            // tbClientSendhex
            // 
            this.tbClientSendhex.Location = new System.Drawing.Point(22, 156);
            this.tbClientSendhex.Multiline = true;
            this.tbClientSendhex.Name = "tbClientSendhex";
            this.tbClientSendhex.ReadOnly = true;
            this.tbClientSendhex.Size = new System.Drawing.Size(745, 71);
            this.tbClientSendhex.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "DataRecv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataSend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IPAddress";
            // 
            // tbClientRecv
            // 
            this.tbClientRecv.Location = new System.Drawing.Point(22, 258);
            this.tbClientRecv.Name = "tbClientRecv";
            this.tbClientRecv.ReadOnly = true;
            this.tbClientRecv.Size = new System.Drawing.Size(745, 26);
            this.tbClientRecv.TabIndex = 3;
            // 
            // tbClientSend
            // 
            this.tbClientSend.Location = new System.Drawing.Point(22, 99);
            this.tbClientSend.Name = "tbClientSend";
            this.tbClientSend.Size = new System.Drawing.Size(403, 26);
            this.tbClientSend.TabIndex = 2;
            this.tbClientSend.Text = "Hello world";
            // 
            // tbClientPort
            // 
            this.tbClientPort.Location = new System.Drawing.Point(131, 40);
            this.tbClientPort.Name = "tbClientPort";
            this.tbClientPort.Size = new System.Drawing.Size(75, 26);
            this.tbClientPort.TabIndex = 1;
            this.tbClientPort.Text = "21";
            this.tbClientPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClientPort_KeyPress);
            // 
            // tbClientIPaddress
            // 
            this.tbClientIPaddress.Location = new System.Drawing.Point(22, 40);
            this.tbClientIPaddress.Name = "tbClientIPaddress";
            this.tbClientIPaddress.Size = new System.Drawing.Size(103, 26);
            this.tbClientIPaddress.TabIndex = 0;
            this.tbClientIPaddress.Text = "127.0.0.1";
            // 
            // tabTCPserver
            // 
            this.tabTCPserver.Controls.Add(this.label10);
            this.tabTCPserver.Controls.Add(this.label11);
            this.tabTCPserver.Controls.Add(this.cbEndlineServer);
            this.tabTCPserver.Controls.Add(this.btnServerSend);
            this.tabTCPserver.Controls.Add(this.tbServerRecvhex);
            this.tabTCPserver.Controls.Add(this.label12);
            this.tabTCPserver.Controls.Add(this.label13);
            this.tabTCPserver.Controls.Add(this.tbServerSendhex);
            this.tabTCPserver.Controls.Add(this.label14);
            this.tabTCPserver.Controls.Add(this.label15);
            this.tabTCPserver.Controls.Add(this.tbServerRecv);
            this.tabTCPserver.Controls.Add(this.tbServerSend);
            this.tabTCPserver.Controls.Add(this.btnServerOpen);
            this.tabTCPserver.Controls.Add(this.label9);
            this.tabTCPserver.Controls.Add(this.tbServerPort);
            this.tabTCPserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabTCPserver.Location = new System.Drawing.Point(4, 22);
            this.tabTCPserver.Name = "tabTCPserver";
            this.tabTCPserver.Padding = new System.Windows.Forms.Padding(3);
            this.tabTCPserver.Size = new System.Drawing.Size(792, 414);
            this.tabTCPserver.TabIndex = 1;
            this.tabTCPserver.Text = "TCP Server";
            this.tabTCPserver.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "(0)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "(0)";
            // 
            // cbEndlineServer
            // 
            this.cbEndlineServer.AutoSize = true;
            this.cbEndlineServer.Enabled = false;
            this.cbEndlineServer.Location = new System.Drawing.Point(430, 110);
            this.cbEndlineServer.Name = "cbEndlineServer";
            this.cbEndlineServer.Size = new System.Drawing.Size(81, 24);
            this.cbEndlineServer.TabIndex = 27;
            this.cbEndlineServer.Text = "add \\r\\n";
            this.cbEndlineServer.UseVisualStyleBackColor = true;
            // 
            // btnServerSend
            // 
            this.btnServerSend.Enabled = false;
            this.btnServerSend.Location = new System.Drawing.Point(517, 97);
            this.btnServerSend.Name = "btnServerSend";
            this.btnServerSend.Size = new System.Drawing.Size(110, 49);
            this.btnServerSend.TabIndex = 26;
            this.btnServerSend.Text = "Send";
            this.btnServerSend.UseVisualStyleBackColor = true;
            this.btnServerSend.Click += new System.EventHandler(this.btnServerSend_Click);
            // 
            // tbServerRecvhex
            // 
            this.tbServerRecvhex.Location = new System.Drawing.Point(21, 326);
            this.tbServerRecvhex.Multiline = true;
            this.tbServerRecvhex.Name = "tbServerRecvhex";
            this.tbServerRecvhex.ReadOnly = true;
            this.tbServerRecvhex.Size = new System.Drawing.Size(745, 71);
            this.tbServerRecvhex.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "DataRecv (HEX)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "DataSend (HEX)";
            // 
            // tbServerSendhex
            // 
            this.tbServerSendhex.Location = new System.Drawing.Point(21, 165);
            this.tbServerSendhex.Multiline = true;
            this.tbServerSendhex.Name = "tbServerSendhex";
            this.tbServerSendhex.ReadOnly = true;
            this.tbServerSendhex.Size = new System.Drawing.Size(745, 71);
            this.tbServerSendhex.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "DataRecv";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "DataSend";
            // 
            // tbServerRecv
            // 
            this.tbServerRecv.Location = new System.Drawing.Point(21, 267);
            this.tbServerRecv.Name = "tbServerRecv";
            this.tbServerRecv.ReadOnly = true;
            this.tbServerRecv.Size = new System.Drawing.Size(745, 26);
            this.tbServerRecv.TabIndex = 19;
            // 
            // tbServerSend
            // 
            this.tbServerSend.Location = new System.Drawing.Point(21, 108);
            this.tbServerSend.Name = "tbServerSend";
            this.tbServerSend.Size = new System.Drawing.Size(403, 26);
            this.tbServerSend.TabIndex = 18;
            this.tbServerSend.Text = "Hello world";
            // 
            // btnServerOpen
            // 
            this.btnServerOpen.Location = new System.Drawing.Point(114, 15);
            this.btnServerOpen.Name = "btnServerOpen";
            this.btnServerOpen.Size = new System.Drawing.Size(110, 49);
            this.btnServerOpen.TabIndex = 15;
            this.btnServerOpen.Text = "Open";
            this.btnServerOpen.UseVisualStyleBackColor = true;
            this.btnServerOpen.Click += new System.EventHandler(this.btnServerOpen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Port";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(22, 38);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(75, 26);
            this.tbServerPort.TabIndex = 13;
            this.tbServerPort.Text = "21";
            // 
            // tabModbusTCP
            // 
            this.tabModbusTCP.Controls.Add(this.btnModbusDisconnect);
            this.tabModbusTCP.Controls.Add(this.label16);
            this.tabModbusTCP.Controls.Add(this.tbModbusRegister);
            this.tabModbusTCP.Controls.Add(this.label17);
            this.tabModbusTCP.Controls.Add(this.tbModbusSend);
            this.tabModbusTCP.Controls.Add(this.btnModbusSend);
            this.tabModbusTCP.Controls.Add(this.label18);
            this.tabModbusTCP.Controls.Add(this.tbModbusRecv);
            this.tabModbusTCP.Controls.Add(this.btnModbusConnect);
            this.tabModbusTCP.Controls.Add(this.label19);
            this.tabModbusTCP.Controls.Add(this.tbModbusPort);
            this.tabModbusTCP.Controls.Add(this.label20);
            this.tabModbusTCP.Controls.Add(this.tbModbusIPaddress);
            this.tabModbusTCP.Location = new System.Drawing.Point(4, 22);
            this.tabModbusTCP.Name = "tabModbusTCP";
            this.tabModbusTCP.Size = new System.Drawing.Size(792, 414);
            this.tabModbusTCP.TabIndex = 2;
            this.tabModbusTCP.Text = "ModbusTCP";
            this.tabModbusTCP.UseVisualStyleBackColor = true;
            // 
            // btnModbusDisconnect
            // 
            this.btnModbusDisconnect.Enabled = false;
            this.btnModbusDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModbusDisconnect.Location = new System.Drawing.Point(225, 150);
            this.btnModbusDisconnect.Name = "btnModbusDisconnect";
            this.btnModbusDisconnect.Size = new System.Drawing.Size(178, 48);
            this.btnModbusDisconnect.TabIndex = 49;
            this.btnModbusDisconnect.Text = "Disconnect";
            this.btnModbusDisconnect.UseVisualStyleBackColor = true;
            this.btnModbusDisconnect.Click += new System.EventHandler(this.btnModbusDisconnect_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(27, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "Register Address";
            // 
            // tbModbusRegister
            // 
            this.tbModbusRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbModbusRegister.Location = new System.Drawing.Point(31, 107);
            this.tbModbusRegister.Name = "tbModbusRegister";
            this.tbModbusRegister.Size = new System.Drawing.Size(119, 26);
            this.tbModbusRegister.TabIndex = 47;
            this.tbModbusRegister.Text = "1002";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(28, 271);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "Send Register Data";
            // 
            // tbModbusSend
            // 
            this.tbModbusSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbModbusSend.Location = new System.Drawing.Point(32, 297);
            this.tbModbusSend.Name = "tbModbusSend";
            this.tbModbusSend.Size = new System.Drawing.Size(177, 26);
            this.tbModbusSend.TabIndex = 45;
            // 
            // btnModbusSend
            // 
            this.btnModbusSend.Enabled = false;
            this.btnModbusSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModbusSend.Location = new System.Drawing.Point(225, 271);
            this.btnModbusSend.Name = "btnModbusSend";
            this.btnModbusSend.Size = new System.Drawing.Size(75, 52);
            this.btnModbusSend.TabIndex = 44;
            this.btnModbusSend.Text = "Send";
            this.btnModbusSend.UseVisualStyleBackColor = true;
            this.btnModbusSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(28, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 20);
            this.label18.TabIndex = 43;
            this.label18.Text = "Recv Register Data";
            // 
            // tbModbusRecv
            // 
            this.tbModbusRecv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbModbusRecv.Location = new System.Drawing.Point(31, 234);
            this.tbModbusRecv.Name = "tbModbusRecv";
            this.tbModbusRecv.Size = new System.Drawing.Size(178, 26);
            this.tbModbusRecv.TabIndex = 42;
            // 
            // btnModbusConnect
            // 
            this.btnModbusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModbusConnect.Location = new System.Drawing.Point(31, 150);
            this.btnModbusConnect.Name = "btnModbusConnect";
            this.btnModbusConnect.Size = new System.Drawing.Size(178, 48);
            this.btnModbusConnect.TabIndex = 41;
            this.btnModbusConnect.Text = "Connect";
            this.btnModbusConnect.UseVisualStyleBackColor = true;
            this.btnModbusConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(152, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 20);
            this.label19.TabIndex = 40;
            this.label19.Text = "Port";
            // 
            // tbModbusPort
            // 
            this.tbModbusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbModbusPort.Location = new System.Drawing.Point(156, 55);
            this.tbModbusPort.Name = "tbModbusPort";
            this.tbModbusPort.Size = new System.Drawing.Size(53, 26);
            this.tbModbusPort.TabIndex = 39;
            this.tbModbusPort.Text = "502";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(26, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "IPAddress";
            // 
            // tbModbusIPaddress
            // 
            this.tbModbusIPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbModbusIPaddress.Location = new System.Drawing.Point(30, 55);
            this.tbModbusIPaddress.Name = "tbModbusIPaddress";
            this.tbModbusIPaddress.Size = new System.Drawing.Size(120, 26);
            this.tbModbusIPaddress.TabIndex = 37;
            this.tbModbusIPaddress.Text = "192.168.1.85";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Test Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabTCPclient.ResumeLayout(false);
            this.tabTCPclient.PerformLayout();
            this.tabTCPserver.ResumeLayout(false);
            this.tabTCPserver.PerformLayout();
            this.tabModbusTCP.ResumeLayout(false);
            this.tabModbusTCP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTCPclient;
        private System.Windows.Forms.TabPage tabTCPserver;
        private System.Windows.Forms.TextBox tbClientRecvhex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClientSendhex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientRecv;
        private System.Windows.Forms.TextBox tbClientSend;
        private System.Windows.Forms.TextBox tbClientPort;
        private System.Windows.Forms.TextBox tbClientIPaddress;
        private System.Windows.Forms.TabPage tabModbusTCP;
        private System.Windows.Forms.Button btnClientSend;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.Button btnClientDisconnect;
        private System.Windows.Forms.CheckBox cbEndlineClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbEndlineServer;
        private System.Windows.Forms.Button btnServerSend;
        private System.Windows.Forms.TextBox tbServerRecvhex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbServerSendhex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbServerRecv;
        private System.Windows.Forms.TextBox tbServerSend;
        private System.Windows.Forms.Button btnServerOpen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbModbusRegister;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbModbusSend;
        private System.Windows.Forms.Button btnModbusSend;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbModbusRecv;
        private System.Windows.Forms.Button btnModbusConnect;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbModbusPort;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbModbusIPaddress;
        private System.Windows.Forms.Button btnModbusDisconnect;
    }
}

