

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkFeatureEdges : vtkPolyDataAlgorithm {
		public vtkFeatureEdges(IntPtr p) : base(p) {}
		public static implicit operator  vtkFeatureEdges(IntPtr p) {return new vtkFeatureEdges(p);}
		public static implicit operator  IntPtr(vtkFeatureEdges o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkFeatureEdges* SafeDownCast(vtkObjectBase * o)
// "static vtkFeatureEdges* SafeDownCast(vtkObjectBase *o)"
public static vtkFeatureEdges SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFeatureEdges.SafeDownCast_0(out returnPointer, o);
//	return (vtkFeatureEdges)(IntPtr)returnPointer;
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// vtkFeatureEdges* NewInstance()
// "vtkFeatureEdges *NewInstance()"
public vtkFeatureEdges NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFeatureEdges.NewInstance_0(out returnPointer, this);
//	return (vtkFeatureEdges)(IntPtr)returnPointer;
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// static vtkFeatureEdges* New()
// "static vtkFeatureEdges *New()"
public static vtkFeatureEdges New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFeatureEdges.New_0(out returnPointer);
//	return (vtkFeatureEdges)(IntPtr)returnPointer;
	return (vtkFeatureEdges)(IntPtr)returnPointer;
}


// virtual void SetBoundaryEdges(vtkTypeBool _arg)
// "virtual void SetBoundaryEdges (vtkTypeBool _arg)"
public void SetBoundaryEdges(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetBoundaryEdges_0(this, _arg);
}


// virtual vtkTypeBool GetBoundaryEdges()
// "virtual vtkTypeBool GetBoundaryEdges ()"
public bool GetBoundaryEdges() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.GetBoundaryEdges_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void BoundaryEdgesOn()
// "virtual void BoundaryEdgesOn ()"
public void BoundaryEdgesOn() {
	VTK_API.API_vtkFeatureEdges.BoundaryEdgesOn_0(this);
}


// virtual void BoundaryEdgesOff()
// "virtual void BoundaryEdgesOff ()"
public void BoundaryEdgesOff() {
	VTK_API.API_vtkFeatureEdges.BoundaryEdgesOff_0(this);
}


// virtual void SetFeatureEdges(vtkTypeBool _arg)
// "virtual void SetFeatureEdges (vtkTypeBool _arg)"
public void SetFeatureEdges(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetFeatureEdges_0(this, _arg);
}


// virtual vtkTypeBool GetFeatureEdges()
// "virtual vtkTypeBool GetFeatureEdges ()"
public bool GetFeatureEdges() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.GetFeatureEdges_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void FeatureEdgesOn()
// "virtual void FeatureEdgesOn ()"
public void FeatureEdgesOn() {
	VTK_API.API_vtkFeatureEdges.FeatureEdgesOn_0(this);
}


// virtual void FeatureEdgesOff()
// "virtual void FeatureEdgesOff ()"
public void FeatureEdgesOff() {
	VTK_API.API_vtkFeatureEdges.FeatureEdgesOff_0(this);
}


// virtual void SetFeatureAngle(double _arg)
// "virtual void SetFeatureAngle (double _arg)"
public void SetFeatureAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetFeatureAngle_0(this, _arg);
}


// virtual double GetFeatureAngleMinValue()
// "virtual double GetFeatureAngleMinValue ()"
public double GetFeatureAngleMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkFeatureEdges.GetFeatureAngleMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetFeatureAngleMaxValue()
// "virtual double GetFeatureAngleMaxValue ()"
public double GetFeatureAngleMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkFeatureEdges.GetFeatureAngleMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetFeatureAngle()
// "virtual double GetFeatureAngle ()"
public double GetFeatureAngle() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkFeatureEdges.GetFeatureAngle_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetNonManifoldEdges(vtkTypeBool _arg)
// "virtual void SetNonManifoldEdges (vtkTypeBool _arg)"
public void SetNonManifoldEdges(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetNonManifoldEdges_0(this, _arg);
}


// virtual vtkTypeBool GetNonManifoldEdges()
// "virtual vtkTypeBool GetNonManifoldEdges ()"
public bool GetNonManifoldEdges() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.GetNonManifoldEdges_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void NonManifoldEdgesOn()
// "virtual void NonManifoldEdgesOn ()"
public void NonManifoldEdgesOn() {
	VTK_API.API_vtkFeatureEdges.NonManifoldEdgesOn_0(this);
}


// virtual void NonManifoldEdgesOff()
// "virtual void NonManifoldEdgesOff ()"
public void NonManifoldEdgesOff() {
	VTK_API.API_vtkFeatureEdges.NonManifoldEdgesOff_0(this);
}


// virtual void SetManifoldEdges(vtkTypeBool _arg)
// "virtual void SetManifoldEdges (vtkTypeBool _arg)"
public void SetManifoldEdges(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetManifoldEdges_0(this, _arg);
}


// virtual vtkTypeBool GetManifoldEdges()
// "virtual vtkTypeBool GetManifoldEdges ()"
public bool GetManifoldEdges() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.GetManifoldEdges_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ManifoldEdgesOn()
// "virtual void ManifoldEdgesOn ()"
public void ManifoldEdgesOn() {
	VTK_API.API_vtkFeatureEdges.ManifoldEdgesOn_0(this);
}


// virtual void ManifoldEdgesOff()
// "virtual void ManifoldEdgesOff ()"
public void ManifoldEdgesOff() {
	VTK_API.API_vtkFeatureEdges.ManifoldEdgesOff_0(this);
}


// virtual void SetColoring(vtkTypeBool _arg)
// "virtual void SetColoring (vtkTypeBool _arg)"
public void SetColoring(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetColoring_0(this, _arg);
}


// virtual vtkTypeBool GetColoring()
// "virtual vtkTypeBool GetColoring ()"
public bool GetColoring() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkFeatureEdges.GetColoring_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ColoringOn()
// "virtual void ColoringOn ()"
public void ColoringOn() {
	VTK_API.API_vtkFeatureEdges.ColoringOn_0(this);
}


// virtual void ColoringOff()
// "virtual void ColoringOff ()"
public void ColoringOff() {
	VTK_API.API_vtkFeatureEdges.ColoringOff_0(this);
}


// void SetLocator(vtkIncrementalPointLocator * locator)
// "void SetLocator(vtkIncrementalPointLocator *locator)"
public void SetLocator(vtkIncrementalPointLocator /*(vtkIncrementalPointLocator*)*/ locator) {
	VTK_API.API_vtkFeatureEdges.SetLocator_0(this, locator);
}


// virtual vtkIncrementalPointLocator* GetLocator()
// "virtual vtkIncrementalPointLocator *GetLocator ()"
public vtkIncrementalPointLocator GetLocator() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkFeatureEdges.GetLocator_0(out returnPointer, this);
//	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
	return (vtkIncrementalPointLocator)(IntPtr)returnPointer;
}


// void CreateDefaultLocator()
// "void CreateDefaultLocator()"
public void CreateDefaultLocator() {
	VTK_API.API_vtkFeatureEdges.CreateDefaultLocator_0(this);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkFeatureEdges.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void SetOutputPointsPrecision(int _arg)
// "virtual void SetOutputPointsPrecision (int _arg)"
public void SetOutputPointsPrecision(int /*(int)*/ _arg) {
	VTK_API.API_vtkFeatureEdges.SetOutputPointsPrecision_0(this, _arg);
}


// virtual int GetOutputPointsPrecision()
// "virtual int GetOutputPointsPrecision ()"
public int GetOutputPointsPrecision() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkFeatureEdges.GetOutputPointsPrecision_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
