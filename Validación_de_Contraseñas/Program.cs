using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validación_de_Contraseñas
{
    class Program
    {
        #region
        /*using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al validador de contraseñas");

            while (true)
            {
                Console.Write("Ingrese la contraseña a validar (entre 8 y 25 caracteres): ");
                string password = ReadPassword();
                Console.WriteLine();

                if (IsValidPassword(password))
                {
                    Console.WriteLine("Contraseña válida");
                    Console.WriteLine($"Nivel de seguridad: {GetSecurityLevel(password)}");
                }
                else
                {
                    Console.WriteLine("Contraseña no válida");
                }

                Console.WriteLine($"Contraseña ingresada: {password}");
                Console.WriteLine();

                Console.Write("¿Desea generar una contraseña aleatoria de nivel alto (s/n)? ");
                string option = Console.ReadLine().ToLower();
                if (option == "s")
                {
                    string randomPassword = GenerateRandomPassword(15);
                    Console.WriteLine($"Contraseña generada: {randomPassword}");
                }

                Console.Write("¿Desea validar otra contraseña (s/n)? ");
                string again = Console.ReadLine().ToLower();
                if (again != "s")
                {
                    break;
                }

                Console.WriteLine();
            }
        }

        static bool IsValidPassword(string password)
        {
            // Longitud entre 8 y 25 caracteres
            if (password.Length < 8 || password.Length > 25)
            {
                return false;
            }

            // Contiene al menos 2 letras mayúsculas, 2 letras minúsculas, 2 dígitos y 2 de los siguientes signos: –, _, $, !, &, @, %, *, +, =
            int uppercaseCount = password.Count(c => Char.IsUpper(c));
            int lowercaseCount = password.Count(c => Char.IsLower(c));
            int digitCount = password.Count(c => Char.IsDigit(c));
            int specialCount = password.Count(c => IsSpecialCharacter(c));
            if (uppercaseCount < 2 || lowercaseCount < 2 || digitCount < 2 || specialCount < 2)
            {
                return false;
            }

            // No contiene signos ? : ni espacios en blanco
            if (password.Contains("?") || password.Contains(":") || password.Contains(" "))
            {
                return false;
            }

            // Inicia con letra y concluye con dígito
            if (!Char.IsLetter(password[0]) || !Char.IsDigit(password[password.Length - 1]))
            {
                return false;
            }

            return true;
        }

        static bool IsSpecialCharacter(char c)
        {
            char[] specialCharacters = { '-', '_', '$', '!', '&', '@', '%', '*', '+', '=' };
            return specialCharacters.Contains(c);
        }

        static string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_$!&@%*+=";
            var sb = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (sb.Length < length)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    sb.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }
            }
            return sb.ToString();
        }

*/
        #endregion
        static void Main(string[] args)
        {
            //string username = "usuario";
            //string password = "p@ssw0rd"; // Contraseña con caracteres especiales y longitud de 8
            //string inputUsername="", inputPassword="";

            ////Console.WriteLine("Ingrese su nombre de usuario:");
            ////inputUsername = Console.ReadLine();
            //Console.WriteLine("Ingrese su contraseña:");
            //while (true)
            //{
            //    ConsoleKeyInfo key = Console.ReadKey(true);
            //    if (key.Key == ConsoleKey.Enter)
            //        break;
            //    inputPassword += key.KeyChar;
            //    Console.Write("*");
            //}
            //Console.ReadKey();
            Console.WriteLine("Ingrese una contraseña:");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Contraseña válida");
            }
            else
            {
                Console.WriteLine("Contraseña inválida");
            }

            Console.ReadLine();
        }
        static bool IsValidPassword(string password)
        {
            // Validar longitud
            if (password.Length < 8 || password.Length > 25)
            {
                return false;
            }

            // Validar letras mayúsculas
            if (password.Count(char.IsUpper) < 2)
            {
                return false;
            }

            // Validar letras minúsculas
            if (password.Count(char.IsLower) < 2)
            {
                return false;
            }

            // Validar dígitos
            if (password.Count(char.IsDigit) < 2)
            {
                return false;
            }

            // Validar símbolos
            string allowedSymbols = "-_$!&@%*+= ";
            if (password.Count(c => allowedSymbols.Contains(c)) < 2)
            {
                return false;
            }

            // Validar símbolos no permitidos
            if (password.Contains("?") || password.Contains(":") || password.Contains(" "))
            {
                return false;
            }

            // Validar primer y último carácter
            if (!char.IsLetter(password[0]) || !char.IsDigit(password[password.Length - 1]))
            {
                return false;
            }

            return true;
        }
    }
}
