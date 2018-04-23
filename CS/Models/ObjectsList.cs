using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models {
    public class ObjectsList {
        private const String Key = "SomeValue";

        public List<MyObject> GetObjects() {
            if (HttpContext.Current.Session["Key"] == null) {
                List<MyObject> list = new List<MyObject>();

                list.Add(new MyObject(1, "Test1"));
                list.Add(new MyObject(2, "Test2"));
                list.Add(new MyObject(3, "Test3"));
                list.Add(new MyObject(4, "Test4"));

                HttpContext.Current.Session["Key"] = list;
            }

            return (List<MyObject>)HttpContext.Current.Session["Key"];
        }

        public void UpdateObject(MyObject obj) {
            List<MyObject> objects = GetObjects();
            
            MyObject editedObject = objects.Where(m => m.ID == obj.ID)
                .First();

            editedObject.Name = obj.Name;
        }
    }
}