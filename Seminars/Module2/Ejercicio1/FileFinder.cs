using System;
using Directos.Modulo2.Ejercicio1.Utils;

namespace Directos.Modulo2.Ejercicio1
{
    public class FileFinder
    {
        private IFileRepository fileRepository;

        public FileFinder(IFileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }

        public File FindOneById(string id)
        {
            File file = this.fileRepository.FindOneById(id);

            return file;
        }
    }
}
