#include <stdio.h>
#include <stdlib.h>

int max(int a, int b){
    return a > b ? a : b;
}

int comp(const void *a, const void *b){
    return ( *(int*)a - *(int*)b );
}

int main(){
    int t, index = 1;
    scanf("%d", &t);
    while(t--){
        int n; 
        scanf("%d", &n);
        int v[n];
        for(int i = 0; i < n; i++) scanf("%d", &v[i]);
        
        qsort(v, n, sizeof(int), comp);

        //caso1
        int p1[n];
        int j = 0;
        for(int k = 1; k < n-1; k += 2) p1[k] = v[j++];
        p1[n-1] = v[j++];
        p1[0] = v[j++];

        for(int k = 2; j < n; k += 2) p1[k] = v[j++];

        int ans1 = 0;
        for(int i = 0; i < n-1; i++) ans1 += abs(p1[i]-p1[i+1]);

        //caso2
        int p2[n];
        j = n-1;
        for(int k = 1; k < n-1; k += 2) p2[k] = v[j--];
        p2[n-1] = v[j--];
        p2[0] = v[j--];
        for(int k = 2; j >= 0; k += 2) p2[k] = v[j--];

        int ans2 = 0;
        for(int i = 0; i < n-1; i++) ans2 += abs(p2[i]-p2[i+1]);
        
        printf("Case %d: %d\n", index++, max(ans1, ans2));
    }
}