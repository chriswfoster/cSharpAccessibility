using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 55; // INTERNAL is available ONLY to the classes in this assembly (AssemblyOne seen in the menu there -> 
        protected internal int IDS = 83; // PROTECTED INTERNAL passes it on to other assemblies or classes that derive from this class (AssemblyOneClassI);
    }
    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);

        }
    }
}
