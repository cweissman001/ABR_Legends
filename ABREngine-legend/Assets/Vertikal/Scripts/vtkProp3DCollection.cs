

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProp3DCollection : vtkPropCollection {
		public vtkProp3DCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkProp3DCollection(IntPtr p) {return new vtkProp3DCollection(p);}
		public static implicit operator  IntPtr(vtkProp3DCollection o) {return o.GetPtr();}

// static vtkProp3DCollection* New()
// "static vtkProp3DCollection *New()"
public static vtkProp3DCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp3DCollection.New_0(out returnPointer);
//	return (vtkProp3DCollection)(IntPtr)returnPointer;
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp3DCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProp3DCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkProp3DCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkProp3DCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkProp3DCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp3DCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkProp3DCollection)(IntPtr)returnPointer;
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// vtkProp3DCollection* NewInstance()
// "vtkProp3DCollection *NewInstance()"
public vtkProp3DCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp3DCollection.NewInstance_0(out returnPointer, this);
//	return (vtkProp3DCollection)(IntPtr)returnPointer;
	return (vtkProp3DCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkProp3D * p)
// "void AddItem(vtkProp3D *p)"
public void AddItem(vtkProp3D /*(vtkProp3D*)*/ p) {
	VTK_API.API_vtkProp3DCollection.AddItem_0(this, p);
}


// vtkProp3D* GetNextProp3D()
// "vtkProp3D *GetNextProp3D()"
public vtkProp3D GetNextProp3D() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp3DCollection.GetNextProp3D_0(out returnPointer, this);
//	return (vtkProp3D)(IntPtr)returnPointer;
	return (vtkProp3D)(IntPtr)returnPointer;
}


// vtkProp3D* GetLastProp3D()
// "vtkProp3D *GetLastProp3D()"
public vtkProp3D GetLastProp3D() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProp3DCollection.GetLastProp3D_0(out returnPointer, this);
//	return (vtkProp3D)(IntPtr)returnPointer;
	return (vtkProp3D)(IntPtr)returnPointer;
}


}
};
