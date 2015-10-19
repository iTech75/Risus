using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnitaOOP.Classes
{
  class Erkek : Insan
  {
    public Erkek(int yas, string adsoyad)
      : base(yas, adsoyad)
    {
    }

    public override void MerhabaYaz(string kime)
    {
      base.MerhabaYaz(kime);
      Console.WriteLine("benimle çıkar mısın?");
    }
  }
}
