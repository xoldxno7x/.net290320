using System;

namespace HW_7_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen Kane = new Citizen("Kane", 1);

            Citizen Kid = new Citizen("John", Kane._id);
            Citizen Kid1 = new Citizen("Jane", Kane._id);
            Citizen Kid2 = new Citizen("James", Kane._id);

            Citizen[] sonsOfKane = new Citizen[] { Kid, Kid1, Kid2 };
            Kane.SetChildren(sonsOfKane);

            Console.WriteLine(Kane);
            Console.WriteLine(HasChildren(Kane));
        }

        public static bool HasChildren(Citizen c)
        {
            return c._children != null && c._children.Length > 0;
        }

        //According to what I understood, this method should check whether the childs ID is the same as the Parent ID
        public static bool CheckValidity(Citizen c)
        {
            if (HasChildren(c))
            {
                foreach(Citizen i in c._children)
                {
                    if(i._id == c._id)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
