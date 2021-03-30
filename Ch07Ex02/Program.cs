using System;
using static System.Console;

namespace Ch07Ex02
{
    class Program
    {
        
        
        
        
        
        
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };
        static void Main(string[] args)
        {
            foreach(string eType in eTypes)
            {
                try
                {
                    WriteLine("Main() try block reached.");
                    WriteLine($"ThrowException(\"{eType}\") called.");
                    ThrowException(eType);
                    WriteLine("Main() try block continues.");
                }
                catch(IndexOutOfRangeException e) when(eType == "filter")
                {
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine("Main() FILTERED IndexOutOfRangeException" +
                        $"catch block reached. Message:\n\"{e.Message}\"");
                    ResetColor();
                }
                catch(IndexOutOfRangeException e)
                {
                    WriteLine("Main() IndexOutOfRangeException catch" +
                        $"block reached. Message:\n\"{e.Message}\"");
                }
                catch
                {
                    WriteLine("Main() general catch block reached");
                }
                finally
                {
                    WriteLine("Main() finally block reached");
                }
                WriteLine();
            }
        }

        private static void ThrowException(string exceptionType)
        {
            WriteLine($"ThrowException(\"{exceptionType}\") reached");
            switch (exceptionType)
            {
                case "none":
                    WriteLine("Not throwing an exception.");
                    break;
                case "simple":
                    WriteLine("Throw System.Exception");
                    throw new System.Exception();
                case "index":
                    WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error"; // throw IndexOutOfRangeException
                    break;
                case "nested index":
                    try
                    {
                        WriteLine("ThrowException(\"nested index\") " +
                                            "try block reached.");
                        WriteLine("ThrowException(\"index\") called");
                        ThrowException("index");
                    }
                    catch
                    {
                        WriteLine("ThrowException(\"nested index\") general" +
                                            " catch block reached.");
                        throw;
                    }
                    finally
                    {
                        WriteLine("ThrowException(\"nested index\") finally"
                                            + " block reached.");
                    }
                    break;
                case "filter":
                    try
                    {
                        WriteLine("ThrowException(\"filter\") " +
                                        "try block reached.");
                        WriteLine("ThrowException(\"index\") called");
                        ThrowException("index");
                    }
                    catch
                    {
                        WriteLine("ThrowException(\"filter\") general"
                            + " catch block reached.");
                        throw;
                    }
                    break;
            }
        }
    }
}
