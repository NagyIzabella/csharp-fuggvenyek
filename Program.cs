//// Magánhangzó eltávolítás

//string maganhangzo_torol(string szoveg)
//{
//    string maganhangzok = "aeiouAEIOU";
//    string kimenet = "";

//    for (int i = 0; i < szoveg.Length; i++)
//    {
//        if (maganhangzok.Contains(szoveg[i]))
//        {
//            continue;
//        }

//        else
//        {
//            kimenet += szoveg[i];
//        }
//    }

//    return kimenet;
//}

//Console.WriteLine("Input: Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol.");
//Console.WriteLine($"Output: {maganhangzo_torol("Iden Java szigeten voltunk nyaralni. Nem is tudtam, hogy elneveztek egy helyet egy programozasi nyelvrol.")}");

//// Elmozdulás

//string elmozdulas(string bemenet)
//{
//    int y = 0;
//    int x = 0;

//    string merreY = "fel";
//    string merreX = "jobbra";

//    for (int i = 0; i < bemenet.Length; i++)
//    {
//        if (bemenet[i] == 'F')
//        {
//            y++;
//        }

//        else if (bemenet[i] == 'L')
//        {
//            y--;
//        }

//        else if (bemenet[i] == 'J')
//        {
//            x++;
//        }

//        else if (bemenet[i] == 'B')
//        {
//            x--;
//        }
//    }

//    if (y < 0)
//    {
//        merreY = "le";
//    }

//    if (x < 0)
//    {
//        merreX = "balra";
//    }

//    if (y == 0 && x == 0)
//    {
//        return "Nem mentunk sehova";
//    }

//    else
//    {
//        return $"{Math.Abs(x)} lepes {merreX}, {Math.Abs(y)} lepes {merreY}";
//    }
//}

//Console.WriteLine("Példa 1.");
//Console.WriteLine("Input. JJFBFFFFFFBBBL");
//Console.WriteLine($"Return: {elmozdulas("JJFBFFFFFFBBBL")}");

//Console.WriteLine("\nPélda 2.");
//Console.WriteLine("Input. FBLLLJLLJ");
//Console.WriteLine($"Return: {elmozdulas("FBLLLJLLJ")}");


// Szöveg titkosítása

string kodol(string bemenet, int n, string c)
{

    string kimenet = "";

    for (int i = 0; i < bemenet.Length; i++)
    {
        kimenet += bemenet[i];
        
        for (int j = 0; j < n; j++)
        {
            kimenet += c;
        }
    }

    return kimenet;
}

Console.WriteLine("Input: Pizza delben?, 3, x");
Console.WriteLine($"Return: {kodol("Pizza delben?", 3, "x")}");