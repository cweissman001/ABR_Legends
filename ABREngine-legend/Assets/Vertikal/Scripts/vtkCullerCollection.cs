

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCullerCollection : vtkCollection {
		public vtkCullerCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkCullerCollection(IntPtr p) {return new vtkCullerCollection(p);}
		public static implicit operator  IntPtr(vtkCullerCollection o) {return o.GetPtr();}

// static vtkCullerCollection* New()
// "static vtkCullerCollection *New()"
public static vtkCullerCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCullerCollection.New_0(out returnPointer);
//	return (vtkCullerCollection)(IntPtr)returnPointer;
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCullerCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCullerCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCullerCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkCullerCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkCullerCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCullerCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkCullerCollection)(IntPtr)returnPointer;
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// vtkCullerCollection* NewInstance()
// "vtkCullerCollection *NewInstance()"
public vtkCullerCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCullerCollection.NewInstance_0(out returnPointer, this);
//	return (vtkCullerCollection)(IntPtr)returnPointer;
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkCuller * a)
// "void AddItem(vtkCuller *a)"
public void AddItem(vtkCuller /*(vtkCuller*)*/ a) {
	VTK_API.API_vtkCullerCollection.AddItem_0(this, a);
}


// vtkCuller* GetNextItem()
// "vtkCuller *GetNextItem()"
public vtkCuller GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCullerCollection.GetNextItem_0(out returnPointer, this);
//	return (vtkCuller)(IntPtr)returnPointer;
	return (vtkCuller)(IntPtr)returnPointer;
}


// vtkCuller* GetLastItem()
// "vtkCuller *GetLastItem()"
public vtkCuller GetLastItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCullerCollection.GetLastItem_0(out returnPointer, this);
//	return (vtkCuller)(IntPtr)returnPointer;
	return (vtkCuller)(IntPtr)returnPointer;
}


}
};
