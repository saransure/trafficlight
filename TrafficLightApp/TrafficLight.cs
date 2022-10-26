using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightApp
{
    public partial class TrafficLight : Form
    {
        static SignalState state;

         const int FIVESECONDS= 5000;
        public TrafficLight()
        {
            InitializeComponent();
        }
        public static Dictionary<SignalColour, Color> SignalColorMapping = new Dictionary<SignalColour, Color>();

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            GetSignalData();
        }

       Timer signalTimer = new Timer();
        private void GetSignalData()
        {
            SetSignalValues(new SignalResponse(SignalColour.GREEN, SignalColour.RED, SignalColour.GREEN, SignalColour.RED));
            signalTimer.Interval = 1;
            signalTimer.Tick += new EventHandler(signalTimer_Tick);
            state = SignalState.ALL_RED_START;
            signalTimer.Enabled = true;

        }

        private void signalTimer_Tick(object sender, EventArgs e)
        {
            signalTimer.Stop();

            switch (state)
            {
                case SignalState.ALL_RED_START:
                    ChangeSignalState(new SignalResponse(SignalColour.GREEN, SignalColour.RED, SignalColour.GREEN, SignalColour.RED), IsPeakHour() ? 30000 : 20000, SignalState.N_GREENRIGHT_S_YELLOW_EW_RED);
                    break;
                case SignalState.N_GREENRIGHT_S_YELLOW_EW_RED:
                    ChangeSignalState(new SignalResponse(SignalColour.YELLOW, SignalColour.RED, SignalColour.GREENRIGHT, SignalColour.RED), FIVESECONDS, SignalState.N_GREENRIGHT_S_RED);
                    break;
                case SignalState.N_GREENRIGHT_S_RED:              
                    ChangeSignalState(new SignalResponse(SignalColour.RED, SignalColour.RED, SignalColour.GREENRIGHT, SignalColour.RED), FIVESECONDS, SignalState.N_YELLOW_S_RED_EW_RED);
                    break;
                case SignalState.N_YELLOW_S_RED_EW_RED:
                    ChangeSignalState(new SignalResponse(SignalColour.RED, SignalColour.RED, SignalColour.YELLOW, SignalColour.RED), FIVESECONDS, SignalState.ALL_RED_MID);
                    break;
                case SignalState.ALL_RED_MID:
                    ChangeSignalState(new SignalResponse(SignalColour.RED, SignalColour.RED, SignalColour.RED, SignalColour.RED), FIVESECONDS, SignalState.NS_RED_EW_GREEN);
                    break;
                case SignalState.NS_RED_EW_GREEN:
                    ChangeSignalState(new SignalResponse(SignalColour.RED, SignalColour.GREEN, SignalColour.RED, SignalColour.GREEN), IsPeakHour() ? 10000 : 20000, SignalState.NS_RED_EW_YELLOW);
                    break;
                case SignalState.NS_RED_EW_YELLOW:
                    ChangeSignalState(new SignalResponse(SignalColour.RED, SignalColour.YELLOW, SignalColour.RED, SignalColour.YELLOW), FIVESECONDS, SignalState.ALL_RED_END);
                    break;
                case SignalState.ALL_RED_END:
                    ChangeSignalState(new SignalResponse(SignalColour.RED, SignalColour.RED, SignalColour.RED, SignalColour.RED), FIVESECONDS, SignalState.ALL_RED_START);
                    break;
            }


        }
        private void ChangeSignalState(SignalResponse responseData,int interval,SignalState stateValue)
        {
            //while exposing a service, this method needs to be replaced with callback to client to provide the state change values
            SetSignalValues(responseData);

            signalTimer.Interval = interval;
            state = stateValue;
            signalTimer.Start();
        }


        public void SetSignalValues(SignalResponse responseData)
        {
            lbl_S_Bound.Text = Convert.ToString(responseData.SouthBound);
            lbl_W_Bound.Text = Convert.ToString(responseData.WestBound);
            lbl_N_Bound.Text = Convert.ToString(responseData.NorthBound);
            lbl_E_Bound.Text = Convert.ToString(responseData.EastBound);

            lbl_S_Bound.BackColor = SignalColorMapping[responseData.SouthBound];
            lbl_W_Bound.BackColor = SignalColorMapping[responseData.WestBound];
            lbl_N_Bound.BackColor = SignalColorMapping[responseData.NorthBound];
            lbl_E_Bound.BackColor = SignalColorMapping[responseData.EastBound];
        }

        private static bool IsPeakHour()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour >= 8 && currentHour < 10 || currentHour >= 17 && currentHour < 19)
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loading values in dictionary
            SignalColorMapping.Add(SignalColour.RED, Color.Red);
            SignalColorMapping.Add(SignalColour.GREEN, Color.Green);
            SignalColorMapping.Add(SignalColour.YELLOW, Color.Yellow);
            SignalColorMapping.Add(SignalColour.GREENRIGHT, Color.Green);
        }

    }
}
