using System; // this is where your'e getting stuff like Console.WriteLine and such.
using AssemblyOne; // to bring this in, I had to right click the AssemblyTwo over ther ->
                   // then reference AssemblyOne, and manually add the using AssemblyOne reference.

namespace AssemblyTwo
{
  

    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void Print()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            base.IDS = 44; // you can't do A2.IDS, you can utilize base here to access what it's getting it's inheritance from;
            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            A2.IDS = 83;
        }
    }

    public class AssemblyTwoClassII
    {
        public void Print()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI(); // I guess I'm pulling the class AssemblyOneClass into here with this, and creating A1 with AssemblyOneClass's inheritance.
            // A1.ID = 88; // as  you can see, since I set it as internal, it will only allow it to be used locally to assembly.
        }
    }
}
