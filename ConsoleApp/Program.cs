using GenericArray;
using Vehicles;

var vehicleArray = new GenericArray<Vehicle>(10);

vehicleArray.AddItem(new Aircraft("Boeing", 80000000, 450));
vehicleArray.AddItem(new Car("BMW", 50000, "Series 4 gran coupe", 252));
vehicleArray.AddItem(new Car("Hyundai", 60000, "Ioniq 5", 305));

vehicleArray.Print();


Console.WriteLine("\n/////////////////////////////////////////////////\n");
Console.WriteLine("Setting vehicle at index 1 to an Aircraft:\n");

vehicleArray.SetItem(1, new Aircraft("Airbus", 100000000, 525));

vehicleArray.Print();

Console.WriteLine("\n/////////////////////////////////////////////////\n");
Console.WriteLine("Swapping vehicle of index 0 with vehicle of index 2:\n");

vehicleArray.SwapItems(0, 2);
vehicleArray.Print();

Console.WriteLine("\n/////////////////////////////////////////////////\n");

Console.WriteLine($"Current array length is: {vehicleArray.GetLength()}");