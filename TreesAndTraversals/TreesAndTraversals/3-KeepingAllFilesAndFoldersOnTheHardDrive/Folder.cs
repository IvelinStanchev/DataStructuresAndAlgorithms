using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_KeepingAllFilesAndFoldersOnTheHardDrive
{
    class Folder
    {
        public string Name { get; set; }
        public File[] Files { get; set; }
        public Folder[] ChildFolders { get; set; }

        public Folder(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("The name should not be null");
            }

            this.Name = name;
            this.Files = new File[0];
            this.ChildFolders = new Folder[0];
        }

        public Folder(string name, params File[] files)
            : this(name)
        {
            this.Files = files;
            this.ChildFolders = new Folder[0];

        }

        public Folder(string name, File[] files, Folder[] folders)
            : this(name, files)
        {
            this.ChildFolders = folders;
        }
    }
}
