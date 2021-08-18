

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLReader : vtkAlgorithm {
		public vtkXMLReader(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLReader(IntPtr p) {return new vtkXMLReader(p);}
		public static implicit operator  IntPtr(vtkXMLReader o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLReader.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLReader.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLReader* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLReader* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLReader SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLReader)(IntPtr)returnPointer;
	return (vtkXMLReader)(IntPtr)returnPointer;
}


// vtkXMLReader* NewInstance()
// "vtkXMLReader *NewInstance()"
public vtkXMLReader NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.NewInstance_0(out returnPointer, this);
//	return (vtkXMLReader)(IntPtr)returnPointer;
	return (vtkXMLReader)(IntPtr)returnPointer;
}


// virtual void SetFileName(const char * _arg)
// "virtual void SetFileName (const char* _arg)"
public void SetFileName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLReader.SetFileName_0(this, _arg);
}


// virtual char* GetFileName()
// "virtual char* GetFileName ()"
public string GetFileName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLReader.GetFileName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetReadFromInputString(vtkTypeBool _arg)
// "virtual void SetReadFromInputString (vtkTypeBool _arg)"
public void SetReadFromInputString(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkXMLReader.SetReadFromInputString_0(this, _arg);
}


// virtual vtkTypeBool GetReadFromInputString()
// "virtual vtkTypeBool GetReadFromInputString ()"
public bool GetReadFromInputString() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLReader.GetReadFromInputString_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void ReadFromInputStringOn()
// "virtual void ReadFromInputStringOn ()"
public void ReadFromInputStringOn() {
	VTK_API.API_vtkXMLReader.ReadFromInputStringOn_0(this);
}


// virtual void ReadFromInputStringOff()
// "virtual void ReadFromInputStringOff ()"
public void ReadFromInputStringOff() {
	VTK_API.API_vtkXMLReader.ReadFromInputStringOff_0(this);
}


// virtual int CanReadFile(const char * name)
// "virtual int CanReadFile(const char* name)"
public int CanReadFile(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.CanReadFile_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkDataSet* GetOutputAsDataSet()
// "vtkDataSet* GetOutputAsDataSet()"
public vtkDataSet GetOutputAsDataSet() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetOutputAsDataSet_0(out returnPointer, this);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// vtkDataSet* GetOutputAsDataSet(int index)
// "vtkDataSet* GetOutputAsDataSet(int index)"
public vtkDataSet GetOutputAsDataSet(int /*(int)*/ index) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetOutputAsDataSet_1(out returnPointer, this, index);
//	return (vtkDataSet)(IntPtr)returnPointer;
	return (vtkDataSet)(IntPtr)returnPointer;
}


// virtual vtkDataArraySelection* GetPointDataArraySelection()
// "virtual vtkDataArraySelection *GetPointDataArraySelection ()"
public vtkDataArraySelection GetPointDataArraySelection() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetPointDataArraySelection_0(out returnPointer, this);
//	return (vtkDataArraySelection)(IntPtr)returnPointer;
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// virtual vtkDataArraySelection* GetCellDataArraySelection()
// "virtual vtkDataArraySelection *GetCellDataArraySelection ()"
public vtkDataArraySelection GetCellDataArraySelection() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetCellDataArraySelection_0(out returnPointer, this);
//	return (vtkDataArraySelection)(IntPtr)returnPointer;
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// virtual vtkDataArraySelection* GetColumnArraySelection()
// "virtual vtkDataArraySelection *GetColumnArraySelection ()"
public vtkDataArraySelection GetColumnArraySelection() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetColumnArraySelection_0(out returnPointer, this);
//	return (vtkDataArraySelection)(IntPtr)returnPointer;
	return (vtkDataArraySelection)(IntPtr)returnPointer;
}


// int GetNumberOfPointArrays()
// "int GetNumberOfPointArrays()"
public int GetNumberOfPointArrays() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetNumberOfPointArrays_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfCellArrays()
// "int GetNumberOfCellArrays()"
public int GetNumberOfCellArrays() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetNumberOfCellArrays_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetNumberOfColumnArrays()
// "int GetNumberOfColumnArrays()"
public int GetNumberOfColumnArrays() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetNumberOfColumnArrays_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// char* GetPointArrayName(int index)
// "const char* GetPointArrayName(int index)"
public string GetPointArrayName(int /*(int)*/ index) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLReader.GetPointArrayName_0(out returnPointer, this, index);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetCellArrayName(int index)
// "const char* GetCellArrayName(int index)"
public string GetCellArrayName(int /*(int)*/ index) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLReader.GetCellArrayName_0(out returnPointer, this, index);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetColumnArrayName(int index)
// "const char* GetColumnArrayName(int index)"
public string GetColumnArrayName(int /*(int)*/ index) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLReader.GetColumnArrayName_0(out returnPointer, this, index);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// int GetPointArrayStatus(const char * name)
// "int GetPointArrayStatus(const char* name)"
public int GetPointArrayStatus(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetPointArrayStatus_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetCellArrayStatus(const char * name)
// "int GetCellArrayStatus(const char* name)"
public int GetCellArrayStatus(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetCellArrayStatus_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetPointArrayStatus(const char * name, int status)
// "void SetPointArrayStatus(const char* name, int status)"
public void SetPointArrayStatus(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkXMLReader.SetPointArrayStatus_0(this, name, status);
}


// void SetCellArrayStatus(const char * name, int status)
// "void SetCellArrayStatus(const char* name, int status)"
public void SetCellArrayStatus(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkXMLReader.SetCellArrayStatus_0(this, name, status);
}


// int GetColumnArrayStatus(const char * name)
// "int GetColumnArrayStatus(const char* name)"
public int GetColumnArrayStatus(string /*(char*)*/ name) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetColumnArrayStatus_0(out returnPointer, this, name);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetColumnArrayStatus(const char * name, int status)
// "void SetColumnArrayStatus(const char* name, int status)"
public void SetColumnArrayStatus(string /*(char*)*/ name, int /*(int)*/ status) {
	VTK_API.API_vtkXMLReader.SetColumnArrayStatus_0(this, name, status);
}


// virtual void SetTimeStep(int _arg)
// "virtual void SetTimeStep (int _arg)"
public void SetTimeStep(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLReader.SetTimeStep_0(this, _arg);
}


// virtual int GetTimeStep()
// "virtual int GetTimeStep ()"
public int GetTimeStep() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetTimeStep_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfTimeSteps()
// "virtual int GetNumberOfTimeSteps ()"
public int GetNumberOfTimeSteps() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLReader.GetNumberOfTimeSteps_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int* GetTimeStepRange()
// "virtual int *GetTimeStepRange ()"
public int[] GetTimeStepRange() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int[] returnPointer = new int[1];
	VTK_API.API_vtkXMLReader.GetTimeStepRange_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void GetTimeStepRange(int & _arg1, int & _arg2)
// "virtual void GetTimeStepRange (int &_arg1, int &_arg2)"
public void GetTimeStepRange(IntPtr /*(int&)*/ _arg1, IntPtr /*(int&)*/ _arg2) {
	VTK_API.API_vtkXMLReader.GetTimeStepRange_1(this, _arg1, _arg2);
}


// virtual void GetTimeStepRange(int _arg[2])
// "virtual void GetTimeStepRange (int _arg[2])"
public void GetTimeStepRange(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkXMLReader.GetTimeStepRange_2(this, _arg);
}


// virtual void SetTimeStepRange(int _arg1, int _arg2)
// "virtual void SetTimeStepRange (int _arg1, int _arg2)"
public void SetTimeStepRange(int /*(int)*/ _arg1, int /*(int)*/ _arg2) {
	VTK_API.API_vtkXMLReader.SetTimeStepRange_0(this, _arg1, _arg2);
}


// void SetTimeStepRange(int _arg[2])
// "void SetTimeStepRange (int _arg[2])"
public void SetTimeStepRange(int /*(int[2])*/ []_arg) {
	VTK_API.API_vtkXMLReader.SetTimeStepRange_1(this, _arg);
}


// vtkXMLDataParser* GetXMLParser()
// "vtkXMLDataParser* GetXMLParser()"
public vtkXMLDataParser GetXMLParser() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetXMLParser_0(out returnPointer, this);
//	return (vtkXMLDataParser)(IntPtr)returnPointer;
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// void SetReaderErrorObserver(vtkCommand * ARG_0)
// "void SetReaderErrorObserver(vtkCommand *)"
public void SetReaderErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkXMLReader.SetReaderErrorObserver_0(this, ARG_0);
}


// virtual vtkCommand* GetReaderErrorObserver()
// "virtual vtkCommand *GetReaderErrorObserver ()"
public vtkCommand GetReaderErrorObserver() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetReaderErrorObserver_0(out returnPointer, this);
//	return (vtkCommand)(IntPtr)returnPointer;
	return (vtkCommand)(IntPtr)returnPointer;
}


// void SetParserErrorObserver(vtkCommand * ARG_0)
// "void SetParserErrorObserver(vtkCommand *)"
public void SetParserErrorObserver(vtkCommand /*(vtkCommand*)*/ ARG_0) {
	VTK_API.API_vtkXMLReader.SetParserErrorObserver_0(this, ARG_0);
}


// virtual vtkCommand* GetParserErrorObserver()
// "virtual vtkCommand *GetParserErrorObserver ()"
public vtkCommand GetParserErrorObserver() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLReader.GetParserErrorObserver_0(out returnPointer, this);
//	return (vtkCommand)(IntPtr)returnPointer;
	return (vtkCommand)(IntPtr)returnPointer;
}


}
};
