// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.Statue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BE6")]
  public class Statue
  {
    [Token(Token = "0x400BACA")]
    [FieldOffset(Offset = "0x10")]
    private GuildFacilityStoneStatueStatus statueStatus;
    [Token(Token = "0x400BACB")]
    [FieldOffset(Offset = "0x18")]
    private GuildFacilityStoneStatue statue;
    [Token(Token = "0x400BACC")]
    [FieldOffset(Offset = "0x20")]
    private GameObject layout;

    [Token(Token = "0x601125B")]
    [Address(RVA = "0x4A0CA40", Offset = "0x4A0CA40", VA = "0x4A0CA40")]
    public Statue(GuildFacilityStoneStatueStatus statueStatus, GuildFacilityStoneStatue statue)
    {
    }

    [Token(Token = "0x601125C")]
    [Address(RVA = "0x4A0CA6C", Offset = "0x4A0CA6C", VA = "0x4A0CA6C")]
    public void Init(GuildFacilityBelowScreen scene, GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x601125D")]
    [Address(RVA = "0x4A0CF04", Offset = "0x4A0CF04", VA = "0x4A0CF04")]
    public Statue(GameObject layout, GuildFacilityStoneStatue statue)
    {
    }

    [Token(Token = "0x601125E")]
    [Address(RVA = "0x4A0CF30", Offset = "0x4A0CF30", VA = "0x4A0CF30")]
    public void Init(GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x601125F")]
    [Address(RVA = "0x4A0CFE8", Offset = "0x4A0CFE8", VA = "0x4A0CFE8")]
    public void SetActive(bool flag)
    {
    }

    [Token(Token = "0x2002BE7")]
    public enum ID
    {
      [Token(Token = "0x400BACE")] Prosperity = 101, // 0x00000065
      [Token(Token = "0x400BACF")] Valor = 102, // 0x00000066
      [Token(Token = "0x400BAD0")] Endurance = 103, // 0x00000067
      [Token(Token = "0x400BAD1")] Celerity = 104, // 0x00000068
    }
  }
}
