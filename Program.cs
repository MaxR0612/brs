using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            counter();
        }
        public static void grading()
            {
                Console.WriteLine("Enter the score you reached. max 60 points");
                int score = Convert.ToInt32(Console.ReadLine());
                int MaximumPoints = 60;
                int lowestscore = 20;
                double Note = 1.0D;
              

                if (score <= lowestscore)
                {
                    Note = 5;
                    Console.WriteLine("durchgefallen");
                }
                else if (score >= MaximumPoints)
                {
                    Console.WriteLine("Inkorrekte Eingabe");
                }

                for (int i = score; i < MaximumPoints; i--)
                {
                    Note = Note + 0.1D;
                }
            } 
        public static void grading2()
            {
                
                
                
                Console.WriteLine("Enter reached Points");


            }
       //test

            
        
    }
}