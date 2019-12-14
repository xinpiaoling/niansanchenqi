using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTreeStruct<char> tree = new BinaryTreeStruct<char>(10);
            //char[] item = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            ////添加树的数据
            //tree.add(item);
            //Console.WriteLine("前序遍历");
            ////tree.firstTraversal();
            //Console.WriteLine("中序遍历");
            ////tree.middleTravesal();
            //Console.WriteLine("后序遍历");
            //tree.lastTravesal();
            //Console.WriteLine("层次遍历");
            //tree.layerTravesal();

            ExtensionLearn.extension(new Learn());
            



        }
    }
    //public class BinaryTreeStruct<T>    //二叉树  顺序排列
    //{
    //    internal  T[] data;
    //    private int count=0;
    //    /// <summary>
    //    /// 当前二叉树的容量
    //    /// </summary>
    //    /// <param name="capacity"></param>
    //    public BinaryTreeStruct(int capacity)
    //    {
    //        data = new T[capacity];
    //        count = capacity;
    //    }
    //    //顺序添加元素
    //    public void add(T[] item)
    //    {
    //        for (int i = 0; i < item.Length; i++)
    //        {
    //            data[i] = item[i];
    //            //Console.WriteLine(data[i]);
    //        }
           
    //    }
    //    /// <summary>
    //    /// 前序遍历
    //    /// </summary>
    //    public void firstTraversal()
    //    {
    //        firstTraversal(0);
    //    }
    //    public void firstTraversal(int index)
    //    {
    //        if (index>=count || data[index].Equals(-1))
    //        {
    //            return;
    //        }
    //        int number = index + 1;                                             
               
    //        int LeftNumber = number * 2;    
    //        int RightNumber = number * 2 + 1;  
    //        Console.WriteLine(data[index] + "前序");
    //        firstTraversal(LeftNumber-1);    
    //        firstTraversal(RightNumber-1);
    //    }

    //    /// <summary>
    //    /// 中序遍历
    //    /// </summary>
    //    public void middleTravesal()
    //    {
    //        middleTravesal(0);
    //    }
    //    public void middleTravesal(int index)
    //    {
    //        if (index>=count || data[index].Equals(-1))
    //        {
    //            return;
    //        }
    //        int number = index + 1;
    //        int leftNumber = number * 2 ;
    //        int rightNumber = number * 2 + 1;
    //        middleTravesal(leftNumber - 1);
    //        Console.WriteLine(data[index]+"中序");
    //        middleTravesal(rightNumber-1);
    //    }
    //    /// <summary>
    //    /// 后序遍历
    //    /// </summary>
    //    public void lastTravesal()
    //    {
    //        lastTravesal(0);
    //    }
    //    public void lastTravesal(int index)
    //    {
    //        if (index>=count || data[index].Equals(-1))
    //        {
    //            return;
    //        }
    //        int number = index + 1;
    //        int leftNumber = number * 2;
    //        int rightNumber = number * 2 + 1;
    //        lastTravesal(leftNumber - 1);
    //        lastTravesal(rightNumber-1);
    //        Console.WriteLine(data[index]+"后序");

    //    }
    //    /// <summary>
    //    ///层次遍历
    //    /// </summary>
    //    public void layerTravesal()
    //    {
    //        for (int i = 0; i < count; i++)
    //        {
    //            Console.WriteLine( data[i]+"" );
    //        }
    //    }
    //}
}
