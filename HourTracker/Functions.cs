using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Functions
{
    #region RO Service Functions
    public class Services
    {
        public static void Add(string ServiceName, string Hours)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\HourTracker\\Services", ServiceName, Hours);
        }

        public static void Remove(string ServiceName)
        {
            // TODO: Function to remove a service from the registry, not sure if this is needed but...
        }

        public static List<string> List
        {
            get
            {
                RegistryKey ServiceKeys = Registry.CurrentUser.OpenSubKey("Software\\hourtracker\\services");

                foreach (string ServiceName in ServiceKeys.GetValueNames())
                {
                    List.Add(ServiceName);
                }

                return List;
            }
        }
    }
    #endregion

    #region RO Functions
    public class RepairOrder
    {
        public static void Add(string Date, string RepairOrder, List<string> Services)
        {
            List<string> filedata = new List<string>();
            filedata.Add(Date);
            filedata.Add(RepairOrder);

            foreach (var services in Services)
            {
                filedata.Add(services.ToString());
            }

            string writetofile = string.Join("|", filedata.ToArray());

            StreamWriter file = new StreamWriter(HoursFile.Location, true);
            file.WriteLine(writetofile);
            file.Close();
        }

        public static void Remove(string RepairOrder)
        {
            List<string> lines = File.ReadAllLines(HoursFile.Location).ToList();
            lines.RemoveAll(line => line.Contains(RepairOrder));
            File.WriteAllLines(HoursFile.Location, lines);
        }

        public static string Services(string RepairOrder)
        {
            string arrayData;
            char[] splitChar = { '|' };
            var file = new StreamReader(HoursFile.Location);
            List<string> ROServices = new List<string>();

            while ((arrayData = file.ReadLine()) != null)
            {
                string[] parsedData = arrayData.Split(splitChar);

                if (parsedData[1] == RepairOrder)
                {
                    for (int i = 2; i < parsedData.Length; i++)
                    {
                        ROServices.Add(parsedData[i].ToString());
                        string tmp = Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker\\Services", parsedData[i], null).ToString();
                    }
                }
            }
            var result = String.Join("|", ROServices.ToArray());
            return result;
        }
    }
    #endregion

    #region DataFile Functions
    public class HoursFile
    {
        public static List<string> RONumbers
        {
            get
            {
                char[] splitChar = { '|' };
                List<string> ROData = File.ReadAllLines(HoursFile.Location).ToList();

                foreach (string RONumber in ROData)
                {
                    string[] parsedData = RONumber.Split(splitChar);
                    RONumbers.Add(parsedData[1]);
                }

                return RONumbers;
            }
        }

        public static string Location
        {
            get
            {
                string x = Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "DataFile", null).ToString();
                return x;
            }
        }
    }
    #endregion

    #region Credential Functions
    public class Credentials
    {
        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "Ab41Dyy2Hm1dR98hEl";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "Ab41Dyy2Hm1dR98hEl";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static bool Check(string Username, string Password)
        {
            string x = Decrypt(Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "username", null).ToString());
            string y = Decrypt(Registry.GetValue("HKEY_CURRENT_USER\\Software\\HourTracker", "password", null).ToString());

            if (Username == x && Password == y) { return true; }
            else { return false; }
        }
    }
    #endregion
}
