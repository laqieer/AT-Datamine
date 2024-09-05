// Decompiled with JetBrains decompiler
// Type: InfiniteCellBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D3")]
public class InfiniteCellBase : MonoBehaviour
{
  [Token(Token = "0x4001074")]
  [FieldOffset(Offset = "0x18")]
  private RectTransform rectTransform;
  [Token(Token = "0x4001075")]
  [FieldOffset(Offset = "0x20")]
  private InfiniteCellData cellData;

  [Token(Token = "0x170001BF")]
  public RectTransform RectTransform
  {
    [Token(Token = "0x60011AB"), Address(RVA = "0x27D738C", Offset = "0x27D738C", VA = "0x27D738C")] get
    {
      return (RectTransform) null;
    }
  }

  [Token(Token = "0x170001C0")]
  public InfiniteCellData CellData
  {
    [Token(Token = "0x60011AC"), Address(RVA = "0x27D7420", Offset = "0x27D7420", VA = "0x27D7420")] set
    {
    }
    [Token(Token = "0x60011AD"), Address(RVA = "0x27D7430", Offset = "0x27D7430", VA = "0x27D7430")] get
    {
      return (InfiniteCellData) null;
    }
  }

  [Token(Token = "0x60011AE")]
  [Address(RVA = "0x27D7438", Offset = "0x27D7438", VA = "0x27D7438")]
  private void Awake()
  {
  }

  [Token(Token = "0x60011AF")]
  [Address(RVA = "0x27D743C", Offset = "0x27D743C", VA = "0x27D743C", Slot = "4")]
  public virtual void OnUpdate()
  {
  }

  [Token(Token = "0x60011B0")]
  [Address(RVA = "0x27D7468", Offset = "0x27D7468", VA = "0x27D7468")]
  public InfiniteCellBase()
  {
  }
}
