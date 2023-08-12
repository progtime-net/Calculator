using System;
namespace CalcJun.Interfaces
{
	public class Multiplication : IOperation
	{
        private string name = "*";
        public string Name
        {
            get { return name; }
        }

        public float Execute(float a, float b)
        {
            return a * b;
        }
    }
}

