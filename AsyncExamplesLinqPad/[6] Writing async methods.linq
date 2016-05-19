<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

/*We've changed 'void' to 'Task' and this allows us to await it
in the Main method. Notice that we don't create the Task ourselves. */

async void Main()
{
	string[] uris =
	{
		"http://www.google.es",
		"http://www.marca.com"		
	};
	
	await GetTotalLength (uris);   // Try deleting the 'await' keyword - notice the difference when run.	
	"Done!".Dump();	
}

async Task GetTotalLength (string[] uris)   // Notice that this now returns a Task.
{
	"Working...".Dump();
	int totalLength = 0;
	foreach (string uri in uris)
	{
		string html = await new WebClient().DownloadStringTaskAsync (new Uri (uri));
		totalLength += html.Length;
	}
	totalLength.Dump();
}