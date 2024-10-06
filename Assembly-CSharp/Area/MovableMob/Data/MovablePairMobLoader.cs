// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovablePairMobLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x2002841")]
  public class MovablePairMobLoader : IMovableMobLoader
  {
    [Token(Token = "0x170037C3")]
    private MovableSingleMobLoader LeftAssetData
    {
      [Token(Token = "0x600FD6B"), Address(RVA = "0x442E3BC", Offset = "0x442E3BC", VA = "0x442E3BC")] get
      {
        return (MovableSingleMobLoader) null;
      }
      [Token(Token = "0x600FD6C"), Address(RVA = "0x442E3C4", Offset = "0x442E3C4", VA = "0x442E3C4")] set
      {
      }
    }

    [Token(Token = "0x170037C4")]
    private MovableSingleMobLoader RightAssetData
    {
      [Token(Token = "0x600FD6D"), Address(RVA = "0x442E3CC", Offset = "0x442E3CC", VA = "0x442E3CC")] get
      {
        return (MovableSingleMobLoader) null;
      }
      [Token(Token = "0x600FD6E"), Address(RVA = "0x442E3D4", Offset = "0x442E3D4", VA = "0x442E3D4")] set
      {
      }
    }

    [Token(Token = "0x170037C5")]
    private string SoundObjectAssetBundleName
    {
      [Token(Token = "0x600FD6F"), Address(RVA = "0x442E3DC", Offset = "0x442E3DC", VA = "0x442E3DC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037C6")]
    private string SoundObjectAssetName
    {
      [Token(Token = "0x600FD70"), Address(RVA = "0x442E41C", Offset = "0x442E41C", VA = "0x442E41C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037C7")]
    private StoryFreeActionSoundObjectData SoundObjectData
    {
      [Token(Token = "0x600FD71"), Address(RVA = "0x442E434", Offset = "0x442E434", VA = "0x442E434")] get
      {
        return (StoryFreeActionSoundObjectData) null;
      }
      [Token(Token = "0x600FD72"), Address(RVA = "0x442E43C", Offset = "0x442E43C", VA = "0x442E43C")] set
      {
      }
    }

    [Token(Token = "0x600FD73")]
    [Address(RVA = "0x442E444", Offset = "0x442E444", VA = "0x442E444")]
    public MovablePairMobLoader(
      MovableSingleMobLoader leftLoader,
      MovableSingleMobLoader rightLoader,
      int soundObjectID)
    {
    }

    [Token(Token = "0x600FD74")]
    [Address(RVA = "0x442E510", Offset = "0x442E510", VA = "0x442E510", Slot = "4")]
    public void Load()
    {
    }

    [Token(Token = "0x600FD75")]
    [Address(RVA = "0x442E8EC", Offset = "0x442E8EC", VA = "0x442E8EC", Slot = "5")]
    public MovableMobInstanceDataBase CreateInstanceData() => (MovableMobInstanceDataBase) null;

    [Token(Token = "0x600FD76")]
    [Address(RVA = "0x442EF20", Offset = "0x442EF20", VA = "0x442EF20", Slot = "6")]
    public void Unload()
    {
    }

    [Token(Token = "0x600FD77")]
    [Address(RVA = "0x442F270", Offset = "0x442F270", VA = "0x442F270")]
    public static MovablePairMobLoader Create(
      StoryAreaMovableSpawnPatternData data,
      int soundGroupLabel,
      StoryCharacterLookWeatherTypeEnum weatherLookType,
      bool isIndoor)
    {
      return (MovablePairMobLoader) null;
    }
  }
}
