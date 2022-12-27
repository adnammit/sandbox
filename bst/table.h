
#include <iostream>
#include <cstring>
#include <cctype>
#include <cstdlib>

class node {
public:
  node(void);
  node(int);
  ~node(void);
  node*&getLeft(void);
  node*&getRight(void);
  void setLeft(node*&);
  void setRight(node*&);
  void display(void) const;
  int getData(void) const;

protected:
  int data;
  node * left;
  node * right;
};

class table {

public:
  table(void);
  ~table(void);
  void display(void) const;
  void insert(int);
  void countLeaves(void) const;
  void countNodes(void) const;
  int height(void) const;


private:
  node * root;
  void destroy(node*&);
  void display(node*) const;
  void insert(node*&,int);
  int countLeaves(node*) const;
  int countNodes(node*) const;
  int height(node*) const;

  //  ***These are the functions you will be writing recursively!
  // int copy (node * & destination, node * source);	//STEP 1.3
  // int sum (node * root);		//STEP 1.4


};
