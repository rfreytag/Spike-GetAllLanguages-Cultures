using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace Spike_GetAllLanguages_Cultures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrate how to retrieve all Languages-Regions from the System.Globalization.CultureType class");

            List<CultureInfo> ci_list = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures)
                                                 .ToList<CultureInfo>();

            Console.WriteLine("List of all .NET CultureTypes (Language-Culture)\n");

            foreach (CultureInfo ci in ci_list)

            {
                Console.WriteLine("{0,-31}{1,-47}", "PROPERTY", "INTERNATIONAL");
                Console.WriteLine("{0,-31}{1,-47}", "CompareInfo", ci.CompareInfo);
                Console.WriteLine("{0,-31}{1,-47}", "DisplayName", ci.DisplayName);
                Console.WriteLine("{0,-31}{1,-47}", "EnglishName", ci.EnglishName);
                Console.WriteLine("{0,-31}{1,-47}", "IsNeutralCulture", ci.IsNeutralCulture);
                Console.WriteLine("{0,-31}{1,-47}", "IsReadOnly", ci.IsReadOnly);
                Console.WriteLine("{0,-31}{1,-47}", "LCID", ci.LCID);
                Console.WriteLine("{0,-31}{1,-47}", "Name", ci.Name);
                Console.WriteLine("{0,-31}{1,-47}", "NativeName", ci.NativeName);
                Console.WriteLine("{0,-31}{1,-47}", "Parent", ci.Parent);
                Console.WriteLine("{0,-31}{1,-47}", "TextInfo", ci.TextInfo);
                Console.WriteLine("{0,-31}{1,-47}", "ThreeLetterISOLanguageName", ci.ThreeLetterISOLanguageName);
                Console.WriteLine("{0,-31}{1,-47}", "ThreeLetterWindowsLanguageName", ci.ThreeLetterWindowsLanguageName);
                Console.WriteLine("{0,-31}{1,-47}", "TwoLetterISOLanguageName", ci.TwoLetterISOLanguageName);

                Console.WriteLine("\n\n");
            }

            Console.WriteLine("END OF OUTPUT -----------------------------------------------");
        }
    }
}
