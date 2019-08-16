using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    /// <summary>
    /// 原型委托的定义
    /// </summary>
    public  class AutoDelegateDemo
    {
     
        /// <summary>
        /// 表示没有返回值 没有参数的委托
        /// </summary>
        public delegate void MyDelegate1();

        /// <summary>
        /// 表示没有返回值 有参数的委托
        /// </summary>
        /// <param name="name">参数</param>
        public delegate void MyDelegate2(string name);
       

        /// <summary>
        /// 表示有返回值 无参数的委托
        /// </summary>
        /// <returns>string</returns>
        public delegate string MyDelegate3();

        /// <summary>
        /// 表示有返回值 有参数的委托
        /// </summary>
        /// <param name="name">参数</param>
        /// <returns>string</returns>
        public delegate string MyDelegate4(Student stu1, Student stu2);

        //-----------------无参无返回值-----------------//
        public void SayHello()
        {
            Console.WriteLine("Hello,");
        }

        public void SayHellolilei()
        {
            Console.WriteLine("Hello,"+"李磊");
        }
        //-----------------无参无返回值-----------------//

        //-----------------有参无返回值-----------------//
        public void SayHello(string name)
        {
            Console.WriteLine("Hello," + name);
        }

        public void LileiSayHello(string name)
        {
            Console.WriteLine("李磊对 "+name+"说了Hello");
        }
        //-----------------有参无返回值-----------------//


        //-----------------无参数有返回值-----------------//
        public string GetReturn() => ("这是一个没有参数,有返回值的方法").ToString();
        //-----------------无参数有返回值-----------------//

        //-----------------有参数有返回值-----------------//
        public string SumStuAge(Student stu1, Student stu2) => (stu1.Age + stu2.Age).ToString();
        //-----------------有参数有返回值-----------------//




    }
}
