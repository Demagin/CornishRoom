using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CornishRoom
{
    public partial class CornishRoom : Form
    {
        public CornishRoom()
        {
            InitializeComponent();
            sphereMaterial.SelectedIndex = 1;
            cube1Material.SelectedIndex = 2;
            cube2Material.SelectedIndex = 0;

            Light1X.Value = 0;
            Light1Y.Value = 0;
            Light1Z.Value = -20;

            Light2X.Value = 15;
            Light2Y.Value = 20;
            Light2Z.Value = 15;

            Light1_on.Checked = true;
            Light2_on.Checked = true;

            EyeX.Value = 0;
            EyeY.Value = -10;
            EyeZ.Value = -49;
        }

        private static List<Figure> scene = new List<Figure>();
        private void InitBall(Point3D center, double r, Color color, Material material)
        {
            scene.Add(new Sphere(color, material, center, r));
        }
        private void InitWall(Point3D p, Point3D p2, Point3D normal, Color color, Material material)
        {
            scene.Add(new Wall(color, material, FigureType.Wall, p, p2, normal));
        }
        private void InitSideCube(Point3D p, Point3D p2, Point3D normal, Color color, Material material)
        {
            scene.Add(new Wall(color, material, FigureType.SideCube, p, p2, normal));
        }

        private void InitRoom(double x, double y, double z)
        {

            // Задняя стена
            InitWall(new Point3D(-x, -y, z), new Point3D(x, y, z), new Point3D(0, 0, -1), Color.Violet, GetReflectionWall(checkBackWall));
            // Пол
            InitWall(new Point3D(-x, -y, -z), new Point3D(x, -y, z), new Point3D(0, 1, 0), Color.White, GetReflectionWall(checkFloor));
            // Потолок
            InitWall(new Point3D(-x, y, -z), new Point3D(x, y, z), new Point3D(0, -1, 0), Color.DarkMagenta, GetReflectionWall(checkCelling));
            // Левая стена
            InitWall(new Point3D(-x, -y, -z), new Point3D(-x, y, z), new Point3D(1, 0, 0), Color.LightBlue, GetReflectionWall(checkLeftWall));
            // Правая стена
            InitWall(new Point3D(x, -y, -z), new Point3D(x, y, z), new Point3D(-1, 0, 0), Color.IndianRed, GetReflectionWall(checkRightWall));
            // Передняя стена
            InitWall(new Point3D(-x, -y, -z), new Point3D(x, y, -z), new Point3D(0, 0, 1), Color.LightPink, GetReflectionWall(checkFrontWall));
        }
        private void InitCube(Point3D center, double r, Color color, Material material)
        {
            double x1 = center.x - r, x2 = center.x + r;
            double y1 = center.y - r, y2 = center.y + r;
            double z1 = center.z - r, z2 = center.z + r;
            InitSideCube(new Point3D(x1, y1, z2), new Point3D(x2, y2, z2), new Point3D(0, 0, 1), color, material);
            InitSideCube(new Point3D(x1, y1, z1), new Point3D(x2, y2, z1), new Point3D(0, 0, -1), color, material);

            InitSideCube(new Point3D(x1, y1, z1), new Point3D(x1, y2, z2), new Point3D(-1, 0, 0), color, material);
            InitSideCube(new Point3D(x2, y1, z1), new Point3D(x2, y2, z2), new Point3D(1, 0, 0), color, material);

            InitSideCube(new Point3D(x1, y1, z1), new Point3D(x2, y1, z2), new Point3D(0, -1, 0), color, material);
            InitSideCube(new Point3D(x1, y2, z1), new Point3D(x2, y2, z2), new Point3D(0, 1, 0), color, material);
        }

        public Material GetReflectionWall(CheckBox cb)
        {
            if (cb.Checked)
                return Material.Mirror;
            else
                return Material.Matte;   
        }

        public Material GetMaterial(ComboBox cb)
        {
            switch (cb.SelectedItem.ToString())
            {
                case "Mirror": return Material.Mirror;
                case "Matte":  return Material.Matte;
                case "Transparent": return Material.Transparent;
                default: return Material.Matte;
            }
        }

        private void buttonRender_Click(object sender, EventArgs e)
        {
            scene = new List<Figure>();
            InitRoom(25,25,50);
            InitBall(new Point3D(10, -15, 15), 10, Color.Cornsilk, GetMaterial(sphereMaterial));
            InitCube(new Point3D(-15, -21, 20), 4, Color.DarkKhaki, GetMaterial(cube1Material));
            InitCube(new Point3D(10, -22, 0), 3, Color.GreenYellow, GetMaterial(cube2Material));


            List<Light> lights = new List<Light>();
            if (Light1_on.Checked)
                lights.Add(new Light(new Point3D((int)Light1X.Value, (int)Light1Y.Value, (int)Light1Z.Value), 0.7));
            if (Light2_on.Checked)
                lights.Add(new Light(new Point3D((int)Light2X.Value, (int)Light2Y.Value, (int)Light2Z.Value), 0.3));

            Point3D eye = new Point3D((int)EyeX.Value, (int)EyeY.Value, (int)EyeZ.Value);

            RayTracing RT = new RayTracing(canvas.Width, canvas.Height, scene, lights, eye);

            canvas.Image = RT.GetImage();
        }

        private void CornishRoom_Load(object sender, EventArgs e)
        {

        }
    }
}