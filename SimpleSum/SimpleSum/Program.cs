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
            string firstValue = "999999999999";
            string secondValue = "999999999999";

            List<int> firstValueList = programObject.creatingList(firstValue);
            List<int> secondValueList = programObject.creatingList(secondValue);

            List<int> answer = programObject.searchingForSum(firstValueList, secondValueList);
            //if()
            for(int i = answer.Count - 1; i >= 0; i--)
            {
                Console.Write(answer[i]);
            }
            Console.WriteLine();
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
                for(int i = 0; i < firstList.Count; i++)
                {
                    try
                    {
                        int suma = (firstList[i] + secondList[i] + haveToAdd);
                        haveToAdd = 0;
                        if (suma > 9)
                        {
                            sum.Add(suma % 10);
                            haveToAdd = suma / 10;
                        }
                        else
                        {
                            sum.Add(suma);
                        }
                    } catch(Exception)
                    {
                        int suma = (firstList[i] + haveToAdd);
                        haveToAdd = 0;
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
                if(haveToAdd != 0)
                {
                    sum.Add(haveToAdd);
                }
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    try
                    {
                        int suma = (firstList[i] + secondList[i] + haveToAdd);
                        haveToAdd = 0;
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
                    catch (Exception)
                    {
                        int suma = (secondList[i] + haveToAdd);
                        haveToAdd = 0;
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
                if (haveToAdd != 0)
                {
                    sum.Add(haveToAdd);
                }
            }

            return sum;
        }
    }
}
