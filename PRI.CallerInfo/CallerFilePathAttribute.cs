﻿namespace System.Runtime.CompilerServices
{
	/// <summary>
	/// Allows you to obtain the full path of the source file that contains the caller. This is the file path at the time of compile.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter)]
	public class CallerFilePathAttribute : Attribute
	{
	}
}