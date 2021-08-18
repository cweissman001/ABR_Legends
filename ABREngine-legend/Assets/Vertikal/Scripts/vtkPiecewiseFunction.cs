

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPiecewiseFunction : vtkDataObject {
		public vtkPiecewiseFunction(IntPtr p) : base(p) {}
		public static implicit operator  vtkPiecewiseFunction(IntPtr p) {return new vtkPiecewiseFunction(p);}
		public static implicit operator  IntPtr(vtkPiecewiseFunction o) {return o.GetPtr();}

// static vtkPiecewiseFunction* New()
// "static vtkPiecewiseFunction *New()"
public static vtkPiecewiseFunction New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPiecewiseFunction.New_0(out returnPointer);
//	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPiecewiseFunction.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPiecewiseFunction.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPiecewiseFunction* SafeDownCast(vtkObjectBase * o)
// "static vtkPiecewiseFunction* SafeDownCast(vtkObjectBase *o)"
public static vtkPiecewiseFunction SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPiecewiseFunction.SafeDownCast_0(out returnPointer, o);
//	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// vtkPiecewiseFunction* NewInstance()
// "vtkPiecewiseFunction *NewInstance()"
public vtkPiecewiseFunction NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPiecewiseFunction.NewInstance_0(out returnPointer, this);
//	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
	return (vtkPiecewiseFunction)(IntPtr)returnPointer;
}


// void DeepCopy(vtkDataObject * f)
// "void DeepCopy( vtkDataObject *f )"
public void DeepCopy(vtkDataObject /*(vtkDataObject*)*/ f) {
	VTK_API.API_vtkPiecewiseFunction.DeepCopy_0(this, f);
}


// void ShallowCopy(vtkDataObject * f)
// "void ShallowCopy( vtkDataObject *f )"
public void ShallowCopy(vtkDataObject /*(vtkDataObject*)*/ f) {
	VTK_API.API_vtkPiecewiseFunction.ShallowCopy_0(this, f);
}


// int GetDataObjectType()
// "int GetDataObjectType()"
public int GetDataObjectType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.GetDataObjectType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetSize()
// "int GetSize()"
public int GetSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.GetSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int AddPoint(double x, double y)
// "int AddPoint( double x, double y )"
public int AddPoint(double /*(double)*/ x, double /*(double)*/ y) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.AddPoint_0(out returnPointer, this, x, y);
//	return (int)returnPointer;
	return returnPointer;
}


// int AddPoint(double x, double y, double midpoint, double sharpness)
// "int AddPoint( double x, double y, double midpoint, double sharpness )"
public int AddPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ midpoint, double /*(double)*/ sharpness) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.AddPoint_1(out returnPointer, this, x, y, midpoint, sharpness);
//	return (int)returnPointer;
	return returnPointer;
}


// int RemovePoint(double x)
// "int RemovePoint( double x )"
public int RemovePoint(double /*(double)*/ x) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.RemovePoint_0(out returnPointer, this, x);
//	return (int)returnPointer;
	return returnPointer;
}


// void RemoveAllPoints()
// "void RemoveAllPoints()"
public void RemoveAllPoints() {
	VTK_API.API_vtkPiecewiseFunction.RemoveAllPoints_0(this);
}


// void AddSegment(double x1, double y1, double x2, double y2)
// "void AddSegment( double x1, double y1, double x2, double y2 )"
public void AddSegment(double /*(double)*/ x1, double /*(double)*/ y1, double /*(double)*/ x2, double /*(double)*/ y2) {
	VTK_API.API_vtkPiecewiseFunction.AddSegment_0(this, x1, y1, x2, y2);
}


// double GetValue(double x)
// "double GetValue( double x )"
public double GetValue(double /*(double)*/ x) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPiecewiseFunction.GetValue_0(out returnPointer, this, x);
//	return (double)returnPointer;
	return returnPointer;
}


// int GetNodeValue(int index, double val[4])
// "int GetNodeValue( int index, double val[4] )"
public int GetNodeValue(int /*(int)*/ index, double /*(double[4])*/ []val) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.GetNodeValue_0(out returnPointer, this, index, val);
//	return (int)returnPointer;
	return returnPointer;
}


// int SetNodeValue(int index, double val[4])
// "int SetNodeValue( int index, double val[4] )"
public int SetNodeValue(int /*(int)*/ index, double /*(double[4])*/ []val) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.SetNodeValue_0(out returnPointer, this, index, val);
//	return (int)returnPointer;
	return returnPointer;
}


// double* GetDataPointer()
// "double *GetDataPointer()"
public double[] GetDataPointer() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPiecewiseFunction.GetDataPointer_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void FillFromDataPointer(int ARG_0, double * ARG_1)
// "void FillFromDataPointer(int, double*)"
public void FillFromDataPointer(int /*(int)*/ ARG_0, double /*(double*)*/ []ARG_1) {
	VTK_API.API_vtkPiecewiseFunction.FillFromDataPointer_0(this, ARG_0, ARG_1);
}


// virtual double* GetRange()
// "virtual double *GetRange ()"
public double[] GetRange() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPiecewiseFunction.GetRange_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetRange(double & _arg1, double & _arg2)
// "virtual void GetRange (double &_arg1, double &_arg2)"
public void GetRange(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkPiecewiseFunction.GetRange_1(this, _arg1, _arg2);
}


// virtual void GetRange(double _arg[2])
// "virtual void GetRange (double _arg[2])"
public void GetRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkPiecewiseFunction.GetRange_2(this, _arg);
}


// int AdjustRange(double range[2])
// "int AdjustRange(double range[2])"
public int AdjustRange(double /*(double[2])*/ []range) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.AdjustRange_0(out returnPointer, this, range);
//	return (int)returnPointer;
	return returnPointer;
}


// void GetTable(double x1, double x2, int size, float * table, int stride = 1, int logIncrements = 0)
// "void GetTable( double x1, double x2, int size, float *table, int stride=1, int logIncrements=0 )"
public void GetTable(double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, float /*(float*)*/ []table, int /*(int)*/ stride, int /*(int)*/ logIncrements) {
	VTK_API.API_vtkPiecewiseFunction.GetTable_0(this, x1, x2, size, table, stride, logIncrements);
}


// void GetTable(double x1, double x2, int size, double * table, int stride = 1, int logIncrements = 0)
// "void GetTable( double x1, double x2, int size, double *table, int stride=1, int logIncrements=0 )"
public void GetTable(double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, double /*(double*)*/ []table, int /*(int)*/ stride, int /*(int)*/ logIncrements) {
	VTK_API.API_vtkPiecewiseFunction.GetTable_1(this, x1, x2, size, table, stride, logIncrements);
}


// void BuildFunctionFromTable(double x1, double x2, int size, double * table, int stride = 1)
// "void BuildFunctionFromTable( double x1, double x2, int size, double *table, int stride=1 )"
public void BuildFunctionFromTable(double /*(double)*/ x1, double /*(double)*/ x2, int /*(int)*/ size, double /*(double*)*/ []table, int /*(int)*/ stride) {
	VTK_API.API_vtkPiecewiseFunction.BuildFunctionFromTable_0(this, x1, x2, size, table, stride);
}


// virtual void SetClamping(vtkTypeBool _arg)
// "virtual void SetClamping (vtkTypeBool _arg)"
public void SetClamping(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPiecewiseFunction.SetClamping_0(this, _arg);
}


// virtual vtkTypeBool GetClamping()
// "virtual vtkTypeBool GetClamping ()"
public bool GetClamping() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPiecewiseFunction.GetClamping_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ClampingOn()
// "virtual void ClampingOn ()"
public void ClampingOn() {
	VTK_API.API_vtkPiecewiseFunction.ClampingOn_0(this);
}


// virtual void ClampingOff()
// "virtual void ClampingOff ()"
public void ClampingOff() {
	VTK_API.API_vtkPiecewiseFunction.ClampingOff_0(this);
}


// virtual void SetUseLogScale(bool _arg)
// "virtual void SetUseLogScale (bool _arg)"
public void SetUseLogScale(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkPiecewiseFunction.SetUseLogScale_0(this, _arg);
}


// virtual bool GetUseLogScale()
// "virtual bool GetUseLogScale ()"
public bool GetUseLogScale() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPiecewiseFunction.GetUseLogScale_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseLogScaleOn()
// "virtual void UseLogScaleOn ()"
public void UseLogScaleOn() {
	VTK_API.API_vtkPiecewiseFunction.UseLogScaleOn_0(this);
}


// virtual void UseLogScaleOff()
// "virtual void UseLogScaleOff ()"
public void UseLogScaleOff() {
	VTK_API.API_vtkPiecewiseFunction.UseLogScaleOff_0(this);
}


// char* GetType()
// "const char *GetType()"
public string GetType() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkPiecewiseFunction.GetType_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// double GetFirstNonZeroValue()
// "double GetFirstNonZeroValue()"
public double GetFirstNonZeroValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPiecewiseFunction.GetFirstNonZeroValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void Initialize()
// "void Initialize()"
public void Initialize() {
	VTK_API.API_vtkPiecewiseFunction.Initialize_0(this);
}


// virtual void SetAllowDuplicateScalars(vtkTypeBool _arg)
// "virtual void SetAllowDuplicateScalars (vtkTypeBool _arg)"
public void SetAllowDuplicateScalars(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPiecewiseFunction.SetAllowDuplicateScalars_0(this, _arg);
}


// virtual vtkTypeBool GetAllowDuplicateScalars()
// "virtual vtkTypeBool GetAllowDuplicateScalars ()"
public bool GetAllowDuplicateScalars() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPiecewiseFunction.GetAllowDuplicateScalars_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void AllowDuplicateScalarsOn()
// "virtual void AllowDuplicateScalarsOn ()"
public void AllowDuplicateScalarsOn() {
	VTK_API.API_vtkPiecewiseFunction.AllowDuplicateScalarsOn_0(this);
}


// virtual void AllowDuplicateScalarsOff()
// "virtual void AllowDuplicateScalarsOff ()"
public void AllowDuplicateScalarsOff() {
	VTK_API.API_vtkPiecewiseFunction.AllowDuplicateScalarsOff_0(this);
}


// int EstimateMinNumberOfSamples(double const& x1, double const& x2)
// "int EstimateMinNumberOfSamples(double const & x1, double const & x2)"
public int EstimateMinNumberOfSamples(IntPtr /*(doubleconst&)*/ x1, IntPtr /*(doubleconst&)*/ x2) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPiecewiseFunction.EstimateMinNumberOfSamples_0(out returnPointer, this, x1, x2);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
