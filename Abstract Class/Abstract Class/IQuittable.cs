using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    //1.Create an interface called IQuittable and have it define a void method called Quit().
    public interface IQuittable
    {
        //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
        //Hint: an object can be of an interface type if it implements that specific interface.
        void Quit();
        
           
        
    }
}
