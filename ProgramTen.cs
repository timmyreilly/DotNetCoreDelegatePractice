using System;

class Base{};
class Derived : Base{}

delegate void MyDelegate(Base b); 
delegate void MyOtherDelegate(Derived d); 

class MainTen{
    static void TakeDerived(Derived d){}
    static void TakeBase(Base b){}

    static void MainA(){
        MyOtherDelegate d1 = TakeDerived; 
        MyOtherDelegate d2 = TakeBase;
        d2(new Derived()); 
    }
}


// Covariance work - the return types are covariant - 
delegate Base ReturnsBaseDelegate(); 
delegate Derived ReturnsDerivedDelegate(); 

class MainTen2{
    static Base ReturnsBase() { return null; }
    static Derived ReturnsDerived() { return null; } 


    static void Main()
    {
        ReturnsBaseDelegate b; 
        b = ReturnsBase; 
        b = ReturnsDerived; 

        ReturnsDerivedDelegate d; 
        // d = ReturnsBase; derived is a base, base is not 'derive' 
        d = ReturnsDerived; 
    }

}