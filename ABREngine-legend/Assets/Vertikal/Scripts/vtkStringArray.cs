

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkStringArray : vtkAbstractArray {
		public vtkStringArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkStringArray(IntPtr p) {return new vtkStringArray(p);}
		public static implicit operator  IntPtr(vtkStringArray o) {return o.GetPtr();}

// static vtkStringArray* New()
// "static vtkStringArray* New()"
public static vtkStringArray New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStringArray.New_0(out returnPointer);
//	return (vtkStringArray)(IntPtr)returnPointer;
	return (vtkStringArray)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStringArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStringArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkStringArray* SafeDownCast(vtkObjectBase * o)
// "static vtkStringArray* SafeDownCast(vtkObjectBase *o)"
public static vtkStringArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStringArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkStringArray)(IntPtr)returnPointer;
	return (vtkStringArray)(IntPtr)returnPointer;
}


// vtkStringArray* NewInstance()
// "vtkStringArray *NewInstance()"
public vtkStringArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStringArray.NewInstance_0(out returnPointer, this);
//	return (vtkStringArray)(IntPtr)returnPointer;
	return (vtkStringArray)(IntPtr)returnPointer;
}


// int GetDataType()
// "int GetDataType()"
public int GetDataType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStringArray.GetDataType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsNumeric()
// "int IsNumeric()"
public int IsNumeric() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStringArray.IsNumeric_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkStringArray.Initialize_0(this);
}


// int GetDataTypeSize()
// "int GetDataTypeSize()"
public int GetDataTypeSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStringArray.GetDataTypeSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void Squeeze()
// "void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkStringArray.Squeeze_0(this);
}


// vtkTypeBool Resize(vtkIdType numTuples)
// "vtkTypeBool Resize(vtkIdType numTuples)"
public bool Resize(long /*(vtkIdType)*/ numTuples) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStringArray.Resize_0(out returnPointer, this, numTuples);
//	return (bool)returnPointer;
	return returnPointer;
}


// void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// "void SetTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)"
public void SetTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.SetTuple_0(this, i, j, source);
}


// void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray * source)
// "void InsertTuple(vtkIdType i, vtkIdType j, vtkAbstractArray* source)"
public void InsertTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.InsertTuple_0(this, i, j, source);
}


// void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray *source)"
public void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkStringArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray * source)
// "vtkIdType InsertNextTuple(vtkIdType j, vtkAbstractArray* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ j, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStringArray.InsertNextTuple_0(out returnPointer, this, j, source);
//	return (long)returnPointer;
	return returnPointer;
}


// void InterpolateTuple(vtkIdType i, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "void InterpolateTuple(vtkIdType i, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public void InterpolateTuple(long /*(vtkIdType)*/ i, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, double /*(double*)*/ []weights) {
	VTK_API.API_vtkStringArray.InterpolateTuple_0(this, i, ptIndices, source, weights);
}


// void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray * source1, vtkIdType id2, vtkAbstractArray * source2, double t)
// "void InterpolateTuple(vtkIdType i, vtkIdType id1, vtkAbstractArray* source1, vtkIdType id2, vtkAbstractArray* source2, double t)"
public void InterpolateTuple(long /*(vtkIdType)*/ i, long /*(vtkIdType)*/ id1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ id2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	VTK_API.API_vtkStringArray.InterpolateTuple_1(this, i, id1, source1, id2, source2, t);
}


// void GetTuples(vtkIdList * ptIds, vtkAbstractArray * output)
// "void GetTuples(vtkIdList *ptIds, vtkAbstractArray *output)"
public void GetTuples(vtkIdList /*(vtkIdList*)*/ ptIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkStringArray.GetTuples_0(this, ptIds, output);
}


// void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkStringArray.GetTuples_1(this, p1, p2, output);
}


// vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext=1000 )"
public bool Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkStringArray.Allocate_0(out returnPointer, this, sz, ext);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkStdString& GetValue(vtkIdType id)
// "vtkStdString &GetValue(vtkIdType id)"
public string GetValue(long /*(vtkIdType)*/ id) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkStringArray.GetValue_0(out returnPointer, this, id);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// void SetValue(vtkIdType id, vtkStdString value)
// "void SetValue(vtkIdType id, vtkStdString value)"
public void SetValue(long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ value) {
	VTK_API.API_vtkStringArray.SetValue_0(this, id, value);
}


// void SetNumberOfTuples(vtkIdType number)
// "void SetNumberOfTuples(vtkIdType number)"
public void SetNumberOfTuples(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkStringArray.SetNumberOfTuples_0(this, number);
}


// void SetNumberOfValues(vtkIdType number)
// "void SetNumberOfValues(vtkIdType number)"
public void SetNumberOfValues(long /*(vtkIdType)*/ number) {
	VTK_API.API_vtkStringArray.SetNumberOfValues_0(this, number);
}


// vtkIdType GetNumberOfValues()
// "vtkIdType GetNumberOfValues()"
public long GetNumberOfValues() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStringArray.GetNumberOfValues_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// int GetNumberOfElementComponents()
// "int GetNumberOfElementComponents()"
public int GetNumberOfElementComponents() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStringArray.GetNumberOfElementComponents_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetElementComponentSize()
// "int GetElementComponentSize()"
public int GetElementComponentSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkStringArray.GetElementComponentSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void InsertValue(vtkIdType id, vtkStdString f)
// "void InsertValue(vtkIdType id, vtkStdString f)"
public void InsertValue(long /*(vtkIdType)*/ id, string /*(vtkStdString)*/ f) {
	VTK_API.API_vtkStringArray.InsertValue_0(this, id, f);
}


// vtkIdType InsertNextValue(vtkStdString f)
// "vtkIdType InsertNextValue(vtkStdString f)"
public long InsertNextValue(string /*(vtkStdString)*/ f) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStringArray.InsertNextValue_0(out returnPointer, this, f);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkStdString* WritePointer(vtkIdType id, vtkIdType number)
// "vtkStdString* WritePointer(vtkIdType id, vtkIdType number)"
public string WritePointer(long /*(vtkIdType)*/ id, long /*(vtkIdType)*/ number) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkStringArray.WritePointer_0(out returnPointer, this, id, number);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// vtkStdString* GetPointer(vtkIdType id)
// "vtkStdString* GetPointer(vtkIdType id)"
public string GetPointer(long /*(vtkIdType)*/ id) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkStringArray.GetPointer_0(out returnPointer, this, id);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// void* GetVoidPointer(vtkIdType id)
// "void* GetVoidPointer(vtkIdType id)"
public IntPtr GetVoidPointer(long /*(vtkIdType)*/ id) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStringArray.GetVoidPointer_0(out returnPointer, this, id);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// void DeepCopy(vtkAbstractArray * aa)
// "void DeepCopy( vtkAbstractArray* aa )"
public void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ aa) {
	VTK_API.API_vtkStringArray.DeepCopy_0(this, aa);
}


// void SetVoidArray(void * array, vtkIdType size, int save)
// "void SetVoidArray(void* array, vtkIdType size, int save)"
public void SetVoidArray(IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save) {
	VTK_API.API_vtkStringArray.SetVoidArray_0(this, array, size, save);
}


// void SetVoidArray(void * array, vtkIdType size, int save, int deleteMethod)
// "void SetVoidArray(void* array, vtkIdType size, int save, int deleteMethod)"
public void SetVoidArray(IntPtr /*(void*)*/ array, long /*(vtkIdType)*/ size, int /*(int)*/ save, int /*(int)*/ deleteMethod) {
	VTK_API.API_vtkStringArray.SetVoidArray_1(this, array, size, save, deleteMethod);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkStringArray.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkArrayIterator* NewIterator()
// "vtkArrayIterator* NewIterator()"
public vtkArrayIterator NewIterator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkStringArray.NewIterator_0(out returnPointer, this);
//	return (vtkArrayIterator)(IntPtr)returnPointer;
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// vtkIdType GetDataSize()
// "vtkIdType GetDataSize()"
public long GetDataSize() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStringArray.GetDataSize_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType LookupValue(const vtkStdString & value)
// "vtkIdType LookupValue(const vtkStdString& value)"
public long LookupValue(string /*(vtkStdString&)*/ value) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkStringArray.LookupValue_0(out returnPointer, this, value);
//	return (long)returnPointer;
	return returnPointer;
}


// void LookupValue(const vtkStdString & value, vtkIdList * ids)
// "void LookupValue(const vtkStdString& value, vtkIdList* ids)"
public void LookupValue(string /*(vtkStdString&)*/ value, vtkIdList /*(vtkIdList*)*/ ids) {
	VTK_API.API_vtkStringArray.LookupValue_1(this, value, ids);
}


// void DataChanged()
// "void DataChanged()"
public void DataChanged() {
	VTK_API.API_vtkStringArray.DataChanged_0(this);
}


// virtual void DataElementChanged(vtkIdType id)
// "virtual void DataElementChanged(vtkIdType id)"
public void DataElementChanged(long /*(vtkIdType)*/ id) {
	VTK_API.API_vtkStringArray.DataElementChanged_0(this, id);
}


// void ClearLookup()
// "void ClearLookup()"
public void ClearLookup() {
	VTK_API.API_vtkStringArray.ClearLookup_0(this);
}


}
};
