using System;
using System.Collections.Generic;

namespace Directos.Modulo2.Ejercicio1.Utils
{
    public class FileRepository : IFileRepository
    {
        private List<File> files;

        private FileRepository()
        {
            this.files = new List<File>();
            
            this.files.Add(new File("1", "craft"));
            this.files.Add(new File("2", "Code"));
        }

        public File FindOneById(string id)
        {
            foreach(File file in this.files) {
                if (file.Id() == id) {
                    return file;
                }
            }

            throw new System.Exception("file not found");
        }
    }
}
