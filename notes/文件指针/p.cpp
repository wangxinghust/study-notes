#include <iostream>
#include <fstream>
using namespace std;
int main() {
	char name[20];
	double price;
	ifstream fin;
	fin.open("price.dat", ios::binary);
	for (size_t i = 0; i < 2; i++)
	{
		fin.read(name, 7);
		fin.read((char*)& price, 8);
		cout << name << "," << price << endl;
	}
	fin.seekg(-15, ios::end);//���ļ�β��ǰ�������أ��ƶ�1�У�1����15���ֽڣ�
	fin.read(name, 7);
	fin.read((char*)& price, 8);//�ض����һ������
	cout << name << "," << price << endl;
	fin.close();
	return 0;
}