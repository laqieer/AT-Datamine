// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017D7")]
  public class FreeMapStart : FreeMapProcess
  {
    [Token(Token = "0x60086FB")]
    [Address(RVA = "0x43D3144", Offset = "0x43D3144", VA = "0x43D3144")]
    public FreeMapStart(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60086FC")]
    [Address(RVA = "0x43D3148", Offset = "0x43D3148", VA = "0x43D3148")]
    public static FreeMapProcess PreLoad(
      FreeMapStateManager entity,
      StoryFreeActionSettingData setting)
    {
      return (FreeMapProcess) null;
    }

    [Token(Token = "0x60086FD")]
    [Address(RVA = "0x43D3340", Offset = "0x43D3340", VA = "0x43D3340", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x20017D8")]
    private class AreaSetup : FreeMapProcess
    {
      [Token(Token = "0x60086FE")]
      [Address(RVA = "0x43D333C", Offset = "0x43D333C", VA = "0x43D333C")]
      public AreaSetup(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60086FF")]
      [Address(RVA = "0x43D35A0", Offset = "0x43D35A0", VA = "0x43D35A0", Slot = "4")]
      public override void Begin()
      {
      }
    }

    [Token(Token = "0x20017D9")]
    private class AreaStarted : FreeMapProcess
    {
      [Token(Token = "0x6008700")]
      [Address(RVA = "0x43D359C", Offset = "0x43D359C", VA = "0x43D359C")]
      public AreaStarted(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x6008701")]
      [Address(RVA = "0x43D3724", Offset = "0x43D3724", VA = "0x43D3724", Slot = "4")]
      public override void Begin()
      {
      }
    }
  }
}
