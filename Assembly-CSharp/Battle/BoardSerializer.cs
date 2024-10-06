// Decompiled with JetBrains decompiler
// Type: Battle.BoardSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using StaqData;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002261")]
  public class BoardSerializer
  {
    [Token(Token = "0x600D0D1")]
    [Address(RVA = "0x4CDF68C", Offset = "0x4CDF68C", VA = "0x4CDF68C")]
    public Offset<staq.SaveSchema.BoardData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.BoardData board,
      byte[] battleData,
      byte[] sceneParamData)
    {
      return new Offset<staq.SaveSchema.BoardData>();
    }

    [Token(Token = "0x600D0D2")]
    [Address(RVA = "0x4CE1A20", Offset = "0x4CE1A20", VA = "0x4CE1A20")]
    public Offset<staq.SaveSchema.BattleData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.BattleData battleData)
    {
      return new Offset<staq.SaveSchema.BattleData>();
    }

    [Token(Token = "0x600D0D3")]
    [Address(RVA = "0x4CE36DC", Offset = "0x4CE36DC", VA = "0x4CE36DC")]
    public Offset<staq.SaveSchema.SceneParameter> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.SceneParameter sceneParameter)
    {
      return new Offset<staq.SaveSchema.SceneParameter>();
    }

    [Token(Token = "0x600D0D4")]
    [Address(RVA = "0x4CE405C", Offset = "0x4CE405C", VA = "0x4CE405C")]
    public Offset<EquipmentOption> Serialize(FlatBufferBuilder fbb, WeaponOptionEffect option)
    {
      return new Offset<EquipmentOption>();
    }

    [Token(Token = "0x600D0D5")]
    [Address(RVA = "0x4CE408C", Offset = "0x4CE408C", VA = "0x4CE408C")]
    public Offset<EquipmentOption> Serialize(FlatBufferBuilder fbb, AccessoryOptionEffect option)
    {
      return new Offset<EquipmentOption>();
    }

    [Token(Token = "0x600D0D6")]
    [Address(RVA = "0x4CE2D20", Offset = "0x4CE2D20", VA = "0x4CE2D20")]
    private Offset<staq.SaveSchema.WeaponData> Serialize(FlatBufferBuilder fbb, Battle.Data.Board.WeaponData weapon)
    {
      return new Offset<staq.SaveSchema.WeaponData>();
    }

    [Token(Token = "0x600D0D7")]
    [Address(RVA = "0x4CE2FF4", Offset = "0x4CE2FF4", VA = "0x4CE2FF4")]
    private Offset<staq.SaveSchema.AccessoryData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.AccessoryData accessory)
    {
      return new Offset<staq.SaveSchema.AccessoryData>();
    }

    [Token(Token = "0x600D0D8")]
    [Address(RVA = "0x4CE3284", Offset = "0x4CE3284", VA = "0x4CE3284")]
    private Offset<staq.SaveSchema.MindEquipmentData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.MindEquipmentData mindEquipment)
    {
      return new Offset<staq.SaveSchema.MindEquipmentData>();
    }

    [Token(Token = "0x600D0D9")]
    [Address(RVA = "0x4CE40BC", Offset = "0x4CE40BC", VA = "0x4CE40BC")]
    private Offset<staq.SaveSchema.ItemData> Serialize(FlatBufferBuilder fbb, Battle.Data.Board.ItemData item)
    {
      return new Offset<staq.SaveSchema.ItemData>();
    }

    [Token(Token = "0x600D0DA")]
    [Address(RVA = "0x4CE40F4", Offset = "0x4CE40F4", VA = "0x4CE40F4")]
    private Offset<staq.SaveSchema.ItemParameterData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.ItemParameterData itemParam)
    {
      return new Offset<staq.SaveSchema.ItemParameterData>();
    }

    [Token(Token = "0x600D0DB")]
    [Address(RVA = "0x4CE3434", Offset = "0x4CE3434", VA = "0x4CE3434")]
    private Offset<staq.SaveSchema.TrustData> Serialize(FlatBufferBuilder fbb, Battle.Data.Board.TrustData trust)
    {
      return new Offset<staq.SaveSchema.TrustData>();
    }

    [Token(Token = "0x600D0DC")]
    [Address(RVA = "0x4CE20E8", Offset = "0x4CE20E8", VA = "0x4CE20E8")]
    private Offset<staq.SaveSchema.SkillData> Serialize(FlatBufferBuilder fbb, Battle.Data.Board.SkillData skill)
    {
      return new Offset<staq.SaveSchema.SkillData>();
    }

    [Token(Token = "0x600D0DD")]
    [Address(RVA = "0x4CE2124", Offset = "0x4CE2124", VA = "0x4CE2124")]
    private Offset<staq.SaveSchema.UnitData> Serialize(FlatBufferBuilder fbb, Battle.Data.Board.UnitData unit)
    {
      return new Offset<staq.SaveSchema.UnitData>();
    }

    [Token(Token = "0x600D0DE")]
    [Address(RVA = "0x4CE02A4", Offset = "0x4CE02A4", VA = "0x4CE02A4")]
    private Offset<staq.SaveSchema.SkillParameterData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.SkillParameterData skillParam)
    {
      return new Offset<staq.SaveSchema.SkillParameterData>();
    }

    [Token(Token = "0x600D0DF")]
    [Address(RVA = "0x4CE4144", Offset = "0x4CE4144", VA = "0x4CE4144")]
    private Offset<staq.SaveSchema.WeaponParameterData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.WeaponParameterData weaponParameter,
      bool isSubstitute = false)
    {
      return new Offset<staq.SaveSchema.WeaponParameterData>();
    }

    [Token(Token = "0x600D0E0")]
    [Address(RVA = "0x4CE1280", Offset = "0x4CE1280", VA = "0x4CE1280")]
    public Offset<staq.SaveSchema.BattlePlayerData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.BattlePlayerData player)
    {
      return new Offset<staq.SaveSchema.BattlePlayerData>();
    }

    [Token(Token = "0x600D0E1")]
    [Address(RVA = "0x4CE02E4", Offset = "0x4CE02E4", VA = "0x4CE02E4")]
    private Offset<staq.SaveSchema.UnitParameterData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.UnitParameterData unitParameter)
    {
      return new Offset<staq.SaveSchema.UnitParameterData>();
    }

    [Token(Token = "0x600D0E2")]
    [Address(RVA = "0x4CE20C0", Offset = "0x4CE20C0", VA = "0x4CE20C0")]
    private Offset<staq.SaveSchema.EffectData> Serialize(FlatBufferBuilder fbb, Battle.Data.Board.EffectData effect)
    {
      return new Offset<staq.SaveSchema.EffectData>();
    }

    [Token(Token = "0x600D0E3")]
    [Address(RVA = "0x4CE432C", Offset = "0x4CE432C", VA = "0x4CE432C")]
    private Offset<staq.SaveSchema.EffectParameterData> Serialize(
      FlatBufferBuilder fbb,
      Battle.Data.Board.EffectParameterData skillEffectParam)
    {
      return new Offset<staq.SaveSchema.EffectParameterData>();
    }

    [Token(Token = "0x600D0E4")]
    [Address(RVA = "0x4CE19A8", Offset = "0x4CE19A8", VA = "0x4CE19A8")]
    private Offset<BattlePlayedVoice> Serialize(FlatBufferBuilder fbb, VoicePlayData PlayedList)
    {
      return new Offset<BattlePlayedVoice>();
    }

    [Token(Token = "0x600D0E5")]
    [Address(RVA = "0x4CE44D0", Offset = "0x4CE44D0", VA = "0x4CE44D0")]
    public BoardSerializer()
    {
    }
  }
}
