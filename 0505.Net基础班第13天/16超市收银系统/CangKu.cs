using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{
    class CangKu
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("仓库有："+item[0].ID+","+"\t"+"有"+item[0].Count+"个,"+"\t"+"每个"+item[0].Price+"元，");
            }
        }
        //这种存储方式方便分类，list中的每个元素又是一个集合 
        //list[0]存储Acer电脑
        //list[1]存储三星手机
        //list[2]存储酱油
        //list[3]存储香蕉
        /// <summary>
        /// 在创建仓库对象的时候 向仓库中添加货架
        /// </summary>
        public CangKu()//构造函数
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public  void JinPros(string strType,int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏碁笔记本"));
                        break;
                    case "SamSung": list[1].Add(new SamSung(Guid.NewGuid().ToString(), 1500, "三星手机"));
                        break;
                    case "JiangYou":list[2].Add(new Banana(Guid.NewGuid().ToString(), 15, "酱油"));
                        break;
                    case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), 10, "香蕉"));
                        break;


                }
            }
        }

        /// <summary>
        /// 从仓库中提取货物
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] QuPros(string strType,int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for(int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer" :pros[i]=list[0][0];//list[0]拿到的是放宏碁笔记本的货架，list[0][0]拿到的是货架上的第一个笔记本
                        list[0].RemoveAt(0);//取完货后将其删除
                        break;
                    case "SamSung":pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;

                }
            }
            return pros;
        }


        //存储货物
        //List<SamSung> listSam = new List<SamSung>();
        //List<Acer> listAcer = new List<Acer>();
        //List<JiangYou> listJiangYou = new List<JiangYou>();
        //List<Banana> listBanana = new List<Banana>();

    }
}
