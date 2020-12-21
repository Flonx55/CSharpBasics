using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11构造函数
{
    class Student
    {
        long _id;
        char _gender;
        int _classId;
        public Student (long aId,int aClassId):this(aId,'0',aClassId )
        {

        }
        public Student (long aId,char aGender,int aClassId)
        {
            _id = aId;
            _gender = aGender;
            _classId = aClassId;
        }
        public void StudentMessage()
        {
            Console.WriteLine("{0},{1},{2}",_id ,_gender ,_classId );
        }
    }
}
