
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUndirectedGraph {

// static vtkUndirectedGraph* New()
// static vtkUndirectedGraph *New()
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkUndirectedGraph*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkUndirectedGraph*)*/ callingObject, string /*(char*)*/ type);

// static vtkUndirectedGraph* SafeDownCast(vtkObjectBase * o)
// static vtkUndirectedGraph* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkUndirectedGraph*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkUndirectedGraph* NewInstance()
// vtkUndirectedGraph *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkUndirectedGraph*)*/ return_value, IntPtr /*(vtkUndirectedGraph*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(out int /*(int)*/ return_value, IntPtr /*(vtkUndirectedGraph*)*/ callingObject);

// vtkIdType GetInDegree(vtkIdType v)
// vtkIdType GetInDegree(vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_GetInDegree_0")] public static extern 
bool GetInDegree_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkUndirectedGraph*)*/ callingObject, long /*(vtkIdType)*/ v);

// void GetInEdge(vtkIdType v, vtkIdType i, vtkGraphEdge * e)
// void GetInEdge(vtkIdType v, vtkIdType i, vtkGraphEdge* e)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_GetInEdge_0")] public static extern 
bool GetInEdge_0(IntPtr /*(vtkUndirectedGraph*)*/ callingObject, long /*(vtkIdType)*/ v, long /*(vtkIdType)*/ i, IntPtr /*(vtkGraphEdge*)*/ e);

// void GetInEdges(vtkIdType v, vtkInEdgeIterator * it)
// void GetInEdges(vtkIdType v, vtkInEdgeIterator *it)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_GetInEdges_0")] public static extern 
bool GetInEdges_0(IntPtr /*(vtkUndirectedGraph*)*/ callingObject, long /*(vtkIdType)*/ v, IntPtr /*(vtkInEdgeIterator*)*/ it);

// bool IsStructureValid(vtkGraph * g)
// bool IsStructureValid(vtkGraph *g)
[DllImport("vtkplugin", EntryPoint="vtkUndirectedGraph_IsStructureValid_0")] public static extern 
bool IsStructureValid_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkUndirectedGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

}
};
