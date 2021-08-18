

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStructuredGrid : vtkPointSet {
		public vtkStructuredGrid(IntPtr p) : base(p) {}
		public static implicit operator  vtkStructuredGrid(IntPtr p) {return new vtkStructuredGrid(p);}
		public static implicit operator  IntPtr(vtkStructuredGrid o) {return o.GetPtr();}

// static vtkStructuredGrid* New()
// "static vtkStructuredGrid *New()"
public static vtkStructuredGrid New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredGrid.New_0(out returnPointer);
//	return (vtkStructuredGrid)(IntPtr)returnPointer;
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStructuredGrid.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStructuredGrid.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkStructuredGrid* SafeDownCast(vtkObjectBase * o)
// "static vtkStructuredGrid* SafeDownCast(vtkObjectBase *o)"
public static vtkStructuredGrid SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredGrid.SafeDownCast_0(out returnPointer, o);
//	return (vtkStructuredGrid)(IntPtr)returnPointer;
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// vtkStructuredGrid* NewInstance()
// "vtkStructuredGrid *NewInstance()"
public vtkStructuredGrid NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredGrid.NewInstance_0(out returnPointer, this);
//	return (vtkStructuredGrid)(IntPtr)returnPointer;
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStructuredGrid.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkStructuredGrid.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStructuredGrid.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public double[] GetPoint(long /*(vtkIdType)*/ ptId) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkStructuredGrid.GetPoint_0(out returnPointer, this, ptId);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetPoint(vtkIdType ptId, double p[3])
// "void GetPoint(vtkIdType ptId, double p[3])"
public void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []p) {
	VTK_API.API_vtkStructuredGrid.GetPoint_1(this, ptId, p);
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredGrid.GetCell_0(out returnPointer, this, cellId);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkCell* GetCell(int i, int j, int k)
// "vtkCell *GetCell(int i, int j, int k)"
public vtkCell GetCell(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStructuredGrid.GetCell_1(out returnPointer, this, i, j, k);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkStructuredGrid.GetCell_2(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkStructuredGrid.GetCellBounds_0(this, cellId, bounds);
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStructuredGrid.GetCellType_0(out returnPointer, this, cellId);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStructuredGrid.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkStructuredGrid.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkStructuredGrid.GetPointCells_0(this, ptId, cellIds);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkStructuredGrid.Initialize_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStructuredGrid.GetMaxCellSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkStructuredGrid.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds, int * seedLoc)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds, int *seedLoc)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds, int /*(int*)*/ []seedLoc) {
	VTK_API.API_vtkStructuredGrid.GetCellNeighbors_1(this, cellId, ptIds, cellIds, seedLoc);
}


// void SetDimensions(int i, int j, int k)
// "void SetDimensions(int i, int j, int k)"
public void SetDimensions(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k) {
	VTK_API.API_vtkStructuredGrid.SetDimensions_0(this, i, j, k);
}


// void SetDimensions(const int dim[3])
// "void SetDimensions(const int dim[3])"
public void SetDimensions(int /*(int[3])*/ []dim) {
	VTK_API.API_vtkStructuredGrid.SetDimensions_1(this, dim);
}


// virtual int* GetDimensions()
// "virtual int *GetDimensions ()"
public int[] GetDimensions() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkStructuredGrid.GetDimensions_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetDimensions(int dim[3])
// "virtual void GetDimensions (int dim[3])"
public void GetDimensions(int /*(int[3])*/ []dim) {
	VTK_API.API_vtkStructuredGrid.GetDimensions_1(this, dim);
}


// int GetDataDimension()
// "int GetDataDimension()"
public int GetDataDimension() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStructuredGrid.GetDataDimension_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetExtent(int extent[6])
// "void SetExtent(int extent[6])"
public void SetExtent(int /*(int[6])*/ []extent) {
	VTK_API.API_vtkStructuredGrid.SetExtent_0(this, extent);
}


// void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
// "void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)"
public void SetExtent(int /*(int)*/ x1, int /*(int)*/ x2, int /*(int)*/ y1, int /*(int)*/ y2, int /*(int)*/ z1, int /*(int)*/ z2) {
	VTK_API.API_vtkStructuredGrid.SetExtent_1(this, x1, x2, y1, y2, z1, z2);
}


// virtual int* GetExtent()
// "virtual int *GetExtent ()"
public int[] GetExtent() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkStructuredGrid.GetExtent_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetExtent(int & _arg1, int & _arg2, int & _arg3, int & _arg4, int & _arg5, int & _arg6)
// "virtual void GetExtent (int &_arg1, int &_arg2, int &_arg3, int &_arg4, int &_arg5, int &_arg6)"
public void GetExtent(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2, IntPtr /*(int&)*/ _arg3, IntPtr /*(int&)*/ _arg4, IntPtr /*(int&)*/ _arg5, IntPtr /*(int&)*/ _arg6) {
	VTK_API.API_vtkStructuredGrid.GetExtent_1(this, _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
}


// virtual void GetExtent(int _arg[6])
// "virtual void GetExtent (int _arg[6])"
public void GetExtent(int /*(int[6])*/ []_arg) {
	VTK_API.API_vtkStructuredGrid.GetExtent_2(this, _arg);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkStructuredGrid.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkStructuredGrid.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkStructuredGrid.DeepCopy_0(this, src);
}


// int GetExtentType()
// "int GetExtentType()"
public int GetExtentType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStructuredGrid.GetExtentType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void BlankPoint(vtkIdType ptId)
// "void BlankPoint(vtkIdType ptId)"
public void BlankPoint(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkStructuredGrid.BlankPoint_0(this, ptId);
}


// void UnBlankPoint(vtkIdType ptId)
// "void UnBlankPoint(vtkIdType ptId)"
public void UnBlankPoint(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkStructuredGrid.UnBlankPoint_0(this, ptId);
}


// void BlankCell(vtkIdType ptId)
// "void BlankCell(vtkIdType ptId)"
public void BlankCell(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkStructuredGrid.BlankCell_0(this, ptId);
}


// void UnBlankCell(vtkIdType ptId)
// "void UnBlankCell(vtkIdType ptId)"
public void UnBlankCell(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkStructuredGrid.UnBlankCell_0(this, ptId);
}


// char IsPointVisible(vtkIdType ptId)
// "unsigned char IsPointVisible(vtkIdType ptId)"
public char IsPointVisible(long /*(vtkIdType)*/ ptId) {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkStructuredGrid.IsPointVisible_0(out returnPointer, this, ptId);
//	return (char)returnPointer;
	return returnPointer;
}


// char IsCellVisible(vtkIdType cellId)
// "unsigned char IsCellVisible(vtkIdType cellId)"
public char IsCellVisible(long /*(vtkIdType)*/ cellId) {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkStructuredGrid.IsCellVisible_0(out returnPointer, this, cellId);
//	return (char)returnPointer;
	return returnPointer;
}


// bool HasAnyBlankPoints()
// "bool HasAnyBlankPoints()"
public bool HasAnyBlankPoints() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStructuredGrid.HasAnyBlankPoints_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// bool HasAnyBlankCells()
// "bool HasAnyBlankCells()"
public bool HasAnyBlankCells() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStructuredGrid.HasAnyBlankCells_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void GetCellDims(int cellDims[3])
// "void GetCellDims( int cellDims[3] )"
public void GetCellDims(int /*(int[3])*/ []cellDims) {
	VTK_API.API_vtkStructuredGrid.GetCellDims_0(this, cellDims);
}


// void Crop(const int * updateExtent)
// "void Crop(const int* updateExtent)"
public void Crop(int /*(int*)*/ []updateExtent) {
	VTK_API.API_vtkStructuredGrid.Crop_0(this, updateExtent);
}


// void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)
// "void GetPoint(int i, int j, int k, double p[3], bool adjustForExtent = true)"
public void GetPoint(int /*(int)*/ i, int /*(int)*/ j, int /*(int)*/ k, double /*(double[3])*/ []p, bool /*(bool)*/ adjustForExtent) {
	VTK_API.API_vtkStructuredGrid.GetPoint_2(this, i, j, k, p, adjustForExtent);
}


}
};
