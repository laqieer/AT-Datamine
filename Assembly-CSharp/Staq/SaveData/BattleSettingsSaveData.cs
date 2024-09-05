// Decompiled with JetBrains decompiler
// Type: staq.SaveData.BattleSettingsSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF7")]
  public class BattleSettingsSaveData
  {
    [Token(Token = "0x4010C69")]
    [FieldOffset(Offset = "0x10")]
    public bool ShowFullDuelAnimation;
    [Token(Token = "0x4010C6A")]
    [FieldOffset(Offset = "0x11")]
    public bool AutoBattleEnabled;
    [Token(Token = "0x4010C6B")]
    [FieldOffset(Offset = "0x12")]
    public bool AutoBattleTreasure;
    [Token(Token = "0x4010C6C")]
    [FieldOffset(Offset = "0x13")]
    public bool AutoBattleWithoutArts;
    [Token(Token = "0x4010C6D")]
    [FieldOffset(Offset = "0x14")]
    public bool AutoBattleWithoutStratagem;
    [Token(Token = "0x4010C6E")]
    [FieldOffset(Offset = "0x15")]
    public bool AutoBattleHealItem;
    [Token(Token = "0x4010C6F")]
    [FieldOffset(Offset = "0x16")]
    public bool AutoBattlePlayScenarioFast;
    [Token(Token = "0x4010C70")]
    [FieldOffset(Offset = "0x17")]
    public bool AutoBattlePauseUnitLost;
    [Token(Token = "0x4010C71")]
    [FieldOffset(Offset = "0x18")]
    public bool AutoBattleDisableDownLP;
    [Token(Token = "0x4010C72")]
    [FieldOffset(Offset = "0x19")]
    public bool AutoPlacement;
    [Token(Token = "0x4010C73")]
    [FieldOffset(Offset = "0x1A")]
    public bool AutoRepair;
    [Token(Token = "0x4010C74")]
    [FieldOffset(Offset = "0x1B")]
    public bool FastMode;
    [Token(Token = "0x4010C75")]
    [FieldOffset(Offset = "0x20")]
    public BattleSettingsSaveData.BattleCamera[] BattleCameras;
    [Token(Token = "0x4010C76")]
    [FieldOffset(Offset = "0x28")]
    public int CameraIndex;
    [Token(Token = "0x4010C77")]
    [FieldOffset(Offset = "0x2C")]
    public bool GridView;
    [Token(Token = "0x4010C78")]
    [FieldOffset(Offset = "0x2D")]
    public bool DangerArea;
    [Token(Token = "0x4010C79")]
    [FieldOffset(Offset = "0x2E")]
    public bool ShowStatusIcon;
    [Token(Token = "0x4010C7A")]
    [FieldOffset(Offset = "0x2F")]
    public bool LevelUpSkip;
    [Token(Token = "0x4010C7B")]
    [FieldOffset(Offset = "0x30")]
    public bool TurnEndCheck;
    [Token(Token = "0x4010C7C")]
    [FieldOffset(Offset = "0x31")]
    public bool AdvSkip;

    [Token(Token = "0x1700500F")]
    public static string Path
    {
      [Token(Token = "0x6018801"), Address(RVA = "0x29399EC", Offset = "0x29399EC", VA = "0x29399EC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018802")]
    [Address(RVA = "0x2939A3C", Offset = "0x2939A3C", VA = "0x2939A3C")]
    public string getPath() => (string) null;

    [Token(Token = "0x6018803")]
    [Address(RVA = "0x2939A84", Offset = "0x2939A84", VA = "0x2939A84")]
    public void delete()
    {
    }

    [Token(Token = "0x6018804")]
    [Address(RVA = "0x2939A9C", Offset = "0x2939A9C", VA = "0x2939A9C")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x6018805")]
    [Address(RVA = "0x2939AC8", Offset = "0x2939AC8", VA = "0x2939AC8")]
    public void load()
    {
    }

    [Token(Token = "0x6018806")]
    [Address(RVA = "0x2939F2C", Offset = "0x2939F2C", VA = "0x2939F2C")]
    public void save()
    {
    }

    [Token(Token = "0x6018807")]
    [Address(RVA = "0x293A1CC", Offset = "0x293A1CC", VA = "0x293A1CC")]
    public BattleSettingsSaveData()
    {
    }

    [Token(Token = "0x2003CF8")]
    public struct BattleCamera
    {
      [Token(Token = "0x4010C7D")]
      [FieldOffset(Offset = "0x0")]
      public int Id;
      [Token(Token = "0x4010C7E")]
      [FieldOffset(Offset = "0x4")]
      public float Distance;
    }
  }
}
