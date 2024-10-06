// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EC3")]
  [MoonSharpUserData]
  public class LuaRewardItem : IRewardPopupElement
  {
    [Token(Token = "0x170051DA")]
    public RewardTypeEnum Type
    {
      [Token(Token = "0x60194CA"), Address(RVA = "0x2FF748C", Offset = "0x2FF748C", VA = "0x2FF748C")] get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x60194CB"), Address(RVA = "0x2FF7494", Offset = "0x2FF7494", VA = "0x2FF7494")] set
      {
      }
    }

    [Token(Token = "0x170051DB")]
    public int ID
    {
      [Token(Token = "0x60194CC"), Address(RVA = "0x2FF749C", Offset = "0x2FF749C", VA = "0x2FF749C")] get
      {
        return new int();
      }
      [Token(Token = "0x60194CD"), Address(RVA = "0x2FF74A4", Offset = "0x2FF74A4", VA = "0x2FF74A4")] set
      {
      }
    }

    [Token(Token = "0x170051DC")]
    public int Amount
    {
      [Token(Token = "0x60194CE"), Address(RVA = "0x2FF74AC", Offset = "0x2FF74AC", VA = "0x2FF74AC")] get
      {
        return new int();
      }
      [Token(Token = "0x60194CF"), Address(RVA = "0x2FF74B4", Offset = "0x2FF74B4", VA = "0x2FF74B4")] set
      {
      }
    }

    [Token(Token = "0x170051DD")]
    public DisplayItemRewardInfoData Reward
    {
      [Token(Token = "0x60194D0"), Address(RVA = "0x2FF722C", Offset = "0x2FF722C", VA = "0x2FF722C", Slot = "4")] get
      {
        return new DisplayItemRewardInfoData();
      }
    }

    [Token(Token = "0x60194D1")]
    [Address(RVA = "0x2FF74BC", Offset = "0x2FF74BC", VA = "0x2FF74BC")]
    public LuaRewardItem()
    {
    }
  }
}
