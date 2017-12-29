using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoreApp
{
	public class GetFilesList
	{
		public static string _path { get; set; }
		public static string _pattern { get; set; }

		private string[] fpaths;

		public GetFilesList()
		{
			_path = ".";
			_pattern = "*";
			fpaths = Directory.GetFiles(_path, _pattern);
		}
		public GetFilesList(string path)
		{
			_path = path;
			_pattern = "*";
			fpaths = Directory.GetFiles(_path, _pattern);
		}

		public GetFilesList(string path, string pattern)
		{
			_path = path;
			_pattern = pattern;
			fpaths = Directory.GetFiles(_path, _pattern);
		}

		public void GetDetails()
		{
			foreach (var val in fpaths)
			{
				FileInfo finfo = new FileInfo(val);
				Console.WriteLine("File Name: {0} ", finfo.Name);
				Console.WriteLine("Extension: {0}", finfo.Extension);
				Console.WriteLine("Length: {0}", finfo.Length);
				Console.WriteLine("Creation Time: {0}", finfo.CreationTime);
				Console.WriteLine("Last Accessed Time: {0}", finfo.LastAccessTime);
				Console.WriteLine("Last Modification Date: {0}", finfo.LastWriteTime);
				Console.WriteLine("**************************");
			}
		}

		public void GetSummary()
		{
			Console.WriteLine("Path: {0}", _path);
			Console.WriteLine("Total number of files: {0}", fpaths.Length);
			Console.WriteLine("List of files: ");
			foreach (var val in fpaths)
			{
				FileInfo finfo = new FileInfo(val);

				Console.WriteLine(" -->File Name: {0} ", finfo.Name);

			}

		}



	}

}
