// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.AccessoryStatusView
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
  [Token(Token = "0x2003389")]
  public class AccessoryStatusView : StatusViewBase
  {
    [Token(Token = "0x400DF71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _life;
    [Token(Token = "0x400DF72")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _strength;
    [Token(Token = "0x400DF73")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text _intelligence;
    [Token(Token = "0x400DF74")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _vitality;
    [Token(Token = "0x400DF75")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text _mind;
    [Token(Token = "0x400DF76")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text _agility;
    [Token(Token = "0x400DF77")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text _dexterity;
    [Token(Token = "0x400DF78")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text _lucky;
    [Token(Token = "0x400DF79")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text _weightText;

    [Token(Token = "0x60143FA")]
    [Address(RVA = "0x206077C", Offset = "0x206077C", VA = "0x206077C", Slot = "6")]
    public override void SetVisible(bool isVisible)
    {
    }

    [Token(Token = "0x60143FB")]
    [Address(RVA = "0x20607A4", Offset = "0x20607A4", VA = "0x20607A4", Slot = "7")]
    public override void UpdateStatus(
      AccessoryStandardStatus status,
      AccessoryStandardStatus assumption = null)
    {
    }

    [Token(Token = "0x60143FC")]
    [Address(RVA = "0x2060B9C", Offset = "0x2060B9C", VA = "0x2060B9C")]
    public AccessoryStatusView()
    {
    }
  }
}
