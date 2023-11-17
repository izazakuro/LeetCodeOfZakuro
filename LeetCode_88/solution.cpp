#include<iostream>>
#include<algorithm>>
#include<vector>

using namespace std;


class Solution {
public:
    void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
        int a = m + n;
        int b = 0;

        for(int i = m ; i < a ; i ++){
            nums1[i] = nums2[b];
            b ++;
        }
        sort(nums1.begin(), nums1.end());
    }
};