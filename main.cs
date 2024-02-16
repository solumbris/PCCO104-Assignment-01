using System;

class Program {
  public static void Main (string[] args) {
    double denomination = 25;

    // No Person is found for .01, .05, .25
    string person_1 = "Jose Rizal";
    string person_5 = "Emilio Aguinaldo";
    string person_10 = "Andres Bonifacio, Apolinario Mabini";
    string person_20 = "Manuel L. Quezon";
    string person_50 = "Sergio Osmena";
    string person_100 = "Manuel Roxas";
    string person_200 = "Diosdado Macapagal";
    string person_500 = "Benigno Sr. and Corazon Aquino";
    string person_1000 = "Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda";

    if (denomination == 1000)
      {
        Console.WriteLine ($"{person_1000} is found in Php. {denomination} ");
      }
    else if (denomination == 500)
      {
        Console.WriteLine ($"{person_500} is found in Php. {denomination} ");
      }
    else if (denomination == 200)
      {
        Console.WriteLine ($"{person_200} is found in Php. {denomination} ");
      }
    else if (denomination == 100)
      {
        Console.WriteLine ($"{person_100} is found in Php. {denomination} ");
      }
    else if (denomination == 50)
      {
        Console.WriteLine ($"{person_50} is found in Php. {denomination} ");
      }
    else if (denomination == 20)
      {
        Console.WriteLine ($"{person_20} is found in Php. {denomination} ");
      }
    else if (denomination == 10)
      {
        Console.WriteLine ($" {person_10} is found in Php. {denomination} ");
      }
    else if (denomination == 5)
      {
        Console.WriteLine ($"{person_5} is found in Php. {denomination} ");
      }
    else if (denomination == 1)
      {
        Console.WriteLine ($"{person_1} is found in Php. {denomination} ");
      }
    else if (denomination == 0.25 | denomination == 0.05 | denomination == 0.01)
      {
        Console.WriteLine ($"No Person is found for Php. {denomination} ");
      }
    else
    {
      Console.WriteLine($"Invalid Denomination: {denomination}");
    }
  }
}