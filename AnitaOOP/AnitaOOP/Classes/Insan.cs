using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnitaOOP.Classes
{
  class Insan
  {
    private string adsoyad;
    protected string getAdSoyad()
    {
      return adsoyad;
    }

    private int yas;

    public int getYas()
    {
      return yas;
    }

    public void setYas(int value)
    {
      if (value < 1 || value > 125)
      {
        throw new Exception("Insan yaşı 0-125 arasında olmalıdır.");
      }
      yas = value;
    }

    public Insan()
    {
      adsoyad = "isimsiz";
      yas = 18;
    }

    public Insan(int yas) : this()
    {
      this.yas = yas;
    }

    public Insan(int yas, string adsoyad)
    {
      this.adsoyad = adsoyad;
      this.yas = yas;
    }

    public virtual void MerhabaYaz()
    {
      MerhabaYaz(null);
    }

    public virtual void MerhabaYaz(string kime)
    {
      string mesaj = mesajiHazirla();
      if (kime != null)
      {
        mesaj = string.Format("{0}, sana dedim {1}", mesaj, kime);
      }
      Console.WriteLine(mesaj);
    }

    private string mesajiHazirla()
    {
      return string.Format("Merhaba ben {0}, {1} yaşındayım...", adsoyad, yas);
    }
  }
}