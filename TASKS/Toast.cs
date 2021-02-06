using System;
using System.Threading.Tasks;

namespace TASKS
{
    public class Toast
    {
        public Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }
        public void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");
        public void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");
    }
}
