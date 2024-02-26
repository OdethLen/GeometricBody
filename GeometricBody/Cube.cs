using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricBody
{
    internal class Cube: Fig3D
    {
		//Propierties
		private double measure_side;

		public double Measure_side
		{
			get { return measure_side; }
			set { measure_side = value; }
		}
		//Constuctor #1

		public Cube() 
		{
			measure_side = 0;
		}

		//Constuctor #2
		public Cube (double measure_side)
		{
			Measure_side = measure_side;
			this.measure_side = measure_side;
		}

        // Method Overloaded method   
        public double GetArea() //#1 No parameters
		{ 
			return 6*(Math.Pow(measure_side,2)); 
		}

        public double GetArea(double measure_side) //#2 Whit one parameter 
        {
            return 6 * (Math.Pow(measure_side, 2));
        }

        public double GetVolume ()
		
		{
			return Math.Pow(GetArea(),3);
		}

        //Cube class finisher
        ~Cube ()
		{

		}
	}
}
