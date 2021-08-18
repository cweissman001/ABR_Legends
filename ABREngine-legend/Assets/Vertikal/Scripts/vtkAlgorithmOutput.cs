

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkAlgorithmOutput : vtkObject {
		public vtkAlgorithmOutput(IntPtr p) : base(p) {}
		public static implicit operator  vtkAlgorithmOutput(IntPtr p) {return new vtkAlgorithmOutput(p);}
		public static implicit operator  IntPtr(vtkAlgorithmOutput o) {return o.GetPtr();}

// static vtkAlgorithmOutput* New()
// "static vtkAlgorithmOutput *New()"
public static vtkAlgorithmOutput New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAlgorithmOutput.New_0(out returnPointer);
//	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAlgorithmOutput.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkAlgorithmOutput.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkAlgorithmOutput* SafeDownCast(vtkObjectBase * o)
// "static vtkAlgorithmOutput* SafeDownCast(vtkObjectBase *o)"
public static vtkAlgorithmOutput SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAlgorithmOutput.SafeDownCast_0(out returnPointer, o);
//	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// vtkAlgorithmOutput* NewInstance()
// "vtkAlgorithmOutput *NewInstance()"
public vtkAlgorithmOutput NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAlgorithmOutput.NewInstance_0(out returnPointer, this);
//	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
	return (vtkAlgorithmOutput)(IntPtr)returnPointer;
}


// void SetIndex(int index)
// "void SetIndex(int index)"
public void SetIndex(int /*(int)*/ index) {
	VTK_API.API_vtkAlgorithmOutput.SetIndex_0(this, index);
}


// int GetIndex()
// "int GetIndex()"
public int GetIndex() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkAlgorithmOutput.GetIndex_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkAlgorithm* GetProducer()
// "vtkAlgorithm* GetProducer()"
public vtkAlgorithm GetProducer() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkAlgorithmOutput.GetProducer_0(out returnPointer, this);
//	return (vtkAlgorithm)(IntPtr)returnPointer;
	return (vtkAlgorithm)(IntPtr)returnPointer;
}


// void SetProducer(vtkAlgorithm * producer)
// "void SetProducer(vtkAlgorithm* producer)"
public void SetProducer(vtkAlgorithm /*(vtkAlgorithm*)*/ producer) {
	VTK_API.API_vtkAlgorithmOutput.SetProducer_0(this, producer);
}


}
};
