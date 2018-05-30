/*************************************************************************
	> File Name: HelloWorld.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.5.28 23:31
	> Describe: Win32 Application HelloWorld.
                《基于 DirectX11 的 3D 图形程序设计案例教程》
                2.2 节程序例子 Hello World
 ************************************************************************/

// 这个头文件包含 Win32 API 的基本元素所需要的结构
#include <windows.h>

// 一个窗口的句柄，这是一个全局变量，后面会用到
HWND MainWindowHandle = 0;

/* 
 * 声明初始化窗口的 InitWindowsApp 函数的函数体
 */
bool InitWindowsApp(HINSTANCE instanceHandle, int show);

/*
 * 声明用于封装消息循环的 Run 函数的函数体
 */
int Run();

/*
 * 声明回调函数 WnProc 的函数体
 */
LRESULT CALLBACK WndProc(HWND hWnd,
						 UINT msg,
						 WPARAM wParam,
						 LPARAM lParam);

/*
 * hInstance：是当前实例的句柄，所谓实例就是指应用程序本身
 * hPreInstance：不使用该参数，Win32 该参数始终为 NULL
 * pCmdLine：用于运行程序的命令行参数字符串
 * nShowCmd：指定窗口的显示方式
 */
int WINAPI WinMain(HINSTANCE hInstance,
	               HINSTANCE hPreInstance,
	               PSTR pCmdLine,
	               int nShowCmd)
{
// 调用窗口初始化函数，如果调用成功则进入消息循环，否则弹出一个对话框
	if (!InitWindowsApp(hInstance, nShowCmd))
	{
		::MessageBox(0, L"Init - Failed", L"Error", MB_OK);

		return 0;
	}

	return Run();
}

/*
* 声明初始化窗口的 InitWindowsApp 函数的函数体
*/
bool InitWindowsApp(HINSTANCE instanceHandle, int show)
{
	WNDCLASS wc;
	wc.style		= CS_HREDRAW | CS_VREDRAW;
					// 这就是一个窗口类 WNDCLASS 的对象定义窗口的样式，
					// 这两个标记表明当窗口的水平或垂直尺寸发生变化时，
					// 窗口将被重绘
	wc.lpfnWndProc	 = WndProc;  // 这里指定回调函数的指针，与上方回调函数同名
	wc.cbClsExtra	 = 0;
    wc.cbWndExtra    = 0;
    wc.hInstance     = instanceHandle;  // 当前应用程序实例的句柄，由 WinMain 传入
    wc.hIcon         = ::LoadIcon(0, IDI_APPLICATION);  // 指定图标
    wc.hCursor       = ::LoadCursor(0, IDC_ARROW);      // 指定光标
    wc.hbrBackground = static_cast<HBRUSH>(::GetStockObject(WHITE_BRUSH));
    wc.lpszMenuName  = 0;               // 指定有无菜单，0 为无菜单   
    wc.lpszClassName = L"Hello";        // 指向窗口名的指针

    if (!::RegisterClass(&wc))
    {
        ::MessageBox(0, L"RegisterClass - Failed", 0, 0);
        
        return false;
    }

    // 这是第一次用到 MainWindowHandle，用户创建窗口
    MainWindowHandle = ::CreateWindow(
                        L"Hello",       // 第一个 “Hello” 必须和 wc.lpszClassName 相同
                        L"Hello",       // 第二个 “Hello” 是窗口的显示名称
                        WS_OVERLAPPEDWINDOW,            // 指定这个窗口时重叠式窗口
                        CW_USEDEFAULT,  // 表示窗口的横坐标为默认值
                        CW_USEDEFAULT,  // 表示窗口的纵坐标为默认值
                        CW_USEDEFAULT,  // 表示窗口的宽为默认值
                        CW_USEDEFAULT,  // 表示窗口的高为默认值
                        0,
                        0,
                        instanceHandle,
                        0);

    // 如果窗口的创建失败 MainWindowHandle 将会为 0,则报错并返回
    if (!MainWindowHandle)
    {
        ::MessageBox(0, L"CreateWindow - Failed", 0, 0);

        return false;
    }

    // 显示窗口，用窗口句柄 MainWindoeHandle 来指定需要显示的窗口
    ::ShowWindow(MainWindowHandle, show);

    //更新窗口，用窗口句柄 MainWindowHandle 来指定需要更新的窗口
    ::UpdateWindow(MainWindowHandle);

    return true;
}

/*
* 声明用于封装消息循环的 Run 函数的函数体
*/
int Run()
{
    MSG msg;
    ::ZeroMemory(&msg, sizeof(msg));    // ZeroMemory 用 0 填充一块内存区域

    // GetMessage() 不断地从消息队列中检索消息，然后填充到 MSG 结构的成员
    while (::GetMessage(&msg, 0, 0, 0))
    {
        ::TranslateMessage(&msg);       // 将消息 msg 的虚拟键转换为字符信息
        ::DispatchMessage(&msg);        // 最终将消息传送到指定的窗口过程中，
                                        // 本程序中就是将消息传给回调函数 WndProc 中
    }

    return msg.wParam;
}

/*
* 声明回调函数 WnProc 的函数体
*/
LRESULT CALLBACK WndProc(HWND windowHandle,
                         UINT msg,
                         WPARAM wParam,
                         LPARAM IParam)
{
    // 根据参数 msg 的键值判断捕捉到的消息的类型
    switch (msg)
    {
    // 如果按下鼠标左键则弹出消息框，这里 WM_LBUTTONDOWN 是鼠标左键的键值
    case WM_LBUTTONDOWN:
        // L"Hello, World" 是消息框中显示的内容
        // L"Hello" 是所在父窗口的指针
        // MB_OK 表示消息框显示 “确定” 按钮
        ::MessageBox(0, L"Hello, World", L"Hello", MB_OK);
        
        return 0;

    // 如果按下键盘任意一个键
    case WM_KEYDOWN:
        // 如果是 ESC 键则关闭窗口
        if (wParam == VK_ESCAPE)
        {
            ::DestroyWindow(MainWindowHandle);
        }

        return 0;
    
    // 如果是关闭窗口的消息，则用 PostQuitMessage() 来退出消息循环
    case WM_DESTROY:
        ::PostQuitMessage(0);
        
        return 0;
    }

    // 用 DefWindowProc 处理一些默认的消息，比如窗口的最大化、最小化、调整尺寸等
    return ::DefWindowProc(windowHandle,
                           msg,
                           wParam,
                           IParam);
}
 