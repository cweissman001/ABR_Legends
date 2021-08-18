
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDistributedGraphHelper {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject, string /*(char*)*/ type);

// static vtkDistributedGraphHelper* SafeDownCast(vtkObjectBase * o)
// static vtkDistributedGraphHelper* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkDistributedGraphHelper*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDistributedGraphHelper* NewInstance()
// vtkDistributedGraphHelper *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkDistributedGraphHelper*)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject);

// vtkIdType GetVertexOwner(vtkIdType v)
// vtkIdType GetVertexOwner(vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_GetVertexOwner_0")] public static extern 
bool GetVertexOwner_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject, long /*(vtkIdType)*/ v);

// vtkIdType GetVertexIndex(vtkIdType v)
// vtkIdType GetVertexIndex(vtkIdType v)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_GetVertexIndex_0")] public static extern 
bool GetVertexIndex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject, long /*(vtkIdType)*/ v);

// vtkIdType GetEdgeOwner(vtkIdType e_id)
// vtkIdType GetEdgeOwner(vtkIdType e_id)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_GetEdgeOwner_0")] public static extern 
bool GetEdgeOwner_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject, long /*(vtkIdType)*/ e_id);

// vtkIdType GetEdgeIndex(vtkIdType e_id)
// vtkIdType GetEdgeIndex(vtkIdType e_id)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_GetEdgeIndex_0")] public static extern 
bool GetEdgeIndex_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject, long /*(vtkIdType)*/ e_id);

// vtkIdType MakeDistributedId(int owner, vtkIdType local)
// vtkIdType MakeDistributedId(int owner, vtkIdType local)
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_MakeDistributedId_0")] public static extern 
bool MakeDistributedId_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject, int /*(int)*/ owner, long /*(vtkIdType)*/ local);

// virtual void Synchronize()
// virtual void Synchronize()
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_Synchronize_0")] public static extern 
bool Synchronize_0(IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject);

// virtual vtkDistributedGraphHelper* Clone()
// virtual vtkDistributedGraphHelper *Clone()
[DllImport("vtkplugin", EntryPoint="vtkDistributedGraphHelper_Clone_0")] public static extern 
bool Clone_0(out IntPtr /*(vtkDistributedGraphHelper*)*/ return_value, IntPtr /*(vtkDistributedGraphHelper*)*/ callingObject);

}
};
