using System.Linq;
using Reqnroll;

namespace TestingReqnroll;

[Binding]
public class testing
{
	[Given("something happens with this string {string}")]
	public void foo(System.Collections.Generic.List<(string name, int number)> input)
	{
		System.Console.WriteLine(input.Count);
	}


	[StepArgumentTransformation]
	public System.Collections.Generic.List<(string name, int number)> GetTupleList(string input)
	{
		return input
			.Split(',')
			.Select(s =>
			{
				var strings = s.Split(':');

				return (name: strings[0], number: System.Int32.Parse(strings[1]));
			})
			.ToList();
	}
}
