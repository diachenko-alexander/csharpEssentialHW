using System;

namespace AdditionalTask
{
    public struct Point3D
    {
        private int x, y, z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D operator +(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }

        public override string ToString()
        {
            return string.Format($"x={this.x}, y={this.y} z= {this.y}");
        }
    }
}
