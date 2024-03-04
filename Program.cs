using LearningAbstraction_in_C;

namespace LearningAbsractionInCSharp

{
    public abstract class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Abstracting in C#****");
            PayBill payBill = new PayBill();
            payBill.Display();
        }
    }
}
