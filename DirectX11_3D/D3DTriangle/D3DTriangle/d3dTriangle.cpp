/*************************************************************************
	> File Name: d3dTriangle.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.6.1 21:35
    > Describe: Win32 Application InitD3D.
                《基于 DirectX11 的 3D 图形程序设计案例教程》
                5.2 节程序例子 绘制一个三角形
 ************************************************************************/
#include "d3dUtility.h"

ID3D11Device*           device           = NULL;    // D3D11 设备指针
IDXGISwapChain*         swapChain        = NULL;    // 交换链指针
ID3D11DeviceContext*    immediateContext = NULL;    // 执行上下文指针
ID3D11RenderTargetView* renderTargetView = NULL;    // 渲染目标视图指针
// 新增的两个全局变量
ID3D11VertexShader*     vertexShader;               // 顶点着色器
ID3D11PixelShader*      pixelShader;                // 像素着色器

// 定义一个顶点结构, 这个顶点只需要包含坐标信息
struct Vertex
{
    XMFLOAT3 Pos;
};

//************* 以下为框架函数 ***************
/*
 * 第一步, 创建顶点着色器
 * 第二步, 创建像素着色器
 * 第三步, 创建并设置输入布局
 * 第四步, 创建顶点缓存
 */
bool Setup()
{
    // 第一步, 创建顶点着色器
    // 定义一个着色器编译标识符
    // D3DCOMPILE_ENABLE_STRICTINESS 表示强制严格编译
    // 这样一些已经废弃的语法将不能编译
    DWORD dwShaderFlag = D3DCOMPILE_ENABLE_STRICTNESS;

    // ID3DBlob 接口用于表示任意长度的数据
    // 本例使用该接口声明一个对象来存放编译后的着色器
    ID3DBlob* pVSBlob  = NULL;

    // 从指定文件编译着色器
    if (FAILED(D3DX11CompileFromFile(
               L"Triangle.hlsl",  // 这是我们创建的 hlsl 文件
               NULL,              // 可选项, 指向一个宏定义数组的指针, 一般为 NULL
               NULL,              // 用于处理着色器中的 include 文件, 没有 include 文件则为 NULL
               "VSMain",          // 指定顶点着色器的入口函数
               "vs_5_0",          // 指定顶点着色器版本, 这里是用 5.0 版本
               dwShaderFlag,      // 上面定义的着色器编译标识符
               0,                 // Effect 编译标识符, 如果不是编译 Effect 文件则设置为 0
               NULL,              // 指向 ID3DX11ThreadPump 的指针,
                                  // 设置为 NULL 表示这个函数在完成之前不会返回
               &pVSBlob,          // 指向编译好的顶点着色器的所在内存的指针
               NULL,              // 指向存放在编译中产生错误和警告的指针
               NULL)))            // 一个指向返回值的指针, 如果第八个参数为 NULL,
                                  // 这里也设置为 NULL
    {
        // 如果编译失败, 弹出一个消息框
        MessageBox(NULL, L"Fail to compile vertex shader", L"ERROR", MB_OK);

        return S_FALSE;
    }

    // 用 CreateVertexShader 创建顶点着色器
    device->CreateVertexShader(
            pVSBlob->GetBufferPointer(),  // 指向 pVSBlob 所在内存块的起始地址
            pVSBlob->GetBufferSize(),     // 取得 pVSBlob 的大小
            NULL,                         // 指向 ID3D11ClassLinkage 的指针, 一般为空
            &vertexShader);               // 将创建好的顶点着色器存放到 vertexShader 中

    // 第二步, 创建像素着色器
    // 声明一个 ID3DBlob 对象来存放编译后的像素着色器
    ID3DBlob* pPSBlob  = NULL;
    if (FAILED(D3DX11CompileFromFile(
               L"Triangle.hlsl",  // 这是我们创建的 hlsl 文件
               NULL,              // 可选项, 指向一个宏定义数组的指针, 一般为 NULL
               NULL,              // 用于处理着色器中的 include 文件, 没有 include 文件则为 NULL
               "PSMain",          // 指定像素着色器的入口函数
               "ps_5_0",          // 指定像素着色器版本, 这里是用 5.0 版本
               dwShaderFlag,      // 上面定义的着色器编译标识符
               0,                 // Effect 编译标识符, 如果不是编译 Effect 文件则设置为 0
               NULL,              // 指向 ID3DX11ThreadPump 的指针,
                                  // 设置为 NULL 表示这个函数在完成之前不会返回
               &pPSBlob,          // 指向编译好的像素着色器的所在内存的指针
               NULL,              // 指向存放在编译中产生错误和警告的指针
               NULL)))            // 一个指向返回值的指针, 如果第八个参数为 NULL,
                                  // 这里也设置为 NULL
    {
        MessageBox(NULL, L"Fail to compile pixel shader", L"ERROR", MB_OK);

        return S_FALSE;
    }

    // 用 CreatePixelShader 创建像素着色器
    device->CreatePixelShader(
            pPSBlob->GetBufferPointer(),  // 指向 pPSBlob 所在内存块的起始地址
            pPSBlob->GetBufferSize(),     // 取得 pPSBlob 的大小
            NULL,                         // 指向 ID3D11ClassLinkage 的指针, 一般为空
            &pixelShader);                // 将创建好的像素着色器存放到 pixelShader 中

    pPSBlob->Release();

    // 第三步, 创建并设置输入布局
    // 所谓输入布局, 就是制定顶点结构所包含信息的实际意义
    // D3D11_INPUT_ELEMENT_DESC 用于描述顶点结构的意义
    // 以便让显卡识别所定义的顶点结构
    // 这里定义一个 D3D11_INPUT_ELEMENT_DESC 数组,
    // 由于定义的顶点结构只有位置坐标, 所有这个数组里也只有一个元素
    D3D11_INPUT_ELEMENT_DESC layout[] = 
    {
        {
            "POSITION",  // 语义标识符, 必须和 hlsl 文件中 VSMain 所用的标识符一致
            0,           // 表示第 1 个元素, 注意和数组一样都是从 0 开始计数,
            DXGI_FORMAT_R32G32B32_FLOAT,  // 96 位浮点像素, 红绿蓝各 32 位
            0,           // 可以取值 0 - 15, 0 表示绑定顶点缓存到第一个输入槽
            0,           // 可选项, 定义了缓存的对齐方式,
            D3D11_INPUT_PER_VERTEX_DATA,     // 定义输入数据类型为顶点数据
            0            // 本例没有使用实例技术, 所以这里为 0
        }
    };

    // 获取输入布局中元素个数
    UINT numElements = ARRAYSIZE(layout);

    // 声明一个输入布局对象 pVertexLayout 用于存放创建好的布局
    ID3D11InputLayout* pVertexLayout;

    // 调用 CreateInputLayout 创建输入布局
    device->CreateInputLayout(
            layout,                       // 上面定义的 D3D11_INPUT_ELEMENT_DESC 数组
            numElements,                  // D3D11_INPUT_ElEMENT_DESC 数组的元素个数
            pVSBlob->GetBufferPointer(),  // 指向顶点着色器起始位置的指针
            pVSBlob->GetBufferSize(),     // 指向顶点着色器的所在内存大小
            &pVertexLayout);              // 返回生成的输入布局对象

    pVSBlob->Release();

    // 设置生成的输入布局
    immediateContext->IASetInputLayout(pVertexLayout);

    pVertexLayout->Release();

    // 第四步, 创建顶点缓存
    // 用我们自己定义的 Vertex 结构创建三角形的三个顶点坐标
    Vertex vertices[] = 
    {
        XMFLOAT3(0.0f, 0.5f, 0.0f),
        XMFLOAT3(0.5f, 0.0f, 0.0f),
        XMFLOAT3(-0.5f, 0.0f, 0.0f)
    };

    // 填充 D3D11_BUFFER_DESC 结构, 这个结构是用来描述顶点缓存的属性
    // 首先声明一个 D3D11_BUFFER_DESC 的对象 bd
    D3D11_BUFFER_DESC bd;
    ZeroMemory(&bd, sizeof(bd));                   // 进行清零操作
    bd.Usage          = D3D11_USAGE_DEFAULT;       // 设置缓存的读写方式, 一般用默认方式
    bd.ByteWidth      = sizeof(Vertex) * 3;        // 设置缓存区域的大小,
                                                   // 由于有三个顶点所以要乘以 3
    bd.BindFlags      = D3D11_BIND_VERTEX_BUFFER;  // 将这个缓存区域绑定到顶点缓存
    bd.CPUAccessFlags = 0;                         // CPU 访问标识符, 0 表示没有 CPU 访问
    bd.MiscFlags      = 0;                         // 其他项标识符, 0 表示不使用该项

    // 声明一个数据用于初始化子资源
    D3D11_SUBRESOURCE_DATA initData;
    ZeroMemory(&initData, sizeof(initData));       // 进行清零操作
    initData.pSysMem  = vertices;                  // 设置需要初始化的数据, 即顶点数组

    // 声明一个 ID3D11Buffer 对象作为顶点缓存
    ID3D11Buffer* vertexBuffer;

    // 调用 CreateBuffer 创建顶点
    device->CreateBuffer(&bd, &initData, &vertexBuffer);
    UINT stride = sizeof(Vertex);     // 获取 Vertex 的大小作为跨度
    UINT offset = 0;                  // 设置偏移量为 0
    
    // 设置顶点缓存
    immediateContext->IASetVertexBuffers(
                      0,              // 绑定到第一个输入槽
                      1,              // 顶点缓存的个数, 这里为一个
                      &vertexBuffer,  // 创建好的顶点缓存
                      &stride,        // 跨度, 即顶点结构的大小
                      &offset);       // 缓存第一个元素到所用元素的偏移量

    vertexBuffer->Release();

    // 指定图元类型, D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST 表示图元为三角形
    immediateContext->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
    
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
    if (vertexShader)
    {
        vertexShader->Release();
    }
    if (pixelShader)
    {
        pixelShader->Release();
    }
}

bool Display(float timeDelta)
{
    if (device)
    {
        // 声明一个数组存放颜色信息, 4 个元素分别表示红, 绿, 蓝以及 alpha
        float ClearColor[4] = { 0.0f, 0.125f, 0.3f, 1.0f };

        // 清除渲染目标视图
        immediateContext->ClearRenderTargetView(renderTargetView,
                                                ClearColor);

        // 把创建好的顶点着色器和像素着色器绑定到 immediateContext
        immediateContext->VSSetShader(vertexShader, NULL, 0);
        immediateContext->PSSetShader(pixelShader, NULL, 0);

        // 绘制三角形, 第一个参数表示绘制 3 个点
        // 第二个参数表示从第 0 个点开始绘制
        immediateContext->Draw(3, 0);

        swapChain->Present(0, 0);
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
