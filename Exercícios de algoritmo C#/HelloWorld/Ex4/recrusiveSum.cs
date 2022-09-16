public class recursion{
    public int recursiveSum(int n){
        if (n==0){
            return 0;
        }
        else{
            string NString = n.ToString();
            if (NString.Length > 1){
                return int.Parse(NString.Substring(0, 1))+recursiveSum(int.Parse(NString.Substring(1, NString.Length-1)));
            }
            else{
                return int.Parse(NString);
            }
            
        }
    }

}