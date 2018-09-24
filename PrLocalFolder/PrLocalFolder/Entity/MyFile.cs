using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrLocalFolder.Entity
{
    class MyFile
    {
        private int _id;
        private string _fileName;

        public int Id { get => _id; set => _id = value; }
        public string FileName { get => _fileName; set => _fileName = value; }
    }
}
