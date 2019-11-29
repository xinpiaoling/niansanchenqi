using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{
    //链表的节点
    public  class DoubleLinked
    {
      public DoubleLinked Previous { get;private set; }
      public DoubleLinked Next { get;private set; }
      
        public int Length
        {
            get
            {
                
            }




        }

        public bool IsHead
        {
            get
            {
                return Previous == null;
            }
        }
        public bool IsTail
        {
            get
            {
                return Next == null;
            }
        }
        /// <summary>
        /// 根据当前节点向前向后找到指定VALUE的第一个链表节点
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DoubleLinked FindBy(int value)
        {
            //向上找一次
            //向下找一次

            return null;
        }
        /// <summary>
        /// 插入当前节点后面
        /// </summary>
        /// <param name="node"></param>
        public void InserAfter(DoubleLinked node)
        {
            
        }
        /// <summary>
        /// 插入当前节点前面
        /// </summary>
        /// <param name="node"></param>
        public void InserBefore(DoubleLinked node)
        {

        }
        /// <summary>
        /// 删除当前节点
        /// </summary>
        public void Delete()
        {

        }
        public void Swap(DoubleLinked a,DoubleLinked b)
        {

        }
    }
}
