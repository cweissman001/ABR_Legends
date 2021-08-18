
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkReaderAlgorithm {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkReaderAlgorithm*)*/ callingObject, string /*(char*)*/ type);

// static vtkReaderAlgorithm* SafeDownCast(vtkObjectBase * o)
// static vtkReaderAlgorithm* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkReaderAlgorithm*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkReaderAlgorithm* NewInstance()
// vtkReaderAlgorithm *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkReaderAlgorithm*)*/ return_value, IntPtr /*(vtkReaderAlgorithm*)*/ callingObject);

// virtual vtkDataObject* CreateOutput(vtkDataObject * currentOutput)
// virtual vtkDataObject* CreateOutput(vtkDataObject* currentOutput)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_CreateOutput_0")] public static extern 
bool CreateOutput_0(out IntPtr /*(vtkDataObject*)*/ return_value, IntPtr /*(vtkReaderAlgorithm*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ currentOutput);

// virtual int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// virtual int ReadMesh( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_ReadMesh_0")] public static extern 
bool ReadMesh_0(out int /*(int)*/ return_value, IntPtr /*(vtkReaderAlgorithm*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

// virtual int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// virtual int ReadPoints( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_ReadPoints_0")] public static extern 
bool ReadPoints_0(out int /*(int)*/ return_value, IntPtr /*(vtkReaderAlgorithm*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

// virtual int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// virtual int ReadArrays( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkReaderAlgorithm_ReadArrays_0")] public static extern 
bool ReadArrays_0(out int /*(int)*/ return_value, IntPtr /*(vtkReaderAlgorithm*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

}
};
