
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUnstructuredGridReader {

// static vtkUnstructuredGridReader* New()
// static vtkUnstructuredGridReader *New()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkUnstructuredGridReader*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkUnstructuredGridReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkUnstructuredGridReader* SafeDownCast(vtkObjectBase * o)
// static vtkUnstructuredGridReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkUnstructuredGridReader*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkUnstructuredGridReader* NewInstance()
// vtkUnstructuredGridReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkUnstructuredGridReader*)*/ return_value, IntPtr /*(vtkUnstructuredGridReader*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput()
// vtkUnstructuredGrid *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_GetOutput_0")] public static extern 
bool GetOutput_0(out IntPtr /*(vtkUnstructuredGrid*)*/ return_value, IntPtr /*(vtkUnstructuredGridReader*)*/ callingObject);

// vtkUnstructuredGrid* GetOutput(int idx)
// vtkUnstructuredGrid *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_GetOutput_1")] public static extern 
bool GetOutput_1(out IntPtr /*(vtkUnstructuredGrid*)*/ return_value, IntPtr /*(vtkUnstructuredGridReader*)*/ callingObject, int /*(int)*/ idx);

// void SetOutput(vtkUnstructuredGrid * output)
// void SetOutput(vtkUnstructuredGrid *output)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridReader_SetOutput_0")] public static extern 
bool SetOutput_0(IntPtr /*(vtkUnstructuredGridReader*)*/ callingObject, IntPtr /*(vtkUnstructuredGrid*)*/ output);

}
};
