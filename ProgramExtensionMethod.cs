using System;

namespace PracticeNew
{
    public static class ProgramExtensionMethod{
        public static void printArray<T>(T[] array)
        {
            foreach(T a in array)
                    Console.Write(a);
            Console.WriteLine("");
        }

        public static void printArrayHouseLight<T>(this HouseLight ob,T[] array)
        {
            foreach(T a in array)
                    Console.Write(a);
            Console.WriteLine("");
        }
    }
}