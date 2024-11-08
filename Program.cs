using System;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] arr = new int[10]; // آرایه با ظرفیت 10
        static int size = 0; // اندازه فعلی آرایه

        // تابع درج مقدار در ایندکس مشخص
        static void Insert(int index, int value)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Index out of bounds!");
                return;
            }
            if (size == arr.Length)
            {
                Console.WriteLine("Array is full!");
                return;
            }
            for (int i = size; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = value;
            size++;
        }

        // تابع حذف مقدار بر اساس مقدار
        static int Delete_By_Value(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    for (int j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    size--;
                    return i; // برگرداندن ایندکس حذف شده
                }
            }
            return -1; // مقدار پیدا نشد
        }

        // تابع حذف مقدار بر اساس ایندکس
        static void Delete_By_Index(int index)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Index out of bounds!");
                return;
            }
            for (int i = index; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            size--;
        }

        // تابع نمایش آرایه
        static void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // تابع افزودن مقدار در انتهای آرایه
        static void Append(int value)
        {
            if (size == arr.Length)
            {
                Console.WriteLine("Array is full!");
                return;
            }
            arr[size] = value;
            size++;
        }

        // تابع معکوس کردن آرایه
        static void Reverse()
        {
            for (int i = 0; i < size/2 ; i++)
            {
                int temp = arr[i];
                arr[i] = arr[size - i - 1];
                arr[size - i - 1] = temp;
            }
        }

        // تابع جستجو بر اساس مقدار
        static int Search_By_Value(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    return i; // برگرداندن ایندکس مقدار پیدا شده
                }
            }
            return -1; // مقدار پیدا نشد
        }

        static void Main(string[] args)
        {
            Append(5);
            Append(10);
            Append(15);
            Append(34);
            Console.WriteLine("Initial array:");
            Display();

            Insert(1, 7);
            Console.WriteLine("After inserting 7 at index 1:");
            Display();

            int deletedIndex = Delete_By_Value(10);
            Console.WriteLine("Deleting value 10 at index: " + deletedIndex);
            Display();

            Delete_By_Index(0);
            Console.WriteLine("After deleting index 0:");
            Display();

            Reverse();
            Console.WriteLine("Reversed array:");
            Display();

            int searchIndex = Search_By_Value(15);
            if (searchIndex != -1)
            {
                Console.WriteLine("Value 15 found at index: " + searchIndex);
            }
            else
            {
                Console.WriteLine("Value 15 not found!");
            }
        }
    }
}