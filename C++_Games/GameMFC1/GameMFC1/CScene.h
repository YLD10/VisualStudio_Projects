//场景类

#ifndef CSCENE_H
#define CSCENE_H

#include "stdafx.h"

#define XSCENE 10
#define YSCENE 5
#define FOGSIZE 128
#define SCENESIZE 16

//迷雾结构体
typedef struct fog
{
	fog()
	{
		f = visited = 0;
	}
	int f;
	int visited;
}Fog;

//迷雾类
class CScene
{
private:
	int m_mode; //迷雾模式
	CImage m_black[2]; //战争迷雾
	Fog m_fogArray[XSCENE][YSCENE]; //迷雾数组
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