using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CTS_DataModels
{
    [Serializable]
    class UserList
    {
        private const string DATA_FILENAME = "UserList.dat";
        private static UserList userList;
        private Dictionary<string, User> _userDictionary;
        private BinaryFormatter formatter;
        
        public static UserList Instance()
        {
            if (userList == null)
            {
                userList = new UserList();
            }

            return userList;
        }

        private UserList()
        {
            this._userDictionary = new Dictionary<string, User>();
            this.formatter = new BinaryFormatter();
        }

        public bool AddUser(User newUser)
        {
            if (this._userDictionary.ContainsKey(newUser.UserName))
            {
                return false;
            }

            this._userDictionary.Add(newUser.UserName, newUser);
            return true;
        }

        public void UpdateUser()
        {

        }

        public bool DeleteUser(string userName)
        {
            if (!this._userDictionary.ContainsKey(userName))
            {
                return false;
            }

            this._userDictionary.Remove(userName);
            return true;
                     
        }

        public void SaveUserList()
        {
            try
            {
                FileStream fileStreamWriter = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                this.formatter.Serialize(fileStreamWriter, this._userDictionary);
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
                    this._userDictionary = (Dictionary<string, User>)this.formatter.Deserialize(fileStreamReader);
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
