

using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace VTK {
public partial class vtkTexture : vtkImageAlgorithm {
		public vtkTexture(IntPtr p) : base(p) {}
		public static implicit operator  vtkTexture(IntPtr p) {return new vtkTexture(p);}
		public static implicit operator  IntPtr(vtkTexture o) {return o.GetPtr();}

// static vtkTexture* New()
// "static vtkTexture* New()"
public static vtkTexture New() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.New_0(out returnPointer);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// static vtkTypeBool IsTypeOf(const char * type)
// "static vtkTypeBool IsTypeOf(const char *type)"
public static bool IsTypeOf(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.IsTypeOf_0(out returnPointer, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// vtkTypeBool IsA(const char * type)
// "vtkTypeBool IsA(const char *type)"
public bool IsA(string /*(char*)*/ type) {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.IsA_0(out returnPointer, this, type);
//	return (bool)returnPointer;
	return returnPointer;
}


// static vtkTexture* SafeDownCast(vtkObjectBase * o)
// "static vtkTexture* SafeDownCast(vtkObjectBase *o)"
public static vtkTexture SafeDownCast(vtkObjectBase /*(vtkObjectBase*)*/ o) {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.SafeDownCast_0(out returnPointer, o);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// vtkTexture* NewInstance()
// "vtkTexture *NewInstance()"
public vtkTexture NewInstance() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.NewInstance_0(out returnPointer, this);
//	return (vtkTexture)(IntPtr)returnPointer;
	return (vtkTexture)(IntPtr)returnPointer;
}


// virtual void Render(vtkRenderer * ren)
// "virtual void Render(vtkRenderer* ren)"
public void Render(vtkRenderer /*(vtkRenderer*)*/ ren) {
	VTK_API.API_vtkTexture.Render_0(this, ren);
}


// virtual void PostRender(vtkRenderer * ARG_0)
// "virtual void PostRender(vtkRenderer*)"
public void PostRender(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkTexture.PostRender_0(this, ARG_0);
}


// virtual void ReleaseGraphicsResources(vtkWindow * ARG_0)
// "virtual void ReleaseGraphicsResources(vtkWindow*)"
public void ReleaseGraphicsResources(vtkWindow /*(vtkWindow*)*/ ARG_0) {
	VTK_API.API_vtkTexture.ReleaseGraphicsResources_0(this, ARG_0);
}


// virtual void Load(vtkRenderer * ARG_0)
// "virtual void Load(vtkRenderer*)"
public void Load(vtkRenderer /*(vtkRenderer*)*/ ARG_0) {
	VTK_API.API_vtkTexture.Load_0(this, ARG_0);
}


// virtual vtkTypeBool GetRepeat()
// "virtual vtkTypeBool GetRepeat ()"
public bool GetRepeat() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetRepeat_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetRepeat(vtkTypeBool _arg)
// "virtual void SetRepeat (vtkTypeBool _arg)"
public void SetRepeat(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkTexture.SetRepeat_0(this, _arg);
}


// virtual void RepeatOn()
// "virtual void RepeatOn ()"
public void RepeatOn() {
	VTK_API.API_vtkTexture.RepeatOn_0(this);
}


// virtual void RepeatOff()
// "virtual void RepeatOff ()"
public void RepeatOff() {
	VTK_API.API_vtkTexture.RepeatOff_0(this);
}


// virtual vtkTypeBool GetEdgeClamp()
// "virtual vtkTypeBool GetEdgeClamp ()"
public bool GetEdgeClamp() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetEdgeClamp_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetEdgeClamp(vtkTypeBool _arg)
// "virtual void SetEdgeClamp (vtkTypeBool _arg)"
public void SetEdgeClamp(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkTexture.SetEdgeClamp_0(this, _arg);
}


// virtual void EdgeClampOn()
// "virtual void EdgeClampOn ()"
public void EdgeClampOn() {
	VTK_API.API_vtkTexture.EdgeClampOn_0(this);
}


// virtual void EdgeClampOff()
// "virtual void EdgeClampOff ()"
public void EdgeClampOff() {
	VTK_API.API_vtkTexture.EdgeClampOff_0(this);
}


// virtual vtkTypeBool GetInterpolate()
// "virtual vtkTypeBool GetInterpolate ()"
public bool GetInterpolate() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetInterpolate_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetInterpolate(vtkTypeBool _arg)
// "virtual void SetInterpolate (vtkTypeBool _arg)"
public void SetInterpolate(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkTexture.SetInterpolate_0(this, _arg);
}


// virtual void InterpolateOn()
// "virtual void InterpolateOn ()"
public void InterpolateOn() {
	VTK_API.API_vtkTexture.InterpolateOn_0(this);
}


// virtual void InterpolateOff()
// "virtual void InterpolateOff ()"
public void InterpolateOff() {
	VTK_API.API_vtkTexture.InterpolateOff_0(this);
}


// virtual bool GetMipmap()
// "virtual bool GetMipmap ()"
public bool GetMipmap() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetMipmap_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetMipmap(bool _arg)
// "virtual void SetMipmap (bool _arg)"
public void SetMipmap(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkTexture.SetMipmap_0(this, _arg);
}


// virtual void MipmapOn()
// "virtual void MipmapOn ()"
public void MipmapOn() {
	VTK_API.API_vtkTexture.MipmapOn_0(this);
}


// virtual void MipmapOff()
// "virtual void MipmapOff ()"
public void MipmapOff() {
	VTK_API.API_vtkTexture.MipmapOff_0(this);
}


// virtual void SetQuality(int _arg)
// "virtual void SetQuality (int _arg)"
public void SetQuality(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetQuality_0(this, _arg);
}


// virtual int GetQuality()
// "virtual int GetQuality ()"
public int GetQuality() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkTexture.GetQuality_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetQualityToDefault()
// "void SetQualityToDefault()"
public void SetQualityToDefault() {
	VTK_API.API_vtkTexture.SetQualityToDefault_0(this);
}


// void SetQualityTo16Bit()
// "void SetQualityTo16Bit()"
public void SetQualityTo16Bit() {
	VTK_API.API_vtkTexture.SetQualityTo16Bit_0(this);
}


// void SetQualityTo32Bit()
// "void SetQualityTo32Bit()"
public void SetQualityTo32Bit() {
	VTK_API.API_vtkTexture.SetQualityTo32Bit_0(this);
}


// virtual void SetColorMode(int _arg)
// "virtual void SetColorMode (int _arg)"
public void SetColorMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetColorMode_0(this, _arg);
}


// virtual int GetColorMode()
// "virtual int GetColorMode ()"
public int GetColorMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkTexture.GetColorMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// void SetColorModeToDefault()
// "void SetColorModeToDefault()"
public void SetColorModeToDefault() {
	VTK_API.API_vtkTexture.SetColorModeToDefault_0(this);
}


// void SetColorModeToMapScalars()
// "void SetColorModeToMapScalars()"
public void SetColorModeToMapScalars() {
	VTK_API.API_vtkTexture.SetColorModeToMapScalars_0(this);
}


// void SetColorModeToDirectScalars()
// "void SetColorModeToDirectScalars()"
public void SetColorModeToDirectScalars() {
	VTK_API.API_vtkTexture.SetColorModeToDirectScalars_0(this);
}


// vtkImageData* GetInput()
// "vtkImageData* GetInput()"
public vtkImageData GetInput() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.GetInput_0(out returnPointer, this);
//	return (vtkImageData)(IntPtr)returnPointer;
	return (vtkImageData)(IntPtr)returnPointer;
}


// void SetLookupTable(vtkScalarsToColors * ARG_0)
// "void SetLookupTable(vtkScalarsToColors *)"
public void SetLookupTable(vtkScalarsToColors /*(vtkScalarsToColors*)*/ ARG_0) {
	VTK_API.API_vtkTexture.SetLookupTable_0(this, ARG_0);
}


// virtual vtkScalarsToColors* GetLookupTable()
// "virtual vtkScalarsToColors *GetLookupTable ()"
public vtkScalarsToColors GetLookupTable() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.GetLookupTable_0(out returnPointer, this);
//	return (vtkScalarsToColors)(IntPtr)returnPointer;
	return (vtkScalarsToColors)(IntPtr)returnPointer;
}


// virtual vtkUnsignedCharArray* GetMappedScalars()
// "virtual vtkUnsignedCharArray *GetMappedScalars ()"
public vtkUnsignedCharArray GetMappedScalars() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.GetMappedScalars_0(out returnPointer, this);
//	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
	return (vtkUnsignedCharArray)(IntPtr)returnPointer;
}


// char* MapScalarsToColors(vtkDataArray * scalars)
// "unsigned char* MapScalarsToColors(vtkDataArray* scalars)"
public string MapScalarsToColors(vtkDataArray /*(vtkDataArray*)*/ scalars) {
//	string
//	ReturnPointer returnPointer = new ReturnPointer(new string());
	byte[] returnPointer = new byte[512];
	VTK_API.API_vtkTexture.MapScalarsToColors_0(out returnPointer, this, scalars);
//	return (string)returnPointer;
	return (string)System.Text.Encoding.ASCII.GetString(returnPointer);
}


// void SetTransform(vtkTransform * transform)
// "void SetTransform(vtkTransform *transform)"
public void SetTransform(vtkTransform /*(vtkTransform*)*/ transform) {
	VTK_API.API_vtkTexture.SetTransform_0(this, transform);
}


// virtual vtkTransform* GetTransform()
// "virtual vtkTransform *GetTransform ()"
public vtkTransform GetTransform() {
//	IntPtr
//	ReturnPointer returnPointer = new ReturnPointer(new IntPtr());
	IntPtr returnPointer = new IntPtr();
	VTK_API.API_vtkTexture.GetTransform_0(out returnPointer, this);
//	return (vtkTransform)(IntPtr)returnPointer;
	return (vtkTransform)(IntPtr)returnPointer;
}


// virtual int GetBlendingMode()
// "virtual int GetBlendingMode ()"
public int GetBlendingMode() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkTexture.GetBlendingMode_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual void SetBlendingMode(int _arg)
// "virtual void SetBlendingMode (int _arg)"
public void SetBlendingMode(int /*(int)*/ _arg) {
	VTK_API.API_vtkTexture.SetBlendingMode_0(this, _arg);
}


// virtual bool GetPremultipliedAlpha()
// "virtual bool GetPremultipliedAlpha ()"
public bool GetPremultipliedAlpha() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetPremultipliedAlpha_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetPremultipliedAlpha(bool _arg)
// "virtual void SetPremultipliedAlpha (bool _arg)"
public void SetPremultipliedAlpha(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkTexture.SetPremultipliedAlpha_0(this, _arg);
}


// virtual void PremultipliedAlphaOn()
// "virtual void PremultipliedAlphaOn ()"
public void PremultipliedAlphaOn() {
	VTK_API.API_vtkTexture.PremultipliedAlphaOn_0(this);
}


// virtual void PremultipliedAlphaOff()
// "virtual void PremultipliedAlphaOff ()"
public void PremultipliedAlphaOff() {
	VTK_API.API_vtkTexture.PremultipliedAlphaOff_0(this);
}


// virtual vtkTypeBool GetRestrictPowerOf2ImageSmaller()
// "virtual vtkTypeBool GetRestrictPowerOf2ImageSmaller ()"
public bool GetRestrictPowerOf2ImageSmaller() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetRestrictPowerOf2ImageSmaller_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetRestrictPowerOf2ImageSmaller(vtkTypeBool _arg)
// "virtual void SetRestrictPowerOf2ImageSmaller (vtkTypeBool _arg)"
public void SetRestrictPowerOf2ImageSmaller(bool /*(vtkTypeBool)*/ _arg) {
	VTK_API.API_vtkTexture.SetRestrictPowerOf2ImageSmaller_0(this, _arg);
}


// virtual void RestrictPowerOf2ImageSmallerOn()
// "virtual void RestrictPowerOf2ImageSmallerOn ()"
public void RestrictPowerOf2ImageSmallerOn() {
	VTK_API.API_vtkTexture.RestrictPowerOf2ImageSmallerOn_0(this);
}


// virtual void RestrictPowerOf2ImageSmallerOff()
// "virtual void RestrictPowerOf2ImageSmallerOff ()"
public void RestrictPowerOf2ImageSmallerOff() {
	VTK_API.API_vtkTexture.RestrictPowerOf2ImageSmallerOff_0(this);
}


// virtual int IsTranslucent()
// "virtual int IsTranslucent()"
public int IsTranslucent() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkTexture.IsTranslucent_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual int GetTextureUnit()
// "virtual int GetTextureUnit()"
public int GetTextureUnit() {
//	int
//	ReturnPointer returnPointer = new ReturnPointer(new int());
	int returnPointer = new int();
	VTK_API.API_vtkTexture.GetTextureUnit_0(out returnPointer, this);
//	return (int)returnPointer;
	return returnPointer;
}


// virtual bool GetCubeMap()
// "virtual bool GetCubeMap ()"
public bool GetCubeMap() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetCubeMap_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void CubeMapOn()
// "virtual void CubeMapOn ()"
public void CubeMapOn() {
	VTK_API.API_vtkTexture.CubeMapOn_0(this);
}


// virtual void CubeMapOff()
// "virtual void CubeMapOff ()"
public void CubeMapOff() {
	VTK_API.API_vtkTexture.CubeMapOff_0(this);
}


// void SetCubeMap(bool val)
// "void SetCubeMap(bool val)"
public void SetCubeMap(bool /*(bool)*/ val) {
	VTK_API.API_vtkTexture.SetCubeMap_0(this, val);
}


// virtual bool GetUseSRGBColorSpace()
// "virtual bool GetUseSRGBColorSpace ()"
public bool GetUseSRGBColorSpace() {
//	bool
//	ReturnPointer returnPointer = new ReturnPointer(new bool());
	bool returnPointer = new bool();
	VTK_API.API_vtkTexture.GetUseSRGBColorSpace_0(out returnPointer, this);
//	return (bool)returnPointer;
	return returnPointer;
}


// virtual void SetUseSRGBColorSpace(bool _arg)
// "virtual void SetUseSRGBColorSpace (bool _arg)"
public void SetUseSRGBColorSpace(bool /*(bool)*/ _arg) {
	VTK_API.API_vtkTexture.SetUseSRGBColorSpace_0(this, _arg);
}


// virtual void UseSRGBColorSpaceOn()
// "virtual void UseSRGBColorSpaceOn ()"
public void UseSRGBColorSpaceOn() {
	VTK_API.API_vtkTexture.UseSRGBColorSpaceOn_0(this);
}


// virtual void UseSRGBColorSpaceOff()
// "virtual void UseSRGBColorSpaceOff ()"
public void UseSRGBColorSpaceOff() {
	VTK_API.API_vtkTexture.UseSRGBColorSpaceOff_0(this);
}


}
};
