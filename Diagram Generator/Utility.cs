using System;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Diagram_Generator
{
	public class Utility
	{
		/// <summary>
		/// Method to round down to 'base'. e.g.
		///  - 544 will be rounded down to 500.
		///  - 13 will be rounded down to 10.
		///  Values smaller than 10 will be untouched.
		///  Method does not evaluate negative numbers.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static int RoundDownToBase(int number)
		{
			//If negative - make positive
			//If positive - keep positive
			int negative = 1;
			if (number < 0) negative = -1;
			number = number * negative;

			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number - (number % mod);
				mod = mod * 10;
			}
			//return rounded down number with original sign (+/-)
			return number * negative;
		}

		/// <summary>
		/// Method to round up to 'base'. e.g.
		///  - 544 will be rounded up to 600.
		///  - 13 will be rounded up to 20.
		///  Values smaller than 10 will be untouched.
		///  Method does not evaluate negative numbers.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static int RoundUpToBase(int number)
		{
			//If negative - make positive
			//If positive - keep positive
			int negative = 1;
			if (number < 0) negative = -1;
			number = number * negative;

			int mod = 10;
			while ((number % mod != number) && (number % mod != 0))
			{
				number = number + (mod - (number % mod));
				mod = mod * 10;
			}
			//return rounded up number with original sign (+/-)
			return number * negative;
		}

		/// <summary>
		/// Get delta between two numbers,
		/// </summary>
		/// <param name="nrOne"></param>
		/// <param name="nrTwo"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Method to ask user a Yes/No question.
		/// Return the response (true for Yes and false for No).
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <returns></returns>
		public static bool AskUserYesNo(string message, string caption)
		{
			bool userRespone = false;
			//Configure the messagebox
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;

			// Displays the MessageBox.
			result = MessageBox.Show(Form.ActiveForm, message, caption, buttons);

			if (result == DialogResult.Yes)
			{
				userRespone = true;
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

		/// <summary>
		/// Method to convert string to integer.
		/// </summary>
		/// <param name="input"></param>
		/// <param name="output"></param>
		public static bool ConvertStringToInteger(string input, out int output)
		{
			bool result = false;
			output = 0;
			try
			{
				output = Convert.ToInt32(input);
				result = true;
			}
			catch (FormatException)
			{
				//Raise error if failure. The resulting output will be 0.
				string error = String.Format("Unable to convert {0} to integer", input);
				MessageBox.Show(error);
			}
			return result;
		}

		// <summary>
		/// Method which configures and displays a messagebox to indicate succesful registration
		/// </summary>
		public static void DisplaySuccesfulMsgBox(string messageBoxText)
		{
			//Configure the message box
			string caption = "Diagram Generator";          //Sets the heading of the msgbox
			MessageBoxButtons button = MessageBoxButtons.OK; //configures the button(s) of the msgbox
			MessageBoxIcon icon = MessageBoxIcon.Information;//configures the icon to be displayed

			//Display the messagebox
			MessageBox.Show(messageBoxText, caption, button, icon);
		}

		/// <summary>
		/// Method which configures and displays a messagebox to indicate an error
		/// </summary>
		/// <param name="errorString"></param>
		public static void DisplayErrorMsgBox(string messageBoxText)
		{
			//Configure the message box
			string caption = "Diagram Generator";//Sets the heading of the msgbox
			MessageBoxButtons button = MessageBoxButtons.OK;//configures the button(s) of the msgbox
			MessageBoxIcon icon = MessageBoxIcon.Error;     //configures the icon to be displayed

			//Display the messagebox
			MessageBox.Show(messageBoxText, caption, button, icon);
		}
	}
}
