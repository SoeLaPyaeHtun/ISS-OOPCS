using System;
namespace Triangle_Exception
{
    public class BadTriangleException : Exception
    {

       public BadTriangleException(string message): base(message) { }
    }
}

