// Decompiled with JetBrains decompiler
// Type: ADV2.Effect.PostProcessBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ADV2.Effect
{
  [Token(Token = "0x2003E99")]
  public class PostProcessBehaviour : EffectBehaviourBase
  {
    [Token(Token = "0x40112AF")]
    [FieldOffset(Offset = "0x18")]
    private Volume entity;
    [Token(Token = "0x40112B0")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, VolumeComponent> VolumeTypeStrToComponentCache;

    [Token(Token = "0x170051BE")]
    public Volume volume
    {
      [Token(Token = "0x601931D"), Address(RVA = "0x2D03FB8", Offset = "0x2D03FB8", VA = "0x2D03FB8")] get
      {
        return (Volume) null;
      }
    }

    [Token(Token = "0x601931E")]
    [Address(RVA = "0x2D04050", Offset = "0x2D04050", VA = "0x2D04050")]
    public void SetWeight(float weight)
    {
    }

    [Token(Token = "0x601931F")]
    [Address(RVA = "0x2D0408C", Offset = "0x2D0408C", VA = "0x2D0408C")]
    public void SetWeight(float from, float to, float sec)
    {
    }

    [Token(Token = "0x6019320")]
    public T GetVolumeComponent<T>() where T : VolumeComponent => (T) null;

    [Token(Token = "0x6019321")]
    [Address(RVA = "0x2D0415C", Offset = "0x2D0415C", VA = "0x2D0415C")]
    public void SetVolumeParamterFloat(string volumeComponentType, string fieldName, float value)
    {
    }

    [Token(Token = "0x6019322")]
    [Address(RVA = "0x2D04374", Offset = "0x2D04374", VA = "0x2D04374")]
    public void SetVolumeParamterInt(string volumeComponentType, string fieldName, int value)
    {
    }

    [Token(Token = "0x6019323")]
    [Address(RVA = "0x2D04454", Offset = "0x2D04454", VA = "0x2D04454")]
    public void SetVolumeParamterBool(string volumeComponentType, string fieldName, bool value)
    {
    }

    [Token(Token = "0x6019324")]
    [Address(RVA = "0x2D04534", Offset = "0x2D04534", VA = "0x2D04534")]
    public void SetVolumeParamterEnum(
      string volumeComponentType,
      string fieldTypeName,
      string fieldName,
      string enumTypeName,
      string enumValue)
    {
    }

    [Token(Token = "0x6019325")]
    [Address(RVA = "0x2D04960", Offset = "0x2D04960", VA = "0x2D04960")]
    public void SetVolumeParamterVector2(
      string volumeComponentType,
      string fieldName,
      Vector2 value)
    {
    }

    [Token(Token = "0x6019326")]
    [Address(RVA = "0x2D04A48", Offset = "0x2D04A48", VA = "0x2D04A48")]
    public void SetVolumeParamterVector3(
      string volumeComponentType,
      string fieldName,
      Vector3 value)
    {
    }

    [Token(Token = "0x6019327")]
    [Address(RVA = "0x2D04B44", Offset = "0x2D04B44", VA = "0x2D04B44")]
    public void SetVolumeParamterVector4(
      string volumeComponentType,
      string fieldName,
      Vector4 value)
    {
    }

    [Token(Token = "0x6019328")]
    [Address(RVA = "0x2D04C48", Offset = "0x2D04C48", VA = "0x2D04C48")]
    public void SetVolumeParamterColor(string volumeComponentType, string fieldName, Color value)
    {
    }

    [Token(Token = "0x6019329")]
    [Address(RVA = "0x2D040D0", Offset = "0x2D040D0", VA = "0x2D040D0")]
    private IEnumerator LinearWeight(float from, float to, float sec) => (IEnumerator) null;

    [Token(Token = "0x601932A")]
    [Address(RVA = "0x2D0423C", Offset = "0x2D0423C", VA = "0x2D0423C")]
    private VolumeComponent GetVolumeComponentFromTypeStr(string volumeComponentType)
    {
      return (VolumeComponent) null;
    }

    [Token(Token = "0x601932B")]
    [Address(RVA = "0x2D04860", Offset = "0x2D04860", VA = "0x2D04860")]
    private static System.Type GetType(string typeString) => (System.Type) null;

    [Token(Token = "0x601932C")]
    private static T GetField<T>(object obj, string propName) => (T) null;

    [Token(Token = "0x601932D")]
    [Address(RVA = "0x2D046F8", Offset = "0x2D046F8", VA = "0x2D046F8")]
    private static object GetField(object obj, string propName) => (object) null;

    [Token(Token = "0x601932E")]
    [Address(RVA = "0x2D04D74", Offset = "0x2D04D74", VA = "0x2D04D74")]
    public PostProcessBehaviour()
    {
    }
  }
}
