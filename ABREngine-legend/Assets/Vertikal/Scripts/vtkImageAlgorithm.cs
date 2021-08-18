

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkImageAlgorithm : vtkAlgorithm {
		public vtkImageAlgorithm(IntPtr p) : base(p) {}
		public static implicit operator  vtkImageAlgorithm(IntPtr p) {return new vtkImageAlgorithm(p);}
		public static implicit operator  IntPtr(vtkImageAlgorithm o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkImageAlgorithm.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkImageAlgorithm.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkImageAlgorithm* SafeDownCast(vtkObjectBase * o)
// "static vtkImageAlgorithm* SafeDownCast(vtkObjectBase *o)"
public static vtkImageAlgorithm SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.SafeDownCast_0(out returnPointer, o);
//	return (vtkImageAlgorithm)(IntPtr)returnPointer;
	return (vtkImageAlgorithm)(IntPtr)returnPointer;
}


// vtkImageAlgorithm* NewInstance()
// "vtkImageAlgorithm *NewInstance()"
public vtkImageAlgorithm NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.NewInstance_0(out returnPointer, this);
//	return (vtkImageAlgorithm)(IntPtr)returnPointer;
	return (vtkImageAlgorithm)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput()
// "vtkImageData* GetOutput()"
public vtkImageData GetOutput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.GetOutput_0(out returnPointer, this);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput(int ARG_0)
// "vtkImageData* GetOutput(int)"
public vtkImageData GetOutput(int /*(int)*/ ARG_0) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.GetOutput_1(out returnPointer, this, ARG_0);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


// virtual void SetOutput(vtkDataObject * d)
// "virtual void SetOutput(vtkDataObject* d)"
public void SetOutput(vtkDataObject /*(vtkDataObject*)*/ d) {
	VTK_API.API_vtkImageAlgorithm.SetOutput_0(this, d);
}


// void SetInputData(vtkDataObject * ARG_0)
// "void SetInputData(vtkDataObject *)"
public void SetInputData(vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkImageAlgorithm.SetInputData_0(this, ARG_0);
}


// void SetInputData(int ARG_0, vtkDataObject * ARG_1)
// "void SetInputData(int, vtkDataObject*)"
public void SetInputData(int /*(int)*/ ARG_0, vtkDataObject /*(vtkDataObject*)*/ ARG_1) {
	VTK_API.API_vtkImageAlgorithm.SetInputData_1(this, ARG_0, ARG_1);
}


// vtkDataObject* GetInput(int port)
// "vtkDataObject *GetInput(int port)"
public vtkDataObject GetInput(int /*(int)*/ port) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.GetInput_0(out returnPointer, this, port);
//	return (vtkDataObject)(IntPtr)returnPointer;
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkDataObject* GetInput()
// "vtkDataObject *GetInput()"
public vtkDataObject GetInput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.GetInput_1(out returnPointer, this);
//	return (vtkDataObject)(IntPtr)returnPointer;
	return (vtkDataObject)(IntPtr)returnPointer;
}


// vtkImageData* GetImageDataInput(int port)
// "vtkImageData *GetImageDataInput(int port)"
public vtkImageData GetImageDataInput(int /*(int)*/ port) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkImageAlgorithm.GetImageDataInput_0(out returnPointer, this, port);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


// virtual void AddInputData(vtkDataObject * ARG_0)
// "virtual void AddInputData(vtkDataObject *)"
public void AddInputData(vtkDataObject /*(vtkDataObject*)*/ ARG_0) {
	VTK_API.API_vtkImageAlgorithm.AddInputData_0(this, ARG_0);
}


// virtual void AddInputData(int ARG_0, vtkDataObject * ARG_1)
// "virtual void AddInputData(int, vtkDataObject*)"
public void AddInputData(int /*(int)*/ ARG_0, vtkDataObject /*(vtkDataObject*)*/ ARG_1) {
	VTK_API.API_vtkImageAlgorithm.AddInputData_1(this, ARG_0, ARG_1);
}


}
};
