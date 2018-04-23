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

namespace BindToList {
    public class Bug {
        private int id;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        private int status;

        public int Status {
            get { return status; }
            set { status = value; }
        }

        const int count = 10;
        public static List<Bug> GetBugList() {
            List<Bug> result = new List<Bug>(count);
            for (int i = 0; i < count; i++) {
                Bug st = new Bug();
                st.Name = "Bug" + i.ToString();
                st.id = i;
                st.Status = i % 3;
                result.Add(st);
            }
            return result;
        }

    }
}
