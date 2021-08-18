

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkCuller : vtkObject {
		public vtkCuller(IntPtr p) : base(p) {}
		public static implicit operator  vtkCuller(IntPtr p) {return new vtkCuller(p);}
		public static implicit operator  IntPtr(vtkCuller o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCuller.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkCuller.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkCuller* SafeDownCast(vtkObjectBase * o)
// "static vtkCuller* SafeDownCast(vtkObjectBase *o)"
public static vtkCuller SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCuller.SafeDownCast_0(out returnPointer, o);
//	return (vtkCuller)(IntPtr)returnPointer;
	return (vtkCuller)(IntPtr)returnPointer;
}


// vtkCuller* NewInstance()
// "vtkCuller *NewInstance()"
public vtkCuller NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkCuller.NewInstance_0(out returnPointer, this);
//	return (vtkCuller)(IntPtr)returnPointer;
	return (vtkCuller)(IntPtr)returnPointer;
}


// virtual double Cull(vtkRenderer * ren, vtkProp ** propList, int & listLength, int & initialized)
// "virtual double Cull( vtkRenderer *ren, vtkProp **propList, int& listLength, int& initialized )"
public double Cull(vtkRenderer /*(vtkRenderer*)*/ ren, vtkProp /*(vtkProp**)*/ propList, IntPtr /*(int&)*/ listLength, IntPtr /*(int&)*/ initialized) {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkCuller.Cull_0(out returnPointer, this, ren, propList, listLength, initialized);
//	return (double)returnPointer;
	return returnPointer;
}


}
};
