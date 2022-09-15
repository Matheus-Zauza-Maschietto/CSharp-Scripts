
public class SolutionClass
{  
    public void findUnique(int[] arr) 
    { 	   
      int item = 0;
      int cont = 0;
      int itensUnicos=0;
      int[] array = new int[arr.Length];
      for(int i=0; i<arr.Length; i++)
      {
        item = arr[i];
        if (i==0)
        {
          array[0] = arr[0];
          itensUnicos+=1;
        }
        else
        {
          for(int j=0; j<arr.Length;j++)
          {
            if(arr[j]==item){
              cont+=1;
            }
          }
          if (cont==1){
            array[itensUnicos] = arr[i];
            itensUnicos+=1;
          }
          cont=0;
        }
      }
      int[] listaUnicos = new int[itensUnicos];
      for (int i=0; i<itensUnicos; i++)
      {
        listaUnicos[i] = array[i];
      }
      foreach(int i in listaUnicos)
      {
        Console.Write(i+" ");
      }

    }
}