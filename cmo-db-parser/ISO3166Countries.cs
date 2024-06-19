using System.Collections.Generic;

namespace cmo_db_parser
{
    internal class ISO3166Countries
    {
        public static List<(string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent)> Entries = new List<(string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent)>
        {
            // South America
            ("AR", "ARG", "Argentina", -34.6037, -58.3816, "South America"),
            ("BO", "BOL", "Bolivia", -16.5000, -68.1500, "South America"),
            ("BR", "BRA", "Brazil", -15.7939, -47.8828, "South America"),
            ("CL", "CHL", "Chile", -33.4489, -70.6693, "South America"),
            ("CO", "COL", "Colombia", 4.7110, -74.0721, "South America"),
            ("EC", "ECU", "Ecuador", -0.1807, -78.4678, "South America"),
            ("GY", "GUY", "Guyana", 6.8013, -58.1551, "South America"),
            ("PY", "PRY", "Paraguay", -25.2637, -57.5759, "South America"),
            ("PE", "PER", "Peru", -12.0464, -77.0428, "South America"),
            ("SR", "SUR", "Suriname", 5.8664, -55.1668, "South America"),
            ("UY", "URY", "Uruguay", -34.9011, -56.1645, "South America"),
            ("VE", "VEN", "Venezuela", 10.4806, -66.9036, "South America"),

            // North America
            ("AG", "ATG", "Antigua and Barbuda", 17.1175, -61.8456, "North America"),
            ("BS", "BHS", "Bahamas", 25.0343, -77.3963, "North America"),
            ("BB", "BRB", "Barbados", 13.0975, -59.6167, "North America"),
            ("BZ", "BLZ", "Belize", 17.5046, -88.1962, "North America"),
            ("CA", "CAN", "Canada", 45.4215, -75.6972, "North America"),
            ("CR", "CRI", "Costa Rica", 9.9281, -84.0907, "North America"),
            ("CU", "CUB", "Cuba", 23.1136, -82.3666, "North America"),
            ("DM", "DMA", "Dominica", 15.3092, -61.3794, "North America"),
            ("DO", "DOM", "Dominican Republic", 18.4861, -69.9312, "North America"),
            ("SV", "SLV", "El Salvador", 13.6929, -89.2182, "North America"),
            ("GD", "GRD", "Grenada", 12.0561, -61.7486, "North America"),
            ("GT", "GTM", "Guatemala", 14.6349, -90.5069, "North America"),
            ("HT", "HTI", "Haiti", 18.5944, -72.3074, "North America"),
            ("HN", "HND", "Honduras", 14.0723, -87.1921, "North America"),
            ("JM", "JAM", "Jamaica", 18.1096, -77.2975, "North America"),
            ("MX", "MEX", "Mexico", 19.4326, -99.1332, "North America"),
            ("NI", "NIC", "Nicaragua", 12.1140, -86.2362, "North America"),
            ("PA", "PAN", "Panama", 8.9833, -79.5167, "North America"),
            ("KN", "KNA", "Saint Kitts and Nevis", 17.3578, -62.7820, "North America"),
            ("LC", "LCA", "Saint Lucia", 13.9094, -60.9789, "North America"),
            ("VC", "VCT", "Saint Vincent and the Grenadines", 13.1600, -61.2248, "North America"),
            ("TT", "TTO", "Trinidad and Tobago", 10.6918, -61.2225, "North America"),
            ("US", "USA", "United States", 38.9072, -77.0369, "North America")
        };

        public static (string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent) GetTupleByCountryName(string countryName)
        {
            foreach((string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent) row in Entries) {
                if (row.CountryName == countryName)
                {
                    return row;
                }
            }

            return (null, null, null, 0, 0, null);
        }
    }
}
