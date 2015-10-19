using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnitaOOP.Classes;

namespace AnitaOOP
{
  class ProgramOOP
  {
    static void Main(string[] args)
    {
      Insan insan = new Insan();
      insan.setYas(65);
      Kadin anita = new Kadin(41, "Anita Barin Aytekin");
      Insan tekin = new Erkek(40, "Tekin Aytekin");
      Kadin arven = new Kadin(4, "Arven Arya Aytekin", "60-60-60");

      Insan[] insanlar = { insan, anita, tekin, arven, anita };
      //Console.WriteLine(anita.getYas());
      //tekin = anita;
      //tekin.setYas(99);
      //Console.WriteLine(anita.getYas());

      foreach (Insan item in insanlar)
      {
        item.MerhabaYaz();
        if (item is Kadin)
        {
          Kadin kadin = item as Kadin;//(Kadin)item;
          kadin.ElbiseAl();
        }
        item.MerhabaYaz("Ehsa");
        Console.WriteLine("---------------");
      }

      Console.ReadLine();
    }
  }
}