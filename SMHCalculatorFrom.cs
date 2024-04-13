using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Newtonsoft.Json.Linq;


namespace SMHCalculator
{
    public partial class Form1 : Form
    {

        public delegate void UpDataListView(string[] UIdata);
        public static UpDataListView UpDataListViewDelegate;
        public Form1()
        {
            InitializeComponent();
            UpDataListViewDelegate += UpDataUI;
            this.cb_size.SelectedIndex = 0;
            this.tb_USD.Text = "3.31";

            wssSendAsync();

        }

        public class Details
        {
            public string personaname { get; set; }
        }

        private void UpDataUI(string[] data)
        {
            if (InvokeRequired)
            {

            }
            else
            {
                this.lab_accounts.Text = data[0];

                float SME = Int64.Parse(data[1]) / 1000000000;
                this.lab_SME.Text = SME.ToString() + " SMH";
                this.lab_EPOCH.Text = data[2];

                
                float SECURITY = Int64.Parse(data[3]) / 1024 /1024 /1024 /1024 /1024;
                this.lab_LAYER.Text = SECURITY.ToString() + " PiB";
                this.lab_ActiveSME.Text = data[4];
            }
        }

        public delegate void AsynUpdataUI(string data);
        private static async Task DoClientWebSocket()
        {
            using (ClientWebSocket ws = new ClientWebSocket())
            {
                Uri serverUri = new Uri("wss://mainnet-explorer-api.spacemesh.network/ws/network-info");

                //Implementation of timeout of 5000 ms
                var source = new CancellationTokenSource();
                source.CancelAfter(5000);

                await ws.ConnectAsync(serverUri, source.Token);
                var iterationNo = 0;
                // restricted to 5 iteration only
                while (ws.State == WebSocketState.Open && iterationNo++ < 5)
                {
                    
                    var receiveBuffer = new byte[10240];
                    //Multipacket response
                    var offset = 0;
                    var dataPerPacket = 10240; //Just for example
                    while (true)
                    {
                        ArraySegment<byte> bytesReceived = new ArraySegment<byte>(receiveBuffer, offset, dataPerPacket);
                        WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, source.Token);
                        string ResponseMsg = Encoding.UTF8.GetString(receiveBuffer, offset,result.Count);

                        JObject json = JObject.Parse(ResponseMsg);
                        String[] DataInfo = new String[5];
                        DataInfo[0] = json["epoch"]["stats"]["current"]["accounts"].ToString();
                        DataInfo[1] = json["epoch"]["stats"]["current"]["rewards"].ToString();
                        DataInfo[2] = json["epoch"]["number"].ToString();
                        DataInfo[3] = json["epoch"]["stats"]["current"]["security"].ToString();
                        DataInfo[4] = json["epoch"]["stats"]["current"]["smeshers"].ToString();
                        UpDataListViewDelegate(DataInfo);
                    }
  
                }
            }
        }
        public async Task wssSendAsync()
        {

            try
            {
                DoClientWebSocket();
                var taskWebConnect = Task.Run(() => DoClientWebSocket());
                //taskWebConnect.Wait();
            }
            catch(Exception ex)
            {

            }



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                tb_Size.Text = trackBar1.Value.ToString();
                int SelectedIndex = this.cb_size.SelectedIndex;
                double nPSize = 0;
                switch (SelectedIndex)
                {
                    case 0:
                        nPSize = double.Parse(trackBar1.Value.ToString()) / 1024 / 1024;
                        break;
                    case 1:
                        nPSize = double.Parse(trackBar1.Value.ToString()) / 1024;
                        break;
                    case 2:
                        nPSize = double.Parse(trackBar1.Value.ToString());
                        break;
                }


                string PIB = this.lab_LAYER.Text.Substring(0, this.lab_LAYER.Text.Length - 4);
                double nSMH = nPSize / double.Parse(PIB);

                double nDSMH = nSMH * 135000;

                this.lb_DailySMH.Text = String.Format("{0:f2}", nDSMH) + " SMH / Day";

                double nMSMH = nSMH * 135000 * 30;
                this.lb_MonthlySMH.Text = String.Format("{0:f2}", nMSMH) + " SMH / month";


                double DUSD = nDSMH * double.Parse(this.tb_USD.Text);
                this.lb_DaliyUSD.Text = "$" + String.Format("{0:f2}", DUSD) + "  / Day";

                double MUSD = nMSMH * double.Parse(this.tb_USD.Text);
                this.lb_MouthlyUSD.Text = "$" + String.Format("{0:f2}", MUSD) + "  / month";
            }
            catch(Exception ex)
            {

            }
    



        }
    }
}
