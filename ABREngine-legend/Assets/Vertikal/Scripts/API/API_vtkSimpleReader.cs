
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkSimpleReader {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkSimpleReader* SafeDownCast(vtkObjectBase * o)
// static vtkSimpleReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkSimpleReader*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkSimpleReader* NewInstance()
// vtkSimpleReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkSimpleReader*)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject);

// void AddFileName(const char * fname)
// void AddFileName(const char* fname)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_AddFileName_0")] public static extern 
bool AddFileName_0(IntPtr /*(vtkSimpleReader*)*/ callingObject, string /*(char*)*/ fname);

// void ClearFileNames()
// void ClearFileNames()
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_ClearFileNames_0")] public static extern 
bool ClearFileNames_0(IntPtr /*(vtkSimpleReader*)*/ callingObject);

// int GetNumberOfFileNames()
// int GetNumberOfFileNames()
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_GetNumberOfFileNames_0")] public static extern 
bool GetNumberOfFileNames_0(out int /*(int)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject);

// char* GetFileName(int i)
// const char* GetFileName(int i)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_GetFileName_0")] public static extern 
bool GetFileName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject, int /*(int)*/ i);

// char* GetCurrentFileName()
// const char* GetCurrentFileName()
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_GetCurrentFileName_0")] public static extern 
bool GetCurrentFileName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject);

// int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// int ReadMesh( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_ReadMesh_0")] public static extern 
bool ReadMesh_0(out int /*(int)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

// int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// int ReadPoints( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_ReadPoints_0")] public static extern 
bool ReadPoints_0(out int /*(int)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

// int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// int ReadArrays( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkSimpleReader_ReadArrays_0")] public static extern 
bool ReadArrays_0(out int /*(int)*/ return_value, IntPtr /*(vtkSimpleReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

}
};
