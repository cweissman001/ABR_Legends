

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderWindowInteractor : vtkObject {
		public vtkRenderWindowInteractor(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderWindowInteractor(IntPtr p) {return new vtkRenderWindowInteractor(p);}
		public static implicit operator  IntPtr(vtkRenderWindowInteractor o) {return o.GetPtr();}

// static vtkRenderWindowInteractor* New()
// "static vtkRenderWindowInteractor *New()"
public static vtkRenderWindowInteractor New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.New_0(out returnPointer);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkRenderWindowInteractor* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderWindowInteractor* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderWindowInteractor SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.SafeDownCast_0(out returnPointer, o);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// vtkRenderWindowInteractor* NewInstance()
// "vtkRenderWindowInteractor *NewInstance()"
public vtkRenderWindowInteractor NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.NewInstance_0(out returnPointer, this);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkRenderWindowInteractor.Initialize_0(this);
}


// void ReInitialize()
// "void ReInitialize()"
public void ReInitialize() {
	VTK_API.API_vtkRenderWindowInteractor.ReInitialize_0(this);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkRenderWindowInteractor.UnRegister_0(this, o);
}


// virtual void Start()
// "virtual void Start()"
public void Start() {
	VTK_API.API_vtkRenderWindowInteractor.Start_0(this);
}


// virtual void Enable()
// "virtual void Enable()"
public void Enable() {
	VTK_API.API_vtkRenderWindowInteractor.Enable_0(this);
}


// virtual void Disable()
// "virtual void Disable()"
public void Disable() {
	VTK_API.API_vtkRenderWindowInteractor.Disable_0(this);
}


// virtual int GetEnabled()
// "virtual int GetEnabled ()"
public int GetEnabled() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetEnabled_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void EnableRenderOn()
// "virtual void EnableRenderOn ()"
public void EnableRenderOn() {
	VTK_API.API_vtkRenderWindowInteractor.EnableRenderOn_0(this);
}


// virtual void EnableRenderOff()
// "virtual void EnableRenderOff ()"
public void EnableRenderOff() {
	VTK_API.API_vtkRenderWindowInteractor.EnableRenderOff_0(this);
}


// virtual void SetEnableRender(bool _arg)
// "virtual void SetEnableRender (bool _arg)"
public void SetEnableRender(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetEnableRender_0(this, _arg);
}


// virtual bool GetEnableRender()
// "virtual bool GetEnableRender ()"
public bool GetEnableRender() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.GetEnableRender_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void SetRenderWindow(vtkRenderWindow * aren)
// "void SetRenderWindow(vtkRenderWindow *aren)"
public void SetRenderWindow(vtkRenderWindow /*(vtkRenderWindow*)*/ aren) {
	VTK_API.API_vtkRenderWindowInteractor.SetRenderWindow_0(this, aren);
}


// virtual vtkRenderWindow* GetRenderWindow()
// "virtual vtkRenderWindow *GetRenderWindow ()"
public vtkRenderWindow GetRenderWindow() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.GetRenderWindow_0(out returnPointer, this);
//	return (vtkRenderWindow)(IntPtr)returnPointer;
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// virtual void UpdateSize(int x, int y)
// "virtual void UpdateSize(int x,int y)"
public void UpdateSize(int /*(int)*/ x, int /*(int)*/ y) {
	VTK_API.API_vtkRenderWindowInteractor.UpdateSize_0(this, x, y);
}


// virtual int CreateTimer(int timerType)
// "virtual int CreateTimer(int timerType)"
public int CreateTimer(int /*(int)*/ timerType) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.CreateTimer_0(out returnPointer, this, timerType);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int DestroyTimer()
// "virtual int DestroyTimer()"
public int DestroyTimer() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.DestroyTimer_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int CreateRepeatingTimer(unsigned long duration)
// "int CreateRepeatingTimer(unsigned long duration)"
public int CreateRepeatingTimer(ulong /*(unsigned long)*/ duration) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.CreateRepeatingTimer_0(out returnPointer, this, duration);
//	return (int)returnPointer;
	return returnPointer;
}


// int CreateOneShotTimer(unsigned long duration)
// "int CreateOneShotTimer(unsigned long duration)"
public int CreateOneShotTimer(ulong /*(unsigned long)*/ duration) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.CreateOneShotTimer_0(out returnPointer, this, duration);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsOneShotTimer(int timerId)
// "int IsOneShotTimer(int timerId)"
public int IsOneShotTimer(int /*(int)*/ timerId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.IsOneShotTimer_0(out returnPointer, this, timerId);
//	return (int)returnPointer;
	return returnPointer;
}


// long GetTimerDuration(int timerId)
// "unsigned long GetTimerDuration(int timerId)"
public ulong GetTimerDuration(int /*(int)*/ timerId) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerDuration_0(out returnPointer, this, timerId);
//	return (ulong)returnPointer;
	return returnPointer;
}


// int ResetTimer(int timerId)
// "int ResetTimer(int timerId)"
public int ResetTimer(int /*(int)*/ timerId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.ResetTimer_0(out returnPointer, this, timerId);
//	return (int)returnPointer;
	return returnPointer;
}


// int DestroyTimer(int timerId)
// "int DestroyTimer(int timerId)"
public int DestroyTimer(int /*(int)*/ timerId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.DestroyTimer_1(out returnPointer, this, timerId);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetVTKTimerId(int platformTimerId)
// "virtual int GetVTKTimerId(int platformTimerId)"
public int GetVTKTimerId(int /*(int)*/ platformTimerId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetVTKTimerId_0(out returnPointer, this, platformTimerId);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetTimerDuration(unsigned long _arg)
// "virtual void SetTimerDuration (unsigned long _arg)"
public void SetTimerDuration(ulong /*(unsigned long)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetTimerDuration_0(this, _arg);
}


// virtual long GetTimerDurationMinValue()
// "virtual unsigned long GetTimerDurationMinValue ()"
public ulong GetTimerDurationMinValue() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerDurationMinValue_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual long GetTimerDurationMaxValue()
// "virtual unsigned long GetTimerDurationMaxValue ()"
public ulong GetTimerDurationMaxValue() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerDurationMaxValue_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual long GetTimerDuration()
// "virtual unsigned long GetTimerDuration ()"
public ulong GetTimerDuration() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerDuration_1(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void SetTimerEventId(int _arg)
// "virtual void SetTimerEventId (int _arg)"
public void SetTimerEventId(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetTimerEventId_0(this, _arg);
}


// virtual int GetTimerEventId()
// "virtual int GetTimerEventId ()"
public int GetTimerEventId() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerEventId_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetTimerEventType(int _arg)
// "virtual void SetTimerEventType (int _arg)"
public void SetTimerEventType(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetTimerEventType_0(this, _arg);
}


// virtual int GetTimerEventType()
// "virtual int GetTimerEventType ()"
public int GetTimerEventType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerEventType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetTimerEventDuration(int _arg)
// "virtual void SetTimerEventDuration (int _arg)"
public void SetTimerEventDuration(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetTimerEventDuration_0(this, _arg);
}


// virtual int GetTimerEventDuration()
// "virtual int GetTimerEventDuration ()"
public int GetTimerEventDuration() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerEventDuration_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetTimerEventPlatformId(int _arg)
// "virtual void SetTimerEventPlatformId (int _arg)"
public void SetTimerEventPlatformId(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetTimerEventPlatformId_0(this, _arg);
}


// virtual int GetTimerEventPlatformId()
// "virtual int GetTimerEventPlatformId ()"
public int GetTimerEventPlatformId() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetTimerEventPlatformId_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void TerminateApp()
// "virtual void TerminateApp(void)"
public void TerminateApp() {
	VTK_API.API_vtkRenderWindowInteractor.TerminateApp_0(this);
}


// virtual void SetInteractorStyle(vtkInteractorObserver * ARG_0)
// "virtual void SetInteractorStyle(vtkInteractorObserver *)"
public void SetInteractorStyle(vtkInteractorObserver /*(vtkInteractorObserver*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindowInteractor.SetInteractorStyle_0(this, ARG_0);
}


// virtual vtkInteractorObserver* GetInteractorStyle()
// "virtual vtkInteractorObserver *GetInteractorStyle ()"
public vtkInteractorObserver GetInteractorStyle() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.GetInteractorStyle_0(out returnPointer, this);
//	return (vtkInteractorObserver)(IntPtr)returnPointer;
	return (vtkInteractorObserver)(IntPtr)returnPointer;
}


// virtual void SetLightFollowCamera(vtkTypeBool _arg)
// "virtual void SetLightFollowCamera (vtkTypeBool _arg)"
public void SetLightFollowCamera(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetLightFollowCamera_0(this, _arg);
}


// virtual vtkTypeBool GetLightFollowCamera()
// "virtual vtkTypeBool GetLightFollowCamera ()"
public bool GetLightFollowCamera() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.GetLightFollowCamera_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void LightFollowCameraOn()
// "virtual void LightFollowCameraOn ()"
public void LightFollowCameraOn() {
	VTK_API.API_vtkRenderWindowInteractor.LightFollowCameraOn_0(this);
}


// virtual void LightFollowCameraOff()
// "virtual void LightFollowCameraOff ()"
public void LightFollowCameraOff() {
	VTK_API.API_vtkRenderWindowInteractor.LightFollowCameraOff_0(this);
}


// virtual void SetDesiredUpdateRate(double _arg)
// "virtual void SetDesiredUpdateRate (double _arg)"
public void SetDesiredUpdateRate(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetDesiredUpdateRate_0(this, _arg);
}


// virtual double GetDesiredUpdateRateMinValue()
// "virtual double GetDesiredUpdateRateMinValue ()"
public double GetDesiredUpdateRateMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetDesiredUpdateRateMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetDesiredUpdateRateMaxValue()
// "virtual double GetDesiredUpdateRateMaxValue ()"
public double GetDesiredUpdateRateMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetDesiredUpdateRateMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetDesiredUpdateRate()
// "virtual double GetDesiredUpdateRate ()"
public double GetDesiredUpdateRate() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetDesiredUpdateRate_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetStillUpdateRate(double _arg)
// "virtual void SetStillUpdateRate (double _arg)"
public void SetStillUpdateRate(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetStillUpdateRate_0(this, _arg);
}


// virtual double GetStillUpdateRateMinValue()
// "virtual double GetStillUpdateRateMinValue ()"
public double GetStillUpdateRateMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetStillUpdateRateMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetStillUpdateRateMaxValue()
// "virtual double GetStillUpdateRateMaxValue ()"
public double GetStillUpdateRateMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetStillUpdateRateMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetStillUpdateRate()
// "virtual double GetStillUpdateRate ()"
public double GetStillUpdateRate() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetStillUpdateRate_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int GetInitialized()
// "virtual int GetInitialized ()"
public int GetInitialized() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetInitialized_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetPicker(vtkAbstractPicker * ARG_0)
// "virtual void SetPicker(vtkAbstractPicker*)"
public void SetPicker(vtkAbstractPicker /*(vtkAbstractPicker*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindowInteractor.SetPicker_0(this, ARG_0);
}


// virtual vtkAbstractPicker* GetPicker()
// "virtual vtkAbstractPicker *GetPicker ()"
public vtkAbstractPicker GetPicker() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.GetPicker_0(out returnPointer, this);
//	return (vtkAbstractPicker)(IntPtr)returnPointer;
	return (vtkAbstractPicker)(IntPtr)returnPointer;
}


// virtual vtkAbstractPropPicker* CreateDefaultPicker()
// "virtual vtkAbstractPropPicker *CreateDefaultPicker()"
public vtkAbstractPropPicker CreateDefaultPicker() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.CreateDefaultPicker_0(out returnPointer, this);
//	return (vtkAbstractPropPicker)(IntPtr)returnPointer;
	return (vtkAbstractPropPicker)(IntPtr)returnPointer;
}


// virtual void SetPickingManager(vtkPickingManager * ARG_0)
// "virtual void SetPickingManager(vtkPickingManager*)"
public void SetPickingManager(vtkPickingManager /*(vtkPickingManager*)*/ ARG_0) {
	VTK_API.API_vtkRenderWindowInteractor.SetPickingManager_0(this, ARG_0);
}


// virtual vtkPickingManager* GetPickingManager()
// "virtual vtkPickingManager *GetPickingManager ()"
public vtkPickingManager GetPickingManager() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.GetPickingManager_0(out returnPointer, this);
//	return (vtkPickingManager)(IntPtr)returnPointer;
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// virtual void ExitCallback()
// "virtual void ExitCallback()"
public void ExitCallback() {
	VTK_API.API_vtkRenderWindowInteractor.ExitCallback_0(this);
}


// virtual void UserCallback()
// "virtual void UserCallback()"
public void UserCallback() {
	VTK_API.API_vtkRenderWindowInteractor.UserCallback_0(this);
}


// virtual void StartPickCallback()
// "virtual void StartPickCallback()"
public void StartPickCallback() {
	VTK_API.API_vtkRenderWindowInteractor.StartPickCallback_0(this);
}


// virtual void EndPickCallback()
// "virtual void EndPickCallback()"
public void EndPickCallback() {
	VTK_API.API_vtkRenderWindowInteractor.EndPickCallback_0(this);
}


// virtual void GetMousePosition(int * x, int * y)
// "virtual void GetMousePosition(int *x, int *y)"
public void GetMousePosition(int /*(int*)*/ []x, int /*(int*)*/ []y) {
	VTK_API.API_vtkRenderWindowInteractor.GetMousePosition_0(this, x, y);
}


// void HideCursor()
// "void HideCursor()"
public void HideCursor() {
	VTK_API.API_vtkRenderWindowInteractor.HideCursor_0(this);
}


// void ShowCursor()
// "void ShowCursor()"
public void ShowCursor() {
	VTK_API.API_vtkRenderWindowInteractor.ShowCursor_0(this);
}


// virtual void Render()
// "virtual void Render()"
public void Render() {
	VTK_API.API_vtkRenderWindowInteractor.Render_0(this);
}


// void FlyTo(vtkRenderer * ren, double x, double y, double z)
// "void FlyTo(vtkRenderer *ren, double x, double y, double z)"
public void FlyTo(vtkRenderer /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkRenderWindowInteractor.FlyTo_0(this, ren, x, y, z);
}


// void FlyTo(vtkRenderer * ren, double * x)
// "void FlyTo(vtkRenderer *ren, double *x)"
public void FlyTo(vtkRenderer /*(vtkRenderer*)*/ ren, double /*(double*)*/ []x) {
	VTK_API.API_vtkRenderWindowInteractor.FlyTo_1(this, ren, x);
}


// void FlyToImage(vtkRenderer * ren, double x, double y)
// "void FlyToImage(vtkRenderer *ren, double x, double y)"
public void FlyToImage(vtkRenderer /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y) {
	VTK_API.API_vtkRenderWindowInteractor.FlyToImage_0(this, ren, x, y);
}


// void FlyToImage(vtkRenderer * ren, double * x)
// "void FlyToImage(vtkRenderer *ren, double *x)"
public void FlyToImage(vtkRenderer /*(vtkRenderer*)*/ ren, double /*(double*)*/ []x) {
	VTK_API.API_vtkRenderWindowInteractor.FlyToImage_1(this, ren, x);
}


// virtual void SetNumberOfFlyFrames(int _arg)
// "virtual void SetNumberOfFlyFrames (int _arg)"
public void SetNumberOfFlyFrames(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetNumberOfFlyFrames_0(this, _arg);
}


// virtual int GetNumberOfFlyFramesMinValue()
// "virtual int GetNumberOfFlyFramesMinValue ()"
public int GetNumberOfFlyFramesMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetNumberOfFlyFramesMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfFlyFramesMaxValue()
// "virtual int GetNumberOfFlyFramesMaxValue ()"
public int GetNumberOfFlyFramesMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetNumberOfFlyFramesMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfFlyFrames()
// "virtual int GetNumberOfFlyFrames ()"
public int GetNumberOfFlyFrames() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetNumberOfFlyFrames_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetDolly(double _arg)
// "virtual void SetDolly (double _arg)"
public void SetDolly(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetDolly_0(this, _arg);
}


// virtual double GetDolly()
// "virtual double GetDolly ()"
public double GetDolly() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetDolly_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int* GetEventPosition()
// "virtual int *GetEventPosition ()"
public int[] GetEventPosition() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindowInteractor.GetEventPosition_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetEventPosition(int & _arg1, int & _arg2)
// "virtual void GetEventPosition (int &_arg1, int &_arg2)"
public void GetEventPosition(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.GetEventPosition_1(this, _arg1, _arg2);
}


// virtual void GetEventPosition(int _arg[2])
// "virtual void GetEventPosition (int _arg[2])"
public void GetEventPosition(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.GetEventPosition_2(this, _arg);
}


// virtual int* GetLastEventPosition()
// "virtual int *GetLastEventPosition ()"
public int[] GetLastEventPosition() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindowInteractor.GetLastEventPosition_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetLastEventPosition(int & _arg1, int & _arg2)
// "virtual void GetLastEventPosition (int &_arg1, int &_arg2)"
public void GetLastEventPosition(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.GetLastEventPosition_1(this, _arg1, _arg2);
}


// virtual void GetLastEventPosition(int _arg[2])
// "virtual void GetLastEventPosition (int _arg[2])"
public void GetLastEventPosition(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.GetLastEventPosition_2(this, _arg);
}


// virtual void SetLastEventPosition(int _arg1, int _arg2)
// "virtual void SetLastEventPosition (int _arg1, int _arg2)"
public void SetLastEventPosition(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.SetLastEventPosition_0(this, _arg1, _arg2);
}


// void SetLastEventPosition(int _arg[2])
// "void SetLastEventPosition (int _arg[2])"
public void SetLastEventPosition(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetLastEventPosition_1(this, _arg);
}


// virtual void SetEventPosition(int x, int y)
// "virtual void SetEventPosition(int x, int y)"
public void SetEventPosition(int /*(int)*/ x, int /*(int)*/ y) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPosition_0(this, x, y);
}


// virtual void SetEventPosition(int pos[2])
// "virtual void SetEventPosition(int pos[2])"
public void SetEventPosition(int /*(int[2])*/ []pos) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPosition_1(this, pos);
}


// virtual void SetEventPositionFlipY(int x, int y)
// "virtual void SetEventPositionFlipY(int x, int y)"
public void SetEventPositionFlipY(int /*(int)*/ x, int /*(int)*/ y) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPositionFlipY_0(this, x, y);
}


// virtual void SetEventPositionFlipY(int pos[2])
// "virtual void SetEventPositionFlipY(int pos[2])"
public void SetEventPositionFlipY(int /*(int[2])*/ []pos) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPositionFlipY_1(this, pos);
}


// virtual int* GetEventPositions(int pointerIndex)
// "virtual int *GetEventPositions(int pointerIndex)"
public int[] GetEventPositions(int /*(int)*/ pointerIndex) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindowInteractor.GetEventPositions_0(out returnPointer, this, pointerIndex);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int* GetLastEventPositions(int pointerIndex)
// "virtual int *GetLastEventPositions(int pointerIndex)"
public int[] GetLastEventPositions(int /*(int)*/ pointerIndex) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindowInteractor.GetLastEventPositions_0(out returnPointer, this, pointerIndex);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetEventPosition(int x, int y, int pointerIndex)
// "virtual void SetEventPosition(int x, int y, int pointerIndex)"
public void SetEventPosition(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ pointerIndex) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPosition_2(this, x, y, pointerIndex);
}


// virtual void SetEventPosition(int pos[2], int pointerIndex)
// "virtual void SetEventPosition(int pos[2], int pointerIndex)"
public void SetEventPosition(int /*(int[2])*/ []pos, int /*(int)*/ pointerIndex) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPosition_3(this, pos, pointerIndex);
}


// virtual void SetEventPositionFlipY(int x, int y, int pointerIndex)
// "virtual void SetEventPositionFlipY(int x, int y, int pointerIndex)"
public void SetEventPositionFlipY(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ pointerIndex) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPositionFlipY_2(this, x, y, pointerIndex);
}


// virtual void SetEventPositionFlipY(int pos[2], int pointerIndex)
// "virtual void SetEventPositionFlipY(int pos[2], int pointerIndex)"
public void SetEventPositionFlipY(int /*(int[2])*/ []pos, int /*(int)*/ pointerIndex) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventPositionFlipY_3(this, pos, pointerIndex);
}


// virtual void SetAltKey(int _arg)
// "virtual void SetAltKey (int _arg)"
public void SetAltKey(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetAltKey_0(this, _arg);
}


// virtual int GetAltKey()
// "virtual int GetAltKey ()"
public int GetAltKey() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetAltKey_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetControlKey(int _arg)
// "virtual void SetControlKey (int _arg)"
public void SetControlKey(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetControlKey_0(this, _arg);
}


// virtual int GetControlKey()
// "virtual int GetControlKey ()"
public int GetControlKey() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetControlKey_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetShiftKey(int _arg)
// "virtual void SetShiftKey (int _arg)"
public void SetShiftKey(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetShiftKey_0(this, _arg);
}


// virtual int GetShiftKey()
// "virtual int GetShiftKey ()"
public int GetShiftKey() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetShiftKey_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetKeyCode(char _arg)
// "virtual void SetKeyCode (char _arg)"
public void SetKeyCode(char /*(char)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetKeyCode_0(this, _arg);
}


// virtual char GetKeyCode()
// "virtual char GetKeyCode ()"
public char GetKeyCode() {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkRenderWindowInteractor.GetKeyCode_0(out returnPointer, this);
//	return (char)returnPointer;
	return returnPointer;
}


// virtual void SetRepeatCount(int _arg)
// "virtual void SetRepeatCount (int _arg)"
public void SetRepeatCount(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetRepeatCount_0(this, _arg);
}


// virtual int GetRepeatCount()
// "virtual int GetRepeatCount ()"
public int GetRepeatCount() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetRepeatCount_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetKeySym(const char * _arg)
// "virtual void SetKeySym (const char* _arg)"
public void SetKeySym(string /*(char*)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetKeySym_0(this, _arg);
}


// virtual char* GetKeySym()
// "virtual char* GetKeySym ()"
public string GetKeySym() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkRenderWindowInteractor.GetKeySym_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetPointerIndex(int _arg)
// "virtual void SetPointerIndex (int _arg)"
public void SetPointerIndex(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetPointerIndex_0(this, _arg);
}


// virtual int GetPointerIndex()
// "virtual int GetPointerIndex ()"
public int GetPointerIndex() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetPointerIndex_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetRotation(double val)
// "void SetRotation(double val)"
public void SetRotation(double /*(double)*/ val) {
	VTK_API.API_vtkRenderWindowInteractor.SetRotation_0(this, val);
}


// virtual double GetRotation()
// "virtual double GetRotation ()"
public double GetRotation() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetRotation_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetLastRotation()
// "virtual double GetLastRotation ()"
public double GetLastRotation() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetLastRotation_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void SetScale(double val)
// "void SetScale(double val)"
public void SetScale(double /*(double)*/ val) {
	VTK_API.API_vtkRenderWindowInteractor.SetScale_0(this, val);
}


// virtual double GetScale()
// "virtual double GetScale ()"
public double GetScale() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetScale_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetLastScale()
// "virtual double GetLastScale ()"
public double GetLastScale() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderWindowInteractor.GetLastScale_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void SetTranslation(double val[2])
// "void SetTranslation(double val[2])"
public void SetTranslation(double /*(double[2])*/ []val) {
	VTK_API.API_vtkRenderWindowInteractor.SetTranslation_0(this, val);
}


// virtual double* GetTranslation()
// "virtual double *GetTranslation ()"
public double[] GetTranslation() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkRenderWindowInteractor.GetTranslation_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetTranslation(double & _arg1, double & _arg2)
// "virtual void GetTranslation (double &_arg1, double &_arg2)"
public void GetTranslation(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.GetTranslation_1(this, _arg1, _arg2);
}


// virtual void GetTranslation(double _arg[2])
// "virtual void GetTranslation (double _arg[2])"
public void GetTranslation(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.GetTranslation_2(this, _arg);
}


// virtual double* GetLastTranslation()
// "virtual double *GetLastTranslation ()"
public double[] GetLastTranslation() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkRenderWindowInteractor.GetLastTranslation_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetLastTranslation(double & _arg1, double & _arg2)
// "virtual void GetLastTranslation (double &_arg1, double &_arg2)"
public void GetLastTranslation(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.GetLastTranslation_1(this, _arg1, _arg2);
}


// virtual void GetLastTranslation(double _arg[2])
// "virtual void GetLastTranslation (double _arg[2])"
public void GetLastTranslation(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.GetLastTranslation_2(this, _arg);
}


// void SetEventInformation(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char * keysym, int pointerIndex)
// "void SetEventInformation(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char* keysym, int pointerIndex)"
public void SetEventInformation(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym, int /*(int)*/ pointerIndex) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventInformation_0(this, x, y, ctrl, shift, keycode, repeatcount, keysym, pointerIndex);
}


// void SetEventInformation(int x, int y, int ctrl = 0, int shift = 0, char keycode = 0, int repeatcount = 0, const char * keysym = nullptr)
// "void SetEventInformation(int x, int y, int ctrl=0, int shift=0, char keycode=0, int repeatcount=0, const char* keysym=nullptr)"
public void SetEventInformation(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventInformation_1(this, x, y, ctrl, shift, keycode, repeatcount, keysym);
}


// void SetEventInformationFlipY(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char * keysym, int pointerIndex)
// "void SetEventInformationFlipY(int x, int y, int ctrl, int shift, char keycode, int repeatcount, const char* keysym, int pointerIndex)"
public void SetEventInformationFlipY(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym, int /*(int)*/ pointerIndex) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventInformationFlipY_0(this, x, y, ctrl, shift, keycode, repeatcount, keysym, pointerIndex);
}


// void SetEventInformationFlipY(int x, int y, int ctrl = 0, int shift = 0, char keycode = 0, int repeatcount = 0, const char * keysym = nullptr)
// "void SetEventInformationFlipY(int x, int y, int ctrl=0, int shift=0, char keycode=0, int repeatcount=0, const char* keysym=nullptr)"
public void SetEventInformationFlipY(int /*(int)*/ x, int /*(int)*/ y, int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventInformationFlipY_1(this, x, y, ctrl, shift, keycode, repeatcount, keysym);
}


// void SetKeyEventInformation(int ctrl = 0, int shift = 0, char keycode = 0, int repeatcount = 0, const char * keysym = nullptr)
// "void SetKeyEventInformation(int ctrl=0, int shift=0, char keycode=0, int repeatcount=0, const char* keysym=nullptr)"
public void SetKeyEventInformation(int /*(int)*/ ctrl, int /*(int)*/ shift, char /*(char)*/ keycode, int /*(int)*/ repeatcount, string /*(char*)*/ keysym) {
	VTK_API.API_vtkRenderWindowInteractor.SetKeyEventInformation_0(this, ctrl, shift, keycode, repeatcount, keysym);
}


// virtual void SetSize(int _arg1, int _arg2)
// "virtual void SetSize (int _arg1, int _arg2)"
public void SetSize(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.SetSize_0(this, _arg1, _arg2);
}


// void SetSize(int _arg[2])
// "void SetSize (int _arg[2])"
public void SetSize(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetSize_1(this, _arg);
}


// virtual int* GetSize()
// "virtual int *GetSize ()"
public int[] GetSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindowInteractor.GetSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetSize(int & _arg1, int & _arg2)
// "virtual void GetSize (int &_arg1, int &_arg2)"
public void GetSize(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.GetSize_1(this, _arg1, _arg2);
}


// virtual void GetSize(int _arg[2])
// "virtual void GetSize (int _arg[2])"
public void GetSize(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.GetSize_2(this, _arg);
}


// virtual void SetEventSize(int _arg1, int _arg2)
// "virtual void SetEventSize (int _arg1, int _arg2)"
public void SetEventSize(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventSize_0(this, _arg1, _arg2);
}


// void SetEventSize(int _arg[2])
// "void SetEventSize (int _arg[2])"
public void SetEventSize(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetEventSize_1(this, _arg);
}


// virtual int* GetEventSize()
// "virtual int *GetEventSize ()"
public int[] GetEventSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkRenderWindowInteractor.GetEventSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetEventSize(int & _arg1, int & _arg2)
// "virtual void GetEventSize (int &_arg1, int &_arg2)"
public void GetEventSize(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkRenderWindowInteractor.GetEventSize_1(this, _arg1, _arg2);
}


// virtual void GetEventSize(int _arg[2])
// "virtual void GetEventSize (int _arg[2])"
public void GetEventSize(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkRenderWindowInteractor.GetEventSize_2(this, _arg);
}


// virtual vtkRenderer* FindPokedRenderer(int ARG_0, int ARG_1)
// "virtual vtkRenderer *FindPokedRenderer(int,int)"
public vtkRenderer FindPokedRenderer(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.FindPokedRenderer_0(out returnPointer, this, ARG_0, ARG_1);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// vtkObserverMediator* GetObserverMediator()
// "vtkObserverMediator *GetObserverMediator()"
public vtkObserverMediator GetObserverMediator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderWindowInteractor.GetObserverMediator_0(out returnPointer, this);
//	return (vtkObserverMediator)(IntPtr)returnPointer;
	return (vtkObserverMediator)(IntPtr)returnPointer;
}


// virtual void SetUseTDx(bool _arg)
// "virtual void SetUseTDx (bool _arg)"
public void SetUseTDx(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetUseTDx_0(this, _arg);
}


// virtual bool GetUseTDx()
// "virtual bool GetUseTDx ()"
public bool GetUseTDx() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.GetUseTDx_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void MouseMoveEvent()
// "virtual void MouseMoveEvent()"
public void MouseMoveEvent() {
	VTK_API.API_vtkRenderWindowInteractor.MouseMoveEvent_0(this);
}


// virtual void RightButtonPressEvent()
// "virtual void RightButtonPressEvent()"
public void RightButtonPressEvent() {
	VTK_API.API_vtkRenderWindowInteractor.RightButtonPressEvent_0(this);
}


// virtual void RightButtonReleaseEvent()
// "virtual void RightButtonReleaseEvent()"
public void RightButtonReleaseEvent() {
	VTK_API.API_vtkRenderWindowInteractor.RightButtonReleaseEvent_0(this);
}


// virtual void LeftButtonPressEvent()
// "virtual void LeftButtonPressEvent()"
public void LeftButtonPressEvent() {
	VTK_API.API_vtkRenderWindowInteractor.LeftButtonPressEvent_0(this);
}


// virtual void LeftButtonReleaseEvent()
// "virtual void LeftButtonReleaseEvent()"
public void LeftButtonReleaseEvent() {
	VTK_API.API_vtkRenderWindowInteractor.LeftButtonReleaseEvent_0(this);
}


// virtual void MiddleButtonPressEvent()
// "virtual void MiddleButtonPressEvent()"
public void MiddleButtonPressEvent() {
	VTK_API.API_vtkRenderWindowInteractor.MiddleButtonPressEvent_0(this);
}


// virtual void MiddleButtonReleaseEvent()
// "virtual void MiddleButtonReleaseEvent()"
public void MiddleButtonReleaseEvent() {
	VTK_API.API_vtkRenderWindowInteractor.MiddleButtonReleaseEvent_0(this);
}


// virtual void MouseWheelForwardEvent()
// "virtual void MouseWheelForwardEvent()"
public void MouseWheelForwardEvent() {
	VTK_API.API_vtkRenderWindowInteractor.MouseWheelForwardEvent_0(this);
}


// virtual void MouseWheelBackwardEvent()
// "virtual void MouseWheelBackwardEvent()"
public void MouseWheelBackwardEvent() {
	VTK_API.API_vtkRenderWindowInteractor.MouseWheelBackwardEvent_0(this);
}


// virtual void ExposeEvent()
// "virtual void ExposeEvent()"
public void ExposeEvent() {
	VTK_API.API_vtkRenderWindowInteractor.ExposeEvent_0(this);
}


// virtual void ConfigureEvent()
// "virtual void ConfigureEvent()"
public void ConfigureEvent() {
	VTK_API.API_vtkRenderWindowInteractor.ConfigureEvent_0(this);
}


// virtual void EnterEvent()
// "virtual void EnterEvent()"
public void EnterEvent() {
	VTK_API.API_vtkRenderWindowInteractor.EnterEvent_0(this);
}


// virtual void LeaveEvent()
// "virtual void LeaveEvent()"
public void LeaveEvent() {
	VTK_API.API_vtkRenderWindowInteractor.LeaveEvent_0(this);
}


// virtual void KeyPressEvent()
// "virtual void KeyPressEvent()"
public void KeyPressEvent() {
	VTK_API.API_vtkRenderWindowInteractor.KeyPressEvent_0(this);
}


// virtual void KeyReleaseEvent()
// "virtual void KeyReleaseEvent()"
public void KeyReleaseEvent() {
	VTK_API.API_vtkRenderWindowInteractor.KeyReleaseEvent_0(this);
}


// virtual void CharEvent()
// "virtual void CharEvent()"
public void CharEvent() {
	VTK_API.API_vtkRenderWindowInteractor.CharEvent_0(this);
}


// virtual void ExitEvent()
// "virtual void ExitEvent()"
public void ExitEvent() {
	VTK_API.API_vtkRenderWindowInteractor.ExitEvent_0(this);
}


// virtual void FourthButtonPressEvent()
// "virtual void FourthButtonPressEvent()"
public void FourthButtonPressEvent() {
	VTK_API.API_vtkRenderWindowInteractor.FourthButtonPressEvent_0(this);
}


// virtual void FourthButtonReleaseEvent()
// "virtual void FourthButtonReleaseEvent()"
public void FourthButtonReleaseEvent() {
	VTK_API.API_vtkRenderWindowInteractor.FourthButtonReleaseEvent_0(this);
}


// virtual void FifthButtonPressEvent()
// "virtual void FifthButtonPressEvent()"
public void FifthButtonPressEvent() {
	VTK_API.API_vtkRenderWindowInteractor.FifthButtonPressEvent_0(this);
}


// virtual void FifthButtonReleaseEvent()
// "virtual void FifthButtonReleaseEvent()"
public void FifthButtonReleaseEvent() {
	VTK_API.API_vtkRenderWindowInteractor.FifthButtonReleaseEvent_0(this);
}


// virtual void StartPinchEvent()
// "virtual void StartPinchEvent()"
public void StartPinchEvent() {
	VTK_API.API_vtkRenderWindowInteractor.StartPinchEvent_0(this);
}


// virtual void PinchEvent()
// "virtual void PinchEvent()"
public void PinchEvent() {
	VTK_API.API_vtkRenderWindowInteractor.PinchEvent_0(this);
}


// virtual void EndPinchEvent()
// "virtual void EndPinchEvent()"
public void EndPinchEvent() {
	VTK_API.API_vtkRenderWindowInteractor.EndPinchEvent_0(this);
}


// virtual void StartRotateEvent()
// "virtual void StartRotateEvent()"
public void StartRotateEvent() {
	VTK_API.API_vtkRenderWindowInteractor.StartRotateEvent_0(this);
}


// virtual void RotateEvent()
// "virtual void RotateEvent()"
public void RotateEvent() {
	VTK_API.API_vtkRenderWindowInteractor.RotateEvent_0(this);
}


// virtual void EndRotateEvent()
// "virtual void EndRotateEvent()"
public void EndRotateEvent() {
	VTK_API.API_vtkRenderWindowInteractor.EndRotateEvent_0(this);
}


// virtual void StartPanEvent()
// "virtual void StartPanEvent()"
public void StartPanEvent() {
	VTK_API.API_vtkRenderWindowInteractor.StartPanEvent_0(this);
}


// virtual void PanEvent()
// "virtual void PanEvent()"
public void PanEvent() {
	VTK_API.API_vtkRenderWindowInteractor.PanEvent_0(this);
}


// virtual void EndPanEvent()
// "virtual void EndPanEvent()"
public void EndPanEvent() {
	VTK_API.API_vtkRenderWindowInteractor.EndPanEvent_0(this);
}


// virtual void TapEvent()
// "virtual void TapEvent()"
public void TapEvent() {
	VTK_API.API_vtkRenderWindowInteractor.TapEvent_0(this);
}


// virtual void LongTapEvent()
// "virtual void LongTapEvent()"
public void LongTapEvent() {
	VTK_API.API_vtkRenderWindowInteractor.LongTapEvent_0(this);
}


// virtual void SwipeEvent()
// "virtual void SwipeEvent()"
public void SwipeEvent() {
	VTK_API.API_vtkRenderWindowInteractor.SwipeEvent_0(this);
}


// virtual void SetRecognizeGestures(bool _arg)
// "virtual void SetRecognizeGestures (bool _arg)"
public void SetRecognizeGestures(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderWindowInteractor.SetRecognizeGestures_0(this, _arg);
}


// virtual bool GetRecognizeGestures()
// "virtual bool GetRecognizeGestures ()"
public bool GetRecognizeGestures() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.GetRecognizeGestures_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual int GetPointersDownCount()
// "virtual int GetPointersDownCount ()"
public int GetPointersDownCount() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetPointersDownCount_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void ClearContact(size_t contactID)
// "void ClearContact(size_t contactID)"
public void ClearContact(ulong /*(size_t)*/ contactID) {
	VTK_API.API_vtkRenderWindowInteractor.ClearContact_0(this, contactID);
}


// int GetPointerIndexForContact(size_t contactID)
// "int GetPointerIndexForContact(size_t contactID)"
public int GetPointerIndexForContact(ulong /*(size_t)*/ contactID) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetPointerIndexForContact_0(out returnPointer, this, contactID);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetPointerIndexForExistingContact(size_t contactID)
// "int GetPointerIndexForExistingContact(size_t contactID)"
public int GetPointerIndexForExistingContact(ulong /*(size_t)*/ contactID) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderWindowInteractor.GetPointerIndexForExistingContact_0(out returnPointer, this, contactID);
//	return (int)returnPointer;
	return returnPointer;
}


// bool IsPointerIndexSet(int i)
// "bool IsPointerIndexSet(int i)"
public bool IsPointerIndexSet(int /*(int)*/ i) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderWindowInteractor.IsPointerIndexSet_0(out returnPointer, this, i);
//	return (bool)returnPointer;
	return returnPointer;
}


// void ClearPointerIndex(int i)
// "void ClearPointerIndex(int i)"
public void ClearPointerIndex(int /*(int)*/ i) {
	VTK_API.API_vtkRenderWindowInteractor.ClearPointerIndex_0(this, i);
}


}
};
