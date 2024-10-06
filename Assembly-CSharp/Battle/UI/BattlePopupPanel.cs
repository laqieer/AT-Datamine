// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattlePopupPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200237F")]
  public class BattlePopupPanel : PopupBase
  {
    [Token(Token = "0x4009727")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    protected CommonButton closeButton;

    [Token(Token = "0x600D8CE")]
    [Address(RVA = "0x1B989B4", Offset = "0x1B989B4", VA = "0x1B989B4", Slot = "10")]
    public virtual void Initialize()
    {
    }

    [Token(Token = "0x600D8CF")]
    [Address(RVA = "0x1B99738", Offset = "0x1B99738", VA = "0x1B99738", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x600D8D0")]
    [Address(RVA = "0x1B99788", Offset = "0x1B99788", VA = "0x1B99788", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x600D8D1")]
    [Address(RVA = "0x1B99824", Offset = "0x1B99824", VA = "0x1B99824", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x600D8D2")]
    [Address(RVA = "0x1B98A58", Offset = "0x1B98A58", VA = "0x1B98A58")]
    public BattlePopupPanel()
    {
    }
  }
}
