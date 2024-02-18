#include <iostream>
using namespace std;
void calculateFactorial(int n = 7)
{
    int factorial = 1;
for (int i = 1; i <=n; i++)
    {
        factorial *= i;
    }
    std::cout << factorial << std::endl;
}
int main() {
    calculateFactorial();
}