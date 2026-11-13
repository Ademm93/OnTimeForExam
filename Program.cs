
using System;

namespace OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ExamHour = int.Parse(Console.ReadLine());
            int ExamMinutes = int.Parse(Console.ReadLine());
            int ArrivalHour = int.Parse(Console.ReadLine());
            int ArrivalMinutes = int.Parse(Console.ReadLine());

            int ExamTime = ExamHour * 60 + ExamMinutes;
            int ArrivalTime = ArrivalHour * 60 + ArrivalMinutes;

            int difference = ArrivalTime - ExamTime;

            if (difference > 0)
            {
                Console.WriteLine("Late");
            }
            else if (difference >= -30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            if (difference != 0)
            {
                if (difference < 0)
                {
                    difference = difference * (-1);
                }

                if (difference < 60)
                {
                    if (ArrivalTime < ExamTime)
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{difference} minutes after the start");
                    }
                }
                else
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;

                    if (ArrivalTime < ExamTime)
                    {
                        Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                    }
                }
            }
        }
    }
}
