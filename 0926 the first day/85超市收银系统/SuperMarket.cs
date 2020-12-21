﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85超市收银系统
{
    class SuperMarket
    {
        //创建仓库对象
        CangKu ck = new CangKu();
        /// <summary>
        /// 创建仓库对象的时候，给仓库的货架上导入货物
        /// </summary>
        public SuperMarket ()
        {
            ck.JinPros("Acer",1000);
            ck.JinPros("Samsung",1000);
            ck.JinPros("JiangYou",1000);
            ck.JinPros("Banana",1000);
        }

        /// <summary>
        /// 跟用户交互的过程
        /// </summary>
        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要些什么？");
            Console.WriteLine("我们有Acer,Samsung,JiangYou,Banana");
            string StrType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库去货物
            ProductFather[] pros = ck.QuPros(StrType , count);
            //下面该计算价钱了
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元",realMoney );
            Console.WriteLine("请选择你的打折方式1---不打折 2---打九折 3---打85折 4---买300送50 5---买500送100");
            string input = Console.ReadLine();
            //通过简单工厂的设计模式根据用户的舒服获得一个打折对象
            CalFather cal = GetCal(input);
            double totalMoney= cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完针后,您应付{0}元",totalMoney );
            
        }

        /// <summary>
        /// 根据用户的选择打折的方式返回一个打折对象
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>返回的父类对象 但是里面装的是子类对象</returns>
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch(input)
            {
                case "1":cal = new CalNormal();
                    break;
                case "2":cal = new CalRate(0.9);
                    break;
                case "3":cal = new CalRate(0.85);
                    break;
                case "4":cal = new CalMN(300, 50);
                    break;
                case "5":cal = new CalMN(500, 100);
                    break;
                    
            }
            return cal;
        }
        /// <summary>
        /// 根据用户买的货物计算总价钱
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length ; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }


        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
