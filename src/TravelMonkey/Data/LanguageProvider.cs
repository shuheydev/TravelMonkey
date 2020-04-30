using System;
using System.Collections.Generic;
using System.Text;
using TravelMonkey.Models;

namespace TravelMonkey.Data
{
    public static class LanguageProvider
    {
        public static List<Language> GetLanguages()
        {
            var languages = new List<Language>
            {
                new Language{Name="English",Code="en"},
                new Language{Name="Japanese",Code="ja"},
                new Language{Name="French",Code="fr"},
                new Language{Name="Dutch",Code="nl"},
                new Language{Name="Spanish",Code="es"},
            };

            return languages;
        }
    }
}
