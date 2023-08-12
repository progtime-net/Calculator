using System;
namespace CalcJun.Interfaces
{
    interface ICalculator
    {
        void InputAndCalculate();
        float ExecuteOperation(string operation, float a, float b);
    }
    
}
