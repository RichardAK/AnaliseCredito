decimal valor, renda, valorparcela, maiorparcela;
int parcelas;

Console.Write("Valor Requerido: "); 
valor = Convert.ToDecimal(Console.ReadLine()); 

Console.Write("Quantidade de parcelas: ");
parcelas = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Renda: ");
renda = Convert.ToDecimal(Console.ReadLine()); 

valorparcela = valor / parcelas;
maiorparcela = renda / 100 * 30  ;

Console.WriteLine(); 

if(valorparcela > maiorparcela )
{   
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Valor não aprovado");
}

else 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Valor aprovado");
}
 
Console.ResetColor(); 