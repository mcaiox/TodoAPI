using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        // A model is a set of classes that represent the data the application manages. The model for this app is a single TodoItem Class
        //Model classes could really go anywhere, but the Models folder is a convention
        //Models are represented as C# classes, also know as Plain Old CLR Object(POCOs)
   
        public long Id { get; set; }  //This Id Property maps to a unique key in a relational database
        public string Name { get; set; }

        public bool IsComplete { get; set; }


    }
}
