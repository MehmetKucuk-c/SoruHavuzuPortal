using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SoruHavuzuPortal
{
    /// <summary>
    /// Program açıkken değişmeyen kod
    /// </summary>
    class GirisBilgiTut
    {
        private static GirisBilgiTut girisBilgiTut;


        public string IsimTut {set; get; }
        public int IdTut {set; get; }

        private GirisBilgiTut()
        {

        }

        public static GirisBilgiTut GetInstance()
        {
            if(girisBilgiTut==null)
            {
                girisBilgiTut = new GirisBilgiTut();
            }
            return girisBilgiTut;
        }
    }
}