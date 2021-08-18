

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGrid : vtkUnstructuredGridBase {
		public vtkUnstructuredGrid(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnstructuredGrid(IntPtr p) {return new vtkUnstructuredGrid(p);}
		public static implicit operator  IntPtr(vtkUnstructuredGrid o) {return o.GetPtr();}

// static vtkUnstructuredGrid* New()
// "static vtkUnstructuredGrid *New()"
public static vtkUnstructuredGrid New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.New_0(out returnPointer);
//	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnstructuredGrid.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnstructuredGrid.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkUnstructuredGrid* SafeDownCast(vtkObjectBase * o)
// "static vtkUnstructuredGrid* SafeDownCast(vtkObjectBase *o)"
public static vtkUnstructuredGrid SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.SafeDownCast_0(out returnPointer, o);
//	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* NewInstance()
// "vtkUnstructuredGrid *NewInstance()"
public vtkUnstructuredGrid NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.NewInstance_0(out returnPointer, this);
//	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// "void Allocate(vtkIdType numCells=1000, int extSize=1000)"
public void Allocate(long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize) {
	VTK_API.API_vtkUnstructuredGrid.Allocate_0(this, numCells, extSize);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkUnstructuredGrid.Reset_0(this);
}


// void CopyStructure(vtkDataSet * ds)
// "void CopyStructure(vtkDataSet *ds)"
public void CopyStructure(vtkDataSet /*(vtkDataSet*)*/ ds) {
	VTK_API.API_vtkUnstructuredGrid.CopyStructure_0(this, ds);
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkUnstructuredGrid.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkCell* GetCell(vtkIdType cellId)
// "vtkCell *GetCell(vtkIdType cellId)"
public vtkCell GetCell(long /*(vtkIdType)*/ cellId) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetCell_0(out returnPointer, this, cellId);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// void GetCell(vtkIdType cellId, vtkGenericCell * cell)
// "void GetCell(vtkIdType cellId, vtkGenericCell *cell)"
public void GetCell(long /*(vtkIdType)*/ cellId, vtkGenericCell /*(vtkGenericCell*)*/ cell) {
	VTK_API.API_vtkUnstructuredGrid.GetCell_1(this, cellId, cell);
}


// void GetCellBounds(vtkIdType cellId, double bounds[6])
// "void GetCellBounds(vtkIdType cellId, double bounds[6])"
public void GetCellBounds(long /*(vtkIdType)*/ cellId, double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkUnstructuredGrid.GetCellBounds_0(this, cellId, bounds);
}


// void GetCellPoints(vtkIdType cellId, vtkIdList * ptIds)
// "void GetCellPoints(vtkIdType cellId, vtkIdList *ptIds)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkUnstructuredGrid.GetCellPoints_0(this, cellId, ptIds);
}


// void GetPointCells(vtkIdType ptId, vtkIdList * cellIds)
// "void GetPointCells(vtkIdType ptId, vtkIdList *cellIds)"
public void GetPointCells(long /*(vtkIdType)*/ ptId, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkUnstructuredGrid.GetPointCells_0(this, ptId, cellIds);
}


// vtkCellIterator* NewCellIterator()
// "vtkCellIterator* NewCellIterator()"
public vtkCellIterator NewCellIterator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.NewCellIterator_0(out returnPointer, this);
//	return (vtkCellIterator)(IntPtr)returnPointer;
	return (vtkCellIterator)(IntPtr)returnPointer;
}


// int GetCellType(vtkIdType cellId)
// "int GetCellType(vtkIdType cellId)"
public int GetCellType(long /*(vtkIdType)*/ cellId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.GetCellType_0(out returnPointer, this, cellId);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkUnsignedCharArray* GetCellTypesArray()
// "vtkUnsignedCharArray* GetCellTypesArray()"
public vtkUnsignedCharArray GetCellTypesArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetCellTypesArray_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkIdTypeArray* GetCellLocationsArray()
// "vtkIdTypeArray* GetCellLocationsArray()"
public vtkIdTypeArray GetCellLocationsArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetCellLocationsArray_0(out returnPointer, this);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkUnstructuredGrid.Squeeze_0(this);
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkUnstructuredGrid.Initialize_0(this);
}


// int GetMaxCellSize()
// "int GetMaxCellSize()"
public int GetMaxCellSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.GetMaxCellSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void BuildLinks()
// "void BuildLinks()"
public void BuildLinks() {
	VTK_API.API_vtkUnstructuredGrid.BuildLinks_0(this);
}


// vtkCellLinks* GetCellLinks()
// "vtkCellLinks *GetCellLinks()"
public vtkCellLinks GetCellLinks() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetCellLinks_0(out returnPointer, this);
//	return (vtkCellLinks)(IntPtr)returnPointer;
	return (vtkCellLinks)(IntPtr)returnPointer;
}


// virtual void GetCellPoints(vtkIdType cellId, vtkIdType & npts, vtkIdType *& pts)
// "virtual void GetCellPoints(vtkIdType cellId, vtkIdType& npts, vtkIdType* &pts)"
public void GetCellPoints(long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(vtkIdType*&)*/ pts) {
	VTK_API.API_vtkUnstructuredGrid.GetCellPoints_1(this, cellId, npts, pts);
}


// void GetFaceStream(vtkIdType cellId, vtkIdList * ptIds)
// "void GetFaceStream(vtkIdType cellId, vtkIdList *ptIds)"
public void GetFaceStream(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds) {
	VTK_API.API_vtkUnstructuredGrid.GetFaceStream_0(this, cellId, ptIds);
}


// void GetFaceStream(vtkIdType cellId, vtkIdType & nfaces, vtkIdType *& ptIds)
// "void GetFaceStream(vtkIdType cellId, vtkIdType& nfaces, vtkIdType* &ptIds)"
public void GetFaceStream(long /*(vtkIdType)*/ cellId, IntPtr /*(vtkIdType&)*/ nfaces, IntPtr /*(vtkIdType*&)*/ ptIds) {
	VTK_API.API_vtkUnstructuredGrid.GetFaceStream_1(this, cellId, nfaces, ptIds);
}


// vtkCellArray* GetCells()
// "vtkCellArray *GetCells()"
public vtkCellArray GetCells() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetCells_0(out returnPointer, this);
//	return (vtkCellArray)(IntPtr)returnPointer;
	return (vtkCellArray)(IntPtr)returnPointer;
}


// void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void RemoveReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public void RemoveReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkUnstructuredGrid.RemoveReferenceToCell_0(this, ptId, cellId);
}


// void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)
// "void AddReferenceToCell(vtkIdType ptId, vtkIdType cellId)"
public void AddReferenceToCell(long /*(vtkIdType)*/ ptId, long /*(vtkIdType)*/ cellId) {
	VTK_API.API_vtkUnstructuredGrid.AddReferenceToCell_0(this, ptId, cellId);
}


// void ResizeCellList(vtkIdType ptId, int size)
// "void ResizeCellList(vtkIdType ptId, int size)"
public void ResizeCellList(long /*(vtkIdType)*/ ptId, int /*(int)*/ size) {
	VTK_API.API_vtkUnstructuredGrid.ResizeCellList_0(this, ptId, size);
}


// void GetCellNeighbors(vtkIdType cellId, vtkIdList * ptIds, vtkIdList * cellIds)
// "void GetCellNeighbors(vtkIdType cellId, vtkIdList *ptIds, vtkIdList *cellIds)"
public void GetCellNeighbors(long /*(vtkIdType)*/ cellId, vtkIdList /*(vtkIdList*)*/ ptIds, vtkIdList /*(vtkIdList*)*/ cellIds) {
	VTK_API.API_vtkUnstructuredGrid.GetCellNeighbors_0(this, cellId, ptIds, cellIds);
}


// virtual int GetPiece()
// "virtual int GetPiece()"
public int GetPiece() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.GetPiece_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfPieces()
// "virtual int GetNumberOfPieces()"
public int GetNumberOfPieces() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.GetNumberOfPieces_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetGhostLevel()
// "virtual int GetGhostLevel()"
public int GetGhostLevel() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.GetGhostLevel_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkUnstructuredGrid.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkDataObject * src)
// "void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkUnstructuredGrid.ShallowCopy_0(this, src);
}


// void DeepCopy(vtkDataObject * src)
// "void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkUnstructuredGrid.DeepCopy_0(this, src);
}


// void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// "void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)"
public void GetIdsOfCellsOfType(int /*(int)*/ type, vtkIdTypeArray /*(vtkIdTypeArray*)*/ array) {
	VTK_API.API_vtkUnstructuredGrid.GetIdsOfCellsOfType_0(this, type, array);
}


// int IsHomogeneous()
// "int IsHomogeneous()"
public int IsHomogeneous() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.IsHomogeneous_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void RemoveGhostCells()
// "void RemoveGhostCells()"
public void RemoveGhostCells() {
	VTK_API.API_vtkUnstructuredGrid.RemoveGhostCells_0(this);
}


// vtkIdType* GetFaces(vtkIdType cellId)
// "vtkIdType *GetFaces(vtkIdType cellId)"
public long[] GetFaces(long /*(vtkIdType)*/ cellId) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkUnstructuredGrid.GetFaces_0(out returnPointer, this, cellId);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdTypeArray* GetFaces()
// "vtkIdTypeArray* GetFaces()"
public vtkIdTypeArray GetFaces() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetFaces_1(out returnPointer, this);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// vtkIdTypeArray* GetFaceLocations()
// "vtkIdTypeArray* GetFaceLocations()"
public vtkIdTypeArray GetFaceLocations() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGrid.GetFaceLocations_0(out returnPointer, this);
//	return (vtkIdTypeArray)(IntPtr)returnPointer;
	return (vtkIdTypeArray)(IntPtr)returnPointer;
}


// int InitializeFacesRepresentation(vtkIdType numPrevCells)
// "int InitializeFacesRepresentation(vtkIdType numPrevCells)"
public int InitializeFacesRepresentation(long /*(vtkIdType)*/ numPrevCells) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkUnstructuredGrid.InitializeFacesRepresentation_0(out returnPointer, this, numPrevCells);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkMTimeType GetMeshMTime()
// "virtual vtkMTimeType GetMeshMTime()"
public ulong GetMeshMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkUnstructuredGrid.GetMeshMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// static void DecomposeAPolyhedronCell(vtkCellArray * polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkCellArray *polyhedronCellArray, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)"
public static void DecomposeAPolyhedronCell(vtkCellArray /*(vtkCellArray*)*/ polyhedronCellArray, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkIdType&)*/ nCellfaces, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_0(polyhedronCellArray, nCellpts, nCellfaces, cellArray, faces);
}


// static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkIdType * polyhedronCellStream, vtkIdType & nCellpts, vtkIdType & nCellfaces, vtkCellArray *cellArray, vtkIdTypeArray *faces)"
public static void DecomposeAPolyhedronCell(long /*(vtkIdType*)*/ []polyhedronCellStream, IntPtr /*(vtkIdType&)*/ nCellpts, IntPtr /*(vtkIdType&)*/ nCellfaces, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_1(polyhedronCellStream, nCellpts, nCellfaces, cellArray, faces);
}


// static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, const vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)
// "static void DecomposeAPolyhedronCell(vtkIdType nCellFaces, const vtkIdType * inFaceStream, vtkIdType & nCellpts, vtkCellArray * cellArray, vtkIdTypeArray * faces)"
public static void DecomposeAPolyhedronCell(long /*(vtkIdType)*/ nCellFaces, long /*(vtkIdType*)*/ []inFaceStream, IntPtr /*(vtkIdType&)*/ nCellpts, vtkCellArray /*(vtkCellArray*)*/ cellArray, vtkIdTypeArray /*(vtkIdTypeArray*)*/ faces) {
	VTK_API.API_vtkUnstructuredGrid.DecomposeAPolyhedronCell_2(nCellFaces, inFaceStream, nCellpts, cellArray, faces);
}


// static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)
// "static void ConvertFaceStreamPointIds(vtkIdList * faceStream, vtkIdType * idMap)"
public static void ConvertFaceStreamPointIds(vtkIdList /*(vtkIdList*)*/ faceStream, long /*(vtkIdType*)*/ []idMap) {
	VTK_API.API_vtkUnstructuredGrid.ConvertFaceStreamPointIds_0(faceStream, idMap);
}


// static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)
// "static void ConvertFaceStreamPointIds(vtkIdType nfaces, vtkIdType * faceStream, vtkIdType * idMap)"
public static void ConvertFaceStreamPointIds(long /*(vtkIdType)*/ nfaces, long /*(vtkIdType*)*/ []faceStream, long /*(vtkIdType*)*/ []idMap) {
	VTK_API.API_vtkUnstructuredGrid.ConvertFaceStreamPointIds_1(nfaces, faceStream, idMap);
}


}
};
