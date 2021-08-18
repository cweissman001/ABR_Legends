

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProperty : vtkObject {
		public vtkProperty(IntPtr p) : base(p) {}
		public static implicit operator  vtkProperty(IntPtr p) {return new vtkProperty(p);}
		public static implicit operator  IntPtr(vtkProperty o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkProperty* SafeDownCast(vtkObjectBase * o)
// "static vtkProperty* SafeDownCast(vtkObjectBase *o)"
public static vtkProperty SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProperty.SafeDownCast_0(out returnPointer, o);
//	return (vtkProperty)(IntPtr)returnPointer;
	return (vtkProperty)(IntPtr)returnPointer;
}


// vtkProperty* NewInstance()
// "vtkProperty *NewInstance()"
public vtkProperty NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProperty.NewInstance_0(out returnPointer, this);
//	return (vtkProperty)(IntPtr)returnPointer;
	return (vtkProperty)(IntPtr)returnPointer;
}


// static vtkProperty* New()
// "static vtkProperty *New()"
public static vtkProperty New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProperty.New_0(out returnPointer);
//	return (vtkProperty)(IntPtr)returnPointer;
	return (vtkProperty)(IntPtr)returnPointer;
}


// void DeepCopy(vtkProperty * p)
// "void DeepCopy(vtkProperty *p)"
public void DeepCopy(vtkProperty /*(vtkProperty*)*/ p) {
	VTK_API.API_vtkProperty.DeepCopy_0(this, p);
}


// virtual void Render(vtkActor * ARG_0, vtkRenderer * ARG_1)
// "virtual void Render(vtkActor *, vtkRenderer *)"
public void Render(vtkActor /*(vtkActor*)*/ ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	VTK_API.API_vtkProperty.Render_0(this, ARG_0, ARG_1);
}


// virtual void BackfaceRender(vtkActor * ARG_0, vtkRenderer * ARG_1)
// "virtual void BackfaceRender(vtkActor *, vtkRenderer *)"
public void BackfaceRender(vtkActor /*(vtkActor*)*/ ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	VTK_API.API_vtkProperty.BackfaceRender_0(this, ARG_0, ARG_1);
}


// virtual void PostRender(vtkActor * ARG_0, vtkRenderer * ARG_1)
// "virtual void PostRender(vtkActor*, vtkRenderer*)"
public void PostRender(vtkActor /*(vtkActor*)*/ ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
	VTK_API.API_vtkProperty.PostRender_0(this, ARG_0, ARG_1);
}


// virtual bool GetLighting()
// "virtual bool GetLighting ()"
public bool GetLighting() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetLighting_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetLighting(bool _arg)
// "virtual void SetLighting (bool _arg)"
public void SetLighting(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProperty.SetLighting_0(this, _arg);
}


// virtual void LightingOn()
// "virtual void LightingOn ()"
public void LightingOn() {
	VTK_API.API_vtkProperty.LightingOn_0(this);
}


// virtual void LightingOff()
// "virtual void LightingOff ()"
public void LightingOff() {
	VTK_API.API_vtkProperty.LightingOff_0(this);
}


// virtual bool GetRenderPointsAsSpheres()
// "virtual bool GetRenderPointsAsSpheres ()"
public bool GetRenderPointsAsSpheres() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetRenderPointsAsSpheres_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetRenderPointsAsSpheres(bool _arg)
// "virtual void SetRenderPointsAsSpheres (bool _arg)"
public void SetRenderPointsAsSpheres(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProperty.SetRenderPointsAsSpheres_0(this, _arg);
}


// virtual void RenderPointsAsSpheresOn()
// "virtual void RenderPointsAsSpheresOn ()"
public void RenderPointsAsSpheresOn() {
	VTK_API.API_vtkProperty.RenderPointsAsSpheresOn_0(this);
}


// virtual void RenderPointsAsSpheresOff()
// "virtual void RenderPointsAsSpheresOff ()"
public void RenderPointsAsSpheresOff() {
	VTK_API.API_vtkProperty.RenderPointsAsSpheresOff_0(this);
}


// virtual bool GetRenderLinesAsTubes()
// "virtual bool GetRenderLinesAsTubes ()"
public bool GetRenderLinesAsTubes() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetRenderLinesAsTubes_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetRenderLinesAsTubes(bool _arg)
// "virtual void SetRenderLinesAsTubes (bool _arg)"
public void SetRenderLinesAsTubes(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkProperty.SetRenderLinesAsTubes_0(this, _arg);
}


// virtual void RenderLinesAsTubesOn()
// "virtual void RenderLinesAsTubesOn ()"
public void RenderLinesAsTubesOn() {
	VTK_API.API_vtkProperty.RenderLinesAsTubesOn_0(this);
}


// virtual void RenderLinesAsTubesOff()
// "virtual void RenderLinesAsTubesOff ()"
public void RenderLinesAsTubesOff() {
	VTK_API.API_vtkProperty.RenderLinesAsTubesOff_0(this);
}


// virtual void SetInterpolation(int _arg)
// "virtual void SetInterpolation (int _arg)"
public void SetInterpolation(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetInterpolation_0(this, _arg);
}


// virtual int GetInterpolationMinValue()
// "virtual int GetInterpolationMinValue ()"
public int GetInterpolationMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetInterpolationMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetInterpolationMaxValue()
// "virtual int GetInterpolationMaxValue ()"
public int GetInterpolationMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetInterpolationMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetInterpolation()
// "virtual int GetInterpolation ()"
public int GetInterpolation() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetInterpolation_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetInterpolationToFlat()
// "void SetInterpolationToFlat()"
public void SetInterpolationToFlat() {
	VTK_API.API_vtkProperty.SetInterpolationToFlat_0(this);
}


// void SetInterpolationToGouraud()
// "void SetInterpolationToGouraud()"
public void SetInterpolationToGouraud() {
	VTK_API.API_vtkProperty.SetInterpolationToGouraud_0(this);
}


// void SetInterpolationToPhong()
// "void SetInterpolationToPhong()"
public void SetInterpolationToPhong() {
	VTK_API.API_vtkProperty.SetInterpolationToPhong_0(this);
}


// char* GetInterpolationAsString()
// "const char *GetInterpolationAsString()"
public string GetInterpolationAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkProperty.GetInterpolationAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetRepresentation(int _arg)
// "virtual void SetRepresentation (int _arg)"
public void SetRepresentation(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetRepresentation_0(this, _arg);
}


// virtual int GetRepresentationMinValue()
// "virtual int GetRepresentationMinValue ()"
public int GetRepresentationMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetRepresentationMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetRepresentationMaxValue()
// "virtual int GetRepresentationMaxValue ()"
public int GetRepresentationMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetRepresentationMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetRepresentation()
// "virtual int GetRepresentation ()"
public int GetRepresentation() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetRepresentation_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetRepresentationToPoints()
// "void SetRepresentationToPoints()"
public void SetRepresentationToPoints() {
	VTK_API.API_vtkProperty.SetRepresentationToPoints_0(this);
}


// void SetRepresentationToWireframe()
// "void SetRepresentationToWireframe()"
public void SetRepresentationToWireframe() {
	VTK_API.API_vtkProperty.SetRepresentationToWireframe_0(this);
}


// void SetRepresentationToSurface()
// "void SetRepresentationToSurface()"
public void SetRepresentationToSurface() {
	VTK_API.API_vtkProperty.SetRepresentationToSurface_0(this);
}


// char* GetRepresentationAsString()
// "const char *GetRepresentationAsString()"
public string GetRepresentationAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkProperty.GetRepresentationAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetColor(double r, double g, double b)
// "virtual void SetColor(double r, double g, double b)"
public void SetColor(double /*(double)*/ r, double /*(double)*/ g, double /*(double)*/ b) {
	VTK_API.API_vtkProperty.SetColor_0(this, r, g, b);
}


// virtual void SetColor(double a[3])
// "virtual void SetColor(double a[3])"
public void SetColor(double /*(double[3])*/ []a) {
	VTK_API.API_vtkProperty.SetColor_1(this, a);
}


// double* GetColor()
// "double *GetColor()"
public double[] GetColor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProperty.GetColor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetColor(double rgb[3])
// "void GetColor(double rgb[3])"
public void GetColor(double /*(double[3])*/ []rgb) {
	VTK_API.API_vtkProperty.GetColor_1(this, rgb);
}


// void GetColor(double & r, double & g, double & b)
// "void GetColor(double &r, double &g, double &b)"
public void GetColor(IntPtr /*(double&)*/ r, IntPtr /*(double&)*/ g, IntPtr /*(double&)*/ b) {
	VTK_API.API_vtkProperty.GetColor_2(this, r, g, b);
}


// virtual void SetAmbient(double _arg)
// "virtual void SetAmbient (double _arg)"
public void SetAmbient(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetAmbient_0(this, _arg);
}


// virtual double GetAmbientMinValue()
// "virtual double GetAmbientMinValue ()"
public double GetAmbientMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetAmbientMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetAmbientMaxValue()
// "virtual double GetAmbientMaxValue ()"
public double GetAmbientMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetAmbientMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetAmbient()
// "virtual double GetAmbient ()"
public double GetAmbient() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetAmbient_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetDiffuse(double _arg)
// "virtual void SetDiffuse (double _arg)"
public void SetDiffuse(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetDiffuse_0(this, _arg);
}


// virtual double GetDiffuseMinValue()
// "virtual double GetDiffuseMinValue ()"
public double GetDiffuseMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetDiffuseMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetDiffuseMaxValue()
// "virtual double GetDiffuseMaxValue ()"
public double GetDiffuseMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetDiffuseMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetDiffuse()
// "virtual double GetDiffuse ()"
public double GetDiffuse() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetDiffuse_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetSpecular(double _arg)
// "virtual void SetSpecular (double _arg)"
public void SetSpecular(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetSpecular_0(this, _arg);
}


// virtual double GetSpecularMinValue()
// "virtual double GetSpecularMinValue ()"
public double GetSpecularMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetSpecularMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetSpecularMaxValue()
// "virtual double GetSpecularMaxValue ()"
public double GetSpecularMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetSpecularMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetSpecular()
// "virtual double GetSpecular ()"
public double GetSpecular() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetSpecular_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetSpecularPower(double _arg)
// "virtual void SetSpecularPower (double _arg)"
public void SetSpecularPower(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetSpecularPower_0(this, _arg);
}


// virtual double GetSpecularPowerMinValue()
// "virtual double GetSpecularPowerMinValue ()"
public double GetSpecularPowerMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetSpecularPowerMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetSpecularPowerMaxValue()
// "virtual double GetSpecularPowerMaxValue ()"
public double GetSpecularPowerMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetSpecularPowerMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetSpecularPower()
// "virtual double GetSpecularPower ()"
public double GetSpecularPower() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetSpecularPower_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetOpacity(double _arg)
// "virtual void SetOpacity (double _arg)"
public void SetOpacity(double /*(double)*/ _arg) {
	VTK_API.API_vtkProperty.SetOpacity_0(this, _arg);
}


// virtual double GetOpacityMinValue()
// "virtual double GetOpacityMinValue ()"
public double GetOpacityMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetOpacityMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetOpacityMaxValue()
// "virtual double GetOpacityMaxValue ()"
public double GetOpacityMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetOpacityMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetOpacity()
// "virtual double GetOpacity ()"
public double GetOpacity() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProperty.GetOpacity_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetAmbientColor (double _arg1, double _arg2, double _arg3)"
public void SetAmbientColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetAmbientColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAmbientColor(double _arg[3])
// "virtual void SetAmbientColor (double _arg[3])"
public void SetAmbientColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetAmbientColor_1(this, _arg);
}


// virtual double* GetAmbientColor()
// "virtual double *GetAmbientColor ()"
public double[] GetAmbientColor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProperty.GetAmbientColor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetAmbientColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetAmbientColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetAmbientColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetAmbientColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetAmbientColor(double _arg[3])
// "virtual void GetAmbientColor (double _arg[3])"
public void GetAmbientColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetAmbientColor_2(this, _arg);
}


// virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetDiffuseColor (double _arg1, double _arg2, double _arg3)"
public void SetDiffuseColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetDiffuseColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetDiffuseColor(double _arg[3])
// "virtual void SetDiffuseColor (double _arg[3])"
public void SetDiffuseColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetDiffuseColor_1(this, _arg);
}


// virtual double* GetDiffuseColor()
// "virtual double *GetDiffuseColor ()"
public double[] GetDiffuseColor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProperty.GetDiffuseColor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetDiffuseColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetDiffuseColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetDiffuseColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetDiffuseColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetDiffuseColor(double _arg[3])
// "virtual void GetDiffuseColor (double _arg[3])"
public void GetDiffuseColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetDiffuseColor_2(this, _arg);
}


// virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetSpecularColor (double _arg1, double _arg2, double _arg3)"
public void SetSpecularColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetSpecularColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetSpecularColor(double _arg[3])
// "virtual void SetSpecularColor (double _arg[3])"
public void SetSpecularColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetSpecularColor_1(this, _arg);
}


// virtual double* GetSpecularColor()
// "virtual double *GetSpecularColor ()"
public double[] GetSpecularColor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProperty.GetSpecularColor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetSpecularColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetSpecularColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetSpecularColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetSpecularColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetSpecularColor(double _arg[3])
// "virtual void GetSpecularColor (double _arg[3])"
public void GetSpecularColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetSpecularColor_2(this, _arg);
}


// virtual vtkTypeBool GetEdgeVisibility()
// "virtual vtkTypeBool GetEdgeVisibility ()"
public bool GetEdgeVisibility() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetEdgeVisibility_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetEdgeVisibility(vtkTypeBool _arg)
// "virtual void SetEdgeVisibility (vtkTypeBool _arg)"
public void SetEdgeVisibility(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProperty.SetEdgeVisibility_0(this, _arg);
}


// virtual void EdgeVisibilityOn()
// "virtual void EdgeVisibilityOn ()"
public void EdgeVisibilityOn() {
	VTK_API.API_vtkProperty.EdgeVisibilityOn_0(this);
}


// virtual void EdgeVisibilityOff()
// "virtual void EdgeVisibilityOff ()"
public void EdgeVisibilityOff() {
	VTK_API.API_vtkProperty.EdgeVisibilityOff_0(this);
}


// virtual void SetEdgeColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetEdgeColor (double _arg1, double _arg2, double _arg3)"
public void SetEdgeColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetEdgeColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetEdgeColor(double _arg[3])
// "virtual void SetEdgeColor (double _arg[3])"
public void SetEdgeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetEdgeColor_1(this, _arg);
}


// virtual double* GetEdgeColor()
// "virtual double *GetEdgeColor ()"
public double[] GetEdgeColor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProperty.GetEdgeColor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetEdgeColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetEdgeColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetEdgeColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetEdgeColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetEdgeColor(double _arg[3])
// "virtual void GetEdgeColor (double _arg[3])"
public void GetEdgeColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetEdgeColor_2(this, _arg);
}


// virtual vtkTypeBool GetVertexVisibility()
// "virtual vtkTypeBool GetVertexVisibility ()"
public bool GetVertexVisibility() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetVertexVisibility_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetVertexVisibility(vtkTypeBool _arg)
// "virtual void SetVertexVisibility (vtkTypeBool _arg)"
public void SetVertexVisibility(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProperty.SetVertexVisibility_0(this, _arg);
}


// virtual void VertexVisibilityOn()
// "virtual void VertexVisibilityOn ()"
public void VertexVisibilityOn() {
	VTK_API.API_vtkProperty.VertexVisibilityOn_0(this);
}


// virtual void VertexVisibilityOff()
// "virtual void VertexVisibilityOff ()"
public void VertexVisibilityOff() {
	VTK_API.API_vtkProperty.VertexVisibilityOff_0(this);
}


// virtual void SetVertexColor(double _arg1, double _arg2, double _arg3)
// "virtual void SetVertexColor (double _arg1, double _arg2, double _arg3)"
public void SetVertexColor(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkProperty.SetVertexColor_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetVertexColor(double _arg[3])
// "virtual void SetVertexColor (double _arg[3])"
public void SetVertexColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.SetVertexColor_1(this, _arg);
}


// virtual double* GetVertexColor()
// "virtual double *GetVertexColor ()"
public double[] GetVertexColor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkProperty.GetVertexColor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetVertexColor(double & _arg1, double & _arg2, double & _arg3)
// "virtual void GetVertexColor (double &_arg1, double &_arg2, double &_arg3)"
public void GetVertexColor(IntPtr /*(double&)*/ _arg1, IntPtr /*(double&)*/ _arg2, IntPtr /*(double&)*/ _arg3) {
	VTK_API.API_vtkProperty.GetVertexColor_1(this, _arg1, _arg2, _arg3);
}


// virtual void GetVertexColor(double _arg[3])
// "virtual void GetVertexColor (double _arg[3])"
public void GetVertexColor(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkProperty.GetVertexColor_2(this, _arg);
}


// virtual void SetLineWidth(float _arg)
// "virtual void SetLineWidth (float _arg)"
public void SetLineWidth(float /*(float)*/ _arg) {
	VTK_API.API_vtkProperty.SetLineWidth_0(this, _arg);
}


// virtual float GetLineWidthMinValue()
// "virtual float GetLineWidthMinValue ()"
public float GetLineWidthMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkProperty.GetLineWidthMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetLineWidthMaxValue()
// "virtual float GetLineWidthMaxValue ()"
public float GetLineWidthMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkProperty.GetLineWidthMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetLineWidth()
// "virtual float GetLineWidth ()"
public float GetLineWidth() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkProperty.GetLineWidth_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetLineStipplePattern(int _arg)
// "virtual void SetLineStipplePattern (int _arg)"
public void SetLineStipplePattern(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetLineStipplePattern_0(this, _arg);
}


// virtual int GetLineStipplePattern()
// "virtual int GetLineStipplePattern ()"
public int GetLineStipplePattern() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetLineStipplePattern_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetLineStippleRepeatFactor(int _arg)
// "virtual void SetLineStippleRepeatFactor (int _arg)"
public void SetLineStippleRepeatFactor(int /*(int)*/ _arg) {
	VTK_API.API_vtkProperty.SetLineStippleRepeatFactor_0(this, _arg);
}


// virtual int GetLineStippleRepeatFactorMinValue()
// "virtual int GetLineStippleRepeatFactorMinValue ()"
public int GetLineStippleRepeatFactorMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetLineStippleRepeatFactorMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetLineStippleRepeatFactorMaxValue()
// "virtual int GetLineStippleRepeatFactorMaxValue ()"
public int GetLineStippleRepeatFactorMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetLineStippleRepeatFactorMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetLineStippleRepeatFactor()
// "virtual int GetLineStippleRepeatFactor ()"
public int GetLineStippleRepeatFactor() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetLineStippleRepeatFactor_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetPointSize(float _arg)
// "virtual void SetPointSize (float _arg)"
public void SetPointSize(float /*(float)*/ _arg) {
	VTK_API.API_vtkProperty.SetPointSize_0(this, _arg);
}


// virtual float GetPointSizeMinValue()
// "virtual float GetPointSizeMinValue ()"
public float GetPointSizeMinValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkProperty.GetPointSizeMinValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetPointSizeMaxValue()
// "virtual float GetPointSizeMaxValue ()"
public float GetPointSizeMaxValue() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkProperty.GetPointSizeMaxValue_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual float GetPointSize()
// "virtual float GetPointSize ()"
public float GetPointSize() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkProperty.GetPointSize_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool GetBackfaceCulling()
// "virtual vtkTypeBool GetBackfaceCulling ()"
public bool GetBackfaceCulling() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetBackfaceCulling_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetBackfaceCulling(vtkTypeBool _arg)
// "virtual void SetBackfaceCulling (vtkTypeBool _arg)"
public void SetBackfaceCulling(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProperty.SetBackfaceCulling_0(this, _arg);
}


// virtual void BackfaceCullingOn()
// "virtual void BackfaceCullingOn ()"
public void BackfaceCullingOn() {
	VTK_API.API_vtkProperty.BackfaceCullingOn_0(this);
}


// virtual void BackfaceCullingOff()
// "virtual void BackfaceCullingOff ()"
public void BackfaceCullingOff() {
	VTK_API.API_vtkProperty.BackfaceCullingOff_0(this);
}


// virtual vtkTypeBool GetFrontfaceCulling()
// "virtual vtkTypeBool GetFrontfaceCulling ()"
public bool GetFrontfaceCulling() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetFrontfaceCulling_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetFrontfaceCulling(vtkTypeBool _arg)
// "virtual void SetFrontfaceCulling (vtkTypeBool _arg)"
public void SetFrontfaceCulling(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProperty.SetFrontfaceCulling_0(this, _arg);
}


// virtual void FrontfaceCullingOn()
// "virtual void FrontfaceCullingOn ()"
public void FrontfaceCullingOn() {
	VTK_API.API_vtkProperty.FrontfaceCullingOn_0(this);
}


// virtual void FrontfaceCullingOff()
// "virtual void FrontfaceCullingOff ()"
public void FrontfaceCullingOff() {
	VTK_API.API_vtkProperty.FrontfaceCullingOff_0(this);
}


// virtual void SetMaterialName(const char * _arg)
// "virtual void SetMaterialName (const char* _arg)"
public void SetMaterialName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkProperty.SetMaterialName_0(this, _arg);
}


// virtual char* GetMaterialName()
// "virtual char* GetMaterialName ()"
public string GetMaterialName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkProperty.GetMaterialName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetShading(vtkTypeBool _arg)
// "virtual void SetShading (vtkTypeBool _arg)"
public void SetShading(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkProperty.SetShading_0(this, _arg);
}


// virtual vtkTypeBool GetShading()
// "virtual vtkTypeBool GetShading ()"
public bool GetShading() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProperty.GetShading_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ShadingOn()
// "virtual void ShadingOn ()"
public void ShadingOn() {
	VTK_API.API_vtkProperty.ShadingOn_0(this);
}


// virtual void ShadingOff()
// "virtual void ShadingOff ()"
public void ShadingOff() {
	VTK_API.API_vtkProperty.ShadingOff_0(this);
}


// virtual vtkShaderDeviceAdapter2* GetShaderDeviceAdapter2()
// "virtual vtkShaderDeviceAdapter2* GetShaderDeviceAdapter2()"
public vtkShaderDeviceAdapter2 GetShaderDeviceAdapter2() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProperty.GetShaderDeviceAdapter2_0(out returnPointer, this);
//	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
	return (vtkShaderDeviceAdapter2)(IntPtr)returnPointer;
}


// void SetTexture(const char * name, vtkTexture * texture)
// "void SetTexture(const char* name, vtkTexture* texture)"
public void SetTexture(string /*(char*)*/ name, vtkTexture /*(vtkTexture*)*/ texture) {
	VTK_API.API_vtkProperty.SetTexture_0(this, name, texture);
}


// vtkTexture* GetTexture(const char * name)
// "vtkTexture* GetTexture(const char* name)"
public vtkTexture GetTexture(string /*(char*)*/ name) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProperty.GetTexture_0(out returnPointer, this, name);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// void RemoveTexture(const char * name)
// "void RemoveTexture(const char* name)"
public void RemoveTexture(string /*(char*)*/ name) {
	VTK_API.API_vtkProperty.RemoveTexture_0(this, name);
}


// void RemoveAllTextures()
// "void RemoveAllTextures()"
public void RemoveAllTextures() {
	VTK_API.API_vtkProperty.RemoveAllTextures_0(this);
}


// int GetNumberOfTextures()
// "int GetNumberOfTextures()"
public int GetNumberOfTextures() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkProperty.GetNumberOfTextures_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void ReleaseGraphicsResources(vtkWindow * win)
// "virtual void ReleaseGraphicsResources(vtkWindow *win)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ win) {
	VTK_API.API_vtkProperty.ReleaseGraphicsResources_0(this, win);
}


}
};
