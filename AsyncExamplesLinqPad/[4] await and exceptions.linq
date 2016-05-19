<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

// If the task completes with an exception, the exception gets re-thrown onto whoever awaits it.


string html = await (new WebClient().DownloadStringTaskAsync (new Uri ("http://albahari.com/InvalidUrl")));
html.Dump();
