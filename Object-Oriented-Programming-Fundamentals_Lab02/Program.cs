using Object_Oriented_Programming_Fundamentals_Lab02;

try
{
    CarPark park = new CarPark(10);

    Vehicle vehicle1 = new Vehicle("AAA");
    Vehicle vehicle2 = new Vehicle("BBB");

    park.ParkVehicle(vehicle1);
    park.ParkVehicle(vehicle2);

    park.RemoveVehicle("AAA");
    park.RemoveVehicle("BBB");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

