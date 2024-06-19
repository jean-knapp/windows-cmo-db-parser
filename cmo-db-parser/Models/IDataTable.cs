using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser.Models
{
    internal interface IDataTable
    {
        /// <summary>
        /// Represents the properties of the table in the database, in order
        /// </summary>
        List<(Type, string)> Properties { get; }

        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        string TableName { get; }
    }
}
