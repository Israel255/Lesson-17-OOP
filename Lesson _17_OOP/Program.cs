using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__17_OOP
{
    class Program
    {
        static bool Has_Children(Citizen c)
        {
            if (c._children.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Check_Validity(Citizen c)
        {
            if (Has_Children(c) == false)
            {
                return false;
            }
            else
            {
                int my_child = 0;
                for (int i = 0; i < c._children.Length; i++)
                {
                    if (c._id == c._children[i]._father_id)
                    {
                        my_child++;
                    }
                }
                if (my_child == c._children.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Citizen piter = new Citizen("Piter", 13579);
            Citizen mario = new Citizen("Mario", 13579, 24680);
            Citizen alan = new Citizen("Alan", 13579,57834);
            Citizen martin = new Citizen("Martin", 13571,45322);
            Citizen[] children = { mario, alan, martin };
            piter.Set_Children(children);
            Console.WriteLine(piter);
            Console.WriteLine(Has_Children(piter));
            Console.WriteLine(Check_Validity(piter));
            Citizen.Print_Number_Of_Citizens();
            Console.WriteLine(Citizen.Reached_Half_Of_Maximum_Size());
            piter.Print_Id();
            mario.Print_Gap_Between_My_Id_And_Father();
        }
    }
}
