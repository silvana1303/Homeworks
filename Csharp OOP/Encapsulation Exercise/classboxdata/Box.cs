using System;
using System.Text;

namespace classboxdata
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine($"Surface Area - {2*(Length*Width) + 2*(Length*Height)+ 2*(Width*Height):f2}");
           sb.AppendLine($"Lateral Surface Area - {2 * (Length * Height) + 2 * (Width * Height):f2}");
           sb.AppendLine($"Volume - {Length*Width*Height:f2}");

           return sb.ToString().Trim();
        }
    }
}