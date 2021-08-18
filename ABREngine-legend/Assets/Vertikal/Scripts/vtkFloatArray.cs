

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFloatArray : vtkDataArray {
		public vtkFloatArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkFloatArray(IntPtr p) {return new vtkFloatArray(p);}
		public static implicit operator  IntPtr(vtkFloatArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFloatArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFloatArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkFloatArray* SafeDownCast(vtkObjectBase * o)
// "static vtkFloatArray* SafeDownCast(vtkObjectBase *o)"
public static vtkFloatArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFloatArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkFloatArray)(IntPtr)returnPointer;
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// vtkFloatArray* NewInstance()
// "vtkFloatArray *NewInstance()"
public vtkFloatArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFloatArray.NewInstance_0(out returnPointer, this);
//	return (vtkFloatArray)(IntPtr)returnPointer;
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// static vtkFloatArray* New()
// "static vtkFloatArray* New()"
public static vtkFloatArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFloatArray.New_0(out returnPointer);
//	return (vtkFloatArray)(IntPtr)returnPointer;
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// static vtkFloatArray* FastDownCast(vtkAbstractArray * source)
// "static vtkFloatArray* FastDownCast(vtkAbstractArray *source)"
public static vtkFloatArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFloatArray.FastDownCast_0(out returnPointer, source);
//	return (vtkFloatArray)(IntPtr)returnPointer;
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// static float GetDataTypeValueMin()
// "static float GetDataTypeValueMin()"
public static float GetDataTypeValueMin() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFloatArray.GetDataTypeValueMin_0(out returnPointer);
//	return (float)returnPointer;
	return returnPointer;
}


// static float GetDataTypeValueMax()
// "static float GetDataTypeValueMax()"
public static float GetDataTypeValueMax() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkFloatArray.GetDataTypeValueMax_0(out returnPointer);
//	return (float)returnPointer;
	return returnPointer;
}


}
};
