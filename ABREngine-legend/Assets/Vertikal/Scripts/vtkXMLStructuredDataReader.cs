

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLStructuredDataReader : vtkXMLDataReader {
		public vtkXMLStructuredDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLStructuredDataReader(IntPtr p) {return new vtkXMLStructuredDataReader(p);}
		public static implicit operator  IntPtr(vtkXMLStructuredDataReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLStructuredDataReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLStructuredDataReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLStructuredDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLStructuredDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredDataReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
}


// vtkXMLStructuredDataReader* NewInstance()
// "vtkXMLStructuredDataReader *NewInstance()"
public vtkXMLStructuredDataReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLStructuredDataReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
	return (vtkXMLStructuredDataReader)(IntPtr)returnPointer;
}


// vtkIdType GetNumberOfPoints()
// "vtkIdType GetNumberOfPoints()"
public long GetNumberOfPoints() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfPoints_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// vtkIdType GetNumberOfCells()
// "vtkIdType GetNumberOfCells()"
public long GetNumberOfCells() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLStructuredDataReader.GetNumberOfCells_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetWholeSlices(vtkTypeBool _arg)
// "virtual void SetWholeSlices (vtkTypeBool _arg)"
public void SetWholeSlices(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkXMLStructuredDataReader.SetWholeSlices_0(this, _arg);
}


// virtual vtkTypeBool GetWholeSlices()
// "virtual vtkTypeBool GetWholeSlices ()"
public bool GetWholeSlices() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLStructuredDataReader.GetWholeSlices_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void WholeSlicesOn()
// "virtual void WholeSlicesOn ()"
public void WholeSlicesOn() {
	VTK_API.API_vtkXMLStructuredDataReader.WholeSlicesOn_0(this);
}


// virtual void WholeSlicesOff()
// "virtual void WholeSlicesOff ()"
public void WholeSlicesOff() {
	VTK_API.API_vtkXMLStructuredDataReader.WholeSlicesOff_0(this);
}


}
};
