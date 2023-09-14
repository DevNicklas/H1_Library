using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Library.Model
{
    /// <summary>
    /// Class <see cref="UserInput"/> represents input from user
    /// </summary>
    internal class UserInput
    {
        /// <summary>
        /// Gets a input by user
        /// </summary>
        /// <returns>A string. Input from user</returns>
        public string GetInput()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Fetches the key the user has pressed
        /// </summary>
        /// <returns>The key the user has pressed as ConsoleKey</returns>
        public ConsoleKey GetPressedKey()
        {
            return Console.ReadKey(true).Key;
        }
    }
}
