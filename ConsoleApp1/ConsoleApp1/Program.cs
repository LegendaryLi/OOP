using System;
using System.Collections.Generic;

public class Program
{
    private string programmerfam;
    private string progi;
    private string languages;

    public Program(string programmerfaml, string progil, string languagesl)
    {
        programmerfam = programmerfaml;
        progi = progil;
        languages = languagesl;
    }

    static void Main()
    {

        Console.WriteLine("Введите фамилию:");
        string pf = Convert.ToString(Console.ReadLine());
        

        List<info> list = new List<info>();
        list.Add(new info() { programmerfam = pf, progi = "Количество прог = 3", languages = "Количество языков = 2" });

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
                Console.WriteLine("Вы подтвердили значение одно из значений(1/2)");
                break;
            default:
                Console.WriteLine("Вы ввели неверные значения!!!");
                break;
                    switch(progi)
                    {
                        case 3:
                            Console.WriteLine("Вы подтвердили значение одно из значений(1/2)");
                            break;
                        default:
                            Console.WriteLine("Вы подтвердили значение одно из значений(1/2)");
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
   
} 
class info
{
  public string programmerfam { get; set; }
  public string progi { get; set; }
  public string languages { get; set; }
}