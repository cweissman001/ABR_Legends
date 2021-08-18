
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkTriangleFilter {

// static vtkTriangleFilter* New()
// static vtkTriangleFilter *New()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkTriangleFilter*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkTriangleFilter*)*/ callingObject, string /*(char*)*/ type);

// static vtkTriangleFilter* SafeDownCast(vtkObjectBase * o)
// static vtkTriangleFilter* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkTriangleFilter*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkTriangleFilter* NewInstance()
// vtkTriangleFilter *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkTriangleFilter*)*/ return_value, IntPtr /*(vtkTriangleFilter*)*/ callingObject);

// virtual void PassVertsOn()
// virtual void PassVertsOn ()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_PassVertsOn_0")] public static extern 
bool PassVertsOn_0(IntPtr /*(vtkTriangleFilter*)*/ callingObject);

// virtual void PassVertsOff()
// virtual void PassVertsOff ()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_PassVertsOff_0")] public static extern 
bool PassVertsOff_0(IntPtr /*(vtkTriangleFilter*)*/ callingObject);

// virtual void SetPassVerts(vtkTypeBool _arg)
// virtual void SetPassVerts (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_SetPassVerts_0")] public static extern 
bool SetPassVerts_0(IntPtr /*(vtkTriangleFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetPassVerts()
// virtual vtkTypeBool GetPassVerts ()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_GetPassVerts_0")] public static extern 
bool GetPassVerts_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkTriangleFilter*)*/ callingObject);

// virtual void PassLinesOn()
// virtual void PassLinesOn ()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_PassLinesOn_0")] public static extern 
bool PassLinesOn_0(IntPtr /*(vtkTriangleFilter*)*/ callingObject);

// virtual void PassLinesOff()
// virtual void PassLinesOff ()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_PassLinesOff_0")] public static extern 
bool PassLinesOff_0(IntPtr /*(vtkTriangleFilter*)*/ callingObject);

// virtual void SetPassLines(vtkTypeBool _arg)
// virtual void SetPassLines (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_SetPassLines_0")] public static extern 
bool SetPassLines_0(IntPtr /*(vtkTriangleFilter*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetPassLines()
// virtual vtkTypeBool GetPassLines ()
[DllImport("vtkplugin", EntryPoint="vtkTriangleFilter_GetPassLines_0")] public static extern 
bool GetPassLines_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkTriangleFilter*)*/ callingObject);

}
};
