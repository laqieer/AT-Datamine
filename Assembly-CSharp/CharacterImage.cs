// Decompiled with JetBrains decompiler
// Type: CharacterImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001CB")]
public class CharacterImage : MonoBehaviour
{
  [Token(Token = "0x4000AD3")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Image image;

  [Token(Token = "0x6000BAA")]
  [Address(RVA = "0x4C701C0", Offset = "0x4C701C0", VA = "0x4C701C0")]
  public static string GetImageAssetBundleName(int styleId, CharacterImageTypeEnum imageType)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BAB")]
  [Address(RVA = "0x4C702D8", Offset = "0x4C702D8", VA = "0x4C702D8")]
  public static string GetImageAssetName(int styleId, CharacterImageTypeEnum imageType)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BAC")]
  [Address(RVA = "0x4C703F0", Offset = "0x4C703F0", VA = "0x4C703F0")]
  public void Load(int styleId, CharacterImageTypeEnum imageType)
  {
  }

  [Token(Token = "0x6000BAD")]
  [Address(RVA = "0x4C70500", Offset = "0x4C70500", VA = "0x4C70500")]
  public void Set(Sprite sprite)
  {
  }

  [Token(Token = "0x6000BAE")]
  [Address(RVA = "0x4C7051C", Offset = "0x4C7051C", VA = "0x4C7051C")]
  public CharacterImage()
  {
  }
}
