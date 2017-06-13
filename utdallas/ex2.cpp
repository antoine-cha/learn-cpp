#include <iostream>
using namespace std;
int main(){
    char h;
    int n;
    float x;
    cout << "Input a single character" << endl;
    cin >> h;
    cout << "Input an integer" << endl;
    cin >> n;
    cout << "Input a float" << endl;
    cin >> x;
    cout << "The character " << h << " when cast to integer gives value " << int(h) << endl;
    cout << "The character " << h << " when cast to float gives value " << float(h) << endl;
    cout << "The integer " << n << " when cast to character gives value " << char(n) << endl;
    cout << "The integer " << n << " when cast to float gives value " << float(n) << endl;
    cout << "The float " << x << " when cast to character gives value " << char(x) << endl;
    cout << "The float " << x << " when cast to integer gives value " << int(x) << endl;
    return 0;
}