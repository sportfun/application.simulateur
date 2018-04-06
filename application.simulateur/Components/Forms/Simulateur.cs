using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application.simulateur
{
    public partial class Simulateur : Form
    {

        Classes.WebSocketIO webSocketIO;
        Timer TimerInterval = new Timer();
        public Simulateur()
        {

            Components.Forms.LoginForm newLoginForm = new Components.Forms.LoginForm();
            if (newLoginForm.ShowDialog() == DialogResult.OK)
            {
                InitializeComponent();

                Classes.WebSocketIO.GetInstance().Connect();
                Classes.WebSocketIO.GetInstance().RegisterChannel("command", OnCommandMessageReceived);

                JObject body = new JObject();
                body.Add("command", "link");

                Classes.WebSocketIO.GetInstance().SendBody("command", body);
                TimerInterval.Tick += TimerInterval_Tick;
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void TimerInterval_Tick(object sender, EventArgs e)
        {
            Decimal rpm = GenerateRPM();

            JObject body = new JObject();
            body.Add("module", "rpm");
            body.Add("value", rpm);

            Classes.WebSocketIO.GetInstance().SendBody("command", body);

            DateTime dt = DateTime.Now;
            textBox.AppendText("[" + dt.Hour + ":" + dt.Minute + ":" + dt.Second + ":" + dt.Millisecond + "]  \t\tRPM: " + rpm + ".\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Private methods

        private Decimal GenerateRPM()
        {
            Decimal rpm = numRPM.Value;
            Random rand = new Random();

            decimal min = numVariationMin.Value;
            decimal max = numVariationMax.Value;

            if (min > max)
            {
                min = numVariationMax.Value;
                max = numVariationMin.Value;
            }

            if (rand.Next(0, 2) == 0)
                rpm += rand.Next(Convert.ToInt32(min), Convert.ToInt32(max));
            else
                rpm -= rand.Next(Convert.ToInt32(min), Convert.ToInt32(max));

            return rpm;
        }

        #endregion Private methods

        #region Events

        #region TimerTick

        private void sendInterval_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");

            textBox.AppendText("tick");
        }

        #endregion TimerTick

        #endregion Events

        #region Web Socket

        #region Channels

        public bool OnCommandMessageReceived(Classes.EventSocketArgs args)
        {
            JObject JsonObject = JObject.Parse(args.Data.ToString());

            switch (JsonObject["body"]["command"].ToString())
            {
                case "start_game":
                    this.Invoke(new Action(() =>
                    {
                        TimerInterval.Interval = 500;
                        TimerInterval.Start();
                    }));

                    break;

                case "stop_game":
                    this.Invoke(new Action(() =>
                    {
                        TimerInterval.Stop();
                    }));
                    break;
            }

            return false;
        }


        #endregion Channels

        #endregion Web Socket

        #region Controller buttons
        private void btnLeftButtonUpper_Click(object sender, EventArgs e)
        {
            JObject body = new JObject();
            body.Add("module", "controller");
            body.Add("value", "0");

            Classes.WebSocketIO.GetInstance().SendBody("command", body);

            DateTime dt = DateTime.Now;
            textBox.AppendText("[" + dt.Hour + ":" + dt.Minute + ":" + dt.Second + ":" + dt.Millisecond + "]\t" + body.ToString(Newtonsoft.Json.Formatting.None) + ".\n");

        }

        private void btnLeftButtonLower_Click(object sender, EventArgs e)
        {
            JObject body = new JObject();
            body.Add("module", "controller");
            body.Add("value", "1");

            Classes.WebSocketIO.GetInstance().SendBody("command", body);

            DateTime dt = DateTime.Now;
            textBox.AppendText("[" + dt.Hour + ":" + dt.Minute + ":" + dt.Second + ":" + dt.Millisecond + "]\t" + body.ToString(Newtonsoft.Json.Formatting.None) + ".\n");

        }

        private void btnRightButtonUpper_Click(object sender, EventArgs e)
        {
            JObject body = new JObject();
            body.Add("module", "controller");
            body.Add("value", "2");

            Classes.WebSocketIO.GetInstance().SendBody("command", body);

            DateTime dt = DateTime.Now;
            textBox.AppendText("[" + dt.Hour + ":" + dt.Minute + ":" + dt.Second + ":" + dt.Millisecond + "]\t" + body.ToString(Newtonsoft.Json.Formatting.None) + ".\n");

        }

        private void btnRightButtonLower_Click(object sender, EventArgs e)
        {
            JObject body = new JObject();
            body.Add("module", "controller");
            body.Add("value", "3");

            Classes.WebSocketIO.GetInstance().SendBody("command", body);

            DateTime dt = DateTime.Now;
            textBox.AppendText("[" + dt.Hour + ":" + dt.Minute + ":" + dt.Second + ":" + dt.Millisecond + "]\t" + body.ToString(Newtonsoft.Json.Formatting.None) + ".\n");

        }

        #endregion Controller buttons
    }
}
