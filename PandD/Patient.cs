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


    public class Patient : Person
    {

        protected string Disease_description;
        protected string Doctor_name;
        protected string date;
        protected string roomnumber;
        protected DataTable ta;

        //------------------------------
        //set Data functions
        public void set_room(string s)
        {
            this.roomnumber = s;
        }
        public void setdate(string s)
        {
            this.date = s;
        }
        public void set_DN(string s)
        {
            this.Doctor_name = s;
        }
        public void set_dd(string s)
        {
            this.Disease_description = s;
        }
        public Patient set(string n, string a, string d, string ag, string s, string dc, string r, string t, string day, string dam, string dad)
        {
            this.name = n;
            this.address = a;
            this.Disease_description = d;
            this.age = ag;
            this.sex = s;
            this.Doctor_name = dc;
            this.roomnumber = r;
            this.type = t;
            this.date = day + "-" + dam + "-" + dad;
            return this;
        }

        //-----------------------------------


        //insert
        //----------------------------------
        public virtual void addp(){}
        //----------------------------------

      
        //Update
        //----------------------------------
        public void update()
        {
            string[] s = new string[5];
            string[] d = new string[5];

            s[0] = this.Disease_description;
            s[1] = this.Doctor_name;
            s[2] = this.roomnumber;
            s[3] = this.type;
            s[4] = this.id;
            //-----------------------------------------
            d[0] = "@DiseaseDescription";
            d[1] = "@D_ID";
            d[2] = "@roomNumber";
            d[3] = "@P_type";
            d[4] = "@P_ID";

            DB.GetInstance().proc("updateP", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
                MessageBox.Show("you Update patient correctly");
        }
        //----------------------------------


        //delete
        //----------------------------------
        public void Delete()
        {
            string[] s = new string[1];
            string[] d = new string[1];
            s[0] = this.id;
            //-----------------------------------------
            d[0] = "@P_ID";
            DB.GetInstance().proc("deletee", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
                MessageBox.Show("you delete patient correctly");

        }
        //----------------------------------


        //---------------------------------------
        //display
        public void set_display(int i)
        {

            if (i == 1)
                abstraction = new Abstraction(new display_p_ID());
            else
                abstraction = new Abstraction(new display_p());

        }
        public DataTable get_display()
        {
            DataTable b = abstraction.AbstractionInterface();
            return b;
        }
        //-----------------------------------------


        //search
        //-------------------------------
        public void set_search(int i)
        {
            if (i == 1)
            {
                context_s = new Context_s(new search_by_date(), date);

            }
            else if (i == 2)
                context_s = new Context_s(new search_by_name(), name);
            else
                context_s = new Context_s(new search_by_Type(), type);
        }
        public DataTable get_search()
        {

            DataTable b = context_s.ContextInterface();
            return b;

        }
        //---------------------------------
        
       

    }

   public class emergency_patient : Patient
    {
        public override void addp()
        {

            string[] s = new string[8];
            string[] d = new string[8];
            s[0] = this.name;
            s[1] = this.address;
            s[2] = this.Disease_description;
            s[3] = this.age;
            s[4] = this.sex;
            s[5] = this.Doctor_name;          
            s[6] = this.type;
            s[7] = this.date;

            //-----------------------------------------
            d[0] = "@p_Name";
            d[1] = "@P_Address";
            d[2] = "@DiseaseDescription";
            d[3] = "@age";
            d[4] = "@sex";
            d[5] = "D_ID";
            d[6] = "@P_type";
            d[7] = "@p_date";

            DB.GetInstance().proc("saveN", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
            {
                MessageBox.Show("you add new patient correctly");
            }
        }
       
    }

   public class Normal_patient : Patient
    {
        public override void addp()
        {
            string[] s = new string[9];
            string[] d = new string[9];
            s[0] = this.name;
            s[1] = this.address;
            s[2] = this.Disease_description;
            s[3] = this.age;
            s[4] = this.sex;
            s[5] = this.Doctor_name;
            s[6] = this.roomnumber;
            s[7] = this.type;
            s[8] = this.date;

            //-----------------------------------------
            d[0] = "@p_Name";
            d[1] = "@P_Address";
            d[2] = "@DiseaseDescription";
            d[3] = "@age";
            d[4] = "@sex";
            d[5] = "D_ID";
            d[6] = "@roomNumber";
            d[7] = "@P_type";
            d[8] = "@p_date";

            DB.GetInstance().proc("savee", d, s);
            if (DB.GetInstance().condation == 0)
            { }
            else
            {
                MessageBox.Show("you add new Doctor correctly");
            }
        }
       
    }
}
