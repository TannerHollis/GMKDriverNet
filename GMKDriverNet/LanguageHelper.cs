using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GMKDriverNET
{
    public class WordLookup
    {
        public string shortHand { get; set; }
        public string EN { get; set; } // English
        public string ES { get; set; } // Spanish
        public string AF { get; set; } // Afrikaans
        public string AR { get; set; } // Arabic
        public string FR { get; set; } // French
        public string RU { get; set; } // Russian
        public string PT { get; set; } // Portuguese
        public string ID { get; set; } // Indonesian
        public string ZH { get; set; } // Chinese
        public string DE { get; set; } // German
        public string JA { get; set; } // Japanese
        public string HI { get; set; } // Hindi
        public string NL { get; set; } // Dutch

        public WordLookup()
        {
            // Do nothing...
        }
    }

    public class WordLookups
    {
        public List<WordLookup> Lookups { get; set; }

        public WordLookups()
        {
            Lookups = new List<WordLookup>();
        }

        public static WordLookups FromFile()
        {
            string jsonString = File.ReadAllText("wordLookups.json");

            return JsonSerializer.Deserialize<WordLookups>(jsonString);
        }

        public void ToFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(this, options);

            File.WriteAllText("wordLookups.json", jsonString);
        }
    }

    public class LanguageHelper
    {
        private static WordLookups _lookups;

        public static void Load()
        {
            if (_lookups == null)
            {
                _lookups = WordLookups.FromFile();
            }
        }

        public static string LookupPhrase(string shortHand)
        {
            Load();
            foreach (WordLookup lookup in _lookups.Lookups)
            {
                if (shortHand == lookup.shortHand)
                {
                    switch (Settings.GetLanguage())
                    {
                        case "EN":
                            return lookup.EN;

                        case "ES":
                            return lookup.ES;

                        case "AF":
                            return lookup.AF;

                        case "AR":
                            return lookup.AR;

                        case "FR":
                            return lookup.FR;

                        case "RU":
                            return lookup.RU;

                        case "PT":
                            return lookup.PT;

                        case "ID":
                            return lookup.ID;

                        case "ZH":
                            return lookup.ZH;

                        case "DE":
                            return lookup.DE;

                        case "JA":
                            return lookup.JA;

                        case "HI":
                            return lookup.HI;

                        case "NL":
                            return lookup.NL;

                        default:
                            return "N/A";
                    }
                }
            }
            return "N/A";
        }
    }
}
