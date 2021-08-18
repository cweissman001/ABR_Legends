

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGraphInternals : vtkObject {
		public vtkGraphInternals(IntPtr p) : base(p) {}
		public static implicit operator  vtkGraphInternals(IntPtr p) {return new vtkGraphInternals(p);}
		public static implicit operator  IntPtr(vtkGraphInternals o) {return o.GetPtr();}

// static vtkGraphInternals* New()
// "static vtkGraphInternals *New()"
public static vtkGraphInternals New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraphInternals.New_0(out returnPointer);
//	return (vtkGraphInternals)(IntPtr)returnPointer;
	return (vtkGraphInternals)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraphInternals.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraphInternals.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkGraphInternals* SafeDownCast(vtkObjectBase * o)
// "static vtkGraphInternals* SafeDownCast(vtkObjectBase *o)"
public static vtkGraphInternals SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraphInternals.SafeDownCast_0(out returnPointer, o);
//	return (vtkGraphInternals)(IntPtr)returnPointer;
	return (vtkGraphInternals)(IntPtr)returnPointer;
}


// vtkGraphInternals* NewInstance()
// "vtkGraphInternals *NewInstance()"
public vtkGraphInternals NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraphInternals.NewInstance_0(out returnPointer, this);
//	return (vtkGraphInternals)(IntPtr)returnPointer;
	return (vtkGraphInternals)(IntPtr)returnPointer;
}


}
};
