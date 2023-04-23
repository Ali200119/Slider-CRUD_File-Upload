using System;
namespace Fiorello.Helpers
{
	public static class FileHelper
	{
		public static bool CheckFileType(this IFormFile file, string pattern)
		{
			return file.ContentType.Contains(pattern);
		}

		public static void DeleteFileFromPath(string path)
		{
			if (File.Exists(path)) File.Delete(path);
		}
	}
}