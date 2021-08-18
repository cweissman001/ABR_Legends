

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStructuredPoints : vtkImageData {
		public vtkStructuredPoints(IntPtr p) : base(p) {}
		public static implicit operator  vtkStructuredPoints(IntPtr p) {return new vtkStructuredPoints(p);}
		public static implicit operator  IntPtr(vtkStructuredPoints o) {return o.GetPtr();}

// static vtkStructuredPoints* New()
// "static vtkStructuredPoints *New()"
public static vtkStructuredPoints New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredPoints.New_0(out returnPointer);
//	return (vtkStructuredPoints)(IntPtr)returnPointer;
	return (vtkStructuredPoints)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStructuredPoints.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStructuredPoints.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkStructuredPoints* SafeDownCast(vtkObjectBase * o)
// "static vtkStructuredPoints* SafeDownCast(vtkObjectBase *o)"
public static vtkStructuredPoints SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredPoints.SafeDownCast_0(out returnPointer, o);
//	return (vtkStructuredPoints)(IntPtr)returnPointer;
	return (vtkStructuredPoints)(IntPtr)returnPointer;
}


// vtkStructuredPoints* NewInstance()
// "vtkStructuredPoints *NewInstance()"
public vtkStructuredPoints NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredPoints.NewInstance_0(out returnPointer, this);
//	return (vtkStructuredPoints)(IntPtr)returnPointer;
	return (vtkStructuredPoints)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStructuredPoints.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
