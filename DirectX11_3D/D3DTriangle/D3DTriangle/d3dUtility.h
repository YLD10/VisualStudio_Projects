/*************************************************************************
	> File Name: d3dUtility.h
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.6.1 21:36
    > Describe: Win32 Application InitD3D.
                《基于 DirectX11 的 3D 图形程序设计案例教程》
                5.2 节程序例子 绘制一个三角形
 ************************************************************************/
#pragma once

#include <Windows.h>

 //////////////////////////////////////////////////////////////////////////
// XNA 数学库相关头文件
//////////////////////////////////////////////////////////////////////////
#include <d3dCompiler.h>
#include <xnamath.h>

//////////////////////////////////////////////////////////////////////////
// DirectX11 相关头文件
//////////////////////////////////////////////////////////////////////////
#include <d3d11.h>
#include <d3dx11.h>

//////////////////////////////////////////////////////////////////////////
// DirectX11 相关库
//////////////////////////////////////////////////////////////////////////
#pragma comment(lib, "d3d11.lib")
#pragma comment(lib, "d3dx11.lib")

#pragma comment(lib, "d3dCompiler.lib")
#pragma comment(lib, "dxguid.lib")
#pragma comment(lib, "winmm.lib")

namespace d3d  // 定义一个 d3d 命名空间
{
    /*
     * 初始化 D3D
     */
    bool InitD3D(HINSTANCE hInstance,
                 int width, int height,
                 ID3D11RenderTargetView** renderTargerView,  // 目标渲染视图接口
                 ID3D11DeviceContext** immediateContext,     // 执行上下文接口
                 IDXGISwapChain** swapChain,                 // 交换链接口
                 ID3D11Device** device);                     // 设备用接口, 每个 D3D 程序至少有一个设备

    /*
     * 消息循环
     */
    int EnterMsgLoop(bool (*ptr_display)(float timeDelta));

    /*
     * 回调函数
     */
    LRESULT CALLBACK WndProc(HWND,
                             UINT msg,
                             WPARAM,
                             LPARAM lParam);
}
