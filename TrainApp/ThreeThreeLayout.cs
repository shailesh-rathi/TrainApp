using TrainApp.Interfaces;

namespace TrainApp
{
    class ThreeThreeLayout : ISearch
    {
        private readonly string[] alSeats;

        public ThreeThreeLayout()
        {
            alSeats = new string[] { "LW", "LM", "LA", "RA", "RM", "RW", "LW", "LM", "LA", "RA", "RM", "RW" };
        }

        public string Search(int seatNumber)
        {
            string seatCode = alSeats[((seatNumber - 1) % alSeats.Length)];
            return seatCode;
        }

    }
}
