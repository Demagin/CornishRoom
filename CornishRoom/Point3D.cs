using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CornishRoom
{
    class Point3D
    {
        public double x, y, z;
        public Point3D(double x, double y, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public static Point3D operator +(Point3D left, Point3D right)
        {
            return new Point3D(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        public static Point3D operator -(Point3D left, Point3D right)
        {
            return left + (-1) * right;
        }
        public static Point3D operator -(Point3D left)
        {
            return new Point3D(-left.x, -left.y, -left.z);
        }
        public static Point3D operator *(Point3D left, double d)
        {
            return new Point3D(left.x * d, left.y * d, left.z * d);
        }
        public static Point3D operator *(double d, Point3D left)
        {
            return left * d;
        }
    }
}
