

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkPolyDataNormals : vtkPolyDataAlgorithm {
		public vtkPolyDataNormals(IntPtr p) : base(p) {}
		public static implicit operator  vtkPolyDataNormals(IntPtr p) {return new vtkPolyDataNormals(p);}
		public static implicit operator  IntPtr(vtkPolyDataNormals o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkPolyDataNormals* SafeDownCast(vtkObjectBase * o)
// "static vtkPolyDataNormals* SafeDownCast(vtkObjectBase *o)"
public static vtkPolyDataNormals SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataNormals.SafeDownCast_0(out returnPointer, o);
//	return (vtkPolyDataNormals)(IntPtr)returnPointer;
	return (vtkPolyDataNormals)(IntPtr)returnPointer;
}


// vtkPolyDataNormals* NewInstance()
// "vtkPolyDataNormals *NewInstance()"
public vtkPolyDataNormals NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataNormals.NewInstance_0(out returnPointer, this);
//	return (vtkPolyDataNormals)(IntPtr)returnPointer;
	return (vtkPolyDataNormals)(IntPtr)returnPointer;
}


// static vtkPolyDataNormals* New()
// "static vtkPolyDataNormals *New()"
public static vtkPolyDataNormals New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkPolyDataNormals.New_0(out returnPointer);
//	return (vtkPolyDataNormals)(IntPtr)returnPointer;
	return (vtkPolyDataNormals)(IntPtr)returnPointer;
}


// virtual void SetFeatureAngle(double _arg)
// "virtual void SetFeatureAngle (double _arg)"
public void SetFeatureAngle(double /*(double)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetFeatureAngle_0(this, _arg);
}


// virtual double GetFeatureAngleMinValue()
// "virtual double GetFeatureAngleMinValue ()"
public double GetFeatureAngleMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPolyDataNormals.GetFeatureAngleMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetFeatureAngleMaxValue()
// "virtual double GetFeatureAngleMaxValue ()"
public double GetFeatureAngleMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPolyDataNormals.GetFeatureAngleMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetFeatureAngle()
// "virtual double GetFeatureAngle ()"
public double GetFeatureAngle() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkPolyDataNormals.GetFeatureAngle_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetSplitting(vtkTypeBool _arg)
// "virtual void SetSplitting (vtkTypeBool _arg)"
public void SetSplitting(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetSplitting_0(this, _arg);
}


// virtual vtkTypeBool GetSplitting()
// "virtual vtkTypeBool GetSplitting ()"
public bool GetSplitting() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetSplitting_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SplittingOn()
// "virtual void SplittingOn ()"
public void SplittingOn() {
	VTK_API.API_vtkPolyDataNormals.SplittingOn_0(this);
}


// virtual void SplittingOff()
// "virtual void SplittingOff ()"
public void SplittingOff() {
	VTK_API.API_vtkPolyDataNormals.SplittingOff_0(this);
}


// virtual void SetConsistency(vtkTypeBool _arg)
// "virtual void SetConsistency (vtkTypeBool _arg)"
public void SetConsistency(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetConsistency_0(this, _arg);
}


// virtual vtkTypeBool GetConsistency()
// "virtual vtkTypeBool GetConsistency ()"
public bool GetConsistency() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetConsistency_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ConsistencyOn()
// "virtual void ConsistencyOn ()"
public void ConsistencyOn() {
	VTK_API.API_vtkPolyDataNormals.ConsistencyOn_0(this);
}


// virtual void ConsistencyOff()
// "virtual void ConsistencyOff ()"
public void ConsistencyOff() {
	VTK_API.API_vtkPolyDataNormals.ConsistencyOff_0(this);
}


// virtual void SetAutoOrientNormals(vtkTypeBool _arg)
// "virtual void SetAutoOrientNormals (vtkTypeBool _arg)"
public void SetAutoOrientNormals(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetAutoOrientNormals_0(this, _arg);
}


// virtual vtkTypeBool GetAutoOrientNormals()
// "virtual vtkTypeBool GetAutoOrientNormals ()"
public bool GetAutoOrientNormals() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetAutoOrientNormals_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void AutoOrientNormalsOn()
// "virtual void AutoOrientNormalsOn ()"
public void AutoOrientNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.AutoOrientNormalsOn_0(this);
}


// virtual void AutoOrientNormalsOff()
// "virtual void AutoOrientNormalsOff ()"
public void AutoOrientNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.AutoOrientNormalsOff_0(this);
}


// virtual void SetComputePointNormals(vtkTypeBool _arg)
// "virtual void SetComputePointNormals (vtkTypeBool _arg)"
public void SetComputePointNormals(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetComputePointNormals_0(this, _arg);
}


// virtual vtkTypeBool GetComputePointNormals()
// "virtual vtkTypeBool GetComputePointNormals ()"
public bool GetComputePointNormals() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetComputePointNormals_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputePointNormalsOn()
// "virtual void ComputePointNormalsOn ()"
public void ComputePointNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.ComputePointNormalsOn_0(this);
}


// virtual void ComputePointNormalsOff()
// "virtual void ComputePointNormalsOff ()"
public void ComputePointNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.ComputePointNormalsOff_0(this);
}


// virtual void SetComputeCellNormals(vtkTypeBool _arg)
// "virtual void SetComputeCellNormals (vtkTypeBool _arg)"
public void SetComputeCellNormals(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetComputeCellNormals_0(this, _arg);
}


// virtual vtkTypeBool GetComputeCellNormals()
// "virtual vtkTypeBool GetComputeCellNormals ()"
public bool GetComputeCellNormals() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetComputeCellNormals_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeCellNormalsOn()
// "virtual void ComputeCellNormalsOn ()"
public void ComputeCellNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.ComputeCellNormalsOn_0(this);
}


// virtual void ComputeCellNormalsOff()
// "virtual void ComputeCellNormalsOff ()"
public void ComputeCellNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.ComputeCellNormalsOff_0(this);
}


// virtual void SetFlipNormals(vtkTypeBool _arg)
// "virtual void SetFlipNormals (vtkTypeBool _arg)"
public void SetFlipNormals(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetFlipNormals_0(this, _arg);
}


// virtual vtkTypeBool GetFlipNormals()
// "virtual vtkTypeBool GetFlipNormals ()"
public bool GetFlipNormals() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetFlipNormals_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void FlipNormalsOn()
// "virtual void FlipNormalsOn ()"
public void FlipNormalsOn() {
	VTK_API.API_vtkPolyDataNormals.FlipNormalsOn_0(this);
}


// virtual void FlipNormalsOff()
// "virtual void FlipNormalsOff ()"
public void FlipNormalsOff() {
	VTK_API.API_vtkPolyDataNormals.FlipNormalsOff_0(this);
}


// virtual void SetNonManifoldTraversal(vtkTypeBool _arg)
// "virtual void SetNonManifoldTraversal (vtkTypeBool _arg)"
public void SetNonManifoldTraversal(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetNonManifoldTraversal_0(this, _arg);
}


// virtual vtkTypeBool GetNonManifoldTraversal()
// "virtual vtkTypeBool GetNonManifoldTraversal ()"
public bool GetNonManifoldTraversal() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkPolyDataNormals.GetNonManifoldTraversal_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void NonManifoldTraversalOn()
// "virtual void NonManifoldTraversalOn ()"
public void NonManifoldTraversalOn() {
	VTK_API.API_vtkPolyDataNormals.NonManifoldTraversalOn_0(this);
}


// virtual void NonManifoldTraversalOff()
// "virtual void NonManifoldTraversalOff ()"
public void NonManifoldTraversalOff() {
	VTK_API.API_vtkPolyDataNormals.NonManifoldTraversalOff_0(this);
}


// virtual void SetOutputPointsPrecision(int _arg)
// "virtual void SetOutputPointsPrecision (int _arg)"
public void SetOutputPointsPrecision(int /*(int)*/ _arg) {
	VTK_API.API_vtkPolyDataNormals.SetOutputPointsPrecision_0(this, _arg);
}


// virtual int GetOutputPointsPrecisionMinValue()
// "virtual int GetOutputPointsPrecisionMinValue ()"
public int GetOutputPointsPrecisionMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataNormals.GetOutputPointsPrecisionMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetOutputPointsPrecisionMaxValue()
// "virtual int GetOutputPointsPrecisionMaxValue ()"
public int GetOutputPointsPrecisionMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataNormals.GetOutputPointsPrecisionMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetOutputPointsPrecision()
// "virtual int GetOutputPointsPrecision ()"
public int GetOutputPointsPrecision() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkPolyDataNormals.GetOutputPointsPrecision_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
