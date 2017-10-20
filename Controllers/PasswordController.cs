using System;
using Microsoft.AspNetCore.Mvc;

namespace DevopsEast.Controllers
{
    [Route("api/[controller]")]
    public class PasswordController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return GeneratePassword();
        }

        private string GeneratePassword()
        {
            int numberOfWords = Constants.WordList.Length;
            int word1 = GetRandomNumberFromArray(numberOfWords);
            int word2 = GetRandomNumberFromArray(numberOfWords);
            int word3 = GetRandomNumberFromArray(numberOfWords);
            int word4 = GetRandomNumberFromArray(numberOfWords);

            return string.Format("{0} {1} {2} {3}",
                Constants.WordList[word1],
                Constants.WordList[word2],
                Constants.WordList[word3],
                Constants.WordList[word4]);
        }

        private int GetRandomNumberFromArray(int arrayLength)
        {
            Random r1 = new Random();
            return r1.Next(0, arrayLength);
        }
    }
}
