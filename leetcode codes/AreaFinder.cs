using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace leetcode_codes
{
    public class AreaFinder
    {
        public (string Shape,double Area) FindArea(int sides) 
        { 
            if (sides == 3) 
            { 
                
                Console.Write("Enter base: "); 
                double b = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Enter height: "); 
                double h = Convert.ToDouble(Console.ReadLine()); 
                double area = 0.5 * b * h;
                return ("Triangle", area);
            } 
            else if (sides == 4) 
            { 
                
                Console.Write("Enter length: "); 
                double l = Convert.ToDouble(Console.ReadLine()); 
                Console.Write("Enter breadth: "); 
                double b = Convert.ToDouble(Console.ReadLine());
                if (l == b)
                {
                    

                    double area = l * l;

                    return ("Square", area);
                }
                else
                {


                    double area = l * b;

                    return ("Rectange", area);
                }
            }
            else if (sides == 0) 
            { 
               
                Console.Write("Enter radius: "); 
                double r = Convert.ToDouble(Console.ReadLine()); 
                double area = Math.PI * r * r;
                return ("Circle", area);
            } 
            else 
            { 
                return ("Shape not supported",0); 
            } 
        }
    }
    

}