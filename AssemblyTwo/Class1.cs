using System; // this is where your'e getting stuff like Console.WriteLine and such.
using AssemblyOne; // to bring this in, I had to right click the AssemblyTwo over ther ->
                   // then reference AssemblyOne, and manually add the using AssemblyOne reference.

namespace AssemblyTwo
{
    public class AssemblyTwoClassI
    {
        public void Print()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            // A1.ID = 88; // as  you can see, since I set it as internal, it will only allow it to be used locally to assembly.
        }
    }

    public class AssemblyTwoClassII : AssemblyOneClassI
    {
        public void Print()
        {
            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            base.IDS = 44; // you can't do A2.IDS, you can utilize base here to access what it's getting it's inheritance from;
        }
    }
}
