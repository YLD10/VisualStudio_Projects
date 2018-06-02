/*************************************************************************
	> File Name: d3dUtility.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.5.31 22:56
    > Describe: Win32 Application InitD3D.
                《基于 DirectX11 的 3D 图形程序设计案例教程》
                4.2 节程序例子 初始化 D3D
 ************************************************************************/
 #include "d3dUtility.h"

/*
 * D3D 初始化
 * 这个函数中包括两个部分: 第一部分: 创建一个窗口; 第二部分: 初始化 D3D
 * 函数参数包括:
 * 1.HINSTANCE   当前应用程序实例的句柄
 * 2.int width   窗口宽
 * 3.int height  窗口高
 * 4.ID3D11RenderTargetView** renderTargetView  目标渲染视图指针
 * 5.ID3D11DeviceContext** immediateContext     立即执行上下文指针
 * 6.IDXGISwapChain** swapChain                 交换链指针
 * 7.ID3D11Device** device                      设备用指针, 每个 D3D 程序至少有一个设备
 */
bool d3d::InitD3D(HINSTANCE hInstance, 
                  int width, int height, 
                  ID3D11RenderTargetView** renderTargerView, 
                  ID3D11DeviceContext** immediateContext, 
                  IDXGISwapChain** swapChain, 
                  ID3D11Device** device)
{
    //************* 第一部分: 创建一个窗口开始 ***************
    // 这部分的代码和 2.2 节中创建窗口代码基本一致
    // 具体参数的注释可以参考 2.2 节程序例子
    // 创建窗口的 4 个步骤: 1 设计一个窗口类; 2 注册窗口类
    //                    3 创建窗口;       4 窗口显示和更新
    // 1 设计一个窗口类
    WNDCLASS wc;
    wc.style            = CS_HREDRAW | CS_VREDRAW;
    wc.lpfnWndProc      = (WNDPROC)d3d::WndProc;
    wc.cbClsExtra       = 0;
    wc.cbWndExtra       = 0;
    wc.hInstance        = hInstance;
    wc.hIcon            = LoadIcon(0, IDI_APPLICATION);
    wc.hCursor          = LoadCursor(0, IDC_ARROW);
    wc.hbrBackground    = (HBRUSH)GetStockObject(WHITE_BRUSH);
    wc.lpszMenuName     = 0;
    wc.lpszClassName    = L"Direct3D11App";

    // 2 注册窗口类
    if (!RegisterClass(&wc))
    {
        ::MessageBox(0, L"RegisterClass() - FAILED", 0, 0);

        return false;
    }

    // 3 创建窗口
    HWND hwnd;
    hwnd = ::CreateWindow(L"Direct3D11App",
                          L"D3D11",
                          WS_OVERLAPPEDWINDOW,
                          CW_USEDEFAULT,
                          CW_USEDEFAULT,
                          width,
                          height,
                          0,
                          0,
                          hInstance,
                          0);
    if (!hwnd)
    {
        ::MessageBox(0, L"CreateWindow() - FAILED", 0, 0);

        return false;
    }

    // 4 窗口显示和更新
    ::ShowWindow(hwnd, SW_SHOW);
    ::UpdateWindow(hwnd);

    //************* 第一部分: 创建一个窗口结束 ***************
    
    //************* 第二部分: 初始化 D3D 开始 ***************
    // 初始化 D3D 设备主要为以下步骤
    // 1. 描述交换链, 即填充 DXGI_SWAP_CHAIN_DESC 结构
    // 2. 使用 D3D11CreateDeviceAndSwapChain 创建 D3D 设备 (ID3D11Device)
    //    执行上下文接口 (ID3D11DeviceContext), 交换链接口 (IDXGISwapChain)
    // 3. 创建目标渲染视图 (ID3D11RenderTargetView)
    // 4. 设置视口 (View Port)

    // 第一步, 描述交换链, 即填充 DXGI_SWAP_CHAIN_DESC 结构
    DXGI_SWAP_CHAIN_DESC sd;          // 首先声明一个 DXGI_SWAP_CHAIN_DESC 的对象 sd
    ZeroMemory(&sd, sizeof(sd));      // 用 ZeroMemory 对 sd 进行初始化
    sd.BufferCount       = 1;         // 交换链中后台缓存数量, 通常为 1
    sd.BufferDesc.Width  = width;     // 缓存区中的窗口宽
    sd.BufferDesc.Height = height;    // 缓存区中的窗口高
    sd.BufferDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;    // 表示红绿蓝 Alpha 各 8 位
    sd.BufferDesc.RefreshRate.Numerator   = 60;           // 刷新频率的分子为 60
    sd.BufferDesc.RefreshRate.Denominator = 1;            // 刷新频率的分母为 1, 即
                                                          // 刷新频率为每秒 60 次
    sd.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;     // 用来描述后台缓存用法
                                                          // 控制 CPU 对后台缓存的访问
    sd.OutputWindow       = hwnd;     // 指向渲染目标窗口的句柄
    sd.SampleDesc.Count   = 1;        // 多重采样, 本例中不采用多重采样
    sd.SampleDesc.Quality = 0;        // 所以 Count = 1, Quality = 0
    sd.Windowed           = TRUE;     // TRUE 为窗口模式, FALSE 为全屏模式

    // 第二步, 创建设备, 交换链以及立即执行上下文
    // 创建一个数组确定尝试创建 Featurelevel 的顺序
    D3D_FEATURE_LEVEL featureLevels[] =
    {
        D3D_FEATURE_LEVEL_11_0,  // D3D11 所支持的特征, 包括 shader model 5
        D3D_FEATURE_LEVEL_10_1,  // D3D10 所支持的特征, 包括 shader model 4
        D3D_FEATURE_LEVEL_10_0
    };

    // 获取 D3D_FEATURE_LEVEL 数组的元素个数
    UINT numFeatureLevels = ARRAYSIZE(featureLevels);

    // 调用 D3D11CreateDeviceAndSwaoChain 创建交换链、设备和执行上下文
    // 分别存入 swapChain, device, immediateContext
    if (FAILED(D3D11CreateDeviceAndSwapChain(
               NULL,                // 确定显示适配器, NULL 表示默认显示适配器
               D3D_DRIVER_TYPE_HARDWARE,  // 驱动类型, 这里表示使用三维硬件加速
               NULL,                // 只有上一个参数设置为
                                    // D3D_DRIVER_TYPE_SOFTWARE 时才使用该参数
               0,                   // 也可以设置为 D3D11_CREATE_DEVICE_DEBUG 开启调试模式
               featureLevels,       // 前面定义的 D3D_FEATURE_LEVEL 数组
               numFeatureLevels,    // D3D_FEATURE_LEVEL 的元素个数
               D3D11_SDK_VERSION,   // SDK 的版本, 这里为 D3D11
               &sd,                 // 前面定义的 DXGI_SWAP_CHAIN_DESC 对象
               swapChain,           // 返回创建好的交换链指针, InitD3D 函数传递的实参
               device,              // 返回创建好的设备用指针, InitD3D 函数传递到实参
               NULL,                // 返回当前设备支持的 featureLevels 数组中的第一个对象,
                                    // 一般设置为 NULL
               immediateContext)))  // 返回创建好的执行上下文指针,
                                    // InitD3D 函数传递的实参
    {
        ::MessageBox(0, L"CreateDevice - FAILED", 0, 0);

        return false;
    }

    // 第三步, 创建并设置渲染目标视图
    HRESULT hr = 0;                         // COM 要求所有的方法都会返回一个 HRESULT 类型的错误号
    ID3D11Texture2D* pBackBuffer = NULL;    // ID3D11Texture2D 类型的后台缓存指针

    // 调用 GetBuffer() 函数得到后台缓存对象, 并存入 &pBackBuffer 中
    hr = (*swapChain)->GetBuffer(0,         // 缓存索引, 一般设置为 0
                                 __uuidof(ID3D11Texture2D),  // 缓存类型
                                 (LPVOID*)&pBackBuffer);     // 缓存指针
    // 判断 GetBuffer 是否调用成功
    if (FAILED(hr))
    {
        ::MessageBox(0, L"GetBuffer - FAILED", 0, 0);

        return false;
    }

    // 调用 CreateRenderTargetView 创建好渲染目标视图
    // 创建后存入 renderTargetView 中
    hr = (*device)->CreateRenderTargetView(pBackBuffer,        // 上面创建好的后台缓存
                                           NULL,               // 设置为 NULL 得到默认的渲染目标视图
                                           renderTargerView);  // 返回创建好的渲染目标视图
                                                               // InitD3D 函数传递的实参
    pBackBuffer->Release();  // 释放后台缓存

    // 判断 CreateRenderTargetView 是否调用成功
    if (FAILED(hr))
    {
        ::MessageBox(0, L"CreateRender - FAILED", 0, 0);

        return false;
    }

    // 将渲染目标视图绑定到渲染管线
    (*immediateContext)->OMSetRenderTargets(1,                 // 绑定的目标视图的个数
                                            renderTargerView,  // 渲染目标视图
                                            NULL);             // 不绑定深度模版

    // 第四步, 设置视口大小, D3D11 默认不会设置视口, 此步骤必须手动设置
    D3D11_VIEWPORT vp;      // 创建一个视口的对象
    vp.Width    = width;    // 视口的宽
    vp.Height   = height;   // 视口的高
    vp.MinDepth = 0.0f;     // 深度值的下限, 由于深度值是 [0, 1] 所以下限值是 0
    vp.MaxDepth = 1.0f;     // 深度值的上限, 上限值是 1
    vp.TopLeftX = 0;        // 视口左上角的横坐标
    vp.TopLeftY = 0;        // 视口左上角的纵坐标

    // 设置视口
    (*immediateContext)->RSSetViewports(1,      // 视口的个数
                                        &vp);   // 上面创建的视口对象

    return true;

    //************* 第二部分: 初始化 D3D 结束 ***************
}

/*
 * 消息循环函数, 和之前 "Hello World" 程序中 Run() 起到同样的功能
 * bool(*ptr_display)(float timeDelta) 表示传递一个函数指针作为参数
 * 这个函数有一个 float 类型的参数, 有一个 bool 类型的返回
 */
int d3d::EnterMsgLoop(bool(*ptr_display)(float timeDelta))
{
    MSG msg;
    ::ZeroMemory(&msg, sizeof(MSG));                // 初始化内存

    static float lastTime = (float)timeGetTime();   // 第一次获取当前时间
    
    while (WM_QUIT != msg.message)
    {
        if (::PeekMessage(&msg, 0, 0, 0, PM_REMOVE))
        {
            ::TranslateMessage(&msg);
            ::DispatchMessage(&msg);
        }
        else
        {
            // 第二次获取当前时间
            float currTime  = (float)timeGetTime();
            
            // 获取两次时间之间的时间差
            float timeDelta = (currTime - lastTime) * 0.001f;

            // 调用显示函数, 这在后面时间图形的变化 (如旋转) 时会用到
            ptr_display(timeDelta);
            lastTime = currTime;
        }
    }
    
    return msg.wParam;
}
 
 