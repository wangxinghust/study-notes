// 使用结构体数组
typedef struct {
	char name[9];
	float score;
}Student;

// 链表
typedef struct tagStudent {
	char name[9];
	float score;
	struct tagStudent* prev, * next; // 定义前向指针prev和后向指针next
}Student;

// 容器(Container)类 迭代器(Iterator)