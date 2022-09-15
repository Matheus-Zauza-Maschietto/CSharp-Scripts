namespace HelloWorld
{
public class Program{
  static public void Main(){
    int row = 5;
    int[][] pascal = new int[row][];
    
    
    for (int linha = 0; linha < row; linha++)
    {  
      pascal[linha] = new int[linha+1];

      for (int item = 0; item <= linha; item++)
      {
        if (item==0 || item==linha)
        {
          pascal[linha][item] = 1;
        }
        else
        {
          pascal[linha][item] = pascal[linha-1][item]+pascal[linha-1][item-1];
        }
      }
    } 

    foreach (int[] linha in pascal)
    {
      foreach(int item in linha)
      {
        Console.Write(item);
      }
      Console.WriteLine();
    }
     
  }
}
}
