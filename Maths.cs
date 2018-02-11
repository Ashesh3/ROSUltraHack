

using System;

namespace Whynot
{
    internal class Maths
    {
        public static bool InsideCircle(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }

        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        public static float[] ViewMatrix = new float[16];

        public static bool WorldToScreen(Vector3 pos, out Vector2 screen, int windowWidth, int windowHeight)
        {

            screen = new Vector2();
            Maths.ViewMatrix = Mem.ReadMatrix<float>(Mem.ReadMemory<int>(Mem.ReadMemory<int>(Mem.BaseAddress + Offsets.ViewMatrix) + 4) + 196, 16);
            Vector4 vector4;
            vector4.X = (float)((double)pos.X * (double)Maths.ViewMatrix[0] + (double)pos.Y * (double)Maths.ViewMatrix[4] + (double)pos.Z * (double)Maths.ViewMatrix[8]) + Maths.ViewMatrix[12];
            vector4.Y = (float)((double)pos.X * (double)Maths.ViewMatrix[1] + (double)pos.Y * (double)Maths.ViewMatrix[5] + (double)pos.Z * (double)Maths.ViewMatrix[9]) + Maths.ViewMatrix[13];
            vector4.Z = (float)((double)pos.X * (double)Maths.ViewMatrix[2] + (double)pos.Y * (double)Maths.ViewMatrix[6] + (double)pos.Z * (double)Maths.ViewMatrix[10]) + Maths.ViewMatrix[14];
            vector4.W = (float)((double)pos.X * (double)Maths.ViewMatrix[3] + (double)pos.Y * (double)Maths.ViewMatrix[7] + (double)pos.Z * (double)Maths.ViewMatrix[11]) + Maths.ViewMatrix[15];
            bool flag;
            if ((double)vector4.W < 0.100000001490116)
            {
                flag = false;
            }
            else
            {
                Vector3 vector3;
                vector3.X = vector4.X / vector4.W;
                vector3.Y = vector4.Y / vector4.W;
                vector3.Z = vector4.Z / vector4.W;
                screen.X = (float)((double)(windowWidth / 2) * (double)vector3.X + ((double)vector3.X + (double)(windowWidth / 2)));
                screen.Y = (float)(-((double)(windowHeight / 2) * (double)vector3.Y) + ((double)vector3.Y + (double)(windowHeight / 2)));
                flag = true;
            }
            return flag;
        }
    }
}
