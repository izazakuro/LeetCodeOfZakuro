#include<iostream>
#include<string>
#include<vector>

using namespace std;

class Solution {
public:
    vector<string>  res;
    vector<string> generateParenthesis(int n){
        dfs(n, 0 , 0 , "");
        return res;
    }


    void dfs (int n, int l, int r, string str){
        if(l == n && r == n) res.push_back(str);
        else{
            if(l < n) dfs(n, l + 1, r, str +"(");
            if(r < n && l > r) dfs(n, l, r + 1, str + ")");
        }
    }
};