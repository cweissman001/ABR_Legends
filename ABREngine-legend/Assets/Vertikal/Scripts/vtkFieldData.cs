

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFieldData : vtkObject {
		public vtkFieldData(IntPtr p) : base(p) {}
		public static implicit operator  vtkFieldData(IntPtr p) {return new vtkFieldData(p);}
		public static implicit operator  IntPtr(vtkFieldData o) {return o.GetPtr();}

// static vtkFieldData* New()
// "static vtkFieldData *New()"
public static vtkFieldData New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.New_0(out returnPointer);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFieldData.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFieldData.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkFieldData* SafeDownCast(vtkObjectBase * o)
// "static vtkFieldData* SafeDownCast(vtkObjectBase *o)"
public static vtkFieldData SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.SafeDownCast_0(out returnPointer, o);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// vtkFieldData* NewInstance()
// "vtkFieldData *NewInstance()"
public vtkFieldData NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.NewInstance_0(out returnPointer, this);
//	return (vtkFieldData)(IntPtr)returnPointer;
	return (vtkFieldData)(IntPtr)returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkFieldData.Initialize_0(this);
}


// vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext=1000)"
public bool Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFieldData.Allocate_0(out returnPointer, this, sz, ext);
//	return (bool)returnPointer;
	return returnPointer;
}


// void CopyStructure(vtkFieldData * ARG_0)
// "void CopyStructure(vtkFieldData*)"
public void CopyStructure(vtkFieldData /*(vtkFieldData*)*/ ARG_0) {
	VTK_API.API_vtkFieldData.CopyStructure_0(this, ARG_0);
}


// void AllocateArrays(int num)
// "void AllocateArrays(int num)"
public void AllocateArrays(int /*(int)*/ num) {
	VTK_API.API_vtkFieldData.AllocateArrays_0(this, num);
}


// int GetNumberOfArrays()
// "int GetNumberOfArrays()"
public int GetNumberOfArrays() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFieldData.GetNumberOfArrays_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int AddArray(vtkAbstractArray * array)
// "int AddArray(vtkAbstractArray *array)"
public int AddArray(vtkAbstractArray /*(vtkAbstractArray*)*/ array) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFieldData.AddArray_0(out returnPointer, this, array);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void RemoveArray(const char * name)
// "virtual void RemoveArray(const char *name)"
public void RemoveArray(string /*(char*)*/ name) {
	VTK_API.API_vtkFieldData.RemoveArray_0(this, name);
}


// virtual void RemoveArray(int index)
// "virtual void RemoveArray(int index)"
public void RemoveArray(int /*(int)*/ index) {
	VTK_API.API_vtkFieldData.RemoveArray_1(this, index);
}


// vtkDataArray* GetArray(int i)
// "vtkDataArray *GetArray(int i)"
public vtkDataArray GetArray(int /*(int)*/ i) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.GetArray_0(out returnPointer, this, i);
//	return (vtkDataArray)(IntPtr)returnPointer;
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetArray(const char * arrayName, int & index)
// "vtkDataArray *GetArray(const char *arrayName, int &index)"
public vtkDataArray GetArray(string /*(char*)*/ arrayName, IntPtr /*(int&)*/ index) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.GetArray_1(out returnPointer, this, arrayName, index);
//	return (vtkDataArray)(IntPtr)returnPointer;
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkDataArray* GetArray(const char * arrayName)
// "vtkDataArray *GetArray(const char *arrayName)"
public vtkDataArray GetArray(string /*(char*)*/ arrayName) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.GetArray_2(out returnPointer, this, arrayName);
//	return (vtkDataArray)(IntPtr)returnPointer;
	return (vtkDataArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractArray(int i)
// "vtkAbstractArray* GetAbstractArray(int i)"
public vtkAbstractArray GetAbstractArray(int /*(int)*/ i) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.GetAbstractArray_0(out returnPointer, this, i);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractArray(const char * arrayName, int & index)
// "vtkAbstractArray* GetAbstractArray(const char* arrayName, int &index)"
public vtkAbstractArray GetAbstractArray(string /*(char*)*/ arrayName, IntPtr /*(int&)*/ index) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.GetAbstractArray_1(out returnPointer, this, arrayName, index);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* GetAbstractArray(const char * arrayName)
// "vtkAbstractArray* GetAbstractArray(const char* arrayName)"
public vtkAbstractArray GetAbstractArray(string /*(char*)*/ arrayName) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFieldData.GetAbstractArray_2(out returnPointer, this, arrayName);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// int HasArray(const char * name)
// "int HasArray(const char *name)"
public int HasArray(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFieldData.HasArray_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// char* GetArrayName(int i)
// "const char* GetArrayName(int i)"
public string GetArrayName(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkFieldData.GetArrayName_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void PassData(vtkFieldData * fd)
// "virtual void PassData(vtkFieldData* fd)"
public void PassData(vtkFieldData /*(vtkFieldData*)*/ fd) {
	VTK_API.API_vtkFieldData.PassData_0(this, fd);
}


// void CopyFieldOn(const char * name)
// "void CopyFieldOn(const char* name)"
public void CopyFieldOn(string /*(char*)*/ name) {
	VTK_API.API_vtkFieldData.CopyFieldOn_0(this, name);
}


// void CopyFieldOff(const char * name)
// "void CopyFieldOff(const char* name)"
public void CopyFieldOff(string /*(char*)*/ name) {
	VTK_API.API_vtkFieldData.CopyFieldOff_0(this, name);
}


// virtual void CopyAllOn(int unused = 0)
// "virtual void CopyAllOn(int unused=0)"
public void CopyAllOn(int /*(int)*/ unused) {
	VTK_API.API_vtkFieldData.CopyAllOn_0(this, unused);
}


// virtual void CopyAllOff(int unused = 0)
// "virtual void CopyAllOff(int unused=0)"
public void CopyAllOff(int /*(int)*/ unused) {
	VTK_API.API_vtkFieldData.CopyAllOff_0(this, unused);
}


// virtual void DeepCopy(vtkFieldData * da)
// "virtual void DeepCopy(vtkFieldData *da)"
public void DeepCopy(vtkFieldData /*(vtkFieldData*)*/ da) {
	VTK_API.API_vtkFieldData.DeepCopy_0(this, da);
}


// virtual void ShallowCopy(vtkFieldData * da)
// "virtual void ShallowCopy(vtkFieldData *da)"
public void ShallowCopy(vtkFieldData /*(vtkFieldData*)*/ da) {
	VTK_API.API_vtkFieldData.ShallowCopy_0(this, da);
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkFieldData.Squeeze_0(this);
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkFieldData.Reset_0(this);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkFieldData.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkFieldData.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void GetField(vtkIdList * ptId, vtkFieldData * f)
// "void GetField(vtkIdList *ptId, vtkFieldData *f)"
public void GetField(vtkIdList /*(vtkIdList*)*/ ptId, vtkFieldData /*(vtkFieldData*)*/ f) {
	VTK_API.API_vtkFieldData.GetField_0(this, ptId, f);
}


// int GetArrayContainingComponent(int i, int & arrayComp)
// "int GetArrayContainingComponent(int i, int& arrayComp)"
public int GetArrayContainingComponent(int /*(int)*/ i, IntPtr /*(int&)*/ arrayComp) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFieldData.GetArrayContainingComponent_0(out returnPointer, this, i, arrayComp);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfComponents()
// "int GetNumberOfComponents()"
public int GetNumberOfComponents() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFieldData.GetNumberOfComponents_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfTuples()
// "vtkIdType GetNumberOfTuples()"
public long GetNumberOfTuples() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkFieldData.GetNumberOfTuples_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetNumberOfTuples(const vtkIdType number)
// "void SetNumberOfTuples(const vtkIdType number)"
public void SetNumberOfTuples(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkFieldData.SetNumberOfTuples_0(this, number);
}


// void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// "void SetTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)"
public void SetTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	VTK_API.API_vtkFieldData.SetTuple_0(this, i, j, source);
}


// void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData * source)
// "void InsertTuple(const vtkIdType i, const vtkIdType j, vtkFieldData* source)"
public void InsertTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
	VTK_API.API_vtkFieldData.InsertTuple_0(this, i, j, source);
}


// vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData * source)
// "vtkIdType InsertNextTuple(const vtkIdType j, vtkFieldData* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ j, vtkFieldData /*(vtkFieldData*)*/ source) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkFieldData.InsertNextTuple_0(out returnPointer, this, j, source);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
