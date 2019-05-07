using System;

public class HouseLight{
    public int[] whatWillbeTheArrayOnDay(int[] houses,int daysToCheck)
        {
            // Clone by value becuase the houses are being sent by reference
            int[] copiedArray = CopyByVAlueArray<int>(houses);
            // Create a new array 
            int[] newArray = new int[houses.Length];

            for(int i=0;i<daysToCheck;i++)
            {
                newArray = ArrayInSpecificDay(copiedArray);
                Console.WriteLine("Day " + i); 
                foreach(int item in newArray)
                    Console.Write(item); 
                Console.WriteLine("");
                copiedArray = CopyByVAlueArray<int>(newArray);
            }
            
            return copiedArray;
        }

        public int[] ArrayInSpecificDay(int[] housePerDay)
        {
            int[] arrayPerDay = new int[housePerDay.Length];
            for(int i=0;i<housePerDay.Length;i++)
            {
                if(i==0) // Checking the first item
                    arrayPerDay[i] = getValue(0,housePerDay[i+1]);
                else if(i == housePerDay.Length-1) // Checking last item
                    arrayPerDay[i] = getValue(housePerDay[i-1],0);
                else
                    arrayPerDay[i] =  getValue(housePerDay[i-1],housePerDay[i+1]);
            }
            return arrayPerDay;
        }

        public int getValue(int valueBefore, int valudeAfter)
        {
            return valueBefore^valudeAfter;
        }

        public T[] CopyByVAlueArray<T>(T[] items)
        {
            T[] arr = new T[items.Length];
            if(items.Length == 0)
                return null;
            for(int i=0;i<items.Length;i++)
                arr[i] = items[i];
            return arr;
        }
}