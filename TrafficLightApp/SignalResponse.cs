namespace TrafficLightApp
{
    public class SignalResponse
    {
        public SignalColour SouthBound { get; set; }

        public SignalColour WestBound { get; set; }

        public SignalColour NorthBound { get; set; }

        public SignalColour EastBound { get; set; }

        public SignalResponse(SignalColour light1clr, SignalColour light2clr, SignalColour light3clr,SignalColour light4clr)
        {
            SouthBound = light1clr;
            WestBound = light2clr;
            NorthBound = light3clr;
            EastBound = light4clr;

        }
    }
}
