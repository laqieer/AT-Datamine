// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.Data.ChatDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Chat.Data
{
  [Token(Token = "0x20030EE")]
  public class ChatDataManager
  {
    [Token(Token = "0x400D048")]
    [FieldOffset(Offset = "0x58")]
    public List<Sprite> playerStampIconList;

    [Token(Token = "0x17004010")]
    public int currentCategoryID
    {
      [Token(Token = "0x60131CA"), Address(RVA = "0x45DBB34", Offset = "0x45DBB34", VA = "0x45DBB34")] get
      {
        return new int();
      }
      [Token(Token = "0x60131CB"), Address(RVA = "0x45DBB3C", Offset = "0x45DBB3C", VA = "0x45DBB3C")] private set
      {
      }
    }

    [Token(Token = "0x17004011")]
    public int currentChannelID
    {
      [Token(Token = "0x60131CC"), Address(RVA = "0x45DBB44", Offset = "0x45DBB44", VA = "0x45DBB44")] get
      {
        return new int();
      }
      [Token(Token = "0x60131CD"), Address(RVA = "0x45DBB4C", Offset = "0x45DBB4C", VA = "0x45DBB4C")] private set
      {
      }
    }

    [Token(Token = "0x17004012")]
    public int currentRoomID
    {
      [Token(Token = "0x60131CE"), Address(RVA = "0x45DBB54", Offset = "0x45DBB54", VA = "0x45DBB54")] get
      {
        return new int();
      }
      [Token(Token = "0x60131CF"), Address(RVA = "0x45DBB5C", Offset = "0x45DBB5C", VA = "0x45DBB5C")] private set
      {
      }
    }

    [Token(Token = "0x17004013")]
    public int currentRoomMasterID
    {
      [Token(Token = "0x60131D0"), Address(RVA = "0x45DBB64", Offset = "0x45DBB64", VA = "0x45DBB64")] get
      {
        return new int();
      }
      [Token(Token = "0x60131D1"), Address(RVA = "0x45DBB6C", Offset = "0x45DBB6C", VA = "0x45DBB6C")] private set
      {
      }
    }

    [Token(Token = "0x17004014")]
    public int currentStampID
    {
      [Token(Token = "0x60131D2"), Address(RVA = "0x45DBB74", Offset = "0x45DBB74", VA = "0x45DBB74")] get
      {
        return new int();
      }
      [Token(Token = "0x60131D3"), Address(RVA = "0x45DBB7C", Offset = "0x45DBB7C", VA = "0x45DBB7C")] private set
      {
      }
    }

    [Token(Token = "0x17004015")]
    public string currentPhraseContent
    {
      [Token(Token = "0x60131D4"), Address(RVA = "0x45DBB84", Offset = "0x45DBB84", VA = "0x45DBB84")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60131D5"), Address(RVA = "0x45DBB8C", Offset = "0x45DBB8C", VA = "0x45DBB8C")] private set
      {
      }
    }

    [Token(Token = "0x17004016")]
    public int simpleMessageCurrentCategoryID
    {
      [Token(Token = "0x60131D6"), Address(RVA = "0x45DBB94", Offset = "0x45DBB94", VA = "0x45DBB94")] get
      {
        return new int();
      }
      [Token(Token = "0x60131D7"), Address(RVA = "0x45DBB9C", Offset = "0x45DBB9C", VA = "0x45DBB9C")] private set
      {
      }
    }

    [Token(Token = "0x17004017")]
    public Dictionary<int, DateTime> lastMsgSendTime
    {
      [Token(Token = "0x60131D8"), Address(RVA = "0x45DBBA4", Offset = "0x45DBBA4", VA = "0x45DBBA4")] get
      {
        return (Dictionary<int, DateTime>) null;
      }
      [Token(Token = "0x60131D9"), Address(RVA = "0x45DBBAC", Offset = "0x45DBBAC", VA = "0x45DBBAC")] private set
      {
      }
    }

    [Token(Token = "0x17004018")]
    public string lastSampleMessageID
    {
      [Token(Token = "0x60131DA"), Address(RVA = "0x45DBBB4", Offset = "0x45DBBB4", VA = "0x45DBBB4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60131DB"), Address(RVA = "0x45DBBBC", Offset = "0x45DBBBC", VA = "0x45DBBBC")] private set
      {
      }
    }

    [Token(Token = "0x17004019")]
    public bool chatSimpleMessageState
    {
      [Token(Token = "0x60131DC"), Address(RVA = "0x45DBBC4", Offset = "0x45DBBC4", VA = "0x45DBBC4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60131DD"), Address(RVA = "0x45DBBCC", Offset = "0x45DBBCC", VA = "0x45DBBCC")] private set
      {
      }
    }

    [Token(Token = "0x1700401A")]
    public bool chatGuidelineState
    {
      [Token(Token = "0x60131DE"), Address(RVA = "0x45DBBD8", Offset = "0x45DBBD8", VA = "0x45DBBD8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60131DF"), Address(RVA = "0x45DBBE0", Offset = "0x45DBBE0", VA = "0x45DBBE0")] private set
      {
      }
    }

    [Token(Token = "0x1700401B")]
    public string chatGuidelineVersion
    {
      [Token(Token = "0x60131E0"), Address(RVA = "0x45DBBEC", Offset = "0x45DBBEC", VA = "0x45DBBEC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60131E1"), Address(RVA = "0x45DBBF4", Offset = "0x45DBBF4", VA = "0x45DBBF4")] private set
      {
      }
    }

    [Token(Token = "0x60131E2")]
    [Address(RVA = "0x45DBBFC", Offset = "0x45DBBFC", VA = "0x45DBBFC")]
    public void SetCurrentDialogCategoryID(int categoryID, bool save = false)
    {
    }

    [Token(Token = "0x60131E3")]
    [Address(RVA = "0x45DBDCC", Offset = "0x45DBDCC", VA = "0x45DBDCC")]
    public void SetCurrentChannelID(int channelID)
    {
    }

    [Token(Token = "0x60131E4")]
    [Address(RVA = "0x45DBDD4", Offset = "0x45DBDD4", VA = "0x45DBDD4")]
    public void SetCurrentRoomID(int roomID)
    {
    }

    [Token(Token = "0x60131E5")]
    [Address(RVA = "0x45DBDDC", Offset = "0x45DBDDC", VA = "0x45DBDDC")]
    public void SetCurrentRoomMasterID(int materID)
    {
    }

    [Token(Token = "0x60131E6")]
    [Address(RVA = "0x45D6218", Offset = "0x45D6218", VA = "0x45D6218")]
    public void SetCurrentStampID(int stampID)
    {
    }

    [Token(Token = "0x60131E7")]
    [Address(RVA = "0x45D8FCC", Offset = "0x45D8FCC", VA = "0x45D8FCC")]
    public void SetCurrentFixedPhraseContent(string content)
    {
    }

    [Token(Token = "0x60131E8")]
    [Address(RVA = "0x45D9A8C", Offset = "0x45D9A8C", VA = "0x45D9A8C")]
    public void SetLastMsgSendTime(int category, DateTime lastTime)
    {
    }

    [Token(Token = "0x60131E9")]
    [Address(RVA = "0x45D7CA8", Offset = "0x45D7CA8", VA = "0x45D7CA8")]
    public void SetLastSampleMessageID(string lastMsgID)
    {
    }

    [Token(Token = "0x60131EA")]
    [Address(RVA = "0x45DAA24", Offset = "0x45DAA24", VA = "0x45DAA24")]
    public void SetChatSimpleMssageState(bool state, bool save = false)
    {
    }

    [Token(Token = "0x60131EB")]
    [Address(RVA = "0x45D8628", Offset = "0x45D8628", VA = "0x45D8628")]
    public void SetChatGuidelineState(bool state, string version, bool save = false)
    {
    }

    [Token(Token = "0x60131EC")]
    [Address(RVA = "0x45DA924", Offset = "0x45DA924", VA = "0x45DA924")]
    public void SetSimpleMessageCurrentCategoryID(int simpleCategoryID, bool save = false)
    {
    }

    [Token(Token = "0x60131ED")]
    [Address(RVA = "0x45DBDE4", Offset = "0x45DBDE4", VA = "0x45DBDE4")]
    public ChatDataManager()
    {
    }
  }
}
