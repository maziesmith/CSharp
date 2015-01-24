//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationMoon
{
    static void Main()
    {
        double weightEarth = 53.5;
        Console.WriteLine("The weight on the moon will be:"+((17.0/100)*weightEarth)+" if the weight on the Earth is "+weightEarth);

    }
}

