public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows >= s.Length)
            return s;

        string[] rows = new string[numRows];
        int currentRow = 0;
        int direction = 1;

        for (int i = 0; i < numRows; i++)
            rows[i] = "";

        foreach (char c in s)
        {
            rows[currentRow] += c;

            if (currentRow == 0)
                direction = 1;
            else if (currentRow == numRows - 1)
                direction = -1;

            currentRow += direction;
        }

        return string.Join("", rows);
    }
}
