public class Solution {
    public bool IsPalindrome(int x) {
        int sum=0;
        int y=x;
        int r;
        while (x > 0)
            {
                r = x % 10;
                sum = (sum * 10) + r;
                x = x / 10;
            }
        if (y == sum)
                return true;
            else
               return false;
                


    }
}