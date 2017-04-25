using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandD
{
    public abstract class Stratgy_s
    {
        public string q;
        public abstract DataTable search();

    }
    public class search_by_name : Stratgy_s
    {
        public override DataTable search()
        {
            string[] pat = new string[9];
            pat[0] = "P_Name";
            pat[1] = "P_Address";
            pat[2] = "DiseaseDescription";
            pat[3] = "age";
            pat[4] = "sex";
            pat[5] = "DR_Name";
            pat[6] = "roomNumber";
            pat[7] = "P_type";
            pat[8] = "p_date";
            DataTable p = DB.GetInstance().display("select P_Name,P_Address,DiseaseDescription,age,sex,doctor.DR_Name,roomNumber,P_type,p_date from patient join doctor on doctor.DR_ID=patient.D_ID where P_Name='" + q + "'", pat);
            return p;
        }


    }
    public class search_by_Type : Stratgy_s
    {
        public override DataTable search()
        {

            string[] pat = new string[9];
            pat[0] = "P_Name";
            pat[1] = "P_Address";
            pat[2] = "DiseaseDescription";
            pat[3] = "age";
            pat[4] = "sex";
            pat[5] = "DR_Name";
            pat[6] = "roomNumber";
            pat[7] = "P_type";
            pat[8] = "p_date";
            DataTable p = DB.GetInstance().display("select P_Name,P_Address,DiseaseDescription,age,sex,doctor.DR_Name,roomNumber,P_type,p_date from patient join doctor on doctor.DR_ID=patient.D_ID where P_type='" + q + "'", pat);
            return p;



        }

    }

    public class search_by_date : Stratgy_s
    {

        public override DataTable search()
        {
            string[] pat = new string[9];
            pat[0] = "P_Name";
            pat[1] = "P_Address";
            pat[2] = "DiseaseDescription";
            pat[3] = "age";
            pat[4] = "sex";
            pat[5] = "DR_Name";
            pat[6] = "roomNumber";
            pat[7] = "P_type";
            pat[8] = "p_date";
            DataTable p = DB.GetInstance().display("select P_Name,P_Address,DiseaseDescription,age,sex,doctor.DR_Name,roomNumber,P_type,p_date from patient join doctor on doctor.DR_ID=patient.D_ID where p_date='" + q + "'", pat);
            return p;
        }


    }
    public class search_doctor_type : Stratgy_s
    {
        public override DataTable search()
        {

            string[] DOC = new string[6];
            DOC[0] = "DR_Name";
            DOC[1] = "DR_Adress";
            DOC[2] = "DR_Age";
            DOC[3] = "DR_sex";
            DOC[4] = "DR_specialist";
            DOC[5] = "DR_Type";
            DataTable p = DB.GetInstance().display("select DR_Name,DR_Adress,DR_Age,DR_sex,DR_specialist,DR_Type from doctor where DR_Type='" + q + "'", DOC);
            return p;
        }



    }
    public class search_doctor_name : Stratgy_s
    {
        public override DataTable search()
        {

            string[] DOC = new string[6];
            DOC[0] = "DR_Name";
            DOC[1] = "DR_Adress";
            DOC[2] = "DR_Age";
            DOC[3] = "DR_sex";
            DOC[4] = "DR_specialist";
            DOC[5] = "DR_Type";
            DataTable p = DB.GetInstance().display("select DR_Name,DR_Adress,DR_Age,DR_sex,DR_specialist,DR_Type from doctor where DR_Name='" + q + "'", DOC);
            return p;
        }



    }

    public class Context_s
    {

        private Stratgy_s _strategy;          // Constructor 
        public string r;
        public Context_s(Stratgy_s strategy,string v)
        {
            r = v;
            this._strategy = strategy;
            strategy.q = r;

        }
        public DataTable ContextInterface()
        {
            DataTable p = _strategy.search();
            return p;
        }

    }


}
