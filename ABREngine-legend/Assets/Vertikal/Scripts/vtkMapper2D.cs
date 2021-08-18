

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkMapper2D : vtkAbstractMapper {
		public vtkMapper2D(IntPtr p) : base(p) {}
		public static implicit operator  vtkMapper2D(IntPtr p) {return new vtkMapper2D(p);}
		public static implicit operator  IntPtr(vtkMapper2D o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper2D.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper2D.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkMapper2D* SafeDownCast(vtkObjectBase * o)
// "static vtkMapper2D* SafeDownCast(vtkObjectBase *o)"
public static vtkMapper2D SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper2D.SafeDownCast_0(out returnPointer, o);
//	return (vtkMapper2D)(IntPtr)returnPointer;
	return (vtkMapper2D)(IntPtr)returnPointer;
}


// vtkMapper2D* NewInstance()
// "vtkMapper2D *NewInstance()"
public vtkMapper2D NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper2D.NewInstance_0(out returnPointer, this);
//	return (vtkMapper2D)(IntPtr)returnPointer;
	return (vtkMapper2D)(IntPtr)returnPointer;
}


// virtual void RenderOverlay(vtkViewport * ARG_0, vtkActor2D * ARG_1)
// "virtual void RenderOverlay(vtkViewport*, vtkActor2D*)"
public void RenderOverlay(vtkViewport /*(vtkViewport*)*/ ARG_0, vtkActor2D /*(vtkActor2D*)*/ ARG_1) {
	VTK_API.API_vtkMapper2D.RenderOverlay_0(this, ARG_0, ARG_1);
}


// virtual void RenderOpaqueGeometry(vtkViewport * ARG_0, vtkActor2D * ARG_1)
// "virtual void RenderOpaqueGeometry(vtkViewport*, vtkActor2D*)"
public void RenderOpaqueGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0, vtkActor2D /*(vtkActor2D*)*/ ARG_1) {
	VTK_API.API_vtkMapper2D.RenderOpaqueGeometry_0(this, ARG_0, ARG_1);
}


// virtual void RenderTranslucentPolygonalGeometry(vtkViewport * ARG_0, vtkActor2D * ARG_1)
// "virtual void RenderTranslucentPolygonalGeometry(vtkViewport*, vtkActor2D*)"
public void RenderTranslucentPolygonalGeometry(vtkViewport /*(vtkViewport*)*/ ARG_0, vtkActor2D /*(vtkActor2D*)*/ ARG_1) {
	VTK_API.API_vtkMapper2D.RenderTranslucentPolygonalGeometry_0(this, ARG_0, ARG_1);
}


// virtual vtkTypeBool HasTranslucentPolygonalGeometry()
// "virtual vtkTypeBool HasTranslucentPolygonalGeometry()"
public bool HasTranslucentPolygonalGeometry() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper2D.HasTranslucentPolygonalGeometry_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
