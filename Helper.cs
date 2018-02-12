using System;

namespace RoS
{
    internal class Helper
    {
        public static int GetDistance(Vector3 v1, Vector3 v2, int Divide)
        {
            Vector3 vector3 = new Vector3();
            vector3.X = v1.X - v2.X;
            vector3.Y = v1.Y - v2.Y;
            vector3.Z = v1.Z - v2.Z;
            return (int) Math.Sqrt(Math.Pow((double) vector3.X, 2.0) + Math.Pow((double) vector3.Y, 2.0) + Math.Pow((double) vector3.Z, 2.0)) / Divide;
        }
    }
}
