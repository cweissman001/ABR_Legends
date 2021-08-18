

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLPolyDataReader : vtkXMLUnstructuredDataReader {
		public vtkXMLPolyDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLPolyDataReader(IntPtr p) {return new vtkXMLPolyDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLPolyDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLPolyDataReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLPolyDataReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLPolyDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLPolyDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLPolyDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLPolyDataReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
}


// vtkXMLPolyDataReader* NewInstance()
// "vtkXMLPolyDataReader *NewInstance()"
public vtkXMLPolyDataReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLPolyDataReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
}


// static vtkXMLPolyDataReader* New()
// "static vtkXMLPolyDataReader *New()"
public static vtkXMLPolyDataReader New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLPolyDataReader.New_0(out returnPointer);
//	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
	return (vtkXMLPolyDataReader)(IntPtr)returnPointer;
}


// vtkPolyData* GetOutput()
// "vtkPolyData *GetOutput()"
public vtkPolyData GetOutput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLPolyDataReader.GetOutput_0(out returnPointer, this);
//	return (vtkPolyData)(IntPtr)returnPointer;
	return (vtkPolyData)(IntPtr)returnPointer;
}


// vtkPolyData* GetOutput(int idx)
// "vtkPolyData *GetOutput(int idx)"
public vtkPolyData GetOutput(int /*(int)*/ idx) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLPolyDataReader.GetOutput_1(out returnPointer, this, idx);
//	return (vtkPolyData)(IntPtr)returnPointer;
	return (vtkPolyData)(IntPtr)returnPointer;
}


// virtual vtkIdType GetNumberOfVerts()
// "virtual vtkIdType GetNumberOfVerts()"
public long GetNumberOfVerts() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfVerts_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfLines()
// "virtual vtkIdType GetNumberOfLines()"
public long GetNumberOfLines() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfLines_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfStrips()
// "virtual vtkIdType GetNumberOfStrips()"
public long GetNumberOfStrips() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfStrips_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfPolys()
// "virtual vtkIdType GetNumberOfPolys()"
public long GetNumberOfPolys() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLPolyDataReader.GetNumberOfPolys_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
