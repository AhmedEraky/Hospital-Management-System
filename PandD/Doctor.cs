using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PandD
{
   public class Doctor:Person
    {
        protected string specialest;
        protected DataTable ta;
        //set
       //---------------------------------------- 
        public void set_spichialest(string s)
        {
            this.specialest = s;
        }
        public void set(string n, string a, string ag, string s, string t,string sp)
        {
            
            this.name = n;
            this.address = a;
            this.age = ag;
            this.sex = s;
            this.specialest = sp;
            this.type = t;
            
        }
       //---------------------------------------
        public void Delete(string newId)
        {
            string[] s = new string[2];
            string[] d = new string[2];
            s[0] = this.id;
            s[1] = newId;
            //-----------------------------------------
            d[0] = "@DR_ID";
            d[1] = "@DR_ID2";
            DB.GetInstance().proc("deleteD", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
                MessageBox.Show("you delete Doctor correctly");
        }
      
        public void insert()
        {


            string[] s = new string[6];
            string[] d = new string[6];
            s[0] = this.name;
            s[1] = this.address;
            s[2] = this.age;
            s[3] = this.sex;
            s[4] = this.type;
            s[5] = this.specialest;

            //-----------------------------------------
            d[0] = "@DR_Name";
            d[1] = "@DR_Adress";
       
            d[2] = "@DR_Age";
            d[3] = "@DR_sex";

            d[4] = "@DR_Type"; 
            d[5] = "@DR_specialist";
            DB.GetInstance().proc("saveeD", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
            {
                MessageBox.Show("you add new Doctor correctly");
            }


        }
       public void Update()
        {
            string[] s = new string[3];
            string[] d = new string[3];
            s[0] = this.type;
            s[1] = this.specialest;
            s[2] = this.id;
            //-----------------------------------------

            d[0] = "@DR_Type";
            d[1] = "@DR_specialist ";
            d[2] = "@DR_ID";
            DB.GetInstance().proc("updateD1", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
                MessageBox.Show("you Update new Doctor correctly");

        }

       //display
       //-------------------------------
       public void set_display(int i)
        {

            if (i == 1)
                abstraction = new Abstraction(new display_D_id());
            else
                abstraction = new Abstraction(new display_D());

        }
       public DataTable get_display()
        {
            DataTable b = abstraction.AbstractionInterface();
            return b;
        }
       //-------------------------------
       
       //search
       //--------------------------------
       public void set_search(int i)
        {
           if (i==1)
           {
               context_s = new Context_s(new search_doctor_name(), name);
           }
           else
           {
               context_s = new Context_s(new search_doctor_type(), type);
           }
        }
       public DataTable get_search()
       {

           DataTable b = context_s.ContextInterface();
           return b;

       }
       //------------------------------
        
    }
}

