
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkUnstructuredGridBase {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, string /*(char*)*/ type);

// static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase * o)
// static vtkUnstructuredGridBase* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkUnstructuredGridBase*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkUnstructuredGridBase* NewInstance()
// vtkUnstructuredGridBase *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkUnstructuredGridBase*)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(out int /*(int)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_Allocate_0")] public static extern 
bool Allocate_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetIdsOfCellsOfType_0")] public static extern 
bool GetIdsOfCellsOfType_0(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdTypeArray*)*/ array);

// virtual int IsHomogeneous()
// virtual int IsHomogeneous()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsHomogeneous_0")] public static extern 
bool IsHomogeneous_0(out int /*(int)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetDataObjectType_1")] public static extern 
bool GetDataObjectType_1(out int /*(int)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

// virtual void Allocate(vtkIdType numCells = 1000, int extSize = 1000)
// virtual void Allocate(vtkIdType numCells=1000, int extSize=1000)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_Allocate_1")] public static extern 
bool Allocate_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, long /*(vtkIdType)*/ numCells, int /*(int)*/ extSize);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_DeepCopy_1")] public static extern 
bool DeepCopy_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray * array)
// virtual void GetIdsOfCellsOfType(int type, vtkIdTypeArray *array)
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_GetIdsOfCellsOfType_1")] public static extern 
bool GetIdsOfCellsOfType_1(IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject, int /*(int)*/ type, IntPtr /*(vtkIdTypeArray*)*/ array);

// virtual int IsHomogeneous()
// virtual int IsHomogeneous()
[DllImport("vtkplugin", EntryPoint="vtkUnstructuredGridBase_IsHomogeneous_1")] public static extern 
bool IsHomogeneous_1(out int /*(int)*/ return_value, IntPtr /*(vtkUnstructuredGridBase*)*/ callingObject);

}
};
