// Decompiled with JetBrains decompiler
// Type: Battle.Staging.GainSupportPointSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025B2")]
  public class GainSupportPointSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A232")]
    [FieldOffset(Offset = "0x10")]
    private IDirector mainDirector;
    [Token(Token = "0x400A233")]
    [FieldOffset(Offset = "0x18")]
    private List<BattleSupportValueInfo> supportData;

    [Token(Token = "0x170031AF")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E8BF"), Address(RVA = "0x4C4494C", Offset = "0x4C4494C", VA = "0x4C4494C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8C0"), Address(RVA = "0x4C44954", Offset = "0x4C44954", VA = "0x4C44954")] private set
      {
      }
    }

    [Token(Token = "0x600E8C1")]
    [Address(RVA = "0x4C44960", Offset = "0x4C44960", VA = "0x4C44960")]
    public static GainSupportPointSequence Create(
      IDirector director,
      List<BattleSupportValueInfo> supportData)
    {
      return (GainSupportPointSequence) null;
    }

    [Token(Token = "0x600E8C2")]
    [Address(RVA = "0x4C449D8", Offset = "0x4C449D8", VA = "0x4C449D8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E8C3")]
    [Address(RVA = "0x4C45054", Offset = "0x4C45054", VA = "0x4C45054", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E8C4")]
    [Address(RVA = "0x4C45048", Offset = "0x4C45048", VA = "0x4C45048", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E8C5")]
    [Address(RVA = "0x4C45058", Offset = "0x4C45058", VA = "0x4C45058", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E8C6")]
    [Address(RVA = "0x4C449D0", Offset = "0x4C449D0", VA = "0x4C449D0")]
    public GainSupportPointSequence()
    {
    }
  }
}
