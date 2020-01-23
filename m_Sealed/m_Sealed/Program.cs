using System;

class Animal
{
    public virtual void Show()
    {


    }
}
class Dog : Animal
{
    public override sealed void Show()
    {
    }
}
class HaShiQi : Dog
{
    //public override void Show()
    //{

    //}
}