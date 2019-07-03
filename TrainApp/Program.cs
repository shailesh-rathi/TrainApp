using System;

using TrainApp.Interfaces;

namespace TrainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter Seat Number");
                string userInput = Console.ReadLine();
                int inputSeatNo;
                int.TryParse(userInput, out inputSeatNo);
                IBogi bogi = new Bogi(64, Enums.CoachLayoutType.Three_One);

                string seatCode = bogi.SearchSeatCode(inputSeatNo);
                Console.WriteLine(string.Format("Three_One: SeatCode for {0} is {1}", inputSeatNo, seatCode));

                Console.WriteLine("\n");
                IBogi bogi2 = new Bogi(64, Enums.CoachLayoutType.Three_Three);

                seatCode = bogi2.SearchSeatCode(inputSeatNo);
                Console.WriteLine(string.Format("Three_Three: SeatCode for {0} is {1}", inputSeatNo, seatCode));
            }


            catch (ApplicationException ex)
            {
                Console.WriteLine("Business rule voilation " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception occurred " + ex.Message);
            }
            Console.ReadKey();

        }

    }

   
}

