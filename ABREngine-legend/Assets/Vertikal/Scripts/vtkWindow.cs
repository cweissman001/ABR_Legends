

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkWindow : vtkObject {
		public vtkWindow(IntPtr p) : base(p) {}
		public static implicit operator  vtkWindow(IntPtr p) {return new vtkWindow(p);}
		public static implicit operator  IntPtr(vtkWindow o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkWindow* SafeDownCast(vtkObjectBase * o)
// "static vtkWindow* SafeDownCast(vtkObjectBase *o)"
public static vtkWindow SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.SafeDownCast_0(out returnPointer, o);
//	return (vtkWindow)(IntPtr)returnPointer;
	return (vtkWindow)(IntPtr)returnPointer;
}


// vtkWindow* NewInstance()
// "vtkWindow *NewInstance()"
public vtkWindow NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.NewInstance_0(out returnPointer, this);
//	return (vtkWindow)(IntPtr)returnPointer;
	return (vtkWindow)(IntPtr)returnPointer;
}


// virtual void SetDisplayId(void * ARG_0)
// "virtual void SetDisplayId(void *)"
public void SetDisplayId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkWindow.SetDisplayId_0(this, ARG_0);
}


// virtual void SetWindowId(void * ARG_0)
// "virtual void SetWindowId(void *)"
public void SetWindowId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkWindow.SetWindowId_0(this, ARG_0);
}


// virtual void SetParentId(void * ARG_0)
// "virtual void SetParentId(void *)"
public void SetParentId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkWindow.SetParentId_0(this, ARG_0);
}


// virtual void* GetGenericDisplayId()
// "virtual void *GetGenericDisplayId()"
public IntPtr GetGenericDisplayId() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.GetGenericDisplayId_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void* GetGenericWindowId()
// "virtual void *GetGenericWindowId()"
public IntPtr GetGenericWindowId() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.GetGenericWindowId_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void* GetGenericParentId()
// "virtual void *GetGenericParentId()"
public IntPtr GetGenericParentId() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.GetGenericParentId_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void* GetGenericContext()
// "virtual void *GetGenericContext()"
public IntPtr GetGenericContext() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.GetGenericContext_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void* GetGenericDrawable()
// "virtual void *GetGenericDrawable()"
public IntPtr GetGenericDrawable() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkWindow.GetGenericDrawable_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void SetWindowInfo(const char * ARG_0)
// "virtual void SetWindowInfo(const char *)"
public void SetWindowInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkWindow.SetWindowInfo_0(this, ARG_0);
}


// virtual void SetParentInfo(const char * ARG_0)
// "virtual void SetParentInfo(const char *)"
public void SetParentInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkWindow.SetParentInfo_0(this, ARG_0);
}


// virtual int* GetPosition()
// "virtual int *GetPosition()"
public int[] GetPosition() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkWindow.GetPosition_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetPosition(int ARG_0, int ARG_1)
// "virtual void SetPosition(int,int)"
public void SetPosition(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1) {
	VTK_API.API_vtkWindow.SetPosition_0(this, ARG_0, ARG_1);
}


// virtual void SetPosition(int a[2])
// "virtual void SetPosition(int a[2])"
public void SetPosition(int /*(int[2])*/ []a) {
	VTK_API.API_vtkWindow.SetPosition_1(this, a);
}


// virtual int* GetSize()
// "virtual int *GetSize()"
public int[] GetSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkWindow.GetSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetSize(int ARG_0, int ARG_1)
// "virtual void SetSize(int,int)"
public void SetSize(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1) {
	VTK_API.API_vtkWindow.SetSize_0(this, ARG_0, ARG_1);
}


// virtual void SetSize(int a[2])
// "virtual void SetSize(int a[2])"
public void SetSize(int /*(int[2])*/ []a) {
	VTK_API.API_vtkWindow.SetSize_1(this, a);
}


// int* GetActualSize()
// "int *GetActualSize()"
public int[] GetActualSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkWindow.GetActualSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int* GetScreenSize()
// "virtual int *GetScreenSize()"
public int[] GetScreenSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkWindow.GetScreenSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetMapped(vtkTypeBool _arg)
// "virtual void SetMapped (vtkTypeBool _arg)"
public void SetMapped(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkWindow.SetMapped_0(this, _arg);
}


// virtual vtkTypeBool GetMapped()
// "virtual vtkTypeBool GetMapped ()"
public bool GetMapped() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.GetMapped_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void MappedOn()
// "virtual void MappedOn ()"
public void MappedOn() {
	VTK_API.API_vtkWindow.MappedOn_0(this);
}


// virtual void MappedOff()
// "virtual void MappedOff ()"
public void MappedOff() {
	VTK_API.API_vtkWindow.MappedOff_0(this);
}


// virtual void SetErase(vtkTypeBool _arg)
// "virtual void SetErase (vtkTypeBool _arg)"
public void SetErase(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkWindow.SetErase_0(this, _arg);
}


// virtual vtkTypeBool GetErase()
// "virtual vtkTypeBool GetErase ()"
public bool GetErase() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.GetErase_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void EraseOn()
// "virtual void EraseOn ()"
public void EraseOn() {
	VTK_API.API_vtkWindow.EraseOn_0(this);
}


// virtual void EraseOff()
// "virtual void EraseOff ()"
public void EraseOff() {
	VTK_API.API_vtkWindow.EraseOff_0(this);
}


// virtual void SetDoubleBuffer(vtkTypeBool _arg)
// "virtual void SetDoubleBuffer (vtkTypeBool _arg)"
public void SetDoubleBuffer(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkWindow.SetDoubleBuffer_0(this, _arg);
}


// virtual vtkTypeBool GetDoubleBuffer()
// "virtual vtkTypeBool GetDoubleBuffer ()"
public bool GetDoubleBuffer() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.GetDoubleBuffer_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void DoubleBufferOn()
// "virtual void DoubleBufferOn ()"
public void DoubleBufferOn() {
	VTK_API.API_vtkWindow.DoubleBufferOn_0(this);
}


// virtual void DoubleBufferOff()
// "virtual void DoubleBufferOff ()"
public void DoubleBufferOff() {
	VTK_API.API_vtkWindow.DoubleBufferOff_0(this);
}


// virtual char* GetWindowName()
// "virtual char* GetWindowName ()"
public string GetWindowName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkWindow.GetWindowName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetWindowName(const char * _arg)
// "virtual void SetWindowName (const char* _arg)"
public void SetWindowName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkWindow.SetWindowName_0(this, _arg);
}


// virtual void Render()
// "virtual void Render()"
public void Render() {
	VTK_API.API_vtkWindow.Render_0(this);
}


// virtual char* GetPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// "virtual unsigned char *GetPixelData(int x, int y, int x2, int y2, int front, int right=0)"
public string GetPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkWindow.GetPixelData_0(out returnPointer, this, x, y, x2, y2, front, right);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray * data, int right = 0)
// "virtual int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray *data, int right=0)"
public int GetPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkWindow.GetPixelData_1(out returnPointer, this, x, y, x2, y2, front, data, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetDPI()
// "virtual int GetDPI ()"
public int GetDPI() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkWindow.GetDPI_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetDPI(int _arg)
// "virtual void SetDPI (int _arg)"
public void SetDPI(int /*(int)*/ _arg) {
	VTK_API.API_vtkWindow.SetDPI_0(this, _arg);
}


// virtual int GetDPIMinValue()
// "virtual int GetDPIMinValue ()"
public int GetDPIMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkWindow.GetDPIMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetDPIMaxValue()
// "virtual int GetDPIMaxValue ()"
public int GetDPIMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkWindow.GetDPIMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual bool DetectDPI()
// "virtual bool DetectDPI()"
public bool DetectDPI() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.DetectDPI_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetOffScreenRendering(vtkTypeBool _arg)
// "virtual void SetOffScreenRendering (vtkTypeBool _arg)"
public void SetOffScreenRendering(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkWindow.SetOffScreenRendering_0(this, _arg);
}


// virtual vtkTypeBool GetOffScreenRendering()
// "virtual vtkTypeBool GetOffScreenRendering ()"
public bool GetOffScreenRendering() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkWindow.GetOffScreenRendering_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void OffScreenRenderingOn()
// "virtual void OffScreenRenderingOn ()"
public void OffScreenRenderingOn() {
	VTK_API.API_vtkWindow.OffScreenRenderingOn_0(this);
}


// virtual void OffScreenRenderingOff()
// "virtual void OffScreenRenderingOff ()"
public void OffScreenRenderingOff() {
	VTK_API.API_vtkWindow.OffScreenRenderingOff_0(this);
}


// virtual void MakeCurrent()
// "virtual void MakeCurrent()"
public void MakeCurrent() {
	VTK_API.API_vtkWindow.MakeCurrent_0(this);
}


// virtual void SetTileScale(int _arg1, int _arg2)
// "virtual void SetTileScale (int _arg1, int _arg2)"
public void SetTileScale(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkWindow.SetTileScale_0(this, _arg1, _arg2);
}


// void SetTileScale(int _arg[2])
// "void SetTileScale (int _arg[2])"
public void SetTileScale(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkWindow.SetTileScale_1(this, _arg);
}


// virtual int* GetTileScale()
// "virtual int *GetTileScale ()"
public int[] GetTileScale() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkWindow.GetTileScale_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetTileScale(int & _arg1, int & _arg2)
// "virtual void GetTileScale (int &_arg1, int &_arg2)"
public void GetTileScale(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkWindow.GetTileScale_1(this, _arg1, _arg2);
}


// virtual void GetTileScale(int _arg[2])
// "virtual void GetTileScale (int _arg[2])"
public void GetTileScale(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkWindow.GetTileScale_2(this, _arg);
}


// void SetTileScale(int s)
// "void SetTileScale(int s)"
public void SetTileScale(int /*(int)*/ s) {
	VTK_API.API_vtkWindow.SetTileScale_2(this, s);
}


// virtual void SetTileViewport(double _arg1, double _arg2, double _arg3, double _arg4)
// "virtual void SetTileViewport (double _arg1, double _arg2, double _arg3, double _arg4)"
public void SetTileViewport(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3, double /*(double)*/ _arg4) {
	VTK_API.API_vtkWindow.SetTileViewport_0(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void SetTileViewport(double _arg[4])
// "virtual void SetTileViewport (double _arg[4])"
public void SetTileViewport(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkWindow.SetTileViewport_1(this, _arg);
}


// virtual double* GetTileViewport()
// "virtual double *GetTileViewport ()"
public double[] GetTileViewport() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkWindow.GetTileViewport_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetTileViewport(double & _arg1, double & _arg2, double & _arg3, double & _arg4)
// "virtual void GetTileViewport (double &_arg1, double &_arg2, double &_arg3, double &_arg4)"
public void GetTileViewport(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3, IntPtr /*(double&)*/ _arg4) {
	VTK_API.API_vtkWindow.GetTileViewport_1(this, _arg1, _arg2, _arg3, _arg4);
}


// virtual void GetTileViewport(double _arg[4])
// "virtual void GetTileViewport (double _arg[4])"
public void GetTileViewport(double /*(double[4])*/ []_arg) {
	VTK_API.API_vtkWindow.GetTileViewport_2(this, _arg);
}


}
};
