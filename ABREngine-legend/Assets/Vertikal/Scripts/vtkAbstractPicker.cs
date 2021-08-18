

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAbstractPicker : vtkObject {
		public vtkAbstractPicker(IntPtr p) : base(p) {}
		public static implicit operator  vtkAbstractPicker(IntPtr p) {return new vtkAbstractPicker(p);}
		public static implicit operator  IntPtr(vtkAbstractPicker o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPicker.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPicker.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAbstractPicker* SafeDownCast(vtkObjectBase * o)
// "static vtkAbstractPicker* SafeDownCast(vtkObjectBase *o)"
public static vtkAbstractPicker SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPicker.SafeDownCast_0(out returnPointer, o);
//	return (vtkAbstractPicker)(IntPtr)returnPointer;
	return (vtkAbstractPicker)(IntPtr)returnPointer;
}


// vtkAbstractPicker* NewInstance()
// "vtkAbstractPicker *NewInstance()"
public vtkAbstractPicker NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPicker.NewInstance_0(out returnPointer, this);
//	return (vtkAbstractPicker)(IntPtr)returnPointer;
	return (vtkAbstractPicker)(IntPtr)returnPointer;
}


// virtual vtkRenderer* GetRenderer()
// "virtual vtkRenderer *GetRenderer ()"
public vtkRenderer GetRenderer() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPicker.GetRenderer_0(out returnPointer, this);
//	return (vtkRenderer)(IntPtr)returnPointer;
	return (vtkRenderer)(IntPtr)returnPointer;
}


// virtual double* GetSelectionPoint()
// "virtual double *GetSelectionPoint ()"
public double[] GetSelectionPoint() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractPicker.GetSelectionPoint_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetSelectionPoint(double data[3])
// "virtual void GetSelectionPoint (double data[3])"
public void GetSelectionPoint(double /*(double[3])*/ []data) {
	VTK_API.API_vtkAbstractPicker.GetSelectionPoint_1(this, data);
}


// virtual double* GetPickPosition()
// "virtual double *GetPickPosition ()"
public double[] GetPickPosition() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double[] returnPointer = new double[1];
	VTK_API.API_vtkAbstractPicker.GetPickPosition_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


// virtual void GetPickPosition(double data[3])
// "virtual void GetPickPosition (double data[3])"
public void GetPickPosition(double /*(double[3])*/ []data) {
	VTK_API.API_vtkAbstractPicker.GetPickPosition_1(this, data);
}


// virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer * renderer)
// "virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer *renderer)"
public int Pick(double /*(double)*/ selectionX, double /*(double)*/ selectionY, double /*(double)*/ selectionZ, vtkRenderer /*(vtkRenderer*)*/ renderer) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractPicker.Pick_0(out returnPointer, this, selectionX, selectionY, selectionZ, renderer);
//	return (int)returnPointer;
	return returnPointer;
}


// int Pick(double selectionPt[3], vtkRenderer * ren)
// "int Pick(double selectionPt[3], vtkRenderer *ren)"
public int Pick(double /*(double[3])*/ []selectionPt, vtkRenderer /*(vtkRenderer*)*/ ren) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractPicker.Pick_1(out returnPointer, this, selectionPt, ren);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int Pick3DPoint(double ARG_0[3], vtkRenderer * ARG_1)
// "virtual int Pick3DPoint(double [3], vtkRenderer * )"
public int Pick3DPoint(double /*(double[3])*/ []ARG_0, vtkRenderer /*(vtkRenderer*)*/ ARG_1) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractPicker.Pick3DPoint_0(out returnPointer, this, ARG_0, ARG_1);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int Pick3DRay(double ARG_0[3], double ARG_1[4], vtkRenderer * ARG_2)
// "virtual int Pick3DRay(double [3], double [4], vtkRenderer * )"
public int Pick3DRay(double /*(double[3])*/ []ARG_0, double /*(double[4])*/ []ARG_1, vtkRenderer /*(vtkRenderer*)*/ ARG_2) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAbstractPicker.Pick3DRay_0(out returnPointer, this, ARG_0, ARG_1, ARG_2);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetPickFromList(vtkTypeBool _arg)
// "virtual void SetPickFromList (vtkTypeBool _arg)"
public void SetPickFromList(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkAbstractPicker.SetPickFromList_0(this, _arg);
}


// virtual vtkTypeBool GetPickFromList()
// "virtual vtkTypeBool GetPickFromList ()"
public bool GetPickFromList() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAbstractPicker.GetPickFromList_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void PickFromListOn()
// "virtual void PickFromListOn ()"
public void PickFromListOn() {
	VTK_API.API_vtkAbstractPicker.PickFromListOn_0(this);
}


// virtual void PickFromListOff()
// "virtual void PickFromListOff ()"
public void PickFromListOff() {
	VTK_API.API_vtkAbstractPicker.PickFromListOff_0(this);
}


// void InitializePickList()
// "void InitializePickList()"
public void InitializePickList() {
	VTK_API.API_vtkAbstractPicker.InitializePickList_0(this);
}


// void AddPickList(vtkProp * ARG_0)
// "void AddPickList(vtkProp *)"
public void AddPickList(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkAbstractPicker.AddPickList_0(this, ARG_0);
}


// void DeletePickList(vtkProp * ARG_0)
// "void DeletePickList(vtkProp *)"
public void DeletePickList(vtkProp /*(vtkProp*)*/ ARG_0) {
	VTK_API.API_vtkAbstractPicker.DeletePickList_0(this, ARG_0);
}


// vtkPropCollection* GetPickList()
// "vtkPropCollection *GetPickList()"
public vtkPropCollection GetPickList() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAbstractPicker.GetPickList_0(out returnPointer, this);
//	return (vtkPropCollection)(IntPtr)returnPointer;
	return (vtkPropCollection)(IntPtr)returnPointer;
}


}
};
