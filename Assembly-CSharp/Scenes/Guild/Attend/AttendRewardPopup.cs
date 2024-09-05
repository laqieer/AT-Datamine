// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Attend.AttendRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using TMPro;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Attend
{
  [Token(Token = "0x2002C4F")]
  public class AttendRewardPopup : PopupBase
  {
    [Token(Token = "0x400BCC1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private AttendRewardListContainer container;
    [Token(Token = "0x400BCC2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI guildLevel;
    [Token(Token = "0x400BCC3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton closeButton;

    [Token(Token = "0x60115BC")]
    [Address(RVA = "0x4E18728", Offset = "0x4E18728", VA = "0x4E18728")]
    public void Initialize(
      AssetCachedSpawner spawner,
      ItemDetailPopupProvider provider,
      int guildLevel)
    {
    }

    [Token(Token = "0x60115BD")]
    [Address(RVA = "0x4E18E68", Offset = "0x4E18E68", VA = "0x4E18E68", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60115BE")]
    [Address(RVA = "0x4E18E8C", Offset = "0x4E18E8C", VA = "0x4E18E8C")]
    public AttendRewardPopup()
    {
    }
  }
}
