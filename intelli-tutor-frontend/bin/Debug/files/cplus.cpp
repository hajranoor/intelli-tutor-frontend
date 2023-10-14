#include <iostream>
	int add(int a = 2, int b = 3) {
            std::cout << a * b<< std::endl;
	}
	int main() {
    add();
    return 0;
	}