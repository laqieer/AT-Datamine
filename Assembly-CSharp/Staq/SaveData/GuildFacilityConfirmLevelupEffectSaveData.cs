// Decompiled with JetBrains decompiler
// Type: staq.SaveData.GuildFacilityConfirmLevelupEffectSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D1D")]
  public class GuildFacilityConfirmLevelupEffectSaveData
  {
    [Token(Token = "0x4010CF0")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, GuildFacilityConfirmLevelupEffectSaveData.FacilityConfirmLevelupEffect> levelupEffectData;

    [Token(Token = "0x17005032")]
    private static string Path
    {
      [Token(Token = "0x60188EF"), Address(RVA = "0x29431F0", Offset = "0x29431F0", VA = "0x29431F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60188F0")]
    [Address(RVA = "0x2943240", Offset = "0x2943240", VA = "0x2943240")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60188F1")]
    [Address(RVA = "0x2943288", Offset = "0x2943288", VA = "0x2943288")]
    public void Delete()
    {
    }

    [Token(Token = "0x60188F2")]
    [Address(RVA = "0x29432A0", Offset = "0x29432A0", VA = "0x29432A0")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60188F3")]
    [Address(RVA = "0x29432D0", Offset = "0x29432D0", VA = "0x29432D0")]
    public void Load()
    {
    }

    [Token(Token = "0x60188F4")]
    [Address(RVA = "0x2943650", Offset = "0x2943650", VA = "0x2943650")]
    public void Save()
    {
    }

    [Token(Token = "0x60188F5")]
    [Address(RVA = "0x29434C4", Offset = "0x29434C4", VA = "0x29434C4")]
    private void FromSchema(GuildFacilitySaveData guildFacilityData)
    {
    }

    [Token(Token = "0x60188F6")]
    [Address(RVA = "0x2943838", Offset = "0x2943838", VA = "0x2943838")]
    private GuildFacilityConfirmLevelupEffectSaveData.FacilityConfirmLevelupEffect FromSchema(
      ConfirmLevelupEffectEveryFacility schema)
    {
      return (GuildFacilityConfirmLevelupEffectSaveData.FacilityConfirmLevelupEffect) null;
    }

    [Token(Token = "0x60188F7")]
    [Address(RVA = "0x29436EC", Offset = "0x29436EC", VA = "0x29436EC")]
    public Offset<GuildFacilitySaveData> ToOffset(FlatBufferBuilder fbb)
    {
      return new Offset<GuildFacilitySaveData>();
    }

    [Token(Token = "0x60188F8")]
    [Address(RVA = "0x29438D0", Offset = "0x29438D0", VA = "0x29438D0")]
    public Offset<ConfirmLevelupEffectEveryFacility> ToOffset(
      GuildFacilityConfirmLevelupEffectSaveData.FacilityConfirmLevelupEffect data,
      FlatBufferBuilder fbb)
    {
      return new Offset<ConfirmLevelupEffectEveryFacility>();
    }

    [Token(Token = "0x60188F9")]
    [Address(RVA = "0x29438FC", Offset = "0x29438FC", VA = "0x29438FC")]
    public void ChangeStatus(int facilityId, int level)
    {
    }

    [Token(Token = "0x60188FA")]
    [Address(RVA = "0x2943A2C", Offset = "0x2943A2C", VA = "0x2943A2C")]
    public bool IsNeedPlayEffect(int facilityId, int level) => new bool();

    [Token(Token = "0x60188FB")]
    [Address(RVA = "0x2943AF8", Offset = "0x2943AF8", VA = "0x2943AF8")]
    public void JoinInit(int facilityId, int level)
    {
    }

    [Token(Token = "0x60188FC")]
    [Address(RVA = "0x2943BAC", Offset = "0x2943BAC", VA = "0x2943BAC")]
    public bool IsEmpty() => new bool();

    [Token(Token = "0x60188FD")]
    [Address(RVA = "0x2943C08", Offset = "0x2943C08", VA = "0x2943C08")]
    public GuildFacilityConfirmLevelupEffectSaveData()
    {
    }

    [Token(Token = "0x2003D1E")]
    public class FacilityConfirmLevelupEffect
    {
      [Token(Token = "0x4010CF1")]
      [FieldOffset(Offset = "0x10")]
      public int facilityId;
      [Token(Token = "0x4010CF2")]
      [FieldOffset(Offset = "0x14")]
      public int confirmLevel;

      [Token(Token = "0x60188FE")]
      [Address(RVA = "0x29439BC", Offset = "0x29439BC", VA = "0x29439BC")]
      public static GuildFacilityConfirmLevelupEffectSaveData.FacilityConfirmLevelupEffect Create(
        int facilityId,
        int confirmLevel)
      {
        return (GuildFacilityConfirmLevelupEffectSaveData.FacilityConfirmLevelupEffect) null;
      }

      [Token(Token = "0x60188FF")]
      [Address(RVA = "0x29438C0", Offset = "0x29438C0", VA = "0x29438C0")]
      public FacilityConfirmLevelupEffect()
      {
      }
    }
  }
}
