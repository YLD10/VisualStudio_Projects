#include "stdafx.h"

int WINAPI WinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPSTR lpCmdLine,
	int nCmdShow)
{
	LPCSTR	DEFAULT_CONSOLE_TITLE = (LPCSTR)"CV";

	AllocConsole();
	
	FILE *stream;
	freopen_s(&stream, "CON", "r", stdin);
	freopen_s(&stream, "CON", "w", stdout);

	HWND _consoleHwnd;
	HDC conDC;
	HANDLE _handleOutput;
	CONSOLE_CURSOR_INFO CursorInfo;

	SetConsoleTitle(DEFAULT_CONSOLE_TITLE); //设置窗口名
	Sleep(100);
	_consoleHwnd = FindWindow(NULL, DEFAULT_CONSOLE_TITLE);
	if (_consoleHwnd)
	{
		_handleOutput = GetStdHandle(STD_OUTPUT_HANDLE);

		GetConsoleCursorInfo(_handleOutput, &CursorInfo);//获取控制台光标信息  
		CursorInfo.bVisible = false; //隐藏控制台光标  
		SetConsoleCursorInfo(_handleOutput, &CursorInfo);//设置控制台光标状态  

		char buf[30] = { 0 };
		snprintf(buf, sizeof(buf), "mode con cols=%d lines=%d", winWid, winHei);
		system(buf);

		SMALL_RECT rect = SizeOfWindow(_handleOutput);
		COORD size = { rect.Right + 1, rect.Bottom + 1 };
		SetConsoleScreenBufferSize(_handleOutput, size);
		SetWindowLong(_consoleHwnd, GWL_STYLE, GetWindowLong(_consoleHwnd, GWL_STYLE) & ~WS_MAXIMIZEBOX & ~WS_THICKFRAME);
		
		cv(_handleOutput);

		conDC = ::GetDC(_consoleHwnd);
		while (true)
		{
			draw(conDC);
			if (_kbhit())
				break;
		}
		
		CloseHandle(_handleOutput);
		ReleaseDC(_consoleHwnd, conDC);
	}

	return 0;
}