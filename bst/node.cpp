#include "table.h"
using namespace std;

node::node(void) {
  data = 0;
  left = NULL;
  right = NULL;
  return;
}

node::node(int value) {
  data = value;
  left = NULL;
  right = NULL;
}

node::~node(void) {
  left = right = NULL;
  data = 0;
  return;
}

node *& node::getLeft(void) {
  return left;
}

node *& node::getRight(void) {
  return right;
}

void node::setLeft(node *& connection) {
  left = connection;
  return;
}

void node::setRight(node *& connection) {
  right = connection;
  return;
}

void node::display(void) const {
  cout << data << endl;
  return;
}

int node::getData(void) const {
  return data;
}
