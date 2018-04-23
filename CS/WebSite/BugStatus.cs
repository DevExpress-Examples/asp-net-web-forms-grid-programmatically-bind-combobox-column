using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace BindToList
{
    public class BugStatus
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static List<BugStatus> GetStatusesList()
        {
            string[] names = new string[] {"Accepted", "Rejected", "Fixed" };
            List<BugStatus> result = new List<BugStatus>(names.Length);
            for (int i = 0; i < names.Length; i++)
            {
                BugStatus st = new BugStatus();
                st.Name = names[i];
                st.id = i;
                result.Add(st);
            }
            return result;
        }

    }
}
