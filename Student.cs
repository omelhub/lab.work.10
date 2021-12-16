using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._10
{
    struct Student : IComparable<Student> //поменяй на class и сравни
    {
        public uint Number;
        public uint CountPhone;
        public uint CountLunch;
        public Position Position;

        public int CompareTo(Student s)
        {
            if (this.CountPhone.CompareTo(s.CountPhone) == 0)
                return this.Position.CompareTo(s.Position);
            return this.CountPhone.CompareTo(s.CountPhone);

            //настраивает метод sort() так, что список сортируется по значению CountPhone
            //если значения CountPhone равны, то отдает предпочтение младшему
        }
    }
}
