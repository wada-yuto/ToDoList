using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ToDoList
{
    public class Controller
    {
        string FileName = "..//ToDoList//bin//Debug//UserDatabase.txt";

        JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new CustomJsonContractResolver(),
            PreserveReferencesHandling = PreserveReferencesHandling.Objects
        };

        public IUser Login(string username, string password)
        {
            IUser existingUser = new User(username, password);
            bool found = false;
            bool changeStatus = false;
            using(StreamReader reader = new StreamReader("UserDatabase.txt", true))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    dynamic data = JObject.Parse(line);
                    if(data.Username == username && data.Password == password)
                    {
                        changeStatus = true;
                        found = true;
                        existingUser = DeSerializeAccount(line);

                        if (changeStatus)
                        {
                            existingUser.Status = "Online";
                        }
                        
                    }
                    else if(data.Username == username && data.Password != password)
                    {
                        return new User("User not found", "User not found");
                    }
                    continue;
                }
                reader.Close();
            }

            

            if (!found)
            {
                using (StreamWriter writer = new StreamWriter("UserDatabase.txt", true))
                {
                    IUser newUser = new User(username, password);
                    string newUserJson = SerializeAccount(newUser);
                    writer.WriteLine(newUserJson);
                    return newUser;
                }
            }
            return existingUser;
        }

       
        public void Logout(IUser user)
        {
            user.Status = "Offline";
            UpdateContact(user);

        }

       
        /// <summary>
        /// Method to update the contact in the database
        /// </summary>
        /// <param name="user">User that is getting their contact updated</param>
        public void UpdateContact(IUser user)
        {
            int lineNumber = GetLine(user.Username);
            string account = SerializeAccount(user);
            LineChanger(account, lineNumber);
        }

        /// <summary>
        /// Return the line number that username is at
        /// </summary>
        /// <param name="username">name of the user</param>
        /// <returns>line number that username is at</returns>
        private int GetLine(string username)
        {
            int lineNum = 0;
            using (StreamReader reader = new StreamReader("UserDatabase.txt", true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    dynamic data = JObject.Parse(line);
                    lineNum++;
                    if (data.Username == username)
                        return lineNum;
                }
                reader.Close();
            }
            return -1;
            
        }

        /// <summary>
        /// Helper method to change the line in the text file
        /// </summary>
        /// <param name="newText">New text</param>
        /// <param name="lineNumber">Line number that needs to be changed</param>
        private void LineChanger(string newText, int lineNumber)
        {
            string[] arrLine = File.ReadAllLines("UserDatabase.txt");
            arrLine[lineNumber - 1] = newText;
            File.WriteAllLines("UserDatabase.txt", arrLine);
        }


        /// <summary>
        /// Method to serialize the user
        /// </summary>
        /// <param name="user">User that is getting serialized</param>
        /// <returns>Returns serialized string of user</returns>
        private string SerializeAccount(IUser user)
        {
            string jsonString = JsonConvert.SerializeObject(user, Settings);
            return jsonString;
        }

        /// <summary>
        /// Method used to deserialize account from the database
        /// </summary>
        /// <param name="stringUser">string that needs to be deserialized </param>
        /// <returns>Returns user that is deserialized from the string</returns>
        private User DeSerializeAccount(string stringUser)
        {
            var user = JsonConvert.DeserializeObject<User>(stringUser);
            return user;
        }

    }
}
