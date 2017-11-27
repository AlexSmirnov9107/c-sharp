using System;
namespace Practice4
{
    public class MyClass
    {
        public string SayMyName(string name)
        {
            if (name == "")
            {
                throw new Exception("I dont know your name");
            }
            return name;

        }

    }
}