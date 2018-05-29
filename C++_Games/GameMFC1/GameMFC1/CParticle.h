#ifndef CPARTICLE_H
#define CPARTICLE_H

#include "stdafx.h"

//ѩ��������������
#define SNOWTYPE 7
//ѩ����С����
#define SNOWSIZE 32

//ѩ���ṹ��
typedef struct snow
{
	snow()
	{
		x = y = speed = number = 0;
	}
	float x; //ѩ��λ��
	float y;
	float speed; //ѩ���ٶ�
	int number; //ѩ��������
}Snow;

//ѩ����
class CParticle
{
private:
	int m_number; //ѩ������
	Snow *m_pSnow; //ѩ��
	CImage m_snowMap[SNOWTYPE]; //ѩ�����༯��

public:
	CParticle(int number);
	~CParticle();

public:
	void Init(); //��ʼ������
	void Draw(CDC &cDC); //��������
	void Update(float time); //��������
	void TransparentPNG(CImage *png); //��ͼ͸����
};

#endif