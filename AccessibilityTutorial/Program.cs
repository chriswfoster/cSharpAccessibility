using System;

public class Customer
{
    //private members only accessed within the containing class.
    //public members are avaiable outside of the containing class.
    //protected members can be accessed if directly accessed by a class that get's it's inheritance from the class the protected member is defined in.

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
    protected int IDS;
    

}

public class CorporateCustomer : Customer // the : gets it's inheritance from the class above.
{
    public void PrintID()
    {
        CorporateCustomer CC = new CorporateCustomer();
       // CC.IDS = 101; //this should owrk perfectly since it inherited IDS from Customer

        //base.IDS = 33; // the base keyword access the base property of the protected member, where it got it's derived data from. From the inherited parent.
        //MainClass below can't use base.IDS to access any inheritance from Customer class.
    }
}


public class MainClass
{
    private static void Main()
    {
        Customer C1 = new Customer(); // I create a new customer class named C1.
       // Console.WriteLine(C1._id); // see the red error here, saying that the ID isn't available due to it being protected.
        Console.WriteLine(C1.ID); // accessible b/c it's public.
        //Console.WriteLine(C1.IDS); // See it's unable to access IDS b/c it's protected to only classes that derived from the original parent class
    }

}