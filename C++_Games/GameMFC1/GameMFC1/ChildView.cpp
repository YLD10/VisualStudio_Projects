
// ChildView.cpp : CChildView 类的实现
//

#include "stdafx.h"
#include "GameMFC1.h"
#include "ChildView.h"
#include "mmsystem.h" //导入媒体控制头文件
#include <math.h>


#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// CChildView

CChildView::CChildView()
{
}

CChildView::~CChildView()
{
	mciSendString("stop bgMusic",NULL,0,NULL);
	if (m_snow != NULL)
	{
		delete m_snow;
		m_snow = NULL;
	}
	if (m_scene != NULL)
	{
		//delete m_scene;
		m_scene = NULL;
	}
	m_bg.Destroy();
	m_bgBlack.Destroy();
}


BEGIN_MESSAGE_MAP(CChildView, CWnd)
	ON_WM_PAINT()
	ON_WM_KEYDOWN()
	ON_WM_LBUTTONDOWN()
	ON_WM_TIMER()
	ON_WM_CREATE()
	ON_WM_MOUSEMOVE()
END_MESSAGE_MAP()



// CChildView 消息处理程序
BOOL CChildView::PreCreateWindow(CREATESTRUCT& cs) 
{
	if (!CWnd::PreCreateWindow(cs))
		return FALSE;

	cs.dwExStyle |= WS_EX_CLIENTEDGE;
	cs.style &= ~WS_BORDER;
	cs.lpszClass = AfxRegisterWndClass(CS_HREDRAW|CS_VREDRAW|CS_DBLCLKS, 
		::LoadCursor(NULL, IDC_ARROW), reinterpret_cast<HBRUSH>(COLOR_WINDOW+1), NULL);

	/************************************************************************/
	/* 数据初始化                                                            */
	/************************************************************************/
	//加载背景蒙版图
	//m_bgBlack.Load("../Images/bgBlack.png");
	//加载背景和英雄
	m_bg.Load("../Images/bg.png");
	MyHero.character.Load("../Images/hero.png");
	TransparentPNG(&MyHero.character);
	//加载怪物
	//Monster.character.Load("../Images/monster.png");
	//TransparentPNG(&Monster.character);

	//初始化雪花系统
	m_snow = new CParticle(100);
	m_snow->Init();

	//初始化迷雾
	m_scene = new CScene();

	//初始化英雄状态
	MyHero.direct = UP;
	MyHero.frame = 0;
	MyHero.width = HEROSIZE;
	MyHero.height = HEROSIZE;
	MyHero.speed = 0.2;
	//初始化怪物状态
	//Monster.direct = LEFT;
	//Monster.frame = 0;
	//Monster.width = MONSTERSIZE;
	//Monster.height = MONSTERSIZE;
	//Monster.speed = 0.15;
	//设置英雄初始位置
	MyHero.x = 100;
	MyHero.y = 400;
	//设置怪物初始位置
	//Monster.x = 700;
	//Monster.y = 100;

	//初始化地图参数
	m_bgWidth = m_mapWidth = m_bg.GetWidth();
	m_mapCount = 1;

	//打开背景音乐
	mciSendString("open ../Musics/background.mp3 alias bgMusic",NULL,0,NULL);
	mciSendString("play bgMusic repeat",NULL,0,NULL);

	return TRUE;
}

//绘制函数
void CChildView::OnPaint() 
{
	CPaintDC dc(this); // 用于绘制的设备上下文

	static float lastTime = timeGetTime();
	static float currentTime = timeGetTime();

	{
		//CBitmap进行贴图
		/*CDC *cDC = this->GetDC(), m_bgcDC;
		GetClientRect(&m_client);

		m_bgcDC.CreateCompatibleDC(NULL);

		CBitmap m_bgBitmap;
		m_bgBitmap.LoadBitmap(bgImage);

		m_bgcDC.SelectObject(&m_bgBitmap);

		cDC->BitBlt(0,0,m_client.Width(),m_client.Height(),&m_bgcDC,0,0,SRCCOPY);*/

		//CImage进行贴图
		/*m_hero.Load("../Images/hero.png");
		TransparentPNG(&m_hero);
		m_hero.Draw(*cDC,100,400,60,60);*/
	}
	
	//获取窗口DC指针
	CDC *cDC = this->GetDC();
	//获取窗口大小
	GetClientRect(&m_client);
	//创建缓冲DC
	m_cacheDC.CreateCompatibleDC(NULL);
	m_cacheCBitmap.CreateCompatibleBitmap(cDC,m_client.Width(),m_client.Height());
	m_cacheDC.SelectObject(m_cacheCBitmap);

	/************************************************************************/
	/* 开始绘制                                                             */
	/************************************************************************/

	//计算地图重复次数
	//GetMapCount();
	//重新计算地图总长度
	//m_mapWidth = m_bgWidth * m_mapCount;

	//for (int i = 0; i < 2; ++ i)
	//{
	//	//贴背景蒙版图
	//	m_bgBlack.Draw(m_cacheDC,m_bgWidth*i,0,WINDOW_WIDTH,WINDOW_HEIGHT,0,0,WINDOW_WIDTH,WINDOW_HEIGHT);
		//贴背景
		m_bg.Draw(m_cacheDC,0,0,WINDOW_WIDTH,WINDOW_HEIGHT,0,0,WINDOW_WIDTH,WINDOW_HEIGHT);
	//}

	//贴英雄和怪物
	MyHero.character.Draw(m_cacheDC,GetScreenX(MyHero.x,m_mapWidth),MyHero.y,HEROSIZE,HEROSIZE,
		MyHero.frame*HEROSIZE,MyHero.direct*HEROSIZE,HEROSIZE,HEROSIZE);
	//Monster.character.Draw(m_cacheDC,GetScreenX(Monster.x),Monster.y,MONSTERSIZE,MONSTERSIZE,
		//Monster.frame*MONSTERSIZE,Monster.direct*MONSTERSIZE,MONSTERSIZE,MONSTERSIZE);

	//贴雪花
	m_snow->Draw(m_cacheDC);
	//更新雪花
	currentTime = timeGetTime();
	m_snow->Update(currentTime-lastTime);
	lastTime = currentTime;

	//绘制战争迷雾
	m_scene->DrawFog(m_cacheDC);

	//计算人物坐标中心
	//MyHero.Xcenter = MyHero.x + MyHero.width/2;
	//MyHero.Ycenter = MyHero.y + MyHero.height/2;
	//Monster.Xcenter = Monster.x + Monster.width/2;
	//Monster.Ycenter = Monster.y + Monster.height/2;

	//设置文字背景透明
	//m_cacheDC.SetBkMode(TRANSPARENT);
	//设置文字颜色红色
	//m_cacheDC.SetTextColor(RGB(255,0,0));

	//判断碰撞
	//IsCollide();

	//缓冲DC输出
	cDC->BitBlt(0,0,m_client.Width(),m_client.Height(),&m_cacheDC,GetMapStartX(),0,SRCCOPY);

	//绘制完图后，使窗口有效
	ValidateRect(&m_client);
	//释放缓冲DC
	m_cacheDC.DeleteDC();
	//释放对象
	m_cacheCBitmap.DeleteObject();
	//释放DC
	ReleaseDC(cDC);
}

//将png贴图透明化
void CChildView::TransparentPNG(CImage *png)  
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

//获取英雄在屏幕上的坐标
int CChildView::GetScreenX(int xHero, int mapWidth)
{
	if (xHero > WINDOW_WIDTH/2 && xHero <= mapWidth-WINDOW_WIDTH/2)
	{
		return WINDOW_WIDTH/2 + (xHero-WINDOW_WIDTH/2) % WINDOW_WIDTH;
	}
	else
	{
		return xHero;
	}
}

//获取怪物在屏幕上的坐标
int CChildView::GetScreenX(int xMonster)
{
	if (MyHero.x < WINDOW_WIDTH*1.5)
	{
		return xMonster;
	}
	else if (((int)(MyHero.x-WINDOW_WIDTH/2)%WINDOW_WIDTH) == 0)
	{
		return xMonster - m_mapWidth + WINDOW_WIDTH;
	}
	else
	{
		return xMonster - WINDOW_WIDTH * (m_mapCount-2);
	}
}

//判断碰撞函数
void CChildView::IsCollide()
{
	if (Monster.Xcenter < MyHero.Xcenter+(MyHero.width/2+Monster.width/2) &&
		Monster.Xcenter > MyHero.Xcenter-(MyHero.width/2+Monster.width/2) &&
		Monster.Ycenter < MyHero.Ycenter+(MyHero.height/2+Monster.height/2) &&
		Monster.Ycenter > MyHero.Ycenter-(MyHero.height/2+Monster.height/2))
	{
		m_cacheDC.TextOut(GetTextStartX(),0,"发生碰撞");
	} 
	else
	{
		m_cacheDC.TextOut(GetTextStartX(),0,"没有碰撞");
	}

	char buf[50] = "";
	sprintf_s(buf,"怪物与英雄距离：%d 米",(int)(0.025*sqrtf((MyHero.Xcenter-Monster.Xcenter)*
		(MyHero.Xcenter-Monster.Xcenter)+(MyHero.Ycenter-Monster.Ycenter)*(MyHero.Ycenter-Monster.Ycenter))));
	m_cacheDC.TextOut(GetTextStartX(),20,buf);
}

//判断通行函数
bool CChildView::IsCanPass(int direct)
{
	return true;
	int i = 0, j = 0, k = 0, iOld = 0, toplimit = 0;
	switch (direct)
	{
	case UP:
		{
			iOld = MyHero.x;
			j = MyHero.y;
			toplimit = MyHero.x + MyHero.width;
			if (iOld >= m_bgWidth)
			{
				iOld %= m_bgWidth;
				toplimit = iOld + MyHero.width;
			}
		}
		break;
	case DOWN:
		{
			iOld = MyHero.x;
			j = MyHero.y + MyHero.height;
			toplimit = MyHero.x + MyHero.width;
			if (iOld >= m_bgWidth)
			{
				iOld %= m_bgWidth;
				toplimit = iOld + MyHero.width;
			}
		}
		break;
	case LEFT:
		{
			iOld = MyHero.y;
			j = MyHero.x;
			toplimit = MyHero.y + MyHero.height;
			if (j >= m_bgWidth)
			{
				j %= m_bgWidth;
			}
		}
		break;
	case RIGHT:
		{
			iOld = MyHero.y;
			j = MyHero.x + MyHero.width;
			toplimit = MyHero.y + MyHero.height;
			if (j >= m_bgWidth)
			{
				j %= m_bgWidth;
			}
		}
		break;
	}

	switch(direct)
	{
	case UP:
		{
			for (; k < 10; ++ k)
			{
				-- j;
				if (j >= 0)
				{
					int toplimitCopy = toplimit;
					for (i = iOld; i < toplimit; ++ i)
					{
						if (i >= m_bgWidth)
						{
							i = 0;
							toplimit -= m_bgWidth;
						}
						if (m_bgBlack.GetPixel(i,j) == RGB(0,0,0))
						{
							return false;
						}
					}
					toplimit = toplimitCopy;
				}
				else
				{
					break;
				}
			}
		}
		break;
	case DOWN:
		{
			for (; k < 10; ++ k)
			{
				++ j;
				if (j < WINDOW_HEIGHT)
				{
					int toplimitCopy = toplimit;
					for (i = iOld; i < toplimit; ++ i)
					{
						if (i >= m_bgWidth)
						{
							i = 0;
							toplimit -= m_bgWidth;
						}
						if (m_bgBlack.GetPixel(i,j) == RGB(0,0,0))
						{
							return false;
						}
					}
					toplimit = toplimitCopy;
				}
				else
				{
					break;
				}
			}
		}
		break;
	case LEFT:
		{
			for (; k < 10; ++ k)
			{
				-- j;
				if (j >= 0)
				{
					for (i = iOld; i < toplimit; ++ i)
					{
						if (m_bgBlack.GetPixel(j,i) == RGB(0,0,0))
						{
							return false;
						}
					}
				}
				else
				{
					if (MyHero.x >= m_bgWidth)
					{
						j += m_bgWidth;
					} 
					else
					{
						break;
					}
					
				}
			}
		}
		break;
	case RIGHT:
		{
			for (; k < 10; ++ k)
			{
				++ j;
				if (j < m_bgWidth)
				{
					for (i = iOld; i < toplimit; ++ i)
					{
						if (m_bgBlack.GetPixel(j,i) == RGB(0,0,0))
						{
							return false;
						}
					}
				}
				else
				{
					break;
				}
			}
		}
		break;
	}
	return true;
}

//计算地图重复次数
void CChildView::GetMapCount()
{
	if (MyHero.x > m_mapWidth-m_bgWidth/2 )
	{
		++ m_mapCount;
	} 
	else if (MyHero.x <= m_mapWidth-m_bgWidth*1.5)
	{
		-- m_mapCount;
	}
}

//获取地图起始位置
int CChildView::GetMapStartX()
{
	if (MyHero.x > WINDOW_WIDTH/2 && MyHero.x < m_mapWidth-m_bgWidth/2)
	{
		return (int)(MyHero.x - WINDOW_WIDTH/2) % m_bgWidth;
	} 
	else
	{
		return 0;
	}
}

//获取提示文字的位置
int CChildView::GetTextStartX()
{
	if (MyHero.x <= WINDOW_WIDTH/2)
	{
		return 0;
	} 
	else
	{
		return GetScreenX(MyHero.x,m_mapWidth) - WINDOW_WIDTH/2;
	}
}

//键盘按键响应函数
void CChildView::OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags)
{
	CWnd::OnKeyDown(nChar, nRepCnt, nFlags);

	static float lastTime = timeGetTime();
	static float currentTime = timeGetTime();
	currentTime = timeGetTime();
	float speedTime = MyHero.speed * (currentTime - lastTime);

	if (speedTime > 10)
	{
		speedTime = 6;
	}

	switch(nChar)
	{
	case 'w':
	case 'W':
		{
			MyHero.direct = UP;
			++ MyHero.frame;
			if (IsCanPass(MyHero.direct))
			{
				MyHero.y -= speedTime;
				if (MyHero.y < 0)
				{
					MyHero.y += speedTime;
				}
			}
			if (MyHero.frame == 4)
			{
				MyHero.frame = 0;
			}
		}
		break;

	case 'a':
	case 'A':
		{		
			MyHero.direct = LEFT;
			++ MyHero.frame;
			if (IsCanPass(MyHero.direct))
			{
				MyHero.x -= speedTime;
				if (MyHero.x < 0)
				{
					MyHero.x += speedTime;
				}
			}
			if (MyHero.frame == 4)
			{
				MyHero.frame = 0;
			}
		}
		break;

	case 'd':
	case 'D':
		{
			MyHero.direct = RIGHT;
			++ MyHero.frame;
			if (IsCanPass(MyHero.direct))
			{	
				MyHero.x += speedTime;	
				if (MyHero.x+HEROSIZE > m_mapWidth)
				{
					MyHero.x -= speedTime;
				}
			}
			if (MyHero.frame == 4)
			{
				MyHero.frame = 0;
			}
		}
		break;

	case 's':
	case 'S':
		{
			MyHero.direct = DOWN;
			++ MyHero.frame;
			if (IsCanPass(MyHero.direct))
			{	
				MyHero.y += speedTime;
				if (MyHero.y+HEROSIZE > WINDOW_HEIGHT)
				{
					MyHero.y -= speedTime;
				}
			}
			if (MyHero.frame == 4)
			{
				MyHero.frame = 0;
			}
		}
		break;

	case 'q':
	case 'Q':
		m_scene->ChangeMode();
		break;

	//创建定时器
	case 't':
	case 'T':
		SetTimer(TIMER_HEROMOVE,100,NULL);
		break;

	//撤销定时器
	case 'i':
	case 'I':
		KillTimer(TIMER_HEROMOVE);
		break;
	}

	lastTime = currentTime;
}

//鼠标左键点击响应函数
void CChildView::OnLButtonDown(UINT nFlags, CPoint point)
{
	CWnd::OnLButtonDown(nFlags, point);
	
	/*char bufPos[20] = "";
	sprintf_s(bufPos,"你点击了(%d,%d)",point.x,point.y);
	AfxMessageBox(bufPos);*/

	m_scene->UpdateFogArea(point.x,point.y);
}

//定时器响应函数
void CChildView::OnTimer(UINT_PTR nIDEvent)
{
	CWnd::OnTimer(nIDEvent);

	static float lastTime = timeGetTime();
	static float currentTime = timeGetTime();
	currentTime = timeGetTime();
	float speedTime = 0;

	switch(nIDEvent)
	{
	case TIMER_PAINT:
		OnPaint();
		break;

	case TIMER_HEROMOVE:
		{
			speedTime = MyHero.speed * (currentTime - lastTime);

			MyHero.direct = RIGHT;
			++ MyHero.frame;
			if (IsCanPass(MyHero.direct))
			{
				MyHero.x += speedTime;	
				if (MyHero.x > m_mapWidth)
				{
					MyHero.x = -HEROSIZE;
				}
			}
			if (MyHero.frame == 4)
			{
				MyHero.frame = 0;
			}
		}
		break;
	case TIMER_MONSTERMOVE:
		{
			speedTime = Monster.speed * (currentTime - lastTime);
			//怪物状态更新
			//水平方向靠近
			if ((int)Monster.x < (int)MyHero.x)
			{
				Monster.direct = RIGHT;
				++ Monster.frame;
				if (Monster.frame == 4)
				{
					Monster.frame = 0;
				}
				Monster.x += speedTime;
			} 
			else if ((int)Monster.x > (int)MyHero.x)
			{
				Monster.direct = LEFT;
				++ Monster.frame;
				if (Monster.frame == 4)
				{
					Monster.frame = 0;
				}
				Monster.x -= speedTime;
			}
			else
			{
				if ((int)Monster.y < (int)MyHero.y)
				{
					Monster.direct = DOWN;
					++ Monster.frame;
					if (Monster.frame == 4)
					{
						Monster.frame = 0;
					}
				} 
				else if ((int)Monster.y > (int)MyHero.y)
				{
					Monster.direct = UP;
					++ Monster.frame;
					if (Monster.frame == 4)
					{
						Monster.frame = 0;
					}
				}
			}
			//竖直方向靠近
			if ((int)Monster.y < (int)MyHero.y)
			{
				Monster.y += speedTime;
			} 
			else if ((int)Monster.y > (int)MyHero.y)
			{
				Monster.y -= speedTime;
			}
		}
		break;
	}
	lastTime = currentTime;
}

//开始初始化函数
int CChildView::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CWnd::OnCreate(lpCreateStruct) == -1)
		return -1;

	SetTimer(TIMER_PAINT,10,NULL);
	SetTimer(TIMER_MONSTERMOVE,100,NULL);
	return 0;
}

//鼠标移动响应函数
void CChildView::OnMouseMove(UINT nFlags, CPoint point)
{
	CWnd::OnMouseMove(nFlags, point);

}
