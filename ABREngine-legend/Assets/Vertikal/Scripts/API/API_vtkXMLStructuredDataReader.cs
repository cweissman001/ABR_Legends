
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkXMLStructuredDataReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase * o)
// static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkXMLStructuredDataReader*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkXMLStructuredDataReader* NewInstance()
// vtkXMLStructuredDataReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkXMLStructuredDataReader*)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfPoints()
// vtkIdType GetNumberOfPoints()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_GetNumberOfPoints_0")] public static extern 
bool GetNumberOfPoints_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// vtkIdType GetNumberOfCells()
// vtkIdType GetNumberOfCells()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_GetNumberOfCells_0")] public static extern 
bool GetNumberOfCells_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// virtual void SetWholeSlices(vtkTypeBool _arg)
// virtual void SetWholeSlices (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_SetWholeSlices_0")] public static extern 
bool SetWholeSlices_0(IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetWholeSlices()
// virtual vtkTypeBool GetWholeSlices ()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_GetWholeSlices_0")] public static extern 
bool GetWholeSlices_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// virtual void WholeSlicesOn()
// virtual void WholeSlicesOn ()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_WholeSlicesOn_0")] public static extern 
bool WholeSlicesOn_0(IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

// virtual void WholeSlicesOff()
// virtual void WholeSlicesOff ()
[DllImport("vtkplugin", EntryPoint="vtkXMLStructuredDataReader_WholeSlicesOff_0")] public static extern 
bool WholeSlicesOff_0(IntPtr /*(vtkXMLStructuredDataReader*)*/ callingObject);

}
};
