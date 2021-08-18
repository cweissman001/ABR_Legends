

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAssemblyPaths : vtkCollection {
		public vtkAssemblyPaths(IntPtr p) : base(p) {}
		public static implicit operator  vtkAssemblyPaths(IntPtr p) {return new vtkAssemblyPaths(p);}
		public static implicit operator  IntPtr(vtkAssemblyPaths o) {return o.GetPtr();}

// static vtkAssemblyPaths* New()
// "static vtkAssemblyPaths *New()"
public static vtkAssemblyPaths New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPaths.New_0(out returnPointer);
//	return (vtkAssemblyPaths)(IntPtr)returnPointer;
	return (vtkAssemblyPaths)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssemblyPaths.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAssemblyPaths.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAssemblyPaths* SafeDownCast(vtkObjectBase * o)
// "static vtkAssemblyPaths* SafeDownCast(vtkObjectBase *o)"
public static vtkAssemblyPaths SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPaths.SafeDownCast_0(out returnPointer, o);
//	return (vtkAssemblyPaths)(IntPtr)returnPointer;
	return (vtkAssemblyPaths)(IntPtr)returnPointer;
}


// vtkAssemblyPaths* NewInstance()
// "vtkAssemblyPaths *NewInstance()"
public vtkAssemblyPaths NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPaths.NewInstance_0(out returnPointer, this);
//	return (vtkAssemblyPaths)(IntPtr)returnPointer;
	return (vtkAssemblyPaths)(IntPtr)returnPointer;
}


// void AddItem(vtkAssemblyPath * p)
// "void AddItem(vtkAssemblyPath *p)"
public void AddItem(vtkAssemblyPath /*(vtkAssemblyPath*)*/ p) {
	VTK_API.API_vtkAssemblyPaths.AddItem_0(this, p);
}


// void RemoveItem(vtkAssemblyPath * p)
// "void RemoveItem(vtkAssemblyPath *p)"
public void RemoveItem(vtkAssemblyPath /*(vtkAssemblyPath*)*/ p) {
	VTK_API.API_vtkAssemblyPaths.RemoveItem_0(this, p);
}


// int IsItemPresent(vtkAssemblyPath * p)
// "int IsItemPresent(vtkAssemblyPath *p)"
public int IsItemPresent(vtkAssemblyPath /*(vtkAssemblyPath*)*/ p) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAssemblyPaths.IsItemPresent_0(out returnPointer, this, p);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkAssemblyPath* GetNextItem()
// "vtkAssemblyPath *GetNextItem()"
public vtkAssemblyPath GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAssemblyPaths.GetNextItem_0(out returnPointer, this);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAssemblyPaths.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


}
};
