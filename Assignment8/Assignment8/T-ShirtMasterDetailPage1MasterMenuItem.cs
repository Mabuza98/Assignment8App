using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class T_ShirtMasterDetailPage1MasterMenuItem
    {
        public T_ShirtMasterDetailPage1MasterMenuItem()
        {
            TargetType = typeof(T_ShirtMasterDetailPage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}