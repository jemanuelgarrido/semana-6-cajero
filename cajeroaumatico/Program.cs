using System;

static void desglose()
{
    int CAN, C100, C50, C20, C10, C5;
    CAN = C100 = C50 = C20 = C10 = C5 = 0;
    String linea;
    Console.Write("Ingrese una cantidad en Q;");
    linea = Console.ReadLine();
    CAN = Convert.ToInt32(linea);

    if ((CAN >= 100))
    {
        C100 = (CAN / 100);
        CAN = CAN - (C100 * 100);
    }
    if ((CAN >= 50))
    {
        C50 = (CAN / 50);
        CAN = CAN - (C50 * 50);
    }
    if ((CAN >= 20))
    {
        C20 = (CAN / 20);
        CAN = CAN - (C50 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (CAN / 5);
        CAN = CAN - (C5 * 5);
    }
    Console.WriteLine($"---ESTOS SON TUS BILLETES---");
    Console.WriteLine($"BILLETES DE 100: {C100}");
    Console.WriteLine($"BILLETES DE 50: {C50}");
    Console.WriteLine($"BILLETES DE 20: {C20}");
    Console.WriteLine($"BILLETES DE 10: {C10}");
    Console.WriteLine($"BILLETES DE 5: {C5}");
    Console.WriteLine($"BILLETES DE 1: {CAN}");

}

static void contraseña()
{
    byte Oportunidades, TienePermiso;
    string CLAVE;
    TienePermiso = 0;
    Oportunidades = 0;
    do
    {
        Console.WriteLine("DIGITE CLAVE:");
        //CLAVE = Console.ReadLine();//
        CLAVE = HideCharacter().Replace("\r", "");
        Console.WriteLine();
        if ((CLAVE.ToUpper() == "444"))
        {
            TienePermiso = 1;

        }
        else
        {
            Oportunidades++;
        }

    } while (((Oportunidades < 3) & (TienePermiso == 0)));

    if (TienePermiso == 1)
    {
        Console.WriteLine("Bienvenido ");
        desglose();
        Console.WriteLine();
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Oportunidades Terminadas");
    }
    Console.ReadLine();
}
{
    contraseña();

}
 static string HideCharacter()
{
    ConsoleKeyInfo key;
    string code = "";
    do
    {
        key = Console.ReadKey(true);

        if (char.IsNumber(key.KeyChar))
        {
            Console.Write("*");

        }
        code += key.KeyChar;
    }
    while (key.Key != ConsoleKey.Enter);
    return code;
}











