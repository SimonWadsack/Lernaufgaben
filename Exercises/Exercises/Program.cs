using System;

namespace Exercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Regeln:
            /*
             *
             *  Du kannst alle Methoden benutzen die C# hat.
             *  Du kannst einfach mit Console.Write und Console.WriteLine die Ausgabe machen.
             *  Du musst deine Lösung in Exercises schreiben.
             * 
             */
            
            //Exercise 1:
            //Gib die Zahlen von 1 bis 100 aus, falls eine Zahl durch 3 teilbar ist gib "Fizz" aus und falls eine Zahl durch 5 teilbar ist
            //gib "Buzz" aus. Falls die Zahl durch beides teilbar ist gib "FizzBuzz" aus!
            
            
            Exercises.Ex1_FizzBuzz();
            

            //Exercise 2:
            //Deine Methode nimmt einen String und du sollst ihn umgekehrt ausgeben, also "Test" wird zu "tseT".
            
            
            Exercises.Ex2_ReverseString("Test");
            Exercises.Ex2_ReverseString("lagerregal");
            Exercises.Ex2_ReverseString("Dies ist ein langer String!");
            
            
            //Exercise 3:
            //Du bekommst ein Array von double Zahlen (ungrade Anzahl) und sollst den Durchschnitt und den Median ausgeben!
            // Also bei [1.0, 2.0, 3.0, 4.0, 5.0, 7.0, 9.0] ist der Durchschnitt 4,42... und der Median 4.0.
            
            
            Exercises.Ex3_ArrayOfNumbers(new double[]{1.0, 2.0, 3.0, 4.0, 5.0, 7.0, 9.0});
            Exercises.Ex3_ArrayOfNumbers(new double[]{1.0, 25.0, 231.0, 4.3245, 7.77, 1837.23, 11.11});
            
            
            //Exercise 4:
            //Berechne und gib die n-te Fibonacci Zahl aus, also bei n=1: 0, n=2: 1, n=3: 1, und dann immer n=?: die beiden vorherigen Zahlen addiert


            Exercises.Ex4_Fibonnaci(1);
            Exercises.Ex4_Fibonnaci(2);
            Exercises.Ex4_Fibonnaci(3);
            Exercises.Ex4_Fibonnaci(20);
            Exercises.Ex4_Fibonnaci(50);

        }
    }
}