

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCellArray : vtkObject {
		public vtkCellArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkCellArray(IntPtr p) {return new vtkCellArray(p);}
		public static implicit operator  IntPtr(vtkCellArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCellArray* SafeDownCast(vtkObjectBase * o)
// "static vtkCellArray* SafeDownCast(vtkObjectBase *o)"
public static vtkCellArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// vtkCellArray* NewInstance()
// "vtkCellArray *NewInstance()"
public vtkCellArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellArray.NewInstance_0(out returnPointer, this);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// static vtkCellArray* New()
// "static vtkCellArray *New()"
public static vtkCellArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellArray.New_0(out returnPointer);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext=1000)"
public bool Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCellArray.Allocate_0(out returnPointer, this, sz, ext);
//	return (bool)returnPointer;
	return returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkCellArray.Initialize_0(this);
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells ()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetNumberOfCells(vtkIdType _arg)
// "virtual void SetNumberOfCells (vtkIdType _arg)"
public void SetNumberOfCells(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkCellArray.SetNumberOfCells_0(this, _arg);
}


// vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)
// "vtkIdType EstimateSize(vtkIdType numCells, int maxPtsPerCell)"
public long EstimateSize(long /*(vtkIdType)*/ numCells, int /*(int)*/ maxPtsPerCell) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.EstimateSize_0(out returnPointer, this, numCells, maxPtsPerCell);
//	return (long)returnPointer;
	return returnPointer;
}


// void InitTraversal()
// "void InitTraversal()"
public void InitTraversal() {
	VTK_API.API_vtkCellArray.InitTraversal_0(this);
}


// int GetNextCell(vtkIdType & npts, vtkIdType *& pts)
// "int GetNextCell(vtkIdType& npts, vtkIdType* &pts)"
public int GetNextCell(IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellArray.GetNextCell_0(out returnPointer, this, npts, pts);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNextCell(vtkIdList * pts)
// "int GetNextCell(vtkIdList *pts)"
public int GetNextCell(vtkIdList /*(vtkIdList*)*/ pts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellArray.GetNextCell_1(out returnPointer, this, pts);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public long GetSize() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.GetSize_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfConnectivityEntries()
// "vtkIdType GetNumberOfConnectivityEntries()"
public long GetNumberOfConnectivityEntries() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.GetNumberOfConnectivityEntries_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void GetCell(vtkIdType loc, vtkIdType & npts, vtkIdType *& pts)
// "void GetCell(vtkIdType loc, vtkIdType &npts, vtkIdType* &pts)"
public void GetCell(long /*(vtkIdType)*/ loc, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
	VTK_API.API_vtkCellArray.GetCell_0(this, loc, npts, pts);
}


// void GetCell(vtkIdType loc, vtkIdList * pts)
// "void GetCell(vtkIdType loc, vtkIdList* pts)"
public void GetCell(long /*(vtkIdType)*/ loc, vtkIdList /*(vtkIdList*)*/ pts) {
	VTK_API.API_vtkCellArray.GetCell_1(this, loc, pts);
}


// void InsertCellPoint(vtkIdType id)
// "void InsertCellPoint(vtkIdType id)"
public void InsertCellPoint(long /*(vtkIdType)*/ id) {
	VTK_API.API_vtkCellArray.InsertCellPoint_0(this, id);
}


// void UpdateCellCount(int npts)
// "void UpdateCellCount(int npts)"
public void UpdateCellCount(int /*(int)*/ npts) {
	VTK_API.API_vtkCellArray.UpdateCellCount_0(this, npts);
}


// vtkIdType GetInsertLocation(int npts)
// "vtkIdType GetInsertLocation(int npts)"
public long GetInsertLocation(int /*(int)*/ npts) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.GetInsertLocation_0(out returnPointer, this, npts);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetTraversalLocation()
// "vtkIdType GetTraversalLocation()"
public long GetTraversalLocation() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.GetTraversalLocation_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetTraversalLocation(vtkIdType loc)
// "void SetTraversalLocation(vtkIdType loc)"
public void SetTraversalLocation(long /*(vtkIdType)*/ loc) {
	VTK_API.API_vtkCellArray.SetTraversalLocation_0(this, loc);
}


// vtkIdType GetTraversalLocation(vtkIdType npts)
// "vtkIdType GetTraversalLocation(vtkIdType npts)"
public long GetTraversalLocation(long /*(vtkIdType)*/ npts) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCellArray.GetTraversalLocation_1(out returnPointer, this, npts);
//	return (long)returnPointer;
	return returnPointer;
}


// void ReverseCell(vtkIdType loc)
// "void ReverseCell(vtkIdType loc)"
public void ReverseCell(long /*(vtkIdType)*/ loc) {
	VTK_API.API_vtkCellArray.ReverseCell_0(this, loc);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCellArray.GetMaxCellSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType* GetPointer()
// "vtkIdType *GetPointer()"
public long[] GetPointer() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkCellArray.GetPointer_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType* WritePointer(const vtkIdType ncells, const vtkIdType size)
// "vtkIdType *WritePointer(const vtkIdType ncells, const vtkIdType size)"
public long[] WritePointer(long /*(vtkIdType)*/ ncells, long /*(vtkIdType)*/ size) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkCellArray.WritePointer_0(out returnPointer, this, ncells, size);
//	return (long)returnPointer;
	return returnPointer;
}


// void DeepCopy(vtkCellArray * ca)
// "void DeepCopy(vtkCellArray *ca)"
public void DeepCopy(vtkCellArray /*(vtkCellArray*)*/ ca) {
	VTK_API.API_vtkCellArray.DeepCopy_0(this, ca);
}


// vtkIdTypeArray* GetData()
// "vtkIdTypeArray* GetData()"
public vtkIdTypeArray GetData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCellArray.GetData_0(out returnPointer, this);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkCellArray.Reset_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkCellArray.Squeeze_0(this);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkCellArray.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


}
};
