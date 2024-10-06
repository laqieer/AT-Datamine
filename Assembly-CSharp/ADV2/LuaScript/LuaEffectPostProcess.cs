// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaEffectPostProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB4")]
  [MoonSharpUserData]
  public class LuaEffectPostProcess : LuaSignal
  {
    [Token(Token = "0x4011315")]
    [FieldOffset(Offset = "0x18")]
    protected Adv2EffectPostProcess advObject;

    [Token(Token = "0x6019400")]
    [Address(RVA = "0x2FF0E30", Offset = "0x2FF0E30", VA = "0x2FF0E30")]
    public LuaEffectPostProcess(Adv2EffectPostProcess instance)
    {
    }

    [Token(Token = "0x6019401")]
    [Address(RVA = "0x2FF0E58", Offset = "0x2FF0E58", VA = "0x2FF0E58")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6019402")]
    [Address(RVA = "0x2FF0E78", Offset = "0x2FF0E78", VA = "0x2FF0E78", Slot = "5")]
    public virtual bool IsActive() => new bool();

    [Token(Token = "0x6019403")]
    [Address(RVA = "0x2FF0E98", Offset = "0x2FF0E98", VA = "0x2FF0E98")]
    public void SetWeight(float weight)
    {
    }

    [Token(Token = "0x6019404")]
    [Address(RVA = "0x2FF0EB4", Offset = "0x2FF0EB4", VA = "0x2FF0EB4")]
    public void SetWeight(float fromWeight, float toWeight, float duration)
    {
    }

    [Token(Token = "0x6019405")]
    [Address(RVA = "0x2FF0ED0", Offset = "0x2FF0ED0", VA = "0x2FF0ED0")]
    public void OnScreenColor(string colorFilterCode, float hueShift, float saturation)
    {
    }

    [Token(Token = "0x6019406")]
    [Address(RVA = "0x2FF1068", Offset = "0x2FF1068", VA = "0x2FF1068")]
    public void OffScreenColor()
    {
    }

    [Token(Token = "0x6019407")]
    [Address(RVA = "0x2FF1168", Offset = "0x2FF1168", VA = "0x2FF1168")]
    public void SetVolumeParamterFloat(string volumeTypeFullName, string fieldName, float value)
    {
    }

    [Token(Token = "0x6019408")]
    [Address(RVA = "0x2FF117C", Offset = "0x2FF117C", VA = "0x2FF117C")]
    public void SetVolumeParamterInt(string volumeTypeFullName, string fieldName, int value)
    {
    }

    [Token(Token = "0x6019409")]
    [Address(RVA = "0x2FF1190", Offset = "0x2FF1190", VA = "0x2FF1190")]
    public void SetVolumeParamterBool(string volumeTypeFullName, string fieldName, bool value)
    {
    }

    [Token(Token = "0x601940A")]
    [Address(RVA = "0x2FF11A8", Offset = "0x2FF11A8", VA = "0x2FF11A8")]
    public void SetVolumeParamterEnum(
      string volumeTypeFullName,
      string fieldTypeName,
      string fieldName,
      string enumTypeName,
      string value)
    {
    }

    [Token(Token = "0x601940B")]
    [Address(RVA = "0x2FF11BC", Offset = "0x2FF11BC", VA = "0x2FF11BC")]
    public void SetVolumeParamterVector2(
      string volumeTypeFullName,
      string fieldName,
      float x,
      float y)
    {
    }

    [Token(Token = "0x601940C")]
    [Address(RVA = "0x2FF11D0", Offset = "0x2FF11D0", VA = "0x2FF11D0")]
    public void SetVolumeParamterVector3(
      string volumeTypeFullName,
      string fieldName,
      float x,
      float y,
      float z)
    {
    }

    [Token(Token = "0x601940D")]
    [Address(RVA = "0x2FF11E4", Offset = "0x2FF11E4", VA = "0x2FF11E4")]
    public void SetVolumeParamterVector4(
      string volumeTypeFullName,
      string fieldName,
      float x,
      float y,
      float z,
      float w)
    {
    }

    [Token(Token = "0x601940E")]
    [Address(RVA = "0x2FF11F8", Offset = "0x2FF11F8", VA = "0x2FF11F8")]
    public void SetVolumeParamterColor(
      string volumeTypeFullName,
      string fieldName,
      string colorCode)
    {
    }

    [Token(Token = "0x601940F")]
    [Address(RVA = "0x2FF125C", Offset = "0x2FF125C", VA = "0x2FF125C")]
    public void OnCameraFrame_ColorFrame(
      string colorCode,
      bool top,
      bool bottom,
      bool left,
      bool right,
      float width,
      float height,
      float smoothness,
      int blendMode)
    {
    }

    [Token(Token = "0x6019410")]
    [Address(RVA = "0x2FF14FC", Offset = "0x2FF14FC", VA = "0x2FF14FC")]
    public void OnCameraFrame_VignetteFrame(
      string colorCode,
      bool topLeft,
      bool topRight,
      bool bottomLeft,
      bool bottomRight,
      float centerX,
      float centerY,
      float intensity,
      float smoothness,
      bool roundness,
      int blendMode)
    {
    }

    [Token(Token = "0x6019411")]
    [Address(RVA = "0x2FF17CC", Offset = "0x2FF17CC", VA = "0x2FF17CC")]
    public void OffCameraFrame()
    {
    }
  }
}
