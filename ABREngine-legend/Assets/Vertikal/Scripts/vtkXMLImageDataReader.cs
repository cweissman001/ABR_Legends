

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLImageDataReader : vtkXMLStructuredDataReader {
		public vtkXMLImageDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLImageDataReader(IntPtr p) {return new vtkXMLImageDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLImageDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLImageDataReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLImageDataReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLImageDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLImageDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLImageDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLImageDataReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// vtkXMLImageDataReader* NewInstance()
// "vtkXMLImageDataReader *NewInstance()"
public vtkXMLImageDataReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLImageDataReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// static vtkXMLImageDataReader* New()
// "static vtkXMLImageDataReader *New()"
public static vtkXMLImageDataReader New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLImageDataReader.New_0(out returnPointer);
//	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
	return (vtkXMLImageDataReader)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput()
// "vtkImageData *GetOutput()"
public vtkImageData GetOutput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLImageDataReader.GetOutput_0(out returnPointer, this);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


// vtkImageData* GetOutput(int idx)
// "vtkImageData *GetOutput(int idx)"
public vtkImageData GetOutput(int /*(int)*/ idx) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLImageDataReader.GetOutput_1(out returnPointer, this, idx);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


}
};
