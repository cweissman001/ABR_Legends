

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataObject : vtkObject {
		public vtkDataObject(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataObject(IntPtr p) {return new vtkDataObject(p);}
		public static implicit operator  IntPtr(vtkDataObject o) {return o.GetPtr();}

// static vtkDataObject* New()
// "static vtkDataObject *New()"
public static vtkDataObject New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataObject.New_0(out returnPointer);
//	return (vtkDataObject)(IntPtr)returnPointer;
	return (vtkDataObject)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataObject.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataObject.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDataObject* SafeDownCast(vtkObjectBase * o)
// "static vtkDataObject* SafeDownCast(vtkObjectBase *o)"
public static vtkDataObject SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataObject.SafeDownCast_0(out returnPointer, o);
//	return (vtkDataObject)(IntPtr)returnPointer;
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* NewInstance()
// "vtkDataObject *NewInstance()"
public vtkDataObject NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataObject.NewInstance_0(out returnPointer, this);
//	return (vtkDataObject)(IntPtr)returnPointer;
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataObject.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkDataObject.Initialize_0(this);
}


// void ReleaseData()
// "void ReleaseData()"
public void ReleaseData() {
	VTK_API.API_vtkDataObject.ReleaseData_0(this);
}


// virtual int GetDataReleased()
// "virtual int GetDataReleased ()"
public int GetDataReleased() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataObject.GetDataReleased_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// static void SetGlobalReleaseDataFlag(int val)
// "static void SetGlobalReleaseDataFlag(int val)"
public static void SetGlobalReleaseDataFlag(int /*(int)*/ val) {
	VTK_API.API_vtkDataObject.SetGlobalReleaseDataFlag_0(val);
}


// void GlobalReleaseDataFlagOn()
// "void GlobalReleaseDataFlagOn()"
public void GlobalReleaseDataFlagOn() {
	VTK_API.API_vtkDataObject.GlobalReleaseDataFlagOn_0(this);
}


// void GlobalReleaseDataFlagOff()
// "void GlobalReleaseDataFlagOff()"
public void GlobalReleaseDataFlagOff() {
	VTK_API.API_vtkDataObject.GlobalReleaseDataFlagOff_0(this);
}


// static int GetGlobalReleaseDataFlag()
// "static int GetGlobalReleaseDataFlag()"
public static int GetGlobalReleaseDataFlag() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataObject.GetGlobalReleaseDataFlag_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetFieldData(vtkFieldData * ARG_0)
// "virtual void SetFieldData(vtkFieldData*)"
public void SetFieldData(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	VTK_API.API_vtkDataObject.SetFieldData_0(this, ARG_0);
}


// virtual vtkFieldData* GetFieldData()
// "virtual vtkFieldData *GetFieldData ()"
public vtkFieldData GetFieldData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataObject.GetFieldData_0(out returnPointer, this);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual int GetDataObjectType()
// "virtual int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataObject.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetUpdateTime()
// "vtkMTimeType GetUpdateTime()"
public ulong GetUpdateTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataObject.GetUpdateTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataObject.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void DataHasBeenGenerated()
// "void DataHasBeenGenerated()"
public void DataHasBeenGenerated() {
	VTK_API.API_vtkDataObject.DataHasBeenGenerated_0(this);
}


// virtual void PrepareForNewData()
// "virtual void PrepareForNewData()"
public void PrepareForNewData() {
	VTK_API.API_vtkDataObject.PrepareForNewData_0(this);
}


// virtual void ShallowCopy(vtkDataObject * src)
// "virtual void ShallowCopy(vtkDataObject *src)"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataObject.ShallowCopy_0(this, src);
}


// virtual void DeepCopy(vtkDataObject * src)
// "virtual void DeepCopy(vtkDataObject *src)"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ src) {
	VTK_API.API_vtkDataObject.DeepCopy_0(this, src);
}


// virtual int GetExtentType()
// "virtual int GetExtentType()"
public int GetExtentType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataObject.GetExtentType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void Crop(const int * updateExtent)
// "virtual void Crop(const int* updateExtent)"
public void Crop(int /*(int*)*/ []updateExtent) {
	VTK_API.API_vtkDataObject.Crop_0(this, updateExtent);
}


// virtual vtkDataSetAttributes* GetAttributes(int type)
// "virtual vtkDataSetAttributes* GetAttributes(int type)"
public vtkDataSetAttributes GetAttributes(int /*(int)*/ type) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataObject.GetAttributes_0(out returnPointer, this, type);
//	return (vtkDataSetAttributes)(IntPtr)returnPointer;
	return (vtkDataSetAttributes)(IntPtr)returnPointer;
}


// virtual vtkFieldData* GetAttributesAsFieldData(int type)
// "virtual vtkFieldData* GetAttributesAsFieldData(int type)"
public vtkFieldData GetAttributesAsFieldData(int /*(int)*/ type) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataObject.GetAttributesAsFieldData_0(out returnPointer, this, type);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual int GetAttributeTypeForArray(vtkAbstractArray * arr)
// "virtual int GetAttributeTypeForArray(vtkAbstractArray* arr)"
public int GetAttributeTypeForArray(vtkAbstractArray /*(vtkAbstractArray*)*/ arr) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataObject.GetAttributeTypeForArray_0(out returnPointer, this, arr);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfElements(int type)
// "virtual vtkIdType GetNumberOfElements(int type)"
public long GetNumberOfElements(int /*(int)*/ type) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkDataObject.GetNumberOfElements_0(out returnPointer, this, type);
//	return (long)returnPointer;
	return returnPointer;
}


// static char* GetAssociationTypeAsString(int associationType)
// "static const char* GetAssociationTypeAsString(int associationType)"
public static string GetAssociationTypeAsString(int /*(int)*/ associationType) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataObject.GetAssociationTypeAsString_0(out returnPointer, associationType);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// static int GetAssociationTypeFromString(const char * associationType)
// "static int GetAssociationTypeFromString(const char* associationType)"
public static int GetAssociationTypeFromString(string /*(char*)*/ associationType) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataObject.GetAssociationTypeFromString_0(out returnPointer, associationType);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
