using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace kiemtra2
{
     class Teststudent
    {
        List<Student> liststudent;
        public Teststudent()
        {
           
            this.liststudent = new List<Student> {
            new Student(){id="20201839",name= "Anh",gender= "nam",age= 18,dateofbirth= "01/03/2002",Class= "ch2",mark1= 9,mark2= 9,mark3= 8},
            new Student(){id="20201829",name= "An",gender= "nu",age= 18,dateofbirth= "02/03/2002",Class= "ch3",mark1= 8,mark2= 9,mark3= 8 },
            new Student(){id="20201819",name= "nh",gender= "nam",age= 18,dateofbirth= "03/03/2002",Class= "ch2",mark1= 7,mark2= 9,mark3= 8 },
            new Student(){id="20201849",name= "Ah",gender= "nu",age= 18,dateofbirth= "04/03/2002",Class= "ch1",mark1= 9,mark2= 9,mark3= 10 },
            };
        }
        public List<Student> GetStudent()
        {
            return liststudent;
        }

        //them 1 st
        public void them1st(string id,string name,string gender, int age,string dateofbirth,string Class,float mark1,float mark2,float mark3)
        {
            liststudent.Add(new Student() {id=id,name=name,gender=gender,age=age,dateofbirth=dateofbirth,Class=Class,mark1=mark1,mark2=mark2,mark3=mark3 });
        }

        //tim 1 stu bang ten
        public Student timbangten(string name)
        {
            Student st = null;
            foreach (var item in liststudent) 
            {
                if (item.name == name)
                {
                    st = item;
                }
            }
            return st;

        }
        // chinh sua thong tin
        public void suathongtin(string namecu, string id, string name, string gender, int age, string dateofbirth, string Class, float mark1, float mark2, float mark3)
        {
            foreach (Student x in liststudent)
            {
                if (x.name == namecu)
                {
                    x.name = name;
                    x.id = id;
                    x.gender = gender;
                    x.age = age;
                    x.dateofbirth = dateofbirth;
                    x.Class = Class;
                    x.mark1 = mark1;
                    x.mark2 = mark2;
                    x.mark3 = mark3;
                }
            }

        }
        //xoa 1 st bang id
        public Student xoast(string id)
        {
            Student st = null;
            foreach (var item in liststudent)
            {
                if (item.id == id)
                {
                    st = item;
                }
            }
            return st;
        }
        // sap xep st theo thu tu
     
        public void sapxep()
        {
            SortBydtb theotb = new SortBydtb();           
            liststudent.Sort(theotb);
            
        }
        public class SortBydtb : IComparer<Student>
        {
            public int Compare(Student e1, Student e2)
            {
                return e1.marktb.CompareTo(e2.marktb);
            }
        }




    }
}
