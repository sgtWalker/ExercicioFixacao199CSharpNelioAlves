﻿using System;
using System.Globalization;
using ExercicioFixacao199CSharpNelioAlves.Entities;

namespace ExercicioFixacao199CSharpNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var contractObject = RequestContractData();
                ProcessContract();
                PrintContractData();
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"An Application exception ocurred: {ex.Message} \n {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Exception ocurred: {ex.Message} \n {(ex.InnerException != null ? ex.InnerException.Message : "")}");
            }            
        }

        private static Tuple<Contract, int> RequestContractData()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installmentsQuantity = int.Parse(Console.ReadLine());

            return new Tuple<Contract, int>(new Contract(number, date, totalValue, new Installment(date, totalValue)), installmentsQuantity);
        }
        private static void ProcessContract()
        {

        }
        private static void PrintContractData()
        {

        }
    }
}
