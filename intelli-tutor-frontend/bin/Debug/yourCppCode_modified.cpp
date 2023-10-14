#include <iostream>

// Function to calculate factorial
unsigned long long calculateFactorial(int n = 3) {
    if (n <= 1) {
        return 1; // Base case: factorial of 0 and 1 is 1
    } else {
        return n * calculateFactorial(n - 1); // Recursive case
    }
}


int main() {
    
    if (num < 0) {
        std::cout << "Factorial is not defined for negative numbers." << std::endl;
    } else {
        unsigned long long factorial = calculateFactorial();
        std::cout << "Factorial of " << num << " is " << factorial << std::endl;
    }

    return 0;
}



