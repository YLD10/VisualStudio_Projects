#ifndef CPARTICLE_H
#define CPARTICLE_H

#include "stdafx.h"

//雪花种类数量定义
#define SNOWTYPE 7
//雪花大小定义
#define SNOWSIZE 32

//雪花结构体
typedef struct snow
{
	snow()
	{
		x = y = speed = number = 0;
	}
	float x; //雪花位置
	float y;
	float speed; //雪花速度
	int number; //雪花种类编号
}Snow;

//雪花类
class CParticle
{
private:
	int m_number; //雪花数量
	Snow *m_pSnow; //雪花
	CImage m_snowMap[SNOWTYPE]; //雪花种类集合

public:
	CParticle(int number);
	~CParticle();

public:
	void Init(); //初始化粒子
	void Draw(CDC &cDC); //绘制粒子
	void Update(float time); //更新粒子
	void TransparentPNG(CImage *png); //贴图透明化
};

#endif