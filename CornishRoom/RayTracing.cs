using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CornishRoom
{
    class RayTracing
    {
        private static double eps = 1e-10;
        private int width, height;//высота ширина канваса, на котором будем рисовать
        Point3D eye;//точка с которой смотрим
        private List<Light> lights;//источники света
        private List<Figure> scene;//объекты сцены

        // <summary>
        /// Скалярное произведение
        /// </summary>
        private double Scalar(Point3D v1, Point3D v2) => (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);

        /// <summary>
        /// Нормирование
        /// </summary>
        private Point3D Normalize(Point3D v)
        {
            double len = Math.Sqrt((v.x * v.x) + (v.y * v.y) + (v.z * v.z));
            return new Point3D(v.x / len, v.y / len, v.z / len);
        }

        //конструктор
        public RayTracing(int width, int height, List<Figure> _scene, List<Light> _lights, Point3D eye) 
        {
            lights = _lights;
            scene = _scene;
            this.width = width;
            this.height = height;
            this.eye = eye;
        }

        /// <summary>
        /// Получение цвета каждого пикселя канваса
        /// </summary>
        public Bitmap GetImage()
        {
            Bitmap newImg = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                {
                    Point3D point = Convert2DTo3D(i, j, width, height);
                    newImg.SetPixel(i, j, RayTrace(eye, point, 10)); 
                }
            return newImg;
        }

        /// <summary>
        /// Трассировка луча
        /// </summary>
        private Color RayTrace(Point3D eye, Point3D ray, int iter)
        {
            // Ищем ближайший объект, пересекающийся с лучом
            (Figure nearest, double t) = NearestElem(eye, ray);

            // Если луч ушел в никуда, то черный цвет
            if (nearest == null)
                return Color.Black;

            // Точка пересечения с ближайшим объектом
            Point3D pointIntersec = eye + t * ray;

            Point3D normal;
            if (nearest.Type == FigureType.Sphere)
            {
                Sphere sphere = nearest as Sphere;
                normal = Normalize(pointIntersec - sphere.Center);
            }
            else
            {
                Wall wall = nearest as Wall;
                normal = wall.Normal;
            }
            // Фоновый цвет
            Color amb = nearest.Ambient;

            // Интенсивность
            double intens = CalcIntensity(pointIntersec, normal);

            // Рассчитаный цвет
            Color color =
                Color.FromArgb(Math.Min((int)(amb.R * intens), 255), Math.Min((int)(amb.G * intens), 255), Math.Min((int)(amb.B * intens), 255));
            // Если дошли до макс. глубины рекурсии или объект матовый, то возвращаем рассчитанное значение
            if (iter == 0 || nearest.Material == Material.Matte)
            {
                return color;
            }

            // Отраженный/преломленный луч
            Point3D reRay = new Point3D();

            // Если зеркало, то рассчитываем отраженный луч
            if (nearest.Material == Material.Mirror)
                reRay = Normalize(Reflect(ray, normal));

            // Если прозрачный, то рассчитываем преломленный луч
            else if (nearest.Material == Material.Transparent)
                reRay = Normalize(Refract(ray, normal));

            // Запускаем рекурсивную трассировку луча
            Color reColor = RayTrace(pointIntersec, reRay, iter - 1);

            //цвет зеркал и  цвет прозрачности
            double k1 = 0.4;//цвет собсвтенный
            double k2 = 1 - k1; // цвет отраженного 
            return Color.FromArgb(
                (int)(color.R * k1 + reColor.R * k2),
                (int)(color.G * k1 + reColor.G * k2),
                (int)(color.B * k1 + reColor.B * k2));
        }
        /// <summary>
        /// Находит ближайший объект к лучу и расстояние до него
        /// </summary>
        private (Figure, double) NearestElem(Point3D eye, Point3D ray)
        {
            (Figure nearest, double min) = (null, double.PositiveInfinity);

            foreach (Figure sceneElement in scene)
            {
                double t = Intersection(eye, ray, sceneElement);
                // Обновить минимум, если пересечение существует и оно меньше текущего значения
                if (!double.IsPositiveInfinity(t) && (t < min))
                    (nearest, min) = (sceneElement, t);
            }

            return (nearest, min);
        }

        /// <summary>
        /// Расчет интенсивности
        /// </summary>
        private double CalcIntensity(Point3D point, Point3D normal)
        {
            double intensity = 0;
            foreach (var light in lights)
            {
                Point3D l = light.Position - point;

                (Figure shape, double t) = NearestElem(point, l);


                if (shape.Type == FigureType.Wall || (shape == null) || t > 1.0)
                {
                    double scalar = Scalar(normal, l);// направление света 
                    if (scalar > 0)
                        intensity += (light.Intensity * scalar) / (Length(normal) * Length(l));
                }
                else continue;
            }
            return intensity;
        }
        /// <summary>
        /// Находит пересечение луча с объектом сцены (сторона куба или сфера)
        /// </summary>
        private double Intersection(Point3D eye, Point3D ray, Figure element)
        {
            if (element.Type == FigureType.Sphere)
            {
                Sphere sphere = element as Sphere;
                Point3D EC = eye - sphere.Center; //луч с началом в Center и направленный на глаз Eye

                double a = Scalar(ray, ray); //d^2
                double b = 2 * Scalar(EC, ray); //(d,s)
                double c = Scalar(EC, EC) - sphere.Radius * sphere.Radius; //s^2 -r^2 

                double D = b * b - 4 * a * c;
                // Нет корней - нет пересечения
                if (D < eps)
                    return double.PositiveInfinity;

                double t1 = (-b + Math.Sqrt(D)) / (2 * a);
                double t2 = (-b - Math.Sqrt(D)) / (2 * a);

                if (Math.Max(t1, t2) < eps)
                    return double.PositiveInfinity;
                //Наименьшее положительное значение t, если оно существует, дает ответ задачи
                return t2 > eps ? t2 : t1;
            }
            else if (element.Type == FigureType.Wall || element.Type == FigureType.SideCube)
            {
                Wall wall = element as Wall;

                Point3D normal = Normalize(wall.Normal);//нормируем, приводим к единичному
                Point3D v = eye - wall.MaxPoint;

                double scalar1 = Scalar(v, normal);//(a,n)
                double scalar2 = Scalar(ray, normal);//(d,n)
                double t = -scalar1 / scalar2;

                if (t < eps)
                    return double.PositiveInfinity;

                Point3D interPoint = eye + t * ray;//это находится точка пересечение через параметрическое уравнение. t — это параметр уравнения. Параметрическим уравнением задается луч
                return PointInPlane(wall, interPoint) ? t : double.PositiveInfinity;
            }
            return double.PositiveInfinity;
        }

        /// <summary>
        /// Расчет отраженного луча
        /// </summary>
        private Point3D Reflect(Point3D ray, Point3D normal) => ray - 2 * Scalar(ray, normal) * normal;

        /// <summary>
        /// Расчет преломленного луча
        /// </summary>
        private Point3D Refract(Point3D ray, Point3D normal)
        {
            const double n1 = 1.1;
            const double n2 = 1;
            Point3D sn = Normalize(Scalar(ray, normal) < 0 ? normal : new Point3D(-normal.x, -normal.y, -normal.z));
            Point3D rd = Normalize(ray);

            double inC1 = -Scalar(sn, rd);
            double inN = inC1 > 0 ? n1 / n2 : n2 / n1;
            double inC2 = Math.Sqrt(Math.Max(1 - inN * inN * (1 - inC1 * inC1), 0));

            return new Point3D(ray.x * inN + normal.x * (inN * inC1 - inC2),
            ray.y * inN + normal.y * (inN * inC1 - inC2),
            ray.z * inN + normal.z * (inN * inC1 - inC2));
        }
        /// <summary>
        /// Длина вектора
        /// </summary>
        private double Length(Point3D point) => Math.Sqrt(point.x * point.x + point.y * point.y + point.z * point.z);

        /// <summary>
        /// Рассчет 3D-координат по координатам bitmap (x, y)
        /// </summary>
        private Point3D Convert2DTo3D(int x, int y, int width, int height)//координаты масштабируется с учётом размеров пикчербокса
        {
            double x3D = (x - width / 2) * (8.0 / width);
            double y3D = -(y - height / 2) * (6.0 / height);
            return new Point3D(x3D, y3D, 5);
        }
        /// <summary>
        /// Принадлежность точки грани
        /// </summary>
        private bool PointInPlane(Wall plain, Point3D point) =>
            (point.x < Math.Max(plain.MaxPoint.x, plain.MinPoint.x) + eps) && (point.x > Math.Min(plain.MaxPoint.x, plain.MinPoint.x) - eps) &&
            (point.y < Math.Max(plain.MaxPoint.y, plain.MinPoint.y) + eps) && (point.y > Math.Min(plain.MaxPoint.y, plain.MinPoint.y) - eps) &&
            (point.z < Math.Max(plain.MaxPoint.z, plain.MinPoint.z) + eps) && (point.z > Math.Min(plain.MaxPoint.z, plain.MinPoint.z) - eps);
    }
}
