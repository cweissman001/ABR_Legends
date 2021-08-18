

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPlaneCollection : vtkCollection {
		public vtkPlaneCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkPlaneCollection(IntPtr p) {return new vtkPlaneCollection(p);}
		public static implicit operator  IntPtr(vtkPlaneCollection o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPlaneCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPlaneCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPlaneCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkPlaneCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkPlaneCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlaneCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkPlaneCollection)(IntPtr)returnPointer;
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// vtkPlaneCollection* NewInstance()
// "vtkPlaneCollection *NewInstance()"
public vtkPlaneCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlaneCollection.NewInstance_0(out returnPointer, this);
//	return (vtkPlaneCollection)(IntPtr)returnPointer;
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// static vtkPlaneCollection* New()
// "static vtkPlaneCollection *New()"
public static vtkPlaneCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlaneCollection.New_0(out returnPointer);
//	return (vtkPlaneCollection)(IntPtr)returnPointer;
	return (vtkPlaneCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkPlane * ARG_0)
// "void AddItem(vtkPlane *)"
public void AddItem(vtkPlane /*(vtkPlane*)*/ ARG_0) {
	VTK_API.API_vtkPlaneCollection.AddItem_0(this, ARG_0);
}


// vtkPlane* GetNextItem()
// "vtkPlane *GetNextItem()"
public vtkPlane GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlaneCollection.GetNextItem_0(out returnPointer, this);
//	return (vtkPlane)(IntPtr)returnPointer;
	return (vtkPlane)(IntPtr)returnPointer;
}


// vtkPlane* GetItem(int i)
// "vtkPlane *GetItem(int i)"
public vtkPlane GetItem(int /*(int)*/ i) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlaneCollection.GetItem_0(out returnPointer, this, i);
//	return (vtkPlane)(IntPtr)returnPointer;
	return (vtkPlane)(IntPtr)returnPointer;
}


}
};
