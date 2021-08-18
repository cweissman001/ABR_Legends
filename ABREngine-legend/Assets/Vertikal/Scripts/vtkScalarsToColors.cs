

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkScalarsToColors : vtkObject {
		public vtkScalarsToColors(IntPtr p) : base(p) {}
		public static implicit operator  vtkScalarsToColors(IntPtr p) {return new vtkScalarsToColors(p);}
		public static implicit operator  IntPtr(vtkScalarsToColors o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkScalarsToColors.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkScalarsToColors.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkScalarsToColors* SafeDownCast(vtkObjectBase * o)
// "static vtkScalarsToColors* SafeDownCast(vtkObjectBase *o)"
public static vtkScalarsToColors SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.SafeDownCast_0(out returnPointer, o);
//	return (vtkScalarsToColors)(IntPtr)returnPointer;
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// vtkScalarsToColors* NewInstance()
// "vtkScalarsToColors *NewInstance()"
public vtkScalarsToColors NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.NewInstance_0(out returnPointer, this);
//	return (vtkScalarsToColors)(IntPtr)returnPointer;
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// static vtkScalarsToColors* New()
// "static vtkScalarsToColors *New()"
public static vtkScalarsToColors New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.New_0(out returnPointer);
//	return (vtkScalarsToColors)(IntPtr)returnPointer;
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// virtual int IsOpaque()
// "virtual int IsOpaque()"
public int IsOpaque() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkScalarsToColors.IsOpaque_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void Build()
// "virtual void Build()"
public void Build() {
	VTK_API.API_vtkScalarsToColors.Build_0(this);
}


// virtual double* GetRange()
// "virtual double *GetRange()"
public double[] GetRange() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkScalarsToColors.GetRange_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetRange(double min, double max)
// "virtual void SetRange(double min, double max)"
public void SetRange(double /*(double)*/ min, double /*(double)*/ max) {
	VTK_API.API_vtkScalarsToColors.SetRange_0(this, min, max);
}


// virtual void SetRange(const double rng[2])
// "virtual void SetRange(const double rng[2])"
public void SetRange(double /*(double[2])*/ []rng) {
	VTK_API.API_vtkScalarsToColors.SetRange_1(this, rng);
}


// virtual void GetColor(double v, double rgb[3])
// "virtual void GetColor(double v, double rgb[3])"
public void GetColor(double /*(double)*/ v, double /*(double[3])*/ []rgb) {
	VTK_API.API_vtkScalarsToColors.GetColor_0(this, v, rgb);
}


// double* GetColor(double v)
// "double *GetColor(double v)"
public double[] GetColor(double /*(double)*/ v) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkScalarsToColors.GetColor_1(out returnPointer, this, v);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetOpacity(double v)
// "virtual double GetOpacity(double v)"
public double GetOpacity(double /*(double)*/ v) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkScalarsToColors.GetOpacity_0(out returnPointer, this, v);
//	return (double)returnPointer;
	return returnPointer;
}


// double GetLuminance(double x)
// "double GetLuminance(double x)"
public double GetLuminance(double /*(double)*/ x) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkScalarsToColors.GetLuminance_0(out returnPointer, this, x);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void SetAlpha(double alpha)
// "virtual void SetAlpha(double alpha)"
public void SetAlpha(double /*(double)*/ alpha) {
	VTK_API.API_vtkScalarsToColors.SetAlpha_0(this, alpha);
}


// virtual double GetAlpha()
// "virtual double GetAlpha ()"
public double GetAlpha() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkScalarsToColors.GetAlpha_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(vtkDataArray * scalars, int colorMode, int component)
// "virtual vtkUnsignedCharArray *MapScalars(vtkDataArray *scalars, int colorMode, int component)"
public vtkUnsignedCharArray MapScalars(vtkDataArray /*(vtkDataArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.MapScalars_0(out returnPointer, this, scalars, colorMode, component);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(vtkAbstractArray * scalars, int colorMode, int component)
// "virtual vtkUnsignedCharArray *MapScalars(vtkAbstractArray *scalars, int colorMode, int component)"
public vtkUnsignedCharArray MapScalars(vtkAbstractArray /*(vtkAbstractArray*)*/ scalars, int /*(int)*/ colorMode, int /*(int)*/ component) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.MapScalars_1(out returnPointer, this, scalars, colorMode, component);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual void SetVectorMode(int _arg)
// "virtual void SetVectorMode (int _arg)"
public void SetVectorMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetVectorMode_0(this, _arg);
}


// virtual int GetVectorMode()
// "virtual int GetVectorMode ()"
public int GetVectorMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkScalarsToColors.GetVectorMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetVectorModeToMagnitude()
// "void SetVectorModeToMagnitude()"
public void SetVectorModeToMagnitude() {
	VTK_API.API_vtkScalarsToColors.SetVectorModeToMagnitude_0(this);
}


// void SetVectorModeToComponent()
// "void SetVectorModeToComponent()"
public void SetVectorModeToComponent() {
	VTK_API.API_vtkScalarsToColors.SetVectorModeToComponent_0(this);
}


// void SetVectorModeToRGBColors()
// "void SetVectorModeToRGBColors()"
public void SetVectorModeToRGBColors() {
	VTK_API.API_vtkScalarsToColors.SetVectorModeToRGBColors_0(this);
}


// virtual void SetVectorComponent(int _arg)
// "virtual void SetVectorComponent (int _arg)"
public void SetVectorComponent(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetVectorComponent_0(this, _arg);
}


// virtual int GetVectorComponent()
// "virtual int GetVectorComponent ()"
public int GetVectorComponent() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkScalarsToColors.GetVectorComponent_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetVectorSize(int _arg)
// "virtual void SetVectorSize (int _arg)"
public void SetVectorSize(int /*(int)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetVectorSize_0(this, _arg);
}


// virtual int GetVectorSize()
// "virtual int GetVectorSize ()"
public int GetVectorSize() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkScalarsToColors.GetVectorSize_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
// "void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)"
public void MapVectorsThroughTable(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat, int /*(int)*/ vectorComponent, int /*(int)*/ vectorSize) {
	VTK_API.API_vtkScalarsToColors.MapVectorsThroughTable_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat, vectorComponent, vectorSize);
}


// void MapVectorsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "void MapVectorsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public void MapVectorsThroughTable(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapVectorsThroughTable_1(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output, int outputFormat)
// "void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output, int outputFormat)"
public void MapScalarsThroughTable(vtkDataArray /*(vtkDataArray*)*/ scalars, string /*(unsigned char*)*/ output, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable_0(this, scalars, output, outputFormat);
}


// void MapScalarsThroughTable(vtkDataArray * scalars, unsigned char * output)
// "void MapScalarsThroughTable(vtkDataArray *scalars, unsigned char *output)"
public void MapScalarsThroughTable(vtkDataArray /*(vtkDataArray*)*/ scalars, string /*(unsigned char*)*/ output) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable_1(this, scalars, output);
}


// void MapScalarsThroughTable(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "void MapScalarsThroughTable(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public void MapScalarsThroughTable(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable_2(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// virtual void MapScalarsThroughTable2(void * input, unsigned char * output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
// "virtual void MapScalarsThroughTable2(void *input, unsigned char *output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)"
public void MapScalarsThroughTable2(IntPtr /*(void*)*/ input, string /*(unsigned char*)*/ output, int /*(int)*/ inputDataType, int /*(int)*/ numberOfValues, int /*(int)*/ inputIncrement, int /*(int)*/ outputFormat) {
	VTK_API.API_vtkScalarsToColors.MapScalarsThroughTable2_0(this, input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
}


// virtual void DeepCopy(vtkScalarsToColors * o)
// "virtual void DeepCopy(vtkScalarsToColors *o)"
public void DeepCopy(vtkScalarsToColors /*(vtkScalarsToColors*)*/ o) {
	VTK_API.API_vtkScalarsToColors.DeepCopy_0(this, o);
}


// virtual int UsingLogScale()
// "virtual int UsingLogScale()"
public int UsingLogScale() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkScalarsToColors.UsingLogScale_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfAvailableColors()
// "virtual vtkIdType GetNumberOfAvailableColors()"
public long GetNumberOfAvailableColors() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkScalarsToColors.GetNumberOfAvailableColors_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetAnnotations(vtkAbstractArray * values, vtkStringArray * annotations)
// "virtual void SetAnnotations( vtkAbstractArray* values, vtkStringArray* annotations )"
public void SetAnnotations(vtkAbstractArray /*(vtkAbstractArray*)*/ values, vtkStringArray /*(vtkStringArray*)*/ annotations) {
	VTK_API.API_vtkScalarsToColors.SetAnnotations_0(this, values, annotations);
}


// virtual vtkAbstractArray* GetAnnotatedValues()
// "virtual vtkAbstractArray *GetAnnotatedValues ()"
public vtkAbstractArray GetAnnotatedValues() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.GetAnnotatedValues_0(out returnPointer, this);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual vtkStringArray* GetAnnotations()
// "virtual vtkStringArray *GetAnnotations ()"
public vtkStringArray GetAnnotations() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkScalarsToColors.GetAnnotations_0(out returnPointer, this);
//	return (vtkStringArray)(IntPtr)returnPointer;
	return (vtkStringArray)(IntPtr)returnPointer;
}


// virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)
// "virtual vtkIdType SetAnnotation(vtkStdString value, vtkStdString annotation)"
public long SetAnnotation(string /*(vtkStdString)*/ value, string /*(vtkStdString)*/ annotation) {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkScalarsToColors.SetAnnotation_0(out returnPointer, this, value, annotation);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfAnnotatedValues()
// "vtkIdType GetNumberOfAnnotatedValues()"
public long GetNumberOfAnnotatedValues() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkScalarsToColors.GetNumberOfAnnotatedValues_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkStdString GetAnnotation(vtkIdType idx)
// "vtkStdString GetAnnotation(vtkIdType idx)"
public string GetAnnotation(long /*(vtkIdType)*/ idx) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkScalarsToColors.GetAnnotation_0(out returnPointer, this, idx);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void GetIndexedColor(vtkIdType i, double rgba[4])
// "virtual void GetIndexedColor(vtkIdType i, double rgba[4])"
public void GetIndexedColor(long /*(vtkIdType)*/ i, double /*(double[4])*/ []rgba) {
	VTK_API.API_vtkScalarsToColors.GetIndexedColor_0(this, i, rgba);
}


// virtual void ResetAnnotations()
// "virtual void ResetAnnotations()"
public void ResetAnnotations() {
	VTK_API.API_vtkScalarsToColors.ResetAnnotations_0(this);
}


// virtual void SetIndexedLookup(vtkTypeBool _arg)
// "virtual void SetIndexedLookup (vtkTypeBool _arg)"
public void SetIndexedLookup(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkScalarsToColors.SetIndexedLookup_0(this, _arg);
}


// virtual vtkTypeBool GetIndexedLookup()
// "virtual vtkTypeBool GetIndexedLookup ()"
public bool GetIndexedLookup() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkScalarsToColors.GetIndexedLookup_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void IndexedLookupOn()
// "virtual void IndexedLookupOn ()"
public void IndexedLookupOn() {
	VTK_API.API_vtkScalarsToColors.IndexedLookupOn_0(this);
}


// virtual void IndexedLookupOff()
// "virtual void IndexedLookupOff ()"
public void IndexedLookupOff() {
	VTK_API.API_vtkScalarsToColors.IndexedLookupOff_0(this);
}


}
};
