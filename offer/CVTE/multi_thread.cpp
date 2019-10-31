#include <iostream>
#include <thread>
#include <condition_variable>
#include <vector>
#include <algorithm>
#include <functional>

std::mutex mtx;
std::condition_variable cvar;
char g_ch = 0;

void print_fun(char ch) {
	int cycle_cnt = 10;
	char ch_ = ch - 'A';

	for (int i = 0; i < cycle_cnt; i++) {
		std::unique_lock<std::mutex> ulk(mtx);
		cvar.wait(ulk, [ch_] {return ch_ == g_ch; });
		std::cout << (char)(ch_ + 'A');
		g_ch = (ch_ + 1) % 3;
		ulk.unlock();

		cvar.notify_all();
	}
}

int main() {
	std::vector<std::thread> threads;
	threads.push_back(std::thread(print_fun, 'A'));
	threads.push_back(std::thread(print_fun, 'B'));
	threads.push_back(std::thread(print_fun, 'C'));

	//std::for_each(threads.begin(), threads.end(), std::mem_fn(&std::thread::join));
	// 与下面代码等效
	for (int i = 0; i < 3; i++) {
		threads[i].join();
	}

	std::cout << std::endl;
	system("pause");
	return 0;
}