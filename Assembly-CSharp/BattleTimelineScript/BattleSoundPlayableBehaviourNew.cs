// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleSoundPlayableBehaviourNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Sound;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021FE")]
  public class BattleSoundPlayableBehaviourNew : PlayableBehaviour
  {
    [Token(Token = "0x4008FA0")]
    [FieldOffset(Offset = "0x10")]
    public BattleSoundPlayableAssetNew.SoundType soundType;
    [Token(Token = "0x4008FA1")]
    [FieldOffset(Offset = "0x18")]
    public string soundName;
    [Token(Token = "0x4008FA2")]
    [FieldOffset(Offset = "0x20")]
    public SoundManager soundManager;
    [Token(Token = "0x4008FA3")]
    [FieldOffset(Offset = "0x28")]
    public GameObject eventObject;
    [Token(Token = "0x4008FA4")]
    [FieldOffset(Offset = "0x30")]
    private uint playingID;

    [Token(Token = "0x600CF0B")]
    [Address(RVA = "0x4B69754", Offset = "0x4B69754", VA = "0x4B69754", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x600CF0C")]
    [Address(RVA = "0x4B6975C", Offset = "0x4B6975C", VA = "0x4B6975C", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CF0D")]
    [Address(RVA = "0x4B6978C", Offset = "0x4B6978C", VA = "0x4B6978C", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CF0E")]
    [Address(RVA = "0x4B69790", Offset = "0x4B69790", VA = "0x4B69790", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x600CF0F")]
    [Address(RVA = "0x4B697E8", Offset = "0x4B697E8", VA = "0x4B697E8")]
    private bool PostEvent() => new bool();

    [Token(Token = "0x600CF10")]
    [Address(RVA = "0x4B6980C", Offset = "0x4B6980C", VA = "0x4B6980C")]
    private uint PlaySound() => new uint();

    [Token(Token = "0x600CF11")]
    [Address(RVA = "0x4B69940", Offset = "0x4B69940", VA = "0x4B69940")]
    public BattleSoundPlayableBehaviourNew()
    {
    }
  }
}
