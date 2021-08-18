
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkGraphInternals {

// static vtkGraphInternals* New()
// static vtkGraphInternals *New()
[DllImport("vtkplugin", EntryPoint="vtkGraphInternals_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkGraphInternals*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGraphInternals_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkGraphInternals_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkGraphInternals*)*/ callingObject, string /*(char*)*/ type);

// static vtkGraphInternals* SafeDownCast(vtkObjectBase * o)
// static vtkGraphInternals* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkGraphInternals_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkGraphInternals*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkGraphInternals* NewInstance()
// vtkGraphInternals *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkGraphInternals_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkGraphInternals*)*/ return_value, IntPtr /*(vtkGraphInternals*)*/ callingObject);

}
};
