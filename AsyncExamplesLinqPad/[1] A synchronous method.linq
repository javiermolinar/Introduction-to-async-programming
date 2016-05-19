<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


void WaitForTwoSeconds()		// Synchronous BLOCKING method
{
	Thread.Sleep (2000);
}
	
void Main()
{
	"Waiting...".Dump();
	WaitForTwoSeconds();		// This method BLOCKS while it's working
	"Done!".Dump();
}