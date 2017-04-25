using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace PandD
{
    public class Person
    {
        protected string name;
        protected string address;
        protected string age;
        protected string sex;
        protected string id;
        protected string type;
        protected Abstraction abstraction;
        protected Context_s context_s;
       public void set_name(string s)
       {
           this.name = s;
       }
       public void set_id(string s)
       {
           this.id = s;
       }
       public void set_age(string s)
       {
           this.age = s;
       }
       public void set_type(string s)
       {
           this.type = s;
       }

       }
}
