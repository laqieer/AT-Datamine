// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableSingleMobLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200284A")]
  public class MovableSingleMobLoader : IMovableMobLoader
  {
    [Token(Token = "0x170037DC")]
    private string ModelAssetBundleName
    {
      [Token(Token = "0x600FDAD"), Address(RVA = "0x4430994", Offset = "0x4430994", VA = "0x4430994")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600FDAE"), Address(RVA = "0x443099C", Offset = "0x443099C", VA = "0x443099C")] set
      {
      }
    }

    [Token(Token = "0x170037DD")]
    private string ModelName
    {
      [Token(Token = "0x600FDAF"), Address(RVA = "0x44309A4", Offset = "0x44309A4", VA = "0x44309A4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600FDB0"), Address(RVA = "0x44309AC", Offset = "0x44309AC", VA = "0x44309AC")] set
      {
      }
    }

    [Token(Token = "0x170037DE")]
    private string AnimationAssetBundleName
    {
      [Token(Token = "0x600FDB1"), Address(RVA = "0x44309B4", Offset = "0x44309B4", VA = "0x44309B4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600FDB2"), Address(RVA = "0x44309BC", Offset = "0x44309BC", VA = "0x44309BC")] set
      {
      }
    }

    [Token(Token = "0x170037DF")]
    private string AnimationAssetName
    {
      [Token(Token = "0x600FDB3"), Address(RVA = "0x44309C4", Offset = "0x44309C4", VA = "0x44309C4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600FDB4"), Address(RVA = "0x44309CC", Offset = "0x44309CC", VA = "0x44309CC")] set
      {
      }
    }

    [Token(Token = "0x170037E0")]
    private string AnimationName
    {
      [Token(Token = "0x600FDB5"), Address(RVA = "0x44309D4", Offset = "0x44309D4", VA = "0x44309D4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600FDB6"), Address(RVA = "0x44309DC", Offset = "0x44309DC", VA = "0x44309DC")] set
      {
      }
    }

    [Token(Token = "0x170037E1")]
    private string SoundObjectAssetBundleName
    {
      [Token(Token = "0x600FDB7"), Address(RVA = "0x44309E4", Offset = "0x44309E4", VA = "0x44309E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037E2")]
    private string SoundObjectAssetName
    {
      [Token(Token = "0x600FDB8"), Address(RVA = "0x4430A24", Offset = "0x4430A24", VA = "0x4430A24")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037E3")]
    private StoryFreeActionSoundObjectData SoundObjectData
    {
      [Token(Token = "0x600FDB9"), Address(RVA = "0x4430A3C", Offset = "0x4430A3C", VA = "0x4430A3C")] get
      {
        return (StoryFreeActionSoundObjectData) null;
      }
      [Token(Token = "0x600FDBA"), Address(RVA = "0x4430A44", Offset = "0x4430A44", VA = "0x4430A44")] set
      {
      }
    }

    [Token(Token = "0x170037E4")]
    private StoryCharacterLookWeatherTypeEnum LookWeatherType
    {
      [Token(Token = "0x600FDBB"), Address(RVA = "0x4430A4C", Offset = "0x4430A4C", VA = "0x4430A4C")] get
      {
        return new StoryCharacterLookWeatherTypeEnum();
      }
      [Token(Token = "0x600FDBC"), Address(RVA = "0x4430A54", Offset = "0x4430A54", VA = "0x4430A54")] set
      {
      }
    }

    [Token(Token = "0x170037E5")]
    private PropSettingData[] PropDatas
    {
      [Token(Token = "0x600FDBD"), Address(RVA = "0x4430A5C", Offset = "0x4430A5C", VA = "0x4430A5C")] get
      {
        return (PropSettingData[]) null;
      }
      [Token(Token = "0x600FDBE"), Address(RVA = "0x4430A64", Offset = "0x4430A64", VA = "0x4430A64")] set
      {
      }
    }

    [Token(Token = "0x600FDBF")]
    [Address(RVA = "0x4430A6C", Offset = "0x4430A6C", VA = "0x4430A6C")]
    public MovableSingleMobLoader(
      int buildID,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      int soundDataID = 0)
    {
    }

    [Token(Token = "0x600FDC0")]
    [Address(RVA = "0x442E654", Offset = "0x442E654", VA = "0x442E654", Slot = "4")]
    public void Load()
    {
    }

    [Token(Token = "0x600FDC1")]
    [Address(RVA = "0x442EB40", Offset = "0x442EB40", VA = "0x442EB40", Slot = "5")]
    public MovableMobInstanceDataBase CreateInstanceData() => (MovableMobInstanceDataBase) null;

    [Token(Token = "0x600FDC2")]
    [Address(RVA = "0x442F05C", Offset = "0x442F05C", VA = "0x442F05C", Slot = "6")]
    public void Unload()
    {
    }

    [Token(Token = "0x600FDC3")]
    [Address(RVA = "0x442F404", Offset = "0x442F404", VA = "0x442F404")]
    public static MovableSingleMobLoader Create(
      int switchID,
      StoryCharacterLookWeatherTypeEnum weatherLookType,
      bool isIndoor,
      int soundDataID = 0)
    {
      return (MovableSingleMobLoader) null;
    }
  }
}
