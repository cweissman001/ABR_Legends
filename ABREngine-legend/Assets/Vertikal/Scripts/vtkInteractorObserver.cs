

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkInteractorObserver : vtkObject {
		public vtkInteractorObserver(IntPtr p) : base(p) {}
		public static implicit operator  vtkInteractorObserver(IntPtr p) {return new vtkInteractorObserver(p);}
		public static implicit operator  IntPtr(vtkInteractorObserver o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInteractorObserver.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInteractorObserver.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkInteractorObserver* SafeDownCast(vtkObjectBase * o)
// "static vtkInteractorObserver* SafeDownCast(vtkObjectBase *o)"
public static vtkInteractorObserver SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInteractorObserver.SafeDownCast_0(out returnPointer, o);
//	return (vtkInteractorObserver)(IntPtr)returnPointer;
	return (vtkInteractorObserver)(IntPtr)returnPointer;
}


// vtkInteractorObserver* NewInstance()
// "vtkInteractorObserver *NewInstance()"
public vtkInteractorObserver NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInteractorObserver.NewInstance_0(out returnPointer, this);
//	return (vtkInteractorObserver)(IntPtr)returnPointer;
	return (vtkInteractorObserver)(IntPtr)returnPointer;
}


// virtual void SetEnabled(int ARG_0)
// "virtual void SetEnabled(int)"
public void SetEnabled(int /*(int)*/ ARG_0) {
	VTK_API.API_vtkInteractorObserver.SetEnabled_0(this, ARG_0);
}


// int GetEnabled()
// "int GetEnabled()"
public int GetEnabled() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkInteractorObserver.GetEnabled_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void EnabledOn()
// "void EnabledOn()"
public void EnabledOn() {
	VTK_API.API_vtkInteractorObserver.EnabledOn_0(this);
}


// void EnabledOff()
// "void EnabledOff()"
public void EnabledOff() {
	VTK_API.API_vtkInteractorObserver.EnabledOff_0(this);
}


// void On()
// "void On()"
public void On() {
	VTK_API.API_vtkInteractorObserver.On_0(this);
}


// void Off()
// "void Off()"
public void Off() {
	VTK_API.API_vtkInteractorObserver.Off_0(this);
}


// virtual void SetInteractor(vtkRenderWindowInteractor * iren)
// "virtual void SetInteractor(vtkRenderWindowInteractor* iren)"
public void SetInteractor(vtkRenderWindowInteractor /*(vtkRenderWindowInteractor*)*/ iren) {
	VTK_API.API_vtkInteractorObserver.SetInteractor_0(this, iren);
}


// virtual vtkRenderWindowInteractor* GetInteractor()
// "virtual vtkRenderWindowInteractor *GetInteractor ()"
public vtkRenderWindowInteractor GetInteractor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInteractorObserver.GetInteractor_0(out returnPointer, this);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// virtual void SetPriority(float _arg)
// "virtual void SetPriority (float _arg)"
public void SetPriority(float /*(float)*/ _arg) {
	VTK_API.API_vtkInteractorObserver.SetPriority_0(this, _arg);
}


// virtual float GetPriorityMinValue()
// "virtual float GetPriorityMinValue ()"
public float GetPriorityMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkInteractorObserver.GetPriorityMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetPriorityMaxValue()
// "virtual float GetPriorityMaxValue ()"
public float GetPriorityMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkInteractorObserver.GetPriorityMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetPriority()
// "virtual float GetPriority ()"
public float GetPriority() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkInteractorObserver.GetPriority_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void PickingManagedOn()
// "virtual void PickingManagedOn ()"
public void PickingManagedOn() {
	VTK_API.API_vtkInteractorObserver.PickingManagedOn_0(this);
}


// virtual void PickingManagedOff()
// "virtual void PickingManagedOff ()"
public void PickingManagedOff() {
	VTK_API.API_vtkInteractorObserver.PickingManagedOff_0(this);
}


// virtual void SetPickingManaged(bool managed)
// "virtual void SetPickingManaged(bool managed)"
public void SetPickingManaged(bool /*(bool)*/ managed) {
	VTK_API.API_vtkInteractorObserver.SetPickingManaged_0(this, managed);
}


// virtual bool GetPickingManaged()
// "virtual bool GetPickingManaged ()"
public bool GetPickingManaged() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInteractorObserver.GetPickingManaged_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetKeyPressActivation(vtkTypeBool _arg)
// "virtual void SetKeyPressActivation (vtkTypeBool _arg)"
public void SetKeyPressActivation(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkInteractorObserver.SetKeyPressActivation_0(this, _arg);
}


// virtual vtkTypeBool GetKeyPressActivation()
// "virtual vtkTypeBool GetKeyPressActivation ()"
public bool GetKeyPressActivation() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkInteractorObserver.GetKeyPressActivation_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void KeyPressActivationOn()
// "virtual void KeyPressActivationOn ()"
public void KeyPressActivationOn() {
	VTK_API.API_vtkInteractorObserver.KeyPressActivationOn_0(this);
}


// virtual void KeyPressActivationOff()
// "virtual void KeyPressActivationOff ()"
public void KeyPressActivationOff() {
	VTK_API.API_vtkInteractorObserver.KeyPressActivationOff_0(this);
}


// virtual void SetKeyPressActivationValue(char _arg)
// "virtual void SetKeyPressActivationValue (char _arg)"
public void SetKeyPressActivationValue(char /*(char)*/ _arg) {
	VTK_API.API_vtkInteractorObserver.SetKeyPressActivationValue_0(this, _arg);
}


// virtual char GetKeyPressActivationValue()
// "virtual char GetKeyPressActivationValue ()"
public char GetKeyPressActivationValue() {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkInteractorObserver.GetKeyPressActivationValue_0(out returnPointer, this);
//	return (char)returnPointer;
	return returnPointer;
}


// virtual vtkRenderer* GetDefaultRenderer()
// "virtual vtkRenderer *GetDefaultRenderer ()"
public vtkRenderer GetDefaultRenderer() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInteractorObserver.GetDefaultRenderer_0(out returnPointer, this);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// virtual void SetDefaultRenderer(vtkRenderer * ARG_0)
// "virtual void SetDefaultRenderer(vtkRenderer*)"
public void SetDefaultRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkInteractorObserver.SetDefaultRenderer_0(this, ARG_0);
}


// virtual vtkRenderer* GetCurrentRenderer()
// "virtual vtkRenderer *GetCurrentRenderer ()"
public vtkRenderer GetCurrentRenderer() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkInteractorObserver.GetCurrentRenderer_0(out returnPointer, this);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// virtual void SetCurrentRenderer(vtkRenderer * ARG_0)
// "virtual void SetCurrentRenderer(vtkRenderer*)"
public void SetCurrentRenderer(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkInteractorObserver.SetCurrentRenderer_0(this, ARG_0);
}


// virtual void OnChar()
// "virtual void OnChar()"
public void OnChar() {
	VTK_API.API_vtkInteractorObserver.OnChar_0(this);
}


// static void ComputeDisplayToWorld(vtkRenderer * ren, double x, double y, double z, double worldPt[4])
// "static void ComputeDisplayToWorld(vtkRenderer *ren, double x, double y, double z, double worldPt[4])"
public static void ComputeDisplayToWorld(vtkRenderer /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, double /*(double[4])*/ []worldPt) {
	VTK_API.API_vtkInteractorObserver.ComputeDisplayToWorld_0(ren, x, y, z, worldPt);
}


// static void ComputeWorldToDisplay(vtkRenderer * ren, double x, double y, double z, double displayPt[3])
// "static void ComputeWorldToDisplay(vtkRenderer *ren, double x, double y, double z, double displayPt[3])"
public static void ComputeWorldToDisplay(vtkRenderer /*(vtkRenderer*)*/ ren, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z, double /*(double[3])*/ []displayPt) {
	VTK_API.API_vtkInteractorObserver.ComputeWorldToDisplay_0(ren, x, y, z, displayPt);
}


// void GrabFocus(vtkCommand * mouseEvents, vtkCommand * keypressEvents = nullptr)
// "void GrabFocus(vtkCommand *mouseEvents, vtkCommand *keypressEvents=nullptr)"
public void GrabFocus(vtkCommand /*(vtkCommand*)*/ mouseEvents, vtkCommand /*(vtkCommand*)*/ keypressEvents) {
	VTK_API.API_vtkInteractorObserver.GrabFocus_0(this, mouseEvents, keypressEvents);
}


// void ReleaseFocus()
// "void ReleaseFocus()"
public void ReleaseFocus() {
	VTK_API.API_vtkInteractorObserver.ReleaseFocus_0(this);
}


}
};
