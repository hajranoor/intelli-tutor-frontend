
			#include <iostream>
using namespace std;
	int table(int a = 2) {
int  i, res;
    for(i=1; i<=5; i++)
    {
        res = a*i;
        cout<<a<<"* "<<i<<" = "<<res;
        cout<<endl;
    }
    cout<<endl;
	}
	int main() {
    table();
    return 0;
	}