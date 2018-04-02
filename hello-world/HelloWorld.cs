using System;

public class HelloWorld
{
    public static String Hello(String input)
    {
        String s = input == null ? "World" : input;
        return String.Format("Hello, {0}!", s);
    }
}