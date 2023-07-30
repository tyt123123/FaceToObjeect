namespace FaceToObjeect
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
    private int age;
    private string name;
    EGender gender;
    private Person _person;
    //在声明和自己相同类型的成员时不可以初始化
    Person[] children;
    private Person[] family;
    Position position;
    Avotation rotation;

    public int Age
    {
      get => age;
      set => age = value;
    }

    public string Name
    {
      get => name;
      set => name = value;
    }

     EGender Gender
    {
      get => gender;
      set => gender = value;
    }

    public Person Person1
    {
      get => _person;
      set => _person = value;
    }

    public Person[] Children
    {
      get => children;
      set => children = value;
    }

    public Person[] Family
    {
      get => family;
      set => family = value;
    }

    Position Position
    {
      get => position;
      set => position = value;
    }

     Avotation Rotation
    {
      get => rotation;
      set => rotation = value;
    }


    public Person()
    {
    }
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