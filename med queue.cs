namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount;
            int appointmentTime = 10; // время приёма 10 минут
            int waitingTime;
            Console.WriteLine("Вы пришли на приём к врачу и заняли место в очереди. Сколько людей стоят в очереди перед вами?");
            peopleCount = Convert.ToInt32(Console.ReadLine());
            waitingTime = peopleCount * appointmentTime;
            int hour = waitingTime / 60;
            int min = waitingTime % 60;
            Console.WriteLine($"Ваше время ожидания составит {hour} часов и {min} минут.");


        }
    }
}
