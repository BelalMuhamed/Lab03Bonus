namespace Bonus
{
    internal class Program
    {
      

        #region Bonus
        public static void Swap(ref TimeSpan T01,ref TimeSpan T02)
        {
            TimeSpan T03= new TimeSpan();
            T03 = T01;
            T01=T02;
            T02 = T03;
        }
        public static void SortingEdition02(TimeSpan[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j =  1; j < array.Length; j++)
                {
                    if (array[i].TotalSeconds() > array[j].TotalSeconds())
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            
            //take size from user 
            bool flag = true;
            int size;
            do
            {
                Console.WriteLine("Enter the size of time span array");
                flag= int.TryParse(Console.ReadLine(), out size);
            }
            while(!flag);
            //filling array from user 
            TimeSpan[] ArrayOfTimes=new TimeSpan[size];
            for(int i = 0;i<ArrayOfTimes.Length;i++)
            {
                Console.WriteLine($"Enter hours of the   {i+1} time ");
                ArrayOfTimes[i].Hours = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter minutes of the  {i + 1} time ");
                ArrayOfTimes[i].Minutes = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter seconds of the  {i + 1} time ");
                ArrayOfTimes[i].Seconds = int.Parse(Console.ReadLine());
            }
            // view array
            Console.WriteLine("Times you enterd ");
            for(int i = 0;i<ArrayOfTimes.Length;i++)
            {
                ArrayOfTimes[i].GetString();
            }
            //test the function
            SortingEdition02(ArrayOfTimes);
            Console.WriteLine("Array after sorting using second edition ");
            for (int i = 0; i < ArrayOfTimes.Length; i++)
            {
                ArrayOfTimes[i].GetString();
            }
        }
    }
}
