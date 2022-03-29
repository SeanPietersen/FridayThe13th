using System;

namespace FridayThe13th.App
{
    public class CalculateTheAmountOfFridayThirteenthInYear : ICalculateTheAmountOfFridayThirteenthInYear
    {
        public string FridayTheThirteenths(int Start, int End = int.MinValue)
        {
            string fridayTheThirteenths = "";
            
            if(End < Start)
            {
                End = Start;
            }

            for (int year = Start; year <= End; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime dateToTest = new DateTime(year, month, 13);

                    if (dateToTest.DayOfWeek == DayOfWeek.Friday)
                    {
                        fridayTheThirteenths += $"{month}/{dateToTest.Day}/{year} ";
                    }
                }
            }
            return fridayTheThirteenths.Trim();
        }
    }
}
