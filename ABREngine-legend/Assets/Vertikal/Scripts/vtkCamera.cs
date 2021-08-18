

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCamera : vtkObject {
		public vtkCamera(IntPtr p) : base(p) {}
		public static implicit operator  vtkCamera(IntPtr p) {return new vtkCamera(p);}
		public static implicit operator  IntPtr(vtkCamera o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCamera* SafeDownCast(vtkObjectBase * o)
// "static vtkCamera* SafeDownCast(vtkObjectBase *o)"
public static vtkCamera SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.SafeDownCast_0(out returnPointer, o);
//	return (vtkCamera)(IntPtr)returnPointer;
	return (vtkCamera)(IntPtr)returnPointer;
}


// vtkCamera* NewInstance()
// "vtkCamera *NewInstance()"
public vtkCamera NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.NewInstance_0(out returnPointer, this);
//	return (vtkCamera)(IntPtr)returnPointer;
	return (vtkCamera)(IntPtr)returnPointer;
}


// static vtkCamera* New()
// "static vtkCamera *New()"
public static vtkCamera New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.New_0(out returnPointer);
//	return (vtkCamera)(IntPtr)returnPointer;
	return (vtkCamera)(IntPtr)returnPointer;
}


// void SetPosition(double x, double y, double z)
// "void SetPosition(double x, double y, double z)"
public void SetPosition(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkCamera.SetPosition_0(this, x, y, z);
}


// void SetPosition(const double a[3])
// "void SetPosition(const double a[3])"
public void SetPosition(double /*(double[3])*/ []a) {
	VTK_API.API_vtkCamera.SetPosition_1(this, a);
}


// virtual double* GetPosition()
// "virtual double *GetPosition ()"
public double[] GetPosition() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetPosition_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetPosition(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetPosition (double &_arg1, double &_arg2, double &_arg3)"
public void GetPosition(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetPosition_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetPosition(double _arg[3])
// "virtual void GetPosition (double _arg[3])"
public void GetPosition(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetPosition_2(this, _arg);
}


// void SetFocalPoint(double x, double y, double z)
// "void SetFocalPoint(double x, double y, double z)"
public void SetFocalPoint(double /*(double)*/ x, double /*(double)*/ y, double /*(double)*/ z) {
	VTK_API.API_vtkCamera.SetFocalPoint_0(this, x, y, z);
}


// void SetFocalPoint(const double a[3])
// "void SetFocalPoint(const double a[3])"
public void SetFocalPoint(double /*(double[3])*/ []a) {
	VTK_API.API_vtkCamera.SetFocalPoint_1(this, a);
}


// virtual double* GetFocalPoint()
// "virtual double *GetFocalPoint ()"
public double[] GetFocalPoint() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetFocalPoint_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetFocalPoint(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetFocalPoint (double &_arg1, double &_arg2, double &_arg3)"
public void GetFocalPoint(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetFocalPoint_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetFocalPoint(double _arg[3])
// "virtual void GetFocalPoint (double _arg[3])"
public void GetFocalPoint(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetFocalPoint_2(this, _arg);
}


// void SetViewUp(double vx, double vy, double vz)
// "void SetViewUp(double vx, double vy, double vz)"
public void SetViewUp(double /*(double)*/ vx, double /*(double)*/ vy, double /*(double)*/ vz) {
	VTK_API.API_vtkCamera.SetViewUp_0(this, vx, vy, vz);
}


// void SetViewUp(const double a[3])
// "void SetViewUp(const double a[3])"
public void SetViewUp(double /*(double[3])*/ []a) {
	VTK_API.API_vtkCamera.SetViewUp_1(this, a);
}


// virtual double* GetViewUp()
// "virtual double *GetViewUp ()"
public double[] GetViewUp() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetViewUp_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetViewUp(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetViewUp (double &_arg1, double &_arg2, double &_arg3)"
public void GetViewUp(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetViewUp_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetViewUp(double _arg[3])
// "virtual void GetViewUp (double _arg[3])"
public void GetViewUp(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetViewUp_2(this, _arg);
}


// void OrthogonalizeViewUp()
// "void OrthogonalizeViewUp()"
public void OrthogonalizeViewUp() {
	VTK_API.API_vtkCamera.OrthogonalizeViewUp_0(this);
}


// void SetDistance(double ARG_0)
// "void SetDistance(double)"
public void SetDistance(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkCamera.SetDistance_0(this, ARG_0);
}


// virtual double GetDistance()
// "virtual double GetDistance ()"
public double GetDistance() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetDistance_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double* GetDirectionOfProjection()
// "virtual double *GetDirectionOfProjection ()"
public double[] GetDirectionOfProjection() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetDirectionOfProjection_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetDirectionOfProjection(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetDirectionOfProjection (double &_arg1, double &_arg2, double &_arg3)"
public void GetDirectionOfProjection(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetDirectionOfProjection_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetDirectionOfProjection(double _arg[3])
// "virtual void GetDirectionOfProjection (double _arg[3])"
public void GetDirectionOfProjection(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetDirectionOfProjection_2(this, _arg);
}


// void Dolly(double value)
// "void Dolly(double value)"
public void Dolly(double /*(double)*/ value) {
	VTK_API.API_vtkCamera.Dolly_0(this, value);
}


// void SetRoll(double angle)
// "void SetRoll(double angle)"
public void SetRoll(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.SetRoll_0(this, angle);
}


// double GetRoll()
// "double GetRoll()"
public double GetRoll() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetRoll_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void Roll(double angle)
// "void Roll(double angle)"
public void Roll(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.Roll_0(this, angle);
}


// void Azimuth(double angle)
// "void Azimuth(double angle)"
public void Azimuth(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.Azimuth_0(this, angle);
}


// void Yaw(double angle)
// "void Yaw(double angle)"
public void Yaw(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.Yaw_0(this, angle);
}


// void Elevation(double angle)
// "void Elevation(double angle)"
public void Elevation(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.Elevation_0(this, angle);
}


// void Pitch(double angle)
// "void Pitch(double angle)"
public void Pitch(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.Pitch_0(this, angle);
}


// void SetParallelProjection(vtkTypeBool flag)
// "void SetParallelProjection(vtkTypeBool flag)"
public void SetParallelProjection(bool /*(vtkTypeBool)*/ flag) {
	VTK_API.API_vtkCamera.SetParallelProjection_0(this, flag);
}


// virtual vtkTypeBool GetParallelProjection()
// "virtual vtkTypeBool GetParallelProjection ()"
public bool GetParallelProjection() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.GetParallelProjection_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ParallelProjectionOn()
// "virtual void ParallelProjectionOn ()"
public void ParallelProjectionOn() {
	VTK_API.API_vtkCamera.ParallelProjectionOn_0(this);
}


// virtual void ParallelProjectionOff()
// "virtual void ParallelProjectionOff ()"
public void ParallelProjectionOff() {
	VTK_API.API_vtkCamera.ParallelProjectionOff_0(this);
}


// void SetUseHorizontalViewAngle(vtkTypeBool flag)
// "void SetUseHorizontalViewAngle(vtkTypeBool flag)"
public void SetUseHorizontalViewAngle(bool /*(vtkTypeBool)*/ flag) {
	VTK_API.API_vtkCamera.SetUseHorizontalViewAngle_0(this, flag);
}


// virtual vtkTypeBool GetUseHorizontalViewAngle()
// "virtual vtkTypeBool GetUseHorizontalViewAngle ()"
public bool GetUseHorizontalViewAngle() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.GetUseHorizontalViewAngle_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseHorizontalViewAngleOn()
// "virtual void UseHorizontalViewAngleOn ()"
public void UseHorizontalViewAngleOn() {
	VTK_API.API_vtkCamera.UseHorizontalViewAngleOn_0(this);
}


// virtual void UseHorizontalViewAngleOff()
// "virtual void UseHorizontalViewAngleOff ()"
public void UseHorizontalViewAngleOff() {
	VTK_API.API_vtkCamera.UseHorizontalViewAngleOff_0(this);
}


// void SetViewAngle(double angle)
// "void SetViewAngle(double angle)"
public void SetViewAngle(double /*(double)*/ angle) {
	VTK_API.API_vtkCamera.SetViewAngle_0(this, angle);
}


// virtual double GetViewAngle()
// "virtual double GetViewAngle ()"
public double GetViewAngle() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetViewAngle_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void SetParallelScale(double scale)
// "void SetParallelScale(double scale)"
public void SetParallelScale(double /*(double)*/ scale) {
	VTK_API.API_vtkCamera.SetParallelScale_0(this, scale);
}


// virtual double GetParallelScale()
// "virtual double GetParallelScale ()"
public double GetParallelScale() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetParallelScale_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void Zoom(double factor)
// "void Zoom(double factor)"
public void Zoom(double /*(double)*/ factor) {
	VTK_API.API_vtkCamera.Zoom_0(this, factor);
}


// void SetClippingRange(double dNear, double dFar)
// "void SetClippingRange(double dNear, double dFar)"
public void SetClippingRange(double /*(double)*/ dNear, double /*(double)*/ dFar) {
	VTK_API.API_vtkCamera.SetClippingRange_0(this, dNear, dFar);
}


// void SetClippingRange(const double a[2])
// "void SetClippingRange(const double a[2])"
public void SetClippingRange(double /*(double[2])*/ []a) {
	VTK_API.API_vtkCamera.SetClippingRange_1(this, a);
}


// virtual double* GetClippingRange()
// "virtual double *GetClippingRange ()"
public double[] GetClippingRange() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetClippingRange_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetClippingRange(double & _arg1, double & _arg2)
// "virtual void GetClippingRange (double &_arg1, double &_arg2)"
public void GetClippingRange(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkCamera.GetClippingRange_1(this, _arg1, _arg2);
}


// virtual void GetClippingRange(double _arg[2])
// "virtual void GetClippingRange (double _arg[2])"
public void GetClippingRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkCamera.GetClippingRange_2(this, _arg);
}


// void SetThickness(double ARG_0)
// "void SetThickness(double)"
public void SetThickness(double /*(double)*/ ARG_0) {
	VTK_API.API_vtkCamera.SetThickness_0(this, ARG_0);
}


// virtual double GetThickness()
// "virtual double GetThickness ()"
public double GetThickness() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetThickness_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void SetWindowCenter(double x, double y)
// "void SetWindowCenter(double x, double y)"
public void SetWindowCenter(double /*(double)*/ x, double /*(double)*/ y) {
	VTK_API.API_vtkCamera.SetWindowCenter_0(this, x, y);
}


// virtual double* GetWindowCenter()
// "virtual double *GetWindowCenter ()"
public double[] GetWindowCenter() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetWindowCenter_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetWindowCenter(double & _arg1, double & _arg2)
// "virtual void GetWindowCenter (double &_arg1, double &_arg2)"
public void GetWindowCenter(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2) {
	VTK_API.API_vtkCamera.GetWindowCenter_1(this, _arg1, _arg2);
}


// virtual void GetWindowCenter(double _arg[2])
// "virtual void GetWindowCenter (double _arg[2])"
public void GetWindowCenter(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkCamera.GetWindowCenter_2(this, _arg);
}


// void SetObliqueAngles(double alpha, double beta)
// "void SetObliqueAngles(double alpha, double beta)"
public void SetObliqueAngles(double /*(double)*/ alpha, double /*(double)*/ beta) {
	VTK_API.API_vtkCamera.SetObliqueAngles_0(this, alpha, beta);
}


// void ApplyTransform(vtkTransform * t)
// "void ApplyTransform(vtkTransform *t)"
public void ApplyTransform(vtkTransform /*(vtkTransform*)*/ t) {
	VTK_API.API_vtkCamera.ApplyTransform_0(this, t);
}


// virtual double* GetViewPlaneNormal()
// "virtual double *GetViewPlaneNormal ()"
public double[] GetViewPlaneNormal() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetViewPlaneNormal_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetViewPlaneNormal(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetViewPlaneNormal (double &_arg1, double &_arg2, double &_arg3)"
public void GetViewPlaneNormal(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetViewPlaneNormal_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetViewPlaneNormal(double _arg[3])
// "virtual void GetViewPlaneNormal (double _arg[3])"
public void GetViewPlaneNormal(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetViewPlaneNormal_2(this, _arg);
}


// void SetViewShear(double dxdz, double dydz, double center)
// "void SetViewShear(double dxdz, double dydz, double center)"
public void SetViewShear(double /*(double)*/ dxdz, double /*(double)*/ dydz, double /*(double)*/ center) {
	VTK_API.API_vtkCamera.SetViewShear_0(this, dxdz, dydz, center);
}


// void SetViewShear(double d[3])
// "void SetViewShear(double d[3])"
public void SetViewShear(double /*(double[3])*/ []d) {
	VTK_API.API_vtkCamera.SetViewShear_1(this, d);
}


// virtual double* GetViewShear()
// "virtual double *GetViewShear ()"
public double[] GetViewShear() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetViewShear_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetViewShear(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetViewShear (double &_arg1, double &_arg2, double &_arg3)"
public void GetViewShear(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetViewShear_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetViewShear(double _arg[3])
// "virtual void GetViewShear (double _arg[3])"
public void GetViewShear(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetViewShear_2(this, _arg);
}


// virtual void SetEyeAngle(double _arg)
// "virtual void SetEyeAngle (double _arg)"
public void SetEyeAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkCamera.SetEyeAngle_0(this, _arg);
}


// virtual double GetEyeAngle()
// "virtual double GetEyeAngle ()"
public double GetEyeAngle() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetEyeAngle_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetFocalDisk(double _arg)
// "virtual void SetFocalDisk (double _arg)"
public void SetFocalDisk(double /*(double)*/ _arg) {
	VTK_API.API_vtkCamera.SetFocalDisk_0(this, _arg);
}


// virtual double GetFocalDisk()
// "virtual double GetFocalDisk ()"
public double GetFocalDisk() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetFocalDisk_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetUseOffAxisProjection(vtkTypeBool _arg)
// "virtual void SetUseOffAxisProjection (vtkTypeBool _arg)"
public void SetUseOffAxisProjection(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkCamera.SetUseOffAxisProjection_0(this, _arg);
}


// virtual vtkTypeBool GetUseOffAxisProjection()
// "virtual vtkTypeBool GetUseOffAxisProjection ()"
public bool GetUseOffAxisProjection() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.GetUseOffAxisProjection_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseOffAxisProjectionOn()
// "virtual void UseOffAxisProjectionOn ()"
public void UseOffAxisProjectionOn() {
	VTK_API.API_vtkCamera.UseOffAxisProjectionOn_0(this);
}


// virtual void UseOffAxisProjectionOff()
// "virtual void UseOffAxisProjectionOff ()"
public void UseOffAxisProjectionOff() {
	VTK_API.API_vtkCamera.UseOffAxisProjectionOff_0(this);
}


// virtual void SetScreenBottomLeft(double _arg1, double _arg2, double _arg3)
// "virtual void SetScreenBottomLeft (double _arg1, double _arg2, double _arg3)"
public void SetScreenBottomLeft(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkCamera.SetScreenBottomLeft_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetScreenBottomLeft(double _arg[3])
// "virtual void SetScreenBottomLeft (double _arg[3])"
public void SetScreenBottomLeft(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.SetScreenBottomLeft_1(this, _arg);
}


// virtual double* GetScreenBottomLeft()
// "virtual double *GetScreenBottomLeft ()"
public double[] GetScreenBottomLeft() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetScreenBottomLeft_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetScreenBottomLeft(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetScreenBottomLeft (double &_arg1, double &_arg2, double &_arg3)"
public void GetScreenBottomLeft(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetScreenBottomLeft_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetScreenBottomLeft(double _arg[3])
// "virtual void GetScreenBottomLeft (double _arg[3])"
public void GetScreenBottomLeft(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetScreenBottomLeft_2(this, _arg);
}


// virtual void SetScreenBottomRight(double _arg1, double _arg2, double _arg3)
// "virtual void SetScreenBottomRight (double _arg1, double _arg2, double _arg3)"
public void SetScreenBottomRight(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkCamera.SetScreenBottomRight_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetScreenBottomRight(double _arg[3])
// "virtual void SetScreenBottomRight (double _arg[3])"
public void SetScreenBottomRight(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.SetScreenBottomRight_1(this, _arg);
}


// virtual double* GetScreenBottomRight()
// "virtual double *GetScreenBottomRight ()"
public double[] GetScreenBottomRight() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetScreenBottomRight_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetScreenBottomRight(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetScreenBottomRight (double &_arg1, double &_arg2, double &_arg3)"
public void GetScreenBottomRight(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetScreenBottomRight_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetScreenBottomRight(double _arg[3])
// "virtual void GetScreenBottomRight (double _arg[3])"
public void GetScreenBottomRight(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetScreenBottomRight_2(this, _arg);
}


// virtual void SetScreenTopRight(double _arg1, double _arg2, double _arg3)
// "virtual void SetScreenTopRight (double _arg1, double _arg2, double _arg3)"
public void SetScreenTopRight(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkCamera.SetScreenTopRight_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetScreenTopRight(double _arg[3])
// "virtual void SetScreenTopRight (double _arg[3])"
public void SetScreenTopRight(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.SetScreenTopRight_1(this, _arg);
}


// virtual double* GetScreenTopRight()
// "virtual double *GetScreenTopRight ()"
public double[] GetScreenTopRight() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetScreenTopRight_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetScreenTopRight(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetScreenTopRight (double &_arg1, double &_arg2, double &_arg3)"
public void GetScreenTopRight(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkCamera.GetScreenTopRight_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetScreenTopRight(double _arg[3])
// "virtual void GetScreenTopRight (double _arg[3])"
public void GetScreenTopRight(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkCamera.GetScreenTopRight_2(this, _arg);
}


// virtual void SetEyeSeparation(double _arg)
// "virtual void SetEyeSeparation (double _arg)"
public void SetEyeSeparation(double /*(double)*/ _arg) {
	VTK_API.API_vtkCamera.SetEyeSeparation_0(this, _arg);
}


// virtual double GetEyeSeparation()
// "virtual double GetEyeSeparation ()"
public double GetEyeSeparation() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCamera.GetEyeSeparation_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void SetEyePosition(double eyePosition[3])
// "void SetEyePosition(double eyePosition[3])"
public void SetEyePosition(double /*(double[3])*/ []eyePosition) {
	VTK_API.API_vtkCamera.SetEyePosition_0(this, eyePosition);
}


// void GetEyePosition(double eyePosition[3])
// "void GetEyePosition(double eyePosition[3])"
public void GetEyePosition(double /*(double[3])*/ []eyePosition) {
	VTK_API.API_vtkCamera.GetEyePosition_0(this, eyePosition);
}


// void GetEyePlaneNormal(double normal[3])
// "void GetEyePlaneNormal(double normal[3])"
public void GetEyePlaneNormal(double /*(double[3])*/ []normal) {
	VTK_API.API_vtkCamera.GetEyePlaneNormal_0(this, normal);
}


// void SetEyeTransformMatrix(vtkMatrix4x4 * matrix)
// "void SetEyeTransformMatrix(vtkMatrix4x4* matrix)"
public void SetEyeTransformMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkCamera.SetEyeTransformMatrix_0(this, matrix);
}


// virtual vtkMatrix4x4* GetEyeTransformMatrix()
// "virtual vtkMatrix4x4 *GetEyeTransformMatrix ()"
public vtkMatrix4x4 GetEyeTransformMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetEyeTransformMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// void SetEyeTransformMatrix(const double elements[16])
// "void SetEyeTransformMatrix(const double elements[16])"
public void SetEyeTransformMatrix(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkCamera.SetEyeTransformMatrix_1(this, elements);
}


// void SetModelTransformMatrix(vtkMatrix4x4 * matrix)
// "void SetModelTransformMatrix(vtkMatrix4x4 *matrix)"
public void SetModelTransformMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ matrix) {
	VTK_API.API_vtkCamera.SetModelTransformMatrix_0(this, matrix);
}


// virtual vtkMatrix4x4* GetModelTransformMatrix()
// "virtual vtkMatrix4x4 *GetModelTransformMatrix ()"
public vtkMatrix4x4 GetModelTransformMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetModelTransformMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// void SetModelTransformMatrix(const double elements[16])
// "void SetModelTransformMatrix(const double elements[16])"
public void SetModelTransformMatrix(double /*(double[16])*/ []elements) {
	VTK_API.API_vtkCamera.SetModelTransformMatrix_1(this, elements);
}


// virtual vtkMatrix4x4* GetModelViewTransformMatrix()
// "virtual vtkMatrix4x4 *GetModelViewTransformMatrix()"
public vtkMatrix4x4 GetModelViewTransformMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetModelViewTransformMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual vtkTransform* GetModelViewTransformObject()
// "virtual vtkTransform *GetModelViewTransformObject()"
public vtkTransform GetModelViewTransformObject() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetModelViewTransformObject_0(out returnPointer, this);
//	return (vtkTransform)(IntPtr)returnPointer;
	return (vtkTransform)(IntPtr)returnPointer;
}


// virtual vtkMatrix4x4* GetViewTransformMatrix()
// "virtual vtkMatrix4x4 *GetViewTransformMatrix()"
public vtkMatrix4x4 GetViewTransformMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetViewTransformMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual vtkTransform* GetViewTransformObject()
// "virtual vtkTransform *GetViewTransformObject()"
public vtkTransform GetViewTransformObject() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetViewTransformObject_0(out returnPointer, this);
//	return (vtkTransform)(IntPtr)returnPointer;
	return (vtkTransform)(IntPtr)returnPointer;
}


// virtual void SetExplicitProjectionTransformMatrix(vtkMatrix4x4 * ARG_0)
// "virtual void SetExplicitProjectionTransformMatrix(vtkMatrix4x4*)"
public void SetExplicitProjectionTransformMatrix(vtkMatrix4x4 /*(vtkMatrix4x4*)*/ ARG_0) {
	VTK_API.API_vtkCamera.SetExplicitProjectionTransformMatrix_0(this, ARG_0);
}


// virtual vtkMatrix4x4* GetExplicitProjectionTransformMatrix()
// "virtual vtkMatrix4x4 *GetExplicitProjectionTransformMatrix ()"
public vtkMatrix4x4 GetExplicitProjectionTransformMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetExplicitProjectionTransformMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual void SetUseExplicitProjectionTransformMatrix(bool _arg)
// "virtual void SetUseExplicitProjectionTransformMatrix (bool _arg)"
public void SetUseExplicitProjectionTransformMatrix(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkCamera.SetUseExplicitProjectionTransformMatrix_0(this, _arg);
}


// virtual bool GetUseExplicitProjectionTransformMatrix()
// "virtual bool GetUseExplicitProjectionTransformMatrix ()"
public bool GetUseExplicitProjectionTransformMatrix() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.GetUseExplicitProjectionTransformMatrix_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseExplicitProjectionTransformMatrixOn()
// "virtual void UseExplicitProjectionTransformMatrixOn ()"
public void UseExplicitProjectionTransformMatrixOn() {
	VTK_API.API_vtkCamera.UseExplicitProjectionTransformMatrixOn_0(this);
}


// virtual void UseExplicitProjectionTransformMatrixOff()
// "virtual void UseExplicitProjectionTransformMatrixOff ()"
public void UseExplicitProjectionTransformMatrixOff() {
	VTK_API.API_vtkCamera.UseExplicitProjectionTransformMatrixOff_0(this);
}


// virtual vtkMatrix4x4* GetProjectionTransformMatrix(double aspect, double nearz, double farz)
// "virtual vtkMatrix4x4 *GetProjectionTransformMatrix(double aspect, double nearz, double farz)"
public vtkMatrix4x4 GetProjectionTransformMatrix(double /*(double)*/ aspect, double /*(double)*/ nearz, double /*(double)*/ farz) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetProjectionTransformMatrix_0(out returnPointer, this, aspect, nearz, farz);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual vtkPerspectiveTransform* GetProjectionTransformObject(double aspect, double nearz, double farz)
// "virtual vtkPerspectiveTransform *GetProjectionTransformObject(double aspect, double nearz, double farz)"
public vtkPerspectiveTransform GetProjectionTransformObject(double /*(double)*/ aspect, double /*(double)*/ nearz, double /*(double)*/ farz) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetProjectionTransformObject_0(out returnPointer, this, aspect, nearz, farz);
//	return (vtkPerspectiveTransform)(IntPtr)returnPointer;
	return (vtkPerspectiveTransform)(IntPtr)returnPointer;
}


// virtual vtkMatrix4x4* GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)
// "virtual vtkMatrix4x4 *GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)"
public vtkMatrix4x4 GetCompositeProjectionTransformMatrix(double /*(double)*/ aspect, double /*(double)*/ nearz, double /*(double)*/ farz) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetCompositeProjectionTransformMatrix_0(out returnPointer, this, aspect, nearz, farz);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual vtkMatrix4x4* GetProjectionTransformMatrix(vtkRenderer * ren)
// "virtual vtkMatrix4x4 *GetProjectionTransformMatrix(vtkRenderer *ren)"
public vtkMatrix4x4 GetProjectionTransformMatrix(vtkRenderer /*(vtkRenderer*)*/ ren) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetProjectionTransformMatrix_1(out returnPointer, this, ren);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// void SetUserViewTransform(vtkHomogeneousTransform * transform)
// "void SetUserViewTransform(vtkHomogeneousTransform *transform)"
public void SetUserViewTransform(vtkHomogeneousTransform /*(vtkHomogeneousTransform*)*/ transform) {
	VTK_API.API_vtkCamera.SetUserViewTransform_0(this, transform);
}


// virtual vtkHomogeneousTransform* GetUserViewTransform()
// "virtual vtkHomogeneousTransform *GetUserViewTransform ()"
public vtkHomogeneousTransform GetUserViewTransform() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetUserViewTransform_0(out returnPointer, this);
//	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// void SetUserTransform(vtkHomogeneousTransform * transform)
// "void SetUserTransform(vtkHomogeneousTransform *transform)"
public void SetUserTransform(vtkHomogeneousTransform /*(vtkHomogeneousTransform*)*/ transform) {
	VTK_API.API_vtkCamera.SetUserTransform_0(this, transform);
}


// virtual vtkHomogeneousTransform* GetUserTransform()
// "virtual vtkHomogeneousTransform *GetUserTransform ()"
public vtkHomogeneousTransform GetUserTransform() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetUserTransform_0(out returnPointer, this);
//	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
	return (vtkHomogeneousTransform)(IntPtr)returnPointer;
}


// virtual void Render(vtkRenderer * ARG_0)
// "virtual void Render(vtkRenderer *)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkCamera.Render_0(this, ARG_0);
}


// vtkMTimeType GetViewingRaysMTime()
// "vtkMTimeType GetViewingRaysMTime()"
public ulong GetViewingRaysMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkCamera.GetViewingRaysMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void ViewingRaysModified()
// "void ViewingRaysModified()"
public void ViewingRaysModified() {
	VTK_API.API_vtkCamera.ViewingRaysModified_0(this);
}


// virtual void GetFrustumPlanes(double aspect, double planes[24])
// "virtual void GetFrustumPlanes(double aspect, double planes[24])"
public void GetFrustumPlanes(double /*(double)*/ aspect, double /*(double[24])*/ []planes) {
	VTK_API.API_vtkCamera.GetFrustumPlanes_0(this, aspect, planes);
}


// double* GetOrientation()
// "double *GetOrientation()"
public double[] GetOrientation() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetOrientation_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// double* GetOrientationWXYZ()
// "double *GetOrientationWXYZ()"
public double[] GetOrientationWXYZ() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkCamera.GetOrientationWXYZ_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void ComputeViewPlaneNormal()
// "void ComputeViewPlaneNormal()"
public void ComputeViewPlaneNormal() {
	VTK_API.API_vtkCamera.ComputeViewPlaneNormal_0(this);
}


// vtkMatrix4x4* GetCameraLightTransformMatrix()
// "vtkMatrix4x4 *GetCameraLightTransformMatrix()"
public vtkMatrix4x4 GetCameraLightTransformMatrix() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCamera.GetCameraLightTransformMatrix_0(out returnPointer, this);
//	return (vtkMatrix4x4)(IntPtr)returnPointer;
	return (vtkMatrix4x4)(IntPtr)returnPointer;
}


// virtual void UpdateViewport(vtkRenderer * ARG_0)
// "virtual void UpdateViewport(vtkRenderer *)"
public void UpdateViewport(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkCamera.UpdateViewport_0(this, ARG_0);
}


// virtual void SetLeftEye(int _arg)
// "virtual void SetLeftEye (int _arg)"
public void SetLeftEye(int /*(int)*/ _arg) {
	VTK_API.API_vtkCamera.SetLeftEye_0(this, _arg);
}


// virtual int GetLeftEye()
// "virtual int GetLeftEye ()"
public int GetLeftEye() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkCamera.GetLeftEye_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void ShallowCopy(vtkCamera * source)
// "void ShallowCopy(vtkCamera *source)"
public void ShallowCopy(vtkCamera /*(vtkCamera*)*/ source) {
	VTK_API.API_vtkCamera.ShallowCopy_0(this, source);
}


// void DeepCopy(vtkCamera * source)
// "void DeepCopy(vtkCamera *source)"
public void DeepCopy(vtkCamera /*(vtkCamera*)*/ source) {
	VTK_API.API_vtkCamera.DeepCopy_0(this, source);
}


// virtual void SetFreezeFocalPoint(bool _arg)
// "virtual void SetFreezeFocalPoint (bool _arg)"
public void SetFreezeFocalPoint(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkCamera.SetFreezeFocalPoint_0(this, _arg);
}


// virtual bool GetFreezeFocalPoint()
// "virtual bool GetFreezeFocalPoint ()"
public bool GetFreezeFocalPoint() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.GetFreezeFocalPoint_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetUseScissor(bool _arg)
// "virtual void SetUseScissor (bool _arg)"
public void SetUseScissor(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkCamera.SetUseScissor_0(this, _arg);
}


// virtual bool GetUseScissor()
// "virtual bool GetUseScissor ()"
public bool GetUseScissor() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCamera.GetUseScissor_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


}
};
