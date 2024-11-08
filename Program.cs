using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static int[] arr = new int[10];
        static int size = 0; //size homon tedad arraye hast

       static void insert(int index, int value)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("tedade arraye bishtar az index hast");
                return;
            }
            if (size == arr.Length)
            {
                Console.WriteLine("tedad araye brabr ast");
                return;
            }
            for (int i = size; i > index; i--)
            {
                arr[i] = arr[i - 1]; //برای i = 5: arr[5] = arr[4] → arr = [1, 2, 3, 4, 5] (ایندکس 5 خالی است)
                // i = 4: arr[4] = arr[3] → arr = [1, 2, 3, 4, 4]
                // i = 3: arr[3] = arr[2] → arr = [1, 2, 3, 3, 4]
            }
            arr[index] = value; //darg meghdar jadid braye index moshakhas shode
            size++;
        }
        static int Delete_By_Value(int value) //hazf bar asas meghdar
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    for (int j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];//arr[4] = arr[5] if j<size  va eror 
                        //arr[2] به arr[3] (یعنی 40) مقداردهی می‌شود.
                        //arr[3] به arr[4] (یعنی 50) مقداردهی می‌شود.
                        //آرایه به شکل {10, 20, 40, 50, 50} در می‌آید.

                    }
                    size--;
                    return i;
                }

            }
            return -1;
        }
        static void Delete_By_Index(int index)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("tedade arraye bishtar az index hast2");
                return;
            }
            for (int i = index; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            size--;
        }
        static void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void append(int value)//value dar entehaye arr gharar begirad
        {
            if (size == arr.Length)
            {
                Console.WriteLine("arraye por ast");
            }
            arr[size] = value;//meghdardehi va ijad araye
            size++;
        }
        static void Reverse() // avaz kardan do araye ba mesal
        {
            //i = 0):

            //temp = arr[0] → temp = 1
            //arr[0] = arr[5 - 0 - 1] → arr[0] = arr[4] → arr[0] = 5
            //arr[4] = temp → arr[4] = 1
            // آرایه: { 5, 2, 3, 4, 1 }
            //دومین تکرار (i = 1):

            //temp = arr[1] → temp = 2
            //arr[1] = arr[5 - 1 - 1] → arr[1] = arr[3] → arr[1] = 4
            //arr[3] = temp → arr[3] = 2
            // آرایه: { 5, 4, 3, 2, 1
            for (int i = 0; i < size / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[size - i - 1];
                arr[size - i - 1] = temp;
            }

        }
        static int Search_By_Value(int value)
        {
            for(int i =0 ; i < size ; i ++)
            {
                if (arr[i]== value)
                {
                    return i;
                }

            }
            return -1;
        }

        static void Main(string[] args)
        {
            append(1);
            append(2);
            append(3);
            append(4);
            append(5);
            Console.WriteLine("arraye bad az meghdar dehe shodan :");
            Display();

            insert(1, 7);
            Console.WriteLine("bad azezafe kardan 7 be index 1 :");
            Display();

            Delete_By_Value(5);
            Console.WriteLine("hazf meghdar 5 :");
            Display();

            Delete_By_Index(1);
            Console.WriteLine("hazf index 1:");
            Display();

            Reverse();
            Display();
            int searcbyvalue = Search_By_Value(3);
            if(searcbyvalue==-1)
            {
                Console.WriteLine("index value peyda nashod");
            }
            else
            {
                Console.WriteLine("index meghdar 3 ast : " + searcbyvalue);
            }

            


        }
    }
}
