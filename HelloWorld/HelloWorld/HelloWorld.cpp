/*************************************************************************
	> File Name: HelloWorld.cpp
	> Author: YLD10
	> Mail: yl1315348050@yahoo.com
	> Created Time: 2018.5.28 23:31
	> Describe: Win32 Application HelloWorld.
                ������ DirectX11 �� 3D ͼ�γ�����ư����̡̳�
                2.2 �ڳ������� Hello World
 ************************************************************************/

// ���ͷ�ļ����� Win32 API �Ļ���Ԫ������Ҫ�Ľṹ
#include <windows.h>

// һ�����ڵľ��������һ��ȫ�ֱ�����������õ�
HWND MainWindowHandle = 0;

/* 
 * ������ʼ�����ڵ� InitWindowsApp �����ĺ�����
 */
bool InitWindowsApp(HINSTANCE instanceHandle, int show);

/*
 * �������ڷ�װ��Ϣѭ���� Run �����ĺ�����
 */
int Run();

/*
 * �����ص����� WnProc �ĺ�����
 */
LRESULT CALLBACK WndProc(HWND hWnd,
						 UINT msg,
						 WPARAM wParam,
						 LPARAM lParam);

/*
 * hInstance���ǵ�ǰʵ���ľ������νʵ������ָӦ�ó�����
 * hPreInstance����ʹ�øò�����Win32 �ò���ʼ��Ϊ NULL
 * pCmdLine���������г���������в����ַ���
 * nShowCmd��ָ�����ڵ���ʾ��ʽ
 */
int WINAPI WinMain(HINSTANCE hInstance,
	               HINSTANCE hPreInstance,
	               PSTR pCmdLine,
	               int nShowCmd)
{
// ���ô��ڳ�ʼ��������������óɹ��������Ϣѭ�������򵯳�һ���Ի���
	if (!InitWindowsApp(hInstance, nShowCmd))
	{
		::MessageBox(0, L"Init - Failed", L"Error", MB_OK);

		return 0;
	}

	return Run();
}

/*
* ������ʼ�����ڵ� InitWindowsApp �����ĺ�����
*/
bool InitWindowsApp(HINSTANCE instanceHandle, int show)
{
	WNDCLASS wc;
	wc.style		= CS_HREDRAW | CS_VREDRAW;
					// �����һ�������� WNDCLASS �Ķ����崰�ڵ���ʽ��
					// ��������Ǳ��������ڵ�ˮƽ��ֱ�ߴ緢���仯ʱ��
					// ���ڽ����ػ�
	wc.lpfnWndProc	 = WndProc;  // ����ָ���ص�������ָ�룬���Ϸ��ص�����ͬ��
	wc.cbClsExtra	 = 0;
    wc.cbWndExtra    = 0;
    wc.hInstance     = instanceHandle;  // ��ǰӦ�ó���ʵ���ľ������ WinMain ����
    wc.hIcon         = ::LoadIcon(0, IDI_APPLICATION);  // ָ��ͼ��
    wc.hCursor       = ::LoadCursor(0, IDC_ARROW);      // ָ�����
    wc.hbrBackground = static_cast<HBRUSH>(::GetStockObject(WHITE_BRUSH));
    wc.lpszMenuName  = 0;               // ָ�����޲˵���0 Ϊ�޲˵�   
    wc.lpszClassName = L"Hello";        // ָ�򴰿�����ָ��

    if (!::RegisterClass(&wc))
    {
        ::MessageBox(0, L"RegisterClass - Failed", 0, 0);
        
        return false;
    }

    // ���ǵ�һ���õ� MainWindowHandle���û���������
    MainWindowHandle = ::CreateWindow(
                        L"Hello",       // ��һ�� ��Hello�� ����� wc.lpszClassName ��ͬ
                        L"Hello",       // �ڶ��� ��Hello�� �Ǵ��ڵ���ʾ����
                        WS_OVERLAPPEDWINDOW,            // ָ���������ʱ�ص�ʽ����
                        CW_USEDEFAULT,  // ��ʾ���ڵĺ�����ΪĬ��ֵ
                        CW_USEDEFAULT,  // ��ʾ���ڵ�������ΪĬ��ֵ
                        CW_USEDEFAULT,  // ��ʾ���ڵĿ�ΪĬ��ֵ
                        CW_USEDEFAULT,  // ��ʾ���ڵĸ�ΪĬ��ֵ
                        0,
                        0,
                        instanceHandle,
                        0);

    // ������ڵĴ���ʧ�� MainWindowHandle ����Ϊ 0,�򱨴�����
    if (!MainWindowHandle)
    {
        ::MessageBox(0, L"CreateWindow - Failed", 0, 0);

        return false;
    }

    // ��ʾ���ڣ��ô��ھ�� MainWindoeHandle ��ָ����Ҫ��ʾ�Ĵ���
    ::ShowWindow(MainWindowHandle, show);

    //���´��ڣ��ô��ھ�� MainWindowHandle ��ָ����Ҫ���µĴ���
    ::UpdateWindow(MainWindowHandle);

    return true;
}

/*
* �������ڷ�װ��Ϣѭ���� Run �����ĺ�����
*/
int Run()
{
    MSG msg;
    ::ZeroMemory(&msg, sizeof(msg));    // ZeroMemory �� 0 ���һ���ڴ�����

    // GetMessage() ���ϵش���Ϣ�����м�����Ϣ��Ȼ����䵽 MSG �ṹ�ĳ�Ա
    while (::GetMessage(&msg, 0, 0, 0))
    {
        ::TranslateMessage(&msg);       // ����Ϣ msg �������ת��Ϊ�ַ���Ϣ
        ::DispatchMessage(&msg);        // ���ս���Ϣ���͵�ָ���Ĵ��ڹ����У�
                                        // �������о��ǽ���Ϣ�����ص����� WndProc ��
    }

    return msg.wParam;
}

/*
* �����ص����� WnProc �ĺ�����
*/
LRESULT CALLBACK WndProc(HWND windowHandle,
                         UINT msg,
                         WPARAM wParam,
                         LPARAM IParam)
{
    // ���ݲ��� msg �ļ�ֵ�жϲ�׽������Ϣ������
    switch (msg)
    {
    // ��������������򵯳���Ϣ������ WM_LBUTTONDOWN ���������ļ�ֵ
    case WM_LBUTTONDOWN:
        // L"Hello, World" ����Ϣ������ʾ������
        // L"Hello" �����ڸ����ڵ�ָ��
        // MB_OK ��ʾ��Ϣ����ʾ ��ȷ���� ��ť
        ::MessageBox(0, L"Hello, World", L"Hello", MB_OK);
        
        return 0;

    // ������¼�������һ����
    case WM_KEYDOWN:
        // ����� ESC ����رմ���
        if (wParam == VK_ESCAPE)
        {
            ::DestroyWindow(MainWindowHandle);
        }

        return 0;
    
    // ����ǹرմ��ڵ���Ϣ������ PostQuitMessage() ���˳���Ϣѭ��
    case WM_DESTROY:
        ::PostQuitMessage(0);
        
        return 0;
    }

    // �� DefWindowProc ����һЩĬ�ϵ���Ϣ�����細�ڵ���󻯡���С���������ߴ��
    return ::DefWindowProc(windowHandle,
                           msg,
                           wParam,
                           IParam);
}
 