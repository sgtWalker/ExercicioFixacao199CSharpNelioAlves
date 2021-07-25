using System;
using System.Globalization;
using ExercicioFixacao199CSharpNelioAlves.Entities;
using ExercicioFixacao199CSharpNelioAlves.Services;

namespace ExercicioFixacao199CSharpNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var contractObject = RequestContractData();
                PrintContractData(ProcessContract(contractObject));
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
            int installmentsNumber = int.Parse(Console.ReadLine());

            return new Tuple<Contract, int>(new Contract(number, date, totalValue), installmentsNumber);
        }
        private static Contract ProcessContract(Tuple<Contract, int> contractObject)
        {
            ContractService service = new ContractService(new PayPalService());
            return service.ProcessContract(contractObject.Item1, contractObject.Item2);
        }
        private static void PrintContractData(Contract contract)
        {
            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
                Console.WriteLine(installment.ToString());
        }
    }
}
