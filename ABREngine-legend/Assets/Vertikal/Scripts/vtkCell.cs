

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCell : vtkObject {
		public vtkCell(IntPtr p) : base(p) {}
		public static implicit operator  vtkCell(IntPtr p) {return new vtkCell(p);}
		public static implicit operator  IntPtr(vtkCell o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCell.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCell.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCell* SafeDownCast(vtkObjectBase * o)
// "static vtkCell* SafeDownCast(vtkObjectBase *o)"
public static vtkCell SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCell.SafeDownCast_0(out returnPointer, o);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// vtkCell* NewInstance()
// "vtkCell *NewInstance()"
public vtkCell NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCell.NewInstance_0(out returnPointer, this);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// void Initialize(int npts, vtkIdType * pts, vtkPoints * p)
// "void Initialize(int npts, vtkIdType *pts, vtkPoints *p)"
public void Initialize(int /*(int)*/ npts, long /*(vtkIdType*)*/ []pts, vtkPoints /*(vtkPoints*)*/ p) {
	VTK_API.API_vtkCell.Initialize_0(this, npts, pts, p);
}


// void Initialize(int npts, vtkPoints * p)
// "void Initialize(int npts, vtkPoints *p)"
public void Initialize(int /*(int)*/ npts, vtkPoints /*(vtkPoints*)*/ p) {
	VTK_API.API_vtkCell.Initialize_1(this, npts, p);
}


// virtual void ShallowCopy(vtkCell * c)
// "virtual void ShallowCopy(vtkCell *c)"
public void ShallowCopy(vtkCell /*(vtkCell*)*/ c) {
	VTK_API.API_vtkCell.ShallowCopy_0(this, c);
}


// virtual void DeepCopy(vtkCell * c)
// "virtual void DeepCopy(vtkCell *c)"
public void DeepCopy(vtkCell /*(vtkCell*)*/ c) {
	VTK_API.API_vtkCell.DeepCopy_0(this, c);
}


// virtual int GetCellType()
// "virtual int GetCellType()"
public int GetCellType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.GetCellType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetCellDimension()
// "virtual int GetCellDimension()"
public int GetCellDimension() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.GetCellDimension_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int IsLinear()
// "virtual int IsLinear()"
public int IsLinear() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.IsLinear_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int RequiresInitialization()
// "virtual int RequiresInitialization()"
public int RequiresInitialization() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.RequiresInitialization_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkCell.Initialize_2(this);
}


// virtual int IsExplicitCell()
// "virtual int IsExplicitCell()"
public int IsExplicitCell() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.IsExplicitCell_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int RequiresExplicitFaceRepresentation()
// "virtual int RequiresExplicitFaceRepresentation()"
public int RequiresExplicitFaceRepresentation() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.RequiresExplicitFaceRepresentation_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetFaces(vtkIdType * ARG_0)
// "virtual void SetFaces(vtkIdType *)"
public void SetFaces(long /*(vtkIdType*)*/ []ARG_0) {
	VTK_API.API_vtkCell.SetFaces_0(this, ARG_0);
}


// virtual vtkIdType* GetFaces()
// "virtual vtkIdType *GetFaces()"
public long[] GetFaces() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long[] returnPointer = new long[1];
	VTK_API.API_vtkCell.GetFaces_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkPoints* GetPoints()
// "vtkPoints *GetPoints()"
public vtkPoints GetPoints() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCell.GetPoints_0(out returnPointer, this);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCell.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfEdges()
// "virtual int GetNumberOfEdges()"
public int GetNumberOfEdges() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.GetNumberOfEdges_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfFaces()
// "virtual int GetNumberOfFaces()"
public int GetNumberOfFaces() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.GetNumberOfFaces_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdList* GetPointIds()
// "vtkIdList *GetPointIds()"
public vtkIdList GetPointIds() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCell.GetPointIds_0(out returnPointer, this);
//	return (vtkIdList)(IntPtr)returnPointer;
	return (vtkIdList)(IntPtr)returnPointer;
}


// vtkIdType GetPointId(int ptId)
// "vtkIdType GetPointId(int ptId)"
public long GetPointId(int /*(int)*/ ptId) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkCell.GetPointId_0(out returnPointer, this, ptId);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkCell* GetEdge(int edgeId)
// "virtual vtkCell *GetEdge(int edgeId)"
public vtkCell GetEdge(int /*(int)*/ edgeId) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCell.GetEdge_0(out returnPointer, this, edgeId);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// virtual vtkCell* GetFace(int faceId)
// "virtual vtkCell *GetFace(int faceId)"
public vtkCell GetFace(int /*(int)*/ faceId) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCell.GetFace_0(out returnPointer, this, faceId);
//	return (vtkCell)(IntPtr)returnPointer;
	return (vtkCell)(IntPtr)returnPointer;
}


// virtual int CellBoundary(int subId, const double pcoords[3], vtkIdList * pts)
// "virtual int CellBoundary(int subId, const double pcoords[3], vtkIdList *pts)"
public int CellBoundary(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, vtkIdList /*(vtkIdList*)*/ pts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.CellBoundary_0(out returnPointer, this, subId, pcoords, pts);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void EvaluateLocation(int & subId, const double pcoords[3], double x[3], double * weights)
// "virtual void EvaluateLocation(int& subId, const double pcoords[3], double x[3], double *weights)"
public void EvaluateLocation(IntPtr /*(int&)*/ subId, double /*(double[3])*/ []pcoords, double /*(double[3])*/ []x, double /*(double*)*/ []weights) {
	VTK_API.API_vtkCell.EvaluateLocation_0(this, subId, pcoords, x, weights);
}


// virtual void Contour(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * verts, vtkCellArray * lines, vtkCellArray * polys, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd)
// "virtual void Contour(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *verts, vtkCellArray *lines, vtkCellArray *polys, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd)"
public void Contour(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ verts, vtkCellArray /*(vtkCellArray*)*/ lines, vtkCellArray /*(vtkCellArray*)*/ polys, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd) {
	VTK_API.API_vtkCell.Contour_0(this, value, cellScalars, locator, verts, lines, polys, inPd, outPd, inCd, cellId, outCd);
}


// virtual void Clip(double value, vtkDataArray * cellScalars, vtkIncrementalPointLocator * locator, vtkCellArray * connectivity, vtkPointData * inPd, vtkPointData * outPd, vtkCellData * inCd, vtkIdType cellId, vtkCellData * outCd, int insideOut)
// "virtual void Clip(double value, vtkDataArray *cellScalars, vtkIncrementalPointLocator *locator, vtkCellArray *connectivity, vtkPointData *inPd, vtkPointData *outPd, vtkCellData *inCd, vtkIdType cellId, vtkCellData *outCd, int insideOut)"
public void Clip(double /*(double)*/ value, vtkDataArray /*(vtkDataArray*)*/ cellScalars, vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator, vtkCellArray /*(vtkCellArray*)*/ connectivity, vtkPointData /*(vtkPointData*)*/ inPd, vtkPointData /*(vtkPointData*)*/ outPd, vtkCellData /*(vtkCellData*)*/ inCd, long /*(vtkIdType)*/ cellId, vtkCellData /*(vtkCellData*)*/ outCd, int /*(int)*/ insideOut) {
	VTK_API.API_vtkCell.Clip_0(this, value, cellScalars, locator, connectivity, inPd, outPd, inCd, cellId, outCd, insideOut);
}


// virtual int IntersectWithLine(const double p1[3], const double p2[3], double tol, double & t, double x[3], double pcoords[3], int & subId)
// "virtual int IntersectWithLine(const double p1[3], const double p2[3], double tol, double& t, double x[3], double pcoords[3], int& subId)"
public int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double)*/ tol, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x, double /*(double[3])*/ []pcoords, IntPtr /*(int&)*/ subId) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.IntersectWithLine_0(out returnPointer, this, p1, p2, tol, t, x, pcoords, subId);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int Triangulate(int index, vtkIdList * ptIds, vtkPoints * pts)
// "virtual int Triangulate(int index, vtkIdList *ptIds, vtkPoints *pts)"
public int Triangulate(int /*(int)*/ index, vtkIdList /*(vtkIdList*)*/ ptIds, vtkPoints /*(vtkPoints*)*/ pts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.Triangulate_0(out returnPointer, this, index, ptIds, pts);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void Derivatives(int subId, const double pcoords[3], const double * values, int dim, double * derivs)
// "virtual void Derivatives(int subId, const double pcoords[3], const double *values, int dim, double *derivs)"
public void Derivatives(int /*(int)*/ subId, double /*(double[3])*/ []pcoords, double /*(double*)*/ []values, int /*(int)*/ dim, double /*(double*)*/ []derivs) {
	VTK_API.API_vtkCell.Derivatives_0(this, subId, pcoords, values, dim, derivs);
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkCell.GetBounds_0(this, bounds);
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCell.GetBounds_1(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetLength2()
// "double GetLength2()"
public double GetLength2() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCell.GetLength2_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int GetParametricCenter(double pcoords[3])
// "virtual int GetParametricCenter(double pcoords[3])"
public int GetParametricCenter(double /*(double[3])*/ []pcoords) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.GetParametricCenter_0(out returnPointer, this, pcoords);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual double GetParametricDistance(const double pcoords[3])
// "virtual double GetParametricDistance(const double pcoords[3])"
public double GetParametricDistance(double /*(double[3])*/ []pcoords) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCell.GetParametricDistance_0(out returnPointer, this, pcoords);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int IsPrimaryCell()
// "virtual int IsPrimaryCell()"
public int IsPrimaryCell() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCell.IsPrimaryCell_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual double* GetParametricCoords()
// "virtual double *GetParametricCoords()"
public double[] GetParametricCoords() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCell.GetParametricCoords_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void InterpolateFunctions(const double ARG_0[3], double * ARG_1)
// "virtual void InterpolateFunctions(const double [3], double* )"
public void InterpolateFunctions(double /*(double[3])*/ []ARG_0, double /*(double*)*/ []ARG_1) {
	VTK_API.API_vtkCell.InterpolateFunctions_0(this, ARG_0, ARG_1);
}


// virtual void InterpolateDerivs(const double ARG_0[3], double * ARG_1)
// "virtual void InterpolateDerivs(const double [3], double* )"
public void InterpolateDerivs(double /*(double[3])*/ []ARG_0, double /*(double*)*/ []ARG_1) {
	VTK_API.API_vtkCell.InterpolateDerivs_0(this, ARG_0, ARG_1);
}


}
};
