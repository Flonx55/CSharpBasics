using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04认识各个硬件部件
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            主存储器：
            存储体 MAR MDR
            MAR（存储地址寄存器）
            MDR（存储数据寄存器）
            寄存器：存放二进制数据
            存储体：数据在存储体内按地址存储
            每个地址对应一个存储单元
            存储单元：每个存储单元存放一串二进制代码
            存储字（word）：每个存储单元中二进制代码的组合
            存储字长：每个存储单元中可以存放的二进制代码的位数
            存储元：即存储二进制的电子元件，每个存储元可存1bit--电容

            MAR=4位-->总共有2^4个存储单元
            MDR=16位-->每个存储单元可存放16bit,一个字(word)=16bit
            易混淆:1个字节(Byte) = 8bit
                   1B = 一个字节
                   1b = 一个bits
            

            运算器的组成
            运算器：用于实现算术运算（加减乘除）、逻辑运算（与或非）

                ACC：累加器，用于存放操作数，或者运算结果
                MQ：乘商寄存器，在乘除运算时，用于存放操作数或运算结果 存放乘数
                X：通用的操作数寄存器，用于存放操作数 存放被乘数
                ALU:算数逻辑单元，通过内部复杂的电路实现算数运算、逻辑运算

            控制器的组成
                CU：控制单元，分析指令，给出控制信号（control unit）
                IR：指令寄存器，存放当前执行的指令（instruction register）
                PC：程序计数器，存放下一条指令地址，有自动加1的功能（program counter）

            完成一条指令：
                    1）取指令 PC(1-4)
                    2）分析指令 IR(5)
                    3）执行指令：CU(6-9)

            计算机的工作过程

            指令和变量的数据都是存储在存储体当中的
                第一个指令存储在主存地址的零号位,所以在程序运行之前pc会指向零号位,需要把这条指令取出来执行
            pc存放的内容需要通过地址总线传递到存储地址寄存器MAR中,pc指向零,使得MAR的值为0,也就是控制器向主存储器
            指明了我接下来要访问的是零号位地址所对应的这一串数据同时控制器会通过控制总线告诉主存储器我这次要进行
            的是读操作.主存储器会根据MAR里面记录的地址信息去存储体里面找出零号地址所对应的二进制数据,并且把这些
            二进制数据放到MDR,也就是数据寄存器当中,这就导致了MDR这一寄存器中里面存放的就是我们想要的读取的第一条指令
            (MAR)---MAR里面的内容
            M-------Memory 主存储器
                
                从MDR中取走的货物即指令,这条指令会通过数据总线把它放到IR,也就是指令寄存器当中,导致控制器IR里面已经存放了此次要执行的
            指令,接下来这个指令的前六位bit,也就是操作码会被送到CU控制单元里边,然后CU会分析这个操作码,他就会知道00001对应的是一条
            取数的指令,所以接下来要把这个地址码所指明的内存单元里的这个数据把他给取出来并且放到ACC这个寄存器当中,这是取数指令要做的
            事情
                既然要读取主存的这个位置的信息,就需要把这些地址码放到主存的MAR当中,这就导致此时MAR=5,那五号存储单元所指向的刚好就是
            a这个变量他所存放的位置,接下来主存储器会根据MAR指明的地址去存储器当中找出五号单元的数据,并且把五号单元的数据放到MDR当中
            也就是把a这个变量的值放到了MDR里面,a=2;最后再控制单元的指挥下,MDR里面的数据会被传送到ACC寄存器当中 

                在取指令这一过程完成后,PC的值就会自动加1

                

                初：（pc=0），指向第一条指令的存储地址
                1）（pc)-->MAR,导致（MAR） = 0
                3）M（MAR）-->MDR,导致(MDR)=000001 0000000101//主存储器里面MAR这个地址所指明的存储单元里边的数据放到MDR
                    这个寄存器当中
                4)(MDR)-->IR,导致(IR)=000001 0000000101
                5)op(IR)-->CU,指令的操作码送到CU,CU分析后得知,这是"取数"指令
                6)Ad(IR)-->MAR,指令的地址码送到MAR,导致(MAR)=5
                8)M(MAR)-->MDR,导致(MDER)=0000000000000010=2
                9)(MDR)-->ACC,导致(ACC)=0000000000000010=2
            */

            //double f = 3.14;
            //while (true)
            //{
            //    Console.WriteLine("请输入4个数 b kn c km d tn e tm");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    double c = Convert.ToDouble(Console.ReadLine());
            //    double d = Convert.ToDouble(Console.ReadLine());
            //    double e = Convert.ToDouble(Console.ReadLine());
            //    double fenzi = 2 * f * (b * e - c * d);//b kn c km d tn e tm
            //    double fenmu = (d * d * e - e * e * d);
            //    double a = fenzi / fenmu;
            //    Console.WriteLine("角加速度是：{0} ", a);

            }


        }
    }
}
