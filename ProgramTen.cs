using System;

class Base{};
class Derived : Base{}

delegate void MyDelegate(Base b); 
delegate void MyOtherDelegate(Derived d); 

class MainTen{
    static void TakeDerived(Derived d){}
    static void TakeBase(Base b){}

    static void Main(){
        MyOtherDelegate d1 = TakeDerived; 
        MyOtherDelegate d2 = TakeBase;
        d2(new Derived()); 
    }
}