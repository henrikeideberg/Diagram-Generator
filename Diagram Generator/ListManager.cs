using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram_Generator
{
	[Serializable]
	public class ListManager<T>
	{
		private List<T> m_list;

		/// <summary>
		/// Default constructor
		/// </summary>
		public ListManager()
		{
			m_list = new List<T>();
		}

		/// <summary>
		/// Function to set the list to inputted newList
		/// </summary>
		/// <param name="newList"></param>
		public void SetList(List<T> newList)
		{
			m_list = newList;
		}

		/// <summary>
		/// Get the count of number of objects in list
		/// </summary>
		public int Count
		{
			get { return m_list.Count; }
		}

		/// <summary>
		///  Method to add object of type T to list
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool Add(T obj)
		{
			if (obj == null) return false;
			else m_list.Add(obj); return true;
		}

		/// <summary>
		/// Method to change/insert object of type T in list
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		public bool ChangeAt(T obj, int index)
		{
			if (CheckIndex(index))
			{
				m_list[index] = obj;
				return true;
			}
			else return false;
		}

		/// <summary>
		/// Method to checks that
		///  - the element at index is not null
		///  - index is within List range
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public bool CheckIndex(int index)
		{
			if ((index >= 0) && (index <= Count))
			{
				return m_list[index] != null;
			}
			else return false;
		}

		/// <summary>
		/// Method to delete all elements in list.
		/// Count is set to 0, and references to other objects from elements of the collection are also released.
		/// </summary>
		public void DeleteAll()
		{
			m_list.Clear();
		}

		/// <summary>
		/// Method to delete/remove element at index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public bool DeleteAt(int index)
		{
			if (CheckIndex(index))
			{
				m_list.RemoveAt(index);
				return true;
			}
			else return false;

		}

		/// <summary>
		/// Method to return element at index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T GetAt(int index)
		{
			if (CheckIndex(index))
			{
				return m_list[index];
			}
			else
			{
				return default(T);
			}
		}

		/// <summary>
		/// Method to reset all elements in list.
		/// Count is set to 0, and references to other objects from elements of the collection are also released.
		/// </summary>
		public void Reset()
		{
			DeleteAll();
		}

		/// <summary>
		/// Returns an array of strings where each string contains info about an object in the collection.
		/// </summary>
		/// <returns></returns>
		public string[] ToStringArray()
		{
			string[] resultStringArray = new string[m_list.Count];
			for (int i = 0; i < m_list.Count; i++)
			{
				resultStringArray[i] = m_list[i].ToString();
			}
			return resultStringArray;
		}

		/// <summary>
		/// Returns a list of string where each string contains info about an object in the collection
		/// </summary>
		/// <returns></returns>
		public List<string> ToStringList()
		{
			List<string> resultingList = new List<string>();
			for (int i = 0; i < m_list.Count; i++)
			{
				resultingList.Add(m_list[i].ToString());
			}
			return resultingList;
		}

		/// <summary>
		/// Method which sorts the list based on inputted sorter-function (sorter)
		/// </summary>
		/// <param name="sorter"></param>
		public void Sort(IComparer<T> sorter)
		{
			m_list.Sort(sorter);
		}
		/*
		/// <summary>
		/// Method to perform binary serialization operation
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public bool BinarySerialize(string filename)
		{
			return BinarySerializerUtility.Serialize<List<T>>(m_list, filename);
		}

		/// <summary>
		/// Method to open and deserialise a file in to the object List<T>
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public bool BinaryDeSerialize(string filename)
		{
			m_list = BinarySerializerUtility.Deserialize<List<T>>(filename);
			return m_list != null ? true : false;
		}
		*/

		/// <summary>
		/// Method to serialise the m_list into XML format
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public bool XMLSerialize(string filename)
		{
			return Utility.Serialize<List<T>>(m_list, filename);
		}

		/// <summary>
		/// Method to open and deserialise a xml file in to the object List<T>
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public bool XMLDeSerialize(string filename)
		{
			m_list = Utility.DeSerialize<List<T>>(filename);
			return m_list != null ? true : false;
		}
	}
}
