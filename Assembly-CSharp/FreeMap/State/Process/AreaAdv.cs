// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.AreaAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017A1")]
  public class AreaAdv : FreeMapProcess
  {
    [Token(Token = "0x4006872")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapAreaAdvPlayer areaAdvPlayer;

    [Token(Token = "0x600861A")]
    [Address(RVA = "0x406ED9C", Offset = "0x406ED9C", VA = "0x406ED9C")]
    public AreaAdv(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600861B")]
    [Address(RVA = "0x406EE48", Offset = "0x406EE48", VA = "0x406EE48", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600861C")]
    [Address(RVA = "0x406EF38", Offset = "0x406EF38", VA = "0x406EF38")]
    private IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x600861D")]
    [Address(RVA = "0x406EFC8", Offset = "0x406EFC8", VA = "0x406EFC8")]
    private void OnAdvEnd()
    {
    }

    [Token(Token = "0x600861E")]
    [Address(RVA = "0x406F02C", Offset = "0x406F02C", VA = "0x406F02C")]
    public void Register(FreeMapAreaAdvPlayer.PlayData advPlayData)
    {
    }

    [Token(Token = "0x600861F")]
    [Address(RVA = "0x406F094", Offset = "0x406F094", VA = "0x406F094")]
    public bool SetupToPlayForFreeActionStart(int telopLabel, out AdvDemoInfoData demo)
    {
      return new bool();
    }
  }
}
