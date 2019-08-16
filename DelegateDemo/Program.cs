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
            Student student1 = new Student { Name="韩梅梅", Age=18, Sex="女", Tel="132164", Nationality="中国" };
            Student student2 = new Student { Name = "赵日天", Age = 28, Sex = "男", Tel = "4561464123", Nationality = "美国" };
            Console.WriteLine("-----------------1---------------");
            //1.实例化 不带返回值 不带参数 的委托
            //MyDelegate1 my = new AutoDelegateDemo().SayHello;//单方法执行
            MyDelegate1 my=null; //可执行多个方法
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
            Console.WriteLine(student1.Name + "和" + student2.Name +"年龄和为:"+ result);
            Console.WriteLine("\n");
        }
    }
}
