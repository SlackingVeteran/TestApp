using System;
using System.Linq;

namespace TestApp.Core.Lib
{
    public class CoreTestClass : MarshalByRefObject
    {
	    public string GetARandomString(int length)
	    {
		    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		    return new string(Enumerable.Repeat(chars, length)
			    .Select(s => s[new Random().Next(s.Length)]).ToArray());
	    }
    }
}
