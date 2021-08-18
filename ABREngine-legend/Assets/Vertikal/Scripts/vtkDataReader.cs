

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataReader : vtkSimpleReader {
		public vtkDataReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataReader(IntPtr p) {return new vtkDataReader(p);}
		public static implicit operator  IntPtr(vtkDataReader o) {return o.GetPtr();}

// static vtkDataReader* New()
// "static vtkDataReader *New()"
public static vtkDataReader New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataReader.New_0(out returnPointer);
//	return (vtkDataReader)(IntPtr)returnPointer;
	return (vtkDataReader)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDataReader* SafeDownCast(vtkObjectBase * o)
// "static vtkDataReader* SafeDownCast(vtkObjectBase *o)"
public static vtkDataReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkDataReader)(IntPtr)returnPointer;
	return (vtkDataReader)(IntPtr)returnPointer;
}


// vtkDataReader* NewInstance()
// "vtkDataReader *NewInstance()"
public vtkDataReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataReader.NewInstance_0(out returnPointer, this);
//	return (vtkDataReader)(IntPtr)returnPointer;
	return (vtkDataReader)(IntPtr)returnPointer;
}


// void SetFileName(const char * fname)
// "void SetFileName(const char* fname)"
public void SetFileName(string /*(char*)*/ fname) {
	VTK_API.API_vtkDataReader.SetFileName_0(this, fname);
}


// char* GetFileName()
// "const char* GetFileName()"
public string GetFileName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetFileName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetFileName(int i)
// "const char* GetFileName(int i)"
public string GetFileName(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetFileName_1(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// int IsFileValid(const char * dstype)
// "int IsFileValid(const char *dstype)"
public int IsFileValid(string /*(char*)*/ dstype) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.IsFileValid_0(out returnPointer, this, dstype);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsFileStructuredPoints()
// "int IsFileStructuredPoints()"
public int IsFileStructuredPoints() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.IsFileStructuredPoints_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsFilePolyData()
// "int IsFilePolyData()"
public int IsFilePolyData() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.IsFilePolyData_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsFileStructuredGrid()
// "int IsFileStructuredGrid()"
public int IsFileStructuredGrid() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.IsFileStructuredGrid_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsFileUnstructuredGrid()
// "int IsFileUnstructuredGrid()"
public int IsFileUnstructuredGrid() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.IsFileUnstructuredGrid_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int IsFileRectilinearGrid()
// "int IsFileRectilinearGrid()"
public int IsFileRectilinearGrid() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.IsFileRectilinearGrid_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetInputString(const char * in)
// "void SetInputString(const char *in)"
public void SetInputString(string /*(char*)*/ in_var) {
	VTK_API.API_vtkDataReader.SetInputString_0(this, in_var);
}


// virtual char* GetInputString()
// "virtual char* GetInputString ()"
public string GetInputString() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetInputString_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// void SetInputString(const char * in, int len)
// "void SetInputString(const char *in, int len)"
public void SetInputString(string /*(char*)*/ in_var, int /*(int)*/ len) {
	VTK_API.API_vtkDataReader.SetInputString_1(this, in_var, len);
}


// virtual int GetInputStringLength()
// "virtual int GetInputStringLength ()"
public int GetInputStringLength() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetInputStringLength_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetBinaryInputString(const char * ARG_0, int len)
// "void SetBinaryInputString(const char *, int len)"
public void SetBinaryInputString(string /*(char*)*/ ARG_0, int /*(int)*/ len) {
	VTK_API.API_vtkDataReader.SetBinaryInputString_0(this, ARG_0, len);
}


// virtual void SetInputArray(vtkCharArray * ARG_0)
// "virtual void SetInputArray(vtkCharArray*)"
public void SetInputArray(vtkCharArray /*(vtkCharArray*)*/ ARG_0) {
	VTK_API.API_vtkDataReader.SetInputArray_0(this, ARG_0);
}


// virtual vtkCharArray* GetInputArray()
// "virtual vtkCharArray *GetInputArray ()"
public vtkCharArray GetInputArray() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataReader.GetInputArray_0(out returnPointer, this);
//	return (vtkCharArray)(IntPtr)returnPointer;
	return (vtkCharArray)(IntPtr)returnPointer;
}


// virtual char* GetHeader()
// "virtual char* GetHeader ()"
public string GetHeader() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetHeader_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetReadFromInputString(vtkTypeBool _arg)
// "virtual void SetReadFromInputString (vtkTypeBool _arg)"
public void SetReadFromInputString(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadFromInputString_0(this, _arg);
}


// virtual vtkTypeBool GetReadFromInputString()
// "virtual vtkTypeBool GetReadFromInputString ()"
public bool GetReadFromInputString() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadFromInputString_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadFromInputStringOn()
// "virtual void ReadFromInputStringOn ()"
public void ReadFromInputStringOn() {
	VTK_API.API_vtkDataReader.ReadFromInputStringOn_0(this);
}


// virtual void ReadFromInputStringOff()
// "virtual void ReadFromInputStringOff ()"
public void ReadFromInputStringOff() {
	VTK_API.API_vtkDataReader.ReadFromInputStringOff_0(this);
}


// virtual int GetFileType()
// "virtual int GetFileType ()"
public int GetFileType() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetFileType_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfScalarsInFile()
// "int GetNumberOfScalarsInFile()"
public int GetNumberOfScalarsInFile() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetNumberOfScalarsInFile_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfVectorsInFile()
// "int GetNumberOfVectorsInFile()"
public int GetNumberOfVectorsInFile() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetNumberOfVectorsInFile_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfTensorsInFile()
// "int GetNumberOfTensorsInFile()"
public int GetNumberOfTensorsInFile() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetNumberOfTensorsInFile_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfNormalsInFile()
// "int GetNumberOfNormalsInFile()"
public int GetNumberOfNormalsInFile() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetNumberOfNormalsInFile_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfTCoordsInFile()
// "int GetNumberOfTCoordsInFile()"
public int GetNumberOfTCoordsInFile() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetNumberOfTCoordsInFile_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfFieldDataInFile()
// "int GetNumberOfFieldDataInFile()"
public int GetNumberOfFieldDataInFile() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetNumberOfFieldDataInFile_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// char* GetScalarsNameInFile(int i)
// "const char *GetScalarsNameInFile(int i)"
public string GetScalarsNameInFile(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetScalarsNameInFile_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetVectorsNameInFile(int i)
// "const char *GetVectorsNameInFile(int i)"
public string GetVectorsNameInFile(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetVectorsNameInFile_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetTensorsNameInFile(int i)
// "const char *GetTensorsNameInFile(int i)"
public string GetTensorsNameInFile(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetTensorsNameInFile_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetNormalsNameInFile(int i)
// "const char *GetNormalsNameInFile(int i)"
public string GetNormalsNameInFile(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetNormalsNameInFile_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetTCoordsNameInFile(int i)
// "const char *GetTCoordsNameInFile(int i)"
public string GetTCoordsNameInFile(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetTCoordsNameInFile_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetFieldDataNameInFile(int i)
// "const char *GetFieldDataNameInFile(int i)"
public string GetFieldDataNameInFile(int /*(int)*/ i) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetFieldDataNameInFile_0(out returnPointer, this, i);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetScalarsName(const char * _arg)
// "virtual void SetScalarsName (const char* _arg)"
public void SetScalarsName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetScalarsName_0(this, _arg);
}


// virtual char* GetScalarsName()
// "virtual char* GetScalarsName ()"
public string GetScalarsName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetScalarsName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetVectorsName(const char * _arg)
// "virtual void SetVectorsName (const char* _arg)"
public void SetVectorsName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetVectorsName_0(this, _arg);
}


// virtual char* GetVectorsName()
// "virtual char* GetVectorsName ()"
public string GetVectorsName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetVectorsName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetTensorsName(const char * _arg)
// "virtual void SetTensorsName (const char* _arg)"
public void SetTensorsName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetTensorsName_0(this, _arg);
}


// virtual char* GetTensorsName()
// "virtual char* GetTensorsName ()"
public string GetTensorsName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetTensorsName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetNormalsName(const char * _arg)
// "virtual void SetNormalsName (const char* _arg)"
public void SetNormalsName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetNormalsName_0(this, _arg);
}


// virtual char* GetNormalsName()
// "virtual char* GetNormalsName ()"
public string GetNormalsName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetNormalsName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetTCoordsName(const char * _arg)
// "virtual void SetTCoordsName (const char* _arg)"
public void SetTCoordsName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetTCoordsName_0(this, _arg);
}


// virtual char* GetTCoordsName()
// "virtual char* GetTCoordsName ()"
public string GetTCoordsName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetTCoordsName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetLookupTableName(const char * _arg)
// "virtual void SetLookupTableName (const char* _arg)"
public void SetLookupTableName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetLookupTableName_0(this, _arg);
}


// virtual char* GetLookupTableName()
// "virtual char* GetLookupTableName ()"
public string GetLookupTableName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetLookupTableName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetFieldDataName(const char * _arg)
// "virtual void SetFieldDataName (const char* _arg)"
public void SetFieldDataName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkDataReader.SetFieldDataName_0(this, _arg);
}


// virtual char* GetFieldDataName()
// "virtual char* GetFieldDataName ()"
public string GetFieldDataName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.GetFieldDataName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetReadAllScalars(vtkTypeBool _arg)
// "virtual void SetReadAllScalars (vtkTypeBool _arg)"
public void SetReadAllScalars(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllScalars_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllScalars()
// "virtual vtkTypeBool GetReadAllScalars ()"
public bool GetReadAllScalars() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllScalars_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllScalarsOn()
// "virtual void ReadAllScalarsOn ()"
public void ReadAllScalarsOn() {
	VTK_API.API_vtkDataReader.ReadAllScalarsOn_0(this);
}


// virtual void ReadAllScalarsOff()
// "virtual void ReadAllScalarsOff ()"
public void ReadAllScalarsOff() {
	VTK_API.API_vtkDataReader.ReadAllScalarsOff_0(this);
}


// virtual void SetReadAllVectors(vtkTypeBool _arg)
// "virtual void SetReadAllVectors (vtkTypeBool _arg)"
public void SetReadAllVectors(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllVectors_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllVectors()
// "virtual vtkTypeBool GetReadAllVectors ()"
public bool GetReadAllVectors() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllVectors_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllVectorsOn()
// "virtual void ReadAllVectorsOn ()"
public void ReadAllVectorsOn() {
	VTK_API.API_vtkDataReader.ReadAllVectorsOn_0(this);
}


// virtual void ReadAllVectorsOff()
// "virtual void ReadAllVectorsOff ()"
public void ReadAllVectorsOff() {
	VTK_API.API_vtkDataReader.ReadAllVectorsOff_0(this);
}


// virtual void SetReadAllNormals(vtkTypeBool _arg)
// "virtual void SetReadAllNormals (vtkTypeBool _arg)"
public void SetReadAllNormals(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllNormals_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllNormals()
// "virtual vtkTypeBool GetReadAllNormals ()"
public bool GetReadAllNormals() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllNormals_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllNormalsOn()
// "virtual void ReadAllNormalsOn ()"
public void ReadAllNormalsOn() {
	VTK_API.API_vtkDataReader.ReadAllNormalsOn_0(this);
}


// virtual void ReadAllNormalsOff()
// "virtual void ReadAllNormalsOff ()"
public void ReadAllNormalsOff() {
	VTK_API.API_vtkDataReader.ReadAllNormalsOff_0(this);
}


// virtual void SetReadAllTensors(vtkTypeBool _arg)
// "virtual void SetReadAllTensors (vtkTypeBool _arg)"
public void SetReadAllTensors(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllTensors_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllTensors()
// "virtual vtkTypeBool GetReadAllTensors ()"
public bool GetReadAllTensors() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllTensors_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllTensorsOn()
// "virtual void ReadAllTensorsOn ()"
public void ReadAllTensorsOn() {
	VTK_API.API_vtkDataReader.ReadAllTensorsOn_0(this);
}


// virtual void ReadAllTensorsOff()
// "virtual void ReadAllTensorsOff ()"
public void ReadAllTensorsOff() {
	VTK_API.API_vtkDataReader.ReadAllTensorsOff_0(this);
}


// virtual void SetReadAllColorScalars(vtkTypeBool _arg)
// "virtual void SetReadAllColorScalars (vtkTypeBool _arg)"
public void SetReadAllColorScalars(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllColorScalars_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllColorScalars()
// "virtual vtkTypeBool GetReadAllColorScalars ()"
public bool GetReadAllColorScalars() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllColorScalars_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllColorScalarsOn()
// "virtual void ReadAllColorScalarsOn ()"
public void ReadAllColorScalarsOn() {
	VTK_API.API_vtkDataReader.ReadAllColorScalarsOn_0(this);
}


// virtual void ReadAllColorScalarsOff()
// "virtual void ReadAllColorScalarsOff ()"
public void ReadAllColorScalarsOff() {
	VTK_API.API_vtkDataReader.ReadAllColorScalarsOff_0(this);
}


// virtual void SetReadAllTCoords(vtkTypeBool _arg)
// "virtual void SetReadAllTCoords (vtkTypeBool _arg)"
public void SetReadAllTCoords(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllTCoords_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllTCoords()
// "virtual vtkTypeBool GetReadAllTCoords ()"
public bool GetReadAllTCoords() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllTCoords_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllTCoordsOn()
// "virtual void ReadAllTCoordsOn ()"
public void ReadAllTCoordsOn() {
	VTK_API.API_vtkDataReader.ReadAllTCoordsOn_0(this);
}


// virtual void ReadAllTCoordsOff()
// "virtual void ReadAllTCoordsOff ()"
public void ReadAllTCoordsOff() {
	VTK_API.API_vtkDataReader.ReadAllTCoordsOff_0(this);
}


// virtual void SetReadAllFields(vtkTypeBool _arg)
// "virtual void SetReadAllFields (vtkTypeBool _arg)"
public void SetReadAllFields(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkDataReader.SetReadAllFields_0(this, _arg);
}


// virtual vtkTypeBool GetReadAllFields()
// "virtual vtkTypeBool GetReadAllFields ()"
public bool GetReadAllFields() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataReader.GetReadAllFields_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadAllFieldsOn()
// "virtual void ReadAllFieldsOn ()"
public void ReadAllFieldsOn() {
	VTK_API.API_vtkDataReader.ReadAllFieldsOn_0(this);
}


// virtual void ReadAllFieldsOff()
// "virtual void ReadAllFieldsOff ()"
public void ReadAllFieldsOff() {
	VTK_API.API_vtkDataReader.ReadAllFieldsOff_0(this);
}


// int OpenVTKFile(const char * fname = nullptr)
// "int OpenVTKFile(const char* fname = nullptr)"
public int OpenVTKFile(string /*(char*)*/ fname) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.OpenVTKFile_0(out returnPointer, this, fname);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadHeader(const char * fname = nullptr)
// "int ReadHeader(const char* fname = nullptr)"
public int ReadHeader(string /*(char*)*/ fname) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadHeader_0(out returnPointer, this, fname);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadCellData(vtkDataSet * ds, vtkIdType numCells)
// "int ReadCellData(vtkDataSet *ds, vtkIdType numCells)"
public int ReadCellData(vtkDataSet /*(vtkDataSet*)*/ ds, long /*(vtkIdType)*/ numCells) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadCellData_0(out returnPointer, this, ds, numCells);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadPointData(vtkDataSet * ds, vtkIdType numPts)
// "int ReadPointData(vtkDataSet *ds, vtkIdType numPts)"
public int ReadPointData(vtkDataSet /*(vtkDataSet*)*/ ds, long /*(vtkIdType)*/ numPts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadPointData_0(out returnPointer, this, ds, numPts);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadPointCoordinates(vtkPointSet * ps, vtkIdType numPts)
// "int ReadPointCoordinates(vtkPointSet *ps, vtkIdType numPts)"
public int ReadPointCoordinates(vtkPointSet /*(vtkPointSet*)*/ ps, long /*(vtkIdType)*/ numPts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadPointCoordinates_0(out returnPointer, this, ps, numPts);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadPointCoordinates(vtkGraph * g, vtkIdType numPts)
// "int ReadPointCoordinates(vtkGraph *g, vtkIdType numPts)"
public int ReadPointCoordinates(vtkGraph /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ numPts) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadPointCoordinates_1(out returnPointer, this, g, numPts);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadVertexData(vtkGraph * g, vtkIdType numVertices)
// "int ReadVertexData(vtkGraph *g, vtkIdType numVertices)"
public int ReadVertexData(vtkGraph /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ numVertices) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadVertexData_0(out returnPointer, this, g, numVertices);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadEdgeData(vtkGraph * g, vtkIdType numEdges)
// "int ReadEdgeData(vtkGraph *g, vtkIdType numEdges)"
public int ReadEdgeData(vtkGraph /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ numEdges) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadEdgeData_0(out returnPointer, this, g, numEdges);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadRowData(vtkTable * t, vtkIdType numEdges)
// "int ReadRowData(vtkTable *t, vtkIdType numEdges)"
public int ReadRowData(vtkTable /*(vtkTable*)*/ t, long /*(vtkIdType)*/ numEdges) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadRowData_0(out returnPointer, this, t, numEdges);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadCells(vtkIdType size, int * data)
// "int ReadCells(vtkIdType size, int *data)"
public int ReadCells(long /*(vtkIdType)*/ size, int /*(int*)*/ []data) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadCells_0(out returnPointer, this, size, data);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadCells(vtkIdType size, int * data, int skip1, int read2, int skip3)
// "int ReadCells(vtkIdType size, int *data, int skip1, int read2, int skip3)"
public int ReadCells(long /*(vtkIdType)*/ size, int /*(int*)*/ []data, int /*(int)*/ skip1, int /*(int)*/ read2, int /*(int)*/ skip3) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadCells_1(out returnPointer, this, size, data, skip1, read2, skip3);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkAbstractArray* ReadArray(const char * dataType, vtkIdType numTuples, vtkIdType numComp)
// "vtkAbstractArray *ReadArray(const char *dataType, vtkIdType numTuples, vtkIdType numComp)"
public vtkAbstractArray ReadArray(string /*(char*)*/ dataType, long /*(vtkIdType)*/ numTuples, long /*(vtkIdType)*/ numComp) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataReader.ReadArray_0(out returnPointer, this, dataType, numTuples, numComp);
//	return (vtkAbstractArray)(IntPtr)returnPointer;
	return (vtkAbstractArray)(IntPtr)returnPointer;
}


// virtual int GetFileMajorVersion()
// "virtual int GetFileMajorVersion ()"
public int GetFileMajorVersion() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetFileMajorVersion_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetFileMinorVersion()
// "virtual int GetFileMinorVersion ()"
public int GetFileMinorVersion() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.GetFileMinorVersion_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(char * ARG_0)
// "int Read(char *)"
public int Read(string /*(char*)*/ ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_0(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(short * ARG_0)
// "int Read(short *)"
public int Read(short /*(short*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_2(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(int * ARG_0)
// "int Read(int *)"
public int Read(int /*(int*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_4(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(unsigned int * ARG_0)
// "int Read(unsigned int *)"
public int Read(uint /*(unsigned int*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_5(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(long * ARG_0)
// "int Read(long *)"
public int Read(long /*(long*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_6(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(unsigned long * ARG_0)
// "int Read(unsigned long *)"
public int Read(ulong /*(unsigned long*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_7(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(float * ARG_0)
// "int Read(float *)"
public int Read(float /*(float*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_10(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// int Read(double * ARG_0)
// "int Read(double *)"
public int Read(double /*(double*)*/ []ARG_0) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.Read_11(out returnPointer, this, ARG_0);
//	return (int)returnPointer;
	return returnPointer;
}


// size_t Peek(char * str, size_t n)
// "size_t Peek(char *str, size_t n)"
public ulong Peek(string /*(char*)*/ str, ulong /*(size_t)*/ n) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataReader.Peek_0(out returnPointer, this, str, n);
//	return (ulong)returnPointer;
	return returnPointer;
}


// void CloseVTKFile()
// "void CloseVTKFile()"
public void CloseVTKFile() {
	VTK_API.API_vtkDataReader.CloseVTKFile_0(this);
}


// int ReadLine(char result[256])
// "int ReadLine(char result[256])"
public int ReadLine(char /*(char[256])*/ []result) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadLine_0(out returnPointer, this, result);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadString(char result[256])
// "int ReadString(char result[256])"
public int ReadString(char /*(char[256])*/ []result) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadString_0(out returnPointer, this, result);
//	return (int)returnPointer;
	return returnPointer;
}


// char* LowerCase(char * str, const size_t len = 256)
// "char *LowerCase(char *str, const size_t len=256)"
public string LowerCase(string /*(char*)*/ str, ulong /*(size_t)*/ len) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkDataReader.LowerCase_0(out returnPointer, this, str, len);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// "int ReadMesh( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)"
public int ReadMesh(int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, vtkDataObject /*(vtkDataObject*)*/ output) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadMesh_0(out returnPointer, this, piece, npieces, nghosts, timestep, output);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadPoints(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkDataObject * ARG_4)
// "int ReadPoints( int , int , int , int , vtkDataObject* )"
public int ReadPoints(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, vtkDataObject /*(vtkDataObject*)*/ ARG_4) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadPoints_0(out returnPointer, this, ARG_0, ARG_1, ARG_2, ARG_3, ARG_4);
//	return (int)returnPointer;
	return returnPointer;
}


// int ReadArrays(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkDataObject * ARG_4)
// "int ReadArrays( int , int , int , int , vtkDataObject* )"
public int ReadArrays(int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, vtkDataObject /*(vtkDataObject*)*/ ARG_4) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataReader.ReadArrays_0(out returnPointer, this, ARG_0, ARG_1, ARG_2, ARG_3, ARG_4);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
