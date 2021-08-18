

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractCellLinks : vtkObject {
		public vtkAbstractCellLinks(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractCellLinks(IntPtr p) {return new vtkAbstractCellLinks(p);}
		public static implicit operator  IntPtr(vtkAbstractCellLinks o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractCellLinks.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractCellLinks.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractCellLinks* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractCellLinks* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractCellLinks SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractCellLinks.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractCellLinks)(IntPtr)returnPointer;
	return (vtkAbstractCellLinks)(IntPtr)returnPointer;
}


// vtkAbstractCellLinks* NewInstance()
// "vtkAbstractCellLinks *NewInstance()"
public vtkAbstractCellLinks NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractCellLinks.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractCellLinks)(IntPtr)returnPointer;
	return (vtkAbstractCellLinks)(IntPtr)returnPointer;
}


// virtual void BuildLinks(vtkDataSet * data)
// "virtual void BuildLinks(vtkDataSet *data)"
public void BuildLinks(vtkDataSet /*(vtkDataSet*)*/ data) {
	VTK_API.API_vtkAbstractCellLinks.BuildLinks_0(this, data);
}


// static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray * ca)
// "static int GetIdType(vtkIdType maxPtId, vtkIdType maxCellId, vtkCellArray *ca)"
public static int GetIdType(long /*(vtkIdType)*/ maxPtId, long /*(vtkIdType)*/ maxCellId, vtkCellArray /*(vtkCellArray*)*/ ca) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractCellLinks.GetIdType_0(out returnPointer, maxPtId, maxCellId, ca);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
