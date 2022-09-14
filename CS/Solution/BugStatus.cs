using System.Collections.Generic;

namespace Solution {
    public class BugStatus {
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

        public static List<BugStatus> GetStatusesList() {
            string[] names = new string[] { "Accepted", "Rejected", "Fixed" };
            List<BugStatus> result = new List<BugStatus>(names.Length);
            for (int i = 0; i < names.Length; i++) {
                BugStatus st = new BugStatus();
                st.Name = names[i];
                st.id = i;
                result.Add(st);
            }
            return result;
        }

    }
}
