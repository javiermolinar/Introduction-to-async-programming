<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

/* The compiler demands that any method that uses the await keyword must be annotated
with the 'async' keyword.*/

async void Main()
{
	"Working...".Dump();
	string[] uris =
	{
		"http://www.google.es",
		"http://www.marca.com"		
	};
	int totalLength = 0;
	foreach (string uri in uris)
	{
		string html = await new WebClient().DownloadStringTaskAsync (new Uri (uri));
		totalLength += html.Length;
	}
	totalLength.Dump();
}