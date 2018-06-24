using System;

public class Customer
{
    private int _id; //private means it's only accessible through the containing type, which would be the class it's in... "Customer"
    public int ID 
    {
        get {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

}

public class MainClass
{
    private static void Main()
    {
        Customer C1 = new Customer(); // I create a new customer class named C1.
       // Console.WriteLine(C1._id); // see the red error here, saying that the ID isn't available due to it being protected.
        Console.WriteLine(C1.ID);
    }

}