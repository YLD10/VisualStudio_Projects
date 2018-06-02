/*************************************************************************
	> File Name: d3dUtility.h
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.6.1 21:36
    > Describe: Win32 Application InitD3D.
                ������ DirectX11 �� 3D ͼ�γ�����ư����̡̳�
                5.2 �ڳ������� ����һ��������
 ************************************************************************/
#pragma once

#include <Windows.h>

 //////////////////////////////////////////////////////////////////////////
// XNA ��ѧ�����ͷ�ļ�
//////////////////////////////////////////////////////////////////////////
#include <d3dCompiler.h>
#include <xnamath.h>

//////////////////////////////////////////////////////////////////////////
// DirectX11 ���ͷ�ļ�
//////////////////////////////////////////////////////////////////////////
#include <d3d11.h>
#include <d3dx11.h>

//////////////////////////////////////////////////////////////////////////
// DirectX11 ��ؿ�
//////////////////////////////////////////////////////////////////////////
#pragma comment(lib, "d3d11.lib")
#pragma comment(lib, "d3dx11.lib")

#pragma comment(lib, "d3dCompiler.lib")
#pragma comment(lib, "dxguid.lib")
#pragma comment(lib, "winmm.lib")

namespace d3d  // ����һ�� d3d �����ռ�
{
    /*
     * ��ʼ�� D3D
     */
    bool InitD3D(HINSTANCE hInstance,
                 int width, int height,
                 ID3D11RenderTargetView** renderTargerView,  // Ŀ����Ⱦ��ͼ�ӿ�
                 ID3D11DeviceContext** immediateContext,     // ִ�������Ľӿ�
                 IDXGISwapChain** swapChain,                 // �������ӿ�
                 ID3D11Device** device);                     // �豸�ýӿ�, ÿ�� D3D ����������һ���豸

    /*
     * ��Ϣѭ��
     */
    int EnterMsgLoop(bool (*ptr_display)(float timeDelta));

    /*
     * �ص�����
     */
    LRESULT CALLBACK WndProc(HWND,
                             UINT msg,
                             WPARAM,
                             LPARAM lParam);
}
