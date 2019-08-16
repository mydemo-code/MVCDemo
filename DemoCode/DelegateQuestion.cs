using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    /// <summary>
    /// 问题的引入
    /// </summary>
    public class DelegateQuestion
    {

        public void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }

        public void EnglishGreeting(string name)
        {
            Console.WriteLine("Good Morning, " + name);
        }

        /// <summary>
        /// 申明一个枚举类型
        /// </summary>
        public enum Language
        {
            English, Chinese
        }
        /// <summary>
        /// 通过枚举类型去调用对应的fun
        /// </summary>
        /// <param name="name">人名</param>
        /// <param name="lang">语言</param>
        public void GreetPeople(string name, Language lang)
        {
            switch (lang)
            {
                case Language.English:
                    EnglishGreeting(name);
                    break;
                case Language.Chinese:
                    ChineseGreeting(name);
                    break;
            }
        }

    }
}
