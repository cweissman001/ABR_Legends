

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGraph : vtkDataObject {
		public vtkGraph(IntPtr p) : base(p) {}
		public static implicit operator  vtkGraph(IntPtr p) {return new vtkGraph(p);}
		public static implicit operator  IntPtr(vtkGraph o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkGraph* SafeDownCast(vtkObjectBase * o)
// "static vtkGraph* SafeDownCast(vtkObjectBase *o)"
public static vtkGraph SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.SafeDownCast_0(out returnPointer, o);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// vtkGraph* NewInstance()
// "vtkGraph *NewInstance()"
public vtkGraph NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.NewInstance_0(out returnPointer, this);
//	return (vtkGraph)(IntPtr)returnPointer;
	return (vtkGraph)(IntPtr)returnPointer;
}


// virtual vtkDataSetAttributes* GetVertexData()
// "virtual vtkDataSetAttributes *GetVertexData ()"
public vtkDataSetAttributes GetVertexData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.GetVertexData_0(out returnPointer, this);
//	return (vtkDataSetAttributes)(IntPtr)returnPointer;
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// virtual vtkDataSetAttributes* GetEdgeData()
// "virtual vtkDataSetAttributes *GetEdgeData ()"
public vtkDataSetAttributes GetEdgeData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.GetEdgeData_0(out returnPointer, this);
//	return (vtkDataSetAttributes)(IntPtr)returnPointer;
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGraph.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkGraph.Initialize_0(this);
}


// double* GetPoint(vtkIdType ptId)
// "double *GetPoint(vtkIdType ptId)"
public double[] GetPoint(long /*(vtkIdType)*/ ptId) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkGraph.GetPoint_0(out returnPointer, this, ptId);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetPoint(vtkIdType ptId, double x[3])
// "void GetPoint(vtkIdType ptId, double x[3])"
public void GetPoint(long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x) {
	VTK_API.API_vtkGraph.GetPoint_1(this, ptId, x);
}


// vtkPoints* GetPoints()
// "vtkPoints* GetPoints()"
public vtkPoints GetPoints() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.GetPoints_0(out returnPointer, this);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// virtual void SetPoints(vtkPoints * points)
// "virtual void SetPoints(vtkPoints *points)"
public void SetPoints(vtkPoints /*(vtkPoints*)*/ points) {
	VTK_API.API_vtkGraph.SetPoints_0(this, points);
}


// void ComputeBounds()
// "void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkGraph.ComputeBounds_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkGraph.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkGraph.GetBounds_1(this, bounds);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkGraph.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void GetOutEdges(vtkIdType v, vtkOutEdgeIterator * it)
// "virtual void GetOutEdges(vtkIdType v, vtkOutEdgeIterator *it)"
public void GetOutEdges(long /*(vtkIdType)*/ v, vtkOutEdgeIterator /*(vtkOutEdgeIterator*)*/ it) {
	VTK_API.API_vtkGraph.GetOutEdges_0(this, v, it);
}


// virtual vtkIdType GetDegree(vtkIdType v)
// "virtual vtkIdType GetDegree(vtkIdType v)"
public long GetDegree(long /*(vtkIdType)*/ v) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetDegree_0(out returnPointer, this, v);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetOutDegree(vtkIdType v)
// "virtual vtkIdType GetOutDegree(vtkIdType v)"
public long GetOutDegree(long /*(vtkIdType)*/ v) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetOutDegree_0(out returnPointer, this, v);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void GetOutEdge(vtkIdType v, vtkIdType index, vtkGraphEdge * e)
// "virtual void GetOutEdge(vtkIdType v, vtkIdType index, vtkGraphEdge* e)"
public void GetOutEdge(long /*(vtkIdType)*/ v, long /*(vtkIdType)*/ index, vtkGraphEdge /*(vtkGraphEdge*)*/ e) {
	VTK_API.API_vtkGraph.GetOutEdge_0(this, v, index, e);
}


// virtual void GetInEdges(vtkIdType v, vtkInEdgeIterator * it)
// "virtual void GetInEdges(vtkIdType v, vtkInEdgeIterator *it)"
public void GetInEdges(long /*(vtkIdType)*/ v, vtkInEdgeIterator /*(vtkInEdgeIterator*)*/ it) {
	VTK_API.API_vtkGraph.GetInEdges_0(this, v, it);
}


// virtual vtkIdType GetInDegree(vtkIdType v)
// "virtual vtkIdType GetInDegree(vtkIdType v)"
public long GetInDegree(long /*(vtkIdType)*/ v) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetInDegree_0(out returnPointer, this, v);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void GetInEdge(vtkIdType v, vtkIdType index, vtkGraphEdge * e)
// "virtual void GetInEdge(vtkIdType v, vtkIdType index, vtkGraphEdge* e)"
public void GetInEdge(long /*(vtkIdType)*/ v, long /*(vtkIdType)*/ index, vtkGraphEdge /*(vtkGraphEdge*)*/ e) {
	VTK_API.API_vtkGraph.GetInEdge_0(this, v, index, e);
}


// virtual void GetAdjacentVertices(vtkIdType v, vtkAdjacentVertexIterator * it)
// "virtual void GetAdjacentVertices(vtkIdType v, vtkAdjacentVertexIterator *it)"
public void GetAdjacentVertices(long /*(vtkIdType)*/ v, vtkAdjacentVertexIterator /*(vtkAdjacentVertexIterator*)*/ it) {
	VTK_API.API_vtkGraph.GetAdjacentVertices_0(this, v, it);
}


// virtual void GetEdges(vtkEdgeListIterator * it)
// "virtual void GetEdges(vtkEdgeListIterator *it)"
public void GetEdges(vtkEdgeListIterator /*(vtkEdgeListIterator*)*/ it) {
	VTK_API.API_vtkGraph.GetEdges_0(this, it);
}


// virtual vtkIdType GetNumberOfEdges()
// "virtual vtkIdType GetNumberOfEdges()"
public long GetNumberOfEdges() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetNumberOfEdges_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void GetVertices(vtkVertexListIterator * it)
// "virtual void GetVertices(vtkVertexListIterator *it)"
public void GetVertices(vtkVertexListIterator /*(vtkVertexListIterator*)*/ it) {
	VTK_API.API_vtkGraph.GetVertices_0(this, it);
}


// virtual vtkIdType GetNumberOfVertices()
// "virtual vtkIdType GetNumberOfVertices()"
public long GetNumberOfVertices() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetNumberOfVertices_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetDistributedGraphHelper(vtkDistributedGraphHelper * helper)
// "void SetDistributedGraphHelper(vtkDistributedGraphHelper *helper)"
public void SetDistributedGraphHelper(vtkDistributedGraphHelper /*(vtkDistributedGraphHelper*)*/ helper) {
	VTK_API.API_vtkGraph.SetDistributedGraphHelper_0(this, helper);
}


// vtkDistributedGraphHelper* GetDistributedGraphHelper()
// "vtkDistributedGraphHelper *GetDistributedGraphHelper()"
public vtkDistributedGraphHelper GetDistributedGraphHelper() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.GetDistributedGraphHelper_0(out returnPointer, this);
//	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
	return (vtkDistributedGraphHelper)(IntPtr)returnPointer;
}


// void ShallowCopy(vtkDataObject * obj)
// "void ShallowCopy(vtkDataObject *obj)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ obj) {
	VTK_API.API_vtkGraph.ShallowCopy_0(this, obj);
}


// void DeepCopy(vtkDataObject * obj)
// "void DeepCopy(vtkDataObject *obj)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ obj) {
	VTK_API.API_vtkGraph.DeepCopy_0(this, obj);
}


// virtual void CopyStructure(vtkGraph * g)
// "virtual void CopyStructure(vtkGraph *g)"
public void CopyStructure(vtkGraph /*(vtkGraph*)*/ g) {
	VTK_API.API_vtkGraph.CopyStructure_0(this, g);
}


// virtual bool CheckedShallowCopy(vtkGraph * g)
// "virtual bool CheckedShallowCopy(vtkGraph *g)"
public bool CheckedShallowCopy(vtkGraph /*(vtkGraph*)*/ g) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.CheckedShallowCopy_0(out returnPointer, this, g);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual bool CheckedDeepCopy(vtkGraph * g)
// "virtual bool CheckedDeepCopy(vtkGraph *g)"
public bool CheckedDeepCopy(vtkGraph /*(vtkGraph*)*/ g) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.CheckedDeepCopy_0(out returnPointer, this, g);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkGraph.Squeeze_0(this);
}


// void ReorderOutVertices(vtkIdType v, vtkIdTypeArray * vertices)
// "void ReorderOutVertices(vtkIdType v, vtkIdTypeArray *vertices)"
public void ReorderOutVertices(long /*(vtkIdType)*/ v, vtkIdTypeArray /*(vtkIdTypeArray*)*/ vertices) {
	VTK_API.API_vtkGraph.ReorderOutVertices_0(this, v, vertices);
}


// bool IsSameStructure(vtkGraph * other)
// "bool IsSameStructure(vtkGraph *other)"
public bool IsSameStructure(vtkGraph /*(vtkGraph*)*/ other) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.IsSameStructure_0(out returnPointer, this, other);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkIdType GetSourceVertex(vtkIdType e)
// "vtkIdType GetSourceVertex(vtkIdType e)"
public long GetSourceVertex(long /*(vtkIdType)*/ e) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetSourceVertex_0(out returnPointer, this, e);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetTargetVertex(vtkIdType e)
// "vtkIdType GetTargetVertex(vtkIdType e)"
public long GetTargetVertex(long /*(vtkIdType)*/ e) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetTargetVertex_0(out returnPointer, this, e);
//	return (long)returnPointer;
	return returnPointer;
}


// void GetEdgePoints(vtkIdType e, vtkIdType & npts, double *& pts)
// "void GetEdgePoints(vtkIdType e, vtkIdType& npts, double*& pts)"
public void GetEdgePoints(long /*(vtkIdType)*/ e, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(double*&)*/ pts) {
	VTK_API.API_vtkGraph.GetEdgePoints_0(this, e, npts, pts);
}


// vtkIdType GetNumberOfEdgePoints(vtkIdType e)
// "vtkIdType GetNumberOfEdgePoints(vtkIdType e)"
public long GetNumberOfEdgePoints(long /*(vtkIdType)*/ e) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetNumberOfEdgePoints_0(out returnPointer, this, e);
//	return (long)returnPointer;
	return returnPointer;
}


// double* GetEdgePoint(vtkIdType e, vtkIdType i)
// "double* GetEdgePoint(vtkIdType e, vtkIdType i)"
public double[] GetEdgePoint(long /*(vtkIdType)*/ e, long /*(vtkIdType)*/ i) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkGraph.GetEdgePoint_0(out returnPointer, this, e, i);
//	return (double)returnPointer;
	return returnPointer;
}


// void ClearEdgePoints(vtkIdType e)
// "void ClearEdgePoints(vtkIdType e)"
public void ClearEdgePoints(long /*(vtkIdType)*/ e) {
	VTK_API.API_vtkGraph.ClearEdgePoints_0(this, e);
}


// void SetEdgePoint(vtkIdType e, vtkIdType i, const double x[3])
// "void SetEdgePoint(vtkIdType e, vtkIdType i, const double x[3])"
public void SetEdgePoint(long /*(vtkIdType)*/ e, long /*(vtkIdType)*/ i, double /*(double[3])*/ []x) {
	VTK_API.API_vtkGraph.SetEdgePoint_0(this, e, i, x);
}


// void SetEdgePoint(vtkIdType e, vtkIdType i, double x, double y, double z)
// "void SetEdgePoint(vtkIdType e, vtkIdType i, double x, double y, double z)"
public void SetEdgePoint(long /*(vtkIdType)*/ e, long /*(vtkIdType)*/ i, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkGraph.SetEdgePoint_1(this, e, i, x, y, z);
}


// void AddEdgePoint(vtkIdType e, const double x[3])
// "void AddEdgePoint(vtkIdType e, const double x[3])"
public void AddEdgePoint(long /*(vtkIdType)*/ e, double /*(double[3])*/ []x) {
	VTK_API.API_vtkGraph.AddEdgePoint_0(this, e, x);
}


// void AddEdgePoint(vtkIdType e, double x, double y, double z)
// "void AddEdgePoint(vtkIdType e, double x, double y, double z)"
public void AddEdgePoint(long /*(vtkIdType)*/ e, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkGraph.AddEdgePoint_1(this, e, x, y, z);
}


// void ShallowCopyEdgePoints(vtkGraph * g)
// "void ShallowCopyEdgePoints(vtkGraph* g)"
public void ShallowCopyEdgePoints(vtkGraph /*(vtkGraph*)*/ g) {
	VTK_API.API_vtkGraph.ShallowCopyEdgePoints_0(this, g);
}


// void DeepCopyEdgePoints(vtkGraph * g)
// "void DeepCopyEdgePoints(vtkGraph* g)"
public void DeepCopyEdgePoints(vtkGraph /*(vtkGraph*)*/ g) {
	VTK_API.API_vtkGraph.DeepCopyEdgePoints_0(this, g);
}


// vtkGraphInternals* GetGraphInternals(bool modifying)
// "vtkGraphInternals *GetGraphInternals(bool modifying)"
public vtkGraphInternals GetGraphInternals(bool /*(bool)*/ modifying) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.GetGraphInternals_0(out returnPointer, this, modifying);
//	return (vtkGraphInternals)(IntPtr)returnPointer;
	return (vtkGraphInternals)(IntPtr)returnPointer;
}


// void GetInducedEdges(vtkIdTypeArray * verts, vtkIdTypeArray * edges)
// "void GetInducedEdges(vtkIdTypeArray* verts, vtkIdTypeArray* edges)"
public void GetInducedEdges(vtkIdTypeArray /*(vtkIdTypeArray*)*/ verts, vtkIdTypeArray /*(vtkIdTypeArray*)*/ edges) {
	VTK_API.API_vtkGraph.GetInducedEdges_0(this, verts, edges);
}


// vtkFieldData* GetAttributesAsFieldData(int type)
// "vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGraph.GetAttributesAsFieldData_0(out returnPointer, this, type);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfElements(int type)
// "vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetNumberOfElements_0(out returnPointer, this, type);
//	return (long)returnPointer;
	return returnPointer;
}


// void Dump()
// "void Dump()"
public void Dump() {
	VTK_API.API_vtkGraph.Dump_0(this);
}


// vtkIdType GetEdgeId(vtkIdType a, vtkIdType b)
// "vtkIdType GetEdgeId(vtkIdType a, vtkIdType b)"
public long GetEdgeId(long /*(vtkIdType)*/ a, long /*(vtkIdType)*/ b) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGraph.GetEdgeId_0(out returnPointer, this, a, b);
//	return (long)returnPointer;
	return returnPointer;
}


// bool ToDirectedGraph(vtkDirectedGraph * g)
// "bool ToDirectedGraph(vtkDirectedGraph* g)"
public bool ToDirectedGraph(vtkDirectedGraph /*(vtkDirectedGraph*)*/ g) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.ToDirectedGraph_0(out returnPointer, this, g);
//	return (bool)returnPointer;
	return returnPointer;
}


// bool ToUndirectedGraph(vtkUndirectedGraph * g)
// "bool ToUndirectedGraph(vtkUndirectedGraph* g)"
public bool ToUndirectedGraph(vtkUndirectedGraph /*(vtkUndirectedGraph*)*/ g) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGraph.ToUndirectedGraph_0(out returnPointer, this, g);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
