using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace Testo.Classes
{
    public class Teacher
    {
        private string name = "";
        private string md5pas = "";

        public string Name
        {
            get { return name; }
        }

        public string Key
        {
            get { return md5pas; }
        }

        public bool Compare(string pas)
        {
            MD5 md = MD5.Create();
            byte[] hash = md.ComputeHash(Encoding.ASCII.GetBytes(pas));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string passwordhash = sb.ToString().ToLower();
            if (passwordhash == md5pas)
            {
                return true;
            }
            else return false;
        }

        public Teacher(string name_, string hash)
        {
            name = name_;
            md5pas = hash;
        }
    }
}
