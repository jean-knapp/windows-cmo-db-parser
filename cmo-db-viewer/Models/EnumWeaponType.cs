using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_viewer.Models
{
    public class EnumWeaponType : DataEnum
    {
        public new static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public override string TableName { get; } = "EnumWeaponType";
    }
}
