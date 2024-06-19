using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumOperatorCountry : DataEnum
    {
        public new static List<IData> DataEntries { get; set; } = new List<IData>();

        public override string TableName { get; } = "EnumOperatorCountry";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(int), nameof(YearStart)), // YearStart
            (typeof(int), nameof(YearEnd)) // YearEnd
        };

        /// <summary>
        /// Represents the year the country was founded.
        /// </summary>
        public int YearStart { get; set; }

        /// <summary>
        /// Represents the year the country was dissolved.
        /// </summary>
        public int YearEnd { get; set; }

        //(string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent)
        private string twoLetterCode = null;

        public string TwoLetterCode
        {
            get
            {
                if (twoLetterCode == null)
                {
                    (string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent) iso3166Country = ISO3166Countries.GetTupleByCountryName(Description);

                    twoLetterCode = iso3166Country.TwoLetterCode ?? "";
                }
                    
                return twoLetterCode;
            }
        }
    }
}
