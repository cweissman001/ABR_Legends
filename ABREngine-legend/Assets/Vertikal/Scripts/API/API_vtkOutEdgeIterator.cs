
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkOutEdgeIterator {

// static vtkOutEdgeIterator* New()
// static vtkOutEdgeIterator *New()
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkOutEdgeIterator*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkOutEdgeIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkOutEdgeIterator* SafeDownCast(vtkObjectBase * o)
// static vtkOutEdgeIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkOutEdgeIterator*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkOutEdgeIterator* NewInstance()
// vtkOutEdgeIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkOutEdgeIterator*)*/ return_value, IntPtr /*(vtkOutEdgeIterator*)*/ callingObject);

// void Initialize(vtkGraph * g, vtkIdType v)
// void Initialize(vtkGraph *g, vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkOutEdgeIterator*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ v);

// virtual vtkGraph* GetGraph()
// virtual vtkGraph *GetGraph ()
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_GetGraph_0")] public static extern 
bool GetGraph_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkOutEdgeIterator*)*/ callingObject);

// virtual vtkIdType GetVertex()
// virtual vtkIdType GetVertex ()
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_GetVertex_0")] public static extern 
bool GetVertex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkOutEdgeIterator*)*/ callingObject);

// vtkGraphEdge* NextGraphEdge()
// vtkGraphEdge *NextGraphEdge()
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_NextGraphEdge_0")] public static extern 
bool NextGraphEdge_0(out IntPtr /*(vtkGraphEdge*)*/ return_value, IntPtr /*(vtkOutEdgeIterator*)*/ callingObject);

// bool HasNext()
// bool HasNext()
[DllImport("vtkplugin", EntryPoint="vtkOutEdgeIterator_HasNext_0")] public static extern 
bool HasNext_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkOutEdgeIterator*)*/ callingObject);

}
};
