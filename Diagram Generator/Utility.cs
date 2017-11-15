using System;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Diagram_Generator
{
	public class Utility
	{
		public static int RoundDownToBase(int number)
		{
			int negative = 1;
			if (number < 0) negative = -1;
			number = number * negative;

			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number - (number % mod);
				mod = mod * 10;
			}
			return number * negative;
		}

		public static int RoundUpToBase(int number)
		{
			int negative = 1;
			if (number < 0) negative = -1;
			number = number * negative;

			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number + (mod - (number % mod));
				mod = mod * 10;
			}
			return number * negative;
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

		public static bool AskUserIfSaveAnimalManagerToFile()
		{
			bool userRespone = false;
			//Configure the messagebox
			string message = "Save the coordinates?";
			string caption = "Save?";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;

			// Displays the MessageBox.
			result = MessageBox.Show(Form.ActiveForm, message, caption, buttons);

			if (result == DialogResult.Yes)
			{
				userRespone = true;
				//If user wants to save the data - do it

			}
			return userRespone;
		}

		/// <summary>
		/// A method which controls that a given string is neither null nor empty 
		/// and should at least have one character other than a blank space (or escape sequences).
		/// </summary>
		/// <param name="stringToValidate"></param>
		/// <returns></returns>
		public static bool ValidateString(string stringToValidate)
		{
			//This will return
			// - false if string is null (i.e. no data in the variable) or empty (i.e. "")
			// - true otherwise
			int length = 1;
			return ValidateString(stringToValidate, length);
		}

		/// <summary>
		/// A method which controls that a given string is
		///  - neither null nor empty 
		///    should at least have one character other than a blank space (or escape sequences).
		///  - equal or greater than inputted length
		/// </summary>
		/// <param name="stringToValidate"></param>
		/// <param name="length"></param>
		/// <returns></returns>
		public static bool ValidateString(string stringToValidate, int length)
		{
			bool result = true;
			result = !string.IsNullOrEmpty(stringToValidate) && stringToValidate.Length >= length;
			return result;
		}

		/// <summary>
		/// Method to convert string to integer.
		/// </summary>
		/// <param name="input"></param>
		/// <param name="output"></param>
		public static bool ConvertStringToFloat(string input, out float output)
		{
			bool result = false;
			output = 0;
			try
			{
				output = Convert.ToSingle(input);
				result = true;
			}
			catch (FormatException)
			{
				//Raise error if failure. The resulting output will be 0.
				string error = String.Format("Unable to convert {0} to float", input);
				MessageBox.Show(error);
			}
			return result;
		}
	}
}
