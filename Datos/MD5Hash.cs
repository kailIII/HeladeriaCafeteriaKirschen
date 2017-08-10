using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Datos
{
	public static class MD5Hash
	{
		private static MD5 md5Hash = MD5.Create();

		public static string Get(string input)
		{
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder sBuilder = new StringBuilder();
			foreach (byte item in data)
				sBuilder.Append(item.ToString("x2"));
			return sBuilder.ToString();
		}

		public static bool Compare(string input, string hash)
		{
			string hashOfInput = Get(input);
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;
			return comparer.Compare(hashOfInput, hash) == 0;
		}
	}
}
