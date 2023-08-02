namespace IndexMechanical
{
    #region 索引器概念

    //让对象像数组一样通过索引访问其中元素
    //索引器可以重载，结构体里也支持索引器

    #endregion

    class Preson
    {
        private int _age;
        private int _height;
        private Preson[] _friends;

        public Preson this[int index]
        {
            get
            {
                if (_friends == null)
                {
                    return null;
                }else if (_friends.Length - 1 < index)
                {
                    return null;
                }
                
                return _friends[index];
            }
            set
            {
                _friends[index] = value;
            }
        }
        //索引器，getset和属性一样
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Preson preson = new Preson();
            preson[0] = new Preson();
            //索引器的使用
        }
    }
}