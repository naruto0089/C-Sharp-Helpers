using System;
using System.IO;

namespace CoreApp
{
	
	class Program
    {
        static void Main(string[] args)
        {
			GetFilesList objFileList = new GetFilesList(@"c:\");
			objFileList.GetSummary();
			objFileList.GetDetails();
			Console.ReadLine();
		}
    }
}
