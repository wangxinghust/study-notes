#include <iostream>
#include <iomanip>
#include <fstream>

int main(int argc, char* argv[]) {
	const char* name[] = { "�ֵ�Ͳ","���" };
	double price[] = { 75.825,4.1 };
	int n;
	std::cout << "��Ʒ���� ����\n" << std::setiosflags(std::ios::left);
	for (n = 0; n < 2; n++) {
		std::cout << std::setw(8) << name[n]; std::cout << " ";
		std::cout << std::setw(6) << price[n]; std::cout << std::endl;
	}

	std::ofstream fout;
	fout.open("price.dat", std::ios::binary);//�Զ�����ģʽ���ļ�"price.dat" ������������Զ�����
	char str[7];
	for (n = 0; n < 2; n++) {
		strcpy_s(str, name[n]);
		fout.write(str, sizeof(str));//�����Ʒ����
		fout.write((char*)& price[n], sizeof(double));
	}
	fout.close();//�ر����򿪵��ļ�"price.dat"
	return 0;
}