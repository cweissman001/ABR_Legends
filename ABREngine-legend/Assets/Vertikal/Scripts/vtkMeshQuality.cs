

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkMeshQuality : vtkDataSetAlgorithm {
		public vtkMeshQuality(IntPtr p) : base(p) {}
		public static implicit operator  vtkMeshQuality(IntPtr p) {return new vtkMeshQuality(p);}
		public static implicit operator  IntPtr(vtkMeshQuality o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMeshQuality.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMeshQuality.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkMeshQuality* SafeDownCast(vtkObjectBase * o)
// "static vtkMeshQuality* SafeDownCast(vtkObjectBase *o)"
public static vtkMeshQuality SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMeshQuality.SafeDownCast_0(out returnPointer, o);
//	return (vtkMeshQuality)(IntPtr)returnPointer;
	return (vtkMeshQuality)(IntPtr)returnPointer;
}


// vtkMeshQuality* NewInstance()
// "vtkMeshQuality *NewInstance()"
public vtkMeshQuality NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMeshQuality.NewInstance_0(out returnPointer, this);
//	return (vtkMeshQuality)(IntPtr)returnPointer;
	return (vtkMeshQuality)(IntPtr)returnPointer;
}


// static vtkMeshQuality* New()
// "static vtkMeshQuality* New()"
public static vtkMeshQuality New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMeshQuality.New_0(out returnPointer);
//	return (vtkMeshQuality)(IntPtr)returnPointer;
	return (vtkMeshQuality)(IntPtr)returnPointer;
}


// virtual void SetSaveCellQuality(vtkTypeBool _arg)
// "virtual void SetSaveCellQuality (vtkTypeBool _arg)"
public void SetSaveCellQuality(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkMeshQuality.SetSaveCellQuality_0(this, _arg);
}


// virtual vtkTypeBool GetSaveCellQuality()
// "virtual vtkTypeBool GetSaveCellQuality ()"
public bool GetSaveCellQuality() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMeshQuality.GetSaveCellQuality_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SaveCellQualityOn()
// "virtual void SaveCellQualityOn ()"
public void SaveCellQualityOn() {
	VTK_API.API_vtkMeshQuality.SaveCellQualityOn_0(this);
}


// virtual void SaveCellQualityOff()
// "virtual void SaveCellQualityOff ()"
public void SaveCellQualityOff() {
	VTK_API.API_vtkMeshQuality.SaveCellQualityOff_0(this);
}


// virtual void SetTriangleQualityMeasure(int _arg)
// "virtual void SetTriangleQualityMeasure (int _arg)"
public void SetTriangleQualityMeasure(int /*(int)*/ _arg) {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasure_0(this, _arg);
}


// virtual int GetTriangleQualityMeasure()
// "virtual int GetTriangleQualityMeasure ()"
public int GetTriangleQualityMeasure() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMeshQuality.GetTriangleQualityMeasure_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetTriangleQualityMeasureToArea()
// "void SetTriangleQualityMeasureToArea()"
public void SetTriangleQualityMeasureToArea() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToArea_0(this);
}


// void SetTriangleQualityMeasureToEdgeRatio()
// "void SetTriangleQualityMeasureToEdgeRatio()"
public void SetTriangleQualityMeasureToEdgeRatio() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToEdgeRatio_0(this);
}


// void SetTriangleQualityMeasureToAspectRatio()
// "void SetTriangleQualityMeasureToAspectRatio()"
public void SetTriangleQualityMeasureToAspectRatio() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToAspectRatio_0(this);
}


// void SetTriangleQualityMeasureToRadiusRatio()
// "void SetTriangleQualityMeasureToRadiusRatio()"
public void SetTriangleQualityMeasureToRadiusRatio() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToRadiusRatio_0(this);
}


// void SetTriangleQualityMeasureToAspectFrobenius()
// "void SetTriangleQualityMeasureToAspectFrobenius()"
public void SetTriangleQualityMeasureToAspectFrobenius() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToAspectFrobenius_0(this);
}


// void SetTriangleQualityMeasureToMinAngle()
// "void SetTriangleQualityMeasureToMinAngle()"
public void SetTriangleQualityMeasureToMinAngle() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToMinAngle_0(this);
}


// void SetTriangleQualityMeasureToMaxAngle()
// "void SetTriangleQualityMeasureToMaxAngle()"
public void SetTriangleQualityMeasureToMaxAngle() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToMaxAngle_0(this);
}


// void SetTriangleQualityMeasureToCondition()
// "void SetTriangleQualityMeasureToCondition()"
public void SetTriangleQualityMeasureToCondition() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToCondition_0(this);
}


// void SetTriangleQualityMeasureToScaledJacobian()
// "void SetTriangleQualityMeasureToScaledJacobian()"
public void SetTriangleQualityMeasureToScaledJacobian() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToScaledJacobian_0(this);
}


// void SetTriangleQualityMeasureToRelativeSizeSquared()
// "void SetTriangleQualityMeasureToRelativeSizeSquared()"
public void SetTriangleQualityMeasureToRelativeSizeSquared() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToRelativeSizeSquared_0(this);
}


// void SetTriangleQualityMeasureToShape()
// "void SetTriangleQualityMeasureToShape()"
public void SetTriangleQualityMeasureToShape() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToShape_0(this);
}


// void SetTriangleQualityMeasureToShapeAndSize()
// "void SetTriangleQualityMeasureToShapeAndSize()"
public void SetTriangleQualityMeasureToShapeAndSize() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToShapeAndSize_0(this);
}


// void SetTriangleQualityMeasureToDistortion()
// "void SetTriangleQualityMeasureToDistortion()"
public void SetTriangleQualityMeasureToDistortion() {
	VTK_API.API_vtkMeshQuality.SetTriangleQualityMeasureToDistortion_0(this);
}


// virtual void SetQuadQualityMeasure(int _arg)
// "virtual void SetQuadQualityMeasure (int _arg)"
public void SetQuadQualityMeasure(int /*(int)*/ _arg) {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasure_0(this, _arg);
}


// virtual int GetQuadQualityMeasure()
// "virtual int GetQuadQualityMeasure ()"
public int GetQuadQualityMeasure() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMeshQuality.GetQuadQualityMeasure_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetQuadQualityMeasureToEdgeRatio()
// "void SetQuadQualityMeasureToEdgeRatio()"
public void SetQuadQualityMeasureToEdgeRatio() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToEdgeRatio_0(this);
}


// void SetQuadQualityMeasureToAspectRatio()
// "void SetQuadQualityMeasureToAspectRatio()"
public void SetQuadQualityMeasureToAspectRatio() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToAspectRatio_0(this);
}


// void SetQuadQualityMeasureToRadiusRatio()
// "void SetQuadQualityMeasureToRadiusRatio()"
public void SetQuadQualityMeasureToRadiusRatio() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToRadiusRatio_0(this);
}


// void SetQuadQualityMeasureToMedAspectFrobenius()
// "void SetQuadQualityMeasureToMedAspectFrobenius()"
public void SetQuadQualityMeasureToMedAspectFrobenius() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToMedAspectFrobenius_0(this);
}


// void SetQuadQualityMeasureToMaxAspectFrobenius()
// "void SetQuadQualityMeasureToMaxAspectFrobenius()"
public void SetQuadQualityMeasureToMaxAspectFrobenius() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToMaxAspectFrobenius_0(this);
}


// void SetQuadQualityMeasureToMaxEdgeRatios()
// "void SetQuadQualityMeasureToMaxEdgeRatios()"
public void SetQuadQualityMeasureToMaxEdgeRatios() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToMaxEdgeRatios_0(this);
}


// void SetQuadQualityMeasureToSkew()
// "void SetQuadQualityMeasureToSkew()"
public void SetQuadQualityMeasureToSkew() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToSkew_0(this);
}


// void SetQuadQualityMeasureToTaper()
// "void SetQuadQualityMeasureToTaper()"
public void SetQuadQualityMeasureToTaper() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToTaper_0(this);
}


// void SetQuadQualityMeasureToWarpage()
// "void SetQuadQualityMeasureToWarpage()"
public void SetQuadQualityMeasureToWarpage() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToWarpage_0(this);
}


// void SetQuadQualityMeasureToArea()
// "void SetQuadQualityMeasureToArea()"
public void SetQuadQualityMeasureToArea() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToArea_0(this);
}


// void SetQuadQualityMeasureToStretch()
// "void SetQuadQualityMeasureToStretch()"
public void SetQuadQualityMeasureToStretch() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToStretch_0(this);
}


// void SetQuadQualityMeasureToMinAngle()
// "void SetQuadQualityMeasureToMinAngle()"
public void SetQuadQualityMeasureToMinAngle() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToMinAngle_0(this);
}


// void SetQuadQualityMeasureToMaxAngle()
// "void SetQuadQualityMeasureToMaxAngle()"
public void SetQuadQualityMeasureToMaxAngle() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToMaxAngle_0(this);
}


// void SetQuadQualityMeasureToOddy()
// "void SetQuadQualityMeasureToOddy()"
public void SetQuadQualityMeasureToOddy() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToOddy_0(this);
}


// void SetQuadQualityMeasureToCondition()
// "void SetQuadQualityMeasureToCondition()"
public void SetQuadQualityMeasureToCondition() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToCondition_0(this);
}


// void SetQuadQualityMeasureToJacobian()
// "void SetQuadQualityMeasureToJacobian()"
public void SetQuadQualityMeasureToJacobian() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToJacobian_0(this);
}


// void SetQuadQualityMeasureToScaledJacobian()
// "void SetQuadQualityMeasureToScaledJacobian()"
public void SetQuadQualityMeasureToScaledJacobian() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToScaledJacobian_0(this);
}


// void SetQuadQualityMeasureToShear()
// "void SetQuadQualityMeasureToShear()"
public void SetQuadQualityMeasureToShear() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToShear_0(this);
}


// void SetQuadQualityMeasureToShape()
// "void SetQuadQualityMeasureToShape()"
public void SetQuadQualityMeasureToShape() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToShape_0(this);
}


// void SetQuadQualityMeasureToRelativeSizeSquared()
// "void SetQuadQualityMeasureToRelativeSizeSquared()"
public void SetQuadQualityMeasureToRelativeSizeSquared() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToRelativeSizeSquared_0(this);
}


// void SetQuadQualityMeasureToShapeAndSize()
// "void SetQuadQualityMeasureToShapeAndSize()"
public void SetQuadQualityMeasureToShapeAndSize() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToShapeAndSize_0(this);
}


// void SetQuadQualityMeasureToShearAndSize()
// "void SetQuadQualityMeasureToShearAndSize()"
public void SetQuadQualityMeasureToShearAndSize() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToShearAndSize_0(this);
}


// void SetQuadQualityMeasureToDistortion()
// "void SetQuadQualityMeasureToDistortion()"
public void SetQuadQualityMeasureToDistortion() {
	VTK_API.API_vtkMeshQuality.SetQuadQualityMeasureToDistortion_0(this);
}


// virtual void SetTetQualityMeasure(int _arg)
// "virtual void SetTetQualityMeasure (int _arg)"
public void SetTetQualityMeasure(int /*(int)*/ _arg) {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasure_0(this, _arg);
}


// virtual int GetTetQualityMeasure()
// "virtual int GetTetQualityMeasure ()"
public int GetTetQualityMeasure() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMeshQuality.GetTetQualityMeasure_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetTetQualityMeasureToEdgeRatio()
// "void SetTetQualityMeasureToEdgeRatio()"
public void SetTetQualityMeasureToEdgeRatio() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToEdgeRatio_0(this);
}


// void SetTetQualityMeasureToAspectRatio()
// "void SetTetQualityMeasureToAspectRatio()"
public void SetTetQualityMeasureToAspectRatio() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToAspectRatio_0(this);
}


// void SetTetQualityMeasureToRadiusRatio()
// "void SetTetQualityMeasureToRadiusRatio()"
public void SetTetQualityMeasureToRadiusRatio() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToRadiusRatio_0(this);
}


// void SetTetQualityMeasureToAspectFrobenius()
// "void SetTetQualityMeasureToAspectFrobenius()"
public void SetTetQualityMeasureToAspectFrobenius() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToAspectFrobenius_0(this);
}


// void SetTetQualityMeasureToMinAngle()
// "void SetTetQualityMeasureToMinAngle()"
public void SetTetQualityMeasureToMinAngle() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToMinAngle_0(this);
}


// void SetTetQualityMeasureToCollapseRatio()
// "void SetTetQualityMeasureToCollapseRatio()"
public void SetTetQualityMeasureToCollapseRatio() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToCollapseRatio_0(this);
}


// void SetTetQualityMeasureToAspectBeta()
// "void SetTetQualityMeasureToAspectBeta()"
public void SetTetQualityMeasureToAspectBeta() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToAspectBeta_0(this);
}


// void SetTetQualityMeasureToAspectGamma()
// "void SetTetQualityMeasureToAspectGamma()"
public void SetTetQualityMeasureToAspectGamma() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToAspectGamma_0(this);
}


// void SetTetQualityMeasureToVolume()
// "void SetTetQualityMeasureToVolume()"
public void SetTetQualityMeasureToVolume() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToVolume_0(this);
}


// void SetTetQualityMeasureToCondition()
// "void SetTetQualityMeasureToCondition()"
public void SetTetQualityMeasureToCondition() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToCondition_0(this);
}


// void SetTetQualityMeasureToJacobian()
// "void SetTetQualityMeasureToJacobian()"
public void SetTetQualityMeasureToJacobian() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToJacobian_0(this);
}


// void SetTetQualityMeasureToScaledJacobian()
// "void SetTetQualityMeasureToScaledJacobian()"
public void SetTetQualityMeasureToScaledJacobian() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToScaledJacobian_0(this);
}


// void SetTetQualityMeasureToShape()
// "void SetTetQualityMeasureToShape()"
public void SetTetQualityMeasureToShape() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToShape_0(this);
}


// void SetTetQualityMeasureToRelativeSizeSquared()
// "void SetTetQualityMeasureToRelativeSizeSquared()"
public void SetTetQualityMeasureToRelativeSizeSquared() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToRelativeSizeSquared_0(this);
}


// void SetTetQualityMeasureToShapeAndSize()
// "void SetTetQualityMeasureToShapeAndSize()"
public void SetTetQualityMeasureToShapeAndSize() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToShapeAndSize_0(this);
}


// void SetTetQualityMeasureToDistortion()
// "void SetTetQualityMeasureToDistortion()"
public void SetTetQualityMeasureToDistortion() {
	VTK_API.API_vtkMeshQuality.SetTetQualityMeasureToDistortion_0(this);
}


// virtual void SetHexQualityMeasure(int _arg)
// "virtual void SetHexQualityMeasure (int _arg)"
public void SetHexQualityMeasure(int /*(int)*/ _arg) {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasure_0(this, _arg);
}


// virtual int GetHexQualityMeasure()
// "virtual int GetHexQualityMeasure ()"
public int GetHexQualityMeasure() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMeshQuality.GetHexQualityMeasure_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetHexQualityMeasureToEdgeRatio()
// "void SetHexQualityMeasureToEdgeRatio()"
public void SetHexQualityMeasureToEdgeRatio() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToEdgeRatio_0(this);
}


// void SetHexQualityMeasureToMedAspectFrobenius()
// "void SetHexQualityMeasureToMedAspectFrobenius()"
public void SetHexQualityMeasureToMedAspectFrobenius() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToMedAspectFrobenius_0(this);
}


// void SetHexQualityMeasureToMaxAspectFrobenius()
// "void SetHexQualityMeasureToMaxAspectFrobenius()"
public void SetHexQualityMeasureToMaxAspectFrobenius() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToMaxAspectFrobenius_0(this);
}


// void SetHexQualityMeasureToMaxEdgeRatios()
// "void SetHexQualityMeasureToMaxEdgeRatios()"
public void SetHexQualityMeasureToMaxEdgeRatios() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToMaxEdgeRatios_0(this);
}


// void SetHexQualityMeasureToSkew()
// "void SetHexQualityMeasureToSkew()"
public void SetHexQualityMeasureToSkew() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToSkew_0(this);
}


// void SetHexQualityMeasureToTaper()
// "void SetHexQualityMeasureToTaper()"
public void SetHexQualityMeasureToTaper() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToTaper_0(this);
}


// void SetHexQualityMeasureToVolume()
// "void SetHexQualityMeasureToVolume()"
public void SetHexQualityMeasureToVolume() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToVolume_0(this);
}


// void SetHexQualityMeasureToStretch()
// "void SetHexQualityMeasureToStretch()"
public void SetHexQualityMeasureToStretch() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToStretch_0(this);
}


// void SetHexQualityMeasureToDiagonal()
// "void SetHexQualityMeasureToDiagonal()"
public void SetHexQualityMeasureToDiagonal() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToDiagonal_0(this);
}


// void SetHexQualityMeasureToDimension()
// "void SetHexQualityMeasureToDimension()"
public void SetHexQualityMeasureToDimension() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToDimension_0(this);
}


// void SetHexQualityMeasureToOddy()
// "void SetHexQualityMeasureToOddy()"
public void SetHexQualityMeasureToOddy() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToOddy_0(this);
}


// void SetHexQualityMeasureToCondition()
// "void SetHexQualityMeasureToCondition()"
public void SetHexQualityMeasureToCondition() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToCondition_0(this);
}


// void SetHexQualityMeasureToJacobian()
// "void SetHexQualityMeasureToJacobian()"
public void SetHexQualityMeasureToJacobian() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToJacobian_0(this);
}


// void SetHexQualityMeasureToScaledJacobian()
// "void SetHexQualityMeasureToScaledJacobian()"
public void SetHexQualityMeasureToScaledJacobian() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToScaledJacobian_0(this);
}


// void SetHexQualityMeasureToShear()
// "void SetHexQualityMeasureToShear()"
public void SetHexQualityMeasureToShear() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToShear_0(this);
}


// void SetHexQualityMeasureToShape()
// "void SetHexQualityMeasureToShape()"
public void SetHexQualityMeasureToShape() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToShape_0(this);
}


// void SetHexQualityMeasureToRelativeSizeSquared()
// "void SetHexQualityMeasureToRelativeSizeSquared()"
public void SetHexQualityMeasureToRelativeSizeSquared() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToRelativeSizeSquared_0(this);
}


// void SetHexQualityMeasureToShapeAndSize()
// "void SetHexQualityMeasureToShapeAndSize()"
public void SetHexQualityMeasureToShapeAndSize() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToShapeAndSize_0(this);
}


// void SetHexQualityMeasureToShearAndSize()
// "void SetHexQualityMeasureToShearAndSize()"
public void SetHexQualityMeasureToShearAndSize() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToShearAndSize_0(this);
}


// void SetHexQualityMeasureToDistortion()
// "void SetHexQualityMeasureToDistortion()"
public void SetHexQualityMeasureToDistortion() {
	VTK_API.API_vtkMeshQuality.SetHexQualityMeasureToDistortion_0(this);
}


// static double TriangleArea(vtkCell * cell)
// "static double TriangleArea( vtkCell* cell )"
public static double TriangleArea(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleArea_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleEdgeRatio(vtkCell * cell)
// "static double TriangleEdgeRatio( vtkCell* cell )"
public static double TriangleEdgeRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleEdgeRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleAspectRatio(vtkCell * cell)
// "static double TriangleAspectRatio( vtkCell* cell )"
public static double TriangleAspectRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleAspectRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleRadiusRatio(vtkCell * cell)
// "static double TriangleRadiusRatio( vtkCell* cell )"
public static double TriangleRadiusRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleRadiusRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleAspectFrobenius(vtkCell * cell)
// "static double TriangleAspectFrobenius( vtkCell* cell )"
public static double TriangleAspectFrobenius(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleAspectFrobenius_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleMinAngle(vtkCell * cell)
// "static double TriangleMinAngle( vtkCell* cell )"
public static double TriangleMinAngle(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleMinAngle_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleMaxAngle(vtkCell * cell)
// "static double TriangleMaxAngle( vtkCell* cell )"
public static double TriangleMaxAngle(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleMaxAngle_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleCondition(vtkCell * cell)
// "static double TriangleCondition( vtkCell* cell )"
public static double TriangleCondition(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleCondition_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleScaledJacobian(vtkCell * cell)
// "static double TriangleScaledJacobian( vtkCell* cell )"
public static double TriangleScaledJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleScaledJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleRelativeSizeSquared(vtkCell * cell)
// "static double TriangleRelativeSizeSquared( vtkCell* cell )"
public static double TriangleRelativeSizeSquared(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleRelativeSizeSquared_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleShape(vtkCell * cell)
// "static double TriangleShape( vtkCell* cell )"
public static double TriangleShape(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleShape_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleShapeAndSize(vtkCell * cell)
// "static double TriangleShapeAndSize( vtkCell* cell )"
public static double TriangleShapeAndSize(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleShapeAndSize_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TriangleDistortion(vtkCell * cell)
// "static double TriangleDistortion( vtkCell* cell )"
public static double TriangleDistortion(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TriangleDistortion_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadEdgeRatio(vtkCell * cell)
// "static double QuadEdgeRatio( vtkCell* cell )"
public static double QuadEdgeRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadEdgeRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadAspectRatio(vtkCell * cell)
// "static double QuadAspectRatio( vtkCell* cell )"
public static double QuadAspectRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadAspectRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadRadiusRatio(vtkCell * cell)
// "static double QuadRadiusRatio( vtkCell* cell )"
public static double QuadRadiusRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadRadiusRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadMedAspectFrobenius(vtkCell * cell)
// "static double QuadMedAspectFrobenius( vtkCell* cell )"
public static double QuadMedAspectFrobenius(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadMedAspectFrobenius_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadMaxAspectFrobenius(vtkCell * cell)
// "static double QuadMaxAspectFrobenius( vtkCell* cell )"
public static double QuadMaxAspectFrobenius(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadMaxAspectFrobenius_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadMinAngle(vtkCell * cell)
// "static double QuadMinAngle( vtkCell* cell )"
public static double QuadMinAngle(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadMinAngle_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadMaxEdgeRatios(vtkCell * cell)
// "static double QuadMaxEdgeRatios( vtkCell* cell )"
public static double QuadMaxEdgeRatios(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadMaxEdgeRatios_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadSkew(vtkCell * cell)
// "static double QuadSkew( vtkCell* cell )"
public static double QuadSkew(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadSkew_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadTaper(vtkCell * cell)
// "static double QuadTaper( vtkCell* cell )"
public static double QuadTaper(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadTaper_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadWarpage(vtkCell * cell)
// "static double QuadWarpage( vtkCell* cell )"
public static double QuadWarpage(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadWarpage_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadArea(vtkCell * cell)
// "static double QuadArea( vtkCell* cell )"
public static double QuadArea(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadArea_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadStretch(vtkCell * cell)
// "static double QuadStretch( vtkCell* cell )"
public static double QuadStretch(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadStretch_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadMaxAngle(vtkCell * cell)
// "static double QuadMaxAngle( vtkCell* cell )"
public static double QuadMaxAngle(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadMaxAngle_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadOddy(vtkCell * cell)
// "static double QuadOddy( vtkCell* cell )"
public static double QuadOddy(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadOddy_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadCondition(vtkCell * cell)
// "static double QuadCondition( vtkCell* cell )"
public static double QuadCondition(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadCondition_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadJacobian(vtkCell * cell)
// "static double QuadJacobian( vtkCell* cell )"
public static double QuadJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadScaledJacobian(vtkCell * cell)
// "static double QuadScaledJacobian( vtkCell* cell )"
public static double QuadScaledJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadScaledJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadShear(vtkCell * cell)
// "static double QuadShear( vtkCell* cell )"
public static double QuadShear(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadShear_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadShape(vtkCell * cell)
// "static double QuadShape( vtkCell* cell )"
public static double QuadShape(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadShape_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadRelativeSizeSquared(vtkCell * cell)
// "static double QuadRelativeSizeSquared( vtkCell* cell )"
public static double QuadRelativeSizeSquared(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadRelativeSizeSquared_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadShapeAndSize(vtkCell * cell)
// "static double QuadShapeAndSize( vtkCell* cell )"
public static double QuadShapeAndSize(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadShapeAndSize_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadShearAndSize(vtkCell * cell)
// "static double QuadShearAndSize( vtkCell* cell )"
public static double QuadShearAndSize(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadShearAndSize_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double QuadDistortion(vtkCell * cell)
// "static double QuadDistortion( vtkCell* cell )"
public static double QuadDistortion(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.QuadDistortion_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetEdgeRatio(vtkCell * cell)
// "static double TetEdgeRatio( vtkCell* cell )"
public static double TetEdgeRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetEdgeRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetAspectRatio(vtkCell * cell)
// "static double TetAspectRatio( vtkCell* cell )"
public static double TetAspectRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetAspectRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetRadiusRatio(vtkCell * cell)
// "static double TetRadiusRatio( vtkCell* cell )"
public static double TetRadiusRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetRadiusRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetAspectFrobenius(vtkCell * cell)
// "static double TetAspectFrobenius( vtkCell* cell )"
public static double TetAspectFrobenius(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetAspectFrobenius_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetMinAngle(vtkCell * cell)
// "static double TetMinAngle( vtkCell* cell )"
public static double TetMinAngle(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetMinAngle_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetCollapseRatio(vtkCell * cell)
// "static double TetCollapseRatio( vtkCell* cell )"
public static double TetCollapseRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetCollapseRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetAspectBeta(vtkCell * cell)
// "static double TetAspectBeta( vtkCell* cell )"
public static double TetAspectBeta(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetAspectBeta_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetAspectGamma(vtkCell * cell)
// "static double TetAspectGamma( vtkCell* cell )"
public static double TetAspectGamma(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetAspectGamma_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetVolume(vtkCell * cell)
// "static double TetVolume( vtkCell* cell )"
public static double TetVolume(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetVolume_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetCondition(vtkCell * cell)
// "static double TetCondition( vtkCell* cell )"
public static double TetCondition(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetCondition_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetJacobian(vtkCell * cell)
// "static double TetJacobian( vtkCell* cell )"
public static double TetJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetScaledJacobian(vtkCell * cell)
// "static double TetScaledJacobian( vtkCell* cell )"
public static double TetScaledJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetScaledJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetShape(vtkCell * cell)
// "static double TetShape( vtkCell* cell )"
public static double TetShape(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetShape_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetRelativeSizeSquared(vtkCell * cell)
// "static double TetRelativeSizeSquared( vtkCell* cell )"
public static double TetRelativeSizeSquared(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetRelativeSizeSquared_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetShapeandSize(vtkCell * cell)
// "static double TetShapeandSize( vtkCell* cell )"
public static double TetShapeandSize(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetShapeandSize_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double TetDistortion(vtkCell * cell)
// "static double TetDistortion( vtkCell* cell )"
public static double TetDistortion(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.TetDistortion_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexEdgeRatio(vtkCell * cell)
// "static double HexEdgeRatio( vtkCell* cell )"
public static double HexEdgeRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexEdgeRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexMedAspectFrobenius(vtkCell * cell)
// "static double HexMedAspectFrobenius( vtkCell* cell )"
public static double HexMedAspectFrobenius(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexMedAspectFrobenius_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexMaxAspectFrobenius(vtkCell * cell)
// "static double HexMaxAspectFrobenius( vtkCell* cell )"
public static double HexMaxAspectFrobenius(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexMaxAspectFrobenius_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexMaxEdgeRatio(vtkCell * cell)
// "static double HexMaxEdgeRatio( vtkCell* cell )"
public static double HexMaxEdgeRatio(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexMaxEdgeRatio_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexSkew(vtkCell * cell)
// "static double HexSkew( vtkCell* cell )"
public static double HexSkew(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexSkew_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexTaper(vtkCell * cell)
// "static double HexTaper( vtkCell* cell )"
public static double HexTaper(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexTaper_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexVolume(vtkCell * cell)
// "static double HexVolume( vtkCell* cell )"
public static double HexVolume(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexVolume_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexStretch(vtkCell * cell)
// "static double HexStretch( vtkCell* cell )"
public static double HexStretch(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexStretch_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexDiagonal(vtkCell * cell)
// "static double HexDiagonal( vtkCell* cell )"
public static double HexDiagonal(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexDiagonal_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexDimension(vtkCell * cell)
// "static double HexDimension( vtkCell* cell )"
public static double HexDimension(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexDimension_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexOddy(vtkCell * cell)
// "static double HexOddy( vtkCell* cell )"
public static double HexOddy(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexOddy_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexCondition(vtkCell * cell)
// "static double HexCondition( vtkCell* cell )"
public static double HexCondition(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexCondition_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexJacobian(vtkCell * cell)
// "static double HexJacobian( vtkCell* cell )"
public static double HexJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexScaledJacobian(vtkCell * cell)
// "static double HexScaledJacobian( vtkCell* cell )"
public static double HexScaledJacobian(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexScaledJacobian_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexShear(vtkCell * cell)
// "static double HexShear( vtkCell* cell )"
public static double HexShear(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexShear_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexShape(vtkCell * cell)
// "static double HexShape( vtkCell* cell )"
public static double HexShape(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexShape_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexRelativeSizeSquared(vtkCell * cell)
// "static double HexRelativeSizeSquared( vtkCell* cell )"
public static double HexRelativeSizeSquared(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexRelativeSizeSquared_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexShapeAndSize(vtkCell * cell)
// "static double HexShapeAndSize( vtkCell* cell )"
public static double HexShapeAndSize(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexShapeAndSize_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexShearAndSize(vtkCell * cell)
// "static double HexShearAndSize( vtkCell* cell )"
public static double HexShearAndSize(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexShearAndSize_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// static double HexDistortion(vtkCell * cell)
// "static double HexDistortion( vtkCell* cell )"
public static double HexDistortion(vtkCell /*(vtkCell*)*/ cell) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMeshQuality.HexDistortion_0(out returnPointer, cell);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetRatio(vtkTypeBool r)
// "virtual void SetRatio( vtkTypeBool r )"
public void SetRatio(bool /*(vtkTypeBool)*/ r) {
	VTK_API.API_vtkMeshQuality.SetRatio_0(this, r);
}


// vtkTypeBool GetRatio()
// "vtkTypeBool GetRatio()"
public bool GetRatio() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMeshQuality.GetRatio_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void RatioOn()
// "virtual void RatioOn ()"
public void RatioOn() {
	VTK_API.API_vtkMeshQuality.RatioOn_0(this);
}


// virtual void RatioOff()
// "virtual void RatioOff ()"
public void RatioOff() {
	VTK_API.API_vtkMeshQuality.RatioOff_0(this);
}


// virtual void SetVolume(vtkTypeBool cv)
// "virtual void SetVolume( vtkTypeBool cv )"
public void SetVolume(bool /*(vtkTypeBool)*/ cv) {
	VTK_API.API_vtkMeshQuality.SetVolume_0(this, cv);
}


// vtkTypeBool GetVolume()
// "vtkTypeBool GetVolume()"
public bool GetVolume() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMeshQuality.GetVolume_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void VolumeOn()
// "virtual void VolumeOn ()"
public void VolumeOn() {
	VTK_API.API_vtkMeshQuality.VolumeOn_0(this);
}


// virtual void VolumeOff()
// "virtual void VolumeOff ()"
public void VolumeOff() {
	VTK_API.API_vtkMeshQuality.VolumeOff_0(this);
}


// virtual void SetCompatibilityMode(vtkTypeBool cm)
// "virtual void SetCompatibilityMode( vtkTypeBool cm )"
public void SetCompatibilityMode(bool /*(vtkTypeBool)*/ cm) {
	VTK_API.API_vtkMeshQuality.SetCompatibilityMode_0(this, cm);
}


// virtual vtkTypeBool GetCompatibilityMode()
// "virtual vtkTypeBool GetCompatibilityMode ()"
public bool GetCompatibilityMode() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMeshQuality.GetCompatibilityMode_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void CompatibilityModeOn()
// "virtual void CompatibilityModeOn ()"
public void CompatibilityModeOn() {
	VTK_API.API_vtkMeshQuality.CompatibilityModeOn_0(this);
}


// virtual void CompatibilityModeOff()
// "virtual void CompatibilityModeOff ()"
public void CompatibilityModeOff() {
	VTK_API.API_vtkMeshQuality.CompatibilityModeOff_0(this);
}


}
};
