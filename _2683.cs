
public class Solution {
    public int[] CircularGameLosers(int n, int k) {
        bool[] visit=new bool[n];
        int t=0;
        int p=0;
        while(visit[p]==false){
            visit[p]=true;
            t++;
            p=(p+t*k)%n;
        }
        List<int> res=new List<int>();
        for(int i=0;i<visit.Length;i++){
            if(!visit[i])
                res.Add(i+1);
        }
        return res.ToArray();
    }
}