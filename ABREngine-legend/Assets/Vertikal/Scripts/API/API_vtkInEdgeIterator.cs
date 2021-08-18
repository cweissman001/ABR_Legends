
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkInEdgeIterator {

// static vtkInEdgeIterator* New()
// static vtkInEdgeIterator *New()
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkInEdgeIterator*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkInEdgeIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkInEdgeIterator* SafeDownCast(vtkObjectBase * o)
// static vtkInEdgeIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkInEdgeIterator*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkInEdgeIterator* NewInstance()
// vtkInEdgeIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkInEdgeIterator*)*/ return_value, IntPtr /*(vtkInEdgeIterator*)*/ callingObject);

// void Initialize(vtkGraph * g, vtkIdType v)
// void Initialize(vtkGraph *g, vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkInEdgeIterator*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ v);

// virtual vtkGraph* GetGraph()
// virtual vtkGraph *GetGraph ()
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_GetGraph_0")] public static extern 
bool GetGraph_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkInEdgeIterator*)*/ callingObject);

// virtual vtkIdType GetVertex()
// virtual vtkIdType GetVertex ()
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_GetVertex_0")] public static extern 
bool GetVertex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkInEdgeIterator*)*/ callingObject);

// vtkGraphEdge* NextGraphEdge()
// vtkGraphEdge *NextGraphEdge()
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_NextGraphEdge_0")] public static extern 
bool NextGraphEdge_0(out IntPtr /*(vtkGraphEdge*)*/ return_value, IntPtr /*(vtkInEdgeIterator*)*/ callingObject);

// bool HasNext()
// bool HasNext()
[DllImport("vtkplugin", EntryPoint="vtkInEdgeIterator_HasNext_0")] public static extern 
bool HasNext_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkInEdgeIterator*)*/ callingObject);

}
};
