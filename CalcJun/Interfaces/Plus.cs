using System;
namespace CalcJun.Interfaces
{
	public class Plus : IOperation
	{
        private string name = "+";
        public string Name
        {
            get { return name; }
        }

        public float Execute(float a, float b)
        {
            return a + b;
        }
    }
}

