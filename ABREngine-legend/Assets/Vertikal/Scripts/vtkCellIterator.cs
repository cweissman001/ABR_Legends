

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellIterator : vtkObject {
		public vtkCellIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellIterator(IntPtr p) {return new vtkCellIterator(p);}
		public static implicit operator  IntPtr(vtkCellIterator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCellIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkCellIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkCellIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkCellIterator)(IntPtr)returnPointer;
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// vtkCellIterator* NewInstance()
// "vtkCellIterator *NewInstance()"
public vtkCellIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellIterator.NewInstance_0(out returnPointer, this);
//	return (vtkCellIterator)(IntPtr)returnPointer;
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCellIterator.InitTraversal_0(this);
}


// void GoToNextCell()
// "void GoToNextCell()"
public void GoToNextCell() {
	VTK_API.API_vtkCellIterator.GoToNextCell_0(this);
}


// virtual bool IsDoneWithTraversal()
// "virtual bool IsDoneWithTraversal()"
public bool IsDoneWithTraversal() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellIterator.IsDoneWithTraversal_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// int GetCellType()
// "int GetCellType()"
public int GetCellType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellIterator.GetCellType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetCellDimension()
// "int GetCellDimension()"
public int GetCellDimension() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellIterator.GetCellDimension_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetCellId()
// "virtual vtkIdType GetCellId()"
public long GetCellId() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellIterator.GetCellId_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdList* GetPointIds()
// "vtkIdList *GetPointIds()"
public vtkIdList GetPointIds() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellIterator.GetPointIds_0(out returnPointer, this);
//	return (vtkIdList)(IntPtr)returnPointer;
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkPoints* GetPoints()
// "vtkPoints *GetPoints()"
public vtkPoints GetPoints() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellIterator.GetPoints_0(out returnPointer, this);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// vtkIdList* GetFaces()
// "vtkIdList *GetFaces()"
public vtkIdList GetFaces() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellIterator.GetFaces_0(out returnPointer, this);
//	return (vtkIdList)(IntPtr)returnPointer;
	return (vtkIdList)(IntPtr)returnPointer;
}


// void GetCell(vtkGenericCell * cell)
// "void GetCell(vtkGenericCell *cell)"
public void GetCell(vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkCellIterator.GetCell_0(this, cell);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellIterator.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfFaces()
// "vtkIdType GetNumberOfFaces()"
public long GetNumberOfFaces() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellIterator.GetNumberOfFaces_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
