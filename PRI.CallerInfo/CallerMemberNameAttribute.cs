﻿namespace System.Runtime.CompilerServices
{
	/// <summary>
	/// Allows you to obtain the method or property name of the caller to the method.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class CallerMemberNameAttribute : Attribute
	{
	}
}