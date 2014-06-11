// The gravitational field of the Moon is approximately 17% of that on the Earth. 
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter weight of a man on Earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = (17 * weightOnEarth) / 100;
        Console.WriteLine("Weight on Moon is: {0}", weightOnMoon);
    }
}