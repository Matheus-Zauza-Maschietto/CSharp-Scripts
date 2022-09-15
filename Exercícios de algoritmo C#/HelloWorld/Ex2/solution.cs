public class SolutionClass{
  public void matrix(int n)
 {
   int[][] lista = new int[n][];
   for (int i=0; i<n; i++)
   {
      lista[i] = new int[n];
      for(int j=0; j<n; j++)
      {
         if (j>i)
         {
            lista[i][j] = 1;
         }
         else if (j<i)
         {
            lista[i][j] = -1;
         }
      }
   }
   foreach(int[] i in lista)
   {
      foreach(int j in i)
      {
         Console.Write(j);
      }
      Console.WriteLine();
   }
   
   

 }
}