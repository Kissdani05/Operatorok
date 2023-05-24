using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Operatorok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kifejezesek = File.ReadAllLines("Datasource\\kifejezesek.txt").ToList();

            // 2. feladat
            Console.WriteLine($"2. feladat: Az állomány {kifejezesek.Count} kifejezést tartalmaz.");

            // 3. feladat

            Console.WriteLine($"3. feladat: A maradékos osztást tartalmazó kifejezések száma: {kifejezesek.Count(x => x.Split(" ")[1] == "mod")}");

            // 4. feladat

            Console.WriteLine($"4. feladat: {(kifejezesek.Any(x => int.Parse(x.Split(" ")[0]) % 10 == 0 && int.Parse(x.Split(" ")[2]) % 10 == 0) ? "Van" : "Nincs")} olyan kifejezés, amelyben mindkét operandus maradék nélkül osztható tízzel.");

            
        }
    }
}
