// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionAppIconPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001997")]
  public class FgGIDMissionAppIconPresenter : IFgGIDMissionAppIconPresenter
  {
    [Token(Token = "0x4006DDD")]
    [FieldOffset(Offset = "0x10")]
    private FgGIDMissionAppIconView view;
    [Token(Token = "0x4006DDE")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDAppData data;
    [Token(Token = "0x4006DDF")]
    [FieldOffset(Offset = "0x20")]
    private FgGIDMissionDataManager manager;
    [Token(Token = "0x4006DE0")]
    [FieldOffset(Offset = "0x28")]
    private FgGIDMissionLoader loader;

    [Token(Token = "0x6009207")]
    [Address(RVA = "0x4D0E4B0", Offset = "0x4D0E4B0", VA = "0x4D0E4B0")]
    public FgGIDMissionAppIconPresenter(
      FgGIDMissionAppIconView view,
      FgGIDAppData data,
      FgGIDMissionDataManager manager,
      FgGIDMissionLoader loader)
    {
    }

    [Token(Token = "0x6009208")]
    [Address(RVA = "0x4D0E5F4", Offset = "0x4D0E5F4", VA = "0x4D0E5F4", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6009209")]
    [Address(RVA = "0x4D0E840", Offset = "0x4D0E840", VA = "0x4D0E840", Slot = "5")]
    public void AppIconClicked()
    {
    }

    [Token(Token = "0x600920A")]
    [Address(RVA = "0x4D0E864", Offset = "0x4D0E864", VA = "0x4D0E864")]
    public void OnSelectedAppChanged(FgGIDAppData appData)
    {
    }
  }
}
