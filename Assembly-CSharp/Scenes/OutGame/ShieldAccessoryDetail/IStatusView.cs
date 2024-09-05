// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.IStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Utility;

#nullable disable
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x200338A")]
  public interface IStatusView
  {
    [Token(Token = "0x60143FD")]
    void SetVisible(bool isVisible);

    [Token(Token = "0x60143FE")]
    void UpdateStatus(AccessoryStandardStatus status, AccessoryStandardStatus assumption = null);
  }
}
