using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NukeNetCMS.Common.Enums
{
    public enum ActiveStatus
    {
        Published,
        Draft
    }

    public static partial class EnumUtils
    {
        public static bool GetActiveStatusValue(this ActiveStatus value)
        {
            switch (value)
            {
                case ActiveStatus.Published: return true;
                case ActiveStatus.Draft: return false;
                default: throw new ArgumentOutOfRangeException("value");
            }
        }

        public static ActiveStatus SetActiveStatusValue(this ActiveStatus key, bool value)
        {
            return value == true ? ActiveStatus.Published : ActiveStatus.Draft;
        }
    }
}
