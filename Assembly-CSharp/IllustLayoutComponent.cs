// Decompiled with JetBrains decompiler
// Type: IllustLayoutComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002DC")]
public class IllustLayoutComponent : MonoBehaviour
{
  [Token(Token = "0x40010A1")]
  [FieldOffset(Offset = "0x18")]
  [Header("描画する領域のGameObject")]
  [SerializeField]
  private Transform anchorObject;
  [Token(Token = "0x40010A2")]
  [FieldOffset(Offset = "0x20")]
  [Header("タグ名")]
  [SerializeField]
  private string tagLabel;
  [Token(Token = "0x40010A3")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  [Header("縦横どちらに合わせるか")]
  private IllustLayoutComponent.MatchMode matchMode;
  [Token(Token = "0x40010A4")]
  [FieldOffset(Offset = "0x2C")]
  public float standardScale;
  [Token(Token = "0x40010A5")]
  [FieldOffset(Offset = "0x30")]
  private IllustLayoutInfo layoutInfo;

  [Token(Token = "0x60011F3")]
  [Address(RVA = "0x27D9FF8", Offset = "0x27D9FF8", VA = "0x27D9FF8")]
  public void Init(IllustLayoutInfo info)
  {
  }

  [Token(Token = "0x60011F4")]
  [Address(RVA = "0x27DA000", Offset = "0x27DA000", VA = "0x27DA000")]
  public void SetTransform(string tag, Transform anchor, IllustLayoutComponent.MatchMode match)
  {
  }

  [Token(Token = "0x60011F5")]
  [Address(RVA = "0x27DA4D0", Offset = "0x27DA4D0", VA = "0x27DA4D0")]
  public void SetTransformForRawImage(
    string tag,
    Transform anchor,
    IllustLayoutComponent.MatchMode match)
  {
  }

  [Token(Token = "0x60011F6")]
  [Address(RVA = "0x27DA8D0", Offset = "0x27DA8D0", VA = "0x27DA8D0")]
  public void SetTransformForDicingImage(
    string tag,
    Transform anchor,
    IllustLayoutComponent.MatchMode match)
  {
  }

  [Token(Token = "0x60011F7")]
  [Address(RVA = "0x27DACD8", Offset = "0x27DACD8", VA = "0x27DACD8")]
  public void SetTransformForDicingImage2(
    string tag,
    Transform anchor,
    IllustLayoutComponent.MatchMode match)
  {
  }

  [Token(Token = "0x60011F8")]
  [Address(RVA = "0x27DAF30", Offset = "0x27DAF30", VA = "0x27DAF30")]
  public void SetTransform()
  {
  }

  [Token(Token = "0x60011F9")]
  [Address(RVA = "0x27DAF3C", Offset = "0x27DAF3C", VA = "0x27DAF3C")]
  public IllustLayoutComponent()
  {
  }

  [Token(Token = "0x20002DD")]
  public enum MatchMode
  {
    [Token(Token = "0x40010A7")] NONE,
    [Token(Token = "0x40010A8")] WIDTH,
    [Token(Token = "0x40010A9")] HEIGHT,
  }
}
