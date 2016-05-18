using System.Threading.Tasks;

namespace MakeBreakfast
{
    public static class Order
    {
        public static void MakeOrder(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1; // to check if found a prime
                while (b*b <= a)
                {
                    if (a%b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                    count++;
                a++;
            }

        }

        public static async Task MakeOrderAsync(int n)
        {
            await Task.Run(() =>
            {
                MakeOrder(n);
            });
        }
    }
    
}
