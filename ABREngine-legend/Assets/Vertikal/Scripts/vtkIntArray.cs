

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIntArray : vtkDataArray {
		public vtkIntArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkIntArray(IntPtr p) {return new vtkIntArray(p);}
		public static implicit operator  IntPtr(vtkIntArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIntArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIntArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkIntArray* SafeDownCast(vtkObjectBase * o)
// "static vtkIntArray* SafeDownCast(vtkObjectBase *o)"
public static vtkIntArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIntArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkIntArray)(IntPtr)returnPointer;
	return (vtkIntArray)(IntPtr)returnPointer;
}


// vtkIntArray* NewInstance()
// "vtkIntArray *NewInstance()"
public vtkIntArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIntArray.NewInstance_0(out returnPointer, this);
//	return (vtkIntArray)(IntPtr)returnPointer;
	return (vtkIntArray)(IntPtr)returnPointer;
}


// static vtkIntArray* New()
// "static vtkIntArray* New()"
public static vtkIntArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIntArray.New_0(out returnPointer);
//	return (vtkIntArray)(IntPtr)returnPointer;
	return (vtkIntArray)(IntPtr)returnPointer;
}


// static vtkIntArray* FastDownCast(vtkAbstractArray * source)
// "static vtkIntArray* FastDownCast(vtkAbstractArray *source)"
public static vtkIntArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIntArray.FastDownCast_0(out returnPointer, source);
//	return (vtkIntArray)(IntPtr)returnPointer;
	return (vtkIntArray)(IntPtr)returnPointer;
}


// static int GetDataTypeValueMin()
// "static int GetDataTypeValueMin()"
public static int GetDataTypeValueMin() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIntArray.GetDataTypeValueMin_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// static int GetDataTypeValueMax()
// "static int GetDataTypeValueMax()"
public static int GetDataTypeValueMax() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIntArray.GetDataTypeValueMax_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
