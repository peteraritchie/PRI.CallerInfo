// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
namespace System.Runtime.CompilerServices
{
	/// <summary>
	/// Allows you to obtain the line number in the source file at which the method is called.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter)]
	public class CallerLineNumberAttribute : Attribute
	{
	}
}
