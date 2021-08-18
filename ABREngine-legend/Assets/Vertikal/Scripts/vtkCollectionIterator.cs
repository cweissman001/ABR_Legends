

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCollectionIterator : vtkObject {
		public vtkCollectionIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkCollectionIterator(IntPtr p) {return new vtkCollectionIterator(p);}
		public static implicit operator  IntPtr(vtkCollectionIterator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCollectionIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCollectionIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCollectionIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkCollectionIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkCollectionIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCollectionIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkCollectionIterator)(IntPtr)returnPointer;
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// vtkCollectionIterator* NewInstance()
// "vtkCollectionIterator *NewInstance()"
public vtkCollectionIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCollectionIterator.NewInstance_0(out returnPointer, this);
//	return (vtkCollectionIterator)(IntPtr)returnPointer;
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// static vtkCollectionIterator* New()
// "static vtkCollectionIterator* New()"
public static vtkCollectionIterator New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCollectionIterator.New_0(out returnPointer);
//	return (vtkCollectionIterator)(IntPtr)returnPointer;
	return (vtkCollectionIterator)(IntPtr)returnPointer;
}


// virtual void SetCollection(vtkCollection * ARG_0)
// "virtual void SetCollection(vtkCollection*)"
public void SetCollection(vtkCollection /*(vtkCollection*)*/ ARG_0) {
	VTK_API.API_vtkCollectionIterator.SetCollection_0(this, ARG_0);
}


// virtual vtkCollection* GetCollection()
// "virtual vtkCollection *GetCollection ()"
public vtkCollection GetCollection() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCollectionIterator.GetCollection_0(out returnPointer, this);
//	return (vtkCollection)(IntPtr)returnPointer;
	return (vtkCollection)(IntPtr)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCollectionIterator.InitTraversal_0(this);
}


// void GoToFirstItem()
// "void GoToFirstItem()"
public void GoToFirstItem() {
	VTK_API.API_vtkCollectionIterator.GoToFirstItem_0(this);
}


// void GoToNextItem()
// "void GoToNextItem()"
public void GoToNextItem() {
	VTK_API.API_vtkCollectionIterator.GoToNextItem_0(this);
}


// int IsDoneWithTraversal()
// "int IsDoneWithTraversal()"
public int IsDoneWithTraversal() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCollectionIterator.IsDoneWithTraversal_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkObject* GetCurrentObject()
// "vtkObject* GetCurrentObject()"
public vtkObject GetCurrentObject() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCollectionIterator.GetCurrentObject_0(out returnPointer, this);
//	return (vtkObject)(IntPtr)returnPointer;
	return (vtkObject)(IntPtr)returnPointer;
}


}
};
