namespace FaceToObject
{
  enum EGender
  {
    Male,
    Female
  }

  struct Position
  {
    
  }

  class  Avotation
  {
    
  }
   public class Person
  {
    /*int Age { get; set; }
    string Name { get; set; }*/
    private int _age;
    private string _name;
    EGender _gender;
    private Person _person;
    //在声明和自己相同类型的成员时不可以初始化
    Person[] _children;
    private Person[] _family;
    Position _position;
    Avotation _rotation;
    private int _cont;

    public int Cont
    {
      get => _cont;
      set => _cont = value;
    }

    public int Age
    {
      get => _age;
      set => _age = value;
      
    }

    public string Name
    {
      get => _name;
      set => _name = value;
    }

     EGender Gender
    {
      get => _gender;
      set => _gender = value;
    }

    public Person Person1
    {
      get => _person;
      set => _person = value;
    }

    public Person[] Children
    {
      get => _children;
      set => _children = value;
    }

    public Person[] Family
    {
      get => _family;
      set => _family = value;
    }

    Position Position
    {
      get => _position;
      set => _position = value;
    }

     Avotation Rotation
    {
      get => _rotation;
      set => _rotation = value;
    }
     //属性只能有get,set 但时在两个访问器里可以写逻辑，属性用于保护成员变量，加密
     //访问器可以加访问修饰符，默认与属性权限相同，且不能超过属性，不能两个都写修饰符
     //只读属性设置，一般设置为只有get。
     //自动属性，外部能得不能改，只有get set ,没有其他逻辑（不做特殊处理—）与{}

    public Person()
    {
    }
    //结构体不允许无参构造，类可以
    public Person(int _age):this()
    {
      this._age = _age;
    }
    //后面加this，先调用无参，后调用有参，若this里有参数（对应前面的参数列表），则先执行对应this参数列表的额构造函数
    //this里面也可以写常量
  }
  internal class Program
  {
    // 一般来说，类声明在命名空间里
    public static void Main(string[] args)
    {
      Person person = new Person();
      person.Name="John  Smith";
    }
    
  }
}