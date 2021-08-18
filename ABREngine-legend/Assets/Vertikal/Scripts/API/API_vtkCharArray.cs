
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkCharArray {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCharArray_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkCharArray_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkCharArray*)*/ callingObject, string /*(char*)*/ type);

// static vtkCharArray* SafeDownCast(vtkObjectBase * o)
// static vtkCharArray* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkCharArray_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkCharArray*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkCharArray* NewInstance()
// vtkCharArray *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkCharArray_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkCharArray*)*/ return_value, IntPtr /*(vtkCharArray*)*/ callingObject);

// static vtkCharArray* New()
// static vtkCharArray* New()
[DllImport("vtkplugin", EntryPoint="vtkCharArray_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkCharArray*)*/ return_value);

// static vtkCharArray* FastDownCast(vtkAbstractArray * source)
// static vtkCharArray* FastDownCast(vtkAbstractArray *source)
[DllImport("vtkplugin", EntryPoint="vtkCharArray_FastDownCast_0")] public static extern 
bool FastDownCast_0(out IntPtr /*(vtkCharArray*)*/ return_value, IntPtr /*(vtkAbstractArray*)*/ source);

// static char GetDataTypeValueMin()
// static char GetDataTypeValueMin()
[DllImport("vtkplugin", EntryPoint="vtkCharArray_GetDataTypeValueMin_0")] public static extern 
bool GetDataTypeValueMin_0(out char /*(char)*/ return_value);

// static char GetDataTypeValueMax()
// static char GetDataTypeValueMax()
[DllImport("vtkplugin", EntryPoint="vtkCharArray_GetDataTypeValueMax_0")] public static extern 
bool GetDataTypeValueMax_0(out char /*(char)*/ return_value);

}
};
