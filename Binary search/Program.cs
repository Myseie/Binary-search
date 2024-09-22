using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sortedList = [1, 3, 5, 6, 7, 8, 9, 11, 22, 33];

        Console.Write("Ange ett tal för att leta efter : ");
        
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(sortedList, target);

        if (index != -1 )
        {
            Console.WriteLine($"Talet {target} finns vid index {index}");
        } else
        {
            Console.WriteLine($"Talet {target} finns inte med i listan");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while ( low <= high )
        {
            int mid = (low + high) / 2;

            if ( array[mid] == target )
            {
                return mid;
            }
            else if ( array[mid] < target )
            {
                low = mid + 1;

            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
}