

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataSet : vtkDataObject {
		public vtkDataSet(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataSet(IntPtr p) {return new vtkDataSet(p);}
		public static implicit operator  IntPtr(vtkDataSet o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSet.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSet.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDataSet* SafeDownCast(vtkObjectBase * o)
// "static vtkDataSet* SafeDownCast(vtkObjectBase *o)"
public static vtkDataSet SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.SafeDownCast_0(out returnPointer, o);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// vtkDataSet* NewInstance()
// "vtkDataSet *NewInstance()"
public vtkDataSet NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.NewInstance_0(out returnPointer, this);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// virtual void CopyStructure(vtkDataSet * ds)
// "virtual void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkDataSet.CopyStructure_0(this, ds);
}


// virtual void CopyAttributes(vtkDataSet * ds)
// "virtual void CopyAttributes(vtkDataSet *ds)"
public void CopyAttributes(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkDataSet.CopyAttributes_0(this, ds);
}


// virtual vtkIdType GetNumberOfPoints()
// "virtual vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual double* GetPoint(vtkIdType ptId)
// "virtual double *GetPoint(vtkIdType ptId)"
protected double[] GetPoint_0(long /*(vtkIdType)*/ ptId) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkDataSet.GetPoint_0(out returnPointer, this, ptId);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetPoint(vtkIdType id, double x[3])
// "virtual void GetPoint(vtkIdType id, double x[3])"
protected void GetPoint_1(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	VTK_API.API_vtkDataSet.GetPoint_1(this, id, x);
}


// virtual vtkCellIterator* NewCellIterator()
// "virtual vtkCellIterator* NewCellIterator()"
public vtkCellIterator NewCellIterator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.NewCellIterator_0(out returnPointer, this);
//	return (vtkCellIterator)(IntPtr)returnPointer;
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// virtual vtkCell* GetCell(vtkIdType cellId)
// "virtual vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetCell_0(out returnPointer, this, cellId);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// virtual vtkCell* GetCell(int ARG_0, int ARG_1, int ARG_2)
// "virtual vtkCell *GetCell(int , int , int )"
public vtkCell GetCell(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetCell_1(out returnPointer, this, ARG_0, ARG_1, ARG_2);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// virtual void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "virtual void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkDataSet.GetCell_2(this, cellId, cell);
}


// virtual void GetCellBounds(vtkIdType cellId, double bounds[6])
// "virtual void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkDataSet.GetCellBounds_0(this, cellId, bounds);
}


// virtual int GetCellType(vtkIdType cellId)
// "virtual int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataSet.GetCellType_0(out returnPointer, this, cellId);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetCellTypes(vtkCellTypes * types)
// "virtual void GetCellTypes(vtkCellTypes *types)"
public void GetCellTypes(vtkCellTypes /*(vtkCellTypes*)*/ types) {
	VTK_API.API_vtkDataSet.GetCellTypes_0(this, types);
}


// virtual void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "virtual void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkDataSet.GetCellPoints_0(this, cellId, ptIds);
}


// virtual void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "virtual void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkDataSet.GetPointCells_0(this, ptId, cellIds);
}


// virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "virtual void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkDataSet.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// vtkIdType FindPoint(double x, double y, double z)
// "vtkIdType FindPoint(double x, double y, double z)"
public long FindPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.FindPoint_0(out returnPointer, this, x, y, z);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType FindPoint(double x[3])
// "virtual vtkIdType FindPoint(double x[3])"
public long FindPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.FindPoint_1(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.FindCell_0(out returnPointer, this, x, cell, cellId, tol2, subId, pcoords, weights);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType FindCell(double x[3], vtkCell * cell, vtkGenericCell * gencell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkIdType FindCell(double x[3], vtkCell *cell, vtkGenericCell *gencell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public long FindCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, vtkGenericCell /*(vtkGenericCell*)*/ gencell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.FindCell_1(out returnPointer, this, x, cell, gencell, cellId, tol2, subId, pcoords, weights);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkCell* FindAndGetCell(double x[3], vtkCell * cell, vtkIdType cellId, double tol2, int & subId, double pcoords[3], double * weights)
// "virtual vtkCell *FindAndGetCell(double x[3], vtkCell *cell, vtkIdType cellId, double tol2, int& subId, double pcoords[3], double *weights)"
public vtkCell FindAndGetCell(double /*(double[3])*/ []x, vtkCell /*(vtkCell*)*/ cell, long /*(vtkIdType)*/ cellId, double /*(double)*/ tol2, IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []weights) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.FindAndGetCell_0(out returnPointer, this, x, cell, cellId, tol2, subId, pcoords, weights);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataSet.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkCellData* GetCellData()
// "vtkCellData *GetCellData()"
public vtkCellData GetCellData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetCellData_0(out returnPointer, this);
//	return (vtkCellData)(IntPtr)returnPointer;
	return (vtkCellData)(IntPtr)returnPointer;
}


// vtkPointData* GetPointData()
// "vtkPointData *GetPointData()"
public vtkPointData GetPointData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetPointData_0(out returnPointer, this);
//	return (vtkPointData)(IntPtr)returnPointer;
	return (vtkPointData)(IntPtr)returnPointer;
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkDataSet.Squeeze_0(this);
}


// virtual void ComputeBounds()
// "virtual void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkDataSet.ComputeBounds_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
protected double[] GetBounds_0() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[6];
	VTK_API.API_vtkDataSet.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkDataSet.GetBounds_1(this, bounds);
}


// double* GetCenter()
// "double *GetCenter()"
public double[] GetCenter() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkDataSet.GetCenter_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetCenter(double center[3])
// "void GetCenter(double center[3])"
public void GetCenter(double /*(double[3])*/ []center) {
	VTK_API.API_vtkDataSet.GetCenter_1(this, center);
}


// double GetLength()
// "double GetLength()"
public double GetLength() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkDataSet.GetLength_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkDataSet.Initialize_0(this);
}


// virtual void GetScalarRange(double range[2])
// "virtual void GetScalarRange(double range[2])"
public void GetScalarRange(double /*(double[2])*/ []range) {
	VTK_API.API_vtkDataSet.GetScalarRange_0(this, range);
}


// double* GetScalarRange()
// "double *GetScalarRange()"
public double[] GetScalarRange() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkDataSet.GetScalarRange_1(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int GetMaxCellSize()
// "virtual int GetMaxCellSize()"
public int GetMaxCellSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataSet.GetMaxCellSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataSet.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataSet.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataSet.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataSet.DeepCopy_0(this, src);
}


// int CheckAttributes()
// "int CheckAttributes()"
public int CheckAttributes() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataSet.CheckAttributes_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GenerateGhostArray(int zeroExt[6])
// "virtual void GenerateGhostArray(int zeroExt[6])"
public void GenerateGhostArray(int /*(int[6])*/ []zeroExt) {
	VTK_API.API_vtkDataSet.GenerateGhostArray_0(this, zeroExt);
}


// virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)
// "virtual void GenerateGhostArray(int zeroExt[6], bool cellOnly)"
public void GenerateGhostArray(int /*(int[6])*/ []zeroExt, bool /*(bool)*/ cellOnly) {
	VTK_API.API_vtkDataSet.GenerateGhostArray_1(this, zeroExt, cellOnly);
}


// vtkFieldData* GetAttributesAsFieldData(int type)
// "vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetAttributesAsFieldData_0(out returnPointer, this, type);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfElements(int type)
// "vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataSet.GetNumberOfElements_0(out returnPointer, this, type);
//	return (long)returnPointer;
	return returnPointer;
}


// bool HasAnyGhostCells()
// "bool HasAnyGhostCells()"
public bool HasAnyGhostCells() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSet.HasAnyGhostCells_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// bool HasAnyGhostPoints()
// "bool HasAnyGhostPoints()"
public bool HasAnyGhostPoints() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSet.HasAnyGhostPoints_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual bool HasAnyBlankCells()
// "virtual bool HasAnyBlankCells()"
public bool HasAnyBlankCells() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSet.HasAnyBlankCells_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual bool HasAnyBlankPoints()
// "virtual bool HasAnyBlankPoints()"
public bool HasAnyBlankPoints() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataSet.HasAnyBlankPoints_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkUnsignedCharArray* GetPointGhostArray()
// "vtkUnsignedCharArray* GetPointGhostArray()"
public vtkUnsignedCharArray GetPointGhostArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetPointGhostArray_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// void UpdatePointGhostArrayCache()
// "void UpdatePointGhostArrayCache()"
public void UpdatePointGhostArrayCache() {
	VTK_API.API_vtkDataSet.UpdatePointGhostArrayCache_0(this);
}


// vtkUnsignedCharArray* AllocatePointGhostArray()
// "vtkUnsignedCharArray* AllocatePointGhostArray()"
public vtkUnsignedCharArray AllocatePointGhostArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.AllocatePointGhostArray_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkUnsignedCharArray* GetCellGhostArray()
// "vtkUnsignedCharArray* GetCellGhostArray()"
public vtkUnsignedCharArray GetCellGhostArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.GetCellGhostArray_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// void UpdateCellGhostArrayCache()
// "void UpdateCellGhostArrayCache()"
public void UpdateCellGhostArrayCache() {
	VTK_API.API_vtkDataSet.UpdateCellGhostArrayCache_0(this);
}


// vtkUnsignedCharArray* AllocateCellGhostArray()
// "vtkUnsignedCharArray* AllocateCellGhostArray()"
public vtkUnsignedCharArray AllocateCellGhostArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataSet.AllocateCellGhostArray_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


}
};
