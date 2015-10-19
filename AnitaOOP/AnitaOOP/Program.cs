using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnitaOOP
{
  class Program
  {
    static void Main(string[] args)
    {
      string yas = YasBilgisiniOku();
      EkranaYasiYaz(yas);
    }

    private static string YasBilgisiniOku()
    {
      Console.Write("Lütfen yaşınızı giriniz? ");
      string yas = Console.ReadLine();
      return yas;
    }

    private static void EkranaYasiYaz(string yas)
    {
      Console.WriteLine(string.Format("Merhaba Anita, sen {0} yaşındasın!", yas));
      Console.ReadLine();
    }
  }
}
