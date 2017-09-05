using System;

namespace ConditionalExcersises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainClass.Exercise1();
            MainClass.Excercise2();
            MainClass.Excercise3();
            MainClass.Exercise4();
        }

		public static void Exercise1()
		{
			Console.WriteLine("Enter a number between 1 to 10: ");
			var input = Console.ReadLine();
			var number = Convert.ToInt32(input);
			if (number >= 1 && number <= 10)
			{
				Console.WriteLine("Valid");
			}
			else
			{
				Console.WriteLine("Invalid");
			}
		}

		public static void Excercise2()
		{
			Console.WriteLine("Enter a number: ");
			var number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter another number: ");
			var number2 = Convert.ToInt32(Console.ReadLine());

			var max = (number1 > number2) ? number1 : number2;
			Console.WriteLine("Mac is " + max);
		}

		public static void Excercise3()
		{
			Console.WriteLine("Image Width: ");
			var imageWidth = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Image Length: ");
			var imageLength = Convert.ToInt32(Console.ReadLine());

			var orientation = imageWidth > imageLength ? ImageOrientation.Landscape : ImageOrientation.Portrait;
			Console.WriteLine("Image orientation is " + orientation);
		}

		public enum ImageOrientation
		{
			Landscape,
			Portrait
		}

		public static void Exercise4()
		{
			Console.WriteLine("What is the speed limit? ");
			var speedLimit = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("What is the speed of the car? ");
			var carSpeed = Convert.ToInt32(Console.ReadLine());

			if (carSpeed < speedLimit)
			{
				Console.WriteLine("OK");
			}
			else
			{
				const int kmPerDemeritPoint = 5;
				var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

				if (demeritPoints > 12)
				{
					Console.WriteLine("License Suspended");
				}
				else
				{
					Console.WriteLine("Demerit points: " + demeritPoints);
				}
			}
		}


    }
}
