
// ChildView.cpp : CChildView ���ʵ��
//

#include "stdafx.h"
#include "GameMFC1.h"
#include "ChildView.h"
#include "mmsystem.h" //����ý�����ͷ�ļ�
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



// CChildView ��Ϣ�������
BOOL CChildView::PreCreateWindow(CREATESTRUCT& cs) 
{
	if (!CWnd::PreCreateWindow(cs))
		return FALSE;

	cs.dwExStyle |= WS_EX_CLIENTEDGE;
	cs.style &= ~WS_BORDER;
	cs.lpszClass = AfxRegisterWndClass(CS_HREDRAW|CS_VREDRAW|CS_DBLCLKS, 
		::LoadCursor(NULL, IDC_ARROW), reinterpret_cast<HBRUSH>(COLOR_WINDOW+1), NULL);

	/************************************************************************/
	/* ���ݳ�ʼ��                                                            */
	/************************************************************************/
	//���ر����ɰ�ͼ
	//m_bgBlack.Load("../Images/bgBlack.png");
	//���ر�����Ӣ��
	m_bg.Load("../Images/bg.png");
	MyHero.character.Load("../Images/hero.png");
	TransparentPNG(&MyHero.character);
	//���ع���
	//Monster.character.Load("../Images/monster.png");
	//TransparentPNG(&Monster.character);

	//��ʼ��ѩ��ϵͳ
	m_snow = new CParticle(100);
	m_snow->Init();

	//��ʼ������
	m_scene = new CScene();

	//��ʼ��Ӣ��״̬
	MyHero.direct = UP;
	MyHero.frame = 0;
	MyHero.width = HEROSIZE;
	MyHero.height = HEROSIZE;
	MyHero.speed = 0.2;
	//��ʼ������״̬
	//Monster.direct = LEFT;
	//Monster.frame = 0;
	//Monster.width = MONSTERSIZE;
	//Monster.height = MONSTERSIZE;
	//Monster.speed = 0.15;
	//����Ӣ�۳�ʼλ��
	MyHero.x = 100;
	MyHero.y = 400;
	//���ù����ʼλ��
	//Monster.x = 700;
	//Monster.y = 100;

	//��ʼ����ͼ����
	m_bgWidth = m_mapWidth = m_bg.GetWidth();
	m_mapCount = 1;

	//�򿪱�������
	mciSendString("open ../Musics/background.mp3 alias bgMusic",NULL,0,NULL);
	mciSendString("play bgMusic repeat",NULL,0,NULL);

	return TRUE;
}

//���ƺ���
void CChildView::OnPaint() 
{
	CPaintDC dc(this); // ���ڻ��Ƶ��豸������

	static float lastTime = timeGetTime();
	static float currentTime = timeGetTime();

	{
		//CBitmap������ͼ
		/*CDC *cDC = this->GetDC(), m_bgcDC;
		GetClientRect(&m_client);

		m_bgcDC.CreateCompatibleDC(NULL);

		CBitmap m_bgBitmap;
		m_bgBitmap.LoadBitmap(bgImage);

		m_bgcDC.SelectObject(&m_bgBitmap);

		cDC->BitBlt(0,0,m_client.Width(),m_client.Height(),&m_bgcDC,0,0,SRCCOPY);*/

		//CImage������ͼ
		/*m_hero.Load("../Images/hero.png");
		TransparentPNG(&m_hero);
		m_hero.Draw(*cDC,100,400,60,60);*/
	}
	
	//��ȡ����DCָ��
	CDC *cDC = this->GetDC();
	//��ȡ���ڴ�С
	GetClientRect(&m_client);
	//��������DC
	m_cacheDC.CreateCompatibleDC(NULL);
	m_cacheCBitmap.CreateCompatibleBitmap(cDC,m_client.Width(),m_client.Height());
	m_cacheDC.SelectObject(m_cacheCBitmap);

	/************************************************************************/
	/* ��ʼ����                                                             */
	/************************************************************************/

	//�����ͼ�ظ�����
	//GetMapCount();
	//���¼����ͼ�ܳ���
	//m_mapWidth = m_bgWidth * m_mapCount;

	//for (int i = 0; i < 2; ++ i)
	//{
	//	//�������ɰ�ͼ
	//	m_bgBlack.Draw(m_cacheDC,m_bgWidth*i,0,WINDOW_WIDTH,WINDOW_HEIGHT,0,0,WINDOW_WIDTH,WINDOW_HEIGHT);
		//������
		m_bg.Draw(m_cacheDC,0,0,WINDOW_WIDTH,WINDOW_HEIGHT,0,0,WINDOW_WIDTH,WINDOW_HEIGHT);
	//}

	//��Ӣ�ۺ͹���
	MyHero.character.Draw(m_cacheDC,GetScreenX(MyHero.x,m_mapWidth),MyHero.y,HEROSIZE,HEROSIZE,
		MyHero.frame*HEROSIZE,MyHero.direct*HEROSIZE,HEROSIZE,HEROSIZE);
	//Monster.character.Draw(m_cacheDC,GetScreenX(Monster.x),Monster.y,MONSTERSIZE,MONSTERSIZE,
		//Monster.frame*MONSTERSIZE,Monster.direct*MONSTERSIZE,MONSTERSIZE,MONSTERSIZE);

	//��ѩ��
	m_snow->Draw(m_cacheDC);
	//����ѩ��
	currentTime = timeGetTime();
	m_snow->Update(currentTime-lastTime);
	lastTime = currentTime;

	//����ս������
	m_scene->DrawFog(m_cacheDC);

	//����������������
	//MyHero.Xcenter = MyHero.x + MyHero.width/2;
	//MyHero.Ycenter = MyHero.y + MyHero.height/2;
	//Monster.Xcenter = Monster.x + Monster.width/2;
	//Monster.Ycenter = Monster.y + Monster.height/2;

	//�������ֱ���͸��
	//m_cacheDC.SetBkMode(TRANSPARENT);
	//����������ɫ��ɫ
	//m_cacheDC.SetTextColor(RGB(255,0,0));

	//�ж���ײ
	//IsCollide();

	//����DC���
	cDC->BitBlt(0,0,m_client.Width(),m_client.Height(),&m_cacheDC,GetMapStartX(),0,SRCCOPY);

	//������ͼ��ʹ������Ч
	ValidateRect(&m_client);
	//�ͷŻ���DC
	m_cacheDC.DeleteDC();
	//�ͷŶ���
	m_cacheCBitmap.DeleteObject();
	//�ͷ�DC
	ReleaseDC(cDC);
}

//��png��ͼ͸����
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

//��ȡӢ������Ļ�ϵ�����
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

//��ȡ��������Ļ�ϵ�����
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

//�ж���ײ����
void CChildView::IsCollide()
{
	if (Monster.Xcenter < MyHero.Xcenter+(MyHero.width/2+Monster.width/2) &&
		Monster.Xcenter > MyHero.Xcenter-(MyHero.width/2+Monster.width/2) &&
		Monster.Ycenter < MyHero.Ycenter+(MyHero.height/2+Monster.height/2) &&
		Monster.Ycenter > MyHero.Ycenter-(MyHero.height/2+Monster.height/2))
	{
		m_cacheDC.TextOut(GetTextStartX(),0,"������ײ");
	} 
	else
	{
		m_cacheDC.TextOut(GetTextStartX(),0,"û����ײ");
	}

	char buf[50] = "";
	sprintf_s(buf,"������Ӣ�۾��룺%d ��",(int)(0.025*sqrtf((MyHero.Xcenter-Monster.Xcenter)*
		(MyHero.Xcenter-Monster.Xcenter)+(MyHero.Ycenter-Monster.Ycenter)*(MyHero.Ycenter-Monster.Ycenter))));
	m_cacheDC.TextOut(GetTextStartX(),20,buf);
}

//�ж�ͨ�к���
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

//�����ͼ�ظ�����
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

//��ȡ��ͼ��ʼλ��
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

//��ȡ��ʾ���ֵ�λ��
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

//���̰�����Ӧ����
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

	//������ʱ��
	case 't':
	case 'T':
		SetTimer(TIMER_HEROMOVE,100,NULL);
		break;

	//������ʱ��
	case 'i':
	case 'I':
		KillTimer(TIMER_HEROMOVE);
		break;
	}

	lastTime = currentTime;
}

//�����������Ӧ����
void CChildView::OnLButtonDown(UINT nFlags, CPoint point)
{
	CWnd::OnLButtonDown(nFlags, point);
	
	/*char bufPos[20] = "";
	sprintf_s(bufPos,"������(%d,%d)",point.x,point.y);
	AfxMessageBox(bufPos);*/

	m_scene->UpdateFogArea(point.x,point.y);
}

//��ʱ����Ӧ����
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
			//����״̬����
			//ˮƽ���򿿽�
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
			//��ֱ���򿿽�
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

//��ʼ��ʼ������
int CChildView::OnCreate(LPCREATESTRUCT lpCreateStruct)
{
	if (CWnd::OnCreate(lpCreateStruct) == -1)
		return -1;

	SetTimer(TIMER_PAINT,10,NULL);
	SetTimer(TIMER_MONSTERMOVE,100,NULL);
	return 0;
}

//����ƶ���Ӧ����
void CChildView::OnMouseMove(UINT nFlags, CPoint point)
{
	CWnd::OnMouseMove(nFlags, point);

}
