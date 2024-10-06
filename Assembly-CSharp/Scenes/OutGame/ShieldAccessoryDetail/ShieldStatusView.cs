// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.ShieldStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x20033B0")]
  public class ShieldStatusView : StatusViewBase
  {
    [Token(Token = "0x400E094")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _physicalDef;
    [Token(Token = "0x400E095")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _magicalDef;
    [Token(Token = "0x400E096")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text _criticalAvoid;
    [Token(Token = "0x400E097")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _weightText;

    [Token(Token = "0x6014530")]
    [Address(RVA = "0x206C9D4", Offset = "0x206C9D4", VA = "0x206C9D4", Slot = "6")]
    public override void SetVisible(bool isVisible)
    {
    }

    [Token(Token = "0x6014531")]
    [Address(RVA = "0x206C9FC", Offset = "0x206C9FC", VA = "0x206C9FC", Slot = "7")]
    public override void UpdateStatus(
      AccessoryStandardStatus status,
      AccessoryStandardStatus assumption = null)
    {
    }

    [Token(Token = "0x6014532")]
    [Address(RVA = "0x206CBAC", Offset = "0x206CBAC", VA = "0x206CBAC")]
    public ShieldStatusView()
    {
    }
  }
}
