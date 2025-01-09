using SenhaForte;

var senhaForte = new AnalisaSenha();
var senha = senhaForte.PedeSenha();
var resultado = senhaForte.SenhaValida(senha);
senhaForte.MostrarResultado(resultado);
