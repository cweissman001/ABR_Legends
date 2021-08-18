
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkAdjacentVertexIterator {

// static vtkAdjacentVertexIterator* New()
// static vtkAdjacentVertexIterator *New()
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkAdjacentVertexIterator*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkAdjacentVertexIterator* SafeDownCast(vtkObjectBase * o)
// static vtkAdjacentVertexIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkAdjacentVertexIterator*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkAdjacentVertexIterator* NewInstance()
// vtkAdjacentVertexIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkAdjacentVertexIterator*)*/ return_value, IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject);

// void Initialize(vtkGraph * g, vtkIdType v)
// void Initialize(vtkGraph *g, vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ v);

// virtual vtkGraph* GetGraph()
// virtual vtkGraph *GetGraph ()
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_GetGraph_0")] public static extern 
bool GetGraph_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject);

// virtual vtkIdType GetVertex()
// virtual vtkIdType GetVertex ()
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_GetVertex_0")] public static extern 
bool GetVertex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject);

// vtkIdType Next()
// vtkIdType Next()
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_Next_0")] public static extern 
bool Next_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject);

// bool HasNext()
// bool HasNext()
[DllImport("vtkplugin", EntryPoint="vtkAdjacentVertexIterator_HasNext_0")] public static extern 
bool HasNext_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkAdjacentVertexIterator*)*/ callingObject);

}
};
