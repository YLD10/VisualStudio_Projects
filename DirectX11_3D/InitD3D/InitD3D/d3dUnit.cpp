/*************************************************************************
	> File Name: d3dUnit.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.5.31 22:57
	> Describe: Win32 Application InitD3D.
                ������ DirectX11 �� 3D ͼ�γ�����ư����̡̳�
                4.2 �ڳ������� ��ʼ�� D3D
 ************************************************************************/
 #include "d3dUtility.h"

ID3D11Device* device = NULL;                        // D3D11 �豸ָ��
IDXGISwapChain* swapChain = NULL;                   // ������ָ��
ID3D11DeviceContext* immediateContext = NULL;       // ִ��������ָ��
ID3D11RenderTargetView* renderTargetView = NULL;    // ��ȾĿ����ͼָ��

//************* ����Ϊ��ܺ��� ***************
bool Setup()
{
    // ������ setup ����û������, �Ժ��ʵ���л���������д����

    return true;
}

void Cleanup()
{
    // �ͷ�ָ��
    if (renderTargetView)
    {
        renderTargetView->Release();
    }
    if (immediateContext)
    {
        immediateContext->Release();
    }
    if (swapChain)
    {
        swapChain->Release();
    }
    if (device)
    {
        device->Release();
    }
}

bool Display(float timeDelta)
{
    if (device)
    {
        // ����һ����������ɫ��Ϣ, 4 ��Ԫ�طֱ��ʾ��, ��, ���Լ� alpha
        float ClearColor[4] = {0.0f, 0.125f, 0.3f, 1.0f};

        // �����ȾĿ����ͼ
        immediateContext->ClearRenderTargetView(renderTargetView,
                                                ClearColor);

        // ��ʾ��Ⱦ�õ�ͼ����û�
        swapChain->Present(0,   // ָ�����ͬ����ʾ, ���� 0 ��ʾ��ͬ����ʾ
                           0);  // ��ѡ��, ���� 0 ��ʾΪ��ÿ����������ʾһ֡
    }

    return true;
}
//************* ��ܺ�����д���� ***************

/*
 * �ص�����
 */
LRESULT CALLBACK d3d::WndProc(HWND hwnd, UINT msg,
                              WPARAM wParam, LPARAM lParam)
{
    switch (msg)
    {
    case WM_DESTROY:
        ::PostQuitMessage(0);
        break;
    case WM_KEYDOWN:
        if (VK_ESCAPE == wParam)
        {
            ::DestroyWindow(hwnd);
        }
        break;
    }

    return ::DefWindowProc(hwnd, msg, wParam, lParam);
}

/*
 * ������ WinMain
 */
int WINAPI WinMain(HINSTANCE hInstance,
                   HINSTANCE hPreInstance,
                   PSTR pCmdLine,
                   int nShowCmd)
{
    // ��ʼ��
    // ���������� 4 ��ָ��, ��������Ϊ�������� InitD3D ����
    if (!d3d::InitD3D(hInstance,
                      800,
                      600,
                      &renderTargetView,
                      &immediateContext,
                      &swapChain,
                      &device))
    {
        ::MessageBox(0, L"InitD3D() - FAILED", 0, 0);

        return 0;
    }
    if (!Setup())
    {
        ::MessageBox(0, L"Setup() - FAILED", 0, 0);

        return 0;
    }

    // ִ����Ϣѭ��, ������ Display ��ָ����Ϊ��������
    d3d::EnterMsgLoop(Display);

    Cleanup();

    return 0;
}
 
