#include <iostream>

using namespace std;

int loop(int x, int y)
{
    int i = 0, j = 0;
    int num = 1, circle = 3;
    while (x != i || y != j)
    {
        i++;
        num++;

        if (x == i && y == j)
        {
            return num;
        }
        for (int k = 0; k < circle -2; k++)
        {
            j++;
            num++;
            if (x == i && y == j)
            {
                return num;
            }
        }

        for (int k = 0; k < circle - 1; k++)
        {
            i--;
            num++;
            if (x == i && y == j)
            {
                return num;
            }
        }

        for (int k = 0; k < circle - 1; k++)
        {
            j--;
            num++;
            if (x == i && y == j)
            {
                return num;
            }
        }

        for (int k = 0; k < circle - 1; k++)
        {
            i++;
            num++;
            if (x == i && y == j)
            {
                return num;
            }
        }
        circle += 2;
    }
    return num;
}

int main()
{
    int x, y;
    cin >> x >> y;
    cout << loop(x, y) << endl;
}
