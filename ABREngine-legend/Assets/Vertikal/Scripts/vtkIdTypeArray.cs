

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkIdTypeArray : vtkDataArray {
		public vtkIdTypeArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkIdTypeArray(IntPtr p) {return new vtkIdTypeArray(p);}
		public static implicit operator  IntPtr(vtkIdTypeArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIdTypeArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkIdTypeArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkIdTypeArray* SafeDownCast(vtkObjectBase * o)
// "static vtkIdTypeArray* SafeDownCast(vtkObjectBase *o)"
public static vtkIdTypeArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdTypeArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// vtkIdTypeArray* NewInstance()
// "vtkIdTypeArray *NewInstance()"
public vtkIdTypeArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdTypeArray.NewInstance_0(out returnPointer, this);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// static vtkIdTypeArray* New()
// "static vtkIdTypeArray* New()"
public static vtkIdTypeArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdTypeArray.New_0(out returnPointer);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// int GetDataType()
// "int GetDataType()"
public int GetDataType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkIdTypeArray.GetDataType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// static vtkIdTypeArray* FastDownCast(vtkAbstractArray * source)
// "static vtkIdTypeArray* FastDownCast(vtkAbstractArray *source)"
public static vtkIdTypeArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkIdTypeArray.FastDownCast_0(out returnPointer, source);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// static vtkIdType GetDataTypeValueMin()
// "static vtkIdType GetDataTypeValueMin()"
public static long GetDataTypeValueMin() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdTypeArray.GetDataTypeValueMin_0(out returnPointer);
//	return (long)returnPointer;
	return returnPointer;
}


// static vtkIdType GetDataTypeValueMax()
// "static vtkIdType GetDataTypeValueMax()"
public static long GetDataTypeValueMax() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkIdTypeArray.GetDataTypeValueMax_0(out returnPointer);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
