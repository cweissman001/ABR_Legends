

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPickingManager : vtkObject {
		public vtkPickingManager(IntPtr p) : base(p) {}
		public static implicit operator  vtkPickingManager(IntPtr p) {return new vtkPickingManager(p);}
		public static implicit operator  IntPtr(vtkPickingManager o) {return o.GetPtr();}

// static vtkPickingManager* New()
// "static vtkPickingManager *New()"
public static vtkPickingManager New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPickingManager.New_0(out returnPointer);
//	return (vtkPickingManager)(IntPtr)returnPointer;
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPickingManager* SafeDownCast(vtkObjectBase * o)
// "static vtkPickingManager* SafeDownCast(vtkObjectBase *o)"
public static vtkPickingManager SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPickingManager.SafeDownCast_0(out returnPointer, o);
//	return (vtkPickingManager)(IntPtr)returnPointer;
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// vtkPickingManager* NewInstance()
// "vtkPickingManager *NewInstance()"
public vtkPickingManager NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPickingManager.NewInstance_0(out returnPointer, this);
//	return (vtkPickingManager)(IntPtr)returnPointer;
	return (vtkPickingManager)(IntPtr)returnPointer;
}


// virtual void EnabledOn()
// "virtual void EnabledOn ()"
public void EnabledOn() {
	VTK_API.API_vtkPickingManager.EnabledOn_0(this);
}


// virtual void EnabledOff()
// "virtual void EnabledOff ()"
public void EnabledOff() {
	VTK_API.API_vtkPickingManager.EnabledOff_0(this);
}


// virtual void SetEnabled(bool _arg)
// "virtual void SetEnabled (bool _arg)"
public void SetEnabled(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkPickingManager.SetEnabled_0(this, _arg);
}


// virtual bool GetEnabled()
// "virtual bool GetEnabled ()"
public bool GetEnabled() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.GetEnabled_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void SetOptimizeOnInteractorEvents(bool optimize)
// "void SetOptimizeOnInteractorEvents(bool optimize)"
public void SetOptimizeOnInteractorEvents(bool /*(bool)*/ optimize) {
	VTK_API.API_vtkPickingManager.SetOptimizeOnInteractorEvents_0(this, optimize);
}


// virtual bool GetOptimizeOnInteractorEvents()
// "virtual bool GetOptimizeOnInteractorEvents ()"
public bool GetOptimizeOnInteractorEvents() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.GetOptimizeOnInteractorEvents_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void SetInteractor(vtkRenderWindowInteractor * iren)
// "void SetInteractor(vtkRenderWindowInteractor* iren)"
public void SetInteractor(vtkRenderWindowInteractor /*(vtkRenderWindowInteractor*)*/ iren) {
	VTK_API.API_vtkPickingManager.SetInteractor_0(this, iren);
}


// virtual vtkRenderWindowInteractor* GetInteractor()
// "virtual vtkRenderWindowInteractor* GetInteractor ()"
public vtkRenderWindowInteractor GetInteractor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPickingManager.GetInteractor_0(out returnPointer, this);
//	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
	return (vtkRenderWindowInteractor)(IntPtr)returnPointer;
}


// void AddPicker(vtkAbstractPicker * picker, vtkObject * object = nullptr)
// "void AddPicker(vtkAbstractPicker* picker, vtkObject* object = nullptr)"
public void AddPicker(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker, vtkObject /*(vtkObject*)*/ obj) {
	VTK_API.API_vtkPickingManager.AddPicker_0(this, picker, obj);
}


// void RemovePicker(vtkAbstractPicker * picker, vtkObject * object = nullptr)
// "void RemovePicker(vtkAbstractPicker* picker, vtkObject* object = nullptr)"
public void RemovePicker(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker, vtkObject /*(vtkObject*)*/ obj) {
	VTK_API.API_vtkPickingManager.RemovePicker_0(this, picker, obj);
}


// void RemoveObject(vtkObject * object)
// "void RemoveObject(vtkObject* object)"
public void RemoveObject(vtkObject /*(vtkObject*)*/ obj) {
	VTK_API.API_vtkPickingManager.RemoveObject_0(this, obj);
}


// bool Pick(vtkAbstractPicker * picker, vtkObject * object)
// "bool Pick(vtkAbstractPicker* picker, vtkObject* object)"
public bool Pick(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker, vtkObject /*(vtkObject*)*/ obj) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.Pick_0(out returnPointer, this, picker, obj);
//	return (bool)returnPointer;
	return returnPointer;
}


// bool Pick(vtkObject * object)
// "bool Pick(vtkObject* object)"
public bool Pick(vtkObject /*(vtkObject*)*/ obj) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.Pick_1(out returnPointer, this, obj);
//	return (bool)returnPointer;
	return returnPointer;
}


// bool Pick(vtkAbstractPicker * picker)
// "bool Pick(vtkAbstractPicker* picker)"
public bool Pick(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPickingManager.Pick_2(out returnPointer, this, picker);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkAssemblyPath* GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker * picker, vtkRenderer * renderer, vtkObject * obj)
// "vtkAssemblyPath* GetAssemblyPath(double X, double Y, double Z, vtkAbstractPropPicker* picker, vtkRenderer* renderer, vtkObject* obj)"
public vtkAssemblyPath GetAssemblyPath(double /*(double)*/ X, double /*(double)*/ Y, double /*(double)*/ Z, vtkAbstractPropPicker /*(vtkAbstractPropPicker*)*/ picker, vtkRenderer /*(vtkRenderer*)*/ renderer, vtkObject /*(vtkObject*)*/ obj) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPickingManager.GetAssemblyPath_0(out returnPointer, this, X, Y, Z, picker, renderer, obj);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// int GetNumberOfPickers()
// "int GetNumberOfPickers()"
public int GetNumberOfPickers() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPickingManager.GetNumberOfPickers_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfObjectsLinked(vtkAbstractPicker * picker)
// "int GetNumberOfObjectsLinked(vtkAbstractPicker* picker)"
public int GetNumberOfObjectsLinked(vtkAbstractPicker /*(vtkAbstractPicker*)*/ picker) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPickingManager.GetNumberOfObjectsLinked_0(out returnPointer, this, picker);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
