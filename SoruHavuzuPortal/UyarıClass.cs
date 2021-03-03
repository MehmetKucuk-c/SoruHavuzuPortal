using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruHavuzuPortal
{
    class UyarıClass
    {
        public void Alert(string msg, BildirimForms.EnmType type)
        {
            BildirimForms bildirimcs = new BildirimForms();
            bildirimcs.ShowAlert(msg, type);
        }
    }
}
