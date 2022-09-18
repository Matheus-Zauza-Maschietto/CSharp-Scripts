public class fibonatie
{
    public int[] fibonacci(int n,  int[]previousList, int line=1)
    {
        int[] lineNumbers = new int[line];
        if (n==1)
        {
            return new int[]{1};
        }
        else
        {
        for (int i=0; i<line; i++)
                {
                    if(i==0 || i==(lineNumbers.Length)-1)
                    {
                        lineNumbers[i] = 1;
                    }
                    else{
                        lineNumbers[i] = previousList[i]+previousList[i-1];
                    }
                }    
        if (n>line)
        {
            return fibonacci(n:n, previousList:lineNumbers, line:line+1);
        }
        else
        {
            return lineNumbers;
        }
        }
    }
}