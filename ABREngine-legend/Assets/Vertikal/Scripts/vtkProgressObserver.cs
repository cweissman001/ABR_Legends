

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkProgressObserver : vtkObject {
		public vtkProgressObserver(IntPtr p) : base(p) {}
		public static implicit operator  vtkProgressObserver(IntPtr p) {return new vtkProgressObserver(p);}
		public static implicit operator  IntPtr(vtkProgressObserver o) {return o.GetPtr();}

// static vtkProgressObserver* New()
// "static vtkProgressObserver *New()"
public static vtkProgressObserver New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProgressObserver.New_0(out returnPointer);
//	return (vtkProgressObserver)(IntPtr)returnPointer;
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProgressObserver.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkProgressObserver.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkProgressObserver* SafeDownCast(vtkObjectBase * o)
// "static vtkProgressObserver* SafeDownCast(vtkObjectBase *o)"
public static vtkProgressObserver SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProgressObserver.SafeDownCast_0(out returnPointer, o);
//	return (vtkProgressObserver)(IntPtr)returnPointer;
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// vtkProgressObserver* NewInstance()
// "vtkProgressObserver *NewInstance()"
public vtkProgressObserver NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkProgressObserver.NewInstance_0(out returnPointer, this);
//	return (vtkProgressObserver)(IntPtr)returnPointer;
	return (vtkProgressObserver)(IntPtr)returnPointer;
}


// virtual void UpdateProgress(double amount)
// "virtual void UpdateProgress(double amount)"
public void UpdateProgress(double /*(double)*/ amount) {
	VTK_API.API_vtkProgressObserver.UpdateProgress_0(this, amount);
}


// virtual double GetProgress()
// "virtual double GetProgress ()"
public double GetProgress() {
//	double
//	ReturnPointer returnPointer = new ReturnPointer(new double());
	double returnPointer = new double();
	VTK_API.API_vtkProgressObserver.GetProgress_0(out returnPointer, this);
//	return (double)returnPointer;
	return returnPointer;
}


}
};
