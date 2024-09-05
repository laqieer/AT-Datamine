// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.Popup.GuildRaidLapReward.GuildRaidSpecialLapRewardContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Raid.Popup.GuildRaidLapReward
{
  [Token(Token = "0x20029FE")]
  internal class GuildRaidSpecialLapRewardContainer : MonoBehaviour
  {
    [Token(Token = "0x400B2DB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildRaidSpecialLapRewardContent baseContent;

    [Token(Token = "0x601076E")]
    [Address(RVA = "0x48925BC", Offset = "0x48925BC", VA = "0x48925BC")]
    public GuildRaidSpecialLapRewardContent CreateSpecialLapRewardContent()
    {
      return (GuildRaidSpecialLapRewardContent) null;
    }

    [Token(Token = "0x601076F")]
    [Address(RVA = "0x4892C34", Offset = "0x4892C34", VA = "0x4892C34")]
    public GuildRaidSpecialLapRewardContainer()
    {
    }
  }
}
