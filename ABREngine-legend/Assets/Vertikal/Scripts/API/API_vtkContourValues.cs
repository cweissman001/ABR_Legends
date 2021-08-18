
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkContourValues {

// static vtkContourValues* New()
// static vtkContourValues *New()
[DllImport("vtkplugin", EntryPoint="vtkContourValues_New_0")] public static extern 
bool New_0(IntPtr /*(IntPtr**)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(IntPtr /*(IntPtr*)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_IsA_0")] public static extern 
bool IsA_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkContourValues*)*/ callingObject, string /*(char*)*/ type);

// static vtkContourValues* SafeDownCast(vtkObjectBase * o)
// static vtkContourValues* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkContourValues* NewInstance()
// vtkContourValues *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkContourValues_NewInstance_0")] public static extern 
bool NewInstance_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkContourValues*)*/ callingObject);

// void SetValue(int i, double value)
// void SetValue(int i, double value)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_SetValue_0")] public static extern 
bool SetValue_0(IntPtr /*(vtkContourValues*)*/ callingObject, int /*(int)*/ i, double /*(double)*/ value);

// double GetValue(int i)
// double GetValue(int i)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_GetValue_0")] public static extern 
bool GetValue_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkContourValues*)*/ callingObject, int /*(int)*/ i);

// double* GetValues()
// double *GetValues()
[DllImport("vtkplugin", EntryPoint="vtkContourValues_GetValues_0")] public static extern 
bool GetValues_0(IntPtr /*(IntPtr**)*/ return_value, IntPtr /*(vtkContourValues*)*/ callingObject);

// void GetValues(double * contourValues)
// void GetValues(double *contourValues)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_GetValues_1")] public static extern 
bool GetValues_1(IntPtr /*(vtkContourValues*)*/ callingObject, IntPtr /*(double*)*/ contourValues);

// void SetNumberOfContours(const int number)
// void SetNumberOfContours(const int number)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_SetNumberOfContours_0")] public static extern 
bool SetNumberOfContours_0(IntPtr /*(vtkContourValues*)*/ callingObject, int /*(int)*/ number);

// int GetNumberOfContours()
// int GetNumberOfContours()
[DllImport("vtkplugin", EntryPoint="vtkContourValues_GetNumberOfContours_0")] public static extern 
bool GetNumberOfContours_0(IntPtr /*(IntPtr*)*/ return_value, IntPtr /*(vtkContourValues*)*/ callingObject);

// void GenerateValues(int numContours, double range[2])
// void GenerateValues(int numContours, double range[2])
[DllImport("vtkplugin", EntryPoint="vtkContourValues_GenerateValues_0")] public static extern 
bool GenerateValues_0(IntPtr /*(vtkContourValues*)*/ callingObject, int /*(int)*/ numContours, double /*(double[2])*/ []range);

// void GenerateValues(int numContours, double rangeStart, double rangeEnd)
// void GenerateValues(int numContours, double rangeStart, double rangeEnd)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_GenerateValues_1")] public static extern 
bool GenerateValues_1(IntPtr /*(vtkContourValues*)*/ callingObject, int /*(int)*/ numContours, double /*(double)*/ rangeStart, double /*(double)*/ rangeEnd);

// void DeepCopy(vtkContourValues * other)
// void DeepCopy(vtkContourValues* other)
[DllImport("vtkplugin", EntryPoint="vtkContourValues_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkContourValues*)*/ callingObject, IntPtr /*(vtkContourValues*)*/ other);

}
};
