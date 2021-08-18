

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkMapper : vtkAbstractMapper3D {
		public vtkMapper(IntPtr p) : base(p) {}
		public static implicit operator  vtkMapper(IntPtr p) {return new vtkMapper(p);}
		public static implicit operator  IntPtr(vtkMapper o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkMapper* SafeDownCast(vtkObjectBase * o)
// "static vtkMapper* SafeDownCast(vtkObjectBase *o)"
public static vtkMapper SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.SafeDownCast_0(out returnPointer, o);
//	return (vtkMapper)(IntPtr)returnPointer;
	return (vtkMapper)(IntPtr)returnPointer;
}


// vtkMapper* NewInstance()
// "vtkMapper *NewInstance()"
public vtkMapper NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.NewInstance_0(out returnPointer, this);
//	return (vtkMapper)(IntPtr)returnPointer;
	return (vtkMapper)(IntPtr)returnPointer;
}


// void ShallowCopy(vtkAbstractMapper * m)
// "void ShallowCopy(vtkAbstractMapper *m)"
public void ShallowCopy(vtkAbstractMapper /*(vtkAbstractMapper*)*/ m) {
	VTK_API.API_vtkMapper.ShallowCopy_0(this, m);
}


// vtkMTimeType GetMTime()
// "vtkMTimeType GetMTime()"
public ulong GetMTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkMapper.GetMTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void Render(vtkRenderer * ren, vtkActor * a)
// "virtual void Render(vtkRenderer *ren, vtkActor *a)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ren, vtkActor /*(vtkActor*)*/ a) {
	VTK_API.API_vtkMapper.Render_0(this, ren, a);
}


// void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "void ReleaseGraphicsResources(vtkWindow *)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkMapper.ReleaseGraphicsResources_0(this, ARG_0);
}


// void SetLookupTable(vtkScalarsToColors * lut)
// "void SetLookupTable(vtkScalarsToColors *lut)"
public void SetLookupTable(vtkScalarsToColors /*(vtkScalarsToColors*)*/ lut) {
	VTK_API.API_vtkMapper.SetLookupTable_0(this, lut);
}


// vtkScalarsToColors* GetLookupTable()
// "vtkScalarsToColors *GetLookupTable()"
public vtkScalarsToColors GetLookupTable() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.GetLookupTable_0(out returnPointer, this);
//	return (vtkScalarsToColors)(IntPtr)returnPointer;
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// virtual void CreateDefaultLookupTable()
// "virtual void CreateDefaultLookupTable()"
public void CreateDefaultLookupTable() {
	VTK_API.API_vtkMapper.CreateDefaultLookupTable_0(this);
}


// virtual void SetScalarVisibility(vtkTypeBool _arg)
// "virtual void SetScalarVisibility (vtkTypeBool _arg)"
public void SetScalarVisibility(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkMapper.SetScalarVisibility_0(this, _arg);
}


// virtual vtkTypeBool GetScalarVisibility()
// "virtual vtkTypeBool GetScalarVisibility ()"
public bool GetScalarVisibility() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.GetScalarVisibility_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ScalarVisibilityOn()
// "virtual void ScalarVisibilityOn ()"
public void ScalarVisibilityOn() {
	VTK_API.API_vtkMapper.ScalarVisibilityOn_0(this);
}


// virtual void ScalarVisibilityOff()
// "virtual void ScalarVisibilityOff ()"
public void ScalarVisibilityOff() {
	VTK_API.API_vtkMapper.ScalarVisibilityOff_0(this);
}


// virtual void SetStatic(vtkTypeBool _arg)
// "virtual void SetStatic (vtkTypeBool _arg)"
public void SetStatic(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkMapper.SetStatic_0(this, _arg);
}


// virtual vtkTypeBool GetStatic()
// "virtual vtkTypeBool GetStatic ()"
public bool GetStatic() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.GetStatic_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void StaticOn()
// "virtual void StaticOn ()"
public void StaticOn() {
	VTK_API.API_vtkMapper.StaticOn_0(this);
}


// virtual void StaticOff()
// "virtual void StaticOff ()"
public void StaticOff() {
	VTK_API.API_vtkMapper.StaticOff_0(this);
}


// virtual void SetColorMode(int _arg)
// "virtual void SetColorMode (int _arg)"
public void SetColorMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkMapper.SetColorMode_0(this, _arg);
}


// virtual int GetColorMode()
// "virtual int GetColorMode ()"
public int GetColorMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetColorMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetColorModeToDefault()
// "void SetColorModeToDefault()"
public void SetColorModeToDefault() {
	VTK_API.API_vtkMapper.SetColorModeToDefault_0(this);
}


// void SetColorModeToMapScalars()
// "void SetColorModeToMapScalars()"
public void SetColorModeToMapScalars() {
	VTK_API.API_vtkMapper.SetColorModeToMapScalars_0(this);
}


// void SetColorModeToDirectScalars()
// "void SetColorModeToDirectScalars()"
public void SetColorModeToDirectScalars() {
	VTK_API.API_vtkMapper.SetColorModeToDirectScalars_0(this);
}


// char* GetColorModeAsString()
// "const char *GetColorModeAsString()"
public string GetColorModeAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkMapper.GetColorModeAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetInterpolateScalarsBeforeMapping(vtkTypeBool _arg)
// "virtual void SetInterpolateScalarsBeforeMapping (vtkTypeBool _arg)"
public void SetInterpolateScalarsBeforeMapping(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkMapper.SetInterpolateScalarsBeforeMapping_0(this, _arg);
}


// virtual vtkTypeBool GetInterpolateScalarsBeforeMapping()
// "virtual vtkTypeBool GetInterpolateScalarsBeforeMapping ()"
public bool GetInterpolateScalarsBeforeMapping() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.GetInterpolateScalarsBeforeMapping_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void InterpolateScalarsBeforeMappingOn()
// "virtual void InterpolateScalarsBeforeMappingOn ()"
public void InterpolateScalarsBeforeMappingOn() {
	VTK_API.API_vtkMapper.InterpolateScalarsBeforeMappingOn_0(this);
}


// virtual void InterpolateScalarsBeforeMappingOff()
// "virtual void InterpolateScalarsBeforeMappingOff ()"
public void InterpolateScalarsBeforeMappingOff() {
	VTK_API.API_vtkMapper.InterpolateScalarsBeforeMappingOff_0(this);
}


// virtual void SetUseLookupTableScalarRange(vtkTypeBool _arg)
// "virtual void SetUseLookupTableScalarRange (vtkTypeBool _arg)"
public void SetUseLookupTableScalarRange(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkMapper.SetUseLookupTableScalarRange_0(this, _arg);
}


// virtual vtkTypeBool GetUseLookupTableScalarRange()
// "virtual vtkTypeBool GetUseLookupTableScalarRange ()"
public bool GetUseLookupTableScalarRange() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.GetUseLookupTableScalarRange_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void UseLookupTableScalarRangeOn()
// "virtual void UseLookupTableScalarRangeOn ()"
public void UseLookupTableScalarRangeOn() {
	VTK_API.API_vtkMapper.UseLookupTableScalarRangeOn_0(this);
}


// virtual void UseLookupTableScalarRangeOff()
// "virtual void UseLookupTableScalarRangeOff ()"
public void UseLookupTableScalarRangeOff() {
	VTK_API.API_vtkMapper.UseLookupTableScalarRangeOff_0(this);
}


// virtual void SetScalarRange(double _arg1, double _arg2)
// "virtual void SetScalarRange (double _arg1, double _arg2)"
public void SetScalarRange(double /*(double)*/ _arg1, double /*(double)*/ _arg2) {
	VTK_API.API_vtkMapper.SetScalarRange_0(this, _arg1, _arg2);
}


// void SetScalarRange(double _arg[2])
// "void SetScalarRange (double _arg[2])"
public void SetScalarRange(double /*(double[2])*/ []_arg) {
	VTK_API.API_vtkMapper.SetScalarRange_1(this, _arg);
}


// virtual double* GetScalarRange()
// "virtual double *GetScalarRange ()"
public double[] GetScalarRange() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkMapper.GetScalarRange_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetScalarRange(double data[2])
// "virtual void GetScalarRange (double data[2])"
public void GetScalarRange(double /*(double[2])*/ []data) {
	VTK_API.API_vtkMapper.GetScalarRange_1(this, data);
}


// virtual void SetScalarMode(int _arg)
// "virtual void SetScalarMode (int _arg)"
public void SetScalarMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkMapper.SetScalarMode_0(this, _arg);
}


// virtual int GetScalarMode()
// "virtual int GetScalarMode ()"
public int GetScalarMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetScalarMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetScalarModeToDefault()
// "void SetScalarModeToDefault()"
public void SetScalarModeToDefault() {
	VTK_API.API_vtkMapper.SetScalarModeToDefault_0(this);
}


// void SetScalarModeToUsePointData()
// "void SetScalarModeToUsePointData()"
public void SetScalarModeToUsePointData() {
	VTK_API.API_vtkMapper.SetScalarModeToUsePointData_0(this);
}


// void SetScalarModeToUseCellData()
// "void SetScalarModeToUseCellData()"
public void SetScalarModeToUseCellData() {
	VTK_API.API_vtkMapper.SetScalarModeToUseCellData_0(this);
}


// void SetScalarModeToUsePointFieldData()
// "void SetScalarModeToUsePointFieldData()"
public void SetScalarModeToUsePointFieldData() {
	VTK_API.API_vtkMapper.SetScalarModeToUsePointFieldData_0(this);
}


// void SetScalarModeToUseCellFieldData()
// "void SetScalarModeToUseCellFieldData()"
public void SetScalarModeToUseCellFieldData() {
	VTK_API.API_vtkMapper.SetScalarModeToUseCellFieldData_0(this);
}


// void SetScalarModeToUseFieldData()
// "void SetScalarModeToUseFieldData()"
public void SetScalarModeToUseFieldData() {
	VTK_API.API_vtkMapper.SetScalarModeToUseFieldData_0(this);
}


// void SelectColorArray(int arrayNum)
// "void SelectColorArray(int arrayNum)"
public void SelectColorArray(int /*(int)*/ arrayNum) {
	VTK_API.API_vtkMapper.SelectColorArray_0(this, arrayNum);
}


// void SelectColorArray(const char * arrayName)
// "void SelectColorArray(const char* arrayName)"
public void SelectColorArray(string /*(char*)*/ arrayName) {
	VTK_API.API_vtkMapper.SelectColorArray_1(this, arrayName);
}


// virtual void SetFieldDataTupleId(vtkIdType _arg)
// "virtual void SetFieldDataTupleId (vtkIdType _arg)"
public void SetFieldDataTupleId(long /*(vtkIdType)*/ _arg) {
	VTK_API.API_vtkMapper.SetFieldDataTupleId_0(this, _arg);
}


// virtual vtkIdType GetFieldDataTupleId()
// "virtual vtkIdType GetFieldDataTupleId ()"
public long GetFieldDataTupleId() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkMapper.GetFieldDataTupleId_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void ColorByArrayComponent(int arrayNum, int component)
// "void ColorByArrayComponent(int arrayNum, int component)"
public void ColorByArrayComponent(int /*(int)*/ arrayNum, int /*(int)*/ component) {
	VTK_API.API_vtkMapper.ColorByArrayComponent_0(this, arrayNum, component);
}


// void ColorByArrayComponent(const char * arrayName, int component)
// "void ColorByArrayComponent(const char* arrayName, int component)"
public void ColorByArrayComponent(string /*(char*)*/ arrayName, int /*(int)*/ component) {
	VTK_API.API_vtkMapper.ColorByArrayComponent_1(this, arrayName, component);
}


// virtual char* GetArrayName()
// "virtual char* GetArrayName ()"
public string GetArrayName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkMapper.GetArrayName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetArrayName(const char * _arg)
// "virtual void SetArrayName (const char* _arg)"
public void SetArrayName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkMapper.SetArrayName_0(this, _arg);
}


// virtual int GetArrayId()
// "virtual int GetArrayId ()"
public int GetArrayId() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetArrayId_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetArrayId(int _arg)
// "virtual void SetArrayId (int _arg)"
public void SetArrayId(int /*(int)*/ _arg) {
	VTK_API.API_vtkMapper.SetArrayId_0(this, _arg);
}


// virtual int GetArrayAccessMode()
// "virtual int GetArrayAccessMode ()"
public int GetArrayAccessMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetArrayAccessMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetArrayAccessMode(int _arg)
// "virtual void SetArrayAccessMode (int _arg)"
public void SetArrayAccessMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkMapper.SetArrayAccessMode_0(this, _arg);
}


// virtual int GetArrayComponent()
// "virtual int GetArrayComponent ()"
public int GetArrayComponent() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetArrayComponent_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetArrayComponent(int _arg)
// "virtual void SetArrayComponent (int _arg)"
public void SetArrayComponent(int /*(int)*/ _arg) {
	VTK_API.API_vtkMapper.SetArrayComponent_0(this, _arg);
}


// char* GetScalarModeAsString()
// "const char *GetScalarModeAsString()"
public string GetScalarModeAsString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkMapper.GetScalarModeAsString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// static void SetResolveCoincidentTopology(int val)
// "static void SetResolveCoincidentTopology(int val)"
public static void SetResolveCoincidentTopology(int /*(int)*/ val) {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopology_0(val);
}


// static int GetResolveCoincidentTopology()
// "static int GetResolveCoincidentTopology()"
public static int GetResolveCoincidentTopology() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetResolveCoincidentTopology_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// static void SetResolveCoincidentTopologyToDefault()
// "static void SetResolveCoincidentTopologyToDefault()"
public static void SetResolveCoincidentTopologyToDefault() {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyToDefault_0();
}


// static void SetResolveCoincidentTopologyToOff()
// "static void SetResolveCoincidentTopologyToOff()"
public static void SetResolveCoincidentTopologyToOff() {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyToOff_0();
}


// static void SetResolveCoincidentTopologyToPolygonOffset()
// "static void SetResolveCoincidentTopologyToPolygonOffset()"
public static void SetResolveCoincidentTopologyToPolygonOffset() {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyToPolygonOffset_0();
}


// static void SetResolveCoincidentTopologyToShiftZBuffer()
// "static void SetResolveCoincidentTopologyToShiftZBuffer()"
public static void SetResolveCoincidentTopologyToShiftZBuffer() {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyToShiftZBuffer_0();
}


// static void SetResolveCoincidentTopologyPolygonOffsetParameters(double factor, double units)
// "static void SetResolveCoincidentTopologyPolygonOffsetParameters( double factor, double units)"
public static void SetResolveCoincidentTopologyPolygonOffsetParameters(double /*(double)*/ factor, double /*(double)*/ units) {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyPolygonOffsetParameters_0(factor, units);
}


// static void GetResolveCoincidentTopologyPolygonOffsetParameters(double & factor, double & units)
// "static void GetResolveCoincidentTopologyPolygonOffsetParameters( double& factor, double& units)"
public static void GetResolveCoincidentTopologyPolygonOffsetParameters(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetResolveCoincidentTopologyPolygonOffsetParameters_0(factor, units);
}


// void SetRelativeCoincidentTopologyPolygonOffsetParameters(double factor, double units)
// "void SetRelativeCoincidentTopologyPolygonOffsetParameters( double factor, double units)"
public void SetRelativeCoincidentTopologyPolygonOffsetParameters(double /*(double)*/ factor, double /*(double)*/ units) {
	VTK_API.API_vtkMapper.SetRelativeCoincidentTopologyPolygonOffsetParameters_0(this, factor, units);
}


// void GetRelativeCoincidentTopologyPolygonOffsetParameters(double & factor, double & units)
// "void GetRelativeCoincidentTopologyPolygonOffsetParameters( double& factor, double& units)"
public void GetRelativeCoincidentTopologyPolygonOffsetParameters(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetRelativeCoincidentTopologyPolygonOffsetParameters_0(this, factor, units);
}


// static void SetResolveCoincidentTopologyLineOffsetParameters(double factor, double units)
// "static void SetResolveCoincidentTopologyLineOffsetParameters( double factor, double units)"
public static void SetResolveCoincidentTopologyLineOffsetParameters(double /*(double)*/ factor, double /*(double)*/ units) {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyLineOffsetParameters_0(factor, units);
}


// static void GetResolveCoincidentTopologyLineOffsetParameters(double & factor, double & units)
// "static void GetResolveCoincidentTopologyLineOffsetParameters( double& factor, double& units)"
public static void GetResolveCoincidentTopologyLineOffsetParameters(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetResolveCoincidentTopologyLineOffsetParameters_0(factor, units);
}


// void SetRelativeCoincidentTopologyLineOffsetParameters(double factor, double units)
// "void SetRelativeCoincidentTopologyLineOffsetParameters( double factor, double units)"
public void SetRelativeCoincidentTopologyLineOffsetParameters(double /*(double)*/ factor, double /*(double)*/ units) {
	VTK_API.API_vtkMapper.SetRelativeCoincidentTopologyLineOffsetParameters_0(this, factor, units);
}


// void GetRelativeCoincidentTopologyLineOffsetParameters(double & factor, double & units)
// "void GetRelativeCoincidentTopologyLineOffsetParameters( double& factor, double& units)"
public void GetRelativeCoincidentTopologyLineOffsetParameters(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetRelativeCoincidentTopologyLineOffsetParameters_0(this, factor, units);
}


// static void SetResolveCoincidentTopologyPointOffsetParameter(double units)
// "static void SetResolveCoincidentTopologyPointOffsetParameter( double units)"
public static void SetResolveCoincidentTopologyPointOffsetParameter(double /*(double)*/ units) {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyPointOffsetParameter_0(units);
}


// static void GetResolveCoincidentTopologyPointOffsetParameter(double & units)
// "static void GetResolveCoincidentTopologyPointOffsetParameter( double& units)"
public static void GetResolveCoincidentTopologyPointOffsetParameter(IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetResolveCoincidentTopologyPointOffsetParameter_0(units);
}


// void SetRelativeCoincidentTopologyPointOffsetParameter(double units)
// "void SetRelativeCoincidentTopologyPointOffsetParameter(double units)"
public void SetRelativeCoincidentTopologyPointOffsetParameter(double /*(double)*/ units) {
	VTK_API.API_vtkMapper.SetRelativeCoincidentTopologyPointOffsetParameter_0(this, units);
}


// void GetRelativeCoincidentTopologyPointOffsetParameter(double & units)
// "void GetRelativeCoincidentTopologyPointOffsetParameter(double& units)"
public void GetRelativeCoincidentTopologyPointOffsetParameter(IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetRelativeCoincidentTopologyPointOffsetParameter_0(this, units);
}


// void GetCoincidentTopologyPolygonOffsetParameters(double & factor, double & units)
// "void GetCoincidentTopologyPolygonOffsetParameters( double& factor, double& units)"
public void GetCoincidentTopologyPolygonOffsetParameters(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetCoincidentTopologyPolygonOffsetParameters_0(this, factor, units);
}


// void GetCoincidentTopologyLineOffsetParameters(double & factor, double & units)
// "void GetCoincidentTopologyLineOffsetParameters( double& factor, double& units)"
public void GetCoincidentTopologyLineOffsetParameters(IntPtr /*(double&)*/ factor, IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetCoincidentTopologyLineOffsetParameters_0(this, factor, units);
}


// void GetCoincidentTopologyPointOffsetParameter(double & units)
// "void GetCoincidentTopologyPointOffsetParameter(double& units)"
public void GetCoincidentTopologyPointOffsetParameter(IntPtr /*(double&)*/ units) {
	VTK_API.API_vtkMapper.GetCoincidentTopologyPointOffsetParameter_0(this, units);
}


// static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)
// "static void SetResolveCoincidentTopologyPolygonOffsetFaces(int faces)"
public static void SetResolveCoincidentTopologyPolygonOffsetFaces(int /*(int)*/ faces) {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyPolygonOffsetFaces_0(faces);
}


// static int GetResolveCoincidentTopologyPolygonOffsetFaces()
// "static int GetResolveCoincidentTopologyPolygonOffsetFaces()"
public static int GetResolveCoincidentTopologyPolygonOffsetFaces() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.GetResolveCoincidentTopologyPolygonOffsetFaces_0(out returnPointer);
//	return (int)returnPointer;
	return returnPointer;
}


// static void SetResolveCoincidentTopologyZShift(double val)
// "static void SetResolveCoincidentTopologyZShift(double val)"
public static void SetResolveCoincidentTopologyZShift(double /*(double)*/ val) {
	VTK_API.API_vtkMapper.SetResolveCoincidentTopologyZShift_0(val);
}


// static double GetResolveCoincidentTopologyZShift()
// "static double GetResolveCoincidentTopologyZShift()"
public static double GetResolveCoincidentTopologyZShift() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMapper.GetResolveCoincidentTopologyZShift_0(out returnPointer);
//	return (double)returnPointer;
	return returnPointer;
}


// double* GetBounds()
// "double *GetBounds()"
public double[] GetBounds() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkMapper.GetBounds_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// void GetBounds(double bounds[6])
// "void GetBounds(double bounds[6])"
public void GetBounds(double /*(double[6])*/ []bounds) {
	VTK_API.API_vtkMapper.GetBounds_1(this, bounds);
}


// void SetRenderTime(double time)
// "void SetRenderTime(double time)"
public void SetRenderTime(double /*(double)*/ time) {
	VTK_API.API_vtkMapper.SetRenderTime_0(this, time);
}


// virtual double GetRenderTime()
// "virtual double GetRenderTime ()"
public double GetRenderTime() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkMapper.GetRenderTime_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// vtkDataSet* GetInput()
// "vtkDataSet *GetInput()"
public vtkDataSet GetInput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.GetInput_0(out returnPointer, this);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// vtkDataSet* GetInputAsDataSet()
// "vtkDataSet *GetInputAsDataSet()"
public vtkDataSet GetInputAsDataSet() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.GetInputAsDataSet_0(out returnPointer, this);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(double alpha)
// "virtual vtkUnsignedCharArray *MapScalars(double alpha)"
public vtkUnsignedCharArray MapScalars(double /*(double)*/ alpha) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.MapScalars_0(out returnPointer, this, alpha);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(double alpha, int & cellFlag)
// "virtual vtkUnsignedCharArray *MapScalars(double alpha, int &cellFlag)"
public vtkUnsignedCharArray MapScalars(double /*(double)*/ alpha, IntPtr /*(int&)*/ cellFlag) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.MapScalars_1(out returnPointer, this, alpha, cellFlag);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(vtkDataSet * input, double alpha)
// "virtual vtkUnsignedCharArray *MapScalars(vtkDataSet *input, double alpha)"
public vtkUnsignedCharArray MapScalars(vtkDataSet /*(vtkDataSet*)*/ input, double /*(double)*/ alpha) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.MapScalars_2(out returnPointer, this, input, alpha);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* MapScalars(vtkDataSet * input, double alpha, int & cellFlag)
// "virtual vtkUnsignedCharArray *MapScalars(vtkDataSet *input, double alpha, int &cellFlag)"
public vtkUnsignedCharArray MapScalars(vtkDataSet /*(vtkDataSet*)*/ input, double /*(double)*/ alpha, IntPtr /*(int&)*/ cellFlag) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.MapScalars_3(out returnPointer, this, input, alpha, cellFlag);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual bool GetIsOpaque()
// "virtual bool GetIsOpaque()"
public bool GetIsOpaque() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.GetIsOpaque_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual bool GetSupportsSelection()
// "virtual bool GetSupportsSelection()"
public bool GetSupportsSelection() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkMapper.GetSupportsSelection_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual int CanUseTextureMapForColoring(vtkDataObject * input)
// "virtual int CanUseTextureMapForColoring(vtkDataObject* input)"
public int CanUseTextureMapForColoring(vtkDataObject /*(vtkDataObject*)*/ input) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkMapper.CanUseTextureMapForColoring_0(out returnPointer, this, input);
//	return (int)returnPointer;
	return returnPointer;
}


// void ClearColorArrays()
// "void ClearColorArrays()"
public void ClearColorArrays() {
	VTK_API.API_vtkMapper.ClearColorArrays_0(this);
}


// vtkUnsignedCharArray* GetColorMapColors()
// "vtkUnsignedCharArray *GetColorMapColors()"
public vtkUnsignedCharArray GetColorMapColors() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.GetColorMapColors_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkFloatArray* GetColorCoordinates()
// "vtkFloatArray *GetColorCoordinates()"
public vtkFloatArray GetColorCoordinates() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.GetColorCoordinates_0(out returnPointer, this);
//	return (vtkFloatArray)(IntPtr)returnPointer;
	return (vtkFloatArray)(IntPtr)returnPointer;
}


// vtkImageData* GetColorTextureMap()
// "vtkImageData* GetColorTextureMap()"
public vtkImageData GetColorTextureMap() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkMapper.GetColorTextureMap_0(out returnPointer, this);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


}
};
