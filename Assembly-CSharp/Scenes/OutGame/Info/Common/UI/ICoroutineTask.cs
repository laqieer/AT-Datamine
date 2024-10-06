// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.ICoroutineTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035D8")]
  public interface ICoroutineTask
  {
    [Token(Token = "0x170046A9")]
    bool Queueing { [Token(Token = "0x6015364")] get; }

    [Token(Token = "0x6015365")]
    IEnumerator LoadAsync();

    [Token(Token = "0x6015366")]
    void OnRelease();
  }
}
