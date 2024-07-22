namespace cadastros;

public class Transportadora
{
    string nome;
    string Endereço;
    int numero;
    string Valor;
    string percurçopercorrido;
    string cidade;
    string estado;
    //______________________________________

    public void SetNome (string nome)
    {
       this.nome = nome;
    }
     public string GetNome ()
    {
       return nome;
    }
    //______________________________________

     private void SetEndereço (string Endereço)
    {
       this.Endereço = Endereço;
    }
     protected string GetEndereço ()
    {
       return Endereço;
    }
     //______________________________________

     protected void Setnumero (string numero)
    {
       this.numero = numero;
    }
     protected string Getnumero ()
    {
       return numero;
    }
     //______________________________________
      protected void Setquantidade (string c)
    {
       this.quantidade = quantidade;
    }
     protected string Getquantiade ()
    {
       return quantidade;
    }
    //______________________________________
     protected void SetValor (string Valor)
    {
       this.Valor = Valor;
    }
     protected string GetValor ()
    {
       return Valor;
    }
    //______________________________________
     protected void Setpercurçopercorrido (string percurçopercorrido)
    {
       this.percurçopercorrido = ipercurçopercorridod;
    }
     protected string Getpercurçopercorrido ()
    {
       return percurçopercorrido;
    }
    //______________________________________
     protected void Setcidade (string cidade)
    {
       this.cidade = cidade;
    }
     protected string Getcidade ()
    {
       return cidade;
    }
    //______________________________________
     protected void Setestado (string estado)
    {
       this.estado = estado;
    }
     protected string Getestado ()
    {
       return estado;
    }
}  
