

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLParser : vtkObject {
		public vtkXMLParser(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLParser(IntPtr p) {return new vtkXMLParser(p);}
		public static implicit operator  IntPtr(vtkXMLParser o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLParser.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLParser.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLParser* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLParser* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLParser SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLParser.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLParser)(IntPtr)returnPointer;
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// vtkXMLParser* NewInstance()
// "vtkXMLParser *NewInstance()"
public vtkXMLParser NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLParser.NewInstance_0(out returnPointer, this);
//	return (vtkXMLParser)(IntPtr)returnPointer;
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// static vtkXMLParser* New()
// "static vtkXMLParser* New()"
public static vtkXMLParser New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLParser.New_0(out returnPointer);
//	return (vtkXMLParser)(IntPtr)returnPointer;
	return (vtkXMLParser)(IntPtr)returnPointer;
}


// vtkTypeInt64 TellG()
// "vtkTypeInt64 TellG()"
public long TellG() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLParser.TellG_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// void SeekG(vtkTypeInt64 position)
// "void SeekG(vtkTypeInt64 position)"
public void SeekG(long /*(vtkTypeInt64)*/ position) {
	VTK_API.API_vtkXMLParser.SeekG_0(this, position);
}


// virtual int Parse()
// "virtual int Parse()"
public int Parse() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.Parse_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int Parse(const char * inputString)
// "virtual int Parse(const char* inputString)"
public int Parse(string /*(char*)*/ inputString) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.Parse_1(out returnPointer, this, inputString);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int Parse(const char * inputString, unsigned int length)
// "virtual int Parse(const char* inputString, unsigned int length)"
public int Parse(string /*(char*)*/ inputString, uint /*(unsigned int)*/ length) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.Parse_2(out returnPointer, this, inputString, length);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int InitializeParser()
// "virtual int InitializeParser()"
public int InitializeParser() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.InitializeParser_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int ParseChunk(const char * inputString, unsigned int length)
// "virtual int ParseChunk(const char* inputString, unsigned int length)"
public int ParseChunk(string /*(char*)*/ inputString, uint /*(unsigned int)*/ length) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.ParseChunk_0(out returnPointer, this, inputString, length);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int CleanupParser()
// "virtual int CleanupParser()"
public int CleanupParser() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.CleanupParser_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetFileName(const char * _arg)
// "virtual void SetFileName (const char* _arg)"
public void SetFileName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetFileName_0(this, _arg);
}


// virtual char* GetFileName()
// "virtual char* GetFileName ()"
public string GetFileName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLParser.GetFileName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetIgnoreCharacterData(int _arg)
// "virtual void SetIgnoreCharacterData (int _arg)"
public void SetIgnoreCharacterData(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetIgnoreCharacterData_0(this, _arg);
}


// virtual int GetIgnoreCharacterData()
// "virtual int GetIgnoreCharacterData ()"
public int GetIgnoreCharacterData() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLParser.GetIgnoreCharacterData_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetEncoding(const char * _arg)
// "virtual void SetEncoding (const char* _arg)"
public void SetEncoding(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLParser.SetEncoding_0(this, _arg);
}


// virtual char* GetEncoding()
// "virtual char* GetEncoding ()"
public string GetEncoding() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLParser.GetEncoding_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


}
};
