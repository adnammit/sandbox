#include "table.h"
using namespace std;

int main() {
  table BST;

  // BUILD OUR TABLE:
  BST.insert(52);
  BST.insert(26);
  BST.insert(78);
  BST.insert(12);
  BST.insert(47);
  BST.insert(68);
  BST.insert(84);
  BST.insert(8);
  BST.insert(20);
  BST.insert(56);
  BST.insert(70);
  BST.insert(81);
  BST.insert(99);
  BST.insert(1);
  BST.insert(18);
  BST.insert(24);
  BST.insert(5);
  BST.insert(25);
  BST.insert(76);

  // DO SOME THINGS TO OUR TABLE:
  BST.display();
  BST.countLeaves();
  BST.countNodes();






  // cout << "Count: " << BST.count() << endl;
  // cout << "Height: " << BST.height() << endl;
  // table BST_new;
  // BST_new.copy(BST);
  // BST_new.display();
  // cout << "Sum: " << BST.sum() << endl;
  // cout << "\nNOW WE ERASE THE NEW ONE:\n";
  // BST_new.remove_all();
  // BST_new.display(0);
  //
  // BST.display(0);

  return 0;
}
