
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLImageDataReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkXMLImageDataReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLImageDataReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLImageDataReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkXMLImageDataReader*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLImageDataReader* NewInstance()
// vtkXMLImageDataReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkXMLImageDataReader*)*/ return_value, IntPtr /*(vtkXMLImageDataReader*)*/ callingObject);

// static vtkXMLImageDataReader* New()
// static vtkXMLImageDataReader *New()
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkXMLImageDataReader*)*/ return_value);

// vtkImageData* GetOutput()
// vtkImageData *GetOutput()
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_GetOutput_0")] public static extern 
bool GetOutput_0(out IntPtr /*(vtkImageData*)*/ return_value, IntPtr /*(vtkXMLImageDataReader*)*/ callingObject);

// vtkImageData* GetOutput(int idx)
// vtkImageData *GetOutput(int idx)
[DllImport("vtkplugin", EntryPoint="vtkXMLImageDataReader_GetOutput_1")] public static extern 
bool GetOutput_1(out IntPtr /*(vtkImageData*)*/ return_value, IntPtr /*(vtkXMLImageDataReader*)*/ callingObject, int /*(int)*/ idx);

}
};
