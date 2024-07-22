namespace cadastros;

public class Produto
{
    string nome;
    string bairronoufacção;
    string tempoestimado;
    string valor;
    string quantidade;
    int id;
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

     protected void SetBairronouFacção (string b)
    {
       this.bairronoufacção = b;
    }
     protected string Getb ()
    {
       return bairronoufacção;
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
     protected void SetValor (string RS)
    {
       this.valor = RS;
    }
     protected string GetValor ()
    {
       return valor;
    }
    //______________________________________
     protected void SetId (string id)
    {
       this.id = id;
    }
     protected string GetID ()
    {
       return id;
    }
    //______________________________________
     protected void Settempoestimado (string tempo estimado)
    {
       this.tempoestimado = tempo estimado;
    }
     protected string GetTempostimado ()
    {
       return tempoestimado;
    }
    //______________________________________

}  
