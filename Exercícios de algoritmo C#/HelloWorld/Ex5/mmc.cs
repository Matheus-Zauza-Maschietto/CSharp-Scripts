public class minimoMultiploComumRecursivo{
    public int mmc(int a, int b){
        int[] primos = new int[]{2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
        int divisorA=1;
        int divisorB=1;
        if (a >= 1 && b >= 1)
        {
            foreach(int primo in primos)
            {
                if (a%primo==0)
                {
                    divisorA=primo;
                }
                if(b%primo==0)
                {
                    divisorB=primo;
                }
            }
            if (divisorA == 1 && divisorB == 1)
            {
                return 1;
            }
            else
            {
                if (divisorA == divisorB)
                {
                    return divisorA*mmc(a/divisorA, b/divisorB);
                }
                else
                {
                    return divisorA*divisorB*mmc(a/divisorA, b/divisorB);
                }
            }
        }
        else
        {
            return 1;
        }
    }
}