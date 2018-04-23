using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Example.Models {
    public class MyObject {
        public MyObject() {
            ID = 0;
            Name = String.Empty;
        }

        public MyObject(Int32 ID, String Name) {
            this.ID = ID;
            this.Name = Name;
        }

        [Key]
        public Int32 ID { get; set; }
        public String Name { get; set; }
    }
}