

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPolyData : vtkPointSet {
		public vtkPolyData(IntPtr p) : base(p) {}
		public static implicit operator  vtkPolyData(IntPtr p) {return new vtkPolyData(p);}
		public static implicit operator  IntPtr(vtkPolyData o) {return o.GetPtr();}

// static vtkPolyData* New()
// "static vtkPolyData *New()"
public static vtkPolyData New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.New_0(out returnPointer);
//	return (vtkPolyData)(IntPtr)returnPointer;
	return (vtkPolyData)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyData.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyData.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPolyData* SafeDownCast(vtkObjectBase * o)
// "static vtkPolyData* SafeDownCast(vtkObjectBase *o)"
public static vtkPolyData SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.SafeDownCast_0(out returnPointer, o);
//	return (vtkPolyData)(IntPtr)returnPointer;
	return (vtkPolyData)(IntPtr)returnPointer;
}


// vtkPolyData* NewInstance()
// "vtkPolyData *NewInstance()"
public vtkPolyData NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.NewInstance_0(out returnPointer, this);
//	return (vtkPolyData)(IntPtr)returnPointer;
	return (vtkPolyData)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkPolyData.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.GetCell_0(out returnPointer, this, cellId);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkPolyData.GetCell_1(this, cellId, cell);
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetCellType_0(out returnPointer, this, cellId);
//	return (int)returnPointer;
	return returnPointer;
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkPolyData.GetCellBounds_0(this, cellId, bounds);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkPolyData.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkPolyData.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkPolyData.GetPointCells_0(this, ptId, cellIds);
}


// void ComputeBounds()
// "void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkPolyData.ComputeBounds_0(this);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkPolyData.Squeeze_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetMaxCellSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetVerts(vtkCellArray * v)
// "void SetVerts (vtkCellArray* v)"
public void SetVerts(vtkCellArray /*(vtkCellArray*)*/ v) {
	VTK_API.API_vtkPolyData.SetVerts_0(this, v);
}


// vtkCellArray* GetVerts()
// "vtkCellArray *GetVerts()"
public vtkCellArray GetVerts() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.GetVerts_0(out returnPointer, this);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// void SetLines(vtkCellArray * l)
// "void SetLines (vtkCellArray* l)"
public void SetLines(vtkCellArray /*(vtkCellArray*)*/ l) {
	VTK_API.API_vtkPolyData.SetLines_0(this, l);
}


// vtkCellArray* GetLines()
// "vtkCellArray *GetLines()"
public vtkCellArray GetLines() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.GetLines_0(out returnPointer, this);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// void SetPolys(vtkCellArray * p)
// "void SetPolys (vtkCellArray* p)"
public void SetPolys(vtkCellArray /*(vtkCellArray*)*/ p) {
	VTK_API.API_vtkPolyData.SetPolys_0(this, p);
}


// vtkCellArray* GetPolys()
// "vtkCellArray *GetPolys()"
public vtkCellArray GetPolys() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.GetPolys_0(out returnPointer, this);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// void SetStrips(vtkCellArray * s)
// "void SetStrips (vtkCellArray* s)"
public void SetStrips(vtkCellArray /*(vtkCellArray*)*/ s) {
	VTK_API.API_vtkPolyData.SetStrips_0(this, s);
}


// vtkCellArray* GetStrips()
// "vtkCellArray *GetStrips()"
public vtkCellArray GetStrips() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyData.GetStrips_0(out returnPointer, this);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfVerts()
// "vtkIdType GetNumberOfVerts()"
public long GetNumberOfVerts() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.GetNumberOfVerts_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfLines()
// "vtkIdType GetNumberOfLines()"
public long GetNumberOfLines() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.GetNumberOfLines_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfPolys()
// "vtkIdType GetNumberOfPolys()"
public long GetNumberOfPolys() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.GetNumberOfPolys_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfStrips()
// "vtkIdType GetNumberOfStrips()"
public long GetNumberOfStrips() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.GetNumberOfStrips_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	VTK_API.API_vtkPolyData.Allocate_0(this, numCells, extSize);
}


// void Allocate(vtkPolyData * inPolyData, vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkPolyData *inPolyData, vtkIdType numCells=1000, int extSize=1000)"
public void Allocate(vtkPolyData /*(vtkPolyData*)*/ inPolyData, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	VTK_API.API_vtkPolyData.Allocate_1(this, inPolyData, numCells, extSize);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkPolyData.Reset_0(this);
}


// void BuildCells()
// "void BuildCells()"
public void BuildCells() {
	VTK_API.API_vtkPolyData.BuildCells_0(this);
}


// bool NeedToBuildCells()
// "bool NeedToBuildCells()"
public bool NeedToBuildCells() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyData.NeedToBuildCells_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void BuildLinks(int initialSize = 0)
// "void BuildLinks(int initialSize=0)"
public void BuildLinks(int /*(int)*/ initialSize) {
	VTK_API.API_vtkPolyData.BuildLinks_0(this, initialSize);
}


// void DeleteCells()
// "void DeleteCells()"
public void DeleteCells() {
	VTK_API.API_vtkPolyData.DeleteCells_0(this);
}


// void DeleteLinks()
// "void DeleteLinks()"
public void DeleteLinks() {
	VTK_API.API_vtkPolyData.DeleteLinks_0(this);
}


// void GetPointCells(vtkIdType ptId, unsigned short & ncells, vtkIdType *& cells)
// "void GetPointCells(vtkIdType ptId, unsigned short& ncells, vtkIdType* &cells)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, IntPtr /*(unsigned short&)*/ ncells, IntPtr /*(vtkIdType*&)*/ cells) {
	VTK_API.API_vtkPolyData.GetPointCells_1(this, ptId, ncells, cells);
}


// void GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList * cellIds)
// "void GetCellEdgeNeighbors(vtkIdType cellId, vtkIdType p1, vtkIdType p2, vtkIdList *cellIds)"
public void GetCellEdgeNeighbors(long /*(vtkIdType)*/ cellId, long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkPolyData.GetCellEdgeNeighbors_0(this, cellId, p1, p2, cellIds);
}


// char GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// "unsigned char GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)"
public char GetCellPoints(long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkPolyData.GetCellPoints_1(out returnPointer, this, cellId, npts, pts);
//	return (char)returnPointer;
	return returnPointer;
}


// char GetCell(vtkIdType cellId, vtkIdType *& pts)
// "unsigned char GetCell(vtkIdType cellId, vtkIdType* &pts)"
public char GetCell(long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType*&)*/ pts) {
//	char
//	ReturnPointer returnPointer = new ReturnPointer(new char());
	char returnPointer = new char();
	VTK_API.API_vtkPolyData.GetCell_2(out returnPointer, this, cellId, pts);
//	return (char)returnPointer;
	return returnPointer;
}


// int IsTriangle(int v1, int v2, int v3)
// "int IsTriangle(int v1, int v2, int v3)"
public int IsTriangle(int /*(int)*/ v1, int /*(int)*/ v2, int /*(int)*/ v3) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.IsTriangle_0(out returnPointer, this, v1, v2, v3);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsEdge(vtkIdType p1, vtkIdType p2)
// "int IsEdge(vtkIdType p1, vtkIdType p2)"
public int IsEdge(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.IsEdge_0(out returnPointer, this, p1, p2);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)
// "int IsPointUsedByCell(vtkIdType ptId, vtkIdType cellId)"
public int IsPointUsedByCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.IsPointUsedByCell_0(out returnPointer, this, ptId, cellId);
//	return (int)returnPointer;
	return returnPointer;
}


// void ReverseCell(vtkIdType cellId)
// "void ReverseCell(vtkIdType cellId)"
public void ReverseCell(long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkPolyData.ReverseCell_0(this, cellId);
}


// void DeletePoint(vtkIdType ptId)
// "void DeletePoint(vtkIdType ptId)"
public void DeletePoint(long /*(vtkIdType)*/ ptId) {
	VTK_API.API_vtkPolyData.DeletePoint_0(this, ptId);
}


// void DeleteCell(vtkIdType cellId)
// "void DeleteCell(vtkIdType cellId)"
public void DeleteCell(long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkPolyData.DeleteCell_0(this, cellId);
}


// void RemoveDeletedCells()
// "void RemoveDeletedCells()"
public void RemoveDeletedCells() {
	VTK_API.API_vtkPolyData.RemoveDeletedCells_0(this);
}


// vtkIdType InsertNextLinkedPoint(int numLinks)
// "vtkIdType InsertNextLinkedPoint(int numLinks)"
public long InsertNextLinkedPoint(int /*(int)*/ numLinks) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.InsertNextLinkedPoint_0(out returnPointer, this, numLinks);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType InsertNextLinkedPoint(double x[3], int numLinks)
// "vtkIdType InsertNextLinkedPoint(double x[3], int numLinks)"
public long InsertNextLinkedPoint(double /*(double[3])*/ []x, int /*(int)*/ numLinks) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPolyData.InsertNextLinkedPoint_1(out returnPointer, this, x, numLinks);
//	return (long)returnPointer;
	return returnPointer;
}


// void RemoveCellReference(vtkIdType cellId)
// "void RemoveCellReference(vtkIdType cellId)"
public void RemoveCellReference(long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkPolyData.RemoveCellReference_0(this, cellId);
}


// void AddCellReference(vtkIdType cellId)
// "void AddCellReference(vtkIdType cellId)"
public void AddCellReference(long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkPolyData.AddCellReference_0(this, cellId);
}


// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public void RemoveReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkPolyData.RemoveReferenceToCell_0(this, ptId, cellId);
}


// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public void AddReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkPolyData.AddReferenceToCell_0(this, ptId, cellId);
}


// void ResizeCellList(vtkIdType ptId, int size)
// "void ResizeCellList(vtkIdType ptId, int size)"
public void ResizeCellList(long /*(vtkIdType)*/ ptId, int /*(int)*/ size) {
	VTK_API.API_vtkPolyData.ResizeCellList_0(this, ptId, size);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkPolyData.Initialize_0(this);
}


// virtual int GetPiece()
// "virtual int GetPiece()"
public int GetPiece() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetPiece_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfPieces()
// "virtual int GetNumberOfPieces()"
public int GetNumberOfPieces() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetNumberOfPieces_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetGhostLevel()
// "virtual int GetGhostLevel()"
public int GetGhostLevel() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetGhostLevel_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPolyData.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkPolyData.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkPolyData.DeepCopy_0(this, src);
}


// void RemoveGhostCells()
// "void RemoveGhostCells()"
public void RemoveGhostCells() {
	VTK_API.API_vtkPolyData.RemoveGhostCells_0(this);
}


// int GetScalarFieldCriticalIndex(vtkIdType pointId, vtkDataArray * scalarField)
// "int GetScalarFieldCriticalIndex (vtkIdType pointId, vtkDataArray *scalarField)"
public int GetScalarFieldCriticalIndex(long /*(vtkIdType)*/ pointId, vtkDataArray /*(vtkDataArray*)*/ scalarField) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetScalarFieldCriticalIndex_0(out returnPointer, this, pointId, scalarField);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetScalarFieldCriticalIndex(vtkIdType pointId, int fieldId)
// "int GetScalarFieldCriticalIndex (vtkIdType pointId, int fieldId)"
public int GetScalarFieldCriticalIndex(long /*(vtkIdType)*/ pointId, int /*(int)*/ fieldId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetScalarFieldCriticalIndex_1(out returnPointer, this, pointId, fieldId);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetScalarFieldCriticalIndex(vtkIdType pointId, const char * fieldName)
// "int GetScalarFieldCriticalIndex (vtkIdType pointId, const char* fieldName)"
public int GetScalarFieldCriticalIndex(long /*(vtkIdType)*/ pointId, string /*(char*)*/ fieldName) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyData.GetScalarFieldCriticalIndex_2(out returnPointer, this, pointId, fieldName);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkMTimeType GetMeshMTime()
// "virtual vtkMTimeType GetMeshMTime()"
public ulong GetMeshMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPolyData.GetMeshMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPolyData.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


}
};
