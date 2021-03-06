

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkXMLDataElement : vtkObject {
		public vtkXMLDataElement(IntPtr p) : base(p) {}
		public static implicit operator  vtkXMLDataElement(IntPtr p) {return new vtkXMLDataElement(p);}
		public static implicit operator  IntPtr(vtkXMLDataElement o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLDataElement.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkXMLDataElement.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkXMLDataElement* SafeDownCast(vtkObjectBase * o)
// "static vtkXMLDataElement* SafeDownCast(vtkObjectBase *o)"
public static vtkXMLDataElement SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.SafeDownCast_0(out returnPointer, o);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// vtkXMLDataElement* NewInstance()
// "vtkXMLDataElement *NewInstance()"
public vtkXMLDataElement NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.NewInstance_0(out returnPointer, this);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// static vtkXMLDataElement* New()
// "static vtkXMLDataElement* New()"
public static vtkXMLDataElement New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.New_0(out returnPointer);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// virtual char* GetName()
// "virtual char* GetName ()"
public string GetName() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLDataElement.GetName_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetName(const char * _arg)
// "virtual void SetName (const char* _arg)"
public void SetName(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLDataElement.SetName_0(this, _arg);
}


// virtual char* GetId()
// "virtual char* GetId ()"
public string GetId() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLDataElement.GetId_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void SetId(const char * _arg)
// "virtual void SetId (const char* _arg)"
public void SetId(string /*(char*)*/ _arg) {
	VTK_API.API_vtkXMLDataElement.SetId_0(this, _arg);
}


// char* GetAttribute(const char * name)
// "const char* GetAttribute(const char* name)"
public string GetAttribute(string /*(char*)*/ name) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLDataElement.GetAttribute_0(out returnPointer, this, name);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// void SetAttribute(const char * name, const char * value)
// "void SetAttribute(const char* name, const char* value)"
public void SetAttribute(string /*(char*)*/ name, string /*(char*)*/ value) {
	VTK_API.API_vtkXMLDataElement.SetAttribute_0(this, name, value);
}


// void SetCharacterData(const char * c, int length)
// "void SetCharacterData(const char* c, int length)"
public void SetCharacterData(string /*(char*)*/ c, int /*(int)*/ length) {
	VTK_API.API_vtkXMLDataElement.SetCharacterData_0(this, c, length);
}


// void AddCharacterData(const char * c, size_t length)
// "void AddCharacterData(const char* c, size_t length)"
public void AddCharacterData(string /*(char*)*/ c, ulong /*(size_t)*/ length) {
	VTK_API.API_vtkXMLDataElement.AddCharacterData_0(this, c, length);
}


// virtual char* GetCharacterData()
// "virtual char* GetCharacterData ()"
public string GetCharacterData() {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLDataElement.GetCharacterData_0(out returnPointer, this);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// int GetScalarAttribute(const char * name, int & value)
// "int GetScalarAttribute(const char* name, int& value)"
public int GetScalarAttribute(string /*(char*)*/ name, IntPtr /*(int&)*/ value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetScalarAttribute_0(out returnPointer, this, name, value);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetIntAttribute(const char * name, int value)
// "void SetIntAttribute(const char* name, int value)"
public void SetIntAttribute(string /*(char*)*/ name, int /*(int)*/ value) {
	VTK_API.API_vtkXMLDataElement.SetIntAttribute_0(this, name, value);
}


// void SetFloatAttribute(const char * name, float value)
// "void SetFloatAttribute(const char* name, float value)"
public void SetFloatAttribute(string /*(char*)*/ name, float /*(float)*/ value) {
	VTK_API.API_vtkXMLDataElement.SetFloatAttribute_0(this, name, value);
}


// void SetDoubleAttribute(const char * name, double value)
// "void SetDoubleAttribute(const char* name, double value)"
public void SetDoubleAttribute(string /*(char*)*/ name, double /*(double)*/ value) {
	VTK_API.API_vtkXMLDataElement.SetDoubleAttribute_0(this, name, value);
}


// void SetUnsignedLongAttribute(const char * name, unsigned long value)
// "void SetUnsignedLongAttribute(const char* name, unsigned long value)"
public void SetUnsignedLongAttribute(string /*(char*)*/ name, ulong /*(unsigned long)*/ value) {
	VTK_API.API_vtkXMLDataElement.SetUnsignedLongAttribute_0(this, name, value);
}


// int GetVectorAttribute(const char * name, int length, int * value)
// "int GetVectorAttribute(const char* name, int length, int* value)"
public int GetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, int /*(int*)*/ []value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetVectorAttribute_0(out returnPointer, this, name, length, value);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetVectorAttribute(const char * name, int length, float * value)
// "int GetVectorAttribute(const char* name, int length, float* value)"
public int GetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, float /*(float*)*/ []value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetVectorAttribute_1(out returnPointer, this, name, length, value);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetVectorAttribute(const char * name, int length, double * value)
// "int GetVectorAttribute(const char* name, int length, double* value)"
public int GetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, double /*(double*)*/ []value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetVectorAttribute_2(out returnPointer, this, name, length, value);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetVectorAttribute(const char * name, int length, long * value)
// "int GetVectorAttribute(const char* name, int length, long* value)"
public int GetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, long /*(long*)*/ []value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetVectorAttribute_3(out returnPointer, this, name, length, value);
//	return (int)returnPointer;
	return returnPointer;
}


// int GetVectorAttribute(const char * name, int length, unsigned long * value)
// "int GetVectorAttribute(const char* name, int length, unsigned long* value)"
public int GetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, ulong /*(unsigned long*)*/ []value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetVectorAttribute_4(out returnPointer, this, name, length, value);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetVectorAttribute(const char * name, int length, const int * value)
// "void SetVectorAttribute(const char* name, int length, const int* value)"
public void SetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, int /*(int*)*/ []value) {
	VTK_API.API_vtkXMLDataElement.SetVectorAttribute_0(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, const float * value)
// "void SetVectorAttribute(const char* name, int length, const float* value)"
public void SetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, float /*(float*)*/ []value) {
	VTK_API.API_vtkXMLDataElement.SetVectorAttribute_1(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, const double * value)
// "void SetVectorAttribute(const char* name, int length, const double* value)"
public void SetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, double /*(double*)*/ []value) {
	VTK_API.API_vtkXMLDataElement.SetVectorAttribute_2(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, const unsigned long * value)
// "void SetVectorAttribute(const char* name, int length, const unsigned long* value)"
public void SetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, ulong /*(unsigned long*)*/ []value) {
	VTK_API.API_vtkXMLDataElement.SetVectorAttribute_3(this, name, length, value);
}


// void SetVectorAttribute(const char * name, int length, long long const* value)
// "void SetVectorAttribute(const char* name, int length, long long const* value)"
public void SetVectorAttribute(string /*(char*)*/ name, int /*(int)*/ length, IntPtr /*(long longconst*)*/ value) {
	VTK_API.API_vtkXMLDataElement.SetVectorAttribute_4(this, name, length, value);
}


// int GetWordTypeAttribute(const char * name, int & value)
// "int GetWordTypeAttribute(const char* name, int& value)"
public int GetWordTypeAttribute(string /*(char*)*/ name, IntPtr /*(int&)*/ value) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetWordTypeAttribute_0(out returnPointer, this, name, value);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetNumberOfAttributes()
// "virtual int GetNumberOfAttributes ()"
public int GetNumberOfAttributes() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetNumberOfAttributes_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// char* GetAttributeName(int idx)
// "const char* GetAttributeName(int idx)"
public string GetAttributeName(int /*(int)*/ idx) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLDataElement.GetAttributeName_0(out returnPointer, this, idx);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// char* GetAttributeValue(int idx)
// "const char* GetAttributeValue(int idx)"
public string GetAttributeValue(int /*(int)*/ idx) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkXMLDataElement.GetAttributeValue_0(out returnPointer, this, idx);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// virtual void RemoveAttribute(const char * name)
// "virtual void RemoveAttribute(const char *name)"
public void RemoveAttribute(string /*(char*)*/ name) {
	VTK_API.API_vtkXMLDataElement.RemoveAttribute_0(this, name);
}


// virtual void RemoveAllAttributes()
// "virtual void RemoveAllAttributes()"
public void RemoveAllAttributes() {
	VTK_API.API_vtkXMLDataElement.RemoveAllAttributes_0(this);
}


// vtkXMLDataElement* GetParent()
// "vtkXMLDataElement* GetParent()"
public vtkXMLDataElement GetParent() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.GetParent_0(out returnPointer, this);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// void SetParent(vtkXMLDataElement * parent)
// "void SetParent(vtkXMLDataElement* parent)"
public void SetParent(vtkXMLDataElement /*(vtkXMLDataElement*)*/ parent) {
	VTK_API.API_vtkXMLDataElement.SetParent_0(this, parent);
}


// virtual vtkXMLDataElement* GetRoot()
// "virtual vtkXMLDataElement* GetRoot()"
public vtkXMLDataElement GetRoot() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.GetRoot_0(out returnPointer, this);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// int GetNumberOfNestedElements()
// "int GetNumberOfNestedElements()"
public int GetNumberOfNestedElements() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetNumberOfNestedElements_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// vtkXMLDataElement* GetNestedElement(int index)
// "vtkXMLDataElement* GetNestedElement(int index)"
public vtkXMLDataElement GetNestedElement(int /*(int)*/ index) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.GetNestedElement_0(out returnPointer, this, index);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// void AddNestedElement(vtkXMLDataElement * element)
// "void AddNestedElement(vtkXMLDataElement* element)"
public void AddNestedElement(vtkXMLDataElement /*(vtkXMLDataElement*)*/ element) {
	VTK_API.API_vtkXMLDataElement.AddNestedElement_0(this, element);
}


// virtual void RemoveNestedElement(vtkXMLDataElement * ARG_0)
// "virtual void RemoveNestedElement(vtkXMLDataElement *)"
public void RemoveNestedElement(vtkXMLDataElement /*(vtkXMLDataElement*)*/ ARG_0) {
	VTK_API.API_vtkXMLDataElement.RemoveNestedElement_0(this, ARG_0);
}


// virtual void RemoveAllNestedElements()
// "virtual void RemoveAllNestedElements()"
public void RemoveAllNestedElements() {
	VTK_API.API_vtkXMLDataElement.RemoveAllNestedElements_0(this);
}


// vtkXMLDataElement* FindNestedElement(const char * id)
// "vtkXMLDataElement* FindNestedElement(const char* id)"
public vtkXMLDataElement FindNestedElement(string /*(char*)*/ id) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.FindNestedElement_0(out returnPointer, this, id);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// vtkXMLDataElement* FindNestedElementWithName(const char * name)
// "vtkXMLDataElement* FindNestedElementWithName(const char* name)"
public vtkXMLDataElement FindNestedElementWithName(string /*(char*)*/ name) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.FindNestedElementWithName_0(out returnPointer, this, name);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// vtkXMLDataElement* FindNestedElementWithNameAndId(const char * name, const char * id)
// "vtkXMLDataElement* FindNestedElementWithNameAndId( const char* name, const char* id)"
public vtkXMLDataElement FindNestedElementWithNameAndId(string /*(char*)*/ name, string /*(char*)*/ id) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.FindNestedElementWithNameAndId_0(out returnPointer, this, name, id);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// vtkXMLDataElement* FindNestedElementWithNameAndAttribute(const char * name, const char * att_name, const char * att_value)
// "vtkXMLDataElement* FindNestedElementWithNameAndAttribute( const char* name, const char* att_name, const char* att_value)"
public vtkXMLDataElement FindNestedElementWithNameAndAttribute(string /*(char*)*/ name, string /*(char*)*/ att_name, string /*(char*)*/ att_value) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.FindNestedElementWithNameAndAttribute_0(out returnPointer, this, name, att_name, att_value);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// vtkXMLDataElement* LookupElementWithName(const char * name)
// "vtkXMLDataElement* LookupElementWithName(const char* name)"
public vtkXMLDataElement LookupElementWithName(string /*(char*)*/ name) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.LookupElementWithName_0(out returnPointer, this, name);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// vtkXMLDataElement* LookupElement(const char * id)
// "vtkXMLDataElement* LookupElement(const char* id)"
public vtkXMLDataElement LookupElement(string /*(char*)*/ id) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkXMLDataElement.LookupElement_0(out returnPointer, this, id);
//	return (vtkXMLDataElement)(IntPtr)returnPointer;
	return (vtkXMLDataElement)(IntPtr)returnPointer;
}


// virtual vtkTypeInt64 GetXMLByteIndex()
// "virtual vtkTypeInt64 GetXMLByteIndex ()"
public long GetXMLByteIndex() {
//	long
//	ReturnPointer returnPointer = new ReturnPointer(new long());
	long returnPointer = new long();
	VTK_API.API_vtkXMLDataElement.GetXMLByteIndex_0(out returnPointer, this);
//	return (long)returnPointer;
	return returnPointer;
}


// virtual void SetXMLByteIndex(vtkTypeInt64 _arg)
// "virtual void SetXMLByteIndex (vtkTypeInt64 _arg)"
public void SetXMLByteIndex(long /*(vtkTypeInt64)*/ _arg) {
	VTK_API.API_vtkXMLDataElement.SetXMLByteIndex_0(this, _arg);
}


// virtual int IsEqualTo(vtkXMLDataElement * elem)
// "virtual int IsEqualTo(vtkXMLDataElement *elem)"
public int IsEqualTo(vtkXMLDataElement /*(vtkXMLDataElement*)*/ elem) {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.IsEqualTo_0(out returnPointer, this, elem);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void DeepCopy(vtkXMLDataElement * elem)
// "virtual void DeepCopy(vtkXMLDataElement *elem)"
public void DeepCopy(vtkXMLDataElement /*(vtkXMLDataElement*)*/ elem) {
	VTK_API.API_vtkXMLDataElement.DeepCopy_0(this, elem);
}


// virtual void SetAttributeEncoding(int _arg)
// "virtual void SetAttributeEncoding (int _arg)"
public void SetAttributeEncoding(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLDataElement.SetAttributeEncoding_0(this, _arg);
}


// virtual int GetAttributeEncodingMinValue()
// "virtual int GetAttributeEncodingMinValue ()"
public int GetAttributeEncodingMinValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetAttributeEncodingMinValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetAttributeEncodingMaxValue()
// "virtual int GetAttributeEncodingMaxValue ()"
public int GetAttributeEncodingMaxValue() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetAttributeEncodingMaxValue_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetAttributeEncoding()
// "virtual int GetAttributeEncoding ()"
public int GetAttributeEncoding() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetAttributeEncoding_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void PrintXML(const char * fname)
// "void PrintXML(const char* fname)"
public void PrintXML(string /*(char*)*/ fname) {
	VTK_API.API_vtkXMLDataElement.PrintXML_0(this, fname);
}


// virtual int GetCharacterDataWidth()
// "virtual int GetCharacterDataWidth ()"
public int GetCharacterDataWidth() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkXMLDataElement.GetCharacterDataWidth_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetCharacterDataWidth(int _arg)
// "virtual void SetCharacterDataWidth (int _arg)"
public void SetCharacterDataWidth(int /*(int)*/ _arg) {
	VTK_API.API_vtkXMLDataElement.SetCharacterDataWidth_0(this, _arg);
}


}
};
