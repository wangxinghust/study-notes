// ʹ�ýṹ������
typedef struct {
	char name[9];
	float score;
}Student;

// ����
typedef struct tagStudent {
	char name[9];
	float score;
	struct tagStudent* prev, * next; // ����ǰ��ָ��prev�ͺ���ָ��next
}Student;

// ����(Container)�� ������(Iterator)