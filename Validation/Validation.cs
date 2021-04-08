using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Validation Library for common inputs
 * 
 * Author: Eli Limper
 * Last modified: 4/8/2021
 * 
 * Description: This library holds a class that is useful for checking if values are the type 
 *  they should be.
 *  
 * non boolean functions should return -1 when invalid
 */

namespace Validation
{
    public class Validation
    {

        /** Returns a boolean value if the string under question is an integer.
         * 
         * <param>    input A string containing unverified input
         * <returns>  true if int, false otherwise
         */
        public static bool isInt(string input)
        {
            try
            {
                int.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /** checks to see if a value is in the range
         * 
         * <param name="input"> a string that needs to be checked as an integer</param>
         * <param name="lowerLimit"> the lowest value the integer can be. Inclusive</param>
         * <param name="upperLimit"> the largest value the integer can be. Inclusive</param>
         * <returns> true if the string is an integer in range. Otherwise false</returns>
         */
        public static bool isIntInRange(string input, int lowerLimit, int upperLimit)
        {
            if(lowerLimit < int.MinValue)
            {
                return false;
            }
            if(upperLimit > int.MaxValue)
            {
                return false;
            }
            try
            {
                int number = int.Parse(input);
                if (number >= lowerLimit && number <= upperLimit)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /**Checks an integer to validate it is within the range
         * 
         * <param name="input"> an integer to validate</param>
         * <param name="lowerLimit">Lowest value the number can be. Inclusive</param>
         * <param name="upperLimit">Largest value the number can be. Incllusive</param>
         * <returns> true if the number is in range. Otherwise false</returns>
         */
        public static bool isIntInRange(int input, int lowerLimit, int upperLimit)
        {
            if (lowerLimit < int.MinValue)
            {
                return false;
            }
            if (upperLimit > int.MaxValue)
            {
                return false;
            }
            if (input >= lowerLimit && input <= upperLimit)
            {
                return true;
            }
            return false;
        }

        /** Checks to see if the provided string is a valid email address
         * 
         * <param name="email"> a string that might be an email</param>
         * <returns> true if it follows email format, otherwise false</returns>
         */
        public static bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /** checks that the added numbers will not result in an overflow
         * 
         * <param name="firstNum">Integer that is going to be added</param>
         * <param name="secondNum">Integer that is going to be added</param>
         * <returns>true if the sum is less than int.MaxValue</returns>
         */
        public static bool canBeSummed(int firstNum, int secondNum)
        {
            if(firstNum < int.MaxValue && secondNum < int.MaxValue)
            {
                if(firstNum + secondNum < int.MaxValue)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
