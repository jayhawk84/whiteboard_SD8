using System;

namespace Geometry
{
    public class Triangle
    {
        public static double AreaOfTriangle(double height, double tbase)
        {
            double h = height;
            double b = tbase;
            double area = b * h / 2;
            return area;
        }
                
    }
}
