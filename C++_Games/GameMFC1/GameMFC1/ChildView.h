
// ChildView.h : CChildView 类的接口
//


#pragma once
#pragma comment(lib,"winmm.lib") //导入声音头文件库

#include "CParticle.h"
#include "CScene.h"

//定时器ID定义
#define TIMER_PAINT 1
#define TIMER_HEROMOVE 2
#define TIMER_MONSTERMOVE 3
//人物方向定义
#define  DOWN 0
#define LEFT 1
#define RIGHT 2
#define UP 3
//人物大小定义
#define HEROSIZE 80
#define MONSTERSIZE 96

// CChildView 窗口


class CChildView : public CWnd
{
// 构造
public:
	CChildView();

// 特性
public:
	struct Character //人物结构体
	{
		CImage character; //保存人物图像
		float x; //保存人物位置
		float y;
		int direct; //人物方向
		int frame; //运动到第几张图片
		int width; //保存图片大小，以便碰撞检测
		int height;
		float Xcenter; //人物中心坐标
		float Ycenter;
		float speed; //人物速度 
	}MyHero, Monster;
	int m_mapCount; //x方向上地图重复次数
	int m_mapWidth;	//背景图片总宽度
	int m_bgWidth; //一张图片的宽度
	CRect m_client;	//背景范围
	CImage m_bg; //背景图片
	CImage m_bgBlack; //背景蒙版图
	CParticle *m_snow; //雪花
	CScene *m_scene; //迷雾场景
	CDC m_cacheDC; //缓冲DC
	CBitmap m_cacheCBitmap; //缓冲位图
// 操作
public:
	//将png贴图透明化
	void TransparentPNG(CImage *png);
	//获取英雄在屏幕上的坐标
	int GetScreenX(int xHero, int mapWidth);
	//获取怪物在屏幕上的坐标
	int GetScreenX(int xMonster);
	//判断碰撞
	void IsCollide();
	//判断通行
	bool IsCanPass(int direct);
	//计算背景重复次数
	void GetMapCount();
	//获取地图起始位置
	int GetMapStartX();
	//获取提示文字的位置
	int GetTextStartX();
// 重写
	protected:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);

// 实现
public:
	virtual ~CChildView();

	// 生成的消息映射函数
protected:
	afx_msg void OnPaint();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags);
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnTimer(UINT_PTR nIDEvent);
	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
};

