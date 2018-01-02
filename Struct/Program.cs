struct MyStruct
{
    //Fields
    private int x, y;
    private AnotherClass myClass;
    private Days my Days;

    //Constructor
    public MyStruct(int a, int b, int c)
    {
        myClass = new AnotherClass();
        myClass.number = a;
        x = b;
        y = c;
        myDays = Days.Mon;
    }
}
