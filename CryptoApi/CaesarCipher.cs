namespace CryptoApi;
public class CaesarCipher
{
    //Kryptera med Caesar-chiffer
    public string Encrypt(string input, int shift)
    {
        char[] buffer = input.ToCharArray(); //Array för krypterad text

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((letter - offset + shift + 26) % 26 + offset);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }
      // Avkryptera med Caesar-chiffer
  public string Decrypt(string input, int shift)
  {
      return Encrypt(input, -shift);
  }
}