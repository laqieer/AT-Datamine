// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStageCommunication
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x200074B")]
  public class AdvStageCommunication : AdvStage, HaveStoryAlreadyReadAdvOption
  {
    [Token(Token = "0x17000608")]
    public int SelectedNormalCommuItemId
    {
      [Token(Token = "0x60028CD"), Address(RVA = "0x3678EA8", Offset = "0x3678EA8", VA = "0x3678EA8")] get
      {
        return new int();
      }
      [Token(Token = "0x60028CE"), Address(RVA = "0x3678EB0", Offset = "0x3678EB0", VA = "0x3678EB0")] private set
      {
      }
    }

    [Token(Token = "0x17000609")]
    public int CommuID
    {
      [Token(Token = "0x60028CF"), Address(RVA = "0x3678EB8", Offset = "0x3678EB8", VA = "0x3678EB8")] get
      {
        return new int();
      }
      [Token(Token = "0x60028D0"), Address(RVA = "0x3678EC0", Offset = "0x3678EC0", VA = "0x3678EC0")] private set
      {
      }
    }

    [Token(Token = "0x1700060A")]
    public int LocationID
    {
      [Token(Token = "0x60028D1"), Address(RVA = "0x3678EC8", Offset = "0x3678EC8", VA = "0x3678EC8")] get
      {
        return new int();
      }
      [Token(Token = "0x60028D2"), Address(RVA = "0x3678ED0", Offset = "0x3678ED0", VA = "0x3678ED0")] private set
      {
      }
    }

    [Token(Token = "0x60028D3")]
    [Address(RVA = "0x3678ED8", Offset = "0x3678ED8", VA = "0x3678ED8")]
    public AdvStageCommunication(
      int commuID,
      int locationID,
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
    }

    [Token(Token = "0x60028D4")]
    [Address(RVA = "0x3678F10", Offset = "0x3678F10", VA = "0x3678F10")]
    public void SetSelectedNormalCommuItemId(int itemId)
    {
    }

    [Token(Token = "0x60028D5")]
    [Address(RVA = "0x3678F18", Offset = "0x3678F18", VA = "0x3678F18")]
    public CommunicationLuaFunction.Object CreateObject() => (CommunicationLuaFunction.Object) null;
  }
}
