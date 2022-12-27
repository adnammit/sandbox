// #include "sorter.h"
#include <iostream>
using namespace std;

// struct node {
//     int data;
//     node * right;
//     node * left;
// };

// struct bst_node {
//     int data;
//     bst_node * right;
//     bst_node * left;
// };
//
// struct lll_node {
//     int data;
//     lll_node * next;
// };
//
//
//
// class sorter {
// public:
//
//
// private:
//     bst_node * head;
// }


// void print_arr (int arr[]) {
//     cout << "Our array is: " << endl;
//     for (int x : arr) {
//         cout << x << " ";
//     }
//     cout << endl;
// }

// node * newNode(int val) {
//     node * temp = new node;
//     temp->data = val;
//     temp->left = NULL;
//     temp->right = NULL;
//     return temp;
// }
//
//
// void insert(node *& root, int val) {
//     if(!root) {
//         root = newNode(val);
//     } else {
//         if (val > root->data) {
//             insert(root->left, val);
//         } else {
//             insert(root->right, val);
//         }
//     }
//     // if(!root) {
//     //     root = new node;
//     //     root.data = val;
//     //     root.right =
//     // } else {
//     //     if (val > root.data) {
//     //         insert(root.left, val);
//     //     } else {
//     //         insert(root.right, val);
//     //     }
//     // }
//     return;
// }


struct node {
    int data;
    node * next;
};

class queue {
public:
    void push(int val) {
        curr = head;
        while(curr) {
            if(!curr) {
                curr = new node;
                curr.data = val;
            } else {
                curr = curr->next;
            }
        }
    }

    int pop() {

    }

    int peek() {

    }
    void print() {
        cout << "Here is our list:" << endl;
        curr = head;
        while(curr) {
            cout << curr->data << endl;
            curr = curr->next;
        }
    }
private:
    head * node;
};


int main() {
    queue list;
    int size = 6;
    int input;
    int arr[size] = { 5, 12, 6, 1, 20, 3 }; // declare the array and init values

    cout << "Our array is: " << endl;
    for (int x : arr) {
        cout << x << " ";
    }
    cout << endl;

    for (int y : arr) {
        list.push(y);
    }

    list.print();

    return 0;
}



// int main() {
//     node * root;
//     int size = 6;
//     int input;
//     // int arr[size];
//     // int arr[size] = { 1, 2, 3, 4, 5, 6 }; // declare the array and init values
//     int arr[size] = { 5, 12, 6, 1, 20, 3 }; // declare the array and init values
//     // int arr[size] = { 1, 2, 3, 4 }; // declare the array and init values, leaving two indices empty
//
//     // int n, m = 0; // only m is 0 -- n is null
//     // cout << "M is " << m << endl;
//     // cout << "N is " << n << endl;
//
//     // for (int i = 0; i < size; i++) {
//     //     cin >> input;
//     //     cin.clear();
//     //     arr[i] = input;
//     // }
//
//     // print_arr(arr);
//
//     cout << "Our array is: " << endl;
//     for (int x : arr) {
//         cout << x << " ";
//     }
//     cout << endl;
//
//
//     for (int y : arr) {
//         insert(root, y);
//     }
//     return 0;
// }
