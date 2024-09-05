// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C81")]
  public struct BattleSettings : IFlatbufferObject
  {
    [Token(Token = "0x4010BE0")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E18")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017F1D"), Address(RVA = "0x3B168A4", Offset = "0x3B168A4", VA = "0x3B168A4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017F1E")]
    [Address(RVA = "0x3B168AC", Offset = "0x3B168AC", VA = "0x3B168AC")]
    public static BattleSettings GetRootAsBattleSettings(ByteBuffer _bb) => new BattleSettings();

    [Token(Token = "0x6017F1F")]
    [Address(RVA = "0x3B168B8", Offset = "0x3B168B8", VA = "0x3B168B8")]
    public static BattleSettings GetRootAsBattleSettings(ByteBuffer _bb, BattleSettings obj)
    {
      return new BattleSettings();
    }

    [Token(Token = "0x6017F20")]
    [Address(RVA = "0x3B16914", Offset = "0x3B16914", VA = "0x3B16914")]
    public static bool BattleSettingsBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017F21")]
    [Address(RVA = "0x3B16960", Offset = "0x3B16960", VA = "0x3B16960", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017F22")]
    [Address(RVA = "0x3B168FC", Offset = "0x3B168FC", VA = "0x3B168FC")]
    public BattleSettings __assign(int _i, ByteBuffer _bb) => new BattleSettings();

    [Token(Token = "0x17004E19")]
    public bool ShowFullDuelAnimation
    {
      [Token(Token = "0x6017F23"), Address(RVA = "0x3B1696C", Offset = "0x3B1696C", VA = "0x3B1696C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E1A")]
    public bool AutoBattleEnabled
    {
      [Token(Token = "0x6017F24"), Address(RVA = "0x3B169BC", Offset = "0x3B169BC", VA = "0x3B169BC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E1B")]
    public bool AutoBattleTreasure
    {
      [Token(Token = "0x6017F25"), Address(RVA = "0x3B16A04", Offset = "0x3B16A04", VA = "0x3B16A04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E1C")]
    public bool AutoBattleWithoutArts
    {
      [Token(Token = "0x6017F26"), Address(RVA = "0x3B16A4C", Offset = "0x3B16A4C", VA = "0x3B16A4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E1D")]
    public bool AutoBattleWithoutStratagem
    {
      [Token(Token = "0x6017F27"), Address(RVA = "0x3B16A94", Offset = "0x3B16A94", VA = "0x3B16A94")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E1E")]
    public bool AutoBattleHealItem
    {
      [Token(Token = "0x6017F28"), Address(RVA = "0x3B16ADC", Offset = "0x3B16ADC", VA = "0x3B16ADC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E1F")]
    public bool AutoBattlePlayScenarioFast
    {
      [Token(Token = "0x6017F29"), Address(RVA = "0x3B16B24", Offset = "0x3B16B24", VA = "0x3B16B24")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E20")]
    public bool AutoBattlePauseUnitLost
    {
      [Token(Token = "0x6017F2A"), Address(RVA = "0x3B16B6C", Offset = "0x3B16B6C", VA = "0x3B16B6C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E21")]
    public bool AutoBattleDisableDownlP
    {
      [Token(Token = "0x6017F2B"), Address(RVA = "0x3B16BB4", Offset = "0x3B16BB4", VA = "0x3B16BB4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E22")]
    public bool AutoPlacement
    {
      [Token(Token = "0x6017F2C"), Address(RVA = "0x3B16C04", Offset = "0x3B16C04", VA = "0x3B16C04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E23")]
    public bool AutoRepair
    {
      [Token(Token = "0x6017F2D"), Address(RVA = "0x3B16C4C", Offset = "0x3B16C4C", VA = "0x3B16C4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E24")]
    public bool FastBattleMode
    {
      [Token(Token = "0x6017F2E"), Address(RVA = "0x3B16C94", Offset = "0x3B16C94", VA = "0x3B16C94")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017F2F")]
    [Address(RVA = "0x3B16CDC", Offset = "0x3B16CDC", VA = "0x3B16CDC")]
    public BattleCamera? BattleCameras(int j) => new BattleCamera?();

    [Token(Token = "0x17004E25")]
    public int BattleCamerasLength
    {
      [Token(Token = "0x6017F30"), Address(RVA = "0x3B16DA8", Offset = "0x3B16DA8", VA = "0x3B16DA8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E26")]
    public bool GridView
    {
      [Token(Token = "0x6017F31"), Address(RVA = "0x3B16DDC", Offset = "0x3B16DDC", VA = "0x3B16DDC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E27")]
    public bool DangerArea
    {
      [Token(Token = "0x6017F32"), Address(RVA = "0x3B16E24", Offset = "0x3B16E24", VA = "0x3B16E24")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E28")]
    public bool ShowStatusIcon
    {
      [Token(Token = "0x6017F33"), Address(RVA = "0x3B16E6C", Offset = "0x3B16E6C", VA = "0x3B16E6C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E29")]
    public int CameraIndex
    {
      [Token(Token = "0x6017F34"), Address(RVA = "0x3B16EB4", Offset = "0x3B16EB4", VA = "0x3B16EB4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E2A")]
    public bool LevelupSkip
    {
      [Token(Token = "0x6017F35"), Address(RVA = "0x3B16EFC", Offset = "0x3B16EFC", VA = "0x3B16EFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E2B")]
    public bool AdvSkip
    {
      [Token(Token = "0x6017F36"), Address(RVA = "0x3B16F4C", Offset = "0x3B16F4C", VA = "0x3B16F4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E2C")]
    public bool TurnendCheck
    {
      [Token(Token = "0x6017F37"), Address(RVA = "0x3B16F94", Offset = "0x3B16F94", VA = "0x3B16F94")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017F38")]
    [Address(RVA = "0x3B16FE4", Offset = "0x3B16FE4", VA = "0x3B16FE4")]
    public static Offset<BattleSettings> CreateBattleSettings(
      FlatBufferBuilder builder,
      bool show_full_duel_animation = true,
      bool auto_battle_enabled = false,
      bool auto_battle_treasure = false,
      bool auto_battle_without_arts = false,
      bool auto_battle_without_stratagem = false,
      bool auto_battle_heal_item = false,
      bool auto_battle_play_scenario_fast = false,
      bool auto_battle_pause_unit_lost = false,
      bool auto_battle_disable_downlP = true,
      bool auto_placement = false,
      bool auto_repair = false,
      bool fast_battle_mode = false,
      VectorOffset battle_camerasOffset = default (VectorOffset),
      bool grid_view = false,
      bool danger_area = false,
      bool show_status_icon = false,
      int camera_index = 1,
      bool levelup_skip = true,
      bool adv_skip = false,
      bool turnend_check = true)
    {
      return new Offset<BattleSettings>();
    }

    [Token(Token = "0x6017F39")]
    [Address(RVA = "0x3B1747C", Offset = "0x3B1747C", VA = "0x3B1747C")]
    public static void StartBattleSettings(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017F3A")]
    [Address(RVA = "0x3B1740C", Offset = "0x3B1740C", VA = "0x3B1740C")]
    public static void AddShowFullDuelAnimation(
      FlatBufferBuilder builder,
      bool showFullDuelAnimation)
    {
    }

    [Token(Token = "0x6017F3B")]
    [Address(RVA = "0x3B173EC", Offset = "0x3B173EC", VA = "0x3B173EC")]
    public static void AddAutoBattleEnabled(FlatBufferBuilder builder, bool autoBattleEnabled)
    {
    }

    [Token(Token = "0x6017F3C")]
    [Address(RVA = "0x3B173CC", Offset = "0x3B173CC", VA = "0x3B173CC")]
    public static void AddAutoBattleTreasure(FlatBufferBuilder builder, bool autoBattleTreasure)
    {
    }

    [Token(Token = "0x6017F3D")]
    [Address(RVA = "0x3B173AC", Offset = "0x3B173AC", VA = "0x3B173AC")]
    public static void AddAutoBattleWithoutArts(
      FlatBufferBuilder builder,
      bool autoBattleWithoutArts)
    {
    }

    [Token(Token = "0x6017F3E")]
    [Address(RVA = "0x3B1738C", Offset = "0x3B1738C", VA = "0x3B1738C")]
    public static void AddAutoBattleWithoutStratagem(
      FlatBufferBuilder builder,
      bool autoBattleWithoutStratagem)
    {
    }

    [Token(Token = "0x6017F3F")]
    [Address(RVA = "0x3B1736C", Offset = "0x3B1736C", VA = "0x3B1736C")]
    public static void AddAutoBattleHealItem(FlatBufferBuilder builder, bool autoBattleHealItem)
    {
    }

    [Token(Token = "0x6017F40")]
    [Address(RVA = "0x3B1734C", Offset = "0x3B1734C", VA = "0x3B1734C")]
    public static void AddAutoBattlePlayScenarioFast(
      FlatBufferBuilder builder,
      bool autoBattlePlayScenarioFast)
    {
    }

    [Token(Token = "0x6017F41")]
    [Address(RVA = "0x3B1732C", Offset = "0x3B1732C", VA = "0x3B1732C")]
    public static void AddAutoBattlePauseUnitLost(
      FlatBufferBuilder builder,
      bool autoBattlePauseUnitLost)
    {
    }

    [Token(Token = "0x6017F42")]
    [Address(RVA = "0x3B1730C", Offset = "0x3B1730C", VA = "0x3B1730C")]
    public static void AddAutoBattleDisableDownlP(
      FlatBufferBuilder builder,
      bool autoBattleDisableDownlP)
    {
    }

    [Token(Token = "0x6017F43")]
    [Address(RVA = "0x3B172EC", Offset = "0x3B172EC", VA = "0x3B172EC")]
    public static void AddAutoPlacement(FlatBufferBuilder builder, bool autoPlacement)
    {
    }

    [Token(Token = "0x6017F44")]
    [Address(RVA = "0x3B172CC", Offset = "0x3B172CC", VA = "0x3B172CC")]
    public static void AddAutoRepair(FlatBufferBuilder builder, bool autoRepair)
    {
    }

    [Token(Token = "0x6017F45")]
    [Address(RVA = "0x3B172AC", Offset = "0x3B172AC", VA = "0x3B172AC")]
    public static void AddFastBattleMode(FlatBufferBuilder builder, bool fastBattleMode)
    {
    }

    [Token(Token = "0x6017F46")]
    [Address(RVA = "0x3B171CC", Offset = "0x3B171CC", VA = "0x3B171CC")]
    public static void AddBattleCameras(FlatBufferBuilder builder, VectorOffset battleCamerasOffset)
    {
    }

    [Token(Token = "0x6017F47")]
    [Address(RVA = "0x3B17494", Offset = "0x3B17494", VA = "0x3B17494")]
    public static VectorOffset CreateBattleCamerasVector(
      FlatBufferBuilder builder,
      Offset<BattleCamera>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F48")]
    [Address(RVA = "0x3B1753C", Offset = "0x3B1753C", VA = "0x3B1753C")]
    public static VectorOffset CreateBattleCamerasVectorBlock(
      FlatBufferBuilder builder,
      Offset<BattleCamera>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017F49")]
    [Address(RVA = "0x3B175C4", Offset = "0x3B175C4", VA = "0x3B175C4")]
    public static void StartBattleCamerasVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017F4A")]
    [Address(RVA = "0x3B1728C", Offset = "0x3B1728C", VA = "0x3B1728C")]
    public static void AddGridView(FlatBufferBuilder builder, bool gridView)
    {
    }

    [Token(Token = "0x6017F4B")]
    [Address(RVA = "0x3B1726C", Offset = "0x3B1726C", VA = "0x3B1726C")]
    public static void AddDangerArea(FlatBufferBuilder builder, bool dangerArea)
    {
    }

    [Token(Token = "0x6017F4C")]
    [Address(RVA = "0x3B1724C", Offset = "0x3B1724C", VA = "0x3B1724C")]
    public static void AddShowStatusIcon(FlatBufferBuilder builder, bool showStatusIcon)
    {
    }

    [Token(Token = "0x6017F4D")]
    [Address(RVA = "0x3B171AC", Offset = "0x3B171AC", VA = "0x3B171AC")]
    public static void AddCameraIndex(FlatBufferBuilder builder, int cameraIndex)
    {
    }

    [Token(Token = "0x6017F4E")]
    [Address(RVA = "0x3B1722C", Offset = "0x3B1722C", VA = "0x3B1722C")]
    public static void AddLevelupSkip(FlatBufferBuilder builder, bool levelupSkip)
    {
    }

    [Token(Token = "0x6017F4F")]
    [Address(RVA = "0x3B1720C", Offset = "0x3B1720C", VA = "0x3B1720C")]
    public static void AddAdvSkip(FlatBufferBuilder builder, bool advSkip)
    {
    }

    [Token(Token = "0x6017F50")]
    [Address(RVA = "0x3B171EC", Offset = "0x3B171EC", VA = "0x3B171EC")]
    public static void AddTurnendCheck(FlatBufferBuilder builder, bool turnendCheck)
    {
    }

    [Token(Token = "0x6017F51")]
    [Address(RVA = "0x3B1742C", Offset = "0x3B1742C", VA = "0x3B1742C")]
    public static Offset<BattleSettings> EndBattleSettings(FlatBufferBuilder builder)
    {
      return new Offset<BattleSettings>();
    }

    [Token(Token = "0x6017F52")]
    [Address(RVA = "0x3B175E4", Offset = "0x3B175E4", VA = "0x3B175E4")]
    public static void FinishBattleSettingsBuffer(
      FlatBufferBuilder builder,
      Offset<BattleSettings> offset)
    {
    }

    [Token(Token = "0x6017F53")]
    [Address(RVA = "0x3B17640", Offset = "0x3B17640", VA = "0x3B17640")]
    public static void FinishSizePrefixedBattleSettingsBuffer(
      FlatBufferBuilder builder,
      Offset<BattleSettings> offset)
    {
    }
  }
}
