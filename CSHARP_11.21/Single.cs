

namespace CSHARP_11._21
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Single
    {
        private static  Single uniqueInstance;
        private Single()
        {

        }

        public static Single SetInstance()
        {
            if (uniqueInstance==null)
            {
                uniqueInstance = new Single();
            }
            return uniqueInstance;
        }
    }
}
