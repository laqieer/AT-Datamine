// Decompiled with JetBrains decompiler
// Type: Battle.Staging.ExHealingSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Unit;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200257E")]
  public sealed class ExHealingSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A10D")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData owner;
    [Token(Token = "0x400A10E")]
    [FieldOffset(Offset = "0x20")]
    private UnitParameterData target;
    [Token(Token = "0x400A10F")]
    [FieldOffset(Offset = "0x28")]
    private bool moveCamera;
    [Token(Token = "0x400A110")]
    [FieldOffset(Offset = "0x30")]
    private SkillData usingSkill;
    [Token(Token = "0x400A111")]
    [FieldOffset(Offset = "0x38")]
    private int healValue;
    [Token(Token = "0x400A112")]
    [FieldOffset(Offset = "0x40")]
    private ActorDirector actorDirector;
    [Token(Token = "0x400A113")]
    [FieldOffset(Offset = "0x48")]
    private IDirector mainDirector;
    [Token(Token = "0x400A114")]
    [FieldOffset(Offset = "0x50")]
    private bool isPlayingParticle;
    [Token(Token = "0x400A115")]
    [FieldOffset(Offset = "0x58")]
    private Action onCompleted;

    [Token(Token = "0x600E74F")]
    [Address(RVA = "0x487D530", Offset = "0x487D530", VA = "0x487D530")]
    public static StagingDirector.ISequence Create(
      UnitParameterData owner,
      SkillData usingSkill,
      int healValue,
      UnitParameterData target,
      IDirector mainDirector,
      bool moveCamera,
      Action onCompleted)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E750")]
    [Address(RVA = "0x4873830", Offset = "0x4873830", VA = "0x4873830")]
    public static StagingDirector.ISequence Create(
      int healValue,
      UnitParameterData target,
      IDirector mainDirector,
      bool moveCamera,
      Action onCompleted)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x1700318A")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E751"), Address(RVA = "0x487D6E4", Offset = "0x487D6E4", VA = "0x487D6E4", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E752"), Address(RVA = "0x487D6EC", Offset = "0x487D6EC", VA = "0x487D6EC")] private set
      {
      }
    }

    [Token(Token = "0x1700318B")]
    private CharacterActor ownerActor
    {
      [Token(Token = "0x600E753"), Address(RVA = "0x487D6F8", Offset = "0x487D6F8", VA = "0x487D6F8")] get
      {
        return (CharacterActor) null;
      }
    }

    [Token(Token = "0x1700318C")]
    private CharacterActor targetActor
    {
      [Token(Token = "0x600E754"), Address(RVA = "0x487D728", Offset = "0x487D728", VA = "0x487D728")] get
      {
        return (CharacterActor) null;
      }
    }

    [Token(Token = "0x600E755")]
    [Address(RVA = "0x487D5E0", Offset = "0x487D5E0", VA = "0x487D5E0")]
    private ExHealingSequence(
      UnitParameterData owner,
      SkillData usingSkill,
      int healValue,
      UnitParameterData target,
      IDirector mainDirector,
      bool moveCamera,
      Action onCompleted)
    {
    }

    [Token(Token = "0x600E756")]
    [Address(RVA = "0x487D758", Offset = "0x487D758", VA = "0x487D758", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E757")]
    [Address(RVA = "0x487DC60", Offset = "0x487DC60", VA = "0x487DC60", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E758")]
    [Address(RVA = "0x487DDEC", Offset = "0x487DDEC", VA = "0x487DDEC", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E759")]
    [Address(RVA = "0x487E0BC", Offset = "0x487E0BC", VA = "0x487E0BC", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E75A")]
    [Address(RVA = "0x487DC2C", Offset = "0x487DC2C", VA = "0x487DC2C")]
    private void OnEndPlayingParticle()
    {
    }

    [Token(Token = "0x600E75B")]
    [Address(RVA = "0x487E0C0", Offset = "0x487E0C0", VA = "0x487E0C0")]
    private void ShowValueIfNeed()
    {
    }
  }
}
