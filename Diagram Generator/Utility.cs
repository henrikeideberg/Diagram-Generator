using System;
using System.Xml.Serialization;
using System.IO;

namespace Diagram_Generator
{
	public class Utility
	{
		public static int RoundDownToBase(int number)
		{
			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number - (number % mod);
				mod = mod * 10;
			}
			return number;
		}

		public static int RoundUpToBase(int number)
		{
			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number + (mod - (number % mod));
				mod = mod * 10;
			}
			return number;
		}

		public static float GetDelta(float nrOne, float nrTwo)
		{
			return Math.Abs(nrOne - nrTwo);
		}

		/// <summary>
		/// Method to write the given object to an XML file
		///  - Only writes and reads the Public properties and variables to / from the file.
		///  - Classes to be serialized must contain a public parameterless constructor.
		///  - The data saved to the file is human readable, so it can easily be edited outside of your application.
		///  - Use the [XmlIgnore] attribute to exclude a public property or variable from being written to the file.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj"></param>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public static bool Serialize<T>(T obj, string filePath)
		{
			bool bOk = false;
			TextWriter writer = null;
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				writer = new StreamWriter(filePath);
				serializer.Serialize(writer, obj);
				bOk = true;
			}
			finally
			{
				if (writer != null)

					writer.Close();
			}
			return bOk;
		}

		/// <summary>
		/// Method to read an object instance of a XML file.
		///  - Only writes and reads the Public properties and variables to / from the file.
		///  - Classes to be serialized must contain a public parameterless constructor.
		///  - The data saved to the file is human readable, so it can easily be edited outside of your application.
		///  - Use the [XmlIgnore] attribute to exclude a public property or variable from being written to the file.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj"></param>
		/// <param name="filePath"></param>
		/// <returns></returns>
		public static T DeSerialize<T>(string filePath)
		{
			TextReader reader = null;
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				reader = new StreamReader(filePath);
				return (T)serializer.Deserialize(reader);
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
		}
	}
}
