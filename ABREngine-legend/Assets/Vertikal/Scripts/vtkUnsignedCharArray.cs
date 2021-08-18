

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnsignedCharArray : vtkDataArray {
		public vtkUnsignedCharArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnsignedCharArray(IntPtr p) {return new vtkUnsignedCharArray(p);}
		public static implicit operator  IntPtr(vtkUnsignedCharArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnsignedCharArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnsignedCharArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkUnsignedCharArray* SafeDownCast(vtkObjectBase * o)
// "static vtkUnsignedCharArray* SafeDownCast(vtkObjectBase *o)"
public static vtkUnsignedCharArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnsignedCharArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkUnsignedCharArray* NewInstance()
// "vtkUnsignedCharArray *NewInstance()"
public vtkUnsignedCharArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnsignedCharArray.NewInstance_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// static vtkUnsignedCharArray* New()
// "static vtkUnsignedCharArray* New()"
public static vtkUnsignedCharArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnsignedCharArray.New_0(out returnPointer);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray * source)
// "static vtkUnsignedCharArray* FastDownCast(vtkAbstractArray *source)"
public static vtkUnsignedCharArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnsignedCharArray.FastDownCast_0(out returnPointer, source);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// static char GetDataTypeValueMin()
// "static unsigned char GetDataTypeValueMin()"
public static char GetDataTypeValueMin() {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkUnsignedCharArray.GetDataTypeValueMin_0(out returnPointer);
//	return (char)returnPointer;
	return returnPointer;
}


// static char GetDataTypeValueMax()
// "static unsigned char GetDataTypeValueMax()"
public static char GetDataTypeValueMax() {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkUnsignedCharArray.GetDataTypeValueMax_0(out returnPointer);
//	return (char)returnPointer;
	return returnPointer;
}


}
};
