using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.id_generator
{
    public class Id
    {
        private char[] _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
        public string _letterId;
        public string _numberId;
        public string _id;
        
        public string NewStudentId()
        {
            Random rnd = new Random();
            _letterId = _chars[rnd.Next(26)].ToString();
            _numberId = _chars[rnd.Next(26, 36)].ToString();
            _id = _letterId + _numberId;
            return _id;
        }
        public string NewTeacherId()
        {
            Random rnd = new Random();
            _letterId = _chars[rnd.Next(26)].ToString();
            _numberId = _chars[rnd.Next(26, 36)].ToString();
            _id = _numberId + _letterId;
            return _id;
        }
        


    }
}
