using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Kekzamen
{
    class Student
    {
      public int id;
      public string Name;
      public string Surname;
      public string Group;

      public Student()
      {

      }
      public Student(int id)
      {
            string st = WorkWithFile.ReadLine(id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            Name = ss[1];
            Surname = ss[2];
            Group = ss[3];
      }
        public void Save()
        {
            WorkWithFile.AddUpdate(id, Name, Surname, Group);
        }



    }
}
