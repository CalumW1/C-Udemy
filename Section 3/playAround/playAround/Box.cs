using System;
using System.Collections.Generic;
using System.Text;

namespace playAround
{
    class Box
    {

        // member variables
        private int length;
        private int height;
        private int width;
        private int volume;

        public void Displayinfo()
        {
            Console.WriteLine("Length {0} and height is {1} and width is {2} so the volume is {3}", length, height, width, volume = length*height*width);
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }


        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                this.volume = value;
            }
        }


        public int FrontSurface
        {
            get
            {
                return height * length; 
            }
        }
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

    }
}
