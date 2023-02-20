using System;
namespace Program

{

    class FindAngle

    {

        static void Main(string[] args)

        {
            //hr=> hour, min=> minute
            int hr, min;
            //asking for an hour value
            Console.WriteLine("Enter Hour: ");

            hr = Convert.ToInt32(Console.ReadLine());
            //checking if given hour fits to our condition
            if (hr < 0 || hr > 12)
            {
                Console.WriteLine("Please Enter Hour between 0-12 : ");
                hr = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter Minute: ");

            min = Convert.ToInt32(Console.ReadLine());

            //checking if given minute fits to our condition

            if (min < 0 || min > 59)
            {
                Console.WriteLine("Please Enter The Minute Between 0-59 : ");
                min = Convert.ToInt32(Console.ReadLine());

            }


            double hrDeg = 30 * hr + 0.5 * min;

            double minDeg = min * 6;



            double minToHour = Math.Abs(hrDeg - minDeg);

            double hourToMin = 360 - minToHour;

            Console.WriteLine("Angle from hour to minute hand :{0} ", hourToMin);
            Console.WriteLine("Angle from minute to hour hand : {0} ", minToHour);

            Console.WriteLine("Press Enter to Exit");

            Console.ReadLine();

        }

    }

}