using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Uilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
