
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkVertexListIterator {

// static vtkVertexListIterator* New()
// static vtkVertexListIterator *New()
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkVertexListIterator*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkVertexListIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkVertexListIterator* SafeDownCast(vtkObjectBase * o)
// static vtkVertexListIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkVertexListIterator*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkVertexListIterator* NewInstance()
// vtkVertexListIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkVertexListIterator*)*/ return_value, IntPtr /*(vtkVertexListIterator*)*/ callingObject);

// virtual void SetGraph(vtkGraph * graph)
// virtual void SetGraph(vtkGraph *graph)
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_SetGraph_0")] public static extern 
bool SetGraph_0(IntPtr /*(vtkVertexListIterator*)*/ callingObject, IntPtr /*(vtkGraph*)*/ graph);

// virtual vtkGraph* GetGraph()
// virtual vtkGraph *GetGraph ()
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_GetGraph_0")] public static extern 
bool GetGraph_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkVertexListIterator*)*/ callingObject);

// vtkIdType Next()
// vtkIdType Next()
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_Next_0")] public static extern 
bool Next_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkVertexListIterator*)*/ callingObject);

// bool HasNext()
// bool HasNext()
[DllImport("vtkplugin", EntryPoint="vtkVertexListIterator_HasNext_0")] public static extern 
bool HasNext_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkVertexListIterator*)*/ callingObject);

}
};
