

namespace CSHARP_11._21
{
    /// <summary>
    /// 单例模式
    /// 懒汉lazy:不调用就不new object...此方法仅适用于单线程
    /// </summary>
    class Singles
    {
        private static  Singles uniqueInstance;
        private Singles()
        {

        }

        public static Singles SetInstance()
        {
            if (uniqueInstance==null)
            {
                uniqueInstance = new Singles();
            }
            return uniqueInstance;
        }
    }
}
