using System;

namespace TmbAnalyst.Services.Utilities.Exceptions;

public class ServerIsTeapotException : Exception
{
    public ServerIsTeapotException():base("I'm a teapot")
    {   
    }
}