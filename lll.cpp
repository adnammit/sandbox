// PRACTICING RECURSION WITH A LINEAR LINKED LIST:


#include <iostream>
using namespace std;


struct node {
    int data;
    node * next;
};

void append(node *& head, int value) {
    if (!head){
	head = new node;
	head->data = value;
	head->next = NULL;
    }
    else {
	append(head->next, value);
    }
}

void copy(node*&dest, node*source) {
    if (!source) {
	dest = NULL;
    }
    else {
	dest = new node;
	dest->data = source->data;
	copy(dest->next, source->next);
    }
}

void display (node*head) {
    if (!head) return;
    cout << head->data << endl;
    display(head->next);
}



int main() {
    node * head;
    for (int i=0; i<15; i++) {
	append(head, i);
    }
    cout << "Here is our first linked list:" << endl;
    display(head);
    cout << "Now we will copy a new list from the old one:" << endl;
    node * head2;
    copy(head2, head);
    display(head2);
    return 0;
}


