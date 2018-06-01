/*************************************************************************
	> File Name: d3dUnit.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.5.31 22:57
	> Describe: Win32 Application InitD3D.
                《基于 DirectX11 的 3D 图形程序设计案例教程》
                4.2 节程序例子 初始化 D3D
 ************************************************************************/
 #include "d3dUtility.h"

ID3D11Device* device = NULL;                        // D3D11 设备指针
IDXGISwapChain* swapChain = NULL;                   // 交换链指针
ID3D11DeviceContext* immediateContext = NULL;       // 执行上下文指针
ID3D11RenderTargetView* renderTargetView = NULL;    // 渲染目标视图指针

//************* 以下为框架函数 ***************
bool Setup()
{
    // 本例中 setup 函数没有内容, 以后的实验中会往里面填写内容

    return true;
}

void Cleanup()
{
    // 释放指针
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
        // 声明一个数组存放颜色信息, 4 个元素分别表示红, 绿, 蓝以及 alpha
        float ClearColor[4] = {0.0f, 0.125f, 0.3f, 1.0f};

        // 清除渲染目标视图
        immediateContext->ClearRenderTargetView(renderTargetView,
                                                ClearColor);

        // 显示渲染好的图像给用户
        swapChain->Present(0,   // 指定如何同步显示, 设置 0 表示不同步显示
                           0);  // 可选项, 设置 0 表示为从每个缓存中显示一帧
    }

    return true;
}
//************* 框架函数编写结束 ***************

/*
 * 回调函数
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
 * 主函数 WinMain
 */
int WINAPI WinMain(HINSTANCE hInstance,
                   HINSTANCE hPreInstance,
                   PSTR pCmdLine,
                   int nShowCmd)
{
    // 初始化
    // 上面声明的 4 个指针, 在这里作为参数传给 InitD3D 函数
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

    // 执行消息循环, 将函数 Display 的指针作为参数传递
    d3d::EnterMsgLoop(Display);

    Cleanup();

    return 0;
}
 
