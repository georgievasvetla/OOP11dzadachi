namespace ListCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count=");
            int count=int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                var car = Console.ReadLine().Split();
                Car cars = new Car(car[0], car[1], double.Parse(car[2]));
                carList.Add(cars);
            }
            carList.Sort();
            foreach (var item in carList)
            {
                item.Print();
            }
           
            
        }
        
    }
}