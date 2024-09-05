// Decompiled with JetBrains decompiler
// Type: GlobalMenuFrontContentsBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002AB")]
public class GlobalMenuFrontContentsBase : MonoBehaviour
{
  [Token(Token = "0x4000FCD")]
  [FieldOffset(Offset = "0x18")]
  protected Transform leftTran;
  [Token(Token = "0x4000FCE")]
  [FieldOffset(Offset = "0x20")]
  protected Scenes.GlobalMenuFrontView.GlobalMenuFrontView ParentGlobalMenuFrontView;

  [Token(Token = "0x60010BC")]
  [Address(RVA = "0x1BEA398", Offset = "0x1BEA398", VA = "0x1BEA398", Slot = "4")]
  public virtual void Initialize(Transform left, Scenes.GlobalMenuFrontView.GlobalMenuFrontView view)
  {
  }

  [Token(Token = "0x60010BD")]
  [Address(RVA = "0x1BEA3A0", Offset = "0x1BEA3A0", VA = "0x1BEA3A0", Slot = "5")]
  public virtual IEnumerator InitializeAsync() => (IEnumerator) null;

  [Token(Token = "0x60010BE")]
  [Address(RVA = "0x1BEA428", Offset = "0x1BEA428", VA = "0x1BEA428")]
  public GlobalMenuFrontContentsBase()
  {
  }
}
