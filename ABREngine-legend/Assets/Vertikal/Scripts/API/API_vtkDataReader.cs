
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace VTK_API {
class API_vtkDataReader {

// static vtkDataReader* New()
// static vtkDataReader *New()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_New_0")] public static extern 
bool New_0(out IntPtr /*(vtkDataReader*)*/ return_value);

// static vtkTypeBool IsTypeOf(const char * type)
// static vtkTypeBool IsTypeOf(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsTypeOf_0")] public static extern 
bool IsTypeOf_0(out bool /*(vtkTypeBool)*/ return_value, string /*(char*)*/ type);

// vtkTypeBool IsA(const char * type)
// vtkTypeBool IsA(const char *type)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsA_0")] public static extern 
bool IsA_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ type);

// static vtkDataReader* SafeDownCast(vtkObjectBase * o)
// static vtkDataReader* SafeDownCast(vtkObjectBase *o)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SafeDownCast_0")] public static extern 
bool SafeDownCast_0(out IntPtr /*(vtkDataReader*)*/ return_value, IntPtr /*(vtkObjectBase*)*/ o);

// vtkDataReader* NewInstance()
// vtkDataReader *NewInstance()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_NewInstance_0")] public static extern 
bool NewInstance_0(out IntPtr /*(vtkDataReader*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// void SetFileName(const char * fname)
// void SetFileName(const char* fname)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetFileName_0")] public static extern 
bool SetFileName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ fname);

// char* GetFileName()
// const char* GetFileName()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFileName_0")] public static extern 
bool GetFileName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// char* GetFileName(int i)
// const char* GetFileName(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFileName_1")] public static extern 
bool GetFileName_1(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// int IsFileValid(const char * dstype)
// int IsFileValid(const char *dstype)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsFileValid_0")] public static extern 
bool IsFileValid_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ dstype);

// int IsFileStructuredPoints()
// int IsFileStructuredPoints()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsFileStructuredPoints_0")] public static extern 
bool IsFileStructuredPoints_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int IsFilePolyData()
// int IsFilePolyData()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsFilePolyData_0")] public static extern 
bool IsFilePolyData_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int IsFileStructuredGrid()
// int IsFileStructuredGrid()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsFileStructuredGrid_0")] public static extern 
bool IsFileStructuredGrid_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int IsFileUnstructuredGrid()
// int IsFileUnstructuredGrid()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsFileUnstructuredGrid_0")] public static extern 
bool IsFileUnstructuredGrid_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int IsFileRectilinearGrid()
// int IsFileRectilinearGrid()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_IsFileRectilinearGrid_0")] public static extern 
bool IsFileRectilinearGrid_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// void SetInputString(const char * in)
// void SetInputString(const char *in)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetInputString_0")] public static extern 
bool SetInputString_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ in_var);

// virtual char* GetInputString()
// virtual char* GetInputString ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetInputString_0")] public static extern 
bool GetInputString_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// void SetInputString(const char * in, int len)
// void SetInputString(const char *in, int len)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetInputString_1")] public static extern 
bool SetInputString_1(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ in_var, int /*(int)*/ len);

// virtual int GetInputStringLength()
// virtual int GetInputStringLength ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetInputStringLength_0")] public static extern 
bool GetInputStringLength_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// void SetBinaryInputString(const char * ARG_0, int len)
// void SetBinaryInputString(const char *, int len)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetBinaryInputString_0")] public static extern 
bool SetBinaryInputString_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ ARG_0, int /*(int)*/ len);

// void SetInputString(const vtkStdString & input)
// void SetInputString(const vtkStdString& input)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetInputString_2")] public static extern 
bool SetInputString_2(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(vtkStdString&)*/ input);

// virtual void SetInputArray(vtkCharArray * ARG_0)
// virtual void SetInputArray(vtkCharArray*)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetInputArray_0")] public static extern 
bool SetInputArray_0(IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkCharArray*)*/ ARG_0);

// virtual vtkCharArray* GetInputArray()
// virtual vtkCharArray *GetInputArray ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetInputArray_0")] public static extern 
bool GetInputArray_0(out IntPtr /*(vtkCharArray*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual char* GetHeader()
// virtual char* GetHeader ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetHeader_0")] public static extern 
bool GetHeader_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadFromInputString(vtkTypeBool _arg)
// virtual void SetReadFromInputString (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadFromInputString_0")] public static extern 
bool SetReadFromInputString_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadFromInputString()
// virtual vtkTypeBool GetReadFromInputString ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadFromInputString_0")] public static extern 
bool GetReadFromInputString_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadFromInputStringOn()
// virtual void ReadFromInputStringOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadFromInputStringOn_0")] public static extern 
bool ReadFromInputStringOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadFromInputStringOff()
// virtual void ReadFromInputStringOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadFromInputStringOff_0")] public static extern 
bool ReadFromInputStringOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual int GetFileType()
// virtual int GetFileType ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFileType_0")] public static extern 
bool GetFileType_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int GetNumberOfScalarsInFile()
// int GetNumberOfScalarsInFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNumberOfScalarsInFile_0")] public static extern 
bool GetNumberOfScalarsInFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int GetNumberOfVectorsInFile()
// int GetNumberOfVectorsInFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNumberOfVectorsInFile_0")] public static extern 
bool GetNumberOfVectorsInFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int GetNumberOfTensorsInFile()
// int GetNumberOfTensorsInFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNumberOfTensorsInFile_0")] public static extern 
bool GetNumberOfTensorsInFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int GetNumberOfNormalsInFile()
// int GetNumberOfNormalsInFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNumberOfNormalsInFile_0")] public static extern 
bool GetNumberOfNormalsInFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int GetNumberOfTCoordsInFile()
// int GetNumberOfTCoordsInFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNumberOfTCoordsInFile_0")] public static extern 
bool GetNumberOfTCoordsInFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int GetNumberOfFieldDataInFile()
// int GetNumberOfFieldDataInFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNumberOfFieldDataInFile_0")] public static extern 
bool GetNumberOfFieldDataInFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// char* GetScalarsNameInFile(int i)
// const char *GetScalarsNameInFile(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetScalarsNameInFile_0")] public static extern 
bool GetScalarsNameInFile_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// char* GetVectorsNameInFile(int i)
// const char *GetVectorsNameInFile(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetVectorsNameInFile_0")] public static extern 
bool GetVectorsNameInFile_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// char* GetTensorsNameInFile(int i)
// const char *GetTensorsNameInFile(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetTensorsNameInFile_0")] public static extern 
bool GetTensorsNameInFile_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// char* GetNormalsNameInFile(int i)
// const char *GetNormalsNameInFile(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNormalsNameInFile_0")] public static extern 
bool GetNormalsNameInFile_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// char* GetTCoordsNameInFile(int i)
// const char *GetTCoordsNameInFile(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetTCoordsNameInFile_0")] public static extern 
bool GetTCoordsNameInFile_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// char* GetFieldDataNameInFile(int i)
// const char *GetFieldDataNameInFile(int i)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFieldDataNameInFile_0")] public static extern 
bool GetFieldDataNameInFile_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ i);

// virtual void SetScalarsName(const char * _arg)
// virtual void SetScalarsName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetScalarsName_0")] public static extern 
bool SetScalarsName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetScalarsName()
// virtual char* GetScalarsName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetScalarsName_0")] public static extern 
bool GetScalarsName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetVectorsName(const char * _arg)
// virtual void SetVectorsName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetVectorsName_0")] public static extern 
bool SetVectorsName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetVectorsName()
// virtual char* GetVectorsName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetVectorsName_0")] public static extern 
bool GetVectorsName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetTensorsName(const char * _arg)
// virtual void SetTensorsName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetTensorsName_0")] public static extern 
bool SetTensorsName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetTensorsName()
// virtual char* GetTensorsName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetTensorsName_0")] public static extern 
bool GetTensorsName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetNormalsName(const char * _arg)
// virtual void SetNormalsName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetNormalsName_0")] public static extern 
bool SetNormalsName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetNormalsName()
// virtual char* GetNormalsName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetNormalsName_0")] public static extern 
bool GetNormalsName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetTCoordsName(const char * _arg)
// virtual void SetTCoordsName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetTCoordsName_0")] public static extern 
bool SetTCoordsName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetTCoordsName()
// virtual char* GetTCoordsName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetTCoordsName_0")] public static extern 
bool GetTCoordsName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetLookupTableName(const char * _arg)
// virtual void SetLookupTableName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetLookupTableName_0")] public static extern 
bool SetLookupTableName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetLookupTableName()
// virtual char* GetLookupTableName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetLookupTableName_0")] public static extern 
bool GetLookupTableName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetFieldDataName(const char * _arg)
// virtual void SetFieldDataName (const char* _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetFieldDataName_0")] public static extern 
bool SetFieldDataName_0(IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ _arg);

// virtual char* GetFieldDataName()
// virtual char* GetFieldDataName ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFieldDataName_0")] public static extern 
bool GetFieldDataName_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllScalars(vtkTypeBool _arg)
// virtual void SetReadAllScalars (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllScalars_0")] public static extern 
bool SetReadAllScalars_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllScalars()
// virtual vtkTypeBool GetReadAllScalars ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllScalars_0")] public static extern 
bool GetReadAllScalars_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllScalarsOn()
// virtual void ReadAllScalarsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllScalarsOn_0")] public static extern 
bool ReadAllScalarsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllScalarsOff()
// virtual void ReadAllScalarsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllScalarsOff_0")] public static extern 
bool ReadAllScalarsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllVectors(vtkTypeBool _arg)
// virtual void SetReadAllVectors (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllVectors_0")] public static extern 
bool SetReadAllVectors_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllVectors()
// virtual vtkTypeBool GetReadAllVectors ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllVectors_0")] public static extern 
bool GetReadAllVectors_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllVectorsOn()
// virtual void ReadAllVectorsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllVectorsOn_0")] public static extern 
bool ReadAllVectorsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllVectorsOff()
// virtual void ReadAllVectorsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllVectorsOff_0")] public static extern 
bool ReadAllVectorsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllNormals(vtkTypeBool _arg)
// virtual void SetReadAllNormals (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllNormals_0")] public static extern 
bool SetReadAllNormals_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllNormals()
// virtual vtkTypeBool GetReadAllNormals ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllNormals_0")] public static extern 
bool GetReadAllNormals_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllNormalsOn()
// virtual void ReadAllNormalsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllNormalsOn_0")] public static extern 
bool ReadAllNormalsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllNormalsOff()
// virtual void ReadAllNormalsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllNormalsOff_0")] public static extern 
bool ReadAllNormalsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllTensors(vtkTypeBool _arg)
// virtual void SetReadAllTensors (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllTensors_0")] public static extern 
bool SetReadAllTensors_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllTensors()
// virtual vtkTypeBool GetReadAllTensors ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllTensors_0")] public static extern 
bool GetReadAllTensors_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllTensorsOn()
// virtual void ReadAllTensorsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllTensorsOn_0")] public static extern 
bool ReadAllTensorsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllTensorsOff()
// virtual void ReadAllTensorsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllTensorsOff_0")] public static extern 
bool ReadAllTensorsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllColorScalars(vtkTypeBool _arg)
// virtual void SetReadAllColorScalars (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllColorScalars_0")] public static extern 
bool SetReadAllColorScalars_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllColorScalars()
// virtual vtkTypeBool GetReadAllColorScalars ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllColorScalars_0")] public static extern 
bool GetReadAllColorScalars_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllColorScalarsOn()
// virtual void ReadAllColorScalarsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllColorScalarsOn_0")] public static extern 
bool ReadAllColorScalarsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllColorScalarsOff()
// virtual void ReadAllColorScalarsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllColorScalarsOff_0")] public static extern 
bool ReadAllColorScalarsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllTCoords(vtkTypeBool _arg)
// virtual void SetReadAllTCoords (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllTCoords_0")] public static extern 
bool SetReadAllTCoords_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllTCoords()
// virtual vtkTypeBool GetReadAllTCoords ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllTCoords_0")] public static extern 
bool GetReadAllTCoords_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllTCoordsOn()
// virtual void ReadAllTCoordsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllTCoordsOn_0")] public static extern 
bool ReadAllTCoordsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllTCoordsOff()
// virtual void ReadAllTCoordsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllTCoordsOff_0")] public static extern 
bool ReadAllTCoordsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void SetReadAllFields(vtkTypeBool _arg)
// virtual void SetReadAllFields (vtkTypeBool _arg)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_SetReadAllFields_0")] public static extern 
bool SetReadAllFields_0(IntPtr /*(vtkDataReader*)*/ callingObject, bool /*(vtkTypeBool)*/ _arg);

// virtual vtkTypeBool GetReadAllFields()
// virtual vtkTypeBool GetReadAllFields ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetReadAllFields_0")] public static extern 
bool GetReadAllFields_0(out bool /*(vtkTypeBool)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllFieldsOn()
// virtual void ReadAllFieldsOn ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllFieldsOn_0")] public static extern 
bool ReadAllFieldsOn_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual void ReadAllFieldsOff()
// virtual void ReadAllFieldsOff ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadAllFieldsOff_0")] public static extern 
bool ReadAllFieldsOff_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// int OpenVTKFile(const char * fname = nullptr)
// int OpenVTKFile(const char* fname = nullptr)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_OpenVTKFile_0")] public static extern 
bool OpenVTKFile_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ fname);

// int ReadHeader(const char * fname = nullptr)
// int ReadHeader(const char* fname = nullptr)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadHeader_0")] public static extern 
bool ReadHeader_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ fname);

// int ReadCellData(vtkDataSet * ds, vtkIdType numCells)
// int ReadCellData(vtkDataSet *ds, vtkIdType numCells)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadCellData_0")] public static extern 
bool ReadCellData_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds, long /*(vtkIdType)*/ numCells);

// int ReadPointData(vtkDataSet * ds, vtkIdType numPts)
// int ReadPointData(vtkDataSet *ds, vtkIdType numPts)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadPointData_0")] public static extern 
bool ReadPointData_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkDataSet*)*/ ds, long /*(vtkIdType)*/ numPts);

// int ReadPointCoordinates(vtkPointSet * ps, vtkIdType numPts)
// int ReadPointCoordinates(vtkPointSet *ps, vtkIdType numPts)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadPointCoordinates_0")] public static extern 
bool ReadPointCoordinates_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkPointSet*)*/ ps, long /*(vtkIdType)*/ numPts);

// int ReadPointCoordinates(vtkGraph * g, vtkIdType numPts)
// int ReadPointCoordinates(vtkGraph *g, vtkIdType numPts)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadPointCoordinates_1")] public static extern 
bool ReadPointCoordinates_1(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ numPts);

// int ReadVertexData(vtkGraph * g, vtkIdType numVertices)
// int ReadVertexData(vtkGraph *g, vtkIdType numVertices)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadVertexData_0")] public static extern 
bool ReadVertexData_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ numVertices);

// int ReadEdgeData(vtkGraph * g, vtkIdType numEdges)
// int ReadEdgeData(vtkGraph *g, vtkIdType numEdges)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadEdgeData_0")] public static extern 
bool ReadEdgeData_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkGraph*)*/ g, long /*(vtkIdType)*/ numEdges);

// int ReadRowData(vtkTable * t, vtkIdType numEdges)
// int ReadRowData(vtkTable *t, vtkIdType numEdges)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadRowData_0")] public static extern 
bool ReadRowData_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, IntPtr /*(vtkTable*)*/ t, long /*(vtkIdType)*/ numEdges);

// int ReadCells(vtkIdType size, int * data)
// int ReadCells(vtkIdType size, int *data)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadCells_0")] public static extern 
bool ReadCells_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, long /*(vtkIdType)*/ size, int[] /*(int*)*/ data);

// int ReadCells(vtkIdType size, int * data, int skip1, int read2, int skip3)
// int ReadCells(vtkIdType size, int *data, int skip1, int read2, int skip3)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadCells_1")] public static extern 
bool ReadCells_1(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, long /*(vtkIdType)*/ size, int[] /*(int*)*/ data, int /*(int)*/ skip1, int /*(int)*/ read2, int /*(int)*/ skip3);

// vtkAbstractArray* ReadArray(const char * dataType, vtkIdType numTuples, vtkIdType numComp)
// vtkAbstractArray *ReadArray(const char *dataType, vtkIdType numTuples, vtkIdType numComp)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadArray_0")] public static extern 
bool ReadArray_0(out IntPtr /*(vtkAbstractArray*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ dataType, long /*(vtkIdType)*/ numTuples, long /*(vtkIdType)*/ numComp);

// virtual int GetFileMajorVersion()
// virtual int GetFileMajorVersion ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFileMajorVersion_0")] public static extern 
bool GetFileMajorVersion_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// virtual int GetFileMinorVersion()
// virtual int GetFileMinorVersion ()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_GetFileMinorVersion_0")] public static extern 
bool GetFileMinorVersion_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject);

// int Read(char * ARG_0)
// int Read(char *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_0")] public static extern 
bool Read_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ ARG_0);

// int Read(unsigned char * ARG_0)
// int Read(unsigned char *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_1")] public static extern 
bool Read_1(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(unsigned char*)*/ ARG_0);

// int Read(short * ARG_0)
// int Read(short *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_2")] public static extern 
bool Read_2(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, short[] /*(short*)*/ ARG_0);

// int Read(unsigned short * ARG_0)
// int Read(unsigned short *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_3")] public static extern 
bool Read_3(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, short[] /*(unsigned short*)*/ ARG_0);

// int Read(int * ARG_0)
// int Read(int *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_4")] public static extern 
bool Read_4(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int[] /*(int*)*/ ARG_0);

// int Read(unsigned int * ARG_0)
// int Read(unsigned int *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_5")] public static extern 
bool Read_5(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, uint[] /*(unsigned int*)*/ ARG_0);

// int Read(long * ARG_0)
// int Read(long *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_6")] public static extern 
bool Read_6(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, long[] /*(long*)*/ ARG_0);

// int Read(unsigned long * ARG_0)
// int Read(unsigned long *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_7")] public static extern 
bool Read_7(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, ulong[] /*(unsigned long*)*/ ARG_0);

// int Read(long long * result)
// int Read(long long *result)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_8")] public static extern 
bool Read_8(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, long[] /*(long long*)*/ result);

// int Read(unsigned long long * result)
// int Read(unsigned long long *result)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_9")] public static extern 
bool Read_9(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, long[] /*(unsigned long long*)*/ result);

// int Read(float * ARG_0)
// int Read(float *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_10")] public static extern 
bool Read_10(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, float[] /*(float*)*/ ARG_0);

// int Read(double * ARG_0)
// int Read(double *)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Read_11")] public static extern 
bool Read_11(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, double[] /*(double*)*/ ARG_0);

// size_t Peek(char * str, size_t n)
// size_t Peek(char *str, size_t n)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_Peek_0")] public static extern 
bool Peek_0(out ulong /*(size_t)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ str, ulong /*(size_t)*/ n);

// void CloseVTKFile()
// void CloseVTKFile()
[DllImport("vtkplugin", EntryPoint="vtkDataReader_CloseVTKFile_0")] public static extern 
bool CloseVTKFile_0(IntPtr /*(vtkDataReader*)*/ callingObject);

// int ReadLine(char result[256])
// int ReadLine(char result[256])
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadLine_0")] public static extern 
bool ReadLine_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, char /*(char[256])*/ []result);

// int ReadString(char result[256])
// int ReadString(char result[256])
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadString_0")] public static extern 
bool ReadString_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, char /*(char[256])*/ []result);

// char* LowerCase(char * str, const size_t len = 256)
// char *LowerCase(char *str, const size_t len=256)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_LowerCase_0")] public static extern 
bool LowerCase_0(out byte[] /*(char*)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, string /*(char*)*/ str, ulong /*(size_t)*/ len);

// int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject * output)
// int ReadMesh( int piece, int npieces, int nghosts, int timestep, vtkDataObject* output)
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadMesh_0")] public static extern 
bool ReadMesh_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ piece, int /*(int)*/ npieces, int /*(int)*/ nghosts, int /*(int)*/ timestep, IntPtr /*(vtkDataObject*)*/ output);

// int ReadPoints(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkDataObject * ARG_4)
// int ReadPoints( int , int , int , int , vtkDataObject* )
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadPoints_0")] public static extern 
bool ReadPoints_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, IntPtr /*(vtkDataObject*)*/ ARG_4);

// int ReadArrays(int ARG_0, int ARG_1, int ARG_2, int ARG_3, vtkDataObject * ARG_4)
// int ReadArrays( int , int , int , int , vtkDataObject* )
[DllImport("vtkplugin", EntryPoint="vtkDataReader_ReadArrays_0")] public static extern 
bool ReadArrays_0(out int /*(int)*/ return_value, IntPtr /*(vtkDataReader*)*/ callingObject, int /*(int)*/ ARG_0, int /*(int)*/ ARG_1, int /*(int)*/ ARG_2, int /*(int)*/ ARG_3, IntPtr /*(vtkDataObject*)*/ ARG_4);

}
};
