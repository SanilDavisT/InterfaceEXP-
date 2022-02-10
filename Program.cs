using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEXP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // IShapes shape =new IShapes();   // wrong way , cant create object for inter face 

            IShapes shape = new Circle();   // can  create object for child class shape
            shape.Draw1();
            shape.Draw2();

            IShapes shape2=new Square();
            shape2.Draw1();
            shape2.Draw2();

            Console.ReadKey();




        }
    }   

    interface IShapes
    {
        void Draw1();  // Abstract function - Doesnot have Function body

        void Draw2();



    }

    class Circle : IShapes
    {
        public void Draw1()
        {
            Console.WriteLine("Draw Circle");

        }

        public void Draw2()
        {
            Console.WriteLine("Draw circle2 ");
        }
    }


    class Square : IShapes
    {
        public void Draw1()
        {
            Console.WriteLine("Draw Square1 ");
        }

        public void Draw2()
        {
            Console.WriteLine("Draw square2");
        }
    }
}
