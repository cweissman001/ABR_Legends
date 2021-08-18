

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkReaderAlgorithm : vtkAlgorithm {
		public vtkReaderAlgorithm(IntPtr p) : base(p) {}
		public static implicit operator  vtkReaderAlgorithm(IntPtr p) {return new vtkReaderAlgorithm(p);}
		public static implicit operator  IntPtr(vtkReaderAlgorithm o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkReaderAlgorithm.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkReaderAlgorithm.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkReaderAlgorithm* SafeDownCast(vtkObjectBase * o)
// "static vtkReaderAlgorithm* SafeDownCast(vtkObjectBase *o)"
public static vtkReaderAlgorithm SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkReaderAlgorithm.SafeDownCast_0(out returnPointer, o);
//	return (vtkReaderAlgorithm)(IntPtr)returnPointer;
	return (vtkReaderAlgorithm)(IntPtr)returnPointer;
}


// vtkReaderAlgorithm* NewInstance()
// "vtkReaderAlgorithm *NewInstance()"
public vtkReaderAlgorithm NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkReaderAlgorithm.NewInstance_0(out returnPointer, this);
//	return (vtkReaderAlgorithm)(IntPtr)returnPointer;
	return (vtkReaderAlgorithm)(IntPtr)returnPointer;
}


// virtual vtkDataObject* CreateOutput(vtkDataObject * currentOutput)
// "virtual vtkDataObject* CreateOutput(vtkDataObject* currentOutput)"
public vtkDataObject CreateOutput(vtkDataObject /*(vtkDataObject*)*/ currentOutput) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkReaderAlgorithm.CreateOutput_0(out returnPointer, this, currentOutput);
//	return (vtkDataObject)(IntPtr)returnPointer;
	return (vtkDataObject)(IntPtr)returnPointer;
}


// virtual int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "virtual int ReadMesh( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadMesh(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkReaderAlgorithm.ReadMesh_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "virtual int ReadPoints( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadPoints(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkReaderAlgorithm.ReadPoints_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "virtual int ReadArrays( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadArrays(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkReaderAlgorithm.ReadArrays_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
