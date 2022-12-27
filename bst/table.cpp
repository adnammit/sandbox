#include "table.h"
using namespace std;

table::table(void) {
  root = NULL;
}

table::~table(void) {
  destroy(root);
}

void table::destroy(node *& root) {
  if (root) {
    destroy(root->getLeft());
    destroy(root->getRight());
    delete root;
  }
  return;
}


//*****************************************************************************
// DISPLAY THE BST

void table::display(void) const {
  cout << "Here is our BST: " << endl;
  display(root);
  return;
}

void table::display(node * root) const {
  if (root) {
    display(root->getLeft());
    root->display();
    display(root->getRight());
  }
  return;
}


//*****************************************************************************
// INSERT A NEW NODE

void table::insert(int value) {
  insert(root, value);
}

void table::insert(node *& root, int value) {
    if (!root) {
    	root = new node(value);
      // cout << "inserting: " << root->getData() << endl;
    } else {
      if (value < root->getData()) {
        insert(root->getLeft(), value);
      } else {
        insert(root->getRight(), value);
      }
    }
    return;
}


//*****************************************************************************
// COUNT THE LEAVES OF THE BST

void table::countLeaves(void) const {
  cout << "We have " << countLeaves(root) << " leaves." << endl;
  return;
}

int table::countLeaves(node * root) const {
  if (!root) {
    return 0;
  }
  if (!root->getLeft() && !root->getRight()) return 1;
  int i = 0;
  i += countLeaves(root->getLeft());
  i += countLeaves(root->getRight());
  return i;
}


//*****************************************************************************
// COUNT THE NODES OF THE BST

void table::countNodes(void) const {
  cout << "We have " << countNodes(root) << " nodes." << endl;
  return;
}

int table::countNodes(node * root) const {
  if (!root)
    return 0;
  return countNodes(root->getLeft()) + countNodes(root->getRight()) + 1;
}


//*****************************************************************************
// COUNT THE LEAVES OF THE BST
//
// int table::height(void) const {
//   int height = 0;
//   if (root) {
//     height = height(root);
//   }
//   return height;
// }
//
// int table::height(node * root) const {
//   int height = 0;
//   // if we reach a leaf, return 1
//   if (!root->getLeft() && !root->getRight()) {
//     height = 0;
//   }
//   // otherwise look left and right and return the greatest height + 1
//   else if (!root->getLeft()) {
//     height = height(root->getRight());
//   }
//   else {
//     height = height(root->getLeft());
//   }
//   return height + 1;
// }
