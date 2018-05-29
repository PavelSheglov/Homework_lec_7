using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1
{
    class Menu
    {
        private double _leftOperand;
        private double _rightOperand;
        Operation _operation;

        public Menu()
        {
            Start();
        }

        private void Start()
        {
            do
            {
                Console.Clear();
                InputData();
                ExecuteOperation();
                Console.Write("Продолжить: Да (1), Нет (any other)...");
            } while (Console.ReadLine() == "1");
        }

        private void InputData()
        {
            bool isOk;
            do
            {
                isOk = false;
                _leftOperand = 0;
                _rightOperand = 0;
                var operation = string.Empty;
                try
                {
                    Console.Write("Введите левый операнд:");
                    _leftOperand = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите знак операции (+, -, *, /, %):");
                    operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            _operation = Calculator.Sum;
                            break;
                        case "-":
                            _operation = Calculator.Deduct;
                            break;
                        case "*":
                            _operation = Calculator.Multiply;
                            break;
                        case "/":
                            _operation = Calculator.Devide;
                            break;
                        case "%":
                            _operation = Calculator.GetRemainder;
                            break;
                        default:
                            throw new InvalidOperationException("Не существующая операция!!!");
                            //break;
                    }
                    Console.Write("Введите правый операнд:");
                    _rightOperand = Convert.ToDouble(Console.ReadLine());
                    isOk = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Операнд(ы) не является(ются) числом(ами)!!!!");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!isOk);
        }

        private void ExecuteOperation()
        {
            try
            {
                Console.WriteLine("Результат выполнения операции: {0:f2}", Calculator.Calculate(_leftOperand, _rightOperand, _operation));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
