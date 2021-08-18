

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPlane : vtkImplicitFunction {
		public vtkPlane(IntPtr p) : base(p) {}
		public static implicit operator  vtkPlane(IntPtr p) {return new vtkPlane(p);}
		public static implicit operator  IntPtr(vtkPlane o) {return o.GetPtr();}

// static vtkPlane* New()
// "static vtkPlane *New()"
public static vtkPlane New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlane.New_0(out returnPointer);
//	return (vtkPlane)(IntPtr)returnPointer;
	return (vtkPlane)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPlane.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPlane.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPlane* SafeDownCast(vtkObjectBase * o)
// "static vtkPlane* SafeDownCast(vtkObjectBase *o)"
public static vtkPlane SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlane.SafeDownCast_0(out returnPointer, o);
//	return (vtkPlane)(IntPtr)returnPointer;
	return (vtkPlane)(IntPtr)returnPointer;
}


// vtkPlane* NewInstance()
// "vtkPlane *NewInstance()"
public vtkPlane NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPlane.NewInstance_0(out returnPointer, this);
//	return (vtkPlane)(IntPtr)returnPointer;
	return (vtkPlane)(IntPtr)returnPointer;
}


// void EvaluateFunction(vtkDataArray * input, vtkDataArray * output)
// "void EvaluateFunction(vtkDataArray* input, vtkDataArray* output)"
public void EvaluateFunction(vtkDataArray /*(vtkDataArray*)*/ input, vtkDataArray /*(vtkDataArray*)*/ output) {
	VTK_API.API_vtkPlane.EvaluateFunction_0(this, input, output);
}


// double EvaluateFunction(double x[3])
// "double EvaluateFunction(double x[3])"
public double EvaluateFunction(double /*(double[3])*/ []x) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPlane.EvaluateFunction_1(out returnPointer, this, x);
//	return (double)returnPointer;
	return returnPointer;
}


// void EvaluateGradient(double x[3], double g[3])
// "void EvaluateGradient(double x[3], double g[3])"
public void EvaluateGradient(double /*(double[3])*/ []x, double /*(double[3])*/ []g) {
	VTK_API.API_vtkPlane.EvaluateGradient_0(this, x, g);
}


// virtual void SetNormal(double _arg1, double _arg2, double _arg3)
// "virtual void SetNormal (double _arg1, double _arg2, double _arg3)"
public void SetNormal(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkPlane.SetNormal_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetNormal(double _arg[3])
// "virtual void SetNormal (double _arg[3])"
public void SetNormal(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkPlane.SetNormal_1(this, _arg);
}


// virtual double* GetNormal()
// "virtual double *GetNormal ()"
public double[] GetNormal() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPlane.GetNormal_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetNormal(double data[3])
// "virtual void GetNormal (double data[3])"
public void GetNormal(double /*(double[3])*/ []data) {
	VTK_API.API_vtkPlane.GetNormal_1(this, data);
}


// virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
// "virtual void SetOrigin (double _arg1, double _arg2, double _arg3)"
public void SetOrigin(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkPlane.SetOrigin_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetOrigin(double _arg[3])
// "virtual void SetOrigin (double _arg[3])"
public void SetOrigin(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkPlane.SetOrigin_1(this, _arg);
}


// virtual double* GetOrigin()
// "virtual double *GetOrigin ()"
public double[] GetOrigin() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkPlane.GetOrigin_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetOrigin(double data[3])
// "virtual void GetOrigin (double data[3])"
public void GetOrigin(double /*(double[3])*/ []data) {
	VTK_API.API_vtkPlane.GetOrigin_1(this, data);
}


// void Push(double distance)
// "void Push(double distance)"
public void Push(double /*(double)*/ distance) {
	VTK_API.API_vtkPlane.Push_0(this, distance);
}


// static void ProjectPoint(const double x[3], const double origin[3], const double normal[3], double xproj[3])
// "static void ProjectPoint(const double x[3], const double origin[3], const double normal[3], double xproj[3])"
public static void ProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.ProjectPoint_0(x, origin, normal, xproj);
}


// void ProjectPoint(const double x[3], double xproj[3])
// "void ProjectPoint(const double x[3], double xproj[3])"
public void ProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.ProjectPoint_1(this, x, xproj);
}


// static void ProjectVector(const double v[3], const double origin[3], const double normal[3], double vproj[3])
// "static void ProjectVector(const double v[3], const double origin[3], const double normal[3], double vproj[3])"
public static void ProjectVector(double /*(double[3])*/ []v, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []vproj) {
	VTK_API.API_vtkPlane.ProjectVector_0(v, origin, normal, vproj);
}


// void ProjectVector(const double v[3], double vproj[3])
// "void ProjectVector(const double v[3], double vproj[3])"
public void ProjectVector(double /*(double[3])*/ []v, double /*(double[3])*/ []vproj) {
	VTK_API.API_vtkPlane.ProjectVector_1(this, v, vproj);
}


// static void GeneralizedProjectPoint(const double x[3], const double origin[3], const double normal[3], double xproj[3])
// "static void GeneralizedProjectPoint(const double x[3], const double origin[3], const double normal[3], double xproj[3])"
public static void GeneralizedProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []origin, double /*(double[3])*/ []normal, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.GeneralizedProjectPoint_0(x, origin, normal, xproj);
}


// void GeneralizedProjectPoint(const double x[3], double xproj[3])
// "void GeneralizedProjectPoint(const double x[3], double xproj[3])"
public void GeneralizedProjectPoint(double /*(double[3])*/ []x, double /*(double[3])*/ []xproj) {
	VTK_API.API_vtkPlane.GeneralizedProjectPoint_1(this, x, xproj);
}


// static double Evaluate(double normal[3], double origin[3], double x[3])
// "static double Evaluate(double normal[3], double origin[3], double x[3])"
public static double Evaluate(double /*(double[3])*/ []normal, double /*(double[3])*/ []origin, double /*(double[3])*/ []x) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPlane.Evaluate_0(out returnPointer, normal, origin, x);
//	return (double)returnPointer;
	return returnPointer;
}


// static double DistanceToPlane(double x[3], double n[3], double p0[3])
// "static double DistanceToPlane(double x[3], double n[3], double p0[3])"
public static double DistanceToPlane(double /*(double[3])*/ []x, double /*(double[3])*/ []n, double /*(double[3])*/ []p0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPlane.DistanceToPlane_0(out returnPointer, x, n, p0);
//	return (double)returnPointer;
	return returnPointer;
}


// double DistanceToPlane(double x[3])
// "double DistanceToPlane(double x[3])"
public double DistanceToPlane(double /*(double[3])*/ []x) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPlane.DistanceToPlane_1(out returnPointer, this, x);
//	return (double)returnPointer;
	return returnPointer;
}


// static int IntersectWithLine(const double p1[3], const double p2[3], double n[3], double p0[3], double & t, double x[3])
// "static int IntersectWithLine(const double p1[3], const double p2[3], double n[3], double p0[3], double& t, double x[3])"
public static int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, double /*(double[3])*/ []n, double /*(double[3])*/ []p0, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPlane.IntersectWithLine_0(out returnPointer, p1, p2, n, p0, t, x);
//	return (int)returnPointer;
	return returnPointer;
}


// int IntersectWithLine(const double p1[3], const double p2[3], double & t, double x[3])
// "int IntersectWithLine(const double p1[3], const double p2[3], double& t, double x[3])"
public int IntersectWithLine(double /*(double[3])*/ []p1, double /*(double[3])*/ []p2, IntPtr /*(double&)*/ t, double /*(double[3])*/ []x) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPlane.IntersectWithLine_1(out returnPointer, this, p1, p2, t, x);
//	return (int)returnPointer;
	return returnPointer;
}


// static int IntersectWithFinitePlane(double n[3], double o[3], double pOrigin[3], double px[3], double py[3], double x0[3], double x1[3])
// "static int IntersectWithFinitePlane(double n[3], double o[3], double pOrigin[3], double px[3], double py[3], double x0[3], double x1[3])"
public static int IntersectWithFinitePlane(double /*(double[3])*/ []n, double /*(double[3])*/ []o, double /*(double[3])*/ []pOrigin, double /*(double[3])*/ []px, double /*(double[3])*/ []py, double /*(double[3])*/ []x0, double /*(double[3])*/ []x1) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPlane.IntersectWithFinitePlane_0(out returnPointer, n, o, pOrigin, px, py, x0, x1);
//	return (int)returnPointer;
	return returnPointer;
}


// int IntersectWithFinitePlane(double pOrigin[3], double px[3], double py[3], double x0[3], double x1[3])
// "int IntersectWithFinitePlane(double pOrigin[3], double px[3], double py[3], double x0[3], double x1[3])"
public int IntersectWithFinitePlane(double /*(double[3])*/ []pOrigin, double /*(double[3])*/ []px, double /*(double[3])*/ []py, double /*(double[3])*/ []x0, double /*(double[3])*/ []x1) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPlane.IntersectWithFinitePlane_1(out returnPointer, this, pOrigin, px, py, x0, x1);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
