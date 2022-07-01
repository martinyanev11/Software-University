using System;
using System.Collections.Generic;
using System.Text;

namespace PointsIComparablePractice
{
    public class Point : IComparable<Point>
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point otherPoint)
        {
            if (this.X != otherPoint.X)
                return (this.X - otherPoint.X);
            if (this.Y != otherPoint.Y)
                return (this.Y - otherPoint.Y);
            return 0;
        }

        public override string ToString()
        {
            return $"Point: {this.X}, {this.Y}";
        }
    }
}
