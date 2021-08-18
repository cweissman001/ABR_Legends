
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkPropCollection {

// static vtkPropCollection* New()
// static vtkPropCollection *New()
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkPropCollection*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkPropCollection*)*/ callingObject, string /*(char*)*/ type);

// static vtkPropCollection* SafeDownCast(vtkObjectBase * o)
// static vtkPropCollection* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkPropCollection*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkPropCollection* NewInstance()
// vtkPropCollection *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkPropCollection*)*/ return_value, IntPtr /*(vtkPropCollection*)*/ callingObject);

// void AddItem(vtkProp * a)
// void AddItem(vtkProp *a)
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_AddItem_0")] public static extern 
bool AddItem_0(IntPtr /*(vtkPropCollection*)*/ callingObject, IntPtr /*(vtkProp*)*/ a);

// vtkProp* GetNextProp()
// vtkProp *GetNextProp()
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_GetNextProp_0")] public static extern 
bool GetNextProp_0(out IntPtr /*(vtkProp*)*/ return_value, IntPtr /*(vtkPropCollection*)*/ callingObject);

// vtkProp* GetLastProp()
// vtkProp *GetLastProp()
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_GetLastProp_0")] public static extern 
bool GetLastProp_0(out IntPtr /*(vtkProp*)*/ return_value, IntPtr /*(vtkPropCollection*)*/ callingObject);

// int GetNumberOfPaths()
// int GetNumberOfPaths()
[DllImport("vtkplugin", EntryPoint="vtkPropCollection_GetNumberOfPaths_0")] public static extern 
bool GetNumberOfPaths_0(out int /*(int)*/ return_value, IntPtr /*(vtkPropCollection*)*/ callingObject);

}
};
