

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGridBase : vtkPointSet {
		public vtkUnstructuredGridBase(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnstructuredGridBase(IntPtr p) {return new vtkUnstructuredGridBase(p);}
		public static implicit operator  IntPtr(vtkUnstructuredGridBase o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnstructuredGridBase.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnstructuredGridBase.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase * o)
// "static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase *o)"
public static vtkUnstructuredGridBase SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridBase.SafeDownCast_0(out returnPointer, o);
//	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
}


// vtkUnstructuredGridBase* NewInstance()
// "vtkUnstructuredGridBase *NewInstance()"
public vtkUnstructuredGridBase NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridBase.NewInstance_0(out returnPointer, this);
//	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
	return (vtkUnstructuredGridBase)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGridBase.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	VTK_API.API_vtkUnstructuredGridBase.Allocate_0(this, numCells, extSize);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkUnstructuredGridBase.DeepCopy_0(this, src);
}


// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// "virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)"
public void GetIdsOfCellsOfType(int /*(int)*/ type, vtkIdTypeArray /*(vtkIdTypeArray*)*/ array) {
	VTK_API.API_vtkUnstructuredGridBase.GetIdsOfCellsOfType_0(this, type, array);
}


// virtual int IsHomogeneous()
// "virtual int IsHomogeneous()"
public int IsHomogeneous() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGridBase.IsHomogeneous_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
