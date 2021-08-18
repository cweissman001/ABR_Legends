

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellData : vtkDataSetAttributes {
		public vtkCellData(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellData(IntPtr p) {return new vtkCellData(p);}
		public static implicit operator  IntPtr(vtkCellData o) {return o.GetPtr();}

// static vtkCellData* New()
// "static vtkCellData *New()"
public static vtkCellData New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellData.New_0(out returnPointer);
//	return (vtkCellData)(IntPtr)returnPointer;
	return (vtkCellData)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellData.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellData.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCellData* SafeDownCast(vtkObjectBase * o)
// "static vtkCellData* SafeDownCast(vtkObjectBase *o)"
public static vtkCellData SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellData.SafeDownCast_0(out returnPointer, o);
//	return (vtkCellData)(IntPtr)returnPointer;
	return (vtkCellData)(IntPtr)returnPointer;
}


// vtkCellData* NewInstance()
// "vtkCellData *NewInstance()"
public vtkCellData NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellData.NewInstance_0(out returnPointer, this);
//	return (vtkCellData)(IntPtr)returnPointer;
	return (vtkCellData)(IntPtr)returnPointer;
}


}
};
