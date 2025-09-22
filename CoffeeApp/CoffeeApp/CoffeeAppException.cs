using System;

namespace CoffeeApp
{
    public class CoffeeAppException : Exception
    {
        public CoffeeAppException(string msg): base(msg)
        {

        }
    }
}
