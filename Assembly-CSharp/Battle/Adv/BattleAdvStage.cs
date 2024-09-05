// Decompiled with JetBrains decompiler
// Type: Battle.Adv.BattleAdvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;

#nullable disable
namespace Battle.Adv
{
  [Token(Token = "0x200281E")]
  public sealed class BattleAdvStage : AdvStageBase
  {
    [Token(Token = "0x400AB34")]
    [FieldOffset(Offset = "0x38")]
    private CameraDirector cameraDirector;
    [Token(Token = "0x400AB35")]
    [FieldOffset(Offset = "0x40")]
    private int? questType;
    [Token(Token = "0x400AB36")]
    [FieldOffset(Offset = "0x48")]
    private int? questId;

    [Token(Token = "0x600FC88")]
    [Address(RVA = "0x4425064", Offset = "0x4425064", VA = "0x4425064")]
    public BattleAdvStage(
      AdvDemoInfoData demoInfo,
      CameraDirector cameraDirector,
      int? questType,
      int? questId)
    {
    }

    [Token(Token = "0x600FC89")]
    [Address(RVA = "0x44250A0", Offset = "0x44250A0", VA = "0x44250A0", Slot = "4")]
    public override void OnStart()
    {
    }

    [Token(Token = "0x600FC8A")]
    [Address(RVA = "0x44250A8", Offset = "0x44250A8", VA = "0x44250A8", Slot = "6")]
    public override void OnDestroy()
    {
    }

    [Token(Token = "0x600FC8B")]
    [Address(RVA = "0x44250B0", Offset = "0x44250B0", VA = "0x44250B0")]
    public (int?, int?) GetQuest() => ();
  }
}
