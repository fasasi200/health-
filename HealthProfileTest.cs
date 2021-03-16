// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hpe1 = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hpe1.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hpe1.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hpe1.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hpe1.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hpe1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hpe1.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hpe1.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hpe1.Gender = Convert.ToString(Console.ReadLine());

        
        
        hpe1.DisplayFirstName();
        hpe1.DisplayLastName();
        hpe1.DisplayDayOfBirth();
        hpe1.DisplayMonthOfBirth();
        hpe1.DisplayYearOfBirth();
        hpe1.DisplayWeightInPounds();
        hpe1.DisplayHeightInInches();
        hpe1.DisplayGender();
        hpe1.DisplayYearsOfAgeSimple();
        hpe1.DisplayMaxHeartRate();
        hpe1.DisplayTargetHeartRate();
        hpe1.DisplayBodyMassIndex();
        hpe1.DisplayBMIOutput();
        hpe1.DisplayBMIChart();        
    }
}