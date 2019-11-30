using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_11._21
{



    //链表的节点
    public class DoubleLinked 
    {
      public DoubleLinked Previous { get;private set; }
      public DoubleLinked Next { get;private set; }
      

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
            
            
            if (node.Next==null)
            {
                //current1.InserAfter(old);
                node.Next = this;         //this指代current1
                this.Previous = node;
            }
            else
            {
                //current2.InserAfter(old);

                this.Next = node.Next;
                node.Next = this;
                this.Next.Previous = this;
                this.Previous = node;

                //还可以重构代码，使用单元测试检测功能是否损坏
               
            }


        }
        /// <summary>
        /// 插入当前节点前面
        /// </summary>
        /// <param name="node"></param>
        public void InserBefore(DoubleLinked node)
        {

            if (node.Previous == null)
            {
                node.Previous = this;
                this.Next = node;
            }
            else
            {
                this.Previous = node.Previous;
                node.Previous = this;
                this.Next = node;
                this.Previous.Next = this;
            }



        }
        /// <summary>
        /// 删除当前节点
        /// </summary>
        public void Delete(DoubleLinked node)
        {
            //old  删除old
            if (node.Next == null && node.Previous == null)
            {
               //do nothing
            }


            else if (node.Previous == null)
            {
                //old 1 2  删除头部old
                this.Previous = null;
                node.Next = null;
            }
            else if (node.Next == null)
            {
                //2 1 old 删除尾部old
                this.Next = null;
                node.Previous = null;
            }
            else  //(node.Next != null && node.Previous != null)
            {
                //1  old  2
                this.Previous = null;
                this.Previous = node.Previous;

                node.Next = null;
                node.Previous.Next = this;
            }

        }

        
        public void Swap(DoubleLinked a,DoubleLinked b)
        {
            
            if (this.Previous==null)
            {
                //old 1 2头部交换为1 old 2
                //old.Swap(currenta, currentb);
                //之前的状态
                //a.Previous = this;
                //b.Previous = a;
                //this.Next = a;
                //a.Next = b;
                a.Next = this;
                this.Next = b;
                b.Previous = this;
                this.Previous = a;
            }
            else if (b.Next==null)
            {
                //1 old 2 尾部交换为 1 2 old
                //current1.Swap(current2, old);
                this.Next = a;
                a.Next = b;
                b.Previous = a;
                a.Previous = this;
            }
            else
            {
                //do nothing
            }

            

        }
    }
}
