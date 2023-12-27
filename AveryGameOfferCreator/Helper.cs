using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveryGameOfferCreator
{
    internal class Helper
    {
        public static string BaseURL = "http://127.0.0.1:8000/";
        public static string GetBaseURL()
        {
            return BaseURL;
        }

        public static void SetBaseURL(string Base)
        {
            BaseURL = Base;
            Program.ini.SetValue("backend", "url", Base);
        }

        public static string GetUsername()
        {
            return Program.ini.GetValue("authentication", "username");
        }

        public static string GetPassword()
        {
            return Program.ini.GetValue("authentication", "password");
        }
    }
}
