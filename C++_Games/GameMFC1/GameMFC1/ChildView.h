
// ChildView.h : CChildView ��Ľӿ�
//


#pragma once
#pragma comment(lib,"winmm.lib") //��������ͷ�ļ���

#include "CParticle.h"
#include "CScene.h"

//��ʱ��ID����
#define TIMER_PAINT 1
#define TIMER_HEROMOVE 2
#define TIMER_MONSTERMOVE 3
//���﷽����
#define  DOWN 0
#define LEFT 1
#define RIGHT 2
#define UP 3
//�����С����
#define HEROSIZE 80
#define MONSTERSIZE 96

// CChildView ����


class CChildView : public CWnd
{
// ����
public:
	CChildView();

// ����
public:
	struct Character //����ṹ��
	{
		CImage character; //��������ͼ��
		float x; //��������λ��
		float y;
		int direct; //���﷽��
		int frame; //�˶����ڼ���ͼƬ
		int width; //����ͼƬ��С���Ա���ײ���
		int height;
		float Xcenter; //������������
		float Ycenter;
		float speed; //�����ٶ� 
	}MyHero, Monster;
	int m_mapCount; //x�����ϵ�ͼ�ظ�����
	int m_mapWidth;	//����ͼƬ�ܿ��
	int m_bgWidth; //һ��ͼƬ�Ŀ��
	CRect m_client;	//������Χ
	CImage m_bg; //����ͼƬ
	CImage m_bgBlack; //�����ɰ�ͼ
	CParticle *m_snow; //ѩ��
	CScene *m_scene; //������
	CDC m_cacheDC; //����DC
	CBitmap m_cacheCBitmap; //����λͼ
// ����
public:
	//��png��ͼ͸����
	void TransparentPNG(CImage *png);
	//��ȡӢ������Ļ�ϵ�����
	int GetScreenX(int xHero, int mapWidth);
	//��ȡ��������Ļ�ϵ�����
	int GetScreenX(int xMonster);
	//�ж���ײ
	void IsCollide();
	//�ж�ͨ��
	bool IsCanPass(int direct);
	//���㱳���ظ�����
	void GetMapCount();
	//��ȡ��ͼ��ʼλ��
	int GetMapStartX();
	//��ȡ��ʾ���ֵ�λ��
	int GetTextStartX();
// ��д
	protected:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);

// ʵ��
public:
	virtual ~CChildView();

	// ���ɵ���Ϣӳ�亯��
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

