// CS4010: Cannot convert async anonymous method to delegate type `System.Func<string>'
// Line: 10
// Compiler options: -langversion:future

using System;

class C
{
	public static void Main ()
	{
		Func<string> a = async delegate { };
	}
}
