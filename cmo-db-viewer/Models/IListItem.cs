using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_viewer.Models
{
    public interface IListItem
    {
        /// <summary>
        /// Represents the properties of the table in the database, in order
        /// </summary>
        List<(Type, string)> Properties { get; }

        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        int ComponentID { get; set; }

        void AssignComponents();
    }
}
