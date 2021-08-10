using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CornishRoom
{
    public enum Material { Matte, Mirror, Transparent };
    public enum FigureType { Sphere, Wall, SideCube };

    abstract class Figure
    {
        public Color Ambient;
        public Material Material;
        public FigureType Type;

        public Figure(Color ambient, Material material, FigureType type)
        {
            Ambient = ambient;
            Material = material;
            Type = type;
        }
    }

    class Sphere : Figure
    {
        public Point3D Center;
        public double Radius;


        public Sphere(Color ambient, Material material, Point3D c, double r)
                 : base(ambient, material, FigureType.Sphere)
        {
            Center = c;
            Radius = r;
        }
    }

    class Wall : Figure
    {
        public Point3D MinPoint;
        public Point3D MaxPoint;
        public Point3D Normal;
        public Wall(Color ambient, Material material, FigureType type, Point3D p1, Point3D p2, Point3D norm)
                : base(ambient, material, type)
        {
            MinPoint = p1;
            MaxPoint = p2;
            Normal = norm;
        }
    }

    class Light
    {
        public Point3D Position;
        public double Intensity;
        public Light(Point3D position, double intensity)
        {
            Position = position;
            Intensity = intensity;
        }
    }
}
