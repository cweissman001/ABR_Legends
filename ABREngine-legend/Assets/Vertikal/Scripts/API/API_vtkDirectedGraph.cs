
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDirectedGraph {

// static vtkDirectedGraph* New()
// static vtkDirectedGraph *New()
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkDirectedGraph*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDirectedGraph*)*/ callingObject, string /*(char*)*/ type);

// static vtkDirectedGraph* SafeDownCast(vtkObjectBase * o)
// static vtkDirectedGraph* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkDirectedGraph*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDirectedGraph* NewInstance()
// vtkDirectedGraph *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkDirectedGraph*)*/ return_value, IntPtr /*(vtkDirectedGraph*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(out int /*(int)*/ return_value, IntPtr /*(vtkDirectedGraph*)*/ callingObject);

// bool IsStructureValid(vtkGraph * g)
// bool IsStructureValid(vtkGraph *g)
[DllImport("vtkplugin", EntryPoint="vtkDirectedGraph_IsStructureValid_0")] public static extern 
bool IsStructureValid_0(out bool /*(bool)*/ return_value, IntPtr /*(vtkDirectedGraph*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g);

}
};
