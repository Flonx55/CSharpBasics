using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Events1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                ●初步了解事件
                    定义:Event, a thing that happpens,especially something important
                            能够发生的什么事情,事件发生的效果才是事件的功能
                    角色:使对象或类具备通知能力的成员,让别人得到通知
                        ●An event is a member that enables an object or class to provide notifications
                   功能:通知+可选的事件参数(详细信息)
                   使用:用于对象或类间的动作协调与信息传递(消息推送)
                   原理:事件模型(event model)
                        ●发生-->响应中的五个部分:闹钟响了你起床,孩子饿了你做饭-------隐含订阅关系
                        ●发生-->相应的五个动作:1)我有一个事件2)一个人或者一群人关心我的这个事件3)我的这个事件发生4)关心这个事件的人会被依次通知到
                            5)被通知的人根据拿到的事件信息(又称"事件数据","事件参数","通知")对事件进行响应(又称处理事件)
                   提示:
                        ●事件多用于桌面,手机等开发的客户端编程,因为这些程序经常是用户通过事件来"驱动"的
                        ●各种编程语言对这个机制的实现方法不尽相同
                        ●java语言里没有事件这种成员,也没有委托这种数据类型.
                        ●MVC,MVP,MVVM等模式,是事件模式更高级,更有效的"玩法"
                        ●日常开发的时候,使用已有事件的机会比较多,自己声明事件的机会比较少,所以先学使用
                   
                ●事件的应用
                    ●实例演示
                        ●派生与拓展
                    ●事件模型的五个组成成分
                        ●事件的拥有者(event source,对象)
                        ●事件成员(event,成员)
                        ●事件的响应者(event subscriber,对象)
                        ●事件处理器(event handler,成员)    本质上是一个回调方法
                        ●事件订阅------把事件处理器与事件关联在一起,本质上是一种以委托类型为基础的约定
                            ●事件的拥有者是事件的响应者的字段成员
                    ●注意:
                        ●事件处理器是方法成员
                        ●挂接事件处理器的时候,可以使用委托实例,也可以直接使用方法名
                ●深入理解事件
                ●事件的声明
                ●问题辨析
            */



        }
    }
}
