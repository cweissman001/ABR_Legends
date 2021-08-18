
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkTable {

// static vtkTable* New()
// static vtkTable* New()
[DllImport("vtkplugin", EntryPoint="vtkTable_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkTable*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTable_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkTable_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject, string /*(char*)*/ type);

// static vtkTable* SafeDownCast(vtkObjectBase * o)
// static vtkTable* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkTable_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkTable*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkTable* NewInstance()
// vtkTable *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkTable_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkTable*)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject);

// int GetDataObjectType()
// int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkTable_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(out int /*(int)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject);

// long GetActualMemorySize()
// unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkTable_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(out ulong /*(unsigned long)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject);

// virtual vtkDataSetAttributes* GetRowData()
// virtual vtkDataSetAttributes *GetRowData ()
[DllImport("vtkplugin", EntryPoint="vtkTable_GetRowData_0")] public static extern 
bool GetRowData_0(out IntPtr /*(vtkDataSetAttributes*)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject);

// virtual void SetRowData(vtkDataSetAttributes * data)
// virtual void SetRowData(vtkDataSetAttributes* data)
[DllImport("vtkplugin", EntryPoint="vtkTable_SetRowData_0")] public static extern 
bool SetRowData_0(IntPtr /*(vtkTable*)*/ callingObject, IntPtr /*(vtkDataSetAttributes*)*/ data);

// vtkIdType GetNumberOfRows()
// vtkIdType GetNumberOfRows()
[DllImport("vtkplugin", EntryPoint="vtkTable_GetNumberOfRows_0")] public static extern 
bool GetNumberOfRows_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject);

// void SetNumberOfRows(const vtkIdType ARG_0)
// void SetNumberOfRows(const vtkIdType )
[DllImport("vtkplugin", EntryPoint="vtkTable_SetNumberOfRows_0")] public static extern 
bool SetNumberOfRows_0(IntPtr /*(vtkTable*)*/ callingObject, long /*(vtkIdType)*/ ARG_0);

// void RemoveRow(vtkIdType row)
// void RemoveRow(vtkIdType row)
[DllImport("vtkplugin", EntryPoint="vtkTable_RemoveRow_0")] public static extern 
bool RemoveRow_0(IntPtr /*(vtkTable*)*/ callingObject, long /*(vtkIdType)*/ row);

// vtkIdType GetNumberOfColumns()
// vtkIdType GetNumberOfColumns()
[DllImport("vtkplugin", EntryPoint="vtkTable_GetNumberOfColumns_0")] public static extern 
bool GetNumberOfColumns_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject);

// char* GetColumnName(vtkIdType col)
// const char* GetColumnName(vtkIdType col)
[DllImport("vtkplugin", EntryPoint="vtkTable_GetColumnName_0")] public static extern 
bool GetColumnName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject, long /*(vtkIdType)*/ col);

// vtkAbstractArray* GetColumnByName(const char * name)
// vtkAbstractArray* GetColumnByName(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkTable_GetColumnByName_0")] public static extern 
bool GetColumnByName_0(out IntPtr /*(vtkAbstractArray*)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject, string /*(char*)*/ name);

// vtkAbstractArray* GetColumn(vtkIdType col)
// vtkAbstractArray* GetColumn(vtkIdType col)
[DllImport("vtkplugin", EntryPoint="vtkTable_GetColumn_0")] public static extern 
bool GetColumn_0(out IntPtr /*(vtkAbstractArray*)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject, long /*(vtkIdType)*/ col);

// void AddColumn(vtkAbstractArray * arr)
// void AddColumn(vtkAbstractArray* arr)
[DllImport("vtkplugin", EntryPoint="vtkTable_AddColumn_0")] public static extern 
bool AddColumn_0(IntPtr /*(vtkTable*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ arr);

// void RemoveColumnByName(const char * name)
// void RemoveColumnByName(const char* name)
[DllImport("vtkplugin", EntryPoint="vtkTable_RemoveColumnByName_0")] public static extern 
bool RemoveColumnByName_0(IntPtr /*(vtkTable*)*/ callingObject, string /*(char*)*/ name);

// void RemoveColumn(vtkIdType col)
// void RemoveColumn(vtkIdType col)
[DllImport("vtkplugin", EntryPoint="vtkTable_RemoveColumn_0")] public static extern 
bool RemoveColumn_0(IntPtr /*(vtkTable*)*/ callingObject, long /*(vtkIdType)*/ col);

// void Initialize()
// void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkTable_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkTable*)*/ callingObject);

// void ShallowCopy(vtkDataObject * src)
// void ShallowCopy(vtkDataObject* src)
[DllImport("vtkplugin", EntryPoint="vtkTable_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkTable*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// void DeepCopy(vtkDataObject * src)
// void DeepCopy(vtkDataObject* src)
[DllImport("vtkplugin", EntryPoint="vtkTable_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkTable*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// vtkFieldData* GetAttributesAsFieldData(int type)
// vtkFieldData* GetAttributesAsFieldData(int type)
[DllImport("vtkplugin", EntryPoint="vtkTable_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData_0(out IntPtr /*(vtkFieldData*)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject, int /*(int)*/ type);

// vtkIdType GetNumberOfElements(int type)
// vtkIdType GetNumberOfElements(int type)
[DllImport("vtkplugin", EntryPoint="vtkTable_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkTable*)*/ callingObject, int /*(int)*/ type);

}
};
