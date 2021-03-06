/*************************************************************************
> File Name: MatrixTrans.cpp
> Author: YLD10
> Mail: yl1315348050@yahoo.com
> Created Time: 2018.5.30 21:11
> Describe: Win32 Console Application MatrixTrans.
《基于 DirectX11 的 3D 图形程序设计案例教程》
3.3 节程序例子 利用 XNA 数学库实现矩阵变换
************************************************************************/
#include "stdafx.h"

// 本例由于需要使用 XNA 函数库
// 所以需要包含 "d3dcompiler.h" 和 "xnamath.h"
#include <iostream>
#include <d3dcompiler.h>
#include <xnamath.h>

/*
* 重载 "<<" 操作符，让 XMVECTOR 的对象也可以使用 "cout <<" 进行输出，
* 向量会以 (X, X, X) 形式输出到屏幕上
*/
std::ostream& operator << (std::ostream& os, XMVECTOR u)
{
    // XMVectorGetX(), XMVectorGetY(), XMVectorGetZ(), XMVectorGetW()
    // 这 4 个函数用来获取 XMVECTOR 的 4 的分量
    os << '('
        << XMVectorGetX(u) << ','
        << XMVectorGetY(u) << ','
        << XMVectorGetZ(u) << ','
        << XMVectorGetW(u)
        << ')'
        << std::endl;

    return os;
}

/*
* 重载 "<<" 操作符，让 XMFLOAT4X4 的对象也可以使用 "cout <<" 进行输出，
* 矩阵会以行-列的形式输出到屏幕上
* 注意: 这里使用 XMFLOAT4X4 对象作为参数而不是 XMMATRIX 作为参数
*       这是因为系统 (x64/x86) 不同会存在字节对齐的问题，
*       使用 XMMATRIX 会报以下错误
*       error C2719: "m": 具有 __declspec(align('16')) 的形参将不被对齐
*/
std::ostream& operator << (std::ostream& os, XMFLOAT4X4 m)
{
    for (int i = 0; i < 4; ++i)
    {
        for (int j = 0; j < 4; ++j)
        {
            // 通过 XMFLOAT4X4 的重载括号操作符引用矩阵元素
            os << '\t' << m(i, j) << ' ';
        }
        os << std::endl;
    }
    os << std::endl;

    return os;
}

int main()
{
    // 声明 3 个 XMMATRIX 对象
    // 分别用来表示平移矩阵 (mTrans), 旋转矩阵 (mRota),
    // 以及缩放矩阵 (mScal)
    XMMATRIX mTrans, mRota, mScal;

    // 第一步: 生成缩放矩阵
    // 调用 XMMatrixScaling() 函数用以生成缩放矩阵, 该函数 3 个参数分别表示
    // 在 X, Y, Z 轴上的缩放量
    // 在 X, Y, Z 轴上缩小到 1/5 (即 0.2), 然后将生成的缩放矩阵赋值给 mScal
    mScal = XMMatrixScaling(0.2f, 0.2f, 0.2f);

    // 将生成的缩放矩阵打印到控制台上, 这里只是方便我们查看生成的矩阵
    std::cout << "缩放矩阵为: " << std::endl;

    // 由于重载的输出操作符 << 是针对 XMFLOAT4X4 对象, 多以这里要将 XMMATRIX
    // 对象转换为 XMFLOAT4X4 对象
    // 首先声明一个 XMFLOAT4X4 对象
    XMFLOAT4X4 mScalFL;

    // 利用 XMStoreFloat4x4 函数把 mScal 的内容存入 XMFLOAT4X4 对象 mScalFL 中
    XMStoreFloat4x4(&mScalFL, mScal);
    std::cout << mScalFL;

    // 第二步: 生成旋转矩阵
    // 绕 Y 轴旋转 45 度, 即 1/4 PI
    // 调用 XMMatrixRotationY() 函数用以生成旋转矩阵, 该函数的参数为旋转的弧度
    // XM_PIDIV4 为 XNA 库定义的数据常量表示 1/4 PI
    mRota = XMMatrixRotationY(XM_PIDIV4);

    // 将生成的旋转矩阵打印到控制台上, 方法同上
    std::cout << "旋转矩阵为: " << std::endl;
    XMFLOAT4X4 mRotaFL;
    XMStoreFloat4x4(&mRotaFL, mRota);
    std::cout << mRotaFL;

    // 第三步: 生成平移矩阵
    // 在 X 轴平移 1 个单位, 在 Y 轴平移 2 个单位, 在 Z 轴平移 -3 个单位
    // 调用函数 XMMatrixTranslation() 生成平移矩阵
    // 该函数 3 个参数分别表示在 X, Y, Z 轴上的平移量
    mTrans = XMMatrixTranslation(1.0f, 2.0f, -3.0f);

    // 将生成的平移矩阵打印到控制台上, 方法同上
    std::cout << "平移矩阵为: " << std::endl;
    XMFLOAT4X4 mTransFL;
    XMStoreFloat4x4(&mTransFL, mTrans);
    std::cout << mTransFL;

    // 第四步: 将上面生成的 3 个变换矩阵合成一个最终的变换矩阵
    // 首先声明一个 XMMATRIX 对象用来存放最终的变换矩阵
    XMMATRIX mFinal;

    // 利用 XMMatrixMultiply 来完成矩阵的相乘,
    // 注意: 由于矩阵相乘不具有交换性, 所以乘法时各个变换矩阵的顺序很重要
    // 例子中的变换顺序是缩小 (mScal) -> 旋转 (mRota) -> 平移 (mTrans)

    // 所以这里首先将 mScal 和 mRota 相乘的中间结果放入 mFinal 中
    mFinal = XMMatrixMultiply(mScal, mRota);

    // 再将中间结果与 mTrans 相乘, 得到最终结果并覆盖先前的 mFinal
    mFinal = XMMatrixMultiply(mFinal, mTrans);

    // 将生成的变换矩阵打印到控制台上
    std::cout << "变换矩阵为: " << std::endl;
    XMFLOAT4X4 mFinalFL;
    XMStoreFloat4x4(&mFinalFL, mFinal);
    std::cout << mFinalFL;

    // 按照例子声明一个 XMVECTOR 对象
    // 例子中向量为 3 维向量, 而 XMVectorSet 只能生成 4 维向量,
    // 最后一个分量如果是 1 表示这是一个点, 如果是 0 表示这是一个向量
    // 这种向量称之为 "齐次向量"
    XMVECTOR vector = XMVectorSet(5.0f, 0.0f, 0.0f, 1.0f);

    // 利用重载的操作符 << 将声明的 XMVECTOR 对象打印到控制台上
    std::cout << "变换前的向量: " << std::endl;
    std::cout << vector;

    // 将上面生成的最终变换矩阵应用到 XMVECTOR 对象上
    // 并将生成的向量了覆盖原来的向量
    vector = XMVector4Transform(vector, mFinal);

    // 将最终的向量打印到控制台上
    std::cout << "变换后的向量为: " << std::endl;
    std::cout << vector;

    system("pause");  // 让控制台不要闪退

    return 0;
}