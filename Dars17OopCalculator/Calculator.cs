using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars17OopCalculator
{
    public class Calculator
    {
        private double FirstNumber { get; set; } = 0;
        private string Operation { get; set; } = string.Empty;
        private double SecondNumber { get; set; } = 0;
        private double Result { get; set; } = 0;
        
        public void Start()
        {            
            while (true)
            {
                Console.WriteLine("Calculator dasturi");

                FirstNumber = ParseNumber();
                Operation = ValidateOperation();
                SecondNumber = ParseNumber();
                Result = GetResult();
                ResultMessage();

                Result = Math.Pow(FirstNumber, SecondNumber);
                Console.WriteLine($"bu ikkita son Darajaga oshirilganda natija:{Result}");
            }
        }

        public double ParseNumber()
        {
            bool parsingResult = false;
            double result = 0;

            while (!parsingResult)
            {
                Console.WriteLine("Son kiriting:");
                string numberString = Console.ReadLine()!;
                parsingResult = double.TryParse(numberString, out result);
            }
            return result;
        }

        private string ValidateOperation()
        {
            string operation = string.Empty;
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "^")
            {
                Console.WriteLine("Amalni kiriting (+ - * / ^):");
                operation = Console.ReadLine()!;
                //Console.WriteLine("Iltimos, faqat yuqorida berilgan amallardan birini kiriting (+ - * /)");
            }
            return operation;
        }

        private double GetResult()
        {
            double result = Operation switch
            {
                "+" => FirstNumber + SecondNumber,
                "-" => FirstNumber - SecondNumber,
                "*" => FirstNumber * SecondNumber,
                "/" => FirstNumber / SecondNumber,
                "^" => Math.Pow(FirstNumber, SecondNumber),
            };

            return result;
        }

        private void ResultMessage()
        {
            Console.WriteLine($"Natija: {FirstNumber} {Operation} {SecondNumber} = {Result}");
            Console.WriteLine();
        }
    }
}
