

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkSimpleReader : vtkReaderAlgorithm {
		public vtkSimpleReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkSimpleReader(IntPtr p) {return new vtkSimpleReader(p);}
		public static implicit operator  IntPtr(vtkSimpleReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkSimpleReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkSimpleReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkSimpleReader* SafeDownCast(vtkObjectBase * o)
// "static vtkSimpleReader* SafeDownCast(vtkObjectBase *o)"
public static vtkSimpleReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkSimpleReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkSimpleReader)(IntPtr)returnPointer;
	return (vtkSimpleReader)(IntPtr)returnPointer;
}


// vtkSimpleReader* NewInstance()
// "vtkSimpleReader *NewInstance()"
public vtkSimpleReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkSimpleReader.NewInstance_0(out returnPointer, this);
//	return (vtkSimpleReader)(IntPtr)returnPointer;
	return (vtkSimpleReader)(IntPtr)returnPointer;
}


// void AddFileName(const char * fname)
// "void AddFileName(const char* fname)"
public void AddFileName(string /*(char*)*/ fname) {
	VTK_API.API_vtkSimpleReader.AddFileName_0(this, fname);
}


// void ClearFileNames()
// "void ClearFileNames()"
public void ClearFileNames() {
	VTK_API.API_vtkSimpleReader.ClearFileNames_0(this);
}


// int GetNumberOfFileNames()
// "int GetNumberOfFileNames()"
public int GetNumberOfFileNames() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkSimpleReader.GetNumberOfFileNames_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// char* GetFileName(int i)
// "const char* GetFileName(int i)"
public string GetFileName(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkSimpleReader.GetFileName_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetCurrentFileName()
// "const char* GetCurrentFileName()"
public string GetCurrentFileName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkSimpleReader.GetCurrentFileName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "int ReadMesh( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadMesh(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkSimpleReader.ReadMesh_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadPoints(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "int ReadPoints( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadPoints(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkSimpleReader.ReadPoints_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadArrays(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "int ReadArrays( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadArrays(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkSimpleReader.ReadArrays_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
