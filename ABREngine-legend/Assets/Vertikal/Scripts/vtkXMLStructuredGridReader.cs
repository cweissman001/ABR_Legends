

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredGridReader : vtkXMLStructuredDataReader {
		public vtkXMLStructuredGridReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLStructuredGridReader(IntPtr p) {return new vtkXMLStructuredGridReader(p);}
		public static implicit operator  IntPtr(vtkXMLStructuredGridReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLStructuredGridReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLStructuredGridReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLStructuredGridReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLStructuredGridReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLStructuredGridReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredGridReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// vtkXMLStructuredGridReader* NewInstance()
// "vtkXMLStructuredGridReader *NewInstance()"
public vtkXMLStructuredGridReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredGridReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// static vtkXMLStructuredGridReader* New()
// "static vtkXMLStructuredGridReader *New()"
public static vtkXMLStructuredGridReader New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredGridReader.New_0(out returnPointer);
//	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
	return (vtkXMLStructuredGridReader)(IntPtr)returnPointer;
}


// vtkStructuredGrid* GetOutput()
// "vtkStructuredGrid *GetOutput()"
public vtkStructuredGrid GetOutput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredGridReader.GetOutput_0(out returnPointer, this);
//	return (vtkStructuredGrid)(IntPtr)returnPointer;
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


// vtkStructuredGrid* GetOutput(int idx)
// "vtkStructuredGrid *GetOutput(int idx)"
public vtkStructuredGrid GetOutput(int /*(int)*/ idx) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredGridReader.GetOutput_1(out returnPointer, this, idx);
//	return (vtkStructuredGrid)(IntPtr)returnPointer;
	return (vtkStructuredGrid)(IntPtr)returnPointer;
}


}
};
