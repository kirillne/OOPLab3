namespace Transports.SityTransports
{
    public class Route
    {
        public Route(Position from, Position to, int number)
        {
            From = from;
            To = to;
            Number = number;
        }

        public Route()
        {
            From = new Position();
            To = new Position();
            Number = 1;
        }

        public Position From { get; set; }

        public Position To { get; set; }

        public int Number { get; set; }

    }
}