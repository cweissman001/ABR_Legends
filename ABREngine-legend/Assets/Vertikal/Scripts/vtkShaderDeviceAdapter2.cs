

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkShaderDeviceAdapter2 : vtkObject {
		public vtkShaderDeviceAdapter2(IntPtr p) : base(p) {}
		public static implicit operator  vtkShaderDeviceAdapter2(IntPtr p) {return new vtkShaderDeviceAdapter2(p);}
		public static implicit operator  IntPtr(vtkShaderDeviceAdapter2 o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkShaderDeviceAdapter2.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkShaderDeviceAdapter2.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkShaderDeviceAdapter2* SafeDownCast(vtkObjectBase * o)
// "static vtkShaderDeviceAdapter2* SafeDownCast(vtkObjectBase *o)"
public static vtkShaderDeviceAdapter2 SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkShaderDeviceAdapter2.SafeDownCast_0(out returnPointer, o);
//	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
}


// vtkShaderDeviceAdapter2* NewInstance()
// "vtkShaderDeviceAdapter2 *NewInstance()"
public vtkShaderDeviceAdapter2 NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkShaderDeviceAdapter2.NewInstance_0(out returnPointer, this);
//	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
}


// virtual void SendAttribute(const char * attrname, int components, int type, const void * attribute, unsigned long offset = 0)
// "virtual void SendAttribute(const char* attrname, int components, int type, const void* attribute, unsigned long offset = 0)"
public void SendAttribute(string /*(char*)*/ attrname, int /*(int)*/ components, int /*(int)*/ type, IntPtr /*(void*)*/ attribute, ulong /*(unsigned long)*/ offset) {
	VTK_API.API_vtkShaderDeviceAdapter2.SendAttribute_0(this, attrname, components, type, attribute, offset);
}


// virtual void PrepareForRender()
// "virtual void PrepareForRender()"
public void PrepareForRender() {
	VTK_API.API_vtkShaderDeviceAdapter2.PrepareForRender_0(this);
}


}
};
