#pragma once
#define DLL_API extern "C" __declspec(dllexport)

DLL_API int __stdcall UgeeOpenDevice();										// 打开设备
DLL_API int __stdcall UgeeStartSign(int penWidth, const char* szSignPath);	// 开始签字
DLL_API int __stdcall UgeeGetBase64CallBack(BASE64_FUNC func);				// 获取base64回调函数
DLL_API int __stdcall UgeeZoom(const char* szDestFile, int Ratioo);			// 缩放
DLL_API int __stdcall UgeeCloseDevice();									// 关闭设备
DLL_API int __stdcall UgeeStartFinger(int quality, const char* szFingerPath);//指纹
DLL_API int __stdcall UgeeStartSignFinger(int penWidth, const char* szSignPath, int quality, const char* szFingerPath);//签字+指纹
DLL_API int __stdcall UgeeGetKeyCallBack(RESPONSE_MSG_FUNC func);				// 界面按键回调 取消3 重签1 确认2
DLL_API char* __stdcall UgeeGetSerialNum();									//返回序列号
DLL_API void __stdcall UgeeFreeMemory(char* ptr);									//释放内存