#include<iostream>
#include<vector>

using namespace std;

class Solution {
public:
    int removeDuplicates(vector<int>& nums) {

        int n = nums.size();
        if(n <= 2){
            return n ;
        }

        int fast = 2;
        int slow = 2;

        while(fast < n){
            
            if(nums[fast] != nums[slow - 2]){

                nums[slow] = nums[fast];
                slow ++;

            }
            fast ++ ;

        }

        return slow;

    }
};

/*
使用fast和slow双指针，slow - 2类似于一个虚拟指针，因为是有序连续的数组，所以slow-2保证了在fast前进后的区间内(3个数)不会出现连续的三个同样的元素
*/