using System;

//一种规范，用来约束所有子类的行为
abstract class TrafficTools
{
    //运输乘客（其中一个功能）
    public abstract void Transport();
}
class Bus : TrafficTools
{
    public override void Transport()
    {
    }
}
class Bike : TrafficTools
{
    public override void Transport()
    {
    }
}
