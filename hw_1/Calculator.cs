using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1
{
    class Calculator
    {
        public static double Calculate(double leftOperand, double rightOperand, Operation operation)
        {
            try
            {
                return operation(leftOperand, rightOperand);
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static double Sum(double leftOperand, double rightOperand)
        {
            return leftOperand + rightOperand;
        }
        public static double Deduct(double leftOperand, double rightOperand)
        {
            return leftOperand - rightOperand;
        }
        public static double Multiply(double leftOperand, double rightOperand)
        {
            return leftOperand * rightOperand;
        }
        public static double Devide(double leftOperand, double rightOperand)
        {
            try
            {
                if (rightOperand == 0)
                    throw new DivideByZeroException("Попытка делить на ноль!!!");
                return leftOperand / rightOperand;
            }
            catch(DivideByZeroException)
            {
                throw;
            }
        }
        public static double GetRemainder(double leftOperand, double rightOperand)
        {
            try
            {
                if (rightOperand == 0)
                    throw new DivideByZeroException("Попытка делить на ноль!!!");
                return Math.IEEERemainder(leftOperand, rightOperand);
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
