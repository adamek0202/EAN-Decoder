using System;
using System.Windows.Forms;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Zadejte text čárového kódu(Musí mít 13 znaků): ");
            string? codeentered = Console.ReadLine();
            if (codeentered.Length == 13 && codeentered.All(char.IsDigit))
            {
                int code = Convert.ToInt32(codeentered.Substring(0, 3));
                Process.Processer(code);
            }
            else
            {
                MessageBox.Show("Neplatné zadání, zkus to znovu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}