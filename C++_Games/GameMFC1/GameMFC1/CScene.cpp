//�������ʵ��

#include "stdafx.h"
#include "CScene.h"

CScene::CScene()
{
	m_mode = 0;
	m_black[0].Load("../Images/fog.png");
	m_black[1].Load("../Images/fog2.png");
}

CScene::~CScene()
{
	m_black[0].Destroy();
	m_black[1].Destroy();
}

//�����ص����ֵ
void CScene::Add(int i, int j, int num)
{
	if (CheckFog(i,j))
	{
		m_fogArray[i][j].f += num;
		if (m_fogArray[i][j].f > 15)
		{
			m_fogArray[i][j].f = 15;
		}
	}
}

//����ս������
void CScene::DrawFog(CDC &cDC)
{
	for (int i = 0; i < XSCENE; ++ i)
	{
		for (int j = 0; j < YSCENE; ++ j)
		{
			if (m_fogArray[i][j].f < 15)
			{
				m_black[m_mode].Draw(cDC,i*FOGSIZE,j*FOGSIZE,FOGSIZE,FOGSIZE,
					(m_fogArray[i][j].f/4)*FOGSIZE,(m_fogArray[i][j].f%4)*FOGSIZE,FOGSIZE,FOGSIZE);
			}
		}
	}
}

//�ı�����ģʽ
void CScene::ChangeMode()
{
	m_mode ^= 1;
}

//�������Χ
bool CScene::CheckFog(int xMouse, int yMouse)
{
	if (xMouse >= 0 && xMouse < XSCENE && yMouse >= 0 && yMouse < YSCENE)
	{
		return true;
	} 
	else
	{
		return false;
	}
}

//��������Χ
void CScene::UpdateFogArea(int x, int y)
{
	//����������ڵĸ���
	int xMouse = x / FOGSIZE, yMouse = y / FOGSIZE;

	//����ɼ���Χ
	if (m_fogArray[xMouse][yMouse].visited == 0)
	{
		//����+4������+8������+1������+2
		Add(xMouse,yMouse,4);
		Add(xMouse+1,yMouse,8);
		Add(xMouse,yMouse+1,1);
		Add(xMouse+1,yMouse+1,2);
		//����Ѿ������
		m_fogArray[xMouse][yMouse].visited = 1;
	}
}