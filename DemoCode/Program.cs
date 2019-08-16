using System;
using System.Collections.Generic;
using System.Linq;
using static DemoCode.DelegateDemo;

namespace DemoCode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> u = new List<Student>() {
               new  Student {  Name="aaa", Age=10, Sex="男", Tel="131456131", Nationality="中国" },
               new  Student {  Name="bbb", Age=28, Sex="女", Tel="45678613", Nationality="韩国" },
               new  Student {  Name="ccc", Age=27, Sex="男", Tel="131456131" , Nationality="日本"},
                new  Student {  Name="ddd", Age=18, Sex="男", Tel="131456131", Nationality="美国" }
            };

            //排序后的list表
            //DemoClass.SortStudent(u);
            /////-------------------------/////
            //问题的引入
            //如果打招呼的人有日本人,德国人,韩国人
            //则我们需要频繁的修改DelegateQuestion.Language的枚举
            //需要添加对应他国人打招呼的方法(fun)这步操作必须
            //面对以上修改频繁的修改枚举的操作,这里我们将用到委托
            //DelegateQuestion question = new DelegateQuestion();
            //question.GreetPeople(u[0].Name, DelegateQuestion.Language.Chinese);

            //实例委托
            //实例方式1:
            GreetingDelegate Greet1 = new GreetingDelegate(new DelegateQuestion().ChineseGreeting);
            Greet1(u[0].Name);
            //实例方式2:
            //GreetingDelegate Greet2 = new DelegateQuestion().EnglishGreeting;//委托推断
            //Greet2.Invoke(u[1].Name);

           // Greet1.Invoke();




        }


    }
}
