

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkExtractSurface : vtkPolyDataAlgorithm {
		public vtkExtractSurface(IntPtr p) : base(p) {}
		public static implicit operator  vtkExtractSurface(IntPtr p) {return new vtkExtractSurface(p);}
		public static implicit operator  IntPtr(vtkExtractSurface o) {return o.GetPtr();}

// static vtkExtractSurface* New()
// "static vtkExtractSurface *New()"
public static vtkExtractSurface New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkExtractSurface.New_0(out returnPointer);
//	return (vtkExtractSurface)(IntPtr)returnPointer;
	return (vtkExtractSurface)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkExtractSurface.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkExtractSurface.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkExtractSurface* SafeDownCast(vtkObjectBase * o)
// "static vtkExtractSurface* SafeDownCast(vtkObjectBase *o)"
public static vtkExtractSurface SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkExtractSurface.SafeDownCast_0(out returnPointer, o);
//	return (vtkExtractSurface)(IntPtr)returnPointer;
	return (vtkExtractSurface)(IntPtr)returnPointer;
}


// vtkExtractSurface* NewInstance()
// "vtkExtractSurface *NewInstance()"
public vtkExtractSurface NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkExtractSurface.NewInstance_0(out returnPointer, this);
//	return (vtkExtractSurface)(IntPtr)returnPointer;
	return (vtkExtractSurface)(IntPtr)returnPointer;
}


// virtual void SetRadius(double _arg)
// "virtual void SetRadius (double _arg)"
public void SetRadius(double /*(double)*/ _arg) {
	VTK_API.API_vtkExtractSurface.SetRadius_0(this, _arg);
}


// virtual double GetRadiusMinValue()
// "virtual double GetRadiusMinValue ()"
public double GetRadiusMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkExtractSurface.GetRadiusMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetRadiusMaxValue()
// "virtual double GetRadiusMaxValue ()"
public double GetRadiusMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkExtractSurface.GetRadiusMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetRadius()
// "virtual double GetRadius ()"
public double GetRadius() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkExtractSurface.GetRadius_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetHoleFilling(bool _arg)
// "virtual void SetHoleFilling (bool _arg)"
public void SetHoleFilling(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkExtractSurface.SetHoleFilling_0(this, _arg);
}


// virtual bool GetHoleFilling()
// "virtual bool GetHoleFilling ()"
public bool GetHoleFilling() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkExtractSurface.GetHoleFilling_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void HoleFillingOn()
// "virtual void HoleFillingOn ()"
public void HoleFillingOn() {
	VTK_API.API_vtkExtractSurface.HoleFillingOn_0(this);
}


// virtual void HoleFillingOff()
// "virtual void HoleFillingOff ()"
public void HoleFillingOff() {
	VTK_API.API_vtkExtractSurface.HoleFillingOff_0(this);
}


// virtual void SetComputeNormals(vtkTypeBool _arg)
// "virtual void SetComputeNormals (vtkTypeBool _arg)"
public void SetComputeNormals(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkExtractSurface.SetComputeNormals_0(this, _arg);
}


// virtual vtkTypeBool GetComputeNormals()
// "virtual vtkTypeBool GetComputeNormals ()"
public bool GetComputeNormals() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkExtractSurface.GetComputeNormals_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeNormalsOn()
// "virtual void ComputeNormalsOn ()"
public void ComputeNormalsOn() {
	VTK_API.API_vtkExtractSurface.ComputeNormalsOn_0(this);
}


// virtual void ComputeNormalsOff()
// "virtual void ComputeNormalsOff ()"
public void ComputeNormalsOff() {
	VTK_API.API_vtkExtractSurface.ComputeNormalsOff_0(this);
}


// virtual void SetComputeGradients(vtkTypeBool _arg)
// "virtual void SetComputeGradients (vtkTypeBool _arg)"
public void SetComputeGradients(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkExtractSurface.SetComputeGradients_0(this, _arg);
}


// virtual vtkTypeBool GetComputeGradients()
// "virtual vtkTypeBool GetComputeGradients ()"
public bool GetComputeGradients() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkExtractSurface.GetComputeGradients_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeGradientsOn()
// "virtual void ComputeGradientsOn ()"
public void ComputeGradientsOn() {
	VTK_API.API_vtkExtractSurface.ComputeGradientsOn_0(this);
}


// virtual void ComputeGradientsOff()
// "virtual void ComputeGradientsOff ()"
public void ComputeGradientsOff() {
	VTK_API.API_vtkExtractSurface.ComputeGradientsOff_0(this);
}


}
};
