using System;
using System.Collections.Generic;

class Program
{
    string programmerfam;
    string progi;
    string languages;

    static void Main(string[] args)
    {
        Console.WriteLine("Введите фамилию:");
        string programmerfam = Convert.ToString(Console.ReadLine());
        

        List<info> list = new List<info>();
        list.Add(new info() { programmerfam = programmerfam, progi = "Количество прог = 3", languages = "Количество языков = 2" });

        foreach(info i in list)
        {
            Console.WriteLine(i.programmerfam);
            Console.WriteLine(i.languages);
            Console.WriteLine(i.progi);
        }
        Console.WriteLine();


        Console.WriteLine("Подтвердите количество языков:\n");
        string l = Console.ReadLine();
        int languages = Int32.Parse(l); 
        Console.WriteLine("Подтвердите количество прог:\n");
        string p = Console.ReadLine();
        int progi = Int32.Parse(p);

        switch(languages)
        {
            case 2:
                Console.WriteLine("Вы подтвердили значения");
                break;
            default:
                Console.WriteLine("Вы ввели неверное значение!!!");
                break;
                    switch(progi)
                    {
                        case 3:
                            Console.WriteLine("Вы подтвердили значение одно из значений(1/2)");
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение!!!");
                            break;
                    }
                        if (languages == default)
                        {
                            break;
                            if (progi == default)
                            {
                                break;
                            }
                        }
                Console.WriteLine();
        }

        if (languages == 2)
        {
            if (progi == 3)
            {
                int q = 6, Qp;

                Console.WriteLine("Q = " + q);

                int p1 = 2;
                Console.WriteLine("P = " + p1);

                Qp = q * p1 / 3;

                Console.WriteLine("Qp = " + Qp);
            }
        }

    }
    class info
    {
        public string programmerfam { get; set; }
        public string progi { get; set; }
        public string languages { get; set; }
    }
}