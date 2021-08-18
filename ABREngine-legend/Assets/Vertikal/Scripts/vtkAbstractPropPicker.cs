

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractPropPicker : vtkAbstractPicker {
		public vtkAbstractPropPicker(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractPropPicker(IntPtr p) {return new vtkAbstractPropPicker(p);}
		public static implicit operator  IntPtr(vtkAbstractPropPicker o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPropPicker.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPropPicker.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractPropPicker* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractPropPicker* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractPropPicker SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractPropPicker)(IntPtr)returnPointer;
	return (vtkAbstractPropPicker)(IntPtr)returnPointer;
}


// vtkAbstractPropPicker* NewInstance()
// "vtkAbstractPropPicker *NewInstance()"
public vtkAbstractPropPicker NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractPropPicker)(IntPtr)returnPointer;
	return (vtkAbstractPropPicker)(IntPtr)returnPointer;
}


// virtual void SetPath(vtkAssemblyPath * ARG_0)
// "virtual void SetPath(vtkAssemblyPath*)"
public void SetPath(vtkAssemblyPath /*(vtkAssemblyPath*)*/ ARG_0) {
	VTK_API.API_vtkAbstractPropPicker.SetPath_0(this, ARG_0);
}


// virtual vtkAssemblyPath* GetPath()
// "virtual vtkAssemblyPath *GetPath ()"
public vtkAssemblyPath GetPath() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetPath_0(out returnPointer, this);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// virtual vtkProp* GetViewProp()
// "virtual vtkProp* GetViewProp()"
public vtkProp GetViewProp() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetViewProp_0(out returnPointer, this);
//	return (vtkProp)(IntPtr)returnPointer;
	return (vtkProp)(IntPtr)returnPointer;
}


// virtual vtkProp3D* GetProp3D()
// "virtual vtkProp3D *GetProp3D()"
public vtkProp3D GetProp3D() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetProp3D_0(out returnPointer, this);
//	return (vtkProp3D)(IntPtr)returnPointer;
	return (vtkProp3D)(IntPtr)returnPointer;
}


// virtual vtkActor* GetActor()
// "virtual vtkActor *GetActor()"
public vtkActor GetActor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetActor_0(out returnPointer, this);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// virtual vtkActor2D* GetActor2D()
// "virtual vtkActor2D *GetActor2D()"
public vtkActor2D GetActor2D() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetActor2D_0(out returnPointer, this);
//	return (vtkActor2D)(IntPtr)returnPointer;
	return (vtkActor2D)(IntPtr)returnPointer;
}


// virtual vtkVolume* GetVolume()
// "virtual vtkVolume *GetVolume()"
public vtkVolume GetVolume() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetVolume_0(out returnPointer, this);
//	return (vtkVolume)(IntPtr)returnPointer;
	return (vtkVolume)(IntPtr)returnPointer;
}


// virtual vtkAssembly* GetAssembly()
// "virtual vtkAssembly *GetAssembly()"
public vtkAssembly GetAssembly() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetAssembly_0(out returnPointer, this);
//	return (vtkAssembly)(IntPtr)returnPointer;
	return (vtkAssembly)(IntPtr)returnPointer;
}


// virtual vtkPropAssembly* GetPropAssembly()
// "virtual vtkPropAssembly *GetPropAssembly()"
public vtkPropAssembly GetPropAssembly() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPropPicker.GetPropAssembly_0(out returnPointer, this);
//	return (vtkPropAssembly)(IntPtr)returnPointer;
	return (vtkPropAssembly)(IntPtr)returnPointer;
}


}
};
