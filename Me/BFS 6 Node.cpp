//Referensi Ini Berasal Dari Luar
//Aku Tidak Menghilangkan Semua Notif Untuk Sistem Pengisian dan Methodenya 
#include<iostream>
#include<queue>
#define NODE 6
#include <conio.h>
char nilai;
using namespace std;
class node {
   public:
      int val;
      int state; //status
};
int graph[NODE][NODE] = {
   {0, 1, 1, 1, 0, 0},
   {1, 0, 0, 1, 1, 0},
   {1, 0, 0, 1, 0, 1},
   {1, 1, 1, 0, 1, 1},
   {0, 1, 0, 1, 0, 1},
   {0, 0, 1, 1, 1, 0}
};
void bfs(node *vert, node s) {
   node u;
   int i, j;
   queue<node> que;
   for(i = 0; i<NODE; i++) {
      vert[i].state = 0; //not visited
   }
   vert[s.val].state = 1;//visited
   que.push(s); //insert starting node
   while(!que.empty()) {
      u = que.front(); //delete from queue and print
      que.pop();
      cout << char(u.val+nilai) << " ";
      for(i = 0; i<NODE; i++) {
         if(graph[i][u.val]) {
            //when the node is non-visited
            if(vert[i].state == 0) {
               vert[i].state = 1;
               que.push(vert[i]);
            }
         }
      }
      u.state = 2;//completed for node u
   }
}
int main() {
   cout <<"BFS Traversal dengan Input Type_Data Char"<<endl;
   cout <<"======== Dengan Jumlah Node 6 ===========" <<endl;
   cout <<""<<endl;
   cout <<"*****************************************"<<endl;
   cout <<"  *Inputan Bisa Berupa Huruf dan Nilai*  "<<endl;
   cout <<"*****************************************"<<endl;
   cout <<""<<endl;
   cout<<"Masukan Inputan = ";cin>>nilai;
   node vertices[NODE];
   node start;
   char s;
   for(int i = 0; i<NODE; i++) {
      vertices[i].val = i;
   }
   s = 'B';//starting vertex B
   start.val = s-'A';
   cout << "BFS Traversal: ";
   bfs(vertices, start);
   //cout << endl;
   getch();
}
