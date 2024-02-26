using GeometricBody;

Fig3D figA = new Fig3D();
figA.Name = "Geometric body";
figA.Num_faces = 10;
figA.Num_vertices = 40;
figA.Num_edges= 40;
Console.WriteLine(figA.Dimentions());
Console.WriteLine("\nName:" + figA.Name + "\nVertices number: " + figA.Num_vertices + "\nEdges number: " + figA.Num_edges + "\nFaces number: " + figA.Num_faces);

Cube CubeA = new Cube();
CubeA.Name = "Cube 1";
CubeA.Num_vertices =8;
CubeA.Num_edges=12;
CubeA.Num_faces =6;
Console.WriteLine("\nName:"+CubeA.Name+"\nVertices number: "+CubeA.Num_vertices+"\nEdges number: "+CubeA.Num_edges+"\nFaces number: "+CubeA.Num_faces);
CubeA.Measure_side = 15.5;
Console.WriteLine("Area: " + CubeA.GetArea());
Console.WriteLine("Volume: " + CubeA.GetVolume());
Console.WriteLine(CubeA.Dimentions());


Cube CubeB = new Cube(0.3);

//Finisher
CubeB = null;


CubeB.Name= "Cube 2";
CubeB.Num_vertices = 8;
CubeB.Num_edges = 12;
CubeB.Num_faces = 6;
Console.WriteLine("\nName:" + CubeB.Name + "\nVertices number: " + CubeB.Num_vertices + "\nEdges number: " + CubeB.Num_edges + "\nFaces number: " + CubeB.Num_faces);
Console.WriteLine("Area: " + CubeB.GetArea());
Console.WriteLine("Volume: " + CubeB.GetVolume());
Console.WriteLine(CubeB.Dimentions());

