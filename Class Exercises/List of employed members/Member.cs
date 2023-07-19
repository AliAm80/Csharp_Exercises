using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Get_Info
{
    public class Member
    {

        public string _fullName;
        public int _age;
        public string _job;
        public int _id;

        public Member(string fullName, int age, string job, int id)
        {
            _fullName = fullName;
            _age = age;
            _job = job;
            id = idMaker();
            _id = id;
        }
        public Member()
        {

        }

        public int idMaker()
        {
            Random rand = new Random();
            var id = rand.Next(10, 100);
            return id;
        }

    }
}