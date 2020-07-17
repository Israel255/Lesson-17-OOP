using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__17_OOP
{
    class Citizen
    {
        public string _name;
        public Citizen[] _children;
        public readonly int _father_id;
        public readonly int _id;
        public static int _number_of_current_citizens = 30;
        public const int _MAXIMUM_NUMBER_OF_CITIZENS = 100;

        public Citizen(string name, int id)
        {
            _name = name;
            _id = id;
        }
        public Citizen(string name, int father_id, int id)
        {
            _name = name;
            _father_id = father_id;
            _id = id;
        }

        public static void Print_Number_Of_Citizens()
        {
            Console.WriteLine("Number of citizens: " + _number_of_current_citizens);
        }

        public static bool Reached_Half_Of_Maximum_Size()
        {
            if (_number_of_current_citizens <= _MAXIMUM_NUMBER_OF_CITIZENS)
            {
               return false;
            }
            else
            {
               return true;
            }
        }
        public void Print_Id()
        {
            Console.WriteLine("The id is: " + _id);
        }
        public void Print_Gap_Between_My_Id_And_Father()
        {
            if (_father_id >= _id)
            {
                Console.WriteLine("The difference is: " + (_father_id - _id));
            }
            else
            {
                Console.WriteLine("The difference is: " + (_id - _father_id));
            }
        }
        public void Set_Children(Citizen[] children)
        {
            _children = children;
        }

        public override string ToString()
        {
            return "Citizen name: " + _name + " Number of children: " + _children.Length + " Id number: " + _father_id + " Number of citizens: " + _number_of_current_citizens;
        }
    }
}
