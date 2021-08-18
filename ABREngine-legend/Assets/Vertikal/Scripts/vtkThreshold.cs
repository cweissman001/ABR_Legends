

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkThreshold : vtkUnstructuredGridAlgorithm {
		public vtkThreshold(IntPtr p) : base(p) {}
		public static implicit operator  vtkThreshold(IntPtr p) {return new vtkThreshold(p);}
		public static implicit operator  IntPtr(vtkThreshold o) {return o.GetPtr();}

// static vtkThreshold* New()
// "static vtkThreshold *New()"
public static vtkThreshold New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkThreshold.New_0(out returnPointer);
//	return (vtkThreshold)(IntPtr)returnPointer;
	return (vtkThreshold)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkThreshold.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkThreshold.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkThreshold* SafeDownCast(vtkObjectBase * o)
// "static vtkThreshold* SafeDownCast(vtkObjectBase *o)"
public static vtkThreshold SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkThreshold.SafeDownCast_0(out returnPointer, o);
//	return (vtkThreshold)(IntPtr)returnPointer;
	return (vtkThreshold)(IntPtr)returnPointer;
}


// vtkThreshold* NewInstance()
// "vtkThreshold *NewInstance()"
public vtkThreshold NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkThreshold.NewInstance_0(out returnPointer, this);
//	return (vtkThreshold)(IntPtr)returnPointer;
	return (vtkThreshold)(IntPtr)returnPointer;
}


// void ThresholdByLower(double lower)
// "void ThresholdByLower(double lower)"
public void ThresholdByLower(double /*(double)*/ lower) {
	VTK_API.API_vtkThreshold.ThresholdByLower_0(this, lower);
}


// void ThresholdByUpper(double upper)
// "void ThresholdByUpper(double upper)"
public void ThresholdByUpper(double /*(double)*/ upper) {
	VTK_API.API_vtkThreshold.ThresholdByUpper_0(this, upper);
}


// void ThresholdBetween(double lower, double upper)
// "void ThresholdBetween(double lower, double upper)"
public void ThresholdBetween(double /*(double)*/ lower, double /*(double)*/ upper) {
	VTK_API.API_vtkThreshold.ThresholdBetween_0(this, lower, upper);
}


// virtual double GetUpperThreshold()
// "virtual double GetUpperThreshold ()"
public double GetUpperThreshold() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkThreshold.GetUpperThreshold_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetLowerThreshold()
// "virtual double GetLowerThreshold ()"
public double GetLowerThreshold() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkThreshold.GetLowerThreshold_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetAttributeMode(int _arg)
// "virtual void SetAttributeMode (int _arg)"
public void SetAttributeMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetAttributeMode_0(this, _arg);
}


// virtual int GetAttributeMode()
// "virtual int GetAttributeMode ()"
public int GetAttributeMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetAttributeMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetAttributeModeToDefault()
// "void SetAttributeModeToDefault()"
public void SetAttributeModeToDefault() {
	VTK_API.API_vtkThreshold.SetAttributeModeToDefault_0(this);
}


// void SetAttributeModeToUsePointData()
// "void SetAttributeModeToUsePointData()"
public void SetAttributeModeToUsePointData() {
	VTK_API.API_vtkThreshold.SetAttributeModeToUsePointData_0(this);
}


// void SetAttributeModeToUseCellData()
// "void SetAttributeModeToUseCellData()"
public void SetAttributeModeToUseCellData() {
	VTK_API.API_vtkThreshold.SetAttributeModeToUseCellData_0(this);
}


// char* GetAttributeModeAsString()
// "const char *GetAttributeModeAsString()"
public string GetAttributeModeAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkThreshold.GetAttributeModeAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetComponentMode(int _arg)
// "virtual void SetComponentMode (int _arg)"
public void SetComponentMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetComponentMode_0(this, _arg);
}


// virtual int GetComponentModeMinValue()
// "virtual int GetComponentModeMinValue ()"
public int GetComponentModeMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetComponentModeMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetComponentModeMaxValue()
// "virtual int GetComponentModeMaxValue ()"
public int GetComponentModeMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetComponentModeMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetComponentMode()
// "virtual int GetComponentMode ()"
public int GetComponentMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetComponentMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetComponentModeToUseSelected()
// "void SetComponentModeToUseSelected()"
public void SetComponentModeToUseSelected() {
	VTK_API.API_vtkThreshold.SetComponentModeToUseSelected_0(this);
}


// void SetComponentModeToUseAll()
// "void SetComponentModeToUseAll()"
public void SetComponentModeToUseAll() {
	VTK_API.API_vtkThreshold.SetComponentModeToUseAll_0(this);
}


// void SetComponentModeToUseAny()
// "void SetComponentModeToUseAny()"
public void SetComponentModeToUseAny() {
	VTK_API.API_vtkThreshold.SetComponentModeToUseAny_0(this);
}


// char* GetComponentModeAsString()
// "const char *GetComponentModeAsString()"
public string GetComponentModeAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkThreshold.GetComponentModeAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetSelectedComponent(int _arg)
// "virtual void SetSelectedComponent (int _arg)"
public void SetSelectedComponent(int /*(int)*/ _arg) {
	VTK_API.API_vtkThreshold.SetSelectedComponent_0(this, _arg);
}


// virtual int GetSelectedComponentMinValue()
// "virtual int GetSelectedComponentMinValue ()"
public int GetSelectedComponentMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetSelectedComponentMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetSelectedComponentMaxValue()
// "virtual int GetSelectedComponentMaxValue ()"
public int GetSelectedComponentMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetSelectedComponentMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetSelectedComponent()
// "virtual int GetSelectedComponent ()"
public int GetSelectedComponent() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetSelectedComponent_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetAllScalars(vtkTypeBool _arg)
// "virtual void SetAllScalars (vtkTypeBool _arg)"
public void SetAllScalars(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkThreshold.SetAllScalars_0(this, _arg);
}


// virtual vtkTypeBool GetAllScalars()
// "virtual vtkTypeBool GetAllScalars ()"
public bool GetAllScalars() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkThreshold.GetAllScalars_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void AllScalarsOn()
// "virtual void AllScalarsOn ()"
public void AllScalarsOn() {
	VTK_API.API_vtkThreshold.AllScalarsOn_0(this);
}


// virtual void AllScalarsOff()
// "virtual void AllScalarsOff ()"
public void AllScalarsOff() {
	VTK_API.API_vtkThreshold.AllScalarsOff_0(this);
}


// virtual void SetUseContinuousCellRange(vtkTypeBool _arg)
// "virtual void SetUseContinuousCellRange (vtkTypeBool _arg)"
public void SetUseContinuousCellRange(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkThreshold.SetUseContinuousCellRange_0(this, _arg);
}


// virtual vtkTypeBool GetUseContinuousCellRange()
// "virtual vtkTypeBool GetUseContinuousCellRange ()"
public bool GetUseContinuousCellRange() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkThreshold.GetUseContinuousCellRange_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseContinuousCellRangeOn()
// "virtual void UseContinuousCellRangeOn ()"
public void UseContinuousCellRangeOn() {
	VTK_API.API_vtkThreshold.UseContinuousCellRangeOn_0(this);
}


// virtual void UseContinuousCellRangeOff()
// "virtual void UseContinuousCellRangeOff ()"
public void UseContinuousCellRangeOff() {
	VTK_API.API_vtkThreshold.UseContinuousCellRangeOff_0(this);
}


// void SetPointsDataTypeToDouble()
// "void SetPointsDataTypeToDouble()"
public void SetPointsDataTypeToDouble() {
	VTK_API.API_vtkThreshold.SetPointsDataTypeToDouble_0(this);
}


// void SetPointsDataTypeToFloat()
// "void SetPointsDataTypeToFloat()"
public void SetPointsDataTypeToFloat() {
	VTK_API.API_vtkThreshold.SetPointsDataTypeToFloat_0(this);
}


// void SetPointsDataType(int type)
// "void SetPointsDataType(int type)"
public void SetPointsDataType(int /*(int)*/ type) {
	VTK_API.API_vtkThreshold.SetPointsDataType_0(this, type);
}


// int GetPointsDataType()
// "int GetPointsDataType()"
public int GetPointsDataType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetPointsDataType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetInvert(bool _arg)
// "virtual void SetInvert (bool _arg)"
public void SetInvert(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkThreshold.SetInvert_0(this, _arg);
}


// virtual bool GetInvert()
// "virtual bool GetInvert ()"
public bool GetInvert() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkThreshold.GetInvert_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void InvertOn()
// "virtual void InvertOn ()"
public void InvertOn() {
	VTK_API.API_vtkThreshold.InvertOn_0(this);
}


// virtual void InvertOff()
// "virtual void InvertOff ()"
public void InvertOff() {
	VTK_API.API_vtkThreshold.InvertOff_0(this);
}


// void SetOutputPointsPrecision(int precision)
// "void SetOutputPointsPrecision(int precision)"
public void SetOutputPointsPrecision(int /*(int)*/ precision) {
	VTK_API.API_vtkThreshold.SetOutputPointsPrecision_0(this, precision);
}


// int GetOutputPointsPrecision()
// "int GetOutputPointsPrecision()"
public int GetOutputPointsPrecision() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkThreshold.GetOutputPointsPrecision_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
