using TrainApp.Interfaces;

namespace TrainApp
{
    class ThreeOneLayout : ISearch
    {
        private readonly string[] alSeats;

        public ThreeOneLayout()
        {
            alSeats = new string[] { "L", "M", "U", "L", "M", "U", "SL", "SU" }; 
        } 

        public string Search(int seatNumber)
        {
            string seatCode = alSeats[((seatNumber - 1) % alSeats.Length)];
            return seatCode; 
        }

    }
}
