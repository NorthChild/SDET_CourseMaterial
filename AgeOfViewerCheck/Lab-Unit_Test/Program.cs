using System;

namespace Lab_Unit_Test
{
    public class Program
    {

        static void Main(string[] args) 
        {

            // some quick manual testing
            //int ageOfViewer = 12;
            //int ageOfViewer2 = 15;
            //int ageOfViewer3 = 18;

            //string ageCheck = AvailableClassifications(ageOfViewer);
            //string ageCheck2 = AvailableClassifications(ageOfViewer2);
            //string ageCheck3 = AvailableClassifications(ageOfViewer3);
            //Console.WriteLine(ageCheck);
            //Console.WriteLine(ageCheck2);
            //Console.WriteLine(ageCheck3);
            Console.WriteLine(AvailableClassifications(-1));
        }

        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;

            if (ageOfViewer < 15 && ageOfViewer >= 0)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer < 18 && ageOfViewer >= 0)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else if (ageOfViewer < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            else
            {
                result = "All films are available.";
            }
            
            return result;
        }

    }
}
