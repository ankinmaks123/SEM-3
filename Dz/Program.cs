
Console.WriteLine("Напишиет пятизначное число!");
string abobus = Console.ReadLine();
while(true)
{   if (abobus[0] == abobus[4] && abobus[1]==abobus[3] && abobus[2]==abobus[2] && abobus[3]==abobus[1] && abobus[4] == abobus[0]  )
{
Console.WriteLine("Вот число палиндроном{0}",abobus);}
    else { 
Console.WriteLine ("Не палиндроном");}
    break;
} 
Console.WriteLine("Exit");