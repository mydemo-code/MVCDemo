using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    /// <summary>
    /// 用来定义委托的类
    /// </summary>
   public class DelegateDemo
    {


        /// <summary>
        /// 定义一个无参委托 打招呼
        /// </summary>
        /// <param name="name">人名</param>
        public delegate void GreetingDelegateDefault();

        /// <summary>
        /// 定义一个有参委托 打招呼
        /// </summary>
        /// <param name="name">人名</param>
        public delegate void GreetingDelegate(string name);

        //public void GreetPeople(string name, GreetingDelegate MakeGreeting) => MakeGreeting(name);




    }
}
