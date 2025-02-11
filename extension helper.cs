using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_project
{
    internal static class extension_helper
    {
        public delegate bool objectacc(user user);
        public static user helpfind(this List<user> Users,objectacc objectacc)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (objectacc(Users[i]))
                    return Users[i];
            }
            return null;
        }
    }
}
