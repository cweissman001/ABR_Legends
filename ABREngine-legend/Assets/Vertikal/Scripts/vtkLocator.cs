

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkLocator : vtkObject {
		public vtkLocator(IntPtr p) : base(p) {}
		public static implicit operator  vtkLocator(IntPtr p) {return new vtkLocator(p);}
		public static implicit operator  IntPtr(vtkLocator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkLocator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkLocator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkLocator* SafeDownCast(vtkObjectBase * o)
// "static vtkLocator* SafeDownCast(vtkObjectBase *o)"
public static vtkLocator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLocator.SafeDownCast_0(out returnPointer, o);
//	return (vtkLocator)(IntPtr)returnPointer;
	return (vtkLocator)(IntPtr)returnPointer;
}


// vtkLocator* NewInstance()
// "vtkLocator *NewInstance()"
public vtkLocator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLocator.NewInstance_0(out returnPointer, this);
//	return (vtkLocator)(IntPtr)returnPointer;
	return (vtkLocator)(IntPtr)returnPointer;
}


// virtual void SetDataSet(vtkDataSet * ARG_0)
// "virtual void SetDataSet(vtkDataSet*)"
public void SetDataSet(vtkDataSet /*(vtkDataSet*)*/ ARG_0) {
	VTK_API.API_vtkLocator.SetDataSet_0(this, ARG_0);
}


// virtual vtkDataSet* GetDataSet()
// "virtual vtkDataSet *GetDataSet ()"
public vtkDataSet GetDataSet() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkLocator.GetDataSet_0(out returnPointer, this);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// virtual void SetMaxLevel(int _arg)
// "virtual void SetMaxLevel (int _arg)"
public void SetMaxLevel(int /*(int)*/ _arg) {
	VTK_API.API_vtkLocator.SetMaxLevel_0(this, _arg);
}


// virtual int GetMaxLevelMinValue()
// "virtual int GetMaxLevelMinValue ()"
public int GetMaxLevelMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkLocator.GetMaxLevelMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetMaxLevelMaxValue()
// "virtual int GetMaxLevelMaxValue ()"
public int GetMaxLevelMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkLocator.GetMaxLevelMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetMaxLevel()
// "virtual int GetMaxLevel ()"
public int GetMaxLevel() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkLocator.GetMaxLevel_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetLevel()
// "virtual int GetLevel ()"
public int GetLevel() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkLocator.GetLevel_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetAutomatic(vtkTypeBool _arg)
// "virtual void SetAutomatic (vtkTypeBool _arg)"
public void SetAutomatic(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkLocator.SetAutomatic_0(this, _arg);
}


// virtual vtkTypeBool GetAutomatic()
// "virtual vtkTypeBool GetAutomatic ()"
public bool GetAutomatic() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkLocator.GetAutomatic_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void AutomaticOn()
// "virtual void AutomaticOn ()"
public void AutomaticOn() {
	VTK_API.API_vtkLocator.AutomaticOn_0(this);
}


// virtual void AutomaticOff()
// "virtual void AutomaticOff ()"
public void AutomaticOff() {
	VTK_API.API_vtkLocator.AutomaticOff_0(this);
}


// virtual void SetTolerance(double _arg)
// "virtual void SetTolerance (double _arg)"
public void SetTolerance(double /*(double)*/ _arg) {
	VTK_API.API_vtkLocator.SetTolerance_0(this, _arg);
}


// virtual double GetToleranceMinValue()
// "virtual double GetToleranceMinValue ()"
public double GetToleranceMinValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkLocator.GetToleranceMinValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetToleranceMaxValue()
// "virtual double GetToleranceMaxValue ()"
public double GetToleranceMaxValue() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkLocator.GetToleranceMaxValue_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual double GetTolerance()
// "virtual double GetTolerance ()"
public double GetTolerance() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkLocator.GetTolerance_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void Update()
// "virtual void Update()"
public void Update() {
	VTK_API.API_vtkLocator.Update_0(this);
}


// virtual void Initialize()
// "virtual void Initialize()"
public void Initialize() {
	VTK_API.API_vtkLocator.Initialize_0(this);
}


// virtual void BuildLocator()
// "virtual void BuildLocator()"
public void BuildLocator() {
	VTK_API.API_vtkLocator.BuildLocator_0(this);
}


// virtual void FreeSearchStructure()
// "virtual void FreeSearchStructure()"
public void FreeSearchStructure() {
	VTK_API.API_vtkLocator.FreeSearchStructure_0(this);
}


// virtual void GenerateRepresentation(int level, vtkPolyData * pd)
// "virtual void GenerateRepresentation(int level, vtkPolyData *pd)"
public void GenerateRepresentation(int /*(int)*/ level, vtkPolyData /*(vtkPolyData*)*/ pd) {
	VTK_API.API_vtkLocator.GenerateRepresentation_0(this, level, pd);
}


// virtual vtkMTimeType GetBuildTime()
// "virtual vtkMTimeType GetBuildTime ()"
public ulong GetBuildTime() {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkLocator.GetBuildTime_0(out returnPointer, this);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void Register(vtkObjectBase * o)
// "void Register(vtkObjectBase *o)"
public void Register(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkLocator.Register_0(this, o);
}


// void UnRegister(vtkObjectBase * o)
// "void UnRegister(vtkObjectBase *o)"
public void UnRegister(vtkObjectBase /*(vtkObjectBase*)*/ o) {
	VTK_API.API_vtkLocator.UnRegister_0(this, o);
}


}
};
