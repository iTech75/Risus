using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnitaOOP.Classes
{
  class Kadin : Insan
  {
    string bedenOlcusu;

    public Kadin(int yas, string adsoyad)
      : base(yas, adsoyad)
    {
      bedenOlcusu = "90-60-90";
    }

    public Kadin(int yas, string adsoyad, string bedenOlcusu) : base(yas, adsoyad)
    {
      this.bedenOlcusu = bedenOlcusu;
    }

    public void ElbiseAl()
    {
      string mesaj = mesajiHazirla();
      Console.WriteLine(mesaj);
    }

    private string mesajiHazirla()
    {
      return string.Format("Ben {0}, Benim beden ölçüm {1}, lütfen elbise ver!", getAdSoyad(), bedenOlcusu);
    }

    public override void MerhabaYaz(string kime)
    {
      string mesaj = string.Format("merhaba şekerim, ben {0}, yaşımı sorma lütfen, tabiki 18", getAdSoyad());
      Console.WriteLine(mesaj);
    }
  }
}