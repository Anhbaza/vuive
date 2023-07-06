using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra2
{
     class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string dateofbirth { get; set; }
        public string Class { get; set; }
        public float mark1 { get; set; }
        public float mark2 { get; set; }
        public float mark3 { get; set; }
        public float marktb;
       
        public void mark_AVG()
        {
            marktb = (mark1 + mark2 + mark3) / 3;
            Console.WriteLine("Diem trung binh cua sinh vien la: " + marktb);
        }
        public void display()
        {
            Console.WriteLine("Ten: "+name);
            Console.WriteLine("Ma so sinh vien " + id);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("gioi tinh : " + gender);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("diem so cua sinh vien: {0}, {1}, {2} ", mark1, mark2, mark3);
            

        }
    }
}
