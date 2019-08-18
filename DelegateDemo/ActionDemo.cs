using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    /// <summary>
    /// 不带返回值的Action但可以有N个参数委托
    /// </summary>
    public static class ActionDemo
    {
        /// <summary>
        /// Action的使用
        /// 使用Action自带的委托 封装一个带有string类型的参数 无返回值的方法
        /// </summary>
        public static readonly Action<string> action = new AutoDelegateDemo().LileiSayHello;

       

        /// <summary>
        /// Action<T>的使用
        /// </summary>
        /// <typeparam name="T">自定义T的泛型</typeparam>
        /// <param name="action">委托名</param>
        /// <param name="t">委托的参数名</param>
        public static void Test<T>(Action<T> action, T t)
        {
            action(t);
        }

        public static void Action(Student s) => Console.WriteLine("我是"+ s.Name+"我今年"+s.Age+"岁了");

        public static void Action(string s) => Console.WriteLine(s);

        public static void Action(int s) => Console.WriteLine("我今年" + s + "岁了");


    } 
    
}
