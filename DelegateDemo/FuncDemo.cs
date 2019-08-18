using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    /// <summary>
    /// 带返回值但可以有0-16个类型的委托
    /// </summary>
    public static class FuncDemo
    {
        /// <summary>
        /// Func的使用
        /// 使用Func自带的委托 封装一个带有2个参数 有一个string类型的回值的方法
        /// </summary>
        //public static Func<int,int,string> func = (a,b) => (a + b).ToString();//极简写法

        public static Func<int, int, string> func = Add;
        public static string Add(int a, int b) => (a + b).ToString();

        //匿名函数  求差的匿名函数
        public static Func<int, int, int> f2 = delegate (int t1, int t2)
        {
            int u = t1 - t2;
            return u;

        };

        public static Func<int, int, int> f3 = (t3, t4) => t3 - t4;//极简写法



        /// <summary>
        ///  Func有返回值的泛型委托
        /// </summary>
        /// <typeparam name="T1">隶属1</typeparam>
        /// <typeparam name="T2">隶属2</typeparam>
        /// <param name="func">Func委托函数</param>
        /// <param name="a">参数1</param>
        /// <param name="b">参数2</param>
        /// <returns>object</returns>
        public static object Test<T1, T2>(Func<T1, T2, object> func, T1 a, T2 b) => func(a, b);

        /// <summary>
        /// 计算两个学生的年龄的和
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>object</returns>
        public static object Func(Student s1, Student s2) => s1.Age + s2.Age;

        /// <summary>
        /// 计算两个数的乘积
        /// </summary>
        /// <param name="a">第一个数</param>
        /// <param name="b">第二个数</param>
        /// <returns>object</returns>
        public static object Func(int a, int b) => (a * b);



       

    }
}
