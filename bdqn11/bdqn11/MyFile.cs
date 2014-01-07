using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn11
{
    public class MyFile
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private string fileType;

        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }
        private float fileSize;

        public float FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public MyFile(string fileName,string fileType,float fileSize,string filePath)
        {
            this.fileName = fileName;
            this.fileType = fileType;
            this.fileSize = fileSize;
            this.filePath = filePath;
        }


    }
}
