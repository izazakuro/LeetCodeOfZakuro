#include<iostream>
#include<vector>

using namespace std;

class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int j;
        j = 0;
        for(int i = 0 ; j < nums.size() - 1 ; i ++){
            if(nums[j] == nums[j + 1]){
                nums.erase(nums.begin() + j);
            }else{
                j++;
            }
        }
        return nums.size();
    }
};