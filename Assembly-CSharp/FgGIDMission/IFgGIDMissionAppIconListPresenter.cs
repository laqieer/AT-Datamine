// Decompiled with JetBrains decompiler
// Type: FgGIDMission.IFgGIDMissionAppIconListPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001994")]
  public interface IFgGIDMissionAppIconListPresenter
  {
    [Token(Token = "0x60091FE")]
    void AssignListItemPresenter(FgGIDMissionAppIconView view, int index);

    [Token(Token = "0x60091FF")]
    void AssignBlankListItemPresenter(FgGIDMissionAppIconView view, int index);

    [Token(Token = "0x6009200")]
    void Initialize();
  }
}
