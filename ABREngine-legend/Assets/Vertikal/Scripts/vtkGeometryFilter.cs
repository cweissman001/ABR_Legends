

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGeometryFilter : vtkPolyDataAlgorithm {
		public vtkGeometryFilter(IntPtr p) : base(p) {}
		public static implicit operator  vtkGeometryFilter(IntPtr p) {return new vtkGeometryFilter(p);}
		public static implicit operator  IntPtr(vtkGeometryFilter o) {return o.GetPtr();}

// static vtkGeometryFilter* New()
// "static vtkGeometryFilter *New()"
public static vtkGeometryFilter New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGeometryFilter.New_0(out returnPointer);
//	return (vtkGeometryFilter)(IntPtr)returnPointer;
	return (vtkGeometryFilter)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGeometryFilter.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGeometryFilter.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkGeometryFilter* SafeDownCast(vtkObjectBase * o)
// "static vtkGeometryFilter* SafeDownCast(vtkObjectBase *o)"
public static vtkGeometryFilter SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGeometryFilter.SafeDownCast_0(out returnPointer, o);
//	return (vtkGeometryFilter)(IntPtr)returnPointer;
	return (vtkGeometryFilter)(IntPtr)returnPointer;
}


// vtkGeometryFilter* NewInstance()
// "vtkGeometryFilter *NewInstance()"
public vtkGeometryFilter NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGeometryFilter.NewInstance_0(out returnPointer, this);
//	return (vtkGeometryFilter)(IntPtr)returnPointer;
	return (vtkGeometryFilter)(IntPtr)returnPointer;
}


// virtual void SetPointClipping(vtkTypeBool _arg)
// "virtual void SetPointClipping (vtkTypeBool _arg)"
public void SetPointClipping(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetPointClipping_0(this, _arg);
}


// virtual vtkTypeBool GetPointClipping()
// "virtual vtkTypeBool GetPointClipping ()"
public bool GetPointClipping() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGeometryFilter.GetPointClipping_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PointClippingOn()
// "virtual void PointClippingOn ()"
public void PointClippingOn() {
	VTK_API.API_vtkGeometryFilter.PointClippingOn_0(this);
}


// virtual void PointClippingOff()
// "virtual void PointClippingOff ()"
public void PointClippingOff() {
	VTK_API.API_vtkGeometryFilter.PointClippingOff_0(this);
}


// virtual void SetCellClipping(vtkTypeBool _arg)
// "virtual void SetCellClipping (vtkTypeBool _arg)"
public void SetCellClipping(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetCellClipping_0(this, _arg);
}


// virtual vtkTypeBool GetCellClipping()
// "virtual vtkTypeBool GetCellClipping ()"
public bool GetCellClipping() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGeometryFilter.GetCellClipping_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void CellClippingOn()
// "virtual void CellClippingOn ()"
public void CellClippingOn() {
	VTK_API.API_vtkGeometryFilter.CellClippingOn_0(this);
}


// virtual void CellClippingOff()
// "virtual void CellClippingOff ()"
public void CellClippingOff() {
	VTK_API.API_vtkGeometryFilter.CellClippingOff_0(this);
}


// virtual void SetExtentClipping(vtkTypeBool _arg)
// "virtual void SetExtentClipping (vtkTypeBool _arg)"
public void SetExtentClipping(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetExtentClipping_0(this, _arg);
}


// virtual vtkTypeBool GetExtentClipping()
// "virtual vtkTypeBool GetExtentClipping ()"
public bool GetExtentClipping() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGeometryFilter.GetExtentClipping_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ExtentClippingOn()
// "virtual void ExtentClippingOn ()"
public void ExtentClippingOn() {
	VTK_API.API_vtkGeometryFilter.ExtentClippingOn_0(this);
}


// virtual void ExtentClippingOff()
// "virtual void ExtentClippingOff ()"
public void ExtentClippingOff() {
	VTK_API.API_vtkGeometryFilter.ExtentClippingOff_0(this);
}


// virtual void SetPointMinimum(vtkIdType _arg)
// "virtual void SetPointMinimum (vtkIdType _arg)"
public void SetPointMinimum(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetPointMinimum_0(this, _arg);
}


// virtual vtkIdType GetPointMinimumMinValue()
// "virtual vtkIdType GetPointMinimumMinValue ()"
public long GetPointMinimumMinValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetPointMinimumMinValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetPointMinimumMaxValue()
// "virtual vtkIdType GetPointMinimumMaxValue ()"
public long GetPointMinimumMaxValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetPointMinimumMaxValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetPointMinimum()
// "virtual vtkIdType GetPointMinimum ()"
public long GetPointMinimum() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetPointMinimum_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetPointMaximum(vtkIdType _arg)
// "virtual void SetPointMaximum (vtkIdType _arg)"
public void SetPointMaximum(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetPointMaximum_0(this, _arg);
}


// virtual vtkIdType GetPointMaximumMinValue()
// "virtual vtkIdType GetPointMaximumMinValue ()"
public long GetPointMaximumMinValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetPointMaximumMinValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetPointMaximumMaxValue()
// "virtual vtkIdType GetPointMaximumMaxValue ()"
public long GetPointMaximumMaxValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetPointMaximumMaxValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetPointMaximum()
// "virtual vtkIdType GetPointMaximum ()"
public long GetPointMaximum() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetPointMaximum_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetCellMinimum(vtkIdType _arg)
// "virtual void SetCellMinimum (vtkIdType _arg)"
public void SetCellMinimum(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetCellMinimum_0(this, _arg);
}


// virtual vtkIdType GetCellMinimumMinValue()
// "virtual vtkIdType GetCellMinimumMinValue ()"
public long GetCellMinimumMinValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetCellMinimumMinValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetCellMinimumMaxValue()
// "virtual vtkIdType GetCellMinimumMaxValue ()"
public long GetCellMinimumMaxValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetCellMinimumMaxValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetCellMinimum()
// "virtual vtkIdType GetCellMinimum ()"
public long GetCellMinimum() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetCellMinimum_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetCellMaximum(vtkIdType _arg)
// "virtual void SetCellMaximum (vtkIdType _arg)"
public void SetCellMaximum(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetCellMaximum_0(this, _arg);
}


// virtual vtkIdType GetCellMaximumMinValue()
// "virtual vtkIdType GetCellMaximumMinValue ()"
public long GetCellMaximumMinValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetCellMaximumMinValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetCellMaximumMaxValue()
// "virtual vtkIdType GetCellMaximumMaxValue ()"
public long GetCellMaximumMaxValue() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetCellMaximumMaxValue_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetCellMaximum()
// "virtual vtkIdType GetCellMaximum ()"
public long GetCellMaximum() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkGeometryFilter.GetCellMaximum_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
// "void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)"
public void SetExtent(double /*(double)*/ xMin, double /*(double)*/ xMax, double /*(double)*/ yMin, double /*(double)*/ yMax, double /*(double)*/ zMin, double /*(double)*/ zMax) {
	VTK_API.API_vtkGeometryFilter.SetExtent_0(this, xMin, xMax, yMin, yMax, zMin, zMax);
}


// void SetExtent(double extent[6])
// "void SetExtent(double extent[6])"
public void SetExtent(double /*(double[6])*/ []extent) {
	VTK_API.API_vtkGeometryFilter.SetExtent_1(this, extent);
}


// double* GetExtent()
// "double *GetExtent()"
public double[] GetExtent() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkGeometryFilter.GetExtent_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetMerging(vtkTypeBool _arg)
// "virtual void SetMerging (vtkTypeBool _arg)"
public void SetMerging(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGeometryFilter.SetMerging_0(this, _arg);
}


// virtual vtkTypeBool GetMerging()
// "virtual vtkTypeBool GetMerging ()"
public bool GetMerging() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGeometryFilter.GetMerging_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void MergingOn()
// "virtual void MergingOn ()"
public void MergingOn() {
	VTK_API.API_vtkGeometryFilter.MergingOn_0(this);
}


// virtual void MergingOff()
// "virtual void MergingOff ()"
public void MergingOff() {
	VTK_API.API_vtkGeometryFilter.MergingOff_0(this);
}


// void SetLocator(vtkIncrementalPointLocator * locator)
// "void SetLocator(vtkIncrementalPointLocator *locator)"
public void SetLocator(vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator) {
	VTK_API.API_vtkGeometryFilter.SetLocator_0(this, locator);
}


// virtual vtkIncrementalPointLocator* GetLocator()
// "virtual vtkIncrementalPointLocator *GetLocator ()"
public vtkIncrementalPointLocator GetLocator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGeometryFilter.GetLocator_0(out returnPointer, this);
//	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// void CreateDefaultLocator()
// "void CreateDefaultLocator()"
public void CreateDefaultLocator() {
	VTK_API.API_vtkGeometryFilter.CreateDefaultLocator_0(this);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkGeometryFilter.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void SetOutputPointsPrecision(int precision)
// "void SetOutputPointsPrecision(int precision)"
public void SetOutputPointsPrecision(int /*(int)*/ precision) {
	VTK_API.API_vtkGeometryFilter.SetOutputPointsPrecision_0(this, precision);
}


// int GetOutputPointsPrecision()
// "int GetOutputPointsPrecision()"
public int GetOutputPointsPrecision() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGeometryFilter.GetOutputPointsPrecision_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
