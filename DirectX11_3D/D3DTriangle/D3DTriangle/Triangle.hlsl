/*************************************************************************
    > File Name: Triangle.hlsl
    > Author: YLD10
    > Mail: yl1315348050@yahoo.com
    > Created Time: 2018.6.1 21:40
    > Describe: Win32 Application InitD3D.
                《基于 DirectX11 的 3D 图形程序设计案例教程》
                5.2 节程序例子 绘制一个三角形
************************************************************************/

/*
 * 顶点着色器 (Vertex Shader)
 * float4 为 HLSL 提供的关键字, 表示一个 4 维向量, 每个分量是一个浮点数
 * VSMain 为顶点着色器的主函数名, 名字可以任意取
 * POSITION 为语义表示符, 在创建输入布局时会用到
 * SV_POSITION 为 HLSL 标识符, 表示该函数返回的是一个坐标
 * 注意这种函数的声明方法有别于 C/C++, 具体意义如下
 * 返回类型       参数类型        参数语义    返回值语义
 *    ↓             ↓              ↓            ↓
 *  float4 VSMain(float4 Pos : POSITION) : SV_POSITION
 */
float4 VSMain(float4 Pos : POSITION) : SV_POSITION
{
    return Pos;
}

/*
 * 像素着色器(Pixel Shader)
 * PSMain 为像素着色器的主函数名, 名字可以任意取
 * SV_TARGET 为 HLSL 标识符, 表示该函数返回的是一个颜色
 */
float4 PSMain(float4 Pos : POSITION) : SV_TARGET
{
    // 返回一个 4 维向量, 分别表示红绿蓝和 alpha, 这里表示三角形是红色的
    return float4(1.0f, 0.0f, 0.0f, 1.0f);
}
