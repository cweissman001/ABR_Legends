

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkDataCompressor : vtkObject {
		public vtkDataCompressor(IntPtr p) : base(p) {}
		public static implicit operator  vtkDataCompressor(IntPtr p) {return new vtkDataCompressor(p);}
		public static implicit operator  IntPtr(vtkDataCompressor o) {return o.GetPtr();}

// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataCompressor.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkDataCompressor.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkDataCompressor* SafeDownCast(vtkObjectBase * o)
// "static vtkDataCompressor* SafeDownCast(vtkObjectBase *o)"
public static vtkDataCompressor SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataCompressor.SafeDownCast_0(out returnPointer, o);
//	return (vtkDataCompressor)(IntPtr)returnPointer;
	return (vtkDataCompressor)(IntPtr)returnPointer;
}


// vtkDataCompressor* NewInstance()
// "vtkDataCompressor *NewInstance()"
public vtkDataCompressor NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataCompressor.NewInstance_0(out returnPointer, this);
//	return (vtkDataCompressor)(IntPtr)returnPointer;
	return (vtkDataCompressor)(IntPtr)returnPointer;
}


// virtual size_t GetMaximumCompressionSpace(size_t size)
// "virtual size_t GetMaximumCompressionSpace(size_t size)"
public ulong GetMaximumCompressionSpace(ulong /*(size_t)*/ size) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataCompressor.GetMaximumCompressionSpace_0(out returnPointer, this, size);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char * compressedData, size_t compressionSpace)
// "size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char* compressedData, size_t compressionSpace)"
public ulong Compress(string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize, string /*(unsigned char*)*/ compressedData, ulong /*(size_t)*/ compressionSpace) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataCompressor.Compress_0(out returnPointer, this, uncompressedData, uncompressedSize, compressedData, compressionSpace);
//	return (ulong)returnPointer;
	return returnPointer;
}


// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char * uncompressedData, size_t uncompressedSize)
// "size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char* uncompressedData, size_t uncompressedSize)"
public ulong Uncompress(string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, string /*(unsigned char*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize) {
//	ulong
//	ReturnPointer returnPointer = new ReturnPointer(new ulong());
	ulong returnPointer = new ulong();
	VTK_API.API_vtkDataCompressor.Uncompress_0(out returnPointer, this, compressedData, compressedSize, uncompressedData, uncompressedSize);
//	return (ulong)returnPointer;
	return returnPointer;
}


// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
// "vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)"
public vtkUnsignedCharArray Compress(string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataCompressor.Compress_1(out returnPointer, this, uncompressedData, uncompressedSize);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
// "vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)"
public vtkUnsignedCharArray Uncompress(string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, ulong /*(size_t)*/ uncompressedSize) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkDataCompressor.Uncompress_1(out returnPointer, this, compressedData, compressedSize, uncompressedSize);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// virtual void SetCompressionLevel(int compressionLevel)
// "virtual void SetCompressionLevel(int compressionLevel)"
public void SetCompressionLevel(int /*(int)*/ compressionLevel) {
	VTK_API.API_vtkDataCompressor.SetCompressionLevel_0(this, compressionLevel);
}


// virtual int GetCompressionLevel()
// "virtual int GetCompressionLevel()"
public int GetCompressionLevel() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkDataCompressor.GetCompressionLevel_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


}
};
