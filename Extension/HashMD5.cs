//using System;
//using System.Text;
//using XSystem.Security.Cryptography;

//namespace PE.Extension
//{
//    public static class HashMD5
//    {
//        public static string ToMD5(this string str)
//        {
//            MD5CryptoServiceProvider toMD5 = new MD5CryptoServiceProvider();
//            byte[] bHash = toMD5.ComputeHash(Encoding.UTF8.GetBytes(str));
//            StringBuilder sbHash = new StringBuilder();
//            foreach (byte b in bHash)
//            {
//                sbHash.Append(String.Format("{0:x2}", b));

//            }
//            return sbHash.ToString();
//        }
//    }
//}
