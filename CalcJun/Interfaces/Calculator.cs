using System;
namespace CalcJun.Interfaces
{
	public class Calculator : ICalculator
	{
		
        Minus minus = new Minus();
		Plus plus = new Plus();
		Division division = new Division();
		Multiplication multiplication = new Multiplication();
        public void InputAndCalculate()
		{
            string a = Console.ReadLine();
            string[] arr = a.Split();
            Console.WriteLine(   ExecuteOperation(arr[1], float.Parse(arr[0]), float.Parse(arr[2])));
		}
        public float ExecuteOperation(string operation, float a, float b)
		{
			if (operation == "+")
			{
                return plus.Execute(a, b);
			}
            if (operation == "-")
            {
                return minus.Execute(a, b);
            }
            if (operation == "*")
            {
                return division.Execute(a, b);
            }
            if (operation == "/")
            {
               return multiplication.Execute(a, b);
            }
            return -1;
        }
    }
}

