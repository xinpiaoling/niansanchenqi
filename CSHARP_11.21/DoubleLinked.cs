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
        public void Delete()
        {
            //old  删除old
            if (this.Next == null && this.Previous == null)
            {
                throw new Exception("只有一个无法删除。");
               //do nothing
            }
            else if (this.Previous == null)
            {
                //old 1 2 删除头部old
                this.Next.Previous = null;
                //this.Previous = null;
                //this.Next = null;
            }
            else if (this.Next == null)
            {
                //2 1 old 删除尾部old
                this.Previous.Next = null;
                //this.Next = null;
                //this.Previous = null;
            }
            else  //(node.Next != null && node.Previous != null)
            {
                //1  old  2
                this.Previous.Next = this.Next;
                this.Next.Previous = this.Previous;
                //this.Next = null;
                //this.Previous = null;
            }
            this.Previous = null;
            this.Next = null;
        }

        
        public void Swap(DoubleLinked another)
        {

            //只有两个值的时候  old  1 交换为  1   old
            //this.Next = null;
            //this.Previous = another;
            //another.Previous = null;
            //another.Next = this;

            //三个值的时候  2  3  4头部交换为3  2  4
            //doublelinked temp ;
            //temp = another.next;
            //another.next = this;
            //this.next = temp;
            //this.next.previous=this  ;
            //this.previous = another;
            //another.previous = null;



            ////5  6  7 尾部交换为 5  7  6
            //DoubleLinked temp;
            //temp = this.Previous;
            //this.Previous = another;
            //another.Previous = temp;
            //temp.Next = another;
            //another.Next = this;
            //this.Next = null;


            //8  9  10  11 中间交换为  8  10  9  11
            //DoubleLinked before;
            //DoubleLinked after;
            //before = this.Previous;
            //after = another.Next;

            //another.Next = this;
            //this.Next = after;
            //before.Next = another;
            ////after.Next = null;
            //this.Next.Previous=this;
            //another = this.Previous;
            //before = another.Previous;
            ////before.Previous = null;


            DoubleLinked temp;
            temp = another.Previous;
            this.Delete();
            another.Delete();
            another.InserBefore(temp);
            this.InserAfter(temp);
            temp.Delete();





        }
    }
}
