
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataObject {

// static vtkDataObject* New()
// static vtkDataObject *New()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkDataObject*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataObject* SafeDownCast(vtkObjectBase * o)
// static vtkDataObject* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkDataObject*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataObject* NewInstance()
// vtkDataObject *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkDataObject*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// vtkMTimeType GetMTime()
// vtkMTimeType GetMTime()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetMTime_0")] public static extern 
bool GetMTime_0(out ulong /*(vtkMTimeType)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void Initialize()
// virtual void Initialize()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_Initialize_0")] public static extern 
bool Initialize_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// void ReleaseData()
// void ReleaseData()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ReleaseData_0")] public static extern 
bool ReleaseData_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual int GetDataReleased()
// virtual int GetDataReleased ()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetDataReleased_0")] public static extern 
bool GetDataReleased_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// static void SetGlobalReleaseDataFlag(int val)
// static void SetGlobalReleaseDataFlag(int val)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetGlobalReleaseDataFlag_0")] public static extern 
bool SetGlobalReleaseDataFlag_0(int /*(int)*/ val);

// void GlobalReleaseDataFlagOn()
// void GlobalReleaseDataFlagOn()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GlobalReleaseDataFlagOn_0")] public static extern 
bool GlobalReleaseDataFlagOn_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// void GlobalReleaseDataFlagOff()
// void GlobalReleaseDataFlagOff()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GlobalReleaseDataFlagOff_0")] public static extern 
bool GlobalReleaseDataFlagOff_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// static int GetGlobalReleaseDataFlag()
// static int GetGlobalReleaseDataFlag()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetGlobalReleaseDataFlag_0")] public static extern 
bool GetGlobalReleaseDataFlag_0(out int /*(int)*/ return_value);

// virtual void SetFieldData(vtkFieldData * ARG_0)
// virtual void SetFieldData(vtkFieldData*)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_SetFieldData_0")] public static extern 
bool SetFieldData_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkFieldData*)*/ ARG_0);

// virtual vtkFieldData* GetFieldData()
// virtual vtkFieldData *GetFieldData ()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetFieldData_0")] public static extern 
bool GetFieldData_0(out IntPtr /*(vtkFieldData*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual int GetDataObjectType()
// virtual int GetDataObjectType()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetDataObjectType_0")] public static extern 
bool GetDataObjectType_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// vtkMTimeType GetUpdateTime()
// vtkMTimeType GetUpdateTime()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetUpdateTime_0")] public static extern 
bool GetUpdateTime_0(out ulong /*(vtkMTimeType)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual long GetActualMemorySize()
// virtual unsigned long GetActualMemorySize()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetActualMemorySize_0")] public static extern 
bool GetActualMemorySize_0(out ulong /*(unsigned long)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// void DataHasBeenGenerated()
// void DataHasBeenGenerated()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DataHasBeenGenerated_0")] public static extern 
bool DataHasBeenGenerated_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void PrepareForNewData()
// virtual void PrepareForNewData()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_PrepareForNewData_0")] public static extern 
bool PrepareForNewData_0(IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void ShallowCopy(vtkDataObject * src)
// virtual void ShallowCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_ShallowCopy_0")] public static extern 
bool ShallowCopy_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual void DeepCopy(vtkDataObject * src)
// virtual void DeepCopy(vtkDataObject *src)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_DeepCopy_0")] public static extern 
bool DeepCopy_0(IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkDataObject*)*/ src);

// virtual int GetExtentType()
// virtual int GetExtentType()
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetExtentType_0")] public static extern 
bool GetExtentType_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject);

// virtual void Crop(const int * updateExtent)
// virtual void Crop(const int* updateExtent)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_Crop_0")] public static extern 
bool Crop_0(IntPtr /*(vtkDataObject*)*/ callingObject, int[] /*(int*)*/ updateExtent);

// virtual vtkDataSetAttributes* GetAttributes(int type)
// virtual vtkDataSetAttributes* GetAttributes(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributes_0")] public static extern 
bool GetAttributes_0(out IntPtr /*(vtkDataSetAttributes*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// virtual vtkFieldData* GetAttributesAsFieldData(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributesAsFieldData_0")] public static extern 
bool GetAttributesAsFieldData_0(out IntPtr /*(vtkFieldData*)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAttributeTypeForArray_0")] public static extern 
bool GetAttributeTypeForArray_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, IntPtr /*(vtkAbstractArray*)*/ arr);

// virtual vtkIdType GetNumberOfElements(int type)
// virtual vtkIdType GetNumberOfElements(int type)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetNumberOfElements_0")] public static extern 
bool GetNumberOfElements_0(out long /*(vtkIdType)*/ return_value, IntPtr /*(vtkDataObject*)*/ callingObject, int /*(int)*/ type);

// static char* GetAssociationTypeAsString(int associationType)
// static const char* GetAssociationTypeAsString(int associationType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAssociationTypeAsString_0")] public static extern 
bool GetAssociationTypeAsString_0(out byte[] /*(char*)*/ return_value, int /*(int)*/ associationType);

// static int GetAssociationTypeFromString(const char * associationType)
// static int GetAssociationTypeFromString(const char* associationType)
[DllImport("vtkplugin", EntryPoint="vtkDataObject_GetAssociationTypeFromString_0")] public static extern 
bool GetAssociationTypeFromString_0(out int /*(int)*/ return_value, string /*(char*)*/ associationType);

}
};
