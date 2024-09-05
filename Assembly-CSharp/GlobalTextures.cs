// Decompiled with JetBrains decompiler
// Type: GlobalTextures
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000D6")]
[DisallowMultipleComponent]
public class GlobalTextures : MonoBehaviour
{
  [Token(Token = "0x40003A4")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Texture2D conditionTexture;
  [Token(Token = "0x40003A5")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Vector2 conditionTextureTiling;

  [Token(Token = "0x600063A")]
  [Address(RVA = "0x4180330", Offset = "0x4180330", VA = "0x4180330")]
  private void Start()
  {
  }

  [Token(Token = "0x600063B")]
  [Address(RVA = "0x4180334", Offset = "0x4180334", VA = "0x4180334")]
  private void Update()
  {
  }

  [Token(Token = "0x600063C")]
  [Address(RVA = "0x41803B4", Offset = "0x41803B4", VA = "0x41803B4")]
  public void SetGlobalTexture(Texture2D texture, Vector2 tiling)
  {
  }

  [Token(Token = "0x600063D")]
  [Address(RVA = "0x41803C0", Offset = "0x41803C0", VA = "0x41803C0")]
  public GlobalTextures()
  {
  }
}
