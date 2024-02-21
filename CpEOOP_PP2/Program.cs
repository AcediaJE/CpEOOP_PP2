using System;

namespace _2324_1Y_CpEOOP_ListRecreation
{
        //        //MAGICAL SORTinG TIME

        //    // Sort in ascending order
        //    Console.WriteLine("\nWE GOING UP (ASCENDING):");
        //    BubbleSort(true);
        //    Console.WriteLine($"Emulated List contains {DisplayContent()}");

        //    // Sort in descending order
        //    Console.WriteLine("\nWe out here descending :( :");
        //    BubbleSort(false);
        //    Console.WriteLine($"Emulated List contains {DisplayContent()}");

        //    Console.ReadKey();
        //}


        //static void BubbleSort(bool ascending) //Giving the BubbleSort a purpose and a meaning in this code
        //{
        //    int n = emulatedList.Length;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (ascending) //This just confirms if its going to ascend or the latter (descend ew)
        //            {
        //                if (emulatedList[j] > emulatedList[j + 1]) //these just check which needs to be moved up in the list
        //                {
        //                    int temp = emulatedList[j]; //
        //                    emulatedList[j] = emulatedList[j + 1]; //this confirms and swaps the numbers that needs to be swapped
        //                    emulatedList[j + 1] = temp; //completes the swap that was stored in the temp
        //                }
        //            }
        //            else
        //            {
        //                if (emulatedList[j] < emulatedList[j + 1]) // this is just the same at the one above but like in reverse order
        //                { //so
        //                    int temp = emulatedList[j];
        //                    emulatedList[j] = emulatedList[j + 1];
        //                    emulatedList[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }
        //}

        //MAGIC SORTING TIME END :(
    internal class Program
    {
        static int[] emulatedList = new int[] { };

        static void Main(string[] args)
        {
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Add(10);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Add(7);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Add(10);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Add(7);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Add(10);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Add(7);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Add(10);
            Console.WriteLine($"Emulated List has a length of {emulatedList.Length}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");


            Console.WriteLine($"\n\nDoes emulated list contain 7? : {Contains(7)}");
            Console.WriteLine($"The index of 7 is {IndexOf(7)}");
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Remove(7);
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            RemoveAt(1);
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            RemoveAll(10);
            Console.WriteLine($"Emulated List contains {DisplayContent()}");
            Insert(1, 5);
            Console.WriteLine($"Emulated List contains {DisplayContent()}");

            //MAGICAL SORTinG TIME

            // Sort in ascending order
            Console.WriteLine("\nWE GOING UP (ASCENDING):");
            BubbleSort(true);
            Console.WriteLine($"Emulated List contains {DisplayContent()}");

            // Sort in descending order
            Console.WriteLine("\nWe out here descending :( :");
            BubbleSort(false);
            Console.WriteLine($"Emulated List contains {DisplayContent()}");

            Console.ReadKey();
        }


        static void BubbleSort(bool ascending) //Giving the BubbleSort a purpose and a meaning in this code
        {
            int n = emulatedList.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (ascending) //This just confirms if its going to ascend or the latter (descend ew)
                    {
                        if (emulatedList[j] > emulatedList[j + 1]) //these just check which needs to be moved up in the list
                        {
                            int temp = emulatedList[j]; //
                            emulatedList[j] = emulatedList[j + 1]; //this confirms and swaps the numbers that needs to be swapped
                            emulatedList[j + 1] = temp; //completes the swap that was stored in the temp
                        }
                    }
                    else
                    {
                        if (emulatedList[j] < emulatedList[j + 1]) // this is just the same at the one above but like in reverse order
                        { //so
                            int temp = emulatedList[j];
                            emulatedList[j] = emulatedList[j + 1];
                            emulatedList[j + 1] = temp;
                        }
                    }
                }
            }
        }

        //MAGIC SORTING TIME END :(

        static void Add(int value)
        {
            int currLength = emulatedList.Length;
            int[] tempClone = new int[currLength];

            for (int x = 0; x < currLength; x++)
                tempClone[x] = emulatedList[x];

            emulatedList = new int[currLength + 1];

            for (int x = 0; x < currLength; x++)
                emulatedList[x] = tempClone[x];

            emulatedList[currLength] = value;
        }

        static string DisplayContent()
        {
            string message = "";

            for (int x = 0; x < emulatedList.Length; x++)
            {
                message = message + emulatedList[x] + "  ";
            }

            return message;
        }

        static void Remove(int value)
        {
            int[] tempClone = new int[emulatedList.Length];
            bool numFound = false;
            int indexOffset = 0;

            if (Contains(value))
            {
                for (int x = 0; x < tempClone.Length; x++)
                    tempClone[x] = emulatedList[x];

                emulatedList = new int[tempClone.Length - 1];

                for (int x = 0; x < tempClone.Length; x++)
                {
                    if (tempClone[x] == value && !numFound)
                    {
                        numFound = true;
                        indexOffset = 1;
                    }
                    else
                    {
                        emulatedList[x - indexOffset] = tempClone[x];
                    }
                }
            }
        }

        static bool Contains(int value)
        {
            for (int x = 0; x < emulatedList.Length; x++)
            {
                if (emulatedList[x] == value)
                    return true;
            }

            return false;
        }

        static void RemoveAt(int index)
        {
            if (index < emulatedList.Length && index > -1)
            {
                int[] tempClone = new int[emulatedList.Length];
                int indexOffset = 0;

                for (int x = 0; x < tempClone.Length; x++)
                    tempClone[x] = emulatedList[x];

                emulatedList = new int[tempClone.Length - 1];

                for (int x = 0; x < tempClone.Length; x++)
                {
                    if (x == index)
                        indexOffset = 1;
                    else
                        emulatedList[x - indexOffset] = tempClone[x];
                }
            }
        }

        static void RemoveAll(int value)
        {
            while (Contains(value))
                Remove(value);
        }

        static int IndexOf(int value)
        {
            for (int x = 0; x < emulatedList.Length; x++)
                if (emulatedList[x] == value)
                    return x;

            return -1;
        }

        static void Insert(int index, int value)
        {
            if (index > emulatedList.Length)
                index = emulatedList.Length;

            int[] tempClone = new int[emulatedList.Length];
            int indexOffset = 0;

            for (int x = 0; x < tempClone.Length; x++)
                tempClone[x] = emulatedList[x];

            emulatedList = new int[tempClone.Length + 1];

            for (int x = 0; x < emulatedList.Length; x++)
            {
                if (x != index)
                    emulatedList[x] = tempClone[x - indexOffset];
                else
                {
                    indexOffset = 1;
                    emulatedList[x] = value;
                }
            }
        }
    }
}
