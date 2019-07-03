using TrainApp.Enums;
using TrainApp.Interfaces;

namespace TrainApp
{
    class CoachManager
    {
        private ISearch objLayout;
        public CoachLayoutType CoachLayout
        {
            get;
            set;
        }

        public CoachManager(CoachLayoutType coachLayoutType)
        {
            this.CoachLayout = coachLayoutType;
        }

        public string Search(int seatNumber)
        {
            string result = string.Empty;
            switch (CoachLayout)
            {
                case CoachLayoutType.Three_One:
                    objLayout = new ThreeOneLayout();
                    result = objLayout.Search(seatNumber);
                    break;
                case CoachLayoutType.Three_Three:
                    objLayout = new ThreeThreeLayout();
                    result = objLayout.Search(seatNumber);
                    break;
            }
            return result;
        }

    }
}
