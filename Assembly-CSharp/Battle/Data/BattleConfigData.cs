// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleConfigData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026F1")]
  public abstract class BattleConfigData : ISystemFlags
  {
    [Token(Token = "0x170032E5")]
    public int CameraIndex
    {
      [Token(Token = "0x600F0E1"), Address(RVA = "0x41ABC38", Offset = "0x41ABC38", VA = "0x41ABC38", Slot = "25")] get
      {
        return new int();
      }
      [Token(Token = "0x600F0E2"), Address(RVA = "0x41ABC40", Offset = "0x41ABC40", VA = "0x41ABC40", Slot = "26")] set
      {
      }
    }

    [Token(Token = "0x170032E6")]
    public bool EnableStaging
    {
      [Token(Token = "0x600F0E3"), Address(RVA = "0x41ABC48", Offset = "0x41ABC48", VA = "0x41ABC48", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0E4"), Address(RVA = "0x41ABC50", Offset = "0x41ABC50", VA = "0x41ABC50")] protected set
      {
      }
    }

    [Token(Token = "0x170032E7")]
    public bool AutoMode
    {
      [Token(Token = "0x600F0E5"), Address(RVA = "0x41ABC5C", Offset = "0x41ABC5C", VA = "0x41ABC5C", Slot = "5")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0E6"), Address(RVA = "0x41ABC64", Offset = "0x41ABC64", VA = "0x41ABC64", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170032E8")]
    public bool FastMode
    {
      [Token(Token = "0x600F0E7"), Address(RVA = "0x41ABC70", Offset = "0x41ABC70", VA = "0x41ABC70", Slot = "7")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0E8"), Address(RVA = "0x41ABC78", Offset = "0x41ABC78", VA = "0x41ABC78", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x170032E9")]
    public bool DangerArea
    {
      [Token(Token = "0x600F0E9"), Address(RVA = "0x41ABC84", Offset = "0x41ABC84", VA = "0x41ABC84", Slot = "9")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0EA"), Address(RVA = "0x41ABC8C", Offset = "0x41ABC8C", VA = "0x41ABC8C", Slot = "10")] set
      {
      }
    }

    [Token(Token = "0x170032EA")]
    public bool IsSkip
    {
      [Token(Token = "0x600F0EB"), Address(RVA = "0x41ABC98", Offset = "0x41ABC98", VA = "0x41ABC98", Slot = "11")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0EC"), Address(RVA = "0x41ABCA0", Offset = "0x41ABCA0", VA = "0x41ABCA0", Slot = "12")] set
      {
      }
    }

    [Token(Token = "0x170032EB")]
    public bool ShowGridLines
    {
      [Token(Token = "0x600F0ED"), Address(RVA = "0x41ABCAC", Offset = "0x41ABCAC", VA = "0x41ABCAC", Slot = "13")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0EE"), Address(RVA = "0x41ABCB4", Offset = "0x41ABCB4", VA = "0x41ABCB4", Slot = "14")] set
      {
      }
    }

    [Token(Token = "0x170032EC")]
    public bool ShowDuelAnim
    {
      [Token(Token = "0x600F0EF"), Address(RVA = "0x41ABCC0", Offset = "0x41ABCC0", VA = "0x41ABCC0", Slot = "15")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0F0"), Address(RVA = "0x41ABCC8", Offset = "0x41ABCC8", VA = "0x41ABCC8", Slot = "16")] set
      {
      }
    }

    [Token(Token = "0x170032ED")]
    public bool ShowStatusIcon
    {
      [Token(Token = "0x600F0F1"), Address(RVA = "0x41ABCD4", Offset = "0x41ABCD4", VA = "0x41ABCD4", Slot = "17")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0F2"), Address(RVA = "0x41ABCDC", Offset = "0x41ABCDC", VA = "0x41ABCDC", Slot = "18")] set
      {
      }
    }

    [Token(Token = "0x170032EE")]
    public bool AutoBattlePlayScenarioFast
    {
      [Token(Token = "0x600F0F3"), Address(RVA = "0x41ABCE8", Offset = "0x41ABCE8", VA = "0x41ABCE8", Slot = "19")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0F4"), Address(RVA = "0x41ABCF0", Offset = "0x41ABCF0", VA = "0x41ABCF0", Slot = "20")] set
      {
      }
    }

    [Token(Token = "0x170032EF")]
    public bool AutoBattlePauseUnitLost
    {
      [Token(Token = "0x600F0F5"), Address(RVA = "0x41ABCFC", Offset = "0x41ABCFC", VA = "0x41ABCFC", Slot = "21")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0F6"), Address(RVA = "0x41ABD04", Offset = "0x41ABD04", VA = "0x41ABD04", Slot = "22")] set
      {
      }
    }

    [Token(Token = "0x170032F0")]
    public bool AutoBattleDisableDownLP
    {
      [Token(Token = "0x600F0F7"), Address(RVA = "0x41ABD10", Offset = "0x41ABD10", VA = "0x41ABD10", Slot = "23")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0F8"), Address(RVA = "0x41ABD18", Offset = "0x41ABD18", VA = "0x41ABD18", Slot = "24")] set
      {
      }
    }

    [Token(Token = "0x170032F1")]
    public bool AutoPlacement
    {
      [Token(Token = "0x600F0F9"), Address(RVA = "0x41ABD24", Offset = "0x41ABD24", VA = "0x41ABD24", Slot = "27")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0FA"), Address(RVA = "0x41ABD2C", Offset = "0x41ABD2C", VA = "0x41ABD2C", Slot = "28")] set
      {
      }
    }

    [Token(Token = "0x170032F2")]
    public bool ShowLevelUpEffect
    {
      [Token(Token = "0x600F0FB"), Address(RVA = "0x41ABD38", Offset = "0x41ABD38", VA = "0x41ABD38", Slot = "35")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0FC"), Address(RVA = "0x41ABD40", Offset = "0x41ABD40", VA = "0x41ABD40", Slot = "36")] set
      {
      }
    }

    [Token(Token = "0x170032F3")]
    public bool CanRollBack
    {
      [Token(Token = "0x600F0FD"), Address(RVA = "0x41ABD4C", Offset = "0x41ABD4C", VA = "0x41ABD4C", Slot = "33")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F0FE"), Address(RVA = "0x41ABD54", Offset = "0x41ABD54", VA = "0x41ABD54", Slot = "34")] set
      {
      }
    }

    [Token(Token = "0x170032F4")]
    public bool CanItemUse
    {
      [Token(Token = "0x600F0FF"), Address(RVA = "0x41ABD60", Offset = "0x41ABD60", VA = "0x41ABD60", Slot = "29")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F100"), Address(RVA = "0x41ABD68", Offset = "0x41ABD68", VA = "0x41ABD68", Slot = "30")] set
      {
      }
    }

    [Token(Token = "0x170032F5")]
    public bool IsTutorial
    {
      [Token(Token = "0x600F101"), Address(RVA = "0x41ABD74", Offset = "0x41ABD74", VA = "0x41ABD74", Slot = "31")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F102"), Address(RVA = "0x41ABD7C", Offset = "0x41ABD7C", VA = "0x41ABD7C", Slot = "32")] set
      {
      }
    }

    [Token(Token = "0x170032F6")]
    public bool IsMock
    {
      [Token(Token = "0x600F103"), Address(RVA = "0x41ABD88", Offset = "0x41ABD88", VA = "0x41ABD88")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F104"), Address(RVA = "0x41ABD90", Offset = "0x41ABD90", VA = "0x41ABD90")] protected set
      {
      }
    }

    [Token(Token = "0x170032F7")]
    public bool EnableLost
    {
      [Token(Token = "0x600F105"), Address(RVA = "0x41ABD9C", Offset = "0x41ABD9C", VA = "0x41ABD9C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F106"), Address(RVA = "0x41ABDA4", Offset = "0x41ABDA4", VA = "0x41ABDA4")] set
      {
      }
    }

    [Token(Token = "0x170032F8")]
    public bool WithoutArts
    {
      [Token(Token = "0x600F107"), Address(RVA = "0x41ABDB0", Offset = "0x41ABDB0", VA = "0x41ABDB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F108"), Address(RVA = "0x41ABDB8", Offset = "0x41ABDB8", VA = "0x41ABDB8")] set
      {
      }
    }

    [Token(Token = "0x170032F9")]
    public bool WithoutStratagem
    {
      [Token(Token = "0x600F109"), Address(RVA = "0x41ABDC4", Offset = "0x41ABDC4", VA = "0x41ABDC4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F10A"), Address(RVA = "0x41ABDCC", Offset = "0x41ABDCC", VA = "0x41ABDCC")] set
      {
      }
    }

    [Token(Token = "0x170032FA")]
    public string MapAssetName
    {
      [Token(Token = "0x600F10B"), Address(RVA = "0x41ABDD8", Offset = "0x41ABDD8", VA = "0x41ABDD8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F10C"), Address(RVA = "0x41ABDE0", Offset = "0x41ABDE0", VA = "0x41ABDE0")] protected set
      {
      }
    }

    [Token(Token = "0x170032FB")]
    public string MapYamlAssetName
    {
      [Token(Token = "0x600F10D"), Address(RVA = "0x41ABDE8", Offset = "0x41ABDE8", VA = "0x41ABDE8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F10E"), Address(RVA = "0x41ABDF0", Offset = "0x41ABDF0", VA = "0x41ABDF0")] protected set
      {
      }
    }

    [Token(Token = "0x170032FC")]
    public abstract BattleTimeTypeEnum TimeSlot { [Token(Token = "0x600F10F")] get; }

    [Token(Token = "0x170032FD")]
    public abstract BattleWeatherTypeEnum Weather { [Token(Token = "0x600F110")] get; }

    [Token(Token = "0x170032FE")]
    public BattleBgColorIdEnum BgColorId
    {
      [Token(Token = "0x600F111"), Address(RVA = "0x41ABDF8", Offset = "0x41ABDF8", VA = "0x41ABDF8")] get
      {
        return new BattleBgColorIdEnum();
      }
      [Token(Token = "0x600F112"), Address(RVA = "0x41ABE00", Offset = "0x41ABE00", VA = "0x41ABE00")] protected set
      {
      }
    }

    [Token(Token = "0x170032FF")]
    public bool EnableSecurityLog
    {
      [Token(Token = "0x600F113"), Address(RVA = "0x41ABE08", Offset = "0x41ABE08", VA = "0x41ABE08")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F114"), Address(RVA = "0x41ABE10", Offset = "0x41ABE10", VA = "0x41ABE10")] set
      {
      }
    }

    [Token(Token = "0x600F115")]
    [Address(RVA = "0x41ABE1C", Offset = "0x41ABE1C", VA = "0x41ABE1C")]
    public MapEditorData GetMapEditorData() => (MapEditorData) null;

    [Token(Token = "0x600F116")]
    [Address(RVA = "0x41ABF10", Offset = "0x41ABF10", VA = "0x41ABF10", Slot = "40")]
    public virtual string GetDefaultBgmName() => (string) null;

    [Token(Token = "0x600F117")]
    [Address(RVA = "0x41ABF58", Offset = "0x41ABF58", VA = "0x41ABF58", Slot = "41")]
    public virtual List<string> GetAllBgmNames() => (List<string>) null;

    [Token(Token = "0x600F118")]
    public abstract void SaveSettings();

    [Token(Token = "0x600F119")]
    [Address(RVA = "0x41ABFCC", Offset = "0x41ABFCC", VA = "0x41ABFCC", Slot = "43")]
    public virtual BattleSettingsSaveData.BattleCamera[] GetCameraSettings()
    {
      return (BattleSettingsSaveData.BattleCamera[]) null;
    }

    [Token(Token = "0x600F11A")]
    [Address(RVA = "0x41AC010", Offset = "0x41AC010", VA = "0x41AC010", Slot = "44")]
    public virtual void SaveCameraSettings(BattleSettingsSaveData.BattleCamera[] cameras)
    {
    }

    [Token(Token = "0x600F11B")]
    [Address(RVA = "0x41AC014", Offset = "0x41AC014", VA = "0x41AC014", Slot = "45")]
    public virtual void OnOnUpdateCameraDistance(float distance)
    {
    }

    [Token(Token = "0x600F11C")]
    [Address(RVA = "0x41A7828", Offset = "0x41A7828", VA = "0x41A7828")]
    protected BattleConfigData()
    {
    }
  }
}
