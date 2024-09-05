// Decompiled with JetBrains decompiler
// Type: TutorialAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
[Token(Token = "0x20002C4")]
public class TutorialAdv
{
  [Token(Token = "0x4001039")]
  [FieldOffset(Offset = "0x10")]
  private bool isBusy;

  [Token(Token = "0x170001AF")]
  public bool IsBusy
  {
    [Token(Token = "0x600114B"), Address(RVA = "0x1BF1DEC", Offset = "0x1BF1DEC", VA = "0x1BF1DEC")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x600114C")]
  [Address(RVA = "0x1BF1DF4", Offset = "0x1BF1DF4", VA = "0x1BF1DF4")]
  public IEnumerator Load(string assetbundleLabel, string fileName) => (IEnumerator) null;

  [Token(Token = "0x600114D")]
  [Address(RVA = "0x1BF1E98", Offset = "0x1BF1E98", VA = "0x1BF1E98")]
  public IEnumerator Play() => (IEnumerator) null;

  [Token(Token = "0x600114E")]
  [Address(RVA = "0x1BF1F28", Offset = "0x1BF1F28", VA = "0x1BF1F28")]
  public IEnumerator Clear() => (IEnumerator) null;

  [Token(Token = "0x600114F")]
  [Address(RVA = "0x1BF1FB8", Offset = "0x1BF1FB8", VA = "0x1BF1FB8")]
  public TutorialAdv()
  {
  }

  [Token(Token = "0x20002C5")]
  public class ProccessSignal : Adv2Manager.OnProccessSignal
  {
    [Token(Token = "0x400103A")]
    [FieldOffset(Offset = "0x18")]
    private TutorialAdv parent;

    [Token(Token = "0x6001153")]
    [Address(RVA = "0x1BF1FD8", Offset = "0x1BF1FD8", VA = "0x1BF1FD8")]
    public ProccessSignal(TutorialAdv parent)
    {
    }

    [Token(Token = "0x6001154")]
    [Address(RVA = "0x1BF2000", Offset = "0x1BF2000", VA = "0x1BF2000", Slot = "4")]
    public override void SetProccessing(bool value)
    {
    }
  }
}
