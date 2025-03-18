namespace Service;

public class Service1
{
    [MethodInterceptor]
    public void Method1()
    {
        throw new Exception("error") ;
        Console.WriteLine("Method1");
    }

    [MethodInterceptor]
    public void Method2() {
        Console.WriteLine("Method2");
    }


}
