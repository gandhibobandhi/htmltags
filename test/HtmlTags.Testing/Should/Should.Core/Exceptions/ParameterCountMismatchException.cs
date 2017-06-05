using System;
using System.Reflection;
using System.Runtime.Serialization;
using Xunit.Abstractions;

namespace Should.Core.Exceptions
{
    /// <summary>
    /// Exception to be thrown from <see cref="MethodInfo"/> invoke when the number of
    /// parameter values does not the test method signature.
    /// </summary>
    public class ParamterCountMismatchException : Exception
    {
    }
}