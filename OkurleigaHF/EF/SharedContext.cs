using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkurleigaHF.EF
{
    public class SharedContext
    {
        public static OkDBContext DBContext = new OkDBContext();
    }
}
