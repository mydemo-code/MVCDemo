using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DemoCode.DelegateDemo;

namespace DemoCode
{
    public class DemoClass
    {
        

        /// <summary>
        /// 使用lambda表达式计算两个学生的年龄
        /// </summary>
        /// <param name="stuone">第一个学生</param>
        /// <param name="stutwo">第二个学生</param>
        /// <returns>返回年龄大于18岁的学生</returns>
        public static bool CompareStuAge(Student stuone, Student stutwo)=> stuone.Age <= stutwo.Age;


        //按照age排序
        public static void SortStudent(List<Student> sList)
        {

            var list =  sList.OrderBy(o => o.Age);

            //打印排序后的链表
            foreach (Student s in list)
                Console.WriteLine($"{s.Name} {s.Age} {s.Sex} {s.Tel} ");
        }



    }
}
