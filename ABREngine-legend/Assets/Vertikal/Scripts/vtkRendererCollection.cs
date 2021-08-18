

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRendererCollection : vtkCollection {
		public vtkRendererCollection(IntPtr p) : base(p) {}
		public static implicit operator  vtkRendererCollection(IntPtr p) {return new vtkRendererCollection(p);}
		public static implicit operator  IntPtr(vtkRendererCollection o) {return o.GetPtr();}

// static vtkRendererCollection* New()
// "static vtkRendererCollection *New()"
public static vtkRendererCollection New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRendererCollection.New_0(out returnPointer);
//	return (vtkRendererCollection)(IntPtr)returnPointer;
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRendererCollection.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRendererCollection.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkRendererCollection* SafeDownCast(vtkObjectBase * o)
// "static vtkRendererCollection* SafeDownCast(vtkObjectBase *o)"
public static vtkRendererCollection SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRendererCollection.SafeDownCast_0(out returnPointer, o);
//	return (vtkRendererCollection)(IntPtr)returnPointer;
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// vtkRendererCollection* NewInstance()
// "vtkRendererCollection *NewInstance()"
public vtkRendererCollection NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRendererCollection.NewInstance_0(out returnPointer, this);
//	return (vtkRendererCollection)(IntPtr)returnPointer;
	return (vtkRendererCollection)(IntPtr)returnPointer;
}


// void AddItem(vtkRenderer * a)
// "void AddItem(vtkRenderer *a)"
public void AddItem(vtkRenderer /*(vtkRenderer*)*/ a) {
	VTK_API.API_vtkRendererCollection.AddItem_0(this, a);
}


// vtkRenderer* GetNextItem()
// "vtkRenderer *GetNextItem()"
public vtkRenderer GetNextItem() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRendererCollection.GetNextItem_0(out returnPointer, this);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// void Render()
// "void Render()"
public void Render() {
	VTK_API.API_vtkRendererCollection.Render_0(this);
}


// vtkRenderer* GetFirstRenderer()
// "vtkRenderer *GetFirstRenderer()"
public vtkRenderer GetFirstRenderer() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRendererCollection.GetFirstRenderer_0(out returnPointer, this);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


}
};
