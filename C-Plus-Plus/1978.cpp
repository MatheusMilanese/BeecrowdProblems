#include <bits/stdc++.h>

using namespace std;

#define FASTIO ios_base::sync_with_stdio(false);cin.tie(NULL);

int main(){ FASTIO

    int n, l, a;

    cin >> n >> l >> a;
    int x, r;
    while(n){
        vector<pair<int, int>> v;

        cin >> n >> l >> a;

        for(int i = 0; i < n; i++){
            cin >> x >> r;
            v.push_back({max(0, x-r), min(l, x+r)});
        }

        sort(v.begin(), v.end());

        int ans = 0;
        int k = 0;
        if(v[0].first > 0){
            cout << "Tera que comprar mais cameras.\n";
        }
        for(int i = 0; i < n; i ++){

            if(v[i].first <= k) continue;
            else{
                i--;
                ans++;
                k = v[i].second;
                if(k == l) break;
            }
        }

        if(k == l) cout << ans << endl;
        else cout << "Tera que comprar mais cameras.\n";
        cin >> n >> l >> a;
    }

    return 0;
}