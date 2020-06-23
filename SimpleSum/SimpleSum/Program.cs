using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program programObject = new Program();
            string firstValue = "155555559798989";
            string secondValue = "2515456456465456456465";

            List<int> firstValueList = programObject.creatingList(firstValue);
            List<int> secondValueList = programObject.creatingList(secondValue);

            List<int> answer = programObject.searchingForSum(firstValueList, secondValueList);
            for(int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        public List<int> creatingList(string value)
        {
            List<int> valueList = new List<int>();
            for(int i = value.Length - 1; i >= 0; i--)
            {
                valueList.Add(Int16.Parse(value[i].ToString()));
            }
            return valueList;
        }

        public List<int> searchingForSum(List<int> firstList, List<int> secondList)
        {
            int haveToAdd = 0;
            
            List<int> sum = new List<int>();
            if(firstList.Count >= secondList.Count)
            {
                for(int i = firstList.Count - 1; i >= 0; i--)
                {
                    
                    int suma = (firstList[i] + secondList[i] + haveToAdd);
                    if(suma > 9)
                    {
                        sum.Add(suma % 10);
                        haveToAdd = suma / 10;
                    }
                    else
                    {
                        sum.Add(suma);
                    }
                }
            }
            else
            {
                for (int i = secondList.Count - 1; i >= 0; i--)
                {
                    int suma = (firstList[i] + secondList[i] + haveToAdd);
                    if (suma > 9)
                    {
                        sum.Add(suma % 10);
                        haveToAdd = suma / 10;
                    }
                    else
                    {
                        sum.Add(suma);
                    }
                }
            }

            return sum;
        }
    }
}
