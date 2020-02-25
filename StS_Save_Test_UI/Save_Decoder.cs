using System;
using System.Text;

namespace STS_Save
{
	public static class SaveDecoder
	{
		private const string MAGIC_WORD = "key";

		public static string Decode(string strJson)
		{
			if (IsPureJson(strJson))
			{
				return strJson;
			}

			try
			{
				var byteArrayJsonDecoded = Convert.FromBase64String(strJson);
				var formedByteArray = XorWithKey(byteArrayJsonDecoded);

				return GetStringFromBytes(formedByteArray);
			}
			catch (Exception)
			{
				return strJson;
			}
		}

		public static string Encode(string strJson)
		{
			if (!IsPureJson(strJson))
			{
				return strJson;
			}

			var byteArrayJson = GetBytesFromString(strJson);

			var formedByteArray = XorWithKey(byteArrayJson);

			return Convert.ToBase64String(formedByteArray);
		}

		private static bool IsPureJson(string strJson)
		{
			return strJson.Contains("{");
		}

		private static byte[] XorWithKey(byte[] jsonDecoded)
		{
			var keyWord = GetBytesFromString(MAGIC_WORD);

			var saida = new byte[jsonDecoded.Length];

			for (int i = 0; i < jsonDecoded.Length; i++)
			{
				saida[i] = (byte)(jsonDecoded[i] ^ keyWord[i % keyWord.Length]);
			}

			return saida;
		}

		//
		private static byte[] GetBytesFromString(string str)
		{
			return Encoding.Default.GetBytes(str.Replace(Environment.NewLine, "\n"));
		}

		private static string GetStringFromBytes(byte[] bytes)
		{
			return Encoding.Default.GetString(bytes).Replace("\n", Environment.NewLine);
		}
	}
}