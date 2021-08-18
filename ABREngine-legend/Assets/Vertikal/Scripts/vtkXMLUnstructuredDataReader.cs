

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLUnstructuredDataReader : vtkXMLDataReader {
		public vtkXMLUnstructuredDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLUnstructuredDataReader(IntPtr p) {return new vtkXMLUnstructuredDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLUnstructuredDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLUnstructuredDataReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLUnstructuredDataReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLUnstructuredDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLUnstructuredDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLUnstructuredDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLUnstructuredDataReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLUnstructuredDataReader)(IntPtr)returnPointer;
	return (vtkXMLUnstructuredDataReader)(IntPtr)returnPointer;
}


// vtkXMLUnstructuredDataReader* NewInstance()
// "vtkXMLUnstructuredDataReader *NewInstance()"
public vtkXMLUnstructuredDataReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLUnstructuredDataReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLUnstructuredDataReader)(IntPtr)returnPointer;
	return (vtkXMLUnstructuredDataReader)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLUnstructuredDataReader.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLUnstructuredDataReader.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual vtkIdType GetNumberOfPieces()
// "virtual vtkIdType GetNumberOfPieces()"
public long GetNumberOfPieces() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLUnstructuredDataReader.GetNumberOfPieces_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
// "void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)"
public void SetupUpdateExtent(int /*(int)*/ piece, int /*(int)*/ numberOfPieces, int /*(int)*/ ghostLevel) {
	VTK_API.API_vtkXMLUnstructuredDataReader.SetupUpdateExtent_0(this, piece, numberOfPieces, ghostLevel);
}


}
};
