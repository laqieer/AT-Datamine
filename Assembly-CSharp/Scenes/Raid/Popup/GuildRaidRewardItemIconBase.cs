// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidRewardItemIconBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Raid.Popup
{
  [Token(Token = "0x20029F0")]
  [Serializable]
  internal class GuildRaidRewardItemIconBase
  {
    [Token(Token = "0x400B2BF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ItemIcon variantItemIcon;
    [Token(Token = "0x400B2C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleThumb variantStyleThumb;
    [Token(Token = "0x400B2C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MnemnographThumb variantMnemnographThumb;
    [Token(Token = "0x400B2C2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform parent;

    [Token(Token = "0x6010744")]
    [Address(RVA = "0x4890B9C", Offset = "0x4890B9C", VA = "0x4890B9C")]
    public void Init()
    {
    }

    [Token(Token = "0x6010745")]
    [Address(RVA = "0x4890D64", Offset = "0x4890D64", VA = "0x4890D64")]
    public ItemIcon ItemIconCreate() => (ItemIcon) null;

    [Token(Token = "0x6010746")]
    [Address(RVA = "0x4890DE0", Offset = "0x4890DE0", VA = "0x4890DE0")]
    public StyleThumb StyleThumbCreate() => (StyleThumb) null;

    [Token(Token = "0x6010747")]
    [Address(RVA = "0x4890E5C", Offset = "0x4890E5C", VA = "0x4890E5C")]
    public MnemnographThumb MnemnographThumbCreate() => (MnemnographThumb) null;

    [Token(Token = "0x6010748")]
    [Address(RVA = "0x4890C8C", Offset = "0x4890C8C", VA = "0x4890C8C")]
    private void SetDisable()
    {
    }

    [Token(Token = "0x6010749")]
    [Address(RVA = "0x4890ED4", Offset = "0x4890ED4", VA = "0x4890ED4")]
    public GuildRaidRewardItemIconBase()
    {
    }
  }
}
