#include "stdafx.h"
#include "CParticle.h"

CParticle::CParticle(int number)
{
	m_number = number;
	m_pSnow = new Snow[number];
}

CParticle::~CParticle()
{
	if (m_pSnow != NULL)
	{
		delete[] m_pSnow;
	}
	for (int i = 0; i < SNOWTYPE; ++ i)
	{
		m_snowMap[i].Destroy();
	}
}

//初始化粒子
void CParticle::Init()
{
	//加载粒子系统-雪花
	char buf[25] = "";
	for (int i = 0; i < SNOWTYPE; ++ i)
	{
		sprintf_s(buf,"../Images/Snow/%d.png",i);
		m_snowMap[i].Load(buf);
		TransparentPNG(&m_snowMap[i]);
	}
	//初始化雪花系统
	for (int i = 0; i < m_number; ++ i)
	{
		m_pSnow[i].x = rand() % (2*WINDOW_WIDTH);
		m_pSnow[i].y = rand() % (2*WINDOW_HEIGHT);
		m_pSnow[i].speed = (rand() % 7 + 1) / 50.0;
		m_pSnow[i].number = rand() % SNOWTYPE;
	}
}

//绘制粒子
void CParticle::Draw(CDC &cDC)
{
	//绘制雪花系统
	for (int i = 0; i < m_number; ++ i)
	{
		m_snowMap[m_pSnow[i].number].Draw(cDC,m_pSnow[i].x,m_pSnow[i].y,SNOWSIZE,SNOWSIZE);
	}
}

//更新粒子
void CParticle::Update(float time)
{
	//更新雪花系统
	for (int i = 0; i < m_number; ++ i)
	{
		m_pSnow[i].y += m_pSnow[i].speed * time;

		if (m_pSnow[i].y > WINDOW_HEIGHT)
		{
			m_pSnow[i].y = -SNOWSIZE;
		}
	}
}

//将png贴图透明化
void CParticle::TransparentPNG(CImage *png)  
{  
	for(int i = 0; i < png->GetWidth(); ++ i)  
	{  
		for(int j = 0; j < png->GetHeight(); ++ j)  
		{  
			unsigned char* pucColor = reinterpret_cast<unsigned char*>(png->GetPixelAddress(i , j));  
			pucColor[0] *= pucColor[3] / 255;
			pucColor[1] *= pucColor[3] / 255;
			pucColor[2] *= pucColor[3] / 255;
		}  
	}  
}  