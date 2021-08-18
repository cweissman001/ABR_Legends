

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractArray : vtkObject {
		public vtkAbstractArray(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractArray(IntPtr p) {return new vtkAbstractArray(p);}
		public static implicit operator  IntPtr(vtkAbstractArray o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractArray* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractArray* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractArray SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractArray.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// vtkAbstractArray* NewInstance()
// "vtkAbstractArray *NewInstance()"
public vtkAbstractArray NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractArray.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual vtkTypeBool Allocate(vtkIdType numValues, vtkIdType ext = 1000)
// "virtual vtkTypeBool Allocate(vtkIdType numValues, vtkIdType ext=1000)"
public bool Allocate(long /*(vtkIdType)*/ numValues, long /*(vtkIdType)*/ ext) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.Allocate_0(out returnPointer, this, numValues, ext);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkAbstractArray.Initialize_0(this);
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public int GetDataType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetDataType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetDataTypeSize()
// "virtual int GetDataTypeSize()"
public int GetDataTypeSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetDataTypeSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// static int GetDataTypeSize(int type)
// "static int GetDataTypeSize(int type)"
public static int GetDataTypeSize(int /*(int)*/ type) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetDataTypeSize_1(out returnPointer, type);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetElementComponentSize()
// "virtual int GetElementComponentSize()"
public int GetElementComponentSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetElementComponentSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetNumberOfComponents(int _arg)
// "virtual void SetNumberOfComponents (int _arg)"
public void SetNumberOfComponents(int /*(int)*/ _arg) {
	VTK_API.API_vtkAbstractArray.SetNumberOfComponents_0(this, _arg);
}


// virtual int GetNumberOfComponentsMinValue()
// "virtual int GetNumberOfComponentsMinValue ()"
public int GetNumberOfComponentsMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetNumberOfComponentsMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfComponentsMaxValue()
// "virtual int GetNumberOfComponentsMaxValue ()"
public int GetNumberOfComponentsMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetNumberOfComponentsMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfComponents()
// "int GetNumberOfComponents()"
public int GetNumberOfComponents() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetNumberOfComponents_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetComponentName(vtkIdType component, const char * name)
// "void SetComponentName( vtkIdType component, const char *name )"
public void SetComponentName(long /*(vtkIdType)*/ component, string /*(char*)*/ name) {
	VTK_API.API_vtkAbstractArray.SetComponentName_0(this, component, name);
}


// char* GetComponentName(vtkIdType component)
// "const char* GetComponentName( vtkIdType component )"
public string GetComponentName(long /*(vtkIdType)*/ component) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkAbstractArray.GetComponentName_0(out returnPointer, this, component);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// bool HasAComponentName()
// "bool HasAComponentName()"
public bool HasAComponentName() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.HasAComponentName_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// int CopyComponentNames(vtkAbstractArray * da)
// "int CopyComponentNames( vtkAbstractArray *da )"
public int CopyComponentNames(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.CopyComponentNames_0(out returnPointer, this, da);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetNumberOfTuples(vtkIdType numTuples)
// "virtual void SetNumberOfTuples(vtkIdType numTuples)"
public void SetNumberOfTuples(long /*(vtkIdType)*/ numTuples) {
	VTK_API.API_vtkAbstractArray.SetNumberOfTuples_0(this, numTuples);
}


// virtual void SetNumberOfValues(vtkIdType numValues)
// "virtual void SetNumberOfValues(vtkIdType numValues)"
public void SetNumberOfValues(long /*(vtkIdType)*/ numValues) {
	VTK_API.API_vtkAbstractArray.SetNumberOfValues_0(this, numValues);
}


// vtkIdType GetNumberOfTuples()
// "vtkIdType GetNumberOfTuples()"
public long GetNumberOfTuples() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractArray.GetNumberOfTuples_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual void SetTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray *source)"
public void SetTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.SetTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual void InsertTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public void InsertTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.InsertTuple_0(this, dstTupleIdx, srcTupleIdx, source);
}


// virtual void InsertTuples(vtkIdList * dstIds, vtkIdList * srcIds, vtkAbstractArray * source)
// "virtual void InsertTuples(vtkIdList *dstIds, vtkIdList *srcIds, vtkAbstractArray* source)"
public void InsertTuples(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.InsertTuples_0(this, dstIds, srcIds, source);
}


// virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray * source)
// "virtual void InsertTuples(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkAbstractArray* source)"
public void InsertTuples(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
	VTK_API.API_vtkAbstractArray.InsertTuples_1(this, dstStart, n, srcStart, source);
}


// virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray * source)
// "virtual vtkIdType InsertNextTuple(vtkIdType srcTupleIdx, vtkAbstractArray* source)"
public long InsertNextTuple(long /*(vtkIdType)*/ srcTupleIdx, vtkAbstractArray /*(vtkAbstractArray*)*/ source) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractArray.InsertNextTuple_0(out returnPointer, this, srcTupleIdx, source);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void GetTuples(vtkIdList * tupleIds, vtkAbstractArray * output)
// "virtual void GetTuples(vtkIdList *tupleIds, vtkAbstractArray* output)"
public void GetTuples(vtkIdList /*(vtkIdList*)*/ tupleIds, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkAbstractArray.GetTuples_0(this, tupleIds, output);
}


// virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray * output)
// "virtual void GetTuples(vtkIdType p1, vtkIdType p2, vtkAbstractArray *output)"
public void GetTuples(long /*(vtkIdType)*/ p1, long /*(vtkIdType)*/ p2, vtkAbstractArray /*(vtkAbstractArray*)*/ output) {
	VTK_API.API_vtkAbstractArray.GetTuples_1(this, p1, p2, output);
}


// virtual bool HasStandardMemoryLayout()
// "virtual bool HasStandardMemoryLayout()"
public bool HasStandardMemoryLayout() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.HasStandardMemoryLayout_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void* GetVoidPointer(vtkIdType valueIdx)
// "virtual void *GetVoidPointer(vtkIdType valueIdx)"
public IntPtr GetVoidPointer(long /*(vtkIdType)*/ valueIdx) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractArray.GetVoidPointer_0(out returnPointer, this, valueIdx);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void DeepCopy(vtkAbstractArray * da)
// "virtual void DeepCopy(vtkAbstractArray* da)"
public void DeepCopy(vtkAbstractArray /*(vtkAbstractArray*)*/ da) {
	VTK_API.API_vtkAbstractArray.DeepCopy_0(this, da);
}


// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList * ptIndices, vtkAbstractArray * source, double * weights)
// "virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdList *ptIndices, vtkAbstractArray* source, double* weights)"
public void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, vtkIdList /*(vtkIdList*)*/ ptIndices, vtkAbstractArray /*(vtkAbstractArray*)*/ source, double /*(double*)*/ []weights) {
	VTK_API.API_vtkAbstractArray.InterpolateTuple_0(this, dstTupleIdx, ptIndices, source, weights);
}


// virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray * source1, vtkIdType srcTupleIdx2, vtkAbstractArray * source2, double t)
// "virtual void InterpolateTuple(vtkIdType dstTupleIdx, vtkIdType srcTupleIdx1, vtkAbstractArray* source1, vtkIdType srcTupleIdx2, vtkAbstractArray* source2, double t)"
public void InterpolateTuple(long /*(vtkIdType)*/ dstTupleIdx, long /*(vtkIdType)*/ srcTupleIdx1, vtkAbstractArray /*(vtkAbstractArray*)*/ source1, long /*(vtkIdType)*/ srcTupleIdx2, vtkAbstractArray /*(vtkAbstractArray*)*/ source2, double /*(double)*/ t) {
	VTK_API.API_vtkAbstractArray.InterpolateTuple_1(this, dstTupleIdx, srcTupleIdx1, source1, srcTupleIdx2, source2, t);
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkAbstractArray.Squeeze_0(this);
}


// virtual vtkTypeBool Resize(vtkIdType numTuples)
// "virtual vtkTypeBool Resize(vtkIdType numTuples)"
public bool Resize(long /*(vtkIdType)*/ numTuples) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.Resize_0(out returnPointer, this, numTuples);
//	return (bool)returnPointer;
	return returnPointer;
}


// void Reset()
// "void Reset()"
public void Reset() {
	VTK_API.API_vtkAbstractArray.Reset_0(this);
}


// vtkIdType GetSize()
// "vtkIdType GetSize()"
public long GetSize() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractArray.GetSize_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetMaxId()
// "vtkIdType GetMaxId()"
public long GetMaxId() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractArray.GetMaxId_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetVoidArray(void * ARG_0, vtkIdType ARG_1, int ARG_2)
// "virtual void SetVoidArray(void *, vtkIdType , int )"
public void SetVoidArray(IntPtr /*(void*)*/ ARG_0, long /*(vtkIdType)*/ ARG_1, int /*(int)*/ ARG_2) {
	VTK_API.API_vtkAbstractArray.SetVoidArray_0(this, ARG_0, ARG_1, ARG_2);
}


// virtual void SetVoidArray(void * array, vtkIdType size, int save, int ARG_0)
// "virtual void SetVoidArray(void *array, vtkIdType size, int save, int )"
// skipping!


// virtual void ExportToVoidPointer(void * out_ptr)
// "virtual void ExportToVoidPointer(void *out_ptr)"
public void ExportToVoidPointer(IntPtr /*(void*)*/ out_ptr) {
	VTK_API.API_vtkAbstractArray.ExportToVoidPointer_0(this, out_ptr);
}


// virtual long GetActualMemorySize()
// "virtual unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkAbstractArray.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void SetName(const char * _arg)
// "virtual void SetName (const char* _arg)"
public void SetName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkAbstractArray.SetName_0(this, _arg);
}


// virtual char* GetName()
// "virtual char* GetName ()"
public string GetName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkAbstractArray.GetName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual char* GetDataTypeAsString()
// "virtual const char *GetDataTypeAsString( void )"
public string GetDataTypeAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkAbstractArray.GetDataTypeAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// static vtkAbstractArray* CreateArray(int dataType)
// "static vtkAbstractArray* CreateArray(int dataType)"
public static vtkAbstractArray CreateArray(int /*(int)*/ dataType) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractArray.CreateArray_0(out returnPointer, dataType);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual int IsNumeric()
// "virtual int IsNumeric()"
public int IsNumeric() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.IsNumeric_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkArrayIterator* NewIterator()
// "virtual vtkArrayIterator* NewIterator()"
public vtkArrayIterator NewIterator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractArray.NewIterator_0(out returnPointer, this);
//	return (vtkArrayIterator)(IntPtr)returnPointer;
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// virtual vtkIdType GetDataSize()
// "virtual vtkIdType GetDataSize()"
public long GetDataSize() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkAbstractArray.GetDataSize_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void DataChanged()
// "virtual void DataChanged()"
public void DataChanged() {
	VTK_API.API_vtkAbstractArray.DataChanged_0(this);
}


// virtual void ClearLookup()
// "virtual void ClearLookup()"
public void ClearLookup() {
	VTK_API.API_vtkAbstractArray.ClearLookup_0(this);
}


// bool HasInformation()
// "bool HasInformation()"
public bool HasInformation() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractArray.HasInformation_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// void Modified()
// "void Modified()"
public void Modified() {
	VTK_API.API_vtkAbstractArray.Modified_0(this);
}


// virtual int GetMaxDiscreteValues()
// "virtual unsigned int GetMaxDiscreteValues ()"
public uint GetMaxDiscreteValues() {
//	uint
//	ReturnPointer returnPointer = new ReturnPointer(new uint());
	uint returnPointer = new uint();
	VTK_API.API_vtkAbstractArray.GetMaxDiscreteValues_0(out returnPointer, this);
//	return (uint)returnPointer;
	return returnPointer;
}


// virtual void SetMaxDiscreteValues(unsigned int _arg)
// "virtual void SetMaxDiscreteValues (unsigned int _arg)"
public void SetMaxDiscreteValues(uint /*(unsigned int)*/ _arg) {
	VTK_API.API_vtkAbstractArray.SetMaxDiscreteValues_0(this, _arg);
}


// virtual int GetArrayType()
// "virtual int GetArrayType()"
public int GetArrayType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractArray.GetArrayType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
