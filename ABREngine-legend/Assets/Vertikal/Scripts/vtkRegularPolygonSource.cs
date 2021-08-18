

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRegularPolygonSource : vtkPolyDataAlgorithm {
		public vtkRegularPolygonSource(IntPtr p) : base(p) {}
		public static implicit operator  vtkRegularPolygonSource(IntPtr p) {return new vtkRegularPolygonSource(p);}
		public static implicit operator  IntPtr(vtkRegularPolygonSource o) {return o.GetPtr();}

// static vtkRegularPolygonSource* New()
// "static vtkRegularPolygonSource *New()"
public static vtkRegularPolygonSource New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRegularPolygonSource.New_0(out returnPointer);
//	return (vtkRegularPolygonSource)(IntPtr)returnPointer;
	return (vtkRegularPolygonSource)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRegularPolygonSource.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRegularPolygonSource.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkRegularPolygonSource* SafeDownCast(vtkObjectBase * o)
// "static vtkRegularPolygonSource* SafeDownCast(vtkObjectBase *o)"
public static vtkRegularPolygonSource SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRegularPolygonSource.SafeDownCast_0(out returnPointer, o);
//	return (vtkRegularPolygonSource)(IntPtr)returnPointer;
	return (vtkRegularPolygonSource)(IntPtr)returnPointer;
}


// vtkRegularPolygonSource* NewInstance()
// "vtkRegularPolygonSource *NewInstance()"
public vtkRegularPolygonSource NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRegularPolygonSource.NewInstance_0(out returnPointer, this);
//	return (vtkRegularPolygonSource)(IntPtr)returnPointer;
	return (vtkRegularPolygonSource)(IntPtr)returnPointer;
}


// virtual void SetNumberOfSides(int _arg)
// "virtual void SetNumberOfSides (int _arg)"
public void SetNumberOfSides(int /*(int)*/ _arg) {
	VTK_API.API_vtkRegularPolygonSource.SetNumberOfSides_0(this, _arg);
}


// virtual int GetNumberOfSidesMinValue()
// "virtual int GetNumberOfSidesMinValue ()"
public int GetNumberOfSidesMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRegularPolygonSource.GetNumberOfSidesMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfSidesMaxValue()
// "virtual int GetNumberOfSidesMaxValue ()"
public int GetNumberOfSidesMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRegularPolygonSource.GetNumberOfSidesMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfSides()
// "virtual int GetNumberOfSides ()"
public int GetNumberOfSides() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRegularPolygonSource.GetNumberOfSides_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetCenter(double _arg1, double _arg2, double _arg3)
// "virtual void SetCenter (double _arg1, double _arg2, double _arg3)"
public void SetCenter(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkRegularPolygonSource.SetCenter_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetCenter(double _arg[3])
// "virtual void SetCenter (double _arg[3])"
public void SetCenter(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkRegularPolygonSource.SetCenter_1(this, _arg);
}


// virtual double* GetCenter()
// "virtual double *GetCenter ()"
public double[] GetCenter() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkRegularPolygonSource.GetCenter_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetCenter(double data[3])
// "virtual void GetCenter (double data[3])"
public void GetCenter(double /*(double[3])*/ []data) {
	VTK_API.API_vtkRegularPolygonSource.GetCenter_1(this, data);
}


// virtual void SetNormal(double _arg1, double _arg2, double _arg3)
// "virtual void SetNormal (double _arg1, double _arg2, double _arg3)"
public void SetNormal(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkRegularPolygonSource.SetNormal_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetNormal(double _arg[3])
// "virtual void SetNormal (double _arg[3])"
public void SetNormal(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkRegularPolygonSource.SetNormal_1(this, _arg);
}


// virtual double* GetNormal()
// "virtual double *GetNormal ()"
public double[] GetNormal() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkRegularPolygonSource.GetNormal_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetNormal(double data[3])
// "virtual void GetNormal (double data[3])"
public void GetNormal(double /*(double[3])*/ []data) {
	VTK_API.API_vtkRegularPolygonSource.GetNormal_1(this, data);
}


// virtual void SetRadius(double _arg)
// "virtual void SetRadius (double _arg)"
public void SetRadius(double /*(double)*/ _arg) {
	VTK_API.API_vtkRegularPolygonSource.SetRadius_0(this, _arg);
}


// virtual double GetRadius()
// "virtual double GetRadius ()"
public double GetRadius() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRegularPolygonSource.GetRadius_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetGeneratePolygon(vtkTypeBool _arg)
// "virtual void SetGeneratePolygon (vtkTypeBool _arg)"
public void SetGeneratePolygon(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRegularPolygonSource.SetGeneratePolygon_0(this, _arg);
}


// virtual vtkTypeBool GetGeneratePolygon()
// "virtual vtkTypeBool GetGeneratePolygon ()"
public bool GetGeneratePolygon() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRegularPolygonSource.GetGeneratePolygon_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void GeneratePolygonOn()
// "virtual void GeneratePolygonOn ()"
public void GeneratePolygonOn() {
	VTK_API.API_vtkRegularPolygonSource.GeneratePolygonOn_0(this);
}


// virtual void GeneratePolygonOff()
// "virtual void GeneratePolygonOff ()"
public void GeneratePolygonOff() {
	VTK_API.API_vtkRegularPolygonSource.GeneratePolygonOff_0(this);
}


// virtual void SetGeneratePolyline(vtkTypeBool _arg)
// "virtual void SetGeneratePolyline (vtkTypeBool _arg)"
public void SetGeneratePolyline(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRegularPolygonSource.SetGeneratePolyline_0(this, _arg);
}


// virtual vtkTypeBool GetGeneratePolyline()
// "virtual vtkTypeBool GetGeneratePolyline ()"
public bool GetGeneratePolyline() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRegularPolygonSource.GetGeneratePolyline_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void GeneratePolylineOn()
// "virtual void GeneratePolylineOn ()"
public void GeneratePolylineOn() {
	VTK_API.API_vtkRegularPolygonSource.GeneratePolylineOn_0(this);
}


// virtual void GeneratePolylineOff()
// "virtual void GeneratePolylineOff ()"
public void GeneratePolylineOff() {
	VTK_API.API_vtkRegularPolygonSource.GeneratePolylineOff_0(this);
}


// virtual void SetOutputPointsPrecision(int _arg)
// "virtual void SetOutputPointsPrecision (int _arg)"
public void SetOutputPointsPrecision(int /*(int)*/ _arg) {
	VTK_API.API_vtkRegularPolygonSource.SetOutputPointsPrecision_0(this, _arg);
}


// virtual int GetOutputPointsPrecision()
// "virtual int GetOutputPointsPrecision ()"
public int GetOutputPointsPrecision() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRegularPolygonSource.GetOutputPointsPrecision_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
