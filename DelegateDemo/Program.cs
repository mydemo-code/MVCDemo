using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemo.AutoDelegateDemo;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化学生
            Student student1 = new Student { Name = "韩梅梅", Age = 18, Sex = "女", Tel = "132164", Nationality = "中国" };
            Student student2 = new Student { Name = "赵日天", Age = 28, Sex = "男", Tel = "4561464123", Nationality = "美国" };

            ScoreDelegate(student1, student2);
            Console.WriteLine("\n");
            ActionDelegate(student1, student2);
            Console.WriteLine("\n");

            //实例化一个func
            string a = FuncDemo.func(1, 2);
            Console.WriteLine(a);
          
            string count = FuncDemo.Test<Student,Student>(FuncDemo.Func, student1, student2).ToString();
            Console.WriteLine(count);
            
            string rs = FuncDemo.Test<int,int>(FuncDemo.Func,4, 2).ToString();
            Console.WriteLine(rs);

            

        }

        /// <summary>
        /// 原委托调用示例
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        private static void ScoreDelegate(Student student1, Student student2)
        {
            Console.WriteLine("-----------------原委托的调用start!---------------");
            Console.WriteLine("-----------------1---------------");
            //1.实例化 不带返回值 不带参数 的委托
            //MyDelegate1 my = new AutoDelegateDemo().SayHello;//单方法执行
            MyDelegate1 my = null; //可执行多个方法
            my += new AutoDelegateDemo().SayHello;
            my += new AutoDelegateDemo().SayHellolilei;
            my.Invoke();//执行无参数无返回值的委托SayHello方法
            Console.WriteLine("-----------------2---------------");

            //2.实例化 不带返回值 带参数 的委托
            //MyDelegate2 f2 = new MyDelegate2(new AutoDelegateDemo().SayHello);/单方法执行
            MyDelegate2 f2 = null;
            f2 += new MyDelegate2(new AutoDelegateDemo().SayHello);
            f2 += new MyDelegate2(new AutoDelegateDemo().LileiSayHello);
            f2(student1.Name);

            Console.WriteLine("-----------------3---------------");
            //3.实例化 带返回值 带参数 的委托
            MyDelegate3 f3 = new AutoDelegateDemo().GetReturn;
            Console.WriteLine(f3());

            Console.WriteLine("-----------------4---------------");
            //4.实例化 带返回值 带参数 的委托
            MyDelegate4 f4 = new AutoDelegateDemo().SumStuAge;
            string result = f4(student1, student2);
            Console.WriteLine(student1.Name + "和" + student2.Name + "年龄和为:" + result);
          

            Console.WriteLine("-----------------原委托的调用end!---------------");
        }

        /// <summary>
        /// Action带参数委托的调用
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        private static void ActionDelegate(Student student1, Student student2)
        {
            Console.WriteLine("-----------------Action start!---------------");
            Console.WriteLine("1.string类型参数的Action[原类型:系统提供的类型]");
            ActionDemo.action(student1.Name);
            Console.WriteLine("\n");

            //----------------------------------------//
            Console.WriteLine("2.int类型参数的Action[原类型:系统提供的类型(显示的指定类型)]");
            ActionDemo.Test<int>(ActionDemo.Action, student1.Age);
            Console.WriteLine("\n");
            //----------------------------------------//
            Console.WriteLine("3.Student类型参数的Action [自定义类型]");
            ActionDemo.Test(ActionDemo.Action, student1);
            Console.WriteLine("\n");
            Console.WriteLine("4.[使用Lambda表达式定义委托]");
            //ActionDemo.Test<Student>(ActionDemo.Action, student2);//未重写
            ActionDemo.Test<Student>(p => { Console.WriteLine("{0}", "我是" + p.Name + "我的电话是:" + p.Tel); }, student2);//使用Lambda表达式定义委托
            Console.WriteLine("\n");

            //----------------------------------------//
            Console.WriteLine("5.委托方法可以使用lambda表达式重写");
            Console.Write("未重写委托方法:");
            ActionDemo.Test<string>(ActionDemo.Action, student1.Name);
            Console.Write("重写委托方法:");
            ActionDemo.Test<string>(obj => { Console.WriteLine("{0}", "我是" + obj); }, student1.Name);
           
            Console.WriteLine("-----------------Action end!---------------");
        }




    }
}
