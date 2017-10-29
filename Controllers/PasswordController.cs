using System;
using Microsoft.AspNetCore.Mvc;

namespace d101.Controllers
{
    [Route("api/[controller]")]
    public class PasswordController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return GeneratePassword(4, Constants.WordList, ' ');
        }

        private string GeneratePassword(int numWords, string[] wordDictionary, char separator)
        {
            int dictionaryLength = wordDictionary.Length;
            string passwordOutput = "";
            for (int i = 0; i < numWords; i++)
            {
                int whichWord = new Random().Next(0, dictionaryLength);
                passwordOutput += string.Format("{0}{1}", wordDictionary[whichWord], separator);
            }
            return passwordOutput.Trim();
        }
    }
}
