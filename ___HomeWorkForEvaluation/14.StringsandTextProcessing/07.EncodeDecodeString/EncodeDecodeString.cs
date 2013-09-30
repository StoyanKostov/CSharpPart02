/* Write a program that encodes and decodes a string using given encryption key (cipher).
 * The key consists of a sequence of characters. The encoding/decoding is done
 * by performing XOR (exclusive or) operation over the first letter of the string
 * with the first of the key, the second – with the second, etc.
 * When the last key character is reached, the next is the first. */

using System;
using System.Collections.Generic;
using System.Text;

class EncodeDecodeString
{
    static void Main()
    {
        string inString = "Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.";
        string cipher = "В .NET Framework всеки символ има пореден номер от Unicode таблицата. Стандартът Unicode е създаден в края на 80-те и началото на 90-те години с цел съхраняването на различни типове текстови данни. Предшестве-никът му ASCII позволява записването на едва 128 или 256 символа (съответно ASCII стандарт със 7-битова или 8-битова таблица).";

        // Encoding
        StringBuilder encodedSb = new StringBuilder(inString.Length);
        for (int i = 0, ci = 0; i < inString.Length; i++, ci++)
        {
            if (ci == cipher.Length)
            {
                ci = 0;
            }
            encodedSb.Append((char)(inString[i] ^ cipher[ci]));
        }
        string encoded = encodedSb.ToString();
        Console.WriteLine("The encoded text is: ");
        Console.WriteLine(encoded);

        // Dedcoding
        StringBuilder decodedSb = new StringBuilder(encoded.Length);
        for (int i = 0, ci = 0; i < encoded.Length; i++, ci++)
        {
            if (ci == cipher.Length)
            {
                ci = 0;
            }
            decodedSb.Append((char)(encoded[i] ^ cipher[ci]));
        }
        string decoded = decodedSb.ToString();
        Console.WriteLine();
        Console.WriteLine("The decoded text is: ");
        Console.WriteLine(decoded);
    }
}