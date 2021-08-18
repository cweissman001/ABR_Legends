
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGraphEdge {

// static vtkGraphEdge* New()
// static vtkGraphEdge *New()
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkGraphEdge*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGraphEdge*)*/ callingObject, string /*(char*)*/ type);

// static vtkGraphEdge* SafeDownCast(vtkObjectBase * o)
// static vtkGraphEdge* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkGraphEdge*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGraphEdge* NewInstance()
// vtkGraphEdge *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkGraphEdge*)*/ return_value, IntPtr /*(vtkGraphEdge*)*/ callingObject);

// virtual void SetSource(vtkIdType _arg)
// virtual void SetSource (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_SetSource_0")] public static extern 
bool SetSource_0(IntPtr /*(vtkGraphEdge*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetSource()
// virtual vtkIdType GetSource ()
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_GetSource_0")] public static extern 
bool GetSource_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraphEdge*)*/ callingObject);

// virtual void SetTarget(vtkIdType _arg)
// virtual void SetTarget (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_SetTarget_0")] public static extern 
bool SetTarget_0(IntPtr /*(vtkGraphEdge*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetTarget()
// virtual vtkIdType GetTarget ()
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_GetTarget_0")] public static extern 
bool GetTarget_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraphEdge*)*/ callingObject);

// virtual void SetId(vtkIdType _arg)
// virtual void SetId (vtkIdType _arg)
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_SetId_0")] public static extern 
bool SetId_0(IntPtr /*(vtkGraphEdge*)*/ callingObject, long /*(vtkIdType)*/ _arg);

// virtual vtkIdType GetId()
// virtual vtkIdType GetId ()
[DllImport("vtkplugin", EntryPoint="vtkGraphEdge_GetId_0")] public static extern 
bool GetId_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkGraphEdge*)*/ callingObject);

}
};
