using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Operatorok
{
    class Program
    {
        static List<string> kifejezesek = new List<string>();
        static void Main(string[] args)
        {
            kifejezesek = File.ReadAllLines("C:\\Users\\Dani\\source\\repos\\ConsoleApp8\\ConsoleApp8\\kifejezesek.txt").ToList();

            // 2. feladat
            Console.WriteLine($"2. feladat: Az állomány {kifejezesek.Count} kifejezést tartalmaz.");

            // 3. feladat

            Console.WriteLine($"3. feladat: A maradékos osztást tartalmazó kifejezések száma: {kifejezesek.Count(x => x.Split(" ")[1] == "mod")}");

            // 4. feladat

            Console.WriteLine($"4. feladat: {(kifejezesek.Any(x => Convert.ToInt32(x.Split(" ")[0]) % 10 == 0 && Convert.ToInt32(x.Split(" ")[2]) % 10 == 0) ? "Van" : "Nincs")} olyan kifejezés, amelyben mindkét operandus maradék nélkül osztható tízzel.");

            // 5. feladat

            Console.WriteLine($"5. feladat: Statisztika \n mod -> {kifejezesek.Count(x => x.Contains("mod"))} db \n / -> {kifejezesek.Count(x => x.Contains("/"))} db \n div -> {kifejezesek.Count(x => x.Contains("div"))} db \n - -> {kifejezesek.Count(x => x.Contains("-"))} db \n * -> {kifejezesek.Count(x => x.Contains("*"))} db \n + -> {kifejezesek.Count(x => x.Contains("+"))} db");

            // 6. feladat
            static string checkOperators(string ans)
            {
                string ret = "";

                double elsoszam = Convert.ToInt32(ans.Split(" ")[0]);
                string op = ans.Split(" ")[1];
                double masodikszam = Convert.ToInt32(ans.Split(" ")[2]);

                if (masodikszam != 0)
                {
                    if (op == "mod")
                    {
                        ret = $"{ans} = {elsoszam % masodikszam}";
                    }
                    else if (op == "/")
                    {
                        ret = $"{ans} = {elsoszam / masodikszam}";
                    }
                    else if (op == "div")
                    {
                        ret = $"{ans} = {Convert.ToInt32(elsoszam / masodikszam)}";
                    }
                    else if (op == "-")
                    {
                        ret = $"{ans} = {elsoszam - masodikszam}";
                    }
                    else if (op == "*")
                    {
                        ret = $"{ans} = {elsoszam * masodikszam}";
                    }
                    else if (op == "+")
                    {
                        ret = $"{ans} = {elsoszam + masodikszam}";
                    }
                    else
                    {
                        ret = $"{ans} = Hibás operátor!";
                    }
                }
                else
                {
                    ret = $"{ans} = Egyéb hiba!";
                }
                return ret;
            }
        }
        }
    }
