
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGraph {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGraph_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGraph_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, string /*(char*)*/ type);

// static vtkGraph* SafeDownCast(vtkObjectBase * o)
// static vtkGraph* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGraph_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGraph* NewInstance()
// vtkGraph *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGraph_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// virtual vtkDataSetAttributes* GetVertexData()
// virtual vtkDataSetAttributes *GetVertexData ()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetVertexData_0")] public static extern 
bool GetVertexData_0(out IntPtr /*(vtkDataSetAttributes*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// virtual vtkDataSetAttributes* GetEdgeData()
// virtual vtkDataSetAttributes *GetEdgeData ()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetEdgeData_0")] public static extern 
bool GetEdgeData_0(out IntPtr /*(vtkDataSetAttributes*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(out int /*(int)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkGraph_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkGraph*)*/ callingObject);

// double* GetPoint(vtkIdType ptId)
// double *GetPoint(vtkIdType ptId)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetPoint_0")] public static extern 
bool GetPoint_0(out double[] /*(double*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ ptId);

// void GetPoint(vtkIdType ptId, double x[3])
// void GetPoint(vtkIdType ptId, double x[3])
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetPoint_1")] public static extern 
bool GetPoint_1(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ ptId, double /*(double[3])*/ []x);

// vtkPoints* GetPoints()
// vtkPoints* GetPoints()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetPoints_0")] public static extern 
bool GetPoints_0(out IntPtr /*(vtkPoints*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// virtual void SetPoints(vtkPoints * points)
// virtual void SetPoints(vtkPoints *points)
[DllImport("vtkplugin", EntryPoint="vtkGraph_SetPoints_0")] public static extern 
bool SetPoints_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkPoints*)*/ points);

// void ComputeBounds()
// void ComputeBounds()
[DllImport("vtkplugin", EntryPoint="vtkGraph_ComputeBounds_0")] public static extern 
bool ComputeBounds_0(IntPtr /*(vtkGraph*)*/ callingObject);

// double* GetBounds()
// double *GetBounds()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetBounds_0")] public static extern 
bool GetBounds_0(out double[] /*(double*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// void GetBounds(double bounds[6])
// void GetBounds(double bounds[6])
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetBounds_1")] public static extern 
bool GetBounds_1(IntPtr /*(vtkGraph*)*/ callingObject, double /*(double[6])*/ []bounds);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetMTime_0")] public static extern 
bool GetMTime_0(out ulong /*(vtkMTimeType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// virtual void GetOutEdges(vtkIdType v, vtkOutEdgeIterator * it)
// virtual void GetOutEdges(vtkIdType v, vtkOutEdgeIterator *it)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetOutEdges_0")] public static extern 
bool GetOutEdges_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v, IntPtr /*(vtkOutEdgeIterator*)*/ it);

// virtual vtkIdType GetDegree(vtkIdType v)
// virtual vtkIdType GetDegree(vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetDegree_0")] public static extern 
bool GetDegree_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v);

// virtual vtkIdType GetOutDegree(vtkIdType v)
// virtual vtkIdType GetOutDegree(vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetOutDegree_0")] public static extern 
bool GetOutDegree_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v);

// virtual void GetOutEdge(vtkIdType v, vtkIdType index, vtkGraphEdge * e)
// virtual void GetOutEdge(vtkIdType v, vtkIdType index, vtkGraphEdge* e)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetOutEdge_0")] public static extern 
bool GetOutEdge_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v, long /*(vtkIdType)*/ index, IntPtr /*(vtkGraphEdge*)*/ e);

// virtual void GetInEdges(vtkIdType v, vtkInEdgeIterator * it)
// virtual void GetInEdges(vtkIdType v, vtkInEdgeIterator *it)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetInEdges_0")] public static extern 
bool GetInEdges_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v, IntPtr /*(vtkInEdgeIterator*)*/ it);

// virtual vtkIdType GetInDegree(vtkIdType v)
// virtual vtkIdType GetInDegree(vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetInDegree_0")] public static extern 
bool GetInDegree_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v);

// virtual void GetInEdge(vtkIdType v, vtkIdType index, vtkGraphEdge * e)
// virtual void GetInEdge(vtkIdType v, vtkIdType index, vtkGraphEdge* e)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetInEdge_0")] public static extern 
bool GetInEdge_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v, long /*(vtkIdType)*/ index, IntPtr /*(vtkGraphEdge*)*/ e);

// virtual void GetAdjacentVertices(vtkIdType v, vtkAdjacentVertexIterator * it)
// virtual void GetAdjacentVertices(vtkIdType v, vtkAdjacentVertexIterator *it)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetAdjacentVertices_0")] public static extern 
bool GetAdjacentVertices_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v, IntPtr /*(vtkAdjacentVertexIterator*)*/ it);

// virtual void GetEdges(vtkEdgeListIterator * it)
// virtual void GetEdges(vtkEdgeListIterator *it)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetEdges_0")] public static extern 
bool GetEdges_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkEdgeListIterator*)*/ it);

// virtual vtkIdType GetNumberOfEdges()
// virtual vtkIdType GetNumberOfEdges()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetNumberOfEdges_0")] public static extern 
bool GetNumberOfEdges_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// virtual void GetVertices(vtkVertexListIterator * it)
// virtual void GetVertices(vtkVertexListIterator *it)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetVertices_0")] public static extern 
bool GetVertices_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkVertexListIterator*)*/ it);

// virtual vtkIdType GetNumberOfVertices()
// virtual vtkIdType GetNumberOfVertices()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetNumberOfVertices_0")] public static extern 
bool GetNumberOfVertices_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// void SetDistributedGraphHelper(vtkDistributedGraphHelper * helper)
// void SetDistributedGraphHelper(vtkDistributedGraphHelper *helper)
[DllImport("vtkplugin", EntryPoint="vtkGraph_SetDistributedGraphHelper_0")] public static extern 
bool SetDistributedGraphHelper_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkDistributedGraphHelper*)*/ helper);

// vtkDistributedGraphHelper* GetDistributedGraphHelper()
// vtkDistributedGraphHelper *GetDistributedGraphHelper()
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetDistributedGraphHelper_0")] public static extern 
bool GetDistributedGraphHelper_0(out IntPtr /*(vtkDistributedGraphHelper*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject);

// void ShallowCopy(vtkDataObject * obj)
// void ShallowCopy(vtkDataObject *obj)
[DllImport("vtkplugin", EntryPoint="vtkGraph_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ obj);

// void DeepCopy(vtkDataObject * obj)
// void DeepCopy(vtkDataObject *obj)
[DllImport("vtkplugin", EntryPoint="vtkGraph_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ obj);

// virtual void CopyStructure(vtkGraph * g)
// virtual void CopyStructure(vtkGraph *g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_CopyStructure_0")] public static extern 
bool CopyStructure_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

// virtual bool CheckedShallowCopy(vtkGraph * g)
// virtual bool CheckedShallowCopy(vtkGraph *g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_CheckedShallowCopy_0")] public static extern 
bool CheckedShallowCopy_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

// virtual bool CheckedDeepCopy(vtkGraph * g)
// virtual bool CheckedDeepCopy(vtkGraph *g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_CheckedDeepCopy_0")] public static extern 
bool CheckedDeepCopy_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

// virtual void Squeeze()
// virtual void Squeeze()
[DllImport("vtkplugin", EntryPoint="vtkGraph_Squeeze_0")] public static extern 
bool Squeeze_0(IntPtr /*(vtkGraph*)*/ callingObject);

// void ReorderOutVertices(vtkIdType v, vtkIdTypeArray * vertices)
// void ReorderOutVertices(vtkIdType v, vtkIdTypeArray *vertices)
[DllImport("vtkplugin", EntryPoint="vtkGraph_ReorderOutVertices_0")] public static extern 
bool ReorderOutVertices_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ v, IntPtr /*(vtkIdTypeArray*)*/ vertices);

// bool IsSameStructure(vtkGraph * other)
// bool IsSameStructure(vtkGraph *other)
[DllImport("vtkplugin", EntryPoint="vtkGraph_IsSameStructure_0")] public static extern 
bool IsSameStructure_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ other);

// vtkIdType GetSourceVertex(vtkIdType e)
// vtkIdType GetSourceVertex(vtkIdType e)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetSourceVertex_0")] public static extern 
bool GetSourceVertex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e);

// vtkIdType GetTargetVertex(vtkIdType e)
// vtkIdType GetTargetVertex(vtkIdType e)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetTargetVertex_0")] public static extern 
bool GetTargetVertex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e);

// void GetEdgePoints(vtkIdType e, vtkIdType & npts, double *& pts)
// void GetEdgePoints(vtkIdType e, vtkIdType& npts, double*& pts)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetEdgePoints_0")] public static extern 
bool GetEdgePoints_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e, IntPtr /*(vtkIdType&)*/ npts, IntPtr /*(double*&)*/ pts);

// vtkIdType GetNumberOfEdgePoints(vtkIdType e)
// vtkIdType GetNumberOfEdgePoints(vtkIdType e)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetNumberOfEdgePoints_0")] public static extern 
bool GetNumberOfEdgePoints_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e);

// double* GetEdgePoint(vtkIdType e, vtkIdType i)
// double* GetEdgePoint(vtkIdType e, vtkIdType i)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetEdgePoint_0")] public static extern 
bool GetEdgePoint_0(out double[] /*(double*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e, long /*(vtkIdType)*/ i);

// void ClearEdgePoints(vtkIdType e)
// void ClearEdgePoints(vtkIdType e)
[DllImport("vtkplugin", EntryPoint="vtkGraph_ClearEdgePoints_0")] public static extern 
bool ClearEdgePoints_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e);

// void SetEdgePoint(vtkIdType e, vtkIdType i, const double x[3])
// void SetEdgePoint(vtkIdType e, vtkIdType i, const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkGraph_SetEdgePoint_0")] public static extern 
bool SetEdgePoint_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e, long /*(vtkIdType)*/ i, double /*(double[3])*/ []x);

// void SetEdgePoint(vtkIdType e, vtkIdType i, double x, double y, double z)
// void SetEdgePoint(vtkIdType e, vtkIdType i, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkGraph_SetEdgePoint_1")] public static extern 
bool SetEdgePoint_1(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e, long /*(vtkIdType)*/ i, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void AddEdgePoint(vtkIdType e, const double x[3])
// void AddEdgePoint(vtkIdType e, const double x[3])
[DllImport("vtkplugin", EntryPoint="vtkGraph_AddEdgePoint_0")] public static extern 
bool AddEdgePoint_0(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e, double /*(double[3])*/ []x);

// void AddEdgePoint(vtkIdType e, double x, double y, double z)
// void AddEdgePoint(vtkIdType e, double x, double y, double z)
[DllImport("vtkplugin", EntryPoint="vtkGraph_AddEdgePoint_1")] public static extern 
bool AddEdgePoint_1(IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ e, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z);

// void ShallowCopyEdgePoints(vtkGraph * g)
// void ShallowCopyEdgePoints(vtkGraph* g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_ShallowCopyEdgePoints_0")] public static extern 
bool ShallowCopyEdgePoints_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

// void DeepCopyEdgePoints(vtkGraph * g)
// void DeepCopyEdgePoints(vtkGraph* g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_DeepCopyEdgePoints_0")] public static extern 
bool DeepCopyEdgePoints_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

// vtkGraphInternals* GetGraphInternals(bool modifying)
// vtkGraphInternals *GetGraphInternals(bool modifying)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetGraphInternals_0")] public static extern 
bool GetGraphInternals_0(out IntPtr /*(vtkGraphInternals*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, bool /*(bool)*/ modifying);

// void GetInducedEdges(vtkIdTypeArray * verts, vtkIdTypeArray * edges)
// void GetInducedEdges(vtkIdTypeArray* verts, vtkIdTypeArray* edges)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetInducedEdges_0")] public static extern 
bool GetInducedEdges_0(IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkIdTypeArray*)*/ verts, IntPtr /*(vtkIdTypeArray*)*/ edges);

// vtkFieldData* GetAttributesAsFieldData(int type)
// vtkFieldData* GetAttributesAsFieldData(int type)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData_0(out IntPtr /*(vtkFieldData*)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, int /*(int)*/ type);

// vtkIdType GetNumberOfElements(int type)
// vtkIdType GetNumberOfElements(int type)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, int /*(int)*/ type);

// void Dump()
// void Dump()
[DllImport("vtkplugin", EntryPoint="vtkGraph_Dump_0")] public static extern 
bool Dump_0(IntPtr /*(vtkGraph*)*/ callingObject);

// vtkIdType GetEdgeId(vtkIdType a, vtkIdType b)
// vtkIdType GetEdgeId(vtkIdType a, vtkIdType b)
[DllImport("vtkplugin", EntryPoint="vtkGraph_GetEdgeId_0")] public static extern 
bool GetEdgeId_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, long /*(vtkIdType)*/ a, long /*(vtkIdType)*/ b);

// bool ToDirectedGraph(vtkDirectedGraph * g)
// bool ToDirectedGraph(vtkDirectedGraph* g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_ToDirectedGraph_0")] public static extern 
bool ToDirectedGraph_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkDirectedGraph*)*/ g);

// bool ToUndirectedGraph(vtkUndirectedGraph * g)
// bool ToUndirectedGraph(vtkUndirectedGraph* g)
[DllImport("vtkplugin", EntryPoint="vtkGraph_ToUndirectedGraph_0")] public static extern 
bool ToUndirectedGraph_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkGraph*)*/ callingObject, IntPtr /*(vtkUndirectedGraph*)*/ g);

}
};
