//������

#ifndef CSCENE_H
#define CSCENE_H

#include "stdafx.h"

#define XSCENE 10
#define YSCENE 5
#define FOGSIZE 128
#define SCENESIZE 16

//����ṹ��
typedef struct fog
{
	fog()
	{
		f = visited = 0;
	}
	int f;
	int visited;
}Fog;

//������
class CScene
{
private:
	int m_mode; //����ģʽ
	CImage m_black[2]; //ս������
	Fog m_fogArray[XSCENE][YSCENE]; //��������
public:
	CScene();
	~CScene();
public:
	void Add(int i, int j, int num);
	void DrawFog(CDC &cDC);
	void ChangeMode();
	bool CheckFog(int xMouse, int yMouse);
	void UpdateFogArea(int x, int y);
};

#endif