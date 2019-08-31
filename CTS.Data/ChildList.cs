using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Data
{
    public class ChildList
    {
        private const string DATA_FILENAME = "UserList.dat";
        private static ChildList childList;
        private Dictionary<string, Child> _childDictionary;
        private BinaryFormatter formatter;

        public static ChildList Instance()
        {
            if (childList == null)
            {
                childList = new ChildList();
            }

            return childList;
        }

        private ChildList()
        {
            this._childDictionary = new Dictionary<string, Child>();
            this.formatter = new BinaryFormatter();
        }

        public bool AddUser(Child newUser)
        {
            if (this._childDictionary.ContainsKey(newUser.UserName))
            {
                return false;
            }

            this._childDictionary.Add(newUser.UserName, newUser);
            return true;
        }

        public void UpdateUser()
        {

        }

        public bool DeleteUser(string userName)
        {
            if (!this._childDictionary.ContainsKey(userName))
            {
                return false;
            }

            this._childDictionary.Remove(userName);
            return true;

        }

        public void SaveUserList()
        {
            try
            {
                FileStream fileStreamWriter = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                this.formatter.Serialize(fileStreamWriter, this._childDictionary);
                fileStreamWriter.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("{0} - Could not save the file", ex.Message));
            }
        }

        public void LoadUserList()
        {
            if (File.Exists(DATA_FILENAME))
            {
                try
                {
                    FileStream fileStreamReader = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);
                    this._childDictionary = (Dictionary<string, Child>)this.formatter.Deserialize(fileStreamReader);
                    fileStreamReader.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception(string.Format("{0} -Unable to open the file", ex.Message));
                }
            }
        }
    }
}

