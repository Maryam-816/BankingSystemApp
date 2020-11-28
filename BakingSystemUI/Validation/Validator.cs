using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Validation
{
    public class Validator
    {
        //public static void Validate(params string[] txbxs)
        //{
        //    foreach (string txbx in txbxs)
        //    {
        //        if (string.IsNullOrEmpty(txbx))
        //        {
        //            throw new ArgumentNullException("Input is empty. Please fill out them all!");

        //        }
        //    }
        //}

        //public static sbyte IsAgeValueValid(string age, sbyte limit)
        //{
        //    if (string.IsNullOrEmpty(age))
        //        throw new ArgumentNullException("Age field is empty!");
        //    if (!sbyte.TryParse(age, out sbyte result))
        //        throw new FormatException("Age value is not valid!");
        //    if (sbyte.Parse(age) < limit)
        //        throw new ValidAgeValueException("Age value is less than zero! Please enter the valid value!");

        //    return result;

        //}

        //public static void IsEmailValid(string email)
        //{
        //    if (string.IsNullOrEmpty(email))
        //        throw new ArgumentNullException("Email is empty!");
        //    if (!email.Contains("@"))
        //        throw new InvalidEmailException();

        //}

        //public static void IsPasswordValid(string password)
        //{
        //    if (string.IsNullOrEmpty(password))
        //        throw new ArgumentNullException();
        //    if (password.Length < 4)
        //        throw new InvalidPasswordException("Password is not valid. Length must contains 4 or more");

        //}
    }
}
