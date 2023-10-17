using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFileRenamer
{
    public class FileObject
    {
        /// <summary>
        /// Represents a file that is read from the directory
        /// </summary>
        public string filename { get; set; }
        public string path { get; set; }
        public string type { get; set; }
    }
}
