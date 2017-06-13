#include <iostream>

using namespace std;

int main(){
    string h = "Cisbest";
    int offset = h.size() * 2; 
    string spaces_before(offset, ' ');
    cout << spaces_before << h[0] << endl;
    for(string::size_type i=1; i < h.size() - 1; i++){
        string spaces_before(offset-2*i, ' ');
        string spaces_after(4*i-1, ' ');
        cout << spaces_before << h[i] << spaces_after << h[i] << endl;
    }
    cout << "  ";
    for(string::size_type i=0; i < h.size(); i++){
        cout << h[i] << " ";
    }
    for(string::size_type i=h.size()-1; i > 0; i--){
        cout << h[i-1] << " ";
    }
    cout << endl;
    return 0;
}