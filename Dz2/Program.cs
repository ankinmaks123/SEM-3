Console.WriteLine("Введите XYZ для первой точки");
string pervie_coordinati =Console.ReadLine();
Console.WriteLine("Введите XYZ для воторой точки");
string vtorie_coordinati =Console.ReadLine();
double resh = Math.Sqrt(((vtorie_coordinati[0]-pervie_coordinati[0])^2 )+(vtorie_coordinati[1]-pervie_coordinati[1])^2+(vtorie_coordinati[2]-pervie_coordinati[2])^2) ;
Console.WriteLine(resh);
