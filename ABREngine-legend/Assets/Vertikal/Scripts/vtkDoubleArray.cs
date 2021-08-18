

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDoubleArray : vtkDataArray {
		public vtkDoubleArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkDoubleArray(IntPtr p) {return new vtkDoubleArray(p);}
		public static implicit operator  IntPtr(vtkDoubleArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDoubleArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDoubleArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDoubleArray* SafeDownCast(vtkObjectBase * o)
// "static vtkDoubleArray* SafeDownCast(vtkObjectBase *o)"
public static vtkDoubleArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDoubleArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkDoubleArray)(IntPtr)returnPointer;
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// vtkDoubleArray* NewInstance()
// "vtkDoubleArray *NewInstance()"
public vtkDoubleArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDoubleArray.NewInstance_0(out returnPointer, this);
//	return (vtkDoubleArray)(IntPtr)returnPointer;
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static vtkDoubleArray* New()
// "static vtkDoubleArray* New()"
public static vtkDoubleArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDoubleArray.New_0(out returnPointer);
//	return (vtkDoubleArray)(IntPtr)returnPointer;
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static vtkDoubleArray* FastDownCast(vtkAbstractArray * source)
// "static vtkDoubleArray* FastDownCast(vtkAbstractArray *source)"
public static vtkDoubleArray FastDownCast(vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDoubleArray.FastDownCast_0(out returnPointer, source);
//	return (vtkDoubleArray)(IntPtr)returnPointer;
	return (vtkDoubleArray)(IntPtr)returnPointer;
}


// static double GetDataTypeValueMin()
// "static double GetDataTypeValueMin()"
public static double GetDataTypeValueMin() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkDoubleArray.GetDataTypeValueMin_0(out returnPointer);
//	return (double)returnPointer;
	return returnPointer;
}


// static double GetDataTypeValueMax()
// "static double GetDataTypeValueMax()"
public static double GetDataTypeValueMax() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkDoubleArray.GetDataTypeValueMax_0(out returnPointer);
//	return (double)returnPointer;
	return returnPointer;
}


}
};
