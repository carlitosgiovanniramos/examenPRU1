namespace SOLID.Domain.Exceptions;

using System;

public class BusinessRuleException : Exception
{
    public BusinessRuleException(string message) : base(message)
    {
    }

}
