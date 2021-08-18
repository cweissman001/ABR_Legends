

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkGradientFilter : vtkDataSetAlgorithm {
		public vtkGradientFilter(IntPtr p) : base(p) {}
		public static implicit operator  vtkGradientFilter(IntPtr p) {return new vtkGradientFilter(p);}
		public static implicit operator  IntPtr(vtkGradientFilter o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkGradientFilter* SafeDownCast(vtkObjectBase * o)
// "static vtkGradientFilter* SafeDownCast(vtkObjectBase *o)"
public static vtkGradientFilter SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGradientFilter.SafeDownCast_0(out returnPointer, o);
//	return (vtkGradientFilter)(IntPtr)returnPointer;
	return (vtkGradientFilter)(IntPtr)returnPointer;
}


// vtkGradientFilter* NewInstance()
// "vtkGradientFilter *NewInstance()"
public vtkGradientFilter NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGradientFilter.NewInstance_0(out returnPointer, this);
//	return (vtkGradientFilter)(IntPtr)returnPointer;
	return (vtkGradientFilter)(IntPtr)returnPointer;
}


// static vtkGradientFilter* New()
// "static vtkGradientFilter *New()"
public static vtkGradientFilter New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkGradientFilter.New_0(out returnPointer);
//	return (vtkGradientFilter)(IntPtr)returnPointer;
	return (vtkGradientFilter)(IntPtr)returnPointer;
}


// virtual void SetInputScalars(int fieldAssociation, const char * name)
// "virtual void SetInputScalars(int fieldAssociation, const char *name)"
public void SetInputScalars(int /*(int)*/ fieldAssociation, string /*(char*)*/ name) {
	VTK_API.API_vtkGradientFilter.SetInputScalars_0(this, fieldAssociation, name);
}


// virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)
// "virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)"
public void SetInputScalars(int /*(int)*/ fieldAssociation, int /*(int)*/ fieldAttributeType) {
	VTK_API.API_vtkGradientFilter.SetInputScalars_1(this, fieldAssociation, fieldAttributeType);
}


// virtual char* GetResultArrayName()
// "virtual char* GetResultArrayName ()"
public string GetResultArrayName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkGradientFilter.GetResultArrayName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetResultArrayName(const char * _arg)
// "virtual void SetResultArrayName (const char* _arg)"
public void SetResultArrayName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetResultArrayName_0(this, _arg);
}


// virtual char* GetDivergenceArrayName()
// "virtual char* GetDivergenceArrayName ()"
public string GetDivergenceArrayName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkGradientFilter.GetDivergenceArrayName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetDivergenceArrayName(const char * _arg)
// "virtual void SetDivergenceArrayName (const char* _arg)"
public void SetDivergenceArrayName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetDivergenceArrayName_0(this, _arg);
}


// virtual char* GetVorticityArrayName()
// "virtual char* GetVorticityArrayName ()"
public string GetVorticityArrayName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkGradientFilter.GetVorticityArrayName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetVorticityArrayName(const char * _arg)
// "virtual void SetVorticityArrayName (const char* _arg)"
public void SetVorticityArrayName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetVorticityArrayName_0(this, _arg);
}


// virtual char* GetQCriterionArrayName()
// "virtual char* GetQCriterionArrayName ()"
public string GetQCriterionArrayName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkGradientFilter.GetQCriterionArrayName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetQCriterionArrayName(const char * _arg)
// "virtual void SetQCriterionArrayName (const char* _arg)"
public void SetQCriterionArrayName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetQCriterionArrayName_0(this, _arg);
}


// virtual vtkTypeBool GetFasterApproximation()
// "virtual vtkTypeBool GetFasterApproximation ()"
public bool GetFasterApproximation() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.GetFasterApproximation_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetFasterApproximation(vtkTypeBool _arg)
// "virtual void SetFasterApproximation (vtkTypeBool _arg)"
public void SetFasterApproximation(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetFasterApproximation_0(this, _arg);
}


// virtual void FasterApproximationOn()
// "virtual void FasterApproximationOn ()"
public void FasterApproximationOn() {
	VTK_API.API_vtkGradientFilter.FasterApproximationOn_0(this);
}


// virtual void FasterApproximationOff()
// "virtual void FasterApproximationOff ()"
public void FasterApproximationOff() {
	VTK_API.API_vtkGradientFilter.FasterApproximationOff_0(this);
}


// virtual void SetComputeGradient(vtkTypeBool _arg)
// "virtual void SetComputeGradient (vtkTypeBool _arg)"
public void SetComputeGradient(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetComputeGradient_0(this, _arg);
}


// virtual vtkTypeBool GetComputeGradient()
// "virtual vtkTypeBool GetComputeGradient ()"
public bool GetComputeGradient() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.GetComputeGradient_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeGradientOn()
// "virtual void ComputeGradientOn ()"
public void ComputeGradientOn() {
	VTK_API.API_vtkGradientFilter.ComputeGradientOn_0(this);
}


// virtual void ComputeGradientOff()
// "virtual void ComputeGradientOff ()"
public void ComputeGradientOff() {
	VTK_API.API_vtkGradientFilter.ComputeGradientOff_0(this);
}


// virtual void SetComputeDivergence(vtkTypeBool _arg)
// "virtual void SetComputeDivergence (vtkTypeBool _arg)"
public void SetComputeDivergence(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetComputeDivergence_0(this, _arg);
}


// virtual vtkTypeBool GetComputeDivergence()
// "virtual vtkTypeBool GetComputeDivergence ()"
public bool GetComputeDivergence() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.GetComputeDivergence_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeDivergenceOn()
// "virtual void ComputeDivergenceOn ()"
public void ComputeDivergenceOn() {
	VTK_API.API_vtkGradientFilter.ComputeDivergenceOn_0(this);
}


// virtual void ComputeDivergenceOff()
// "virtual void ComputeDivergenceOff ()"
public void ComputeDivergenceOff() {
	VTK_API.API_vtkGradientFilter.ComputeDivergenceOff_0(this);
}


// virtual void SetComputeVorticity(vtkTypeBool _arg)
// "virtual void SetComputeVorticity (vtkTypeBool _arg)"
public void SetComputeVorticity(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetComputeVorticity_0(this, _arg);
}


// virtual vtkTypeBool GetComputeVorticity()
// "virtual vtkTypeBool GetComputeVorticity ()"
public bool GetComputeVorticity() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.GetComputeVorticity_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeVorticityOn()
// "virtual void ComputeVorticityOn ()"
public void ComputeVorticityOn() {
	VTK_API.API_vtkGradientFilter.ComputeVorticityOn_0(this);
}


// virtual void ComputeVorticityOff()
// "virtual void ComputeVorticityOff ()"
public void ComputeVorticityOff() {
	VTK_API.API_vtkGradientFilter.ComputeVorticityOff_0(this);
}


// virtual void SetComputeQCriterion(vtkTypeBool _arg)
// "virtual void SetComputeQCriterion (vtkTypeBool _arg)"
public void SetComputeQCriterion(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetComputeQCriterion_0(this, _arg);
}


// virtual vtkTypeBool GetComputeQCriterion()
// "virtual vtkTypeBool GetComputeQCriterion ()"
public bool GetComputeQCriterion() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkGradientFilter.GetComputeQCriterion_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ComputeQCriterionOn()
// "virtual void ComputeQCriterionOn ()"
public void ComputeQCriterionOn() {
	VTK_API.API_vtkGradientFilter.ComputeQCriterionOn_0(this);
}


// virtual void ComputeQCriterionOff()
// "virtual void ComputeQCriterionOff ()"
public void ComputeQCriterionOff() {
	VTK_API.API_vtkGradientFilter.ComputeQCriterionOff_0(this);
}


// virtual void SetContributingCellOption(int _arg)
// "virtual void SetContributingCellOption (int _arg)"
public void SetContributingCellOption(int /*(int)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetContributingCellOption_0(this, _arg);
}


// virtual int GetContributingCellOptionMinValue()
// "virtual int GetContributingCellOptionMinValue ()"
public int GetContributingCellOptionMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGradientFilter.GetContributingCellOptionMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetContributingCellOptionMaxValue()
// "virtual int GetContributingCellOptionMaxValue ()"
public int GetContributingCellOptionMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGradientFilter.GetContributingCellOptionMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetContributingCellOption()
// "virtual int GetContributingCellOption ()"
public int GetContributingCellOption() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGradientFilter.GetContributingCellOption_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetReplacementValueOption(int _arg)
// "virtual void SetReplacementValueOption (int _arg)"
public void SetReplacementValueOption(int /*(int)*/ _arg) {
	VTK_API.API_vtkGradientFilter.SetReplacementValueOption_0(this, _arg);
}


// virtual int GetReplacementValueOptionMinValue()
// "virtual int GetReplacementValueOptionMinValue ()"
public int GetReplacementValueOptionMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGradientFilter.GetReplacementValueOptionMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetReplacementValueOptionMaxValue()
// "virtual int GetReplacementValueOptionMaxValue ()"
public int GetReplacementValueOptionMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGradientFilter.GetReplacementValueOptionMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetReplacementValueOption()
// "virtual int GetReplacementValueOption ()"
public int GetReplacementValueOption() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkGradientFilter.GetReplacementValueOption_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
