// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidLapClearPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Raid.Popup.GuildRaidAnimation;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Raid.Popup
{
  [Token(Token = "0x20029ED")]
  internal class GuildRaidLapClearPopup : PopupBase
  {
    [Token(Token = "0x400B2B9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TMP_Text beforeLapNumText;
    [Token(Token = "0x400B2BA")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TMP_Text afterLapNumText;
    [Token(Token = "0x400B2BB")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400B2BC")]
    [FieldOffset(Offset = "0xA0")]
    private IGuildRaidAnimation popupAnimation;
    [Token(Token = "0x400B2BD")]
    [FieldOffset(Offset = "0xA8")]
    private bool playDirection;

    [Token(Token = "0x601073A")]
    [Address(RVA = "0x488F9B0", Offset = "0x488F9B0", VA = "0x488F9B0")]
    public static void Create(
      AssetCachedSpawner assetCachedSpawner,
      Action<GuildRaidLapClearPopup> onFinish)
    {
    }

    [Token(Token = "0x601073B")]
    [Address(RVA = "0x488FAF4", Offset = "0x488FAF4", VA = "0x488FAF4")]
    public void PreOpen(int beforeLapNum, int afterLapNum)
    {
    }

    [Token(Token = "0x601073C")]
    [Address(RVA = "0x4890798", Offset = "0x4890798", VA = "0x4890798", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x601073D")]
    [Address(RVA = "0x489084C", Offset = "0x489084C", VA = "0x489084C")]
    private void Init()
    {
    }

    [Token(Token = "0x601073E")]
    [Address(RVA = "0x4890634", Offset = "0x4890634", VA = "0x4890634")]
    private void TextSetup(int beforeLapNum, int afterLapNum)
    {
    }

    [Token(Token = "0x601073F")]
    [Address(RVA = "0x48909AC", Offset = "0x48909AC", VA = "0x48909AC", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6010740")]
    [Address(RVA = "0x4890A54", Offset = "0x4890A54", VA = "0x4890A54")]
    public GuildRaidLapClearPopup()
    {
    }
  }
}
