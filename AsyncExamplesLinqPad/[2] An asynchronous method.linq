<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void WaitForTwoSecondsAsync (Action callback)		// Asynchronous NON-BLOCKING method 
{
	new Timer (_ => callback()).Change (4000, -1);
}

void Main()
{
	"Waiting...".Dump();
	WaitForTwoSecondsAsync (() => "Done".Dump());
	"Finishing...".Dump();
}