

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkActorCollection : vtkPropCollection {
		public vtkActorCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkActorCollection(IntPtr p) {return new vtkActorCollection(p);}
		public static implicit operator  IntPtr(vtkActorCollection o) {return o.GetPtr();}

// static vtkActorCollection* New()
// "static vtkActorCollection *New()"
public static vtkActorCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.New_0(out returnPointer);
//	return (vtkActorCollection)(IntPtr)returnPointer;
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActorCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActorCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkActorCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkActorCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkActorCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkActorCollection)(IntPtr)returnPointer;
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// vtkActorCollection* NewInstance()
// "vtkActorCollection *NewInstance()"
public vtkActorCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.NewInstance_0(out returnPointer, this);
//	return (vtkActorCollection)(IntPtr)returnPointer;
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkActor * a)
// "void AddItem(vtkActor *a)"
public void AddItem(vtkActor /*(vtkActor*)*/ a) {
	VTK_API.API_vtkActorCollection.AddItem_0(this, a);
}


// vtkActor* GetNextActor()
// "vtkActor *GetNextActor()"
public vtkActor GetNextActor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.GetNextActor_0(out returnPointer, this);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* GetLastActor()
// "vtkActor *GetLastActor()"
public vtkActor GetLastActor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.GetLastActor_0(out returnPointer, this);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* GetNextItem()
// "vtkActor *GetNextItem()"
public vtkActor GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.GetNextItem_0(out returnPointer, this);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// vtkActor* GetLastItem()
// "vtkActor *GetLastItem()"
public vtkActor GetLastItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActorCollection.GetLastItem_0(out returnPointer, this);
//	return (vtkActor)(IntPtr)returnPointer;
	return (vtkActor)(IntPtr)returnPointer;
}


// void ApplyProperties(vtkProperty * p)
// "void ApplyProperties(vtkProperty *p)"
public void ApplyProperties(vtkProperty /*(vtkProperty*)*/ p) {
	VTK_API.API_vtkActorCollection.ApplyProperties_0(this, p);
}


}
};
