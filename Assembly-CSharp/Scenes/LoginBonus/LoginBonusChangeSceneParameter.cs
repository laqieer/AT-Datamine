// Decompiled with JetBrains decompiler
// Type: Scenes.LoginBonus.LoginBonusChangeSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.LoginBonus
{
  [Token(Token = "0x200317D")]
  public class LoginBonusChangeSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x17004087")]
    public bool IsSkipTodayEffect
    {
      [Token(Token = "0x60134EC"), Address(RVA = "0x4A2DB6C", Offset = "0x4A2DB6C", VA = "0x4A2DB6C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60134ED"), Address(RVA = "0x4A2DB74", Offset = "0x4A2DB74", VA = "0x4A2DB74")] private set
      {
      }
    }

    [Token(Token = "0x60134EE")]
    [Address(RVA = "0x4A2DB80", Offset = "0x4A2DB80", VA = "0x4A2DB80")]
    public LoginBonusChangeSceneParameter(bool isSkipTodayEffect)
    {
    }
  }
}
