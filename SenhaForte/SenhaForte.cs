namespace SenhaForte;
public class AnalisaSenha
{
    public bool SenhaValida(string senha)
    {
        var temMaiuscula = false;
        var temMinuscula = false;
        var temEspecial = false;
        foreach(char c in senha)
        {
            if (char.IsUpper(c))
            {
                temMaiuscula = true;
            }
            
            if (char.IsLower(c))
            {
                temMinuscula = true;
            }

            if (!char.IsLetterOrDigit(c))
            {
                temEspecial = true;
            }

        }
        return temEspecial && temMaiuscula && temMinuscula;
    }
    public void MostrarResultado(bool resultado)
    {
        if (resultado)
        {
            Console.WriteLine("A senha é forte!");
        }
        else
        {
            Console.WriteLine("A senha é fraca!");
        }
    }
    public string PedeSenha()
    {
        Console.WriteLine("Digite a senha: ");
        return Console.ReadLine();
    }
}