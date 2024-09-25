using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SimonovMA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string kStr = k.ToString(); // переводит число в строку
            char digitChar = kStr[^3]; // создаёт переменную-чар и запихивает в него третью с конца цифру, как по условию
            return (int)char.GetNumericValue(digitChar); // возращает эту цифру, которая была преобразована из символа в целочисленную
        }
    }
}
