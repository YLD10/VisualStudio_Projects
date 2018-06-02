/*************************************************************************
	> File Name: d3dUtility.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.5.31 22:56
    > Describe: Win32 Application InitD3D.
                ������ DirectX11 �� 3D ͼ�γ�����ư����̡̳�
                4.2 �ڳ������� ��ʼ�� D3D
 ************************************************************************/
 #include "d3dUtility.h"

/*
 * D3D ��ʼ��
 * ��������а�����������: ��һ����: ����һ������; �ڶ�����: ��ʼ�� D3D
 * ������������:
 * 1.HINSTANCE   ��ǰӦ�ó���ʵ���ľ��
 * 2.int width   ���ڿ�
 * 3.int height  ���ڸ�
 * 4.ID3D11RenderTargetView** renderTargetView  Ŀ����Ⱦ��ͼָ��
 * 5.ID3D11DeviceContext** immediateContext     ����ִ��������ָ��
 * 6.IDXGISwapChain** swapChain                 ������ָ��
 * 7.ID3D11Device** device                      �豸��ָ��, ÿ�� D3D ����������һ���豸
 */
bool d3d::InitD3D(HINSTANCE hInstance, 
                  int width, int height, 
                  ID3D11RenderTargetView** renderTargerView, 
                  ID3D11DeviceContext** immediateContext, 
                  IDXGISwapChain** swapChain, 
                  ID3D11Device** device)
{
    //************* ��һ����: ����һ�����ڿ�ʼ ***************
    // �ⲿ�ֵĴ���� 2.2 ���д������ڴ������һ��
    // ���������ע�Ϳ��Բο� 2.2 �ڳ�������
    // �������ڵ� 4 ������: 1 ���һ��������; 2 ע�ᴰ����
    //                    3 ��������;       4 ������ʾ�͸���
    // 1 ���һ��������
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

    // 2 ע�ᴰ����
    if (!RegisterClass(&wc))
    {
        ::MessageBox(0, L"RegisterClass() - FAILED", 0, 0);

        return false;
    }

    // 3 ��������
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

    // 4 ������ʾ�͸���
    ::ShowWindow(hwnd, SW_SHOW);
    ::UpdateWindow(hwnd);

    //************* ��һ����: ����һ�����ڽ��� ***************
    
    //************* �ڶ�����: ��ʼ�� D3D ��ʼ ***************
    // ��ʼ�� D3D �豸��ҪΪ���²���
    // 1. ����������, ����� DXGI_SWAP_CHAIN_DESC �ṹ
    // 2. ʹ�� D3D11CreateDeviceAndSwapChain ���� D3D �豸 (ID3D11Device)
    //    ִ�������Ľӿ� (ID3D11DeviceContext), �������ӿ� (IDXGISwapChain)
    // 3. ����Ŀ����Ⱦ��ͼ (ID3D11RenderTargetView)
    // 4. �����ӿ� (View Port)

    // ��һ��, ����������, ����� DXGI_SWAP_CHAIN_DESC �ṹ
    DXGI_SWAP_CHAIN_DESC sd;          // ��������һ�� DXGI_SWAP_CHAIN_DESC �Ķ��� sd
    ZeroMemory(&sd, sizeof(sd));      // �� ZeroMemory �� sd ���г�ʼ��
    sd.BufferCount       = 1;         // �������к�̨��������, ͨ��Ϊ 1
    sd.BufferDesc.Width  = width;     // �������еĴ��ڿ�
    sd.BufferDesc.Height = height;    // �������еĴ��ڸ�
    sd.BufferDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;    // ��ʾ������ Alpha �� 8 λ
    sd.BufferDesc.RefreshRate.Numerator   = 60;           // ˢ��Ƶ�ʵķ���Ϊ 60
    sd.BufferDesc.RefreshRate.Denominator = 1;            // ˢ��Ƶ�ʵķ�ĸΪ 1, ��
                                                          // ˢ��Ƶ��Ϊÿ�� 60 ��
    sd.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;     // ����������̨�����÷�
                                                          // ���� CPU �Ժ�̨����ķ���
    sd.OutputWindow       = hwnd;     // ָ����ȾĿ�괰�ڵľ��
    sd.SampleDesc.Count   = 1;        // ���ز���, �����в����ö��ز���
    sd.SampleDesc.Quality = 0;        // ���� Count = 1, Quality = 0
    sd.Windowed           = TRUE;     // TRUE Ϊ����ģʽ, FALSE Ϊȫ��ģʽ

    // �ڶ���, �����豸, �������Լ�����ִ��������
    // ����һ������ȷ�����Դ��� Featurelevel ��˳��
    D3D_FEATURE_LEVEL featureLevels[] =
    {
        D3D_FEATURE_LEVEL_11_0,  // D3D11 ��֧�ֵ�����, ���� shader model 5
        D3D_FEATURE_LEVEL_10_1,  // D3D10 ��֧�ֵ�����, ���� shader model 4
        D3D_FEATURE_LEVEL_10_0
    };

    // ��ȡ D3D_FEATURE_LEVEL �����Ԫ�ظ���
    UINT numFeatureLevels = ARRAYSIZE(featureLevels);

    // ���� D3D11CreateDeviceAndSwaoChain �������������豸��ִ��������
    // �ֱ���� swapChain, device, immediateContext
    if (FAILED(D3D11CreateDeviceAndSwapChain(
               NULL,                // ȷ����ʾ������, NULL ��ʾĬ����ʾ������
               D3D_DRIVER_TYPE_HARDWARE,  // ��������, �����ʾʹ����άӲ������
               NULL,                // ֻ����һ����������Ϊ
                                    // D3D_DRIVER_TYPE_SOFTWARE ʱ��ʹ�øò���
               0,                   // Ҳ��������Ϊ D3D11_CREATE_DEVICE_DEBUG ��������ģʽ
               featureLevels,       // ǰ�涨��� D3D_FEATURE_LEVEL ����
               numFeatureLevels,    // D3D_FEATURE_LEVEL ��Ԫ�ظ���
               D3D11_SDK_VERSION,   // SDK �İ汾, ����Ϊ D3D11
               &sd,                 // ǰ�涨��� DXGI_SWAP_CHAIN_DESC ����
               swapChain,           // ���ش����õĽ�����ָ��, InitD3D �������ݵ�ʵ��
               device,              // ���ش����õ��豸��ָ��, InitD3D �������ݵ�ʵ��
               NULL,                // ���ص�ǰ�豸֧�ֵ� featureLevels �����еĵ�һ������,
                                    // һ������Ϊ NULL
               immediateContext)))  // ���ش����õ�ִ��������ָ��,
                                    // InitD3D �������ݵ�ʵ��
    {
        ::MessageBox(0, L"CreateDevice - FAILED", 0, 0);

        return false;
    }

    // ������, ������������ȾĿ����ͼ
    HRESULT hr = 0;                         // COM Ҫ�����еķ������᷵��һ�� HRESULT ���͵Ĵ����
    ID3D11Texture2D* pBackBuffer = NULL;    // ID3D11Texture2D ���͵ĺ�̨����ָ��

    // ���� GetBuffer() �����õ���̨�������, ������ &pBackBuffer ��
    hr = (*swapChain)->GetBuffer(0,         // ��������, һ������Ϊ 0
                                 __uuidof(ID3D11Texture2D),  // ��������
                                 (LPVOID*)&pBackBuffer);     // ����ָ��
    // �ж� GetBuffer �Ƿ���óɹ�
    if (FAILED(hr))
    {
        ::MessageBox(0, L"GetBuffer - FAILED", 0, 0);

        return false;
    }

    // ���� CreateRenderTargetView ��������ȾĿ����ͼ
    // ��������� renderTargetView ��
    hr = (*device)->CreateRenderTargetView(pBackBuffer,        // ���洴���õĺ�̨����
                                           NULL,               // ����Ϊ NULL �õ�Ĭ�ϵ���ȾĿ����ͼ
                                           renderTargerView);  // ���ش����õ���ȾĿ����ͼ
                                                               // InitD3D �������ݵ�ʵ��
    pBackBuffer->Release();  // �ͷź�̨����

    // �ж� CreateRenderTargetView �Ƿ���óɹ�
    if (FAILED(hr))
    {
        ::MessageBox(0, L"CreateRender - FAILED", 0, 0);

        return false;
    }

    // ����ȾĿ����ͼ�󶨵���Ⱦ����
    (*immediateContext)->OMSetRenderTargets(1,                 // �󶨵�Ŀ����ͼ�ĸ���
                                            renderTargerView,  // ��ȾĿ����ͼ
                                            NULL);             // �������ģ��

    // ���Ĳ�, �����ӿڴ�С, D3D11 Ĭ�ϲ��������ӿ�, �˲�������ֶ�����
    D3D11_VIEWPORT vp;      // ����һ���ӿڵĶ���
    vp.Width    = width;    // �ӿڵĿ�
    vp.Height   = height;   // �ӿڵĸ�
    vp.MinDepth = 0.0f;     // ���ֵ������, �������ֵ�� [0, 1] ��������ֵ�� 0
    vp.MaxDepth = 1.0f;     // ���ֵ������, ����ֵ�� 1
    vp.TopLeftX = 0;        // �ӿ����Ͻǵĺ�����
    vp.TopLeftY = 0;        // �ӿ����Ͻǵ�������

    // �����ӿ�
    (*immediateContext)->RSSetViewports(1,      // �ӿڵĸ���
                                        &vp);   // ���洴�����ӿڶ���

    return true;

    //************* �ڶ�����: ��ʼ�� D3D ���� ***************
}

/*
 * ��Ϣѭ������, ��֮ǰ "Hello World" ������ Run() ��ͬ���Ĺ���
 * bool(*ptr_display)(float timeDelta) ��ʾ����һ������ָ����Ϊ����
 * ���������һ�� float ���͵Ĳ���, ��һ�� bool ���͵ķ���
 */
int d3d::EnterMsgLoop(bool(*ptr_display)(float timeDelta))
{
    MSG msg;
    ::ZeroMemory(&msg, sizeof(MSG));                // ��ʼ���ڴ�

    static float lastTime = (float)timeGetTime();   // ��һ�λ�ȡ��ǰʱ��
    
    while (WM_QUIT != msg.message)
    {
        if (::PeekMessage(&msg, 0, 0, 0, PM_REMOVE))
        {
            ::TranslateMessage(&msg);
            ::DispatchMessage(&msg);
        }
        else
        {
            // �ڶ��λ�ȡ��ǰʱ��
            float currTime  = (float)timeGetTime();
            
            // ��ȡ����ʱ��֮���ʱ���
            float timeDelta = (currTime - lastTime) * 0.001f;

            // ������ʾ����, ���ں���ʱ��ͼ�εı仯 (����ת) ʱ���õ�
            ptr_display(timeDelta);
            lastTime = currTime;
        }
    }
    
    return msg.wParam;
}
 
 