// See https://aka.ms/new-console-template for more information

using Test;

class Solution
{

    public static void Main(string[] args)
    {
        int[] range = new int[] { 100, 54, 1, 1, 8, 8, 69, 38, 28, 14, 100, 54, 1, 1, 8, 8, 69, 38, 28, 14 };
        var t = new ITwoTest(range).GetOrderedSet();

    }
}
