using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricBody
{
    internal class Fig3D
    {
        //Properties
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        protected int num_faces;

        public int Num_faces
        {
            get { return num_faces; }
            set { num_faces = value; }
        }


        protected int num_vertices;

        public int Num_vertices
        {
            get { return num_vertices; }
            set { num_vertices = value; }
        }

        protected int num_edges;

        public int Num_edges
        {
            get { return num_edges; }
            set { num_edges = value; }
        }

        //Constructor 
        public Fig3D()
        {
            name = "";
            num_faces = 0;
            num_vertices = 0;
            num_edges = 0;
        }


        //Method 
        public string Dimentions()
        {
            return "Geometric body are geometric figures of three dimensions, width, length and depth.";
        }

        public void CreateFigure(string name, int num_faces, int num_edges) // With several parameters
            
        {
            name = Name;
            this.name = name;

            num_faces = Num_faces;
            this.num_faces = num_faces;

            num_edges = Num_edges;
            this.num_edges = num_edges;
        }

        //Fig3D class Finisher  
        ~Fig3D() 
        { 
        }
    }
}
