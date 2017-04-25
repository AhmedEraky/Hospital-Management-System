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
    public abstract class Implenator
    {
        public abstract DataTable display();

    }
    public class display_p_ID : Implenator
    {

        public override DataTable display()
        {
            string[] pat = new string[10];
            pat[0] = "P_ID";
            pat[1] = "P_Name";
            pat[2] = "P_Address";
            pat[3] = "DiseaseDescription";
            pat[4] = "age";
            pat[5] = "sex";
            pat[6] = "DR_Name";
            pat[7] = "roomNumber";
            pat[8] = "P_type";
            pat[9] = "p_date";
            DataTable p = DB.GetInstance().display("select P_ID,P_Name,P_Address,DiseaseDescription,age,sex,doctor.DR_Name,roomNumber,P_type,p_date from patient join doctor on doctor.DR_ID=patient.D_ID order by P_Name", pat);
            return p;
        }

    }

    public class display_p : Implenator
    {
        public override DataTable display()
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
            DataTable p = DB.GetInstance().display("select P_Name,P_Address,DiseaseDescription,age,sex,doctor.DR_Name,roomNumber,P_type,p_date from patient join doctor on doctor.DR_ID=patient.D_ID order by P_Name", pat);
            return p;
        }
    }

    public class display_D : Implenator
    {
        public override DataTable display()
        {
            string[] DOC = new string[6];

            DOC[0] = "DR_Name";
            DOC[1] = "DR_Adress";
            DOC[2] = "DR_Age";
            DOC[3] = "DR_sex";
            DOC[4] = "DR_specialist";
            DOC[5] = "DR_Type";
            DataTable D = DB.GetInstance().display("select DR_Name,DR_Adress,DR_Age,DR_sex,DR_specialist,DR_Type from doctor order by DR_Name", DOC);
            return D;

        }


    }

    public class display_D_id : Implenator
    {
        public override DataTable display()
        {
            string[] DOC = new string[7];
            DOC[0] = "DR_ID";
            DOC[1] = "DR_Name";
            DOC[2] = "DR_Adress";
            DOC[3] = "DR_Age";
            DOC[4] = "DR_sex";
            DOC[5] = "DR_specialist";
            DOC[6] = "DR_Type";
            DataTable D = DB.GetInstance().display("select DR_ID,DR_Name,DR_Adress,DR_Age,DR_sex,DR_specialist,DR_Type from doctor", DOC);
            return D;
        }
    }

    public class Abstraction
    {

        private Implenator _implenator;

        // Constructor 

        public Abstraction(Implenator implenator)
        {
            this._implenator = implenator;

        }
        public DataTable AbstractionInterface()
        {
            DataTable p = _implenator.display();
           return p;
        }

    }
}

