

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCharArray : vtkDataArray {
		public vtkCharArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkCharArray(IntPtr p) {return new vtkCharArray(p);}
		public static implicit operator  IntPtr(vtkCharArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCharArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCharArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCharArray* SafeDownCast(vtkObjectBase * o)
// "static vtkCharArray* SafeDownCast(vtkObjectBase *o)"
public static vtkCharArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCharArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkCharArray)(IntPtr)returnPointer;
	return (vtkCharArray)(IntPtr)returnPointer;
}


// vtkCharArray* NewInstance()
// "vtkCharArray *NewInstance()"
public vtkCharArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCharArray.NewInstance_0(out returnPointer, this);
//	return (vtkCharArray)(IntPtr)returnPointer;
	return (vtkCharArray)(IntPtr)returnPointer;
}


// static vtkCharArray* New()
// "static vtkCharArray* New()"
public static vtkCharArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCharArray.New_0(out returnPointer);
//	return (vtkCharArray)(IntPtr)returnPointer;
	return (vtkCharArray)(IntPtr)returnPointer;
}


// static vtkCharArray* FastDownCast(vtkAbstractArray * source)
// "static vtkCharArray* FastDownCast(vtkAbstractArray *source)"
public static vtkCharArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCharArray.FastDownCast_0(out returnPointer, source);
//	return (vtkCharArray)(IntPtr)returnPointer;
	return (vtkCharArray)(IntPtr)returnPointer;
}


// static char GetDataTypeValueMin()
// "static char GetDataTypeValueMin()"
public static char GetDataTypeValueMin() {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkCharArray.GetDataTypeValueMin_0(out returnPointer);
//	return (char)returnPointer;
	return returnPointer;
}


// static char GetDataTypeValueMax()
// "static char GetDataTypeValueMax()"
public static char GetDataTypeValueMax() {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkCharArray.GetDataTypeValueMax_0(out returnPointer);
//	return (char)returnPointer;
	return returnPointer;
}


}
};
