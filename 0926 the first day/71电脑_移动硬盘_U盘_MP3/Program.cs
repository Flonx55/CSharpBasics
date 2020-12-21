using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71电脑_移动硬盘_U盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现 将 移动硬盘或者U盘或者MP3插到电脑上，进行读写数据
            //MobileDisk md = new MobileDisk();
            //UDisk u = new UDisk();
            //MP3 mp3 = new MP3();
            //Computer cpu = new Computer();
            //cpu.CpuRead(u);
            //cpu.CpuWrite(u);
            //Console.ReadKey();

            //MobileStorage ms = new UDisk();
            //Computer cpu = new Computer();
            //cpu.CpuRead(ms);
            //cpu.CpuWrite(ms);
            //Console.ReadKey();

            MobileStorage ms = new MP3();
            Computer cpu = new Computer();
            cpu.Ms = ms; //把MP3给电脑的属性
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();  

        }


    }
    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();

    }
    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }
    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3自己可以播放音乐");
        }

    }

    public class Computer
    {
        private MobileStorage _ms;
        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        public void CpuRead()
        {
            Ms.Read(); 
        }
        public void CpuWrite()
        {
            Ms.Write();
        }
    }
}
