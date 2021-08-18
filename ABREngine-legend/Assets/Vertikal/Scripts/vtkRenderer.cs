

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkRenderer : vtkViewport {
		public vtkRenderer(IntPtr p) : base(p) {}
		public static implicit operator  vtkRenderer(IntPtr p) {return new vtkRenderer(p);}
		public static implicit operator  IntPtr(vtkRenderer o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkRenderer* SafeDownCast(vtkObjectBase * o)
// "static vtkRenderer* SafeDownCast(vtkObjectBase *o)"
public static vtkRenderer SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.SafeDownCast_0(out returnPointer, o);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// vtkRenderer* NewInstance()
// "vtkRenderer *NewInstance()"
public vtkRenderer NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.NewInstance_0(out returnPointer, this);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// static vtkRenderer* New()
// "static vtkRenderer *New()"
public static vtkRenderer New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.New_0(out returnPointer);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// void AddActor(vtkProp * p)
// "void AddActor(vtkProp *p)"
public void AddActor(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.AddActor_0(this, p);
}


// void AddVolume(vtkProp * p)
// "void AddVolume(vtkProp *p)"
public void AddVolume(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.AddVolume_0(this, p);
}


// void RemoveActor(vtkProp * p)
// "void RemoveActor(vtkProp *p)"
public void RemoveActor(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.RemoveActor_0(this, p);
}


// void RemoveVolume(vtkProp * p)
// "void RemoveVolume(vtkProp *p)"
public void RemoveVolume(vtkProp /*(vtkProp*)*/ p) {
	VTK_API.API_vtkRenderer.RemoveVolume_0(this, p);
}


// void AddLight(vtkLight * ARG_0)
// "void AddLight(vtkLight *)"
public void AddLight(vtkLight /*(vtkLight*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.AddLight_0(this, ARG_0);
}


// void RemoveLight(vtkLight * ARG_0)
// "void RemoveLight(vtkLight *)"
public void RemoveLight(vtkLight /*(vtkLight*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.RemoveLight_0(this, ARG_0);
}


// void RemoveAllLights()
// "void RemoveAllLights()"
public void RemoveAllLights() {
	VTK_API.API_vtkRenderer.RemoveAllLights_0(this);
}


// vtkLightCollection* GetLights()
// "vtkLightCollection *GetLights()"
public vtkLightCollection GetLights() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetLights_0(out returnPointer, this);
//	return (vtkLightCollection)(IntPtr)returnPointer;
	return (vtkLightCollection)(IntPtr)returnPointer;
}


// void SetLightCollection(vtkLightCollection * lights)
// "void SetLightCollection(vtkLightCollection *lights)"
public void SetLightCollection(vtkLightCollection /*(vtkLightCollection*)*/ lights) {
	VTK_API.API_vtkRenderer.SetLightCollection_0(this, lights);
}


// void CreateLight()
// "void CreateLight(void)"
public void CreateLight() {
	VTK_API.API_vtkRenderer.CreateLight_0(this);
}


// virtual vtkLight* MakeLight()
// "virtual vtkLight *MakeLight()"
public vtkLight MakeLight() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.MakeLight_0(out returnPointer, this);
//	return (vtkLight)(IntPtr)returnPointer;
	return (vtkLight)(IntPtr)returnPointer;
}


// virtual vtkTypeBool GetTwoSidedLighting()
// "virtual vtkTypeBool GetTwoSidedLighting ()"
public bool GetTwoSidedLighting() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetTwoSidedLighting_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetTwoSidedLighting(vtkTypeBool _arg)
// "virtual void SetTwoSidedLighting (vtkTypeBool _arg)"
public void SetTwoSidedLighting(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetTwoSidedLighting_0(this, _arg);
}


// virtual void TwoSidedLightingOn()
// "virtual void TwoSidedLightingOn ()"
public void TwoSidedLightingOn() {
	VTK_API.API_vtkRenderer.TwoSidedLightingOn_0(this);
}


// virtual void TwoSidedLightingOff()
// "virtual void TwoSidedLightingOff ()"
public void TwoSidedLightingOff() {
	VTK_API.API_vtkRenderer.TwoSidedLightingOff_0(this);
}


// virtual void SetLightFollowCamera(vtkTypeBool _arg)
// "virtual void SetLightFollowCamera (vtkTypeBool _arg)"
public void SetLightFollowCamera(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetLightFollowCamera_0(this, _arg);
}


// virtual vtkTypeBool GetLightFollowCamera()
// "virtual vtkTypeBool GetLightFollowCamera ()"
public bool GetLightFollowCamera() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetLightFollowCamera_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void LightFollowCameraOn()
// "virtual void LightFollowCameraOn ()"
public void LightFollowCameraOn() {
	VTK_API.API_vtkRenderer.LightFollowCameraOn_0(this);
}


// virtual void LightFollowCameraOff()
// "virtual void LightFollowCameraOff ()"
public void LightFollowCameraOff() {
	VTK_API.API_vtkRenderer.LightFollowCameraOff_0(this);
}


// virtual vtkTypeBool GetAutomaticLightCreation()
// "virtual vtkTypeBool GetAutomaticLightCreation ()"
public bool GetAutomaticLightCreation() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetAutomaticLightCreation_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetAutomaticLightCreation(vtkTypeBool _arg)
// "virtual void SetAutomaticLightCreation (vtkTypeBool _arg)"
public void SetAutomaticLightCreation(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetAutomaticLightCreation_0(this, _arg);
}


// virtual void AutomaticLightCreationOn()
// "virtual void AutomaticLightCreationOn ()"
public void AutomaticLightCreationOn() {
	VTK_API.API_vtkRenderer.AutomaticLightCreationOn_0(this);
}


// virtual void AutomaticLightCreationOff()
// "virtual void AutomaticLightCreationOff ()"
public void AutomaticLightCreationOff() {
	VTK_API.API_vtkRenderer.AutomaticLightCreationOff_0(this);
}


// virtual int UpdateLightsGeometryToFollowCamera()
// "virtual int UpdateLightsGeometryToFollowCamera(void)"
public int UpdateLightsGeometryToFollowCamera() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.UpdateLightsGeometryToFollowCamera_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkVolumeCollection* GetVolumes()
// "vtkVolumeCollection *GetVolumes()"
public vtkVolumeCollection GetVolumes() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetVolumes_0(out returnPointer, this);
//	return (vtkVolumeCollection)(IntPtr)returnPointer;
	return (vtkVolumeCollection)(IntPtr)returnPointer;
}


// vtkActorCollection* GetActors()
// "vtkActorCollection *GetActors()"
public vtkActorCollection GetActors() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetActors_0(out returnPointer, this);
//	return (vtkActorCollection)(IntPtr)returnPointer;
	return (vtkActorCollection)(IntPtr)returnPointer;
}


// void SetActiveCamera(vtkCamera * ARG_0)
// "void SetActiveCamera(vtkCamera *)"
public void SetActiveCamera(vtkCamera /*(vtkCamera*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetActiveCamera_0(this, ARG_0);
}


// vtkCamera* GetActiveCamera()
// "vtkCamera *GetActiveCamera()"
public vtkCamera GetActiveCamera() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetActiveCamera_0(out returnPointer, this);
//	return (vtkCamera)(IntPtr)returnPointer;
	return (vtkCamera)(IntPtr)returnPointer;
}


// virtual vtkCamera* MakeCamera()
// "virtual vtkCamera *MakeCamera()"
public vtkCamera MakeCamera() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.MakeCamera_0(out returnPointer, this);
//	return (vtkCamera)(IntPtr)returnPointer;
	return (vtkCamera)(IntPtr)returnPointer;
}


// virtual void SetErase(vtkTypeBool _arg)
// "virtual void SetErase (vtkTypeBool _arg)"
public void SetErase(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetErase_0(this, _arg);
}


// virtual vtkTypeBool GetErase()
// "virtual vtkTypeBool GetErase ()"
public bool GetErase() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetErase_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void EraseOn()
// "virtual void EraseOn ()"
public void EraseOn() {
	VTK_API.API_vtkRenderer.EraseOn_0(this);
}


// virtual void EraseOff()
// "virtual void EraseOff ()"
public void EraseOff() {
	VTK_API.API_vtkRenderer.EraseOff_0(this);
}


// virtual void SetDraw(vtkTypeBool _arg)
// "virtual void SetDraw (vtkTypeBool _arg)"
public void SetDraw(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetDraw_0(this, _arg);
}


// virtual vtkTypeBool GetDraw()
// "virtual vtkTypeBool GetDraw ()"
public bool GetDraw() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetDraw_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void DrawOn()
// "virtual void DrawOn ()"
public void DrawOn() {
	VTK_API.API_vtkRenderer.DrawOn_0(this);
}


// virtual void DrawOff()
// "virtual void DrawOff ()"
public void DrawOff() {
	VTK_API.API_vtkRenderer.DrawOff_0(this);
}


// int CaptureGL2PSSpecialProp(vtkProp * ARG_0)
// "int CaptureGL2PSSpecialProp(vtkProp *)"
public int CaptureGL2PSSpecialProp(vtkProp /*(vtkProp*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.CaptureGL2PSSpecialProp_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetGL2PSSpecialPropCollection(vtkPropCollection * ARG_0)
// "void SetGL2PSSpecialPropCollection(vtkPropCollection *)"
public void SetGL2PSSpecialPropCollection(vtkPropCollection /*(vtkPropCollection*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetGL2PSSpecialPropCollection_0(this, ARG_0);
}


// void AddCuller(vtkCuller * ARG_0)
// "void AddCuller(vtkCuller *)"
public void AddCuller(vtkCuller /*(vtkCuller*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.AddCuller_0(this, ARG_0);
}


// void RemoveCuller(vtkCuller * ARG_0)
// "void RemoveCuller(vtkCuller *)"
public void RemoveCuller(vtkCuller /*(vtkCuller*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.RemoveCuller_0(this, ARG_0);
}


// vtkCullerCollection* GetCullers()
// "vtkCullerCollection *GetCullers()"
public vtkCullerCollection GetCullers() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetCullers_0(out returnPointer, this);
//	return (vtkCullerCollection)(IntPtr)returnPointer;
	return (vtkCullerCollection)(IntPtr)returnPointer;
}


// virtual void SetAmbient(double _arg1, double _arg2, double _arg3)
// "virtual void SetAmbient (double _arg1, double _arg2, double _arg3)"
public void SetAmbient(double /*(double)*/ _arg1, double /*(double)*/ _arg2, double /*(double)*/ _arg3) {
	VTK_API.API_vtkRenderer.SetAmbient_0(this, _arg1, _arg2, _arg3);
}


// virtual void SetAmbient(double _arg[3])
// "virtual void SetAmbient (double _arg[3])"
public void SetAmbient(double /*(double[3])*/ []_arg) {
	VTK_API.API_vtkRenderer.SetAmbient_1(this, _arg);
}


// virtual double* GetAmbient()
// "virtual double *GetAmbient ()"
public double[] GetAmbient() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkRenderer.GetAmbient_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetAmbient(double data[3])
// "virtual void GetAmbient (double data[3])"
public void GetAmbient(double /*(double[3])*/ []data) {
	VTK_API.API_vtkRenderer.GetAmbient_1(this, data);
}


// virtual void SetAllocatedRenderTime(double _arg)
// "virtual void SetAllocatedRenderTime (double _arg)"
public void SetAllocatedRenderTime(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetAllocatedRenderTime_0(this, _arg);
}


// virtual double GetAllocatedRenderTime()
// "virtual double GetAllocatedRenderTime()"
public double GetAllocatedRenderTime() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetAllocatedRenderTime_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetTimeFactor()
// "virtual double GetTimeFactor()"
public double GetTimeFactor() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetTimeFactor_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void Render()
// "virtual void Render()"
public void Render() {
	VTK_API.API_vtkRenderer.Render_0(this);
}


// virtual void DeviceRender()
// "virtual void DeviceRender()"
public void DeviceRender() {
	VTK_API.API_vtkRenderer.DeviceRender_0(this);
}


// virtual void DeviceRenderOpaqueGeometry()
// "virtual void DeviceRenderOpaqueGeometry()"
public void DeviceRenderOpaqueGeometry() {
	VTK_API.API_vtkRenderer.DeviceRenderOpaqueGeometry_0(this);
}


// virtual void DeviceRenderTranslucentPolygonalGeometry()
// "virtual void DeviceRenderTranslucentPolygonalGeometry()"
public void DeviceRenderTranslucentPolygonalGeometry() {
	VTK_API.API_vtkRenderer.DeviceRenderTranslucentPolygonalGeometry_0(this);
}


// virtual void ClearLights()
// "virtual void ClearLights(void)"
public void ClearLights() {
	VTK_API.API_vtkRenderer.ClearLights_0(this);
}


// virtual void Clear()
// "virtual void Clear()"
public void Clear() {
	VTK_API.API_vtkRenderer.Clear_0(this);
}


// int VisibleActorCount()
// "int VisibleActorCount()"
public int VisibleActorCount() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.VisibleActorCount_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int VisibleVolumeCount()
// "int VisibleVolumeCount()"
public int VisibleVolumeCount() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.VisibleVolumeCount_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void ComputeVisiblePropBounds(double bounds[6])
// "void ComputeVisiblePropBounds( double bounds[6] )"
public void ComputeVisiblePropBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkRenderer.ComputeVisiblePropBounds_0(this, bounds);
}


// double* ComputeVisiblePropBounds()
// "double *ComputeVisiblePropBounds()"
public double[] ComputeVisiblePropBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkRenderer.ComputeVisiblePropBounds_1(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void ResetCameraClippingRange()
// "virtual void ResetCameraClippingRange()"
public void ResetCameraClippingRange() {
	VTK_API.API_vtkRenderer.ResetCameraClippingRange_0(this);
}


// virtual void ResetCameraClippingRange(double bounds[6])
// "virtual void ResetCameraClippingRange( double bounds[6] )"
public void ResetCameraClippingRange(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkRenderer.ResetCameraClippingRange_1(this, bounds);
}


// virtual void ResetCameraClippingRange(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// "virtual void ResetCameraClippingRange( double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)"
public void ResetCameraClippingRange(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax) {
	VTK_API.API_vtkRenderer.ResetCameraClippingRange_2(this, xmin, xmax, ymin, ymax, zmin, zmax);
}


// virtual void SetNearClippingPlaneTolerance(double _arg)
// "virtual void SetNearClippingPlaneTolerance (double _arg)"
public void SetNearClippingPlaneTolerance(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetNearClippingPlaneTolerance_0(this, _arg);
}


// virtual double GetNearClippingPlaneToleranceMinValue()
// "virtual double GetNearClippingPlaneToleranceMinValue ()"
public double GetNearClippingPlaneToleranceMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetNearClippingPlaneToleranceMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetNearClippingPlaneToleranceMaxValue()
// "virtual double GetNearClippingPlaneToleranceMaxValue ()"
public double GetNearClippingPlaneToleranceMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetNearClippingPlaneToleranceMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetNearClippingPlaneTolerance()
// "virtual double GetNearClippingPlaneTolerance ()"
public double GetNearClippingPlaneTolerance() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetNearClippingPlaneTolerance_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetClippingRangeExpansion(double _arg)
// "virtual void SetClippingRangeExpansion (double _arg)"
public void SetClippingRangeExpansion(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetClippingRangeExpansion_0(this, _arg);
}


// virtual double GetClippingRangeExpansionMinValue()
// "virtual double GetClippingRangeExpansionMinValue ()"
public double GetClippingRangeExpansionMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetClippingRangeExpansionMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetClippingRangeExpansionMaxValue()
// "virtual double GetClippingRangeExpansionMaxValue ()"
public double GetClippingRangeExpansionMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetClippingRangeExpansionMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetClippingRangeExpansion()
// "virtual double GetClippingRangeExpansion ()"
public double GetClippingRangeExpansion() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetClippingRangeExpansion_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void ResetCamera()
// "virtual void ResetCamera()"
public void ResetCamera() {
	VTK_API.API_vtkRenderer.ResetCamera_0(this);
}


// virtual void ResetCamera(double bounds[6])
// "virtual void ResetCamera(double bounds[6])"
public void ResetCamera(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkRenderer.ResetCamera_1(this, bounds);
}


// virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
// "virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)"
public void ResetCamera(double /*(double)*/ xmin, double /*(double)*/ xmax, double /*(double)*/ ymin, double /*(double)*/ ymax, double /*(double)*/ zmin, double /*(double)*/ zmax) {
	VTK_API.API_vtkRenderer.ResetCamera_2(this, xmin, xmax, ymin, ymax, zmin, zmax);
}


// void SetRenderWindow(vtkRenderWindow * ARG_0)
// "void SetRenderWindow(vtkRenderWindow *)"
public void SetRenderWindow(vtkRenderWindow /*(vtkRenderWindow*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetRenderWindow_0(this, ARG_0);
}


// vtkRenderWindow* GetRenderWindow()
// "vtkRenderWindow *GetRenderWindow()"
public vtkRenderWindow GetRenderWindow() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetRenderWindow_0(out returnPointer, this);
//	return (vtkRenderWindow)(IntPtr)returnPointer;
	return (vtkRenderWindow)(IntPtr)returnPointer;
}


// vtkWindow* GetVTKWindow()
// "vtkWindow *GetVTKWindow()"
public vtkWindow GetVTKWindow() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetVTKWindow_0(out returnPointer, this);
//	return (vtkWindow)(IntPtr)returnPointer;
	return (vtkWindow)(IntPtr)returnPointer;
}


// virtual void SetBackingStore(vtkTypeBool _arg)
// "virtual void SetBackingStore (vtkTypeBool _arg)"
public void SetBackingStore(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetBackingStore_0(this, _arg);
}


// virtual vtkTypeBool GetBackingStore()
// "virtual vtkTypeBool GetBackingStore ()"
public bool GetBackingStore() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetBackingStore_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void BackingStoreOn()
// "virtual void BackingStoreOn ()"
public void BackingStoreOn() {
	VTK_API.API_vtkRenderer.BackingStoreOn_0(this);
}


// virtual void BackingStoreOff()
// "virtual void BackingStoreOff ()"
public void BackingStoreOff() {
	VTK_API.API_vtkRenderer.BackingStoreOff_0(this);
}


// virtual void SetInteractive(vtkTypeBool _arg)
// "virtual void SetInteractive (vtkTypeBool _arg)"
public void SetInteractive(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetInteractive_0(this, _arg);
}


// virtual vtkTypeBool GetInteractive()
// "virtual vtkTypeBool GetInteractive ()"
public bool GetInteractive() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetInteractive_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void InteractiveOn()
// "virtual void InteractiveOn ()"
public void InteractiveOn() {
	VTK_API.API_vtkRenderer.InteractiveOn_0(this);
}


// virtual void InteractiveOff()
// "virtual void InteractiveOff ()"
public void InteractiveOff() {
	VTK_API.API_vtkRenderer.InteractiveOff_0(this);
}


// virtual void SetLayer(int layer)
// "virtual void SetLayer(int layer)"
public void SetLayer(int /*(int)*/ layer) {
	VTK_API.API_vtkRenderer.SetLayer_0(this, layer);
}


// virtual int GetLayer()
// "virtual int GetLayer ()"
public int GetLayer() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.GetLayer_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkTypeBool GetPreserveColorBuffer()
// "virtual vtkTypeBool GetPreserveColorBuffer ()"
public bool GetPreserveColorBuffer() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetPreserveColorBuffer_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetPreserveColorBuffer(vtkTypeBool _arg)
// "virtual void SetPreserveColorBuffer (vtkTypeBool _arg)"
public void SetPreserveColorBuffer(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetPreserveColorBuffer_0(this, _arg);
}


// virtual void PreserveColorBufferOn()
// "virtual void PreserveColorBufferOn ()"
public void PreserveColorBufferOn() {
	VTK_API.API_vtkRenderer.PreserveColorBufferOn_0(this);
}


// virtual void PreserveColorBufferOff()
// "virtual void PreserveColorBufferOff ()"
public void PreserveColorBufferOff() {
	VTK_API.API_vtkRenderer.PreserveColorBufferOff_0(this);
}


// virtual void SetPreserveDepthBuffer(vtkTypeBool _arg)
// "virtual void SetPreserveDepthBuffer (vtkTypeBool _arg)"
public void SetPreserveDepthBuffer(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetPreserveDepthBuffer_0(this, _arg);
}


// virtual vtkTypeBool GetPreserveDepthBuffer()
// "virtual vtkTypeBool GetPreserveDepthBuffer ()"
public bool GetPreserveDepthBuffer() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetPreserveDepthBuffer_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PreserveDepthBufferOn()
// "virtual void PreserveDepthBufferOn ()"
public void PreserveDepthBufferOn() {
	VTK_API.API_vtkRenderer.PreserveDepthBufferOn_0(this);
}


// virtual void PreserveDepthBufferOff()
// "virtual void PreserveDepthBufferOff ()"
public void PreserveDepthBufferOff() {
	VTK_API.API_vtkRenderer.PreserveDepthBufferOff_0(this);
}


// int Transparent()
// "int Transparent()"
public int Transparent() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.Transparent_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void WorldToView()
// "void WorldToView()"
public void WorldToView() {
	VTK_API.API_vtkRenderer.WorldToView_0(this);
}


// void ViewToWorld()
// "void ViewToWorld()"
public void ViewToWorld() {
	VTK_API.API_vtkRenderer.ViewToWorld_0(this);
}


// void ViewToWorld(double & wx, double & wy, double & wz)
// "void ViewToWorld(double &wx, double &wy, double &wz)"
public void ViewToWorld(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.ViewToWorld_1(this, wx, wy, wz);
}


// void WorldToView(double & wx, double & wy, double & wz)
// "void WorldToView(double &wx, double &wy, double &wz)"
public void WorldToView(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.WorldToView_1(this, wx, wy, wz);
}


// void WorldToPose(double & wx, double & wy, double & wz)
// "void WorldToPose(double &wx, double &wy, double &wz)"
public void WorldToPose(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.WorldToPose_0(this, wx, wy, wz);
}


// void PoseToWorld(double & wx, double & wy, double & wz)
// "void PoseToWorld(double &wx, double &wy, double &wz)"
public void PoseToWorld(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.PoseToWorld_0(this, wx, wy, wz);
}


// void ViewToPose(double & wx, double & wy, double & wz)
// "void ViewToPose(double &wx, double &wy, double &wz)"
public void ViewToPose(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.ViewToPose_0(this, wx, wy, wz);
}


// void PoseToView(double & wx, double & wy, double & wz)
// "void PoseToView(double &wx, double &wy, double &wz)"
public void PoseToView(IntPtr /*(double&)*/ wx, IntPtr /*(double&)*/ wy, IntPtr /*(double&)*/ wz) {
	VTK_API.API_vtkRenderer.PoseToView_0(this, wx, wy, wz);
}


// double GetZ(int x, int y)
// "double GetZ (int x, int y)"
public double GetZ(int /*(int)*/ x, int /*(int)*/ y) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetZ_0(out returnPointer, this, x, y);
//	return (double)returnPointer;
	return returnPointer;
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkRenderer.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual double GetLastRenderTimeInSeconds()
// "virtual double GetLastRenderTimeInSeconds ()"
public double GetLastRenderTimeInSeconds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetLastRenderTimeInSeconds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfPropsRendered()
// "virtual int GetNumberOfPropsRendered ()"
public int GetNumberOfPropsRendered() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.GetNumberOfPropsRendered_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkAssemblyPath* PickProp(double selectionX, double selectionY)
// "vtkAssemblyPath* PickProp(double selectionX, double selectionY)"
public vtkAssemblyPath PickProp(double /*(double)*/ selectionX, double /*(double)*/ selectionY) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.PickProp_0(out returnPointer, this, selectionX, selectionY);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
// "vtkAssemblyPath* PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)"
public vtkAssemblyPath PickProp(double /*(double)*/ selectionX1, double /*(double)*/ selectionY1, double /*(double)*/ selectionX2, double /*(double)*/ selectionY2) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.PickProp_1(out returnPointer, this, selectionX1, selectionY1, selectionX2, selectionY2);
//	return (vtkAssemblyPath)(IntPtr)returnPointer;
	return (vtkAssemblyPath)(IntPtr)returnPointer;
}


// virtual void StereoMidpoint()
// "virtual void StereoMidpoint()"
public void StereoMidpoint() {
	VTK_API.API_vtkRenderer.StereoMidpoint_0(this);
}


// double GetTiledAspectRatio()
// "double GetTiledAspectRatio()"
public double GetTiledAspectRatio() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetTiledAspectRatio_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsActiveCameraCreated()
// "vtkTypeBool IsActiveCameraCreated()"
public bool IsActiveCameraCreated() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.IsActiveCameraCreated_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetUseDepthPeeling(vtkTypeBool _arg)
// "virtual void SetUseDepthPeeling (vtkTypeBool _arg)"
public void SetUseDepthPeeling(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseDepthPeeling_0(this, _arg);
}


// virtual vtkTypeBool GetUseDepthPeeling()
// "virtual vtkTypeBool GetUseDepthPeeling ()"
public bool GetUseDepthPeeling() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetUseDepthPeeling_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseDepthPeelingOn()
// "virtual void UseDepthPeelingOn ()"
public void UseDepthPeelingOn() {
	VTK_API.API_vtkRenderer.UseDepthPeelingOn_0(this);
}


// virtual void UseDepthPeelingOff()
// "virtual void UseDepthPeelingOff ()"
public void UseDepthPeelingOff() {
	VTK_API.API_vtkRenderer.UseDepthPeelingOff_0(this);
}


// virtual void SetUseDepthPeelingForVolumes(bool _arg)
// "virtual void SetUseDepthPeelingForVolumes (bool _arg)"
public void SetUseDepthPeelingForVolumes(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseDepthPeelingForVolumes_0(this, _arg);
}


// virtual bool GetUseDepthPeelingForVolumes()
// "virtual bool GetUseDepthPeelingForVolumes ()"
public bool GetUseDepthPeelingForVolumes() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetUseDepthPeelingForVolumes_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseDepthPeelingForVolumesOn()
// "virtual void UseDepthPeelingForVolumesOn ()"
public void UseDepthPeelingForVolumesOn() {
	VTK_API.API_vtkRenderer.UseDepthPeelingForVolumesOn_0(this);
}


// virtual void UseDepthPeelingForVolumesOff()
// "virtual void UseDepthPeelingForVolumesOff ()"
public void UseDepthPeelingForVolumesOff() {
	VTK_API.API_vtkRenderer.UseDepthPeelingForVolumesOff_0(this);
}


// virtual void SetOcclusionRatio(double _arg)
// "virtual void SetOcclusionRatio (double _arg)"
public void SetOcclusionRatio(double /*(double)*/ _arg) {
	VTK_API.API_vtkRenderer.SetOcclusionRatio_0(this, _arg);
}


// virtual double GetOcclusionRatioMinValue()
// "virtual double GetOcclusionRatioMinValue ()"
public double GetOcclusionRatioMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetOcclusionRatioMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetOcclusionRatioMaxValue()
// "virtual double GetOcclusionRatioMaxValue ()"
public double GetOcclusionRatioMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetOcclusionRatioMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetOcclusionRatio()
// "virtual double GetOcclusionRatio ()"
public double GetOcclusionRatio() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkRenderer.GetOcclusionRatio_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetMaximumNumberOfPeels(int _arg)
// "virtual void SetMaximumNumberOfPeels (int _arg)"
public void SetMaximumNumberOfPeels(int /*(int)*/ _arg) {
	VTK_API.API_vtkRenderer.SetMaximumNumberOfPeels_0(this, _arg);
}


// virtual int GetMaximumNumberOfPeels()
// "virtual int GetMaximumNumberOfPeels ()"
public int GetMaximumNumberOfPeels() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.GetMaximumNumberOfPeels_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetLastRenderingUsedDepthPeeling()
// "virtual int GetLastRenderingUsedDepthPeeling ()"
public int GetLastRenderingUsedDepthPeeling() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkRenderer.GetLastRenderingUsedDepthPeeling_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetDelegate(vtkRendererDelegate * d)
// "void SetDelegate(vtkRendererDelegate *d)"
public void SetDelegate(vtkRendererDelegate /*(vtkRendererDelegate*)*/ d) {
	VTK_API.API_vtkRenderer.SetDelegate_0(this, d);
}


// virtual vtkRendererDelegate* GetDelegate()
// "virtual vtkRendererDelegate *GetDelegate ()"
public vtkRendererDelegate GetDelegate() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetDelegate_0(out returnPointer, this);
//	return (vtkRendererDelegate)(IntPtr)returnPointer;
	return (vtkRendererDelegate)(IntPtr)returnPointer;
}


// virtual vtkHardwareSelector* GetSelector()
// "virtual vtkHardwareSelector *GetSelector ()"
public vtkHardwareSelector GetSelector() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetSelector_0(out returnPointer, this);
//	return (vtkHardwareSelector)(IntPtr)returnPointer;
	return (vtkHardwareSelector)(IntPtr)returnPointer;
}


// virtual void SetLeftBackgroundTexture(vtkTexture * ARG_0)
// "virtual void SetLeftBackgroundTexture(vtkTexture*)"
public void SetLeftBackgroundTexture(vtkTexture /*(vtkTexture*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetLeftBackgroundTexture_0(this, ARG_0);
}


// vtkTexture* GetLeftBackgroundTexture()
// "vtkTexture* GetLeftBackgroundTexture()"
public vtkTexture GetLeftBackgroundTexture() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetLeftBackgroundTexture_0(out returnPointer, this);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void SetBackgroundTexture(vtkTexture * ARG_0)
// "virtual void SetBackgroundTexture(vtkTexture*)"
public void SetBackgroundTexture(vtkTexture /*(vtkTexture*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetBackgroundTexture_0(this, ARG_0);
}


// virtual vtkTexture* GetBackgroundTexture()
// "virtual vtkTexture *GetBackgroundTexture ()"
public vtkTexture GetBackgroundTexture() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetBackgroundTexture_0(out returnPointer, this);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void SetRightBackgroundTexture(vtkTexture * ARG_0)
// "virtual void SetRightBackgroundTexture(vtkTexture*)"
public void SetRightBackgroundTexture(vtkTexture /*(vtkTexture*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetRightBackgroundTexture_0(this, ARG_0);
}


// virtual vtkTexture* GetRightBackgroundTexture()
// "virtual vtkTexture *GetRightBackgroundTexture ()"
public vtkTexture GetRightBackgroundTexture() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetRightBackgroundTexture_0(out returnPointer, this);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void SetTexturedBackground(bool _arg)
// "virtual void SetTexturedBackground (bool _arg)"
public void SetTexturedBackground(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetTexturedBackground_0(this, _arg);
}


// virtual bool GetTexturedBackground()
// "virtual bool GetTexturedBackground ()"
public bool GetTexturedBackground() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetTexturedBackground_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void TexturedBackgroundOn()
// "virtual void TexturedBackgroundOn ()"
public void TexturedBackgroundOn() {
	VTK_API.API_vtkRenderer.TexturedBackgroundOn_0(this);
}


// virtual void TexturedBackgroundOff()
// "virtual void TexturedBackgroundOff ()"
public void TexturedBackgroundOff() {
	VTK_API.API_vtkRenderer.TexturedBackgroundOff_0(this);
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual void SetUseFXAA(bool _arg)
// "virtual void SetUseFXAA (bool _arg)"
public void SetUseFXAA(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseFXAA_0(this, _arg);
}


// virtual bool GetUseFXAA()
// "virtual bool GetUseFXAA ()"
public bool GetUseFXAA() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetUseFXAA_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseFXAAOn()
// "virtual void UseFXAAOn ()"
public void UseFXAAOn() {
	VTK_API.API_vtkRenderer.UseFXAAOn_0(this);
}


// virtual void UseFXAAOff()
// "virtual void UseFXAAOff ()"
public void UseFXAAOff() {
	VTK_API.API_vtkRenderer.UseFXAAOff_0(this);
}


// virtual vtkFXAAOptions* GetFXAAOptions()
// "virtual vtkFXAAOptions *GetFXAAOptions ()"
public vtkFXAAOptions GetFXAAOptions() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetFXAAOptions_0(out returnPointer, this);
//	return (vtkFXAAOptions)(IntPtr)returnPointer;
	return (vtkFXAAOptions)(IntPtr)returnPointer;
}


// virtual void SetFXAAOptions(vtkFXAAOptions * ARG_0)
// "virtual void SetFXAAOptions(vtkFXAAOptions*)"
public void SetFXAAOptions(vtkFXAAOptions /*(vtkFXAAOptions*)*/ ARG_0) {
	VTK_API.API_vtkRenderer.SetFXAAOptions_0(this, ARG_0);
}


// virtual void SetUseShadows(vtkTypeBool _arg)
// "virtual void SetUseShadows (vtkTypeBool _arg)"
public void SetUseShadows(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseShadows_0(this, _arg);
}


// virtual vtkTypeBool GetUseShadows()
// "virtual vtkTypeBool GetUseShadows ()"
public bool GetUseShadows() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetUseShadows_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseShadowsOn()
// "virtual void UseShadowsOn ()"
public void UseShadowsOn() {
	VTK_API.API_vtkRenderer.UseShadowsOn_0(this);
}


// virtual void UseShadowsOff()
// "virtual void UseShadowsOff ()"
public void UseShadowsOff() {
	VTK_API.API_vtkRenderer.UseShadowsOff_0(this);
}


// virtual void SetUseHiddenLineRemoval(vtkTypeBool _arg)
// "virtual void SetUseHiddenLineRemoval (vtkTypeBool _arg)"
public void SetUseHiddenLineRemoval(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkRenderer.SetUseHiddenLineRemoval_0(this, _arg);
}


// virtual vtkTypeBool GetUseHiddenLineRemoval()
// "virtual vtkTypeBool GetUseHiddenLineRemoval ()"
public bool GetUseHiddenLineRemoval() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkRenderer.GetUseHiddenLineRemoval_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseHiddenLineRemovalOn()
// "virtual void UseHiddenLineRemovalOn ()"
public void UseHiddenLineRemovalOn() {
	VTK_API.API_vtkRenderer.UseHiddenLineRemovalOn_0(this);
}


// virtual void UseHiddenLineRemovalOff()
// "virtual void UseHiddenLineRemovalOff ()"
public void UseHiddenLineRemovalOff() {
	VTK_API.API_vtkRenderer.UseHiddenLineRemovalOff_0(this);
}


// void SetPass(vtkRenderPass * p)
// "void SetPass(vtkRenderPass *p)"
public void SetPass(vtkRenderPass /*(vtkRenderPass*)*/ p) {
	VTK_API.API_vtkRenderer.SetPass_0(this, p);
}


// virtual vtkRenderPass* GetPass()
// "virtual vtkRenderPass *GetPass ()"
public vtkRenderPass GetPass() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkRenderer.GetPass_0(out returnPointer, this);
//	return (vtkRenderPass)(IntPtr)returnPointer;
	return (vtkRenderPass)(IntPtr)returnPointer;
}


}
};
