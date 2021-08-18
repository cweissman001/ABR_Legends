

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataParser : vtkXMLParser {
		public vtkXMLDataParser(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLDataParser(IntPtr p) {return new vtkXMLDataParser(p);}
		public static implicit operator  IntPtr(vtkXMLDataParser o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLDataParser.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLDataParser.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLDataParser* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLDataParser* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLDataParser SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataParser.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLDataParser)(IntPtr)returnPointer;
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// vtkXMLDataParser* NewInstance()
// "vtkXMLDataParser *NewInstance()"
public vtkXMLDataParser NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataParser.NewInstance_0(out returnPointer, this);
//	return (vtkXMLDataParser)(IntPtr)returnPointer;
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// static vtkXMLDataParser* New()
// "static vtkXMLDataParser* New()"
public static vtkXMLDataParser New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataParser.New_0(out returnPointer);
//	return (vtkXMLDataParser)(IntPtr)returnPointer;
	return (vtkXMLDataParser)(IntPtr)returnPointer;
}


// vtkXMLDataElement* GetRootElement()
// "vtkXMLDataElement* GetRootElement()"
public vtkXMLDataElement GetRootElement() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataParser.GetRootElement_0(out returnPointer, this);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public ulong ReadInlineData(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.ReadInlineData_0(out returnPointer, this, element, isAscii, buffer, startWord, numWords, wordType);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t ReadInlineData(vtkXMLDataElement * element, int isAscii, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// "size_t ReadInlineData(vtkXMLDataElement* element, int isAscii, char* buffer, vtkTypeUInt64 startWord, size_t numWords)"
public ulong ReadInlineData(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element, int /*(int)*/ isAscii, string /*(char*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.ReadInlineData_1(out returnPointer, this, element, isAscii, buffer, startWord, numWords);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t ReadAppendedData(vtkTypeInt64 offset, void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadAppendedData(vtkTypeInt64 offset, void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public ulong ReadAppendedData(long /*(vtkTypeInt64)*/ offset, IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.ReadAppendedData_0(out returnPointer, this, offset, buffer, startWord, numWords, wordType);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t ReadAppendedData(vtkTypeInt64 offset, char * buffer, vtkTypeUInt64 startWord, size_t numWords)
// "size_t ReadAppendedData(vtkTypeInt64 offset, char* buffer, vtkTypeUInt64 startWord, size_t numWords)"
public ulong ReadAppendedData(long /*(vtkTypeInt64)*/ offset, string /*(char*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.ReadAppendedData_1(out returnPointer, this, offset, buffer, startWord, numWords);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t ReadAsciiData(void * buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)
// "size_t ReadAsciiData(void* buffer, vtkTypeUInt64 startWord, size_t numWords, int wordType)"
public ulong ReadAsciiData(IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ numWords, int /*(int)*/ wordType) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.ReadAsciiData_0(out returnPointer, this, buffer, startWord, numWords, wordType);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t ReadBinaryData(void * buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)
// "size_t ReadBinaryData(void* buffer, vtkTypeUInt64 startWord, size_t maxWords, int wordType)"
public ulong ReadBinaryData(IntPtr /*(void*)*/ buffer, ulong /*(vtkTypeUInt64)*/ startWord, ulong /*(size_t)*/ maxWords, int /*(int)*/ wordType) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.ReadBinaryData_0(out returnPointer, this, buffer, startWord, maxWords, wordType);
//	return (ulong)returnPointer;
	return returnPointer;
}


// virtual void SetCompressor(vtkDataCompressor * ARG_0)
// "virtual void SetCompressor(vtkDataCompressor*)"
public void SetCompressor(vtkDataCompressor /*(vtkDataCompressor*)*/ ARG_0) {
	VTK_API.API_vtkXMLDataParser.SetCompressor_0(this, ARG_0);
}


// virtual vtkDataCompressor* GetCompressor()
// "virtual vtkDataCompressor *GetCompressor ()"
public vtkDataCompressor GetCompressor() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataParser.GetCompressor_0(out returnPointer, this);
//	return (vtkDataCompressor)(IntPtr)returnPointer;
	return (vtkDataCompressor)(IntPtr)returnPointer;
}


// size_t GetWordTypeSize(int wordType)
// "size_t GetWordTypeSize(int wordType)"
public ulong GetWordTypeSize(int /*(int)*/ wordType) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkXMLDataParser.GetWordTypeSize_0(out returnPointer, this, wordType);
//	return (ulong)returnPointer;
	return returnPointer;
}


// int Parse()
// "int Parse()"
public int Parse() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataParser.Parse_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetAbort()
// "virtual int GetAbort ()"
public int GetAbort() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataParser.GetAbort_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetAbort(int _arg)
// "virtual void SetAbort (int _arg)"
public void SetAbort(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLDataParser.SetAbort_0(this, _arg);
}


// virtual float GetProgress()
// "virtual float GetProgress ()"
public float GetProgress() {
//	float
//	ReturnPointer returnPointer = new ReturnPointer(new float());
	float returnPointer = new float();
	VTK_API.API_vtkXMLDataParser.GetProgress_0(out returnPointer, this);
//	return (float)returnPointer;
	return returnPointer;
}


// virtual void SetProgress(float _arg)
// "virtual void SetProgress (float _arg)"
public void SetProgress(float /*(float)*/ _arg) {
	VTK_API.API_vtkXMLDataParser.SetProgress_0(this, _arg);
}


// virtual void SetAttributesEncoding(int _arg)
// "virtual void SetAttributesEncoding (int _arg)"
public void SetAttributesEncoding(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLDataParser.SetAttributesEncoding_0(this, _arg);
}


// virtual int GetAttributesEncodingMinValue()
// "virtual int GetAttributesEncodingMinValue ()"
public int GetAttributesEncodingMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataParser.GetAttributesEncodingMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetAttributesEncodingMaxValue()
// "virtual int GetAttributesEncodingMaxValue ()"
public int GetAttributesEncodingMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataParser.GetAttributesEncodingMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetAttributesEncoding()
// "virtual int GetAttributesEncoding ()"
public int GetAttributesEncoding() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataParser.GetAttributesEncoding_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void CharacterDataHandler(const char * data, int length)
// "void CharacterDataHandler(const char* data, int length)"
public void CharacterDataHandler(string /*(char*)*/ data, int /*(int)*/ length) {
	VTK_API.API_vtkXMLDataParser.CharacterDataHandler_0(this, data, length);
}


// vtkTypeInt64 GetAppendedDataPosition()
// "vtkTypeInt64 GetAppendedDataPosition()"
public long GetAppendedDataPosition() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLDataParser.GetAppendedDataPosition_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


}
};
