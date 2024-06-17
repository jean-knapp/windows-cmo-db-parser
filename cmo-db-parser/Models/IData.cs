using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public interface IData
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Represents the properties of the table in the database, in order
        /// </summary>
        List<(Type, string)> Properties { get; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        int ID { get; set; }
    }
}
