using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private const int boxPropertyMinValue = 0;
        private const string zeroOrNegativeArgumentException = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set 
            {
                if (value <= boxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(zeroOrNegativeArgumentException, nameof(this.Length)));
                }
                this.length = value; 
            }
        }
        public double Width
        {
            get { return width; }
            private set 
            {
                if (value <= boxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(zeroOrNegativeArgumentException, nameof(this.Width)));
                }
                width = value; 
            }
        }
        public double Height
        {
            get { return heigth; }
            private set 
            {
                if (value <= boxPropertyMinValue)
                {
                    throw new ArgumentException(String.Format(zeroOrNegativeArgumentException, nameof(this.Height)));
                }
                heigth = value; 
            }
        }

        public double SurfaceArea() 
            => (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }
        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }
    }
}
