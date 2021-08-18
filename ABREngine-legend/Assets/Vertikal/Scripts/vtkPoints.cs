

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPoints : vtkObject {
		public vtkPoints(IntPtr p) : base(p) {}
		public static implicit operator  vtkPoints(IntPtr p) {return new vtkPoints(p);}
		public static implicit operator  IntPtr(vtkPoints o) {return o.GetPtr();}

// static vtkPoints* New(int dataType)
// "static vtkPoints *New(int dataType)"
public static vtkPoints New(int /*(int)*/ dataType) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPoints.New_0(out returnPointer, dataType);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// static vtkPoints* New()
// "static vtkPoints *New()"
public static vtkPoints New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPoints.New_1(out returnPointer);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPoints.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPoints.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPoints* SafeDownCast(vtkObjectBase * o)
// "static vtkPoints* SafeDownCast(vtkObjectBase *o)"
public static vtkPoints SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPoints.SafeDownCast_0(out returnPointer, o);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// vtkPoints* NewInstance()
// "vtkPoints *NewInstance()"
public vtkPoints NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPoints.NewInstance_0(out returnPointer, this);
//	return (vtkPoints)(IntPtr)returnPointer;
	return (vtkPoints)(IntPtr)returnPointer;
}


// virtual vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext = 1000)
// "virtual vtkTypeBool Allocate(vtkIdType sz, vtkIdType ext = 1000)"
public bool Allocate(long /*(vtkIdType)*/ sz, long /*(vtkIdType)*/ ext) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPoints.Allocate_0(out returnPointer, this, sz, ext);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkPoints.Initialize_0(this);
}


// virtual void SetData(vtkDataArray * ARG_0)
// "virtual void SetData(vtkDataArray *)"
public void SetData(vtkDataArray /*(vtkDataArray*)*/ ARG_0) {
	VTK_API.API_vtkPoints.SetData_0(this, ARG_0);
}


// vtkDataArray* GetData()
// "vtkDataArray *GetData()"
public vtkDataArray GetData() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPoints.GetData_0(out returnPointer, this);
//	return (vtkDataArray)(IntPtr)returnPointer;
	return (vtkDataArray)(IntPtr)returnPointer;
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public int GetDataType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPoints.GetDataType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetDataType(int dataType)
// "virtual void SetDataType(int dataType)"
public void SetDataType(int /*(int)*/ dataType) {
	VTK_API.API_vtkPoints.SetDataType_0(this, dataType);
}


// void SetDataTypeToBit()
// "void SetDataTypeToBit()"
public void SetDataTypeToBit() {
	VTK_API.API_vtkPoints.SetDataTypeToBit_0(this);
}


// void SetDataTypeToChar()
// "void SetDataTypeToChar()"
public void SetDataTypeToChar() {
	VTK_API.API_vtkPoints.SetDataTypeToChar_0(this);
}


// void SetDataTypeToUnsignedChar()
// "void SetDataTypeToUnsignedChar()"
public void SetDataTypeToUnsignedChar() {
	VTK_API.API_vtkPoints.SetDataTypeToUnsignedChar_0(this);
}


// void SetDataTypeToShort()
// "void SetDataTypeToShort()"
public void SetDataTypeToShort() {
	VTK_API.API_vtkPoints.SetDataTypeToShort_0(this);
}


// void SetDataTypeToUnsignedShort()
// "void SetDataTypeToUnsignedShort()"
public void SetDataTypeToUnsignedShort() {
	VTK_API.API_vtkPoints.SetDataTypeToUnsignedShort_0(this);
}


// void SetDataTypeToInt()
// "void SetDataTypeToInt()"
public void SetDataTypeToInt() {
	VTK_API.API_vtkPoints.SetDataTypeToInt_0(this);
}


// void SetDataTypeToUnsignedInt()
// "void SetDataTypeToUnsignedInt()"
public void SetDataTypeToUnsignedInt() {
	VTK_API.API_vtkPoints.SetDataTypeToUnsignedInt_0(this);
}


// void SetDataTypeToLong()
// "void SetDataTypeToLong()"
public void SetDataTypeToLong() {
	VTK_API.API_vtkPoints.SetDataTypeToLong_0(this);
}


// void SetDataTypeToUnsignedLong()
// "void SetDataTypeToUnsignedLong()"
public void SetDataTypeToUnsignedLong() {
	VTK_API.API_vtkPoints.SetDataTypeToUnsignedLong_0(this);
}


// void SetDataTypeToFloat()
// "void SetDataTypeToFloat()"
public void SetDataTypeToFloat() {
	VTK_API.API_vtkPoints.SetDataTypeToFloat_0(this);
}


// void SetDataTypeToDouble()
// "void SetDataTypeToDouble()"
public void SetDataTypeToDouble() {
	VTK_API.API_vtkPoints.SetDataTypeToDouble_0(this);
}


// void* GetVoidPointer(const int id)
// "void *GetVoidPointer(const int id)"
public IntPtr GetVoidPointer(int /*(int)*/ id) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPoints.GetVoidPointer_0(out returnPointer, this, id);
//	return (IntPtr)returnPointer;
	return returnPointer;
}


// virtual void Squeeze()
// "virtual void Squeeze()"
public void Squeeze() {
	VTK_API.API_vtkPoints.Squeeze_0(this);
}


// virtual void Reset()
// "virtual void Reset()"
public void Reset() {
	VTK_API.API_vtkPoints.Reset_0(this);
}


// virtual void DeepCopy(vtkPoints * ad)
// "virtual void DeepCopy(vtkPoints *ad)"
public void DeepCopy(vtkPoints /*(vtkPoints*)*/ ad) {
	VTK_API.API_vtkPoints.DeepCopy_0(this, ad);
}


// virtual void ShallowCopy(vtkPoints * ad)
// "virtual void ShallowCopy(vtkPoints *ad)"
public void ShallowCopy(vtkPoints /*(vtkPoints*)*/ ad) {
	VTK_API.API_vtkPoints.ShallowCopy_0(this, ad);
}


// long GetActualMemorySize()
// "unsigned long GetActualMemorySize()"
public ulong GetActualMemorySize() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPoints.GetActualMemorySize_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPoints.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// double* GetPoint(vtkIdType id)
// "double *GetPoint(vtkIdType id)"
protected double[] GetPoint_0(long /*(vtkIdType)*/ id) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPoints.GetPoint_0(out returnPointer, this, id);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetPoint(vtkIdType id, double x[3])
// "void GetPoint(vtkIdType id, double x[3])"
protected void GetPoint_1(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	VTK_API.API_vtkPoints.GetPoint_1(this, id, x);
}


// void SetPoint(vtkIdType id, const float x[3])
// "void SetPoint(vtkIdType id, const float x[3])"
public void SetPoint(long /*(vtkIdType)*/ id, float /*(float[3])*/ []x) {
	VTK_API.API_vtkPoints.SetPoint_0(this, id, x);
}


// void SetPoint(vtkIdType id, const double x[3])
// "void SetPoint(vtkIdType id, const double x[3])"
public void SetPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	VTK_API.API_vtkPoints.SetPoint_1(this, id, x);
}


// void SetPoint(vtkIdType id, double x, double y, double z)
// "void SetPoint(vtkIdType id, double x, double y, double z)"
public void SetPoint(long /*(vtkIdType)*/ id, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkPoints.SetPoint_2(this, id, x, y, z);
}


// void InsertPoint(vtkIdType id, const float x[3])
// "void InsertPoint(vtkIdType id, const float x[3])"
public void InsertPoint(long /*(vtkIdType)*/ id, float /*(float[3])*/ []x) {
	VTK_API.API_vtkPoints.InsertPoint_0(this, id, x);
}


// void InsertPoint(vtkIdType id, const double x[3])
// "void InsertPoint(vtkIdType id, const double x[3])"
public void InsertPoint(long /*(vtkIdType)*/ id, double /*(double[3])*/ []x) {
	VTK_API.API_vtkPoints.InsertPoint_1(this, id, x);
}


// void InsertPoint(vtkIdType id, double x, double y, double z)
// "void InsertPoint(vtkIdType id, double x, double y, double z)"
public void InsertPoint(long /*(vtkIdType)*/ id, double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkPoints.InsertPoint_2(this, id, x, y, z);
}


// void InsertPoints(vtkIdList * dstIds, vtkIdList * srcIds, vtkPoints * source)
// "void InsertPoints(vtkIdList *dstIds, vtkIdList *srcIds, vtkPoints *source)"
public void InsertPoints(vtkIdList /*(vtkIdList*)*/ dstIds, vtkIdList /*(vtkIdList*)*/ srcIds, vtkPoints /*(vtkPoints*)*/ source) {
	VTK_API.API_vtkPoints.InsertPoints_0(this, dstIds, srcIds, source);
}


// void InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints * source)
// "void InsertPoints(vtkIdType dstStart, vtkIdType n, vtkIdType srcStart, vtkPoints* source)"
public void InsertPoints(long /*(vtkIdType)*/ dstStart, long /*(vtkIdType)*/ n, long /*(vtkIdType)*/ srcStart, vtkPoints /*(vtkPoints*)*/ source) {
	VTK_API.API_vtkPoints.InsertPoints_1(this, dstStart, n, srcStart, source);
}


// vtkIdType InsertNextPoint(const float x[3])
// "vtkIdType InsertNextPoint(const float x[3])"
public long InsertNextPoint(float /*(float[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPoints.InsertNextPoint_0(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType InsertNextPoint(const double x[3])
// "vtkIdType InsertNextPoint(const double x[3])"
public long InsertNextPoint(double /*(double[3])*/ []x) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPoints.InsertNextPoint_1(out returnPointer, this, x);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType InsertNextPoint(double x, double y, double z)
// "vtkIdType InsertNextPoint(double x, double y, double z)"
public long InsertNextPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkPoints.InsertNextPoint_2(out returnPointer, this, x, y, z);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetNumberOfPoints(vtkIdType numPoints)
// "void SetNumberOfPoints(vtkIdType numPoints)"
public void SetNumberOfPoints(long /*(vtkIdType)*/ numPoints) {
	VTK_API.API_vtkPoints.SetNumberOfPoints_0(this, numPoints);
}


// vtkTypeBool Resize(vtkIdType numPoints)
// "vtkTypeBool Resize(vtkIdType numPoints)"
public bool Resize(long /*(vtkIdType)*/ numPoints) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPoints.Resize_0(out returnPointer, this, numPoints);
//	return (bool)returnPointer;
	return returnPointer;
}


// void GetPoints(vtkIdList * ptId, vtkPoints * fp)
// "void GetPoints(vtkIdList *ptId, vtkPoints *fp)"
public void GetPoints(vtkIdList /*(vtkIdList*)*/ ptId, vtkPoints /*(vtkPoints*)*/ fp) {
	VTK_API.API_vtkPoints.GetPoints_0(this, ptId, fp);
}


// virtual void ComputeBounds()
// "virtual void ComputeBounds()"
public void ComputeBounds() {
	VTK_API.API_vtkPoints.ComputeBounds_0(this);
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPoints.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkPoints.GetBounds_1(this, bounds);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkPoints.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void Modified()
// "void Modified()"
public void Modified() {
	VTK_API.API_vtkPoints.Modified_0(this);
}


}
};
