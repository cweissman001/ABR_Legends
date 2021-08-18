
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkEdgeListIterator {

// static vtkEdgeListIterator* New()
// static vtkEdgeListIterator *New()
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkEdgeListIterator*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkEdgeListIterator*)*/ callingObject, string /*(char*)*/ type);

// static vtkEdgeListIterator* SafeDownCast(vtkObjectBase * o)
// static vtkEdgeListIterator* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkEdgeListIterator*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkEdgeListIterator* NewInstance()
// vtkEdgeListIterator *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkEdgeListIterator*)*/ return_value, IntPtr /*(vtkEdgeListIterator*)*/ callingObject);

// virtual vtkGraph* GetGraph()
// virtual vtkGraph *GetGraph ()
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_GetGraph_0")] public static extern 
bool GetGraph_0(out IntPtr /*(vtkGraph*)*/ return_value, IntPtr /*(vtkEdgeListIterator*)*/ callingObject);

// virtual void SetGraph(vtkGraph * graph)
// virtual void SetGraph(vtkGraph *graph)
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_SetGraph_0")] public static extern 
bool SetGraph_0(IntPtr /*(vtkEdgeListIterator*)*/ callingObject, IntPtr /*(vtkGraph*)*/ graph);

// vtkGraphEdge* NextGraphEdge()
// vtkGraphEdge *NextGraphEdge()
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_NextGraphEdge_0")] public static extern 
bool NextGraphEdge_0(out IntPtr /*(vtkGraphEdge*)*/ return_value, IntPtr /*(vtkEdgeListIterator*)*/ callingObject);

// bool HasNext()
// bool HasNext()
[DllImport("vtkplugin", EntryPoint="vtkEdgeListIterator_HasNext_0")] public static extern 
bool HasNext_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkEdgeListIterator*)*/ callingObject);

}
};
