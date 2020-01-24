using System;

namespace Singletone
{
    internal class Singletone
    {
        static Singletone uniqueInstance;
        string singletoneData = string.Empty;
        protected Singletone()
        { }
        public static Singletone Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Singletone();
            return uniqueInstance;
        }

        internal void SingletonOperation()
        {
            singletoneData = "SingletoneData";
        }

        internal string GetSingletoneData()
        {
            return singletoneData;
        }
    }
}