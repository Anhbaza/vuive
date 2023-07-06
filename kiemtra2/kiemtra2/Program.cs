using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danh sach sinh vien");
            Teststudent test = new Teststudent();
            List<Student> list = test.GetStudent();
            foreach (Student m in list)
            {
                m.mark_AVG();
                m.display();
            }
            Console.WriteLine("//////////////////////////////////////");
            Console.ReadKey();

            Console.WriteLine("Them sinh vien Anhbaza");
            test.them1st("20201623", "Anhbaza", "nam", 20, "01/03/2002", "Ch2", 10, 10, 6);
            foreach (Student m in list)
            {
                m.mark_AVG();
                m.display();
            }
            Console.ReadKey();
            Console.WriteLine("//////////////////////////////////////");
            Console.WriteLine("Tim sinh vien Anh");
            // tim bang ten
            Student sb = test.timbangten("Anh");
            sb.display();
            Console.ReadKey();
            Console.WriteLine("//////////////////////////////////////");
            Console.WriteLine("Xoa sinh vien co id 20201839");
            //xoa stu
            Student st = test.xoast("20201839");
            list.Remove(sb);
            ShowStudents(list);
            Console.ReadKey();
            Console.WriteLine("//////////////////////////////////////");
            Console.WriteLine("Sua sinh vien an thanh Anhbaza1");
            // chinh sua
            test.suathongtin("An","20201623", "Anhbaza1", "nam", 20, "01/03/2002", "Ch2", 10, 10, 6);
            ShowStudents(list);
            Console.ReadKey();
            Console.WriteLine("//////////////////////////////////////");
            // sap xep
            Console.WriteLine("Sap xep danh sac theo diem trung binh");
            test.sapxep();
            ShowSortstu(list);
            

        }

        private static void ShowStudents(List<Student> list)
        {
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine($"list count: {list.Count}");
            foreach (Student student in list)
            {

                student.display();
                student.mark_AVG();
            }
        }
            private static void ShowSortstu(List<Student> list) 
            {
                foreach (Student student in list)
                {
                    Console.WriteLine("Ten:" + student.name);
                    Console.WriteLine("dtb:{0} ",student.marktb);
                }
            }
        
        
    }
}
