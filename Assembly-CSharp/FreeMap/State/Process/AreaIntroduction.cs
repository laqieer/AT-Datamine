// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaIntroduction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017A8")]
  public class AreaIntroduction : FreeMapProcess
  {
    [Token(Token = "0x400687B")]
    private const int InvalidTableID = 0;
    [Token(Token = "0x400687D")]
    [FieldOffset(Offset = "0x38")]
    private Coroutine executeCoroutine;

    [Token(Token = "0x17001550")]
    private int PlayIntroductionTableID
    {
      [Token(Token = "0x6008638"), Address(RVA = "0x406FEB8", Offset = "0x406FEB8", VA = "0x406FEB8")] set
      {
      }
      [Token(Token = "0x6008639"), Address(RVA = "0x406FEC0", Offset = "0x406FEC0", VA = "0x406FEC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001551")]
    private FreeMapAssetHolder<GameObject> TimelineLoader
    {
      [Token(Token = "0x600863A"), Address(RVA = "0x406FEC8", Offset = "0x406FEC8", VA = "0x406FEC8")] set
      {
      }
      [Token(Token = "0x600863B"), Address(RVA = "0x406FED0", Offset = "0x406FED0", VA = "0x406FED0")] get
      {
        return (FreeMapAssetHolder<GameObject>) null;
      }
    }

    [Token(Token = "0x600863C")]
    [Address(RVA = "0x406FED8", Offset = "0x406FED8", VA = "0x406FED8")]
    public AreaIntroduction(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600863D")]
    [Address(RVA = "0x406FF64", Offset = "0x406FF64", VA = "0x406FF64", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600863E")]
    [Address(RVA = "0x40701EC", Offset = "0x40701EC", VA = "0x40701EC")]
    protected void ProcessEnd()
    {
    }

    [Token(Token = "0x600863F")]
    [Address(RVA = "0x407046C", Offset = "0x407046C", VA = "0x407046C")]
    public bool SetupToPlay(FreeMapStateManager entry, int toAreaID) => new bool();

    [Token(Token = "0x6008640")]
    [Address(RVA = "0x4070404", Offset = "0x4070404", VA = "0x4070404")]
    private IEnumerator ExecuteCoroutine() => (IEnumerator) null;
  }
}
