// Decompiled with JetBrains decompiler
// Type: StampIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000218")]
public class StampIcon : MonoBehaviour
{
  [Token(Token = "0x4000C8C")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Image image;
  [Token(Token = "0x4000C8D")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Button button;
  [Token(Token = "0x4000C8E")]
  [FieldOffset(Offset = "0x28")]
  private int stampId;
  [Token(Token = "0x4000C8F")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string ASSET_BUNDLE_NAME;
  [Token(Token = "0x4000C90")]
  [FieldOffset(Offset = "0x8")]
  private static readonly string ASSET_NAME;

  [Token(Token = "0x17000119")]
  public int StampID
  {
    [Token(Token = "0x6000D41"), Address(RVA = "0x1C84FA0", Offset = "0x1C84FA0", VA = "0x1C84FA0")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x6000D42")]
  [Address(RVA = "0x1C84FA8", Offset = "0x1C84FA8", VA = "0x1C84FA8")]
  public IEnumerator InitializeSync(
    int stampID,
    AssetCachedSpawner assetLoader,
    Action<int> clickAction = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000D43")]
  [Address(RVA = "0x1C8505C", Offset = "0x1C8505C", VA = "0x1C8505C")]
  public void Initialize(int stampID, AssetCachedSpawner assetLoader, Action<int> clickAction = null)
  {
  }

  [Token(Token = "0x6000D44")]
  [Address(RVA = "0x1C8507C", Offset = "0x1C8507C", VA = "0x1C8507C")]
  public void Select(bool sw)
  {
  }

  [Token(Token = "0x6000D45")]
  [Address(RVA = "0x1C85130", Offset = "0x1C85130", VA = "0x1C85130")]
  public StampIcon()
  {
  }

  [Token(Token = "0x6000D46")]
  [Address(RVA = "0x1C85138", Offset = "0x1C85138", VA = "0x1C85138")]
  static StampIcon()
  {
  }
}
