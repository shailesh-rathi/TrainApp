using TrainApp.Enums;

namespace TrainApp.Interfaces
{
    interface IBogi
    {
        CoachLayoutType CoachLayout {get;set;}
        int MaxSeats { get; set; }
        string SearchSeatCode(int seatNumber);
        
    }
}
