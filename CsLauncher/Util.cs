using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CsLauncher
{
    static class Util
    {
        public static bool IsPathExist( this string path )
        {
            if ( path == string.Empty ) return false;
            return File.Exists( path ) || Directory.Exists( path );
        }
    }
}
