using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_练习
{
    public class Ticket //类
    {
        //写一个Ticket类，有一个距离属性（本属性只读，在构造函数中赋值）不能为负数，
        //有一个价格属性，价格属性只读
        //并且根据距离distance计算价格Price（1元/公里）
        //0-100公里 票价不打折
        //101-200公里 总额打9.5折
        //201-300公里 总额打9折
        //300公里以上 总额打8折
        double _distance;//字段
        public double Distance//属性
        {
            get { return _distance; }
        }
        public Ticket(double distance)//构造函数，来使用属性，进而使用字段完成一些任务
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        double _price;
        public double Price
        {
            get
            {
                if (_distance > 0 && _distance <= 100)
                {
                    _price = _distance;
                }
                else if (_distance > 100 && _distance <= 200)
                {
                    _price = _distance * 0.95;
                }
                else if (_distance > 200 && _distance <= 300)
                {
                    _price = _distance * 0.9;
                }
                else//到这一步就不用判断条件了，到这一步的时候，信息已经被前面的过滤掉
                {
                    _price = _distance * 0.8;
                }
                return _price; }
        }
        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要{1}元", Distance, Price);
        }
    }
}
