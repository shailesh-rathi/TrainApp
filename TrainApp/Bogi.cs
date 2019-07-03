using System;
using TrainApp.Enums;
using TrainApp.Interfaces;

namespace TrainApp
{
    class Bogi : IBogi
    {
        private int _maxSeats;
        private CoachManager mgr;
        public Bogi(int maxSeats, CoachLayoutType layoutType)
        {
            this.MaxSeats = maxSeats;
            this.CoachLayout = layoutType;
            mgr = new CoachManager(layoutType);
        }

        #region IBogi Members

        public int MaxSeats
        {
            get
            {
                return _maxSeats;
            }
            set
            {
                _maxSeats = value;
            }
        }

        public CoachLayoutType CoachLayout
        {
            get;
            set;
        }

        public string SearchSeatCode(int seatNumber)
        {
            string result = string.Empty;
            if (seatNumber > 0 && seatNumber <= MaxSeats)
            {
                result = mgr.Search(seatNumber);
            }
            else
            {
                throw new ApplicationException("Invalid input");
            }
            return result;
        }

        #endregion
    }
}
