namespace Service;

public class Service1
{
    [MethodInterceptor]
    public void Method1()
    {
        Console.WriteLine("Method1");
    }

    [MethodInterceptor]
    public void Method2() {
        Console.WriteLine("Method2");
    }


}
