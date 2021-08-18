

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkArrayIterator : vtkObject {
		public vtkArrayIterator(IntPtr p) : base(p) {}
		public static implicit operator  vtkArrayIterator(IntPtr p) {return new vtkArrayIterator(p);}
		public static implicit operator  IntPtr(vtkArrayIterator o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkArrayIterator.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkArrayIterator.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkArrayIterator* SafeDownCast(vtkObjectBase * o)
// "static vtkArrayIterator* SafeDownCast(vtkObjectBase *o)"
public static vtkArrayIterator SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkArrayIterator.SafeDownCast_0(out returnPointer, o);
//	return (vtkArrayIterator)(IntPtr)returnPointer;
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// vtkArrayIterator* NewInstance()
// "vtkArrayIterator *NewInstance()"
public vtkArrayIterator NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkArrayIterator.NewInstance_0(out returnPointer, this);
//	return (vtkArrayIterator)(IntPtr)returnPointer;
	return (vtkArrayIterator)(IntPtr)returnPointer;
}


// virtual void Initialize(vtkAbstractArray * array)
// "virtual void Initialize(vtkAbstractArray* array)"
public void Initialize(vtkAbstractArray /*(vtkAbstractArray*)*/ array) {
	VTK_API.API_vtkArrayIterator.Initialize_0(this, array);
}


// virtual int GetDataType()
// "virtual int GetDataType()"
public int GetDataType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkArrayIterator.GetDataType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
