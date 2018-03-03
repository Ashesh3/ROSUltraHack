

using System;
using Microsoft.DirectX;

namespace Whynot
{
  public struct Vector4
  {
    public float W;
    public float X;
    public float Y;
    public float Z;
        private int v1;
        private int v2;
        private int v3;
        private float v4;

        public Vector4(int v1, int v2, int v3, float v4) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public static implicit operator Microsoft.DirectX.Vector4(Vector4 v)
        {
            throw new NotImplementedException();
        }
    }
}
