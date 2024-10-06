// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FastTravel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.UI;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017BA")]
  public class FastTravel : FreeMapProcess
  {
    [Token(Token = "0x40068AD")]
    [FieldOffset(Offset = "0x40")]
    private ITransitionEvent transition;

    [Token(Token = "0x1700155A")]
    public FreeMapUIParamBase TargetParam
    {
      [Token(Token = "0x600868F"), Address(RVA = "0x43CFA24", Offset = "0x43CFA24", VA = "0x43CFA24")] get
      {
        return (FreeMapUIParamBase) null;
      }
      [Token(Token = "0x6008690"), Address(RVA = "0x43CFA2C", Offset = "0x43CFA2C", VA = "0x43CFA2C")] private set
      {
      }
    }

    [Token(Token = "0x6008691")]
    [Address(RVA = "0x43CFA34", Offset = "0x43CFA34", VA = "0x43CFA34")]
    public FastTravel(
      FreeMapStateManager entity,
      ITransitionEvent transition,
      FreeMapUIParamBase targetParam)
    {
    }

    [Token(Token = "0x6008692")]
    [Address(RVA = "0x43CFA5C", Offset = "0x43CFA5C", VA = "0x43CFA5C", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008693")]
    [Address(RVA = "0x43CFFD4", Offset = "0x43CFFD4", VA = "0x43CFFD4")]
    private void SameArea()
    {
    }

    [Token(Token = "0x6008694")]
    [Address(RVA = "0x43CFB28", Offset = "0x43CFB28", VA = "0x43CFB28")]
    private void OtherArea()
    {
    }

    [Token(Token = "0x20017BB")]
    private class DummyLoad : FreeMapProcess
    {
      [Token(Token = "0x40068AE")]
      public const float DEFAULT_WAIT_SEC = 0.5f;
      [Token(Token = "0x40068AF")]
      [FieldOffset(Offset = "0x34")]
      private float sec;

      [Token(Token = "0x6008695")]
      [Address(RVA = "0x43D04A8", Offset = "0x43D04A8", VA = "0x43D04A8")]
      public DummyLoad(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008696")]
      [Address(RVA = "0x43D0558", Offset = "0x43D0558", VA = "0x43D0558")]
      public DummyLoad(FreeMapStateManager entity, float sec)
      {
      }

      [Token(Token = "0x6008697")]
      [Address(RVA = "0x43D0584", Offset = "0x43D0584", VA = "0x43D0584", Slot = "4")]
      public override void Begin()
      {
      }

      [Token(Token = "0x6008698")]
      [Address(RVA = "0x43D05B8", Offset = "0x43D05B8", VA = "0x43D05B8")]
      private IEnumerator WaitCoroutine() => (IEnumerator) null;
    }

    [Token(Token = "0x20017BD")]
    private class PlayerWarpProcess : FreeMapProcess
    {
      [Token(Token = "0x40068B3")]
      [FieldOffset(Offset = "0x38")]
      private FreeMapUIParamBase targetParam;
      [Token(Token = "0x40068B4")]
      [FieldOffset(Offset = "0x40")]
      private FreeMapUITransformHolder target;

      [Token(Token = "0x600869F")]
      [Address(RVA = "0x43D04D0", Offset = "0x43D04D0", VA = "0x43D04D0")]
      public PlayerWarpProcess(FreeMapStateManager entity, FreeMapUIParamBase targetParam)
      {
      }

      [Token(Token = "0x60086A0")]
      [Address(RVA = "0x43D0764", Offset = "0x43D0764", VA = "0x43D0764")]
      public PlayerWarpProcess(FreeMapStateManager entity, FreeMapUITransformHolder target)
      {
      }

      [Token(Token = "0x60086A1")]
      [Address(RVA = "0x43D0788", Offset = "0x43D0788", VA = "0x43D0788", Slot = "4")]
      public override void Begin()
      {
      }
    }

    [Token(Token = "0x20017BE")]
    private class FastTravelIconEvent : FreeMapProcess
    {
      [Token(Token = "0x1700155D")]
      public FreeMapUIParamBase InvokeParam
      {
        [Token(Token = "0x60086A2"), Address(RVA = "0x43D0BCC", Offset = "0x43D0BCC", VA = "0x43D0BCC")] get
        {
          return (FreeMapUIParamBase) null;
        }
        [Token(Token = "0x60086A3"), Address(RVA = "0x43D0BD4", Offset = "0x43D0BD4", VA = "0x43D0BD4")] private set
        {
        }
      }

      [Token(Token = "0x60086A4")]
      [Address(RVA = "0x43D0534", Offset = "0x43D0534", VA = "0x43D0534")]
      public FastTravelIconEvent(FreeMapStateManager entity, FreeMapUIParamBase invokeParam)
      {
      }

      [Token(Token = "0x60086A5")]
      [Address(RVA = "0x43D0BDC", Offset = "0x43D0BDC", VA = "0x43D0BDC", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
