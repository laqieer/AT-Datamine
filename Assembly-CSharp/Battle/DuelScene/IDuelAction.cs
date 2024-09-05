// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.IDuelAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002550")]
  public interface IDuelAction
  {
    [Token(Token = "0x14000139")]
    event OnCompletedAction OnComplete;

    [Token(Token = "0x17003178")]
    float TimeScale { [Token(Token = "0x600E64A")] get; [Token(Token = "0x600E64B")] set; }

    [Token(Token = "0x600E64C")]
    void Initialize(DuelData data, ActionData targetActionData, IDirector mainDirector);

    [Token(Token = "0x600E64D")]
    void RequestStaging();
  }
}
