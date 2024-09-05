// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.CameraWork
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.CameraField;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001716")]
  public class CameraWork
  {
    [Token(Token = "0x40066E8")]
    [FieldOffset(Offset = "0x20")]
    private OverrideCameraBase duplicateCameraParam;

    [Token(Token = "0x1700146F")]
    private FreeMapIconEventHandler EventHandler
    {
      [Token(Token = "0x60082A2"), Address(RVA = "0x420134C", Offset = "0x420134C", VA = "0x420134C")] get
      {
        return (FreeMapIconEventHandler) null;
      }
    }

    [Token(Token = "0x17001470")]
    private FreeMapManager FreeMapManager
    {
      [Token(Token = "0x60082A3"), Address(RVA = "0x4201354", Offset = "0x4201354", VA = "0x4201354")] get
      {
        return (FreeMapManager) null;
      }
    }

    [Token(Token = "0x60082A4")]
    [Address(RVA = "0x420135C", Offset = "0x420135C", VA = "0x420135C")]
    public CameraWork(FreeMapIconEventHandler eventHandler, FreeMapManager freeMapManager)
    {
    }

    [Token(Token = "0x60082A5")]
    [Address(RVA = "0x4201388", Offset = "0x4201388", VA = "0x4201388")]
    public IFreeMapButtonEventTask GetChangeTask() => (IFreeMapButtonEventTask) null;

    [Token(Token = "0x60082A6")]
    [Address(RVA = "0x4201414", Offset = "0x4201414", VA = "0x4201414")]
    public IFreeMapButtonEventTask GetRevertTask() => (IFreeMapButtonEventTask) null;

    [Token(Token = "0x2001717")]
    private class ChangeTask : IFreeMapButtonEventTask
    {
      [Token(Token = "0x17001471")]
      private CameraWork Parent
      {
        [Token(Token = "0x60082A7"), Address(RVA = "0x42014A0", Offset = "0x42014A0", VA = "0x42014A0")] get
        {
          return (CameraWork) null;
        }
      }

      [Token(Token = "0x60082A8")]
      [Address(RVA = "0x42013EC", Offset = "0x42013EC", VA = "0x42013EC")]
      public ChangeTask(CameraWork parent)
      {
      }

      [Token(Token = "0x60082A9")]
      [Address(RVA = "0x42014A8", Offset = "0x42014A8", VA = "0x42014A8", Slot = "4")]
      public void Execute()
      {
      }

      [Token(Token = "0x60082AA")]
      [Address(RVA = "0x42016B8", Offset = "0x42016B8", VA = "0x42016B8", Slot = "5")]
      public void Update()
      {
      }

      [Token(Token = "0x60082AB")]
      [Address(RVA = "0x42016BC", Offset = "0x42016BC", VA = "0x42016BC", Slot = "6")]
      public bool IsBusy() => new bool();
    }

    [Token(Token = "0x2001718")]
    private class RevertTask : IFreeMapButtonEventTask
    {
      [Token(Token = "0x17001472")]
      private CameraWork Parent
      {
        [Token(Token = "0x60082AC"), Address(RVA = "0x4201754", Offset = "0x4201754", VA = "0x4201754")] get
        {
          return (CameraWork) null;
        }
      }

      [Token(Token = "0x60082AD")]
      [Address(RVA = "0x4201478", Offset = "0x4201478", VA = "0x4201478")]
      public RevertTask(CameraWork parent)
      {
      }

      [Token(Token = "0x60082AE")]
      [Address(RVA = "0x420175C", Offset = "0x420175C", VA = "0x420175C", Slot = "4")]
      public void Execute()
      {
      }

      [Token(Token = "0x60082AF")]
      [Address(RVA = "0x4201854", Offset = "0x4201854", VA = "0x4201854", Slot = "5")]
      public void Update()
      {
      }

      [Token(Token = "0x60082B0")]
      [Address(RVA = "0x4201970", Offset = "0x4201970", VA = "0x4201970", Slot = "6")]
      public bool IsBusy() => new bool();
    }
  }
}
