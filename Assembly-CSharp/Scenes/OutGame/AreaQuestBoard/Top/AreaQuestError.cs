// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestError
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F2")]
  public class AreaQuestError
  {
    [Token(Token = "0x400F909")]
    [FieldOffset(Offset = "0x10")]
    private Action<string> onError;

    [Token(Token = "0x6016631")]
    [Address(RVA = "0x207CFA4", Offset = "0x207CFA4", VA = "0x207CFA4")]
    public AreaQuestError(Action<string> onErrorAction)
    {
    }

    [Token(Token = "0x6016632")]
    [Address(RVA = "0x207D480", Offset = "0x207D480", VA = "0x207D480")]
    public void OnInvalidPlayableArea()
    {
    }
  }
}
