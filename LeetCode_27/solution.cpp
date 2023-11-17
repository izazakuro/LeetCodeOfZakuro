#include<iostream>
#include<vector>

using namespace std;

class Solution {
public:
    int removeElement(vector<int>& nums, int val) {
        nums.erase(remove(nums.begin(), nums.end(), val), nums.end());

        return nums.size();
    }
};

/*
解题思路：使用erase-remove方法 erase(Iterator begin, Iterator end)接收两个迭代器 
std::remove 函数：

    remove(ForwardIterator first, ForwardIterator last, const T& value)：
        first 和 last 是定义序列范围的迭代器。first 是范围的开始，last 是范围的结束。
        value 是要从序列中移除的元素的值。

std::remove 函数遍历由 first 和 last 定义的范围，移除所有等于 value 的元素。重要的是要理解，
这个函数实际上并不改变容器的大小；它只是将不需要的元素移到容器的末尾，并返回一个指向新逻辑末尾的迭代器。
*/