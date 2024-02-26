using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricBody
{
    internal class SquarePrism: Fig3D
    {
		//Propierties 
		protected  double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		private double sideSP;

		public double SideSP
		{
			get { return sideSP; }
			set { sideSP = value; }
		}


		//Constuctor 
		public SquarePrism() 
		{ 
			height = 0;
			sideSP = 0;
		}

		public SquarePrism(double height, double sideSP) 
		{ 
			Height=height;
			this.height = height;
            SideSP = sideSP;
            this.sideSP = height;
        }

        //Method

        public double GetVolume(double heigth)

        {
            return (sideSP*SideSP)*heigth ;
        }


        //Cube class finisher
        ~SquarePrism()
        {

        }

    }
}
