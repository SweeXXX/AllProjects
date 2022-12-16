// author Vardhan Gacche
#include <iostream>
#include <Bits.h>
#include <vector>
using namespace std;
char get(int i)
{
    return 'a' + i - 1;
}
int main()
{
    int t;
    cin >> t;
    while (t--)
    {
        int n;
        cin >> n;
        int *a = new int[n];
        for (int i = 0; i < n; i++)
        {
            cin >> a[i];
        }
        int n2a = 0;
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                if (a[i] % 2 != 0 || a[i] == 0)
                {
                    break;
                }
                else
                {
                    n2a++;
                    a[i] = a[i] / 2;
                }
            }
        }
        // cout << n2a << endl;
        int m = n - n2a;
        if (m <= 0)
        {
            cout << 0 << endl;
        }
        else
        {
            int ans = 0;
            vector<int> pow2i;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                int k = i;
                while (true)
                {
                    if (k % 2 != 0)
                    {
                        break;
                    }
                    else
                    {
                        count++;
                        k = k / 2;
                    }
                }
                pow2i.push_back(count);
            }
            // for (int x : pow2i)
            // {
            //     cout << x << " ";
            // }
            sort(pow2i, pow2i.size());
            while (true)
            {
                if (m <= 0)
                {
                    break;
                }
                else
                {
                    m = m - pow2i[pow2i.size() - 1];
                    pow2i.pop_back();
                    ans++;
                    if (pow2i.size() == 0)
                    {
                        break;
                    }
                }
            }
            if (m > 0)
            {
                cout << -1 << endl;
            }
            else
            {
                cout << ans << endl;
            }
        }
    }
    return 0;
}