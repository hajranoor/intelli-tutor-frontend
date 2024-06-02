#include <iostream>
using namespace std;
int add(int a = 2, int b = 3) {
int result;
result = a + b;
cout<<result;
}
int main() {
    add();
    return 0;
}