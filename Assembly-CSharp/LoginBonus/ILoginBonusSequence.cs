// Decompiled with JetBrains decompiler
// Type: LoginBonus.ILoginBonusSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000ADD")]
  public interface ILoginBonusSequence
  {
    [Token(Token = "0x6003DDF")]
    void PrepareStart();

    [Token(Token = "0x6003DE0")]
    void Start();

    [Token(Token = "0x6003DE1")]
    void Release();

    [Token(Token = "0x170008E6")]
    bool IsPrepareStartCalled { [Token(Token = "0x6003DE2")] get; }

    [Token(Token = "0x170008E7")]
    bool IsFinished { [Token(Token = "0x6003DE3")] get; }

    [Token(Token = "0x170008E8")]
    bool IsReady { [Token(Token = "0x6003DE4")] get; }

    [Token(Token = "0x170008E9")]
    LoginBonusTypeEnum LoginBonusType { [Token(Token = "0x6003DE5")] get; }
  }
}
