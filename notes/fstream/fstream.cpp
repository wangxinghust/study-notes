#include <fstream>
#include <iostream>
#include <iomanip>

int main(int argc, char* argv[]) {
	const char* name[] = { "shoudiantong","dianchi" };
	double price[] = { 75.825,4.1 };
	int n;
	//ʹ����ʾ������cout�������������ʾ��
	std::cout << "�� Ʒ �� ��    �� ��\n" << std::setiosflags(std::ios::left);
	for (n = 0; n < 2; n++) {
		std::cout << std::setw(13) << name[n]; std::cout << "  ";
		std::cout << std::setw(10) << price[n]; std::cout << std::endl;
	}
	//ʹ���ļ��������ofstream���ļ�����fout������������ı��ļ�"price.txt"
	std::ofstream fout;
	fout.open("price.txt");//���ļ�"price.txt"�����ļ��������򴴽����ļ�
	fout << "�� Ʒ �� ��    �� ��\n" << std::setiosflags(std::ios::left);//������
	for (n = 0; n < 2; n++) {
		fout << std::setw(13) << name[n]; fout << "  ";
		fout << std::setw(6) << price[n]; fout << std::endl;
	}//ʵ��txt�༭�����޷����룬vs���������
	fout.close();
	return 0;
}