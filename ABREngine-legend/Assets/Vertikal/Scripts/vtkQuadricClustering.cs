

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkQuadricClustering : vtkPolyDataAlgorithm {
		public vtkQuadricClustering(IntPtr p) : base(p) {}
		public static implicit operator  vtkQuadricClustering(IntPtr p) {return new vtkQuadricClustering(p);}
		public static implicit operator  IntPtr(vtkQuadricClustering o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkQuadricClustering* SafeDownCast(vtkObjectBase * o)
// "static vtkQuadricClustering* SafeDownCast(vtkObjectBase *o)"
public static vtkQuadricClustering SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkQuadricClustering.SafeDownCast_0(out returnPointer, o);
//	return (vtkQuadricClustering)(IntPtr)returnPointer;
	return (vtkQuadricClustering)(IntPtr)returnPointer;
}


// vtkQuadricClustering* NewInstance()
// "vtkQuadricClustering *NewInstance()"
public vtkQuadricClustering NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkQuadricClustering.NewInstance_0(out returnPointer, this);
//	return (vtkQuadricClustering)(IntPtr)returnPointer;
	return (vtkQuadricClustering)(IntPtr)returnPointer;
}


// static vtkQuadricClustering* New()
// "static vtkQuadricClustering *New()"
public static vtkQuadricClustering New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkQuadricClustering.New_0(out returnPointer);
//	return (vtkQuadricClustering)(IntPtr)returnPointer;
	return (vtkQuadricClustering)(IntPtr)returnPointer;
}


// void SetNumberOfXDivisions(int num)
// "void SetNumberOfXDivisions(int num)"
public void SetNumberOfXDivisions(int /*(int)*/ num) {
	VTK_API.API_vtkQuadricClustering.SetNumberOfXDivisions_0(this, num);
}


// void SetNumberOfYDivisions(int num)
// "void SetNumberOfYDivisions(int num)"
public void SetNumberOfYDivisions(int /*(int)*/ num) {
	VTK_API.API_vtkQuadricClustering.SetNumberOfYDivisions_0(this, num);
}


// void SetNumberOfZDivisions(int num)
// "void SetNumberOfZDivisions(int num)"
public void SetNumberOfZDivisions(int /*(int)*/ num) {
	VTK_API.API_vtkQuadricClustering.SetNumberOfZDivisions_0(this, num);
}


// virtual int GetNumberOfXDivisions()
// "virtual int GetNumberOfXDivisions ()"
public int GetNumberOfXDivisions() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkQuadricClustering.GetNumberOfXDivisions_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfYDivisions()
// "virtual int GetNumberOfYDivisions ()"
public int GetNumberOfYDivisions() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkQuadricClustering.GetNumberOfYDivisions_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfZDivisions()
// "virtual int GetNumberOfZDivisions ()"
public int GetNumberOfZDivisions() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkQuadricClustering.GetNumberOfZDivisions_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetNumberOfDivisions(int div[3])
// "void SetNumberOfDivisions(int div[3])"
public void SetNumberOfDivisions(int /*(int[3])*/ []div) {
	VTK_API.API_vtkQuadricClustering.SetNumberOfDivisions_0(this, div);
}


// void SetNumberOfDivisions(int div0, int div1, int div2)
// "void SetNumberOfDivisions(int div0, int div1, int div2)"
public void SetNumberOfDivisions(int /*(int)*/ div0, int /*(int)*/ div1, int /*(int)*/ div2) {
	VTK_API.API_vtkQuadricClustering.SetNumberOfDivisions_1(this, div0, div1, div2);
}


// int* GetNumberOfDivisions()
// "int *GetNumberOfDivisions()"
public int[] GetNumberOfDivisions() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkQuadricClustering.GetNumberOfDivisions_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void GetNumberOfDivisions(int div[3])
// "void GetNumberOfDivisions(int div[3])"
public void GetNumberOfDivisions(int /*(int[3])*/ []div) {
	VTK_API.API_vtkQuadricClustering.GetNumberOfDivisions_1(this, div);
}


// virtual void SetAutoAdjustNumberOfDivisions(vtkTypeBool _arg)
// "virtual void SetAutoAdjustNumberOfDivisions (vtkTypeBool _arg)"
public void SetAutoAdjustNumberOfDivisions(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetAutoAdjustNumberOfDivisions_0(this, _arg);
}


// virtual vtkTypeBool GetAutoAdjustNumberOfDivisions()
// "virtual vtkTypeBool GetAutoAdjustNumberOfDivisions ()"
public bool GetAutoAdjustNumberOfDivisions() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetAutoAdjustNumberOfDivisions_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void AutoAdjustNumberOfDivisionsOn()
// "virtual void AutoAdjustNumberOfDivisionsOn ()"
public void AutoAdjustNumberOfDivisionsOn() {
	VTK_API.API_vtkQuadricClustering.AutoAdjustNumberOfDivisionsOn_0(this);
}


// virtual void AutoAdjustNumberOfDivisionsOff()
// "virtual void AutoAdjustNumberOfDivisionsOff ()"
public void AutoAdjustNumberOfDivisionsOff() {
	VTK_API.API_vtkQuadricClustering.AutoAdjustNumberOfDivisionsOff_0(this);
}


// void SetDivisionOrigin(double x, double y, double z)
// "void SetDivisionOrigin(double x, double y, double z)"
public void SetDivisionOrigin(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkQuadricClustering.SetDivisionOrigin_0(this, x, y, z);
}


// void SetDivisionOrigin(double o[3])
// "void SetDivisionOrigin(double o[3])"
public void SetDivisionOrigin(double /*(double[3])*/ []o) {
	VTK_API.API_vtkQuadricClustering.SetDivisionOrigin_1(this, o);
}


// virtual double* GetDivisionOrigin()
// "virtual double *GetDivisionOrigin ()"
public double[] GetDivisionOrigin() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkQuadricClustering.GetDivisionOrigin_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetDivisionOrigin(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetDivisionOrigin (double &_arg1, double &_arg2, double &_arg3)"
public void GetDivisionOrigin(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkQuadricClustering.GetDivisionOrigin_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetDivisionOrigin(double _arg[3])
// "virtual void GetDivisionOrigin (double _arg[3])"
public void GetDivisionOrigin(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkQuadricClustering.GetDivisionOrigin_2(this, _arg);
}


// void SetDivisionSpacing(double x, double y, double z)
// "void SetDivisionSpacing(double x, double y, double z)"
public void SetDivisionSpacing(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkQuadricClustering.SetDivisionSpacing_0(this, x, y, z);
}


// void SetDivisionSpacing(double s[3])
// "void SetDivisionSpacing(double s[3])"
public void SetDivisionSpacing(double /*(double[3])*/ []s) {
	VTK_API.API_vtkQuadricClustering.SetDivisionSpacing_1(this, s);
}


// virtual double* GetDivisionSpacing()
// "virtual double *GetDivisionSpacing ()"
public double[] GetDivisionSpacing() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkQuadricClustering.GetDivisionSpacing_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetDivisionSpacing(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetDivisionSpacing (double &_arg1, double &_arg2, double &_arg3)"
public void GetDivisionSpacing(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkQuadricClustering.GetDivisionSpacing_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetDivisionSpacing(double _arg[3])
// "virtual void GetDivisionSpacing (double _arg[3])"
public void GetDivisionSpacing(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkQuadricClustering.GetDivisionSpacing_2(this, _arg);
}


// virtual void SetUseInputPoints(vtkTypeBool _arg)
// "virtual void SetUseInputPoints (vtkTypeBool _arg)"
public void SetUseInputPoints(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetUseInputPoints_0(this, _arg);
}


// virtual vtkTypeBool GetUseInputPoints()
// "virtual vtkTypeBool GetUseInputPoints ()"
public bool GetUseInputPoints() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetUseInputPoints_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseInputPointsOn()
// "virtual void UseInputPointsOn ()"
public void UseInputPointsOn() {
	VTK_API.API_vtkQuadricClustering.UseInputPointsOn_0(this);
}


// virtual void UseInputPointsOff()
// "virtual void UseInputPointsOff ()"
public void UseInputPointsOff() {
	VTK_API.API_vtkQuadricClustering.UseInputPointsOff_0(this);
}


// virtual void SetUseFeatureEdges(vtkTypeBool _arg)
// "virtual void SetUseFeatureEdges (vtkTypeBool _arg)"
public void SetUseFeatureEdges(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetUseFeatureEdges_0(this, _arg);
}


// virtual vtkTypeBool GetUseFeatureEdges()
// "virtual vtkTypeBool GetUseFeatureEdges ()"
public bool GetUseFeatureEdges() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetUseFeatureEdges_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseFeatureEdgesOn()
// "virtual void UseFeatureEdgesOn ()"
public void UseFeatureEdgesOn() {
	VTK_API.API_vtkQuadricClustering.UseFeatureEdgesOn_0(this);
}


// virtual void UseFeatureEdgesOff()
// "virtual void UseFeatureEdgesOff ()"
public void UseFeatureEdgesOff() {
	VTK_API.API_vtkQuadricClustering.UseFeatureEdgesOff_0(this);
}


// vtkFeatureEdges* GetFeatureEdges()
// "vtkFeatureEdges *GetFeatureEdges()"
public vtkFeatureEdges GetFeatureEdges() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkQuadricClustering.GetFeatureEdges_0(out returnPointer, this);
//	return (vtkFeatureEdges)(IntPtr)returnPointer;
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// virtual void SetUseFeaturePoints(vtkTypeBool _arg)
// "virtual void SetUseFeaturePoints (vtkTypeBool _arg)"
public void SetUseFeaturePoints(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetUseFeaturePoints_0(this, _arg);
}


// virtual vtkTypeBool GetUseFeaturePoints()
// "virtual vtkTypeBool GetUseFeaturePoints ()"
public bool GetUseFeaturePoints() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetUseFeaturePoints_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseFeaturePointsOn()
// "virtual void UseFeaturePointsOn ()"
public void UseFeaturePointsOn() {
	VTK_API.API_vtkQuadricClustering.UseFeaturePointsOn_0(this);
}


// virtual void UseFeaturePointsOff()
// "virtual void UseFeaturePointsOff ()"
public void UseFeaturePointsOff() {
	VTK_API.API_vtkQuadricClustering.UseFeaturePointsOff_0(this);
}


// virtual void SetFeaturePointsAngle(double _arg)
// "virtual void SetFeaturePointsAngle (double _arg)"
public void SetFeaturePointsAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetFeaturePointsAngle_0(this, _arg);
}


// virtual double GetFeaturePointsAngleMinValue()
// "virtual double GetFeaturePointsAngleMinValue ()"
public double GetFeaturePointsAngleMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkQuadricClustering.GetFeaturePointsAngleMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetFeaturePointsAngleMaxValue()
// "virtual double GetFeaturePointsAngleMaxValue ()"
public double GetFeaturePointsAngleMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkQuadricClustering.GetFeaturePointsAngleMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetFeaturePointsAngle()
// "virtual double GetFeaturePointsAngle ()"
public double GetFeaturePointsAngle() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkQuadricClustering.GetFeaturePointsAngle_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetUseInternalTriangles(vtkTypeBool _arg)
// "virtual void SetUseInternalTriangles (vtkTypeBool _arg)"
public void SetUseInternalTriangles(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetUseInternalTriangles_0(this, _arg);
}


// virtual vtkTypeBool GetUseInternalTriangles()
// "virtual vtkTypeBool GetUseInternalTriangles ()"
public bool GetUseInternalTriangles() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetUseInternalTriangles_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseInternalTrianglesOn()
// "virtual void UseInternalTrianglesOn ()"
public void UseInternalTrianglesOn() {
	VTK_API.API_vtkQuadricClustering.UseInternalTrianglesOn_0(this);
}


// virtual void UseInternalTrianglesOff()
// "virtual void UseInternalTrianglesOff ()"
public void UseInternalTrianglesOff() {
	VTK_API.API_vtkQuadricClustering.UseInternalTrianglesOff_0(this);
}


// void StartAppend(double * bounds)
// "void StartAppend(double *bounds)"
public void StartAppend(double /*(double*)*/ []bounds) {
	VTK_API.API_vtkQuadricClustering.StartAppend_0(this, bounds);
}


// void StartAppend(double x0, double x1, double y0, double y1, double z0, double z1)
// "void StartAppend(double x0,double x1,double y0,double y1,double z0,double z1)"
public void StartAppend(double /*(double)*/ x0, double /*(double)*/ x1, double /*(double)*/ y0, double /*(double)*/ y1, double /*(double)*/ z0, double /*(double)*/ z1) {
	VTK_API.API_vtkQuadricClustering.StartAppend_1(this, x0, x1, y0, y1, z0, z1);
}


// void Append(vtkPolyData * piece)
// "void Append(vtkPolyData *piece)"
public void Append(vtkPolyData /*(vtkPolyData*)*/ piece) {
	VTK_API.API_vtkQuadricClustering.Append_0(this, piece);
}


// void EndAppend()
// "void EndAppend()"
public void EndAppend() {
	VTK_API.API_vtkQuadricClustering.EndAppend_0(this);
}


// virtual void SetCopyCellData(vtkTypeBool _arg)
// "virtual void SetCopyCellData (vtkTypeBool _arg)"
public void SetCopyCellData(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetCopyCellData_0(this, _arg);
}


// virtual vtkTypeBool GetCopyCellData()
// "virtual vtkTypeBool GetCopyCellData ()"
public bool GetCopyCellData() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetCopyCellData_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void CopyCellDataOn()
// "virtual void CopyCellDataOn ()"
public void CopyCellDataOn() {
	VTK_API.API_vtkQuadricClustering.CopyCellDataOn_0(this);
}


// virtual void CopyCellDataOff()
// "virtual void CopyCellDataOff ()"
public void CopyCellDataOff() {
	VTK_API.API_vtkQuadricClustering.CopyCellDataOff_0(this);
}


// virtual void SetPreventDuplicateCells(vtkTypeBool _arg)
// "virtual void SetPreventDuplicateCells (vtkTypeBool _arg)"
public void SetPreventDuplicateCells(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkQuadricClustering.SetPreventDuplicateCells_0(this, _arg);
}


// virtual vtkTypeBool GetPreventDuplicateCells()
// "virtual vtkTypeBool GetPreventDuplicateCells ()"
public bool GetPreventDuplicateCells() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkQuadricClustering.GetPreventDuplicateCells_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PreventDuplicateCellsOn()
// "virtual void PreventDuplicateCellsOn ()"
public void PreventDuplicateCellsOn() {
	VTK_API.API_vtkQuadricClustering.PreventDuplicateCellsOn_0(this);
}


// virtual void PreventDuplicateCellsOff()
// "virtual void PreventDuplicateCellsOff ()"
public void PreventDuplicateCellsOff() {
	VTK_API.API_vtkQuadricClustering.PreventDuplicateCellsOff_0(this);
}


}
};
