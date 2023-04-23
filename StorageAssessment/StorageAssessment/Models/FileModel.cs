using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAssessment.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public FileModel( string name, string location, int type)
        {
            this.Location = location;
            this.Name = name;
            this.Type = type;
        }
    }
}
