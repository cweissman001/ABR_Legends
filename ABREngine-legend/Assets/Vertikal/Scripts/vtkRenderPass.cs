

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderPass : vtkObject {
		public vtkRenderPass(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderPass(IntPtr p) {return new vtkRenderPass(p);}
		public static implicit operator  IntPtr(vtkRenderPass o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderPass.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderPass.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkRenderPass* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderPass* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderPass SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderPass.SafeDownCast_0(out returnPointer, o);
//	return (vtkRenderPass)(IntPtr)returnPointer;
	return (vtkRenderPass)(IntPtr)returnPointer;
}


// vtkRenderPass* NewInstance()
// "vtkRenderPass *NewInstance()"
public vtkRenderPass NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderPass.NewInstance_0(out returnPointer, this);
//	return (vtkRenderPass)(IntPtr)returnPointer;
	return (vtkRenderPass)(IntPtr)returnPointer;
}


// virtual int GetNumberOfRenderedProps()
// "virtual int GetNumberOfRenderedProps ()"
public int GetNumberOfRenderedProps() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderPass.GetNumberOfRenderedProps_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * w)
// "virtual void ReleaseGraphicsResources(vtkWindow *w)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ w) {
	VTK_API.API_vtkRenderPass.ReleaseGraphicsResources_0(this, w);
}


}
};
