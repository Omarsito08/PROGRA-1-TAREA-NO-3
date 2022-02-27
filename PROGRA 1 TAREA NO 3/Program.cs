static void desgloce()
{
    float CAN;
    int C200, C100, C50, C20, C10, C5, C1, CEN50, CEN25, CEN10, CEN5, CEN1;
    C200 = C100 = C50 = C20 = C10 = C5 = C1 = CEN50 = CEN25 = CEN10 = CEN5 = CEN1 = 0;
    String linea;
    Console.WriteLine("INGRESE LA CANTIDAD A DESGLOSAR");

    linea = Console.ReadLine();
    CAN = float.Parse(linea);


    if ((CAN >= 200))
    {
        C200 = (int)(CAN / 200);
        CAN = CAN - (C200 * 200);
    }
    if ((CAN >= 100))
    {
        C100 = (int)(CAN / 100);
        CAN = CAN - (C100 * 100);
    }

    if ((CAN >= 50))
    {
        C50 = (int)(CAN / 50);
        CAN = CAN - (C50 * 50);
    }

    if ((CAN >= 20))
    {
        C20 = (int)(CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (int)(CAN / 10);
        CAN = CAN - (C10 * 10);
    }

    if ((CAN >= 5))
    {
        C5 = (int)(CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    if ((CAN >= 1))
    {
        C1 = (int)(CAN / 1);
        CAN = CAN - (C1 * 1);
    }

    if ((CAN >= 0.50))
    {
        CEN50 = (int)(CAN / 0.50);
        CAN = (CAN - (float)(CEN50 * 0.50));
    }
    if ((CAN >= 0.25))
    {
        CEN25 = (int)(CAN / 0.25);
        CAN = (CAN - (float)(CEN25 * 0.25));
    }
    if ((CAN >= 0.1))
    {
        CEN10 = (int)(CAN / 0.1);
        CAN = (CAN - (float)(CEN10 * 0.1));
    }
    if ((CAN >= 0.05))
    {
        CEN5 = (int)(CAN / 0.05);
        CAN = (CAN - (float)(CEN5 * 0.05));
    }
    if ((CAN >= 0.01))
    {
        CEN1 = (int)(CAN / 0.01);
        CAN = (CAN - (float)(CEN1 * 0.01));
    }

    Console.WriteLine($"BILLETES DE 200:  {C200}");
    Console.WriteLine($"BILLETES DE 100:  {C100}");
    Console.WriteLine($"BILLETES DE 50:   {C50}");
    Console.WriteLine($"BILLETES DE 20:   {C20}");
    Console.WriteLine($"BILLETES DE 10:   {C10}");
    Console.WriteLine($"BILLETES DE 5:    {C5}");
    Console.WriteLine($"BILLETES DE 1:    {C1}");
    Console.WriteLine($"MONEDAS DE 0.50:  {CEN50}");
    Console.WriteLine($"MONEDAS DE 0.25:  {CEN25}");
    Console.WriteLine($"MONEDAS DE 0.10:  {CEN10}");
    Console.WriteLine($"MONEDAS DE 0.05:  {CEN5}");
    Console.WriteLine($"MONEDAS DE 0.01:  {CEN1}");



}

static void desglocedolares()
{
    float CAN, mult, Quetzales;
    int C200, C100, C50, C20, C10, C5, C1, CEN50, CEN25, CEN10, CEN5, CEN1;
    C200 = C100 = C50 = C20 = C10 = C5 = C1 = CEN50 = CEN25 = CEN10 = CEN5 = CEN1 = 0;
    String linea;
    Console.WriteLine("INGRESE LA CANTIDAD DE DOLARES A DESGLOSAR");

    linea = Console.ReadLine();
    CAN = float.Parse(linea);
    mult = CAN;
    Quetzales = (float)(mult * 7.69);

    if ((CAN >= 200))
    {
        C200 = (int)(CAN / 200);
        CAN = CAN - (C200 * 200);
    }
    if ((CAN >= 100))
    {
        C100 = (int)(CAN / 100);
        CAN = CAN - (C100 * 100);
    }

    if ((CAN >= 50))
    {
        C50 = (int)(CAN / 50);
        CAN = CAN - (C50 * 50);
    }

    if ((CAN >= 20))
    {
        C20 = (int)(CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (int)(CAN / 10);
        CAN = CAN - (C10 * 10);
    }

    if ((CAN >= 5))
    {
        C5 = (int)(CAN / 5);
        CAN = CAN - (C5 * 5);
    }

    if ((CAN >= 1))
    {
        C1 = (int)(CAN / 1);
        CAN = CAN - (C1 * 1);
    }

    if ((CAN >= 0.50))
    {
        CEN50 = (int)(CAN / 0.50);
        CAN = (CAN - (float)(CEN50 * 0.50));
    }
    if ((CAN >= 0.25))
    {
        CEN25 = (int)(CAN / 0.25);
        CAN = (CAN - (float)(CEN25 * 0.25));
    }
    if ((CAN >= 0.1))
    {
        CEN10 = (int)(CAN / 0.1);
        CAN = (CAN - (float)(CEN10 * 0.1));
    }
    if ((CAN >= 0.05))
    {
        CEN5 = (int)(CAN / 0.05);
        CAN = (CAN - (float)(CEN5 * 0.05));
    }
    if ((CAN >= 0.01))
    {
        CEN1 = (int)(CAN / 0.01);
        CAN = (CAN - (float)(CEN1 * 0.01));
    }

    Console.WriteLine($"BILLETES DE 200 DOLARES:  {C200}");
    Console.WriteLine($"BILLETES DE 100 DOLARES:  {C100}");
    Console.WriteLine($"BILLETES DE 50 DOLARES:   {C50}");
    Console.WriteLine($"BILLETES DE 20 DOLARES:   {C20}");
    Console.WriteLine($"BILLETES DE 10 DOLARES:   {C10}");
    Console.WriteLine($"BILLETES DE 5 DOLARES:    {C5}");
    Console.WriteLine($"BILLETES DE 1 DOLARES:    {C1}");
    Console.WriteLine($"MONEDAS DE 0.50 CENTAVOS DE DOLAR:  {CEN50}");
    Console.WriteLine($"MONEDAS DE 0.25 CENTAVOS DE DOLAR:  {CEN25}");
    Console.WriteLine($"MONEDAS DE 0.10 CENTAVOS DE DOLAR:  {CEN10}");
    Console.WriteLine($"MONEDAS DE 0.05 CENTAVOS DE DOLAR:  {CEN5}");
    Console.WriteLine($"MONEDAS DE 0.01 CENTAVOS DE DOLAR:  {CEN1}");
    Console.WriteLine("La cantidad {0} dolares, equivale a {1} Quetzales", mult, Quetzales);


}
desglocedolares();