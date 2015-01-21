//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;


class Floats
{
    static void Main()
    {
        float a = 1.000009F;
        float b = 1.000019F;
        float c = 1.0000099F;
        float d = 1.0000009F;
        Console.WriteLine("The float variables:");
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
        Console.WriteLine("c="+c);
        Console.WriteLine("d="+d);
        decimal eps = 0.000001m;
        Console.WriteLine("eps="+eps); 
        bool ab;
        bool ac;
        bool ad;
        bool bc;
        bool bd;
        bool cd;

        decimal differenceAB = Math.Abs((decimal)(a - b));
        if (differenceAB<=eps)
        {
            ab = true;
            Console.WriteLine("Is a=b? "+ab+" because |a - b|="+differenceAB+" <=  eps= :"+eps);
        }
        else 
        {
            ab = false;
            Console.WriteLine("Is a=b? " + ab + " because |a - b|=" + differenceAB + " >  eps= :" + eps);
        }

        decimal differenceAC = Math.Abs((decimal)(a - c));
        if(differenceAC<=eps)
        {
            ac = true;
            Console.WriteLine("Is a=c? " + ac + " because |a-c|=" + differenceAC + " <= eps=:" + eps);
        }
        else
        {
            ac = false;
            Console.WriteLine("Is a=c? " + ac + " because |a-c|=" + differenceAC + " > eps=:" + eps);
        }

        decimal differenceAD = Math.Abs((decimal)(a - d));
        if (differenceAD<=eps)
        {
            ad = true;
            Console.WriteLine("Is a=d? " + ad + " because |a-d|="+differenceAD+" <= eps="+eps);
        }
        else
        {
            ad = false;
            Console.WriteLine("Is a=d? " + ad + " because |a-d|=" + differenceAD + " > eps=" + eps);
        }

        decimal differenceBC = Math.Abs((decimal)(b - c));
        if (differenceBC<=eps)
        {
            bc = true;
            Console.WriteLine("Is b=c? " + bc + " because |b-c|= " + differenceBC+" <= eps="+eps);
        }
        else
        {
            bc = false;
            Console.WriteLine("Is b=c? " + bc + " because |b-c|= " + differenceBC + " > eps=" + eps);
        }

        decimal differenceBD = Math.Abs((decimal)(b - d));
        if (differenceBD<=eps)
        {
            bd = true;
            Console.WriteLine("Is b=d? " + bd + " because |b-d|="+differenceBD+" <= eps="+eps);
        }
        else
        {
            bd = false;
            Console.WriteLine("Is b=d? " + bd + " because |b-d|=" + differenceBD + " > eps=" + eps);
        }

        decimal differenceCD = Math.Abs((decimal)(c - d));
        if(differenceCD<=eps)
        {
            cd = true;
            Console.WriteLine("Is c=d "+cd+" because |c-d|="+differenceCD+" <= eps="+eps);
        }
        else
        {
            cd = false;
            Console.WriteLine("Is c=d " + cd + " because |c-d|=" + differenceCD + " > eps=" + eps);
        }
    }
}

