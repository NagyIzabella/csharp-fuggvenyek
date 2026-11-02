// Jelszó-erősség mérő

int jelszo_erosseg(string jelszo)
{
    int pontszam = 1;

    if (jelszo.Count() >= 5)
    {
        pontszam += 1;
    }

    if (jelszo.Count() >= 8)
    {
        pontszam += 2;
    }

    for (int i = 0; i < jelszo.Count(); i++)
    {
        if (jelszo[i] == '_' || jelszo[i] == '-' || jelszo[i] == '.')
        {
            pontszam += 2;
        }
    }

    if (jelszo.Contains("jelszo") || jelszo.Contains("123") || jelszo.Count() == 0)
    {
        pontszam = 0;
    }

    return pontszam;
}

Console.WriteLine($"Jelszó: hazi_macska_4_life\nPontszám: {jelszo_erosseg("hazi_macska_4_life")}\n");
Console.WriteLine($"Jelszó: ez1feltorhetetlenjelszo\nPontszám: {jelszo_erosseg("ez1feltorhetetlenjelszo")}");
