/*************************************************************************
    > File Name: Triangle.hlsl
    > Author: YLD10
    > Mail: yl1315348050@yahoo.com
    > Created Time: 2018.6.1 21:40
    > Describe: Win32 Application InitD3D.
                ������ DirectX11 �� 3D ͼ�γ�����ư����̡̳�
                5.2 �ڳ������� ����һ��������
************************************************************************/

/*
 * ������ɫ�� (Vertex Shader)
 * float4 Ϊ HLSL �ṩ�Ĺؼ���, ��ʾһ�� 4 ά����, ÿ��������һ��������
 * VSMain Ϊ������ɫ������������, ���ֿ�������ȡ
 * POSITION Ϊ�����ʾ��, �ڴ������벼��ʱ���õ�
 * SV_POSITION Ϊ HLSL ��ʶ��, ��ʾ�ú������ص���һ������
 * ע�����ֺ��������������б��� C/C++, ������������
 * ��������       ��������        ��������    ����ֵ����
 *    ��             ��              ��            ��
 *  float4 VSMain(float4 Pos : POSITION) : SV_POSITION
 */
float4 VSMain(float4 Pos : POSITION) : SV_POSITION
{
    return Pos;
}

/*
 * ������ɫ��(Pixel Shader)
 * PSMain Ϊ������ɫ������������, ���ֿ�������ȡ
 * SV_TARGET Ϊ HLSL ��ʶ��, ��ʾ�ú������ص���һ����ɫ
 */
float4 PSMain(float4 Pos : POSITION) : SV_TARGET
{
    // ����һ�� 4 ά����, �ֱ��ʾ�������� alpha, �����ʾ�������Ǻ�ɫ��
    return float4(1.0f, 0.0f, 0.0f, 1.0f);
}
