using System;
using System.Collections.Generic;

namespace cmo_db_viewer.Models
{
    public class EnumOperatorCountry : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

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
                    LoadISO3166();
                }
                    
                return twoLetterCode;
            }
        }

        private string threeLetterCode = null;

        public string ThreeLetterCode
        {
            get
            {
                if (twoLetterCode == null)
                {
                    LoadISO3166();
                }

                return threeLetterCode;
            }
        }

        private double latitude = 0;
        public double Latitude
        {
            get
            {
                if (twoLetterCode == null)
                {
                    LoadISO3166();
                }

                return latitude;
            }
        }

        private double longitude = 0;
        public double Longitude
        {
            get
            {
                if (twoLetterCode == null)
                {
                    LoadISO3166();
                }

                return latitude;
            }
        }

        private string continent = null;
        public string Continent
        {
            get
            {
                if (twoLetterCode == null)
                {
                    LoadISO3166();
                }

                return continent;
            }
        }

        private string osmCountryName = null;
        public string OSMCountryName
        {
            get
            {
                if (twoLetterCode == null)
                {
                    LoadISO3166();
                }

                return osmCountryName;
            }
        }

        private void LoadISO3166()
        {
            (string TwoLetterCode, string ThreeLetterCode, string CountryName, string OSMCountryName, double Latitude, double Longitude, string Continent) iso3166Country = ISO3166Countries.GetTupleByCountryName(Description);

            twoLetterCode = iso3166Country.TwoLetterCode ?? "";
            threeLetterCode = iso3166Country.ThreeLetterCode ?? "";
            latitude = iso3166Country.Latitude;
            longitude = iso3166Country.Longitude;
            continent = iso3166Country.Continent;
            osmCountryName = iso3166Country.OSMCountryName;
        }

    }
}
