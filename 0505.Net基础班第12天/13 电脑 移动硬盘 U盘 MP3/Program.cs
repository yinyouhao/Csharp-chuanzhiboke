using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_电脑_移动硬盘_U盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态实现 将 移动硬盘或者U盘或者MP3插到电脑上进行读写数据
            //MobileDisk md = new MobileDisk();
            //UDisk u = new UDisk();
            //Mp3 mp3 = new Mp3();
            //Computer cpu = new Computer();
            //cpu.CpuRead(u);
            //cpu.CpuWrite(u);
            //Console.ReadKey();

            MobileStorage ms = new UDisk();
            Computer cpu = new Computer();
            cpu.Ms = ms;
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 抽象父类（移动存储设备）
    /// </summary>
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

    public class Mp3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("Mp3自己可以播放音乐");
        }
    }

    public  class Computer
    {

        private MobileStorage _ms;

        public MobileStorage Ms { get => _ms; set => _ms = value; }

        public void CpuRead()
        {
            Ms.Read();
        }
        public void CpuWrite()
        {
            Ms.Write();
        }

        //public void CpuRead(MobileStorage ms)//电脑类中拿到父类参数，传参
        //{
        //    ms.Read();
        //}
        //public void CpuWrite(MobileStorage ms)
        //{
        //    ms.Write();
        //}
    }
}
