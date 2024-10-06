// Decompiled with JetBrains decompiler
// Type: Battle.VoicePlayData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200226A")]
  public class VoicePlayData
  {
    [Token(Token = "0x4009107")]
    [FieldOffset(Offset = "0x10")]
    public BattleVoiceTimingEnum Timing;
    [Token(Token = "0x4009108")]
    [FieldOffset(Offset = "0x18")]
    public string VoicePackId;
    [Token(Token = "0x4009109")]
    [FieldOffset(Offset = "0x20")]
    public string TargetVoicePackId;
    [Token(Token = "0x400910A")]
    [FieldOffset(Offset = "0x28")]
    public int Turn;
    [Token(Token = "0x400910B")]
    [FieldOffset(Offset = "0x2C")]
    public int PlayerId;

    [Token(Token = "0x600D146")]
    [Address(RVA = "0x1953B40", Offset = "0x1953B40", VA = "0x1953B40")]
    public VoicePlayData(
      BattleVoiceTimingEnum timing,
      string voicePackId,
      string targetVoicePackId,
      int turn,
      int playerId)
    {
    }
  }
}
