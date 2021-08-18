

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataReader : vtkXMLReader {
		public vtkXMLDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLDataReader(IntPtr p) {return new vtkXMLDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLDataReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLDataReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLDataReader)(IntPtr)returnPointer;
	return (vtkXMLDataReader)(IntPtr)returnPointer;
}


// vtkXMLDataReader* NewInstance()
// "vtkXMLDataReader *NewInstance()"
public vtkXMLDataReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLDataReader)(IntPtr)returnPointer;
	return (vtkXMLDataReader)(IntPtr)returnPointer;
}


// virtual vtkIdType GetNumberOfPoints()
// "virtual vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLDataReader.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfCells()
// "virtual vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLDataReader.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
