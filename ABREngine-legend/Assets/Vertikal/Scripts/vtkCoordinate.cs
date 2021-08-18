

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCoordinate : vtkObject {
		public vtkCoordinate(IntPtr p) : base(p) {}
		public static implicit operator  vtkCoordinate(IntPtr p) {return new vtkCoordinate(p);}
		public static implicit operator  IntPtr(vtkCoordinate o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCoordinate.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCoordinate.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCoordinate* SafeDownCast(vtkObjectBase * o)
// "static vtkCoordinate* SafeDownCast(vtkObjectBase *o)"
public static vtkCoordinate SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCoordinate.SafeDownCast_0(out returnPointer, o);
//	return (vtkCoordinate)(IntPtr)returnPointer;
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// vtkCoordinate* NewInstance()
// "vtkCoordinate *NewInstance()"
public vtkCoordinate NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCoordinate.NewInstance_0(out returnPointer, this);
//	return (vtkCoordinate)(IntPtr)returnPointer;
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// static vtkCoordinate* New()
// "static vtkCoordinate* New()"
public static vtkCoordinate New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCoordinate.New_0(out returnPointer);
//	return (vtkCoordinate)(IntPtr)returnPointer;
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// virtual void SetCoordinateSystem(int _arg)
// "virtual void SetCoordinateSystem (int _arg)"
public void SetCoordinateSystem(int /*(int)*/ _arg) {
	VTK_API.API_vtkCoordinate.SetCoordinateSystem_0(this, _arg);
}


// virtual int GetCoordinateSystem()
// "virtual int GetCoordinateSystem ()"
public int GetCoordinateSystem() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCoordinate.GetCoordinateSystem_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetCoordinateSystemToDisplay()
// "void SetCoordinateSystemToDisplay()"
public void SetCoordinateSystemToDisplay() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToDisplay_0(this);
}


// void SetCoordinateSystemToNormalizedDisplay()
// "void SetCoordinateSystemToNormalizedDisplay()"
public void SetCoordinateSystemToNormalizedDisplay() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToNormalizedDisplay_0(this);
}


// void SetCoordinateSystemToViewport()
// "void SetCoordinateSystemToViewport()"
public void SetCoordinateSystemToViewport() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToViewport_0(this);
}


// void SetCoordinateSystemToNormalizedViewport()
// "void SetCoordinateSystemToNormalizedViewport()"
public void SetCoordinateSystemToNormalizedViewport() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToNormalizedViewport_0(this);
}


// void SetCoordinateSystemToView()
// "void SetCoordinateSystemToView()"
public void SetCoordinateSystemToView() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToView_0(this);
}


// void SetCoordinateSystemToPose()
// "void SetCoordinateSystemToPose()"
public void SetCoordinateSystemToPose() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToPose_0(this);
}


// void SetCoordinateSystemToWorld()
// "void SetCoordinateSystemToWorld()"
public void SetCoordinateSystemToWorld() {
	VTK_API.API_vtkCoordinate.SetCoordinateSystemToWorld_0(this);
}


// char* GetCoordinateSystemAsString()
// "const char *GetCoordinateSystemAsString ()"
public string GetCoordinateSystemAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkCoordinate.GetCoordinateSystemAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetValue(double _arg1, double _arg2, double _arg3)
// "virtual void SetValue (double _arg1, double _arg2, double _arg3)"
public void SetValue(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkCoordinate.SetValue_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetValue(double _arg[3])
// "virtual void SetValue (double _arg[3])"
public void SetValue(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCoordinate.SetValue_1(this, _arg);
}


// virtual double* GetValue()
// "virtual double *GetValue ()"
public double[] GetValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCoordinate.GetValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetValue(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetValue (double &_arg1, double &_arg2, double &_arg3)"
public void GetValue(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCoordinate.GetValue_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetValue(double _arg[3])
// "virtual void GetValue (double _arg[3])"
public void GetValue(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCoordinate.GetValue_2(this, _arg);
}


// void SetValue(double a, double b)
// "void SetValue(double a, double b)"
public void SetValue(double /*(double)*/ a, double /*(double)*/ b) {
	VTK_API.API_vtkCoordinate.SetValue_2(this, a, b);
}


// virtual void SetReferenceCoordinate(vtkCoordinate * ARG_0)
// "virtual void SetReferenceCoordinate(vtkCoordinate*)"
public void SetReferenceCoordinate(vtkCoordinate /*(vtkCoordinate*)*/ ARG_0) {
	VTK_API.API_vtkCoordinate.SetReferenceCoordinate_0(this, ARG_0);
}


// virtual vtkCoordinate* GetReferenceCoordinate()
// "virtual vtkCoordinate *GetReferenceCoordinate ()"
public vtkCoordinate GetReferenceCoordinate() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCoordinate.GetReferenceCoordinate_0(out returnPointer, this);
//	return (vtkCoordinate)(IntPtr)returnPointer;
	return (vtkCoordinate)(IntPtr)returnPointer;
}


// void SetViewport(vtkViewport * viewport)
// "void SetViewport(vtkViewport *viewport)"
public void SetViewport(vtkViewport /*(vtkViewport*)*/ viewport) {
	VTK_API.API_vtkCoordinate.SetViewport_0(this, viewport);
}


// virtual vtkViewport* GetViewport()
// "virtual vtkViewport *GetViewport ()"
public vtkViewport GetViewport() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCoordinate.GetViewport_0(out returnPointer, this);
//	return (vtkViewport)(IntPtr)returnPointer;
	return (vtkViewport)(IntPtr)returnPointer;
}


// double* GetComputedWorldValue(vtkViewport * ARG_0)
// "double *GetComputedWorldValue(vtkViewport *)"
public double[] GetComputedWorldValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCoordinate.GetComputedWorldValue_0(out returnPointer, this, ARG_0);
//	return (double)returnPointer;
	return returnPointer;
}


// int* GetComputedViewportValue(vtkViewport * ARG_0)
// "int *GetComputedViewportValue(vtkViewport *)"
public int[] GetComputedViewportValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkCoordinate.GetComputedViewportValue_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int* GetComputedDisplayValue(vtkViewport * ARG_0)
// "int *GetComputedDisplayValue(vtkViewport *)"
public int[] GetComputedDisplayValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkCoordinate.GetComputedDisplayValue_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int* GetComputedLocalDisplayValue(vtkViewport * ARG_0)
// "int *GetComputedLocalDisplayValue(vtkViewport *)"
public int[] GetComputedLocalDisplayValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkCoordinate.GetComputedLocalDisplayValue_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// double* GetComputedDoubleViewportValue(vtkViewport * ARG_0)
// "double *GetComputedDoubleViewportValue(vtkViewport *)"
public double[] GetComputedDoubleViewportValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCoordinate.GetComputedDoubleViewportValue_0(out returnPointer, this, ARG_0);
//	return (double)returnPointer;
	return returnPointer;
}


// double* GetComputedDoubleDisplayValue(vtkViewport * ARG_0)
// "double *GetComputedDoubleDisplayValue(vtkViewport *)"
public double[] GetComputedDoubleDisplayValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCoordinate.GetComputedDoubleDisplayValue_0(out returnPointer, this, ARG_0);
//	return (double)returnPointer;
	return returnPointer;
}


// double* GetComputedValue(vtkViewport * ARG_0)
// "double *GetComputedValue(vtkViewport *)"
public double[] GetComputedValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCoordinate.GetComputedValue_0(out returnPointer, this, ARG_0);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double* GetComputedUserDefinedValue(vtkViewport * ARG_0)
// "virtual double *GetComputedUserDefinedValue(vtkViewport *)"
public double[] GetComputedUserDefinedValue(vtkViewport /*(vtkViewport*)*/ ARG_0) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCoordinate.GetComputedUserDefinedValue_0(out returnPointer, this, ARG_0);
//	return (double)returnPointer;
	return returnPointer;
}


}
};
