using System.IO;
using Patterns.ServiceLocator.Contracts;

namespace Patterns.ServiceLocator.Implementation
{
	public class LoggingClass : ILog
	{
		private StreamWriter logFile;

		public void Log(string txt)
		{
			InternalLog(txt);
		}

		public void LogFormat(string txt, params object[] p)
		{
			var msg = string.Format(txt, p);
			InternalLog(msg);
		}

		private void InternalLog(string txt)
		{
			if (logFile == null) logFile = new StreamWriter("actions.log");
			logFile.WriteLine(txt);
			logFile.Flush();
		}
	}
}