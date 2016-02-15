public class Base
{
    public Base()
    {
    Consile.WriteLine("Base ctor")!
    }


    public virtual void Method()
    {
      Console.WriteLine("Base method");
    }

}


public class Child : Base
{
    public Child()
    {
      Console.WriteLine("Child ctor")!
    }


    public void Method()
    {
      Console.WriteLine("Child method");
    }
}


public class Programm
{
  public static void Main()
  {
  Base b1 = new Base();
  Base b2 = new Child();
  Child b3 = new Child();
  Child b4 = new Base();

  b1.Method();
  b2.Method();
  b3.Method();
  b4.Method();

  var b5 = new Base();
  b5.Method();

  dynamic b6 = new Child();
  b6.Method();
  }

}
