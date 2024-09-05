// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionStatus.ExpeditionStatusPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.ExpeditionStatus
{
  [Token(Token = "0x2002CF9")]
  public class ExpeditionStatusPopup : PopupBase
  {
    [Token(Token = "0x400C0A6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Scenes.Expedition.ExpeditionStatus.ExpeditionStatus expeditionStatus;
    [Token(Token = "0x400C0A7")]
    private const string OpenTweenName = "ExpeditionStatusIn";
    [Token(Token = "0x400C0A8")]
    private const string CloseTweenName = "ExpeditionStatustOut";

    [Token(Token = "0x60119A8")]
    [Address(RVA = "0x46A6C48", Offset = "0x46A6C48", VA = "0x46A6C48")]
    public Scenes.Expedition.ExpeditionStatus.ExpeditionStatus GetExpeditionStatus()
    {
      return (Scenes.Expedition.ExpeditionStatus.ExpeditionStatus) null;
    }

    [Token(Token = "0x60119A9")]
    [Address(RVA = "0x46A6C50", Offset = "0x46A6C50", VA = "0x46A6C50", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60119AA")]
    [Address(RVA = "0x46A6CF4", Offset = "0x46A6CF4", VA = "0x46A6CF4", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60119AB")]
    [Address(RVA = "0x46A6D84", Offset = "0x46A6D84", VA = "0x46A6D84")]
    public ExpeditionStatusPopup()
    {
    }
  }
}
