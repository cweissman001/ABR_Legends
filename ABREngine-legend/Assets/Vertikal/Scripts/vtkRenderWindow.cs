

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderWindow : vtkWindow {
		public vtkRenderWindow(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderWindow(IntPtr p) {return new vtkRenderWindow(p);}
		public static implicit operator  IntPtr(vtkRenderWindow o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkRenderWindow* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderWindow* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderWindow SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.SafeDownCast_0(out returnPointer, o);
//	return (vtkRenderWindow)(IntPtr)returnPointer;
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// vtkRenderWindow* NewInstance()
// "vtkRenderWindow *NewInstance()"
public vtkRenderWindow NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.NewInstance_0(out returnPointer, this);
//	return (vtkRenderWindow)(IntPtr)returnPointer;
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// static vtkRenderWindow* New()
// "static vtkRenderWindow *New()"
public static vtkRenderWindow New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.New_0(out returnPointer);
//	return (vtkRenderWindow)(IntPtr)returnPointer;
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// virtual void AddRenderer(vtkRenderer * ARG_0)
// "virtual void AddRenderer(vtkRenderer *)"
public void AddRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.AddRenderer_0(this, ARG_0);
}


// void RemoveRenderer(vtkRenderer * ARG_0)
// "void RemoveRenderer(vtkRenderer *)"
public void RemoveRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.RemoveRenderer_0(this, ARG_0);
}


// int HasRenderer(vtkRenderer * ARG_0)
// "int HasRenderer(vtkRenderer *)"
public int HasRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.HasRenderer_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// static char* GetRenderLibrary()
// "static const char *GetRenderLibrary()"
public static string GetRenderLibrary() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkRenderWindow.GetRenderLibrary_0(out returnPointer);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual char* GetRenderingBackend()
// "virtual const char *GetRenderingBackend()"
public string GetRenderingBackend() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkRenderWindow.GetRenderingBackend_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual vtkRenderTimerLog* GetRenderTimer()
// "virtual vtkRenderTimerLog *GetRenderTimer ()"
public vtkRenderTimerLog GetRenderTimer() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetRenderTimer_0(out returnPointer, this);
//	return (vtkRenderTimerLog)(IntPtr)returnPointer;
	return (vtkRenderTimerLog)(IntPtr)returnPointer;
}


// vtkRendererCollection* GetRenderers()
// "vtkRendererCollection *GetRenderers()"
public vtkRendererCollection GetRenderers() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetRenderers_0(out returnPointer, this);
//	return (vtkRendererCollection)(IntPtr)returnPointer;
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// void CaptureGL2PSSpecialProps(vtkCollection * specialProps)
// "void CaptureGL2PSSpecialProps(vtkCollection *specialProps)"
public void CaptureGL2PSSpecialProps(vtkCollection /*(vtkCollection*)*/ specialProps) {
	VTK_API.API_vtkRenderWindow.CaptureGL2PSSpecialProps_0(this, specialProps);
}


// virtual int GetCapturingGL2PSSpecialProps()
// "virtual int GetCapturingGL2PSSpecialProps ()"
public int GetCapturingGL2PSSpecialProps() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetCapturingGL2PSSpecialProps_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void Render()
// "void Render()"
public void Render() {
	VTK_API.API_vtkRenderWindow.Render_0(this);
}


// virtual void Start()
// "virtual void Start()"
public void Start() {
	VTK_API.API_vtkRenderWindow.Start_0(this);
}


// virtual void Finalize()
// "virtual void Finalize()"
public void Finalize() {
	VTK_API.API_vtkRenderWindow.Finalize_0(this);
}


// virtual void Frame()
// "virtual void Frame()"
public void Frame() {
	VTK_API.API_vtkRenderWindow.Frame_0(this);
}


// virtual void WaitForCompletion()
// "virtual void WaitForCompletion()"
public void WaitForCompletion() {
	VTK_API.API_vtkRenderWindow.WaitForCompletion_0(this);
}


// virtual void CopyResultFrame()
// "virtual void CopyResultFrame()"
public void CopyResultFrame() {
	VTK_API.API_vtkRenderWindow.CopyResultFrame_0(this);
}


// virtual vtkRenderWindowInteractor* MakeRenderWindowInteractor()
// "virtual vtkRenderWindowInteractor *MakeRenderWindowInteractor()"
public vtkRenderWindowInteractor MakeRenderWindowInteractor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.MakeRenderWindowInteractor_0(out returnPointer, this);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// virtual void HideCursor()
// "virtual void HideCursor()"
public void HideCursor() {
	VTK_API.API_vtkRenderWindow.HideCursor_0(this);
}


// virtual void ShowCursor()
// "virtual void ShowCursor()"
public void ShowCursor() {
	VTK_API.API_vtkRenderWindow.ShowCursor_0(this);
}


// virtual void SetCursorPosition(int ARG_0, int ARG_1)
// "virtual void SetCursorPosition(int , int )"
public void SetCursorPosition(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1) {
	VTK_API.API_vtkRenderWindow.SetCursorPosition_0(this, ARG_0, ARG_1);
}


// virtual void SetCurrentCursor(int _arg)
// "virtual void SetCurrentCursor (int _arg)"
public void SetCurrentCursor(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetCurrentCursor_0(this, _arg);
}


// virtual int GetCurrentCursor()
// "virtual int GetCurrentCursor ()"
public int GetCurrentCursor() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetCurrentCursor_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetFullScreen(vtkTypeBool ARG_0)
// "virtual void SetFullScreen(vtkTypeBool)"
public void SetFullScreen(bool /*(vtkTypeBool)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetFullScreen_0(this, ARG_0);
}


// virtual vtkTypeBool GetFullScreen()
// "virtual vtkTypeBool GetFullScreen ()"
public bool GetFullScreen() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetFullScreen_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void FullScreenOn()
// "virtual void FullScreenOn ()"
public void FullScreenOn() {
	VTK_API.API_vtkRenderWindow.FullScreenOn_0(this);
}


// virtual void FullScreenOff()
// "virtual void FullScreenOff ()"
public void FullScreenOff() {
	VTK_API.API_vtkRenderWindow.FullScreenOff_0(this);
}


// virtual void SetBorders(vtkTypeBool _arg)
// "virtual void SetBorders (vtkTypeBool _arg)"
public void SetBorders(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetBorders_0(this, _arg);
}


// virtual vtkTypeBool GetBorders()
// "virtual vtkTypeBool GetBorders ()"
public bool GetBorders() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetBorders_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void BordersOn()
// "virtual void BordersOn ()"
public void BordersOn() {
	VTK_API.API_vtkRenderWindow.BordersOn_0(this);
}


// virtual void BordersOff()
// "virtual void BordersOff ()"
public void BordersOff() {
	VTK_API.API_vtkRenderWindow.BordersOff_0(this);
}


// virtual vtkTypeBool GetStereoCapableWindow()
// "virtual vtkTypeBool GetStereoCapableWindow ()"
public bool GetStereoCapableWindow() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetStereoCapableWindow_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void StereoCapableWindowOn()
// "virtual void StereoCapableWindowOn ()"
public void StereoCapableWindowOn() {
	VTK_API.API_vtkRenderWindow.StereoCapableWindowOn_0(this);
}


// virtual void StereoCapableWindowOff()
// "virtual void StereoCapableWindowOff ()"
public void StereoCapableWindowOff() {
	VTK_API.API_vtkRenderWindow.StereoCapableWindowOff_0(this);
}


// virtual void SetStereoCapableWindow(vtkTypeBool capable)
// "virtual void SetStereoCapableWindow(vtkTypeBool capable)"
public void SetStereoCapableWindow(bool /*(vtkTypeBool)*/ capable) {
	VTK_API.API_vtkRenderWindow.SetStereoCapableWindow_0(this, capable);
}


// virtual vtkTypeBool GetStereoRender()
// "virtual vtkTypeBool GetStereoRender ()"
public bool GetStereoRender() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetStereoRender_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void SetStereoRender(vtkTypeBool stereo)
// "void SetStereoRender(vtkTypeBool stereo)"
public void SetStereoRender(bool /*(vtkTypeBool)*/ stereo) {
	VTK_API.API_vtkRenderWindow.SetStereoRender_0(this, stereo);
}


// virtual void StereoRenderOn()
// "virtual void StereoRenderOn ()"
public void StereoRenderOn() {
	VTK_API.API_vtkRenderWindow.StereoRenderOn_0(this);
}


// virtual void StereoRenderOff()
// "virtual void StereoRenderOff ()"
public void StereoRenderOff() {
	VTK_API.API_vtkRenderWindow.StereoRenderOff_0(this);
}


// virtual void SetAlphaBitPlanes(vtkTypeBool _arg)
// "virtual void SetAlphaBitPlanes (vtkTypeBool _arg)"
public void SetAlphaBitPlanes(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetAlphaBitPlanes_0(this, _arg);
}


// virtual vtkTypeBool GetAlphaBitPlanes()
// "virtual vtkTypeBool GetAlphaBitPlanes ()"
public bool GetAlphaBitPlanes() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetAlphaBitPlanes_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void AlphaBitPlanesOn()
// "virtual void AlphaBitPlanesOn ()"
public void AlphaBitPlanesOn() {
	VTK_API.API_vtkRenderWindow.AlphaBitPlanesOn_0(this);
}


// virtual void AlphaBitPlanesOff()
// "virtual void AlphaBitPlanesOff ()"
public void AlphaBitPlanesOff() {
	VTK_API.API_vtkRenderWindow.AlphaBitPlanesOff_0(this);
}


// virtual void SetPointSmoothing(vtkTypeBool _arg)
// "virtual void SetPointSmoothing (vtkTypeBool _arg)"
public void SetPointSmoothing(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetPointSmoothing_0(this, _arg);
}


// virtual vtkTypeBool GetPointSmoothing()
// "virtual vtkTypeBool GetPointSmoothing ()"
public bool GetPointSmoothing() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetPointSmoothing_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PointSmoothingOn()
// "virtual void PointSmoothingOn ()"
public void PointSmoothingOn() {
	VTK_API.API_vtkRenderWindow.PointSmoothingOn_0(this);
}


// virtual void PointSmoothingOff()
// "virtual void PointSmoothingOff ()"
public void PointSmoothingOff() {
	VTK_API.API_vtkRenderWindow.PointSmoothingOff_0(this);
}


// virtual void SetLineSmoothing(vtkTypeBool _arg)
// "virtual void SetLineSmoothing (vtkTypeBool _arg)"
public void SetLineSmoothing(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetLineSmoothing_0(this, _arg);
}


// virtual vtkTypeBool GetLineSmoothing()
// "virtual vtkTypeBool GetLineSmoothing ()"
public bool GetLineSmoothing() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetLineSmoothing_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void LineSmoothingOn()
// "virtual void LineSmoothingOn ()"
public void LineSmoothingOn() {
	VTK_API.API_vtkRenderWindow.LineSmoothingOn_0(this);
}


// virtual void LineSmoothingOff()
// "virtual void LineSmoothingOff ()"
public void LineSmoothingOff() {
	VTK_API.API_vtkRenderWindow.LineSmoothingOff_0(this);
}


// virtual void SetPolygonSmoothing(vtkTypeBool _arg)
// "virtual void SetPolygonSmoothing (vtkTypeBool _arg)"
public void SetPolygonSmoothing(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetPolygonSmoothing_0(this, _arg);
}


// virtual vtkTypeBool GetPolygonSmoothing()
// "virtual vtkTypeBool GetPolygonSmoothing ()"
public bool GetPolygonSmoothing() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetPolygonSmoothing_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PolygonSmoothingOn()
// "virtual void PolygonSmoothingOn ()"
public void PolygonSmoothingOn() {
	VTK_API.API_vtkRenderWindow.PolygonSmoothingOn_0(this);
}


// virtual void PolygonSmoothingOff()
// "virtual void PolygonSmoothingOff ()"
public void PolygonSmoothingOff() {
	VTK_API.API_vtkRenderWindow.PolygonSmoothingOff_0(this);
}


// virtual int GetStereoType()
// "virtual int GetStereoType ()"
public int GetStereoType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetStereoType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetStereoType(int ARG_0)
// "void SetStereoType(int)"
public void SetStereoType(int /*(int)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetStereoType_0(this, ARG_0);
}


// void SetStereoTypeToCrystalEyes()
// "void SetStereoTypeToCrystalEyes()"
public void SetStereoTypeToCrystalEyes() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToCrystalEyes_0(this);
}


// void SetStereoTypeToRedBlue()
// "void SetStereoTypeToRedBlue()"
public void SetStereoTypeToRedBlue() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToRedBlue_0(this);
}


// void SetStereoTypeToInterlaced()
// "void SetStereoTypeToInterlaced()"
public void SetStereoTypeToInterlaced() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToInterlaced_0(this);
}


// void SetStereoTypeToLeft()
// "void SetStereoTypeToLeft()"
public void SetStereoTypeToLeft() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToLeft_0(this);
}


// void SetStereoTypeToRight()
// "void SetStereoTypeToRight()"
public void SetStereoTypeToRight() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToRight_0(this);
}


// void SetStereoTypeToDresden()
// "void SetStereoTypeToDresden()"
public void SetStereoTypeToDresden() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToDresden_0(this);
}


// void SetStereoTypeToAnaglyph()
// "void SetStereoTypeToAnaglyph()"
public void SetStereoTypeToAnaglyph() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToAnaglyph_0(this);
}


// void SetStereoTypeToCheckerboard()
// "void SetStereoTypeToCheckerboard()"
public void SetStereoTypeToCheckerboard() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToCheckerboard_0(this);
}


// void SetStereoTypeToSplitViewportHorizontal()
// "void SetStereoTypeToSplitViewportHorizontal()"
public void SetStereoTypeToSplitViewportHorizontal() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToSplitViewportHorizontal_0(this);
}


// void SetStereoTypeToFake()
// "void SetStereoTypeToFake()"
public void SetStereoTypeToFake() {
	VTK_API.API_vtkRenderWindow.SetStereoTypeToFake_0(this);
}


// char* GetStereoTypeAsString()
// "const char *GetStereoTypeAsString()"
public string GetStereoTypeAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkRenderWindow.GetStereoTypeAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void StereoUpdate()
// "virtual void StereoUpdate()"
public void StereoUpdate() {
	VTK_API.API_vtkRenderWindow.StereoUpdate_0(this);
}


// virtual void StereoMidpoint()
// "virtual void StereoMidpoint()"
public void StereoMidpoint() {
	VTK_API.API_vtkRenderWindow.StereoMidpoint_0(this);
}


// virtual void StereoRenderComplete()
// "virtual void StereoRenderComplete()"
public void StereoRenderComplete() {
	VTK_API.API_vtkRenderWindow.StereoRenderComplete_0(this);
}


// virtual void SetAnaglyphColorSaturation(float _arg)
// "virtual void SetAnaglyphColorSaturation (float _arg)"
public void SetAnaglyphColorSaturation(float /*(float)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetAnaglyphColorSaturation_0(this, _arg);
}


// virtual float GetAnaglyphColorSaturationMinValue()
// "virtual float GetAnaglyphColorSaturationMinValue ()"
public float GetAnaglyphColorSaturationMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorSaturationMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetAnaglyphColorSaturationMaxValue()
// "virtual float GetAnaglyphColorSaturationMaxValue ()"
public float GetAnaglyphColorSaturationMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorSaturationMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetAnaglyphColorSaturation()
// "virtual float GetAnaglyphColorSaturation ()"
public float GetAnaglyphColorSaturation() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorSaturation_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetAnaglyphColorMask(int _arg1, int _arg2)
// "virtual void SetAnaglyphColorMask (int _arg1, int _arg2)"
public void SetAnaglyphColorMask(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkRenderWindow.SetAnaglyphColorMask_0(this, _arg1, _arg2);
}


// void SetAnaglyphColorMask(int _arg[2])
// "void SetAnaglyphColorMask (int _arg[2])"
public void SetAnaglyphColorMask(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindow.SetAnaglyphColorMask_1(this, _arg);
}


// virtual int* GetAnaglyphColorMask()
// "virtual int *GetAnaglyphColorMask ()"
public int[] GetAnaglyphColorMask() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorMask_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetAnaglyphColorMask(int data[2])
// "virtual void GetAnaglyphColorMask (int data[2])"
public void GetAnaglyphColorMask(int /*(int[2])*/ []data) {
	VTK_API.API_vtkRenderWindow.GetAnaglyphColorMask_1(this, data);
}


// virtual void WindowRemap()
// "virtual void WindowRemap()"
public void WindowRemap() {
	VTK_API.API_vtkRenderWindow.WindowRemap_0(this);
}


// virtual void SetSwapBuffers(vtkTypeBool _arg)
// "virtual void SetSwapBuffers (vtkTypeBool _arg)"
public void SetSwapBuffers(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetSwapBuffers_0(this, _arg);
}


// virtual vtkTypeBool GetSwapBuffers()
// "virtual vtkTypeBool GetSwapBuffers ()"
public bool GetSwapBuffers() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetSwapBuffers_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SwapBuffersOn()
// "virtual void SwapBuffersOn ()"
public void SwapBuffersOn() {
	VTK_API.API_vtkRenderWindow.SwapBuffersOn_0(this);
}


// virtual void SwapBuffersOff()
// "virtual void SwapBuffersOff ()"
public void SwapBuffersOff() {
	VTK_API.API_vtkRenderWindow.SwapBuffersOff_0(this);
}


// virtual int SetPixelData(int x, int y, int x2, int y2, unsigned char * data, int front, int right = 0)
// "virtual int SetPixelData(int x, int y, int x2, int y2, unsigned char *data, int front, int right=0)"
public int SetPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, string /*(unsigned char*)*/ data, int /*(int)*/ front, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetPixelData_0(out returnPointer, this, x, y, x2, y2, data, front, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray * data, int front, int right = 0)
// "virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray *data, int front, int right=0)"
public int SetPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ front, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetPixelData_1(out returnPointer, this, x, y, x2, y2, data, front, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual float* GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// "virtual float *GetRGBAPixelData(int x, int y, int x2, int y2, int front, int right=0)"
public float[] GetRGBAPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkRenderWindow.GetRGBAPixelData_0(out returnPointer, this, x, y, x2, y2, front, right);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray * data, int right = 0)
// "virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray *data, int right=0)"
public int GetRGBAPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, vtkFloatArray /*(vtkFloatArray*)*/ data, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetRGBAPixelData_1(out returnPointer, this, x, y, x2, y2, front, data, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetRGBAPixelData(int x, int y, int x2, int y2, float * ARG_0, int front, int blend = 0, int right = 0)
// "virtual int SetRGBAPixelData(int x, int y, int x2, int y2, float *, int front, int blend=0, int right=0)"
public int SetRGBAPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, float /*(float*)*/ []ARG_0, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetRGBAPixelData_0(out returnPointer, this, x, y, x2, y2, ARG_0, front, blend, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetRGBAPixelData(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkFloatArray * ARG_4, int ARG_5, int blend = 0, int right = 0)
// "virtual int SetRGBAPixelData(int, int, int, int, vtkFloatArray*, int, int blend=0, int right=0)"
public int SetRGBAPixelData(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, vtkFloatArray /*(vtkFloatArray*)*/ ARG_4, int /*(int)*/ ARG_5, int /*(int)*/ blend, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetRGBAPixelData_1(out returnPointer, this, ARG_0, ARG_1, ARG_2, ARG_3, ARG_4, ARG_5, blend, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void ReleaseRGBAPixelData(float * data)
// "virtual void ReleaseRGBAPixelData(float *data)"
public void ReleaseRGBAPixelData(float /*(float*)*/ []data) {
	VTK_API.API_vtkRenderWindow.ReleaseRGBAPixelData_0(this, data);
}


// virtual char* GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right = 0)
// "virtual unsigned char *GetRGBACharPixelData(int x, int y, int x2, int y2, int front, int right=0)"
public string GetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, int /*(int)*/ right) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkRenderWindow.GetRGBACharPixelData_0(out returnPointer, this, x, y, x2, y2, front, right);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray * data, int right = 0)
// "virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray *data, int right=0)"
public int GetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, int /*(int)*/ front, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetRGBACharPixelData_1(out returnPointer, this, x, y, x2, y2, front, data, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, unsigned char * data, int front, int blend = 0, int right = 0)
// "virtual int SetRGBACharPixelData(int x,int y, int x2, int y2, unsigned char *data, int front, int blend=0, int right=0)"
public int SetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, string /*(unsigned char*)*/ data, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetRGBACharPixelData_0(out returnPointer, this, x, y, x2, y2, data, front, blend, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray * data, int front, int blend = 0, int right = 0)
// "virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray *data, int front, int blend=0, int right=0)"
public int SetRGBACharPixelData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkUnsignedCharArray /*(vtkUnsignedCharArray*)*/ data, int /*(int)*/ front, int /*(int)*/ blend, int /*(int)*/ right) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetRGBACharPixelData_1(out returnPointer, this, x, y, x2, y2, data, front, blend, right);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual float* GetZbufferData(int x, int y, int x2, int y2)
// "virtual float *GetZbufferData(int x, int y, int x2, int y2)"
public float[] GetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float[] returnPointer = new float[1];
	VTK_API.API_vtkRenderWindow.GetZbufferData_0(out returnPointer, this, x, y, x2, y2);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual int GetZbufferData(int x, int y, int x2, int y2, float * z)
// "virtual int GetZbufferData(int x, int y, int x2, int y2, float *z)"
public int GetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, float /*(float*)*/ []z) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetZbufferData_1(out returnPointer, this, x, y, x2, y2, z);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray * z)
// "virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray *z)"
public int GetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkFloatArray /*(vtkFloatArray*)*/ z) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetZbufferData_2(out returnPointer, this, x, y, x2, y2, z);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetZbufferData(int x, int y, int x2, int y2, float * z)
// "virtual int SetZbufferData(int x, int y, int x2, int y2, float *z)"
public int SetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, float /*(float*)*/ []z) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetZbufferData_0(out returnPointer, this, x, y, x2, y2, z);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray * z)
// "virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray *z)"
public int SetZbufferData(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ x2, int /*(int)*/ y2, vtkFloatArray /*(vtkFloatArray*)*/ z) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetZbufferData_1(out returnPointer, this, x, y, x2, y2, z);
//	return (int)returnPointer;
	return returnPointer;
}


// float GetZbufferDataAtPoint(int x, int y)
// "float GetZbufferDataAtPoint(int x, int y)"
public float GetZbufferDataAtPoint(int /*(int)*/ x, int /*(int)*/ y) {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkRenderWindow.GetZbufferDataAtPoint_0(out returnPointer, this, x, y);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual int GetNeverRendered()
// "virtual int GetNeverRendered ()"
public int GetNeverRendered() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetNeverRendered_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetAbortRender()
// "virtual int GetAbortRender ()"
public int GetAbortRender() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetAbortRender_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetAbortRender(int _arg)
// "virtual void SetAbortRender (int _arg)"
public void SetAbortRender(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetAbortRender_0(this, _arg);
}


// virtual int GetInAbortCheck()
// "virtual int GetInAbortCheck ()"
public int GetInAbortCheck() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetInAbortCheck_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetInAbortCheck(int _arg)
// "virtual void SetInAbortCheck (int _arg)"
public void SetInAbortCheck(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetInAbortCheck_0(this, _arg);
}


// virtual int CheckAbortStatus()
// "virtual int CheckAbortStatus()"
public int CheckAbortStatus() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.CheckAbortStatus_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool GetIsPicking()
// "virtual vtkTypeBool GetIsPicking ()"
public bool GetIsPicking() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetIsPicking_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetIsPicking(vtkTypeBool _arg)
// "virtual void SetIsPicking (vtkTypeBool _arg)"
public void SetIsPicking(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetIsPicking_0(this, _arg);
}


// virtual void IsPickingOn()
// "virtual void IsPickingOn ()"
public void IsPickingOn() {
	VTK_API.API_vtkRenderWindow.IsPickingOn_0(this);
}


// virtual void IsPickingOff()
// "virtual void IsPickingOff ()"
public void IsPickingOff() {
	VTK_API.API_vtkRenderWindow.IsPickingOff_0(this);
}


// virtual int GetEventPending()
// "virtual int GetEventPending()"
public int GetEventPending() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetEventPending_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int CheckInRenderStatus()
// "virtual int CheckInRenderStatus()"
public int CheckInRenderStatus() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.CheckInRenderStatus_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void ClearInRenderStatus()
// "virtual void ClearInRenderStatus()"
public void ClearInRenderStatus() {
	VTK_API.API_vtkRenderWindow.ClearInRenderStatus_0(this);
}


// virtual void SetDesiredUpdateRate(double ARG_0)
// "virtual void SetDesiredUpdateRate(double)"
public void SetDesiredUpdateRate(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetDesiredUpdateRate_0(this, ARG_0);
}


// virtual double GetDesiredUpdateRate()
// "virtual double GetDesiredUpdateRate ()"
public double GetDesiredUpdateRate() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindow.GetDesiredUpdateRate_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfLayers()
// "virtual int GetNumberOfLayers ()"
public int GetNumberOfLayers() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetNumberOfLayers_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetNumberOfLayers(int _arg)
// "virtual void SetNumberOfLayers (int _arg)"
public void SetNumberOfLayers(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetNumberOfLayers_0(this, _arg);
}


// virtual int GetNumberOfLayersMinValue()
// "virtual int GetNumberOfLayersMinValue ()"
public int GetNumberOfLayersMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetNumberOfLayersMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfLayersMaxValue()
// "virtual int GetNumberOfLayersMaxValue ()"
public int GetNumberOfLayersMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetNumberOfLayersMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkRenderWindowInteractor* GetInteractor()
// "virtual vtkRenderWindowInteractor *GetInteractor ()"
public vtkRenderWindowInteractor GetInteractor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetInteractor_0(out returnPointer, this);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// void SetInteractor(vtkRenderWindowInteractor * ARG_0)
// "void SetInteractor(vtkRenderWindowInteractor *)"
public void SetInteractor(vtkRenderWindowInteractor /*(vtkRenderWindowInteractor*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetInteractor_0(this, ARG_0);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkRenderWindow.UnRegister_0(this, o);
}


// void SetDisplayId(void * ARG_0)
// "void SetDisplayId(void *)"
public void SetDisplayId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetDisplayId_0(this, ARG_0);
}


// void SetWindowId(void * ARG_0)
// "void SetWindowId(void *)"
public void SetWindowId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetWindowId_0(this, ARG_0);
}


// virtual void SetNextWindowId(void * ARG_0)
// "virtual void SetNextWindowId(void *)"
public void SetNextWindowId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetNextWindowId_0(this, ARG_0);
}


// void SetParentId(void * ARG_0)
// "void SetParentId(void *)"
public void SetParentId(IntPtr /*(void*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetParentId_0(this, ARG_0);
}


// void* GetGenericDisplayId()
// "void *GetGenericDisplayId()"
public IntPtr GetGenericDisplayId() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetGenericDisplayId_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// void* GetGenericWindowId()
// "void *GetGenericWindowId()"
public IntPtr GetGenericWindowId() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetGenericWindowId_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// void* GetGenericParentId()
// "void *GetGenericParentId()"
public IntPtr GetGenericParentId() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetGenericParentId_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// void* GetGenericContext()
// "void *GetGenericContext()"
public IntPtr GetGenericContext() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetGenericContext_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// void* GetGenericDrawable()
// "void *GetGenericDrawable()"
public IntPtr GetGenericDrawable() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetGenericDrawable_0(out returnPointer, this);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// void SetWindowInfo(const char * ARG_0)
// "void SetWindowInfo(const char *)"
public void SetWindowInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetWindowInfo_0(this, ARG_0);
}


// virtual void SetNextWindowInfo(const char * ARG_0)
// "virtual void SetNextWindowInfo(const char *)"
public void SetNextWindowInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetNextWindowInfo_0(this, ARG_0);
}


// void SetParentInfo(const char * ARG_0)
// "void SetParentInfo(const char *)"
public void SetParentInfo(string /*(char*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetParentInfo_0(this, ARG_0);
}


// virtual bool InitializeFromCurrentContext()
// "virtual bool InitializeFromCurrentContext()"
public bool InitializeFromCurrentContext() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.InitializeFromCurrentContext_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetSharedRenderWindow(vtkRenderWindow * ARG_0)
// "virtual void SetSharedRenderWindow(vtkRenderWindow *)"
public void SetSharedRenderWindow(vtkRenderWindow /*(vtkRenderWindow*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindow.SetSharedRenderWindow_0(this, ARG_0);
}


// virtual vtkRenderWindow* GetSharedRenderWindow()
// "virtual vtkRenderWindow *GetSharedRenderWindow ()"
public vtkRenderWindow GetSharedRenderWindow() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindow.GetSharedRenderWindow_0(out returnPointer, this);
//	return (vtkRenderWindow)(IntPtr)returnPointer;
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// virtual bool GetPlatformSupportsRenderWindowSharing()
// "virtual bool GetPlatformSupportsRenderWindowSharing()"
public bool GetPlatformSupportsRenderWindowSharing() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetPlatformSupportsRenderWindowSharing_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void MakeCurrent()
// "void MakeCurrent()"
public void MakeCurrent() {
	VTK_API.API_vtkRenderWindow.MakeCurrent_0(this);
}


// virtual bool IsCurrent()
// "virtual bool IsCurrent()"
public bool IsCurrent() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.IsCurrent_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual bool IsDrawable()
// "virtual bool IsDrawable()"
public bool IsDrawable() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.IsDrawable_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetForceMakeCurrent()
// "virtual void SetForceMakeCurrent()"
public void SetForceMakeCurrent() {
	VTK_API.API_vtkRenderWindow.SetForceMakeCurrent_0(this);
}


// virtual char* ReportCapabilities()
// "virtual const char *ReportCapabilities()"
public string ReportCapabilities() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkRenderWindow.ReportCapabilities_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual int SupportsOpenGL()
// "virtual int SupportsOpenGL()"
public int SupportsOpenGL() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SupportsOpenGL_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int IsDirect()
// "virtual int IsDirect()"
public int IsDirect() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.IsDirect_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetDepthBufferSize()
// "virtual int GetDepthBufferSize()"
public int GetDepthBufferSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetDepthBufferSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetColorBufferSizes(int * rgba)
// "virtual int GetColorBufferSizes(int *rgba)"
public int GetColorBufferSizes(int /*(int*)*/ []rgba) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetColorBufferSizes_0(out returnPointer, this, rgba);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetMultiSamples(int _arg)
// "virtual void SetMultiSamples (int _arg)"
public void SetMultiSamples(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetMultiSamples_0(this, _arg);
}


// virtual int GetMultiSamples()
// "virtual int GetMultiSamples ()"
public int GetMultiSamples() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetMultiSamples_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetStencilCapable(vtkTypeBool _arg)
// "virtual void SetStencilCapable (vtkTypeBool _arg)"
public void SetStencilCapable(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetStencilCapable_0(this, _arg);
}


// virtual vtkTypeBool GetStencilCapable()
// "virtual vtkTypeBool GetStencilCapable ()"
public bool GetStencilCapable() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetStencilCapable_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void StencilCapableOn()
// "virtual void StencilCapableOn ()"
public void StencilCapableOn() {
	VTK_API.API_vtkRenderWindow.StencilCapableOn_0(this);
}


// virtual void StencilCapableOff()
// "virtual void StencilCapableOff ()"
public void StencilCapableOff() {
	VTK_API.API_vtkRenderWindow.StencilCapableOff_0(this);
}


// virtual void SetDeviceIndex(int _arg)
// "virtual void SetDeviceIndex (int _arg)"
public void SetDeviceIndex(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetDeviceIndex_0(this, _arg);
}


// virtual int GetDeviceIndex()
// "virtual int GetDeviceIndex ()"
public int GetDeviceIndex() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetDeviceIndex_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfDevices()
// "virtual int GetNumberOfDevices()"
public int GetNumberOfDevices() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.GetNumberOfDevices_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int SetUseOffScreenBuffers(bool ARG_0)
// "virtual int SetUseOffScreenBuffers(bool)"
public int SetUseOffScreenBuffers(bool /*(bool)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindow.SetUseOffScreenBuffers_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual bool GetUseOffScreenBuffers()
// "virtual bool GetUseOffScreenBuffers()"
public bool GetUseOffScreenBuffers() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetUseOffScreenBuffers_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual bool GetUseSRGBColorSpace()
// "virtual bool GetUseSRGBColorSpace ()"
public bool GetUseSRGBColorSpace() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindow.GetUseSRGBColorSpace_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetUseSRGBColorSpace(bool _arg)
// "virtual void SetUseSRGBColorSpace (bool _arg)"
public void SetUseSRGBColorSpace(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderWindow.SetUseSRGBColorSpace_0(this, _arg);
}


// virtual void UseSRGBColorSpaceOn()
// "virtual void UseSRGBColorSpaceOn ()"
public void UseSRGBColorSpaceOn() {
	VTK_API.API_vtkRenderWindow.UseSRGBColorSpaceOn_0(this);
}


// virtual void UseSRGBColorSpaceOff()
// "virtual void UseSRGBColorSpaceOff ()"
public void UseSRGBColorSpaceOff() {
	VTK_API.API_vtkRenderWindow.UseSRGBColorSpaceOff_0(this);
}


}
};
