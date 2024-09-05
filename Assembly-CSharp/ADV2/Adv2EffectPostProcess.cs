// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2EffectPostProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.Effect;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E10")]
  public class Adv2EffectPostProcess : MonoBehaviour
  {
    [Token(Token = "0x401104D")]
    [FieldOffset(Offset = "0x18")]
    private PostProcessBehaviour postprocess;

    [Token(Token = "0x6018FB9")]
    [Address(RVA = "0x2CB8AEC", Offset = "0x2CB8AEC", VA = "0x2CB8AEC")]
    public static Adv2EffectPostProcess Create(string objectName, GameObject addComponent)
    {
      return (Adv2EffectPostProcess) null;
    }

    [Token(Token = "0x6018FBA")]
    [Address(RVA = "0x2CB8B3C", Offset = "0x2CB8B3C", VA = "0x2CB8B3C")]
    public void SetBindObject(GameObject prefab, string layerName)
    {
    }

    [Token(Token = "0x6018FBB")]
    [Address(RVA = "0x2CB8CC4", Offset = "0x2CB8CC4", VA = "0x2CB8CC4")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6018FBC")]
    [Address(RVA = "0x2CB8D68", Offset = "0x2CB8D68", VA = "0x2CB8D68", Slot = "4")]
    public virtual bool IsActive() => new bool();

    [Token(Token = "0x6018FBD")]
    [Address(RVA = "0x2CB8DFC", Offset = "0x2CB8DFC", VA = "0x2CB8DFC")]
    public void SetWeight(float weight)
    {
    }

    [Token(Token = "0x6018FBE")]
    [Address(RVA = "0x2CB8EA0", Offset = "0x2CB8EA0", VA = "0x2CB8EA0")]
    public void SetWeight(float fromWeight, float toWeight, float duration)
    {
    }

    [Token(Token = "0x6018FBF")]
    [Address(RVA = "0x2CB8F64", Offset = "0x2CB8F64", VA = "0x2CB8F64")]
    public void SetVolumeParamterFloat(string volumeTypeFullName, string fieldName, float value)
    {
    }

    [Token(Token = "0x6018FC0")]
    [Address(RVA = "0x2CB8F78", Offset = "0x2CB8F78", VA = "0x2CB8F78")]
    public void SetVolumeParamterInt(string volumeTypeFullName, string fieldName, int value)
    {
    }

    [Token(Token = "0x6018FC1")]
    [Address(RVA = "0x2CB8F8C", Offset = "0x2CB8F8C", VA = "0x2CB8F8C")]
    public void SetVolumeParamterBool(string volumeTypeFullName, string fieldName, bool value)
    {
    }

    [Token(Token = "0x6018FC2")]
    [Address(RVA = "0x2CB8FA4", Offset = "0x2CB8FA4", VA = "0x2CB8FA4")]
    public void SetVolumeParamterEnum(
      string volumeTypeFullName,
      string fieldTypeName,
      string fieldName,
      string enumTypeName,
      string value)
    {
    }

    [Token(Token = "0x6018FC3")]
    [Address(RVA = "0x2CB8FB8", Offset = "0x2CB8FB8", VA = "0x2CB8FB8")]
    public void SetVolumeParamterVector2(
      string volumeTypeFullName,
      string fieldName,
      Vector2 value)
    {
    }

    [Token(Token = "0x6018FC4")]
    [Address(RVA = "0x2CB8FCC", Offset = "0x2CB8FCC", VA = "0x2CB8FCC")]
    public void SetVolumeParamterVector3(
      string volumeTypeFullName,
      string fieldName,
      Vector3 value)
    {
    }

    [Token(Token = "0x6018FC5")]
    [Address(RVA = "0x2CB8FE0", Offset = "0x2CB8FE0", VA = "0x2CB8FE0")]
    public void SetVolumeParamterVector4(
      string volumeTypeFullName,
      string fieldName,
      Vector4 value)
    {
    }

    [Token(Token = "0x6018FC6")]
    [Address(RVA = "0x2CB8FF4", Offset = "0x2CB8FF4", VA = "0x2CB8FF4")]
    public void SetVolumeParamterColor(string volumeTypeFullName, string fieldName, Color value)
    {
    }

    [Token(Token = "0x6018FC7")]
    public T GetVolumeComponent<T>() where T : VolumeComponent => (T) null;

    [Token(Token = "0x6018FC8")]
    [Address(RVA = "0x2CB9008", Offset = "0x2CB9008", VA = "0x2CB9008")]
    public Adv2EffectPostProcess()
    {
    }
  }
}
