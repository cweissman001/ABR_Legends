

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkActor2DCollection : vtkPropCollection {
		public vtkActor2DCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkActor2DCollection(IntPtr p) {return new vtkActor2DCollection(p);}
		public static implicit operator  IntPtr(vtkActor2DCollection o) {return o.GetPtr();}

// static vtkActor2DCollection* New()
// "static vtkActor2DCollection *New()"
public static vtkActor2DCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.New_0(out returnPointer);
//	return (vtkActor2DCollection)(IntPtr)returnPointer;
	return (vtkActor2DCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor2DCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkActor2DCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkActor2DCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkActor2DCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkActor2DCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkActor2DCollection)(IntPtr)returnPointer;
	return (vtkActor2DCollection)(IntPtr)returnPointer;
}


// vtkActor2DCollection* NewInstance()
// "vtkActor2DCollection *NewInstance()"
public vtkActor2DCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.NewInstance_0(out returnPointer, this);
//	return (vtkActor2DCollection)(IntPtr)returnPointer;
	return (vtkActor2DCollection)(IntPtr)returnPointer;
}


// void Sort()
// "void Sort()"
public void Sort() {
	VTK_API.API_vtkActor2DCollection.Sort_0(this);
}


// void AddItem(vtkActor2D * a)
// "void AddItem(vtkActor2D *a)"
public void AddItem(vtkActor2D /*(vtkActor2D*)*/ a) {
	VTK_API.API_vtkActor2DCollection.AddItem_0(this, a);
}


// int IsItemPresent(vtkActor2D * a)
// "int IsItemPresent(vtkActor2D *a)"
public int IsItemPresent(vtkActor2D /*(vtkActor2D*)*/ a) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkActor2DCollection.IsItemPresent_0(out returnPointer, this, a);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkActor2D* GetNextActor2D()
// "vtkActor2D *GetNextActor2D()"
public vtkActor2D GetNextActor2D() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.GetNextActor2D_0(out returnPointer, this);
//	return (vtkActor2D)(IntPtr)returnPointer;
	return (vtkActor2D)(IntPtr)returnPointer;
}


// vtkActor2D* GetLastActor2D()
// "vtkActor2D *GetLastActor2D()"
public vtkActor2D GetLastActor2D() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.GetLastActor2D_0(out returnPointer, this);
//	return (vtkActor2D)(IntPtr)returnPointer;
	return (vtkActor2D)(IntPtr)returnPointer;
}


// vtkActor2D* GetNextItem()
// "vtkActor2D *GetNextItem()"
public vtkActor2D GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.GetNextItem_0(out returnPointer, this);
//	return (vtkActor2D)(IntPtr)returnPointer;
	return (vtkActor2D)(IntPtr)returnPointer;
}


// vtkActor2D* GetLastItem()
// "vtkActor2D *GetLastItem()"
public vtkActor2D GetLastItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkActor2DCollection.GetLastItem_0(out returnPointer, this);
//	return (vtkActor2D)(IntPtr)returnPointer;
	return (vtkActor2D)(IntPtr)returnPointer;
}


// void RenderOverlay(vtkViewport * viewport)
// "void RenderOverlay(vtkViewport* viewport)"
public void RenderOverlay(vtkViewport /*(vtkViewport*)*/ viewport) {
	VTK_API.API_vtkActor2DCollection.RenderOverlay_0(this, viewport);
}


}
};
