
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataCompressor {

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataCompressor* SafeDownCast(vtkObjectBase * o)
// static vtkDataCompressor* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkDataCompressor*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataCompressor* NewInstance()
// vtkDataCompressor *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkDataCompressor*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject);

// virtual size_t GetMaximumCompressionSpace(size_t size)
// virtual size_t GetMaximumCompressionSpace(size_t size)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_GetMaximumCompressionSpace_0")] public static extern 
bool GetMaximumCompressionSpace_0(out ulong /*(size_t)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, ulong /*(size_t)*/ size);

// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char * compressedData, size_t compressionSpace)
// size_t Compress(unsigned char const* uncompressedData, size_t uncompressedSize, unsigned char* compressedData, size_t compressionSpace)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Compress_0")] public static extern 
bool Compress_0(out ulong /*(size_t)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize, string /*(unsigned char*)*/ compressedData, ulong /*(size_t)*/ compressionSpace);

// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char * uncompressedData, size_t uncompressedSize)
// size_t Uncompress(unsigned char const* compressedData, size_t compressedSize, unsigned char* uncompressedData, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Uncompress_0")] public static extern 
bool Uncompress_0(out ulong /*(size_t)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, string /*(unsigned char*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize);

// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
// vtkUnsignedCharArray* Compress(unsigned char const* uncompressedData, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Compress_1")] public static extern 
bool Compress_1(out IntPtr /*(vtkUnsignedCharArray*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ uncompressedData, ulong /*(size_t)*/ uncompressedSize);

// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
// vtkUnsignedCharArray* Uncompress(unsigned char const* compressedData, size_t compressedSize, size_t uncompressedSize)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_Uncompress_1")] public static extern 
bool Uncompress_1(out IntPtr /*(vtkUnsignedCharArray*)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject, string /*(unsigned charconst*)*/ compressedData, ulong /*(size_t)*/ compressedSize, ulong /*(size_t)*/ uncompressedSize);

// virtual void SetCompressionLevel(int compressionLevel)
// virtual void SetCompressionLevel(int compressionLevel)
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_SetCompressionLevel_0")] public static extern 
bool SetCompressionLevel_0(IntPtr /*(vtkDataCompressor*)*/ callingObject, int /*(int)*/ compressionLevel);

// virtual int GetCompressionLevel()
// virtual int GetCompressionLevel()
[DllImport("vtkplugin", EntryPoint="vtkDataCompressor_GetCompressionLevel_0")] public static extern 
bool GetCompressionLevel_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataCompressor*)*/ callingObject);

}
};
