

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkUnstructuredGridReader : vtkDataReader {
		public vtkUnstructuredGridReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkUnstructuredGridReader(IntPtr p) {return new vtkUnstructuredGridReader(p);}
		public static implicit operator  IntPtr(vtkUnstructuredGridReader o) {return o.GetPtr();}

// static vtkUnstructuredGridReader* New()
// "static vtkUnstructuredGridReader *New()"
public static vtkUnstructuredGridReader New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridReader.New_0(out returnPointer);
//	return (vtkUnstructuredGridReader)(IntPtr)returnPointer;
	return (vtkUnstructuredGridReader)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnstructuredGridReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkUnstructuredGridReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkUnstructuredGridReader* SafeDownCast(vtkObjectBase * o)
// "static vtkUnstructuredGridReader* SafeDownCast(vtkObjectBase *o)"
public static vtkUnstructuredGridReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkUnstructuredGridReader)(IntPtr)returnPointer;
	return (vtkUnstructuredGridReader)(IntPtr)returnPointer;
}


// vtkUnstructuredGridReader* NewInstance()
// "vtkUnstructuredGridReader *NewInstance()"
public vtkUnstructuredGridReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridReader.NewInstance_0(out returnPointer, this);
//	return (vtkUnstructuredGridReader)(IntPtr)returnPointer;
	return (vtkUnstructuredGridReader)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetOutput()
// "vtkUnstructuredGrid *GetOutput()"
public vtkUnstructuredGrid GetOutput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridReader.GetOutput_0(out returnPointer, this);
//	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// vtkUnstructuredGrid* GetOutput(int idx)
// "vtkUnstructuredGrid *GetOutput(int idx)"
public vtkUnstructuredGrid GetOutput(int /*(int)*/ idx) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkUnstructuredGridReader.GetOutput_1(out returnPointer, this, idx);
//	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
	return (vtkUnstructuredGrid)(IntPtr)returnPointer;
}


// void SetOutput(vtkUnstructuredGrid * output)
// "void SetOutput(vtkUnstructuredGrid *output)"
public void SetOutput(vtkUnstructuredGrid /*(vtkUnstructuredGrid*)*/ output) {
	VTK_API.API_vtkUnstructuredGridReader.SetOutput_0(this, output);
}


}
};
