// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityStoneStatueStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002C03")]
  public class GuildFacilityStoneStatueStatus : MonoBehaviour
  {
    [Token(Token = "0x400BB5F")]
    [FieldOffset(Offset = "0x18")]
    private GuildFacilityBelowScreen scene;
    [Token(Token = "0x400BB60")]
    [FieldOffset(Offset = "0x20")]
    private GuildFacilityDetailInfo info;
    [Token(Token = "0x400BB61")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text statueName;
    [Token(Token = "0x400BB62")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text nowLevel;
    [Token(Token = "0x400BB63")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text maxLevel;
    [Token(Token = "0x400BB64")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text exp;
    [Token(Token = "0x400BB65")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Slider expGauge;
    [Token(Token = "0x400BB66")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject badge;

    [Token(Token = "0x6011304")]
    [Address(RVA = "0x4A0CB3C", Offset = "0x4A0CB3C", VA = "0x4A0CB3C")]
    public void Init(GuildFacilityBelowScreen scene, GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x6011305")]
    [Address(RVA = "0x4A13B78", Offset = "0x4A13B78", VA = "0x4A13B78")]
    public void OnSearch()
    {
    }

    [Token(Token = "0x6011306")]
    [Address(RVA = "0x4A13B98", Offset = "0x4A13B98", VA = "0x4A13B98")]
    public void OnInvest()
    {
    }

    [Token(Token = "0x6011307")]
    [Address(RVA = "0x4A13BC0", Offset = "0x4A13BC0", VA = "0x4A13BC0")]
    public GuildFacilityStoneStatueStatus()
    {
    }
  }
}
