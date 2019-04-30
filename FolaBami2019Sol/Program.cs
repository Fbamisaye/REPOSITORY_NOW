using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using FolaBami2019Sol.Child;
using FolaBami2019Sol.Grandparent;
using FolaBami2019Sol.Parent;

namespace FolaBami2019Sol
{
	class Program
	{

        static void Main(string[] args)

        {


            //  create object 1 of class triangle first(void)
            //Triangle triangleIsocesles = new Triangle();
            //triangleIsocesles.triBase = 10;
            //triangleIsocesles.triHeights = 10;
            //triangleIsocesles.TriangleArea();

            // CREATE ANOTHER OBJECT 2 OF class TRIANGLE SECOND(void)
            //Triangle triangleRight = new Triangle();
            //triangleRight.triBase = 7;
            //triangleRight.triHeights = 23;
            //triangleRight.TriangleArea();

            // this will be with a return
            //Triangle Squarecal = new Triangle();
            //Squarecal.triBase = 23;
            //Squarecal.triHeights = 23;
            //Squarecal.SquarePerimeter();


            //this will take parameters
            //Triangle poly = new Triangle();
            ////poly.PolygonArea(100, 10);

            //PublicMeth pm = new PublicMeth();
            //pm.age = 12;
            //pm.name = "Angel";
            //pm.StudentDetails();

            //Console.WriteLine();
            //PriMeth priMeth = new PriMeth();
            //priMeth.studentDetails(24, "ola");
            //priMeth.studentSomething();

            //GrandP grandP = new GrandP();
            //grandP.CallMyName();
            //Console.WriteLine("change name to Kevin");
            //grandP.MichaelName = "Kevin";
            //grandP.CallMyName();
            //Console.WriteLine();
            //Guardian guardian = new Guardian();
            //guardian.CallParents();
            
            //Triangle triangleAcc = new Triangle();
            //triangleAcc.TriangleArea();

            //Triangle triangleGP = new Triangle();
            //triangleGP.triheight = 21;
            //Console.WriteLine(" tolu is " + triangleGP.triheight + " meters tall ");

            Folake folake = new Folake();
            folake.PickinName();
            folake.PickinAge();
            folake.childAge = 25;
            folake.PickinAge();
            Console.WriteLine();
            folake.CallDaddyName();
            folake.CallDaddyAge();
            folake.MarriedName();

            Console.ReadKey();




           

        }

          








        }


        }
    
