<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Net</Namespace>
</Query>


Task<string> task = new WebClient().DownloadStringTaskAsync (new Uri ("http://www.albahari.com/threading"));
string html = await task;
html.Dump();

// The await keyword turns everything that follows into a CONTINUATION.

// Because we're awaiting a Task<string>, our await expression evaluates to a string.
// If you await a plain (non-generic) Task, you get a void.

