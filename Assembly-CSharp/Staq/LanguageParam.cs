// Decompiled with JetBrains decompiler
// Type: staq.LanguageParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C45")]
  public class LanguageParam
  {
    [Token(Token = "0x17004D2F")]
    public LanguageEnum Id
    {
      [Token(Token = "0x6017B24"), Address(RVA = "0x238C0F4", Offset = "0x238C0F4", VA = "0x238C0F4")] get
      {
        return new LanguageEnum();
      }
      [Token(Token = "0x6017B25"), Address(RVA = "0x238C0FC", Offset = "0x238C0FC", VA = "0x238C0FC")] private set
      {
      }
    }

    [Token(Token = "0x17004D30")]
    public SystemLanguage SysCode
    {
      [Token(Token = "0x6017B26"), Address(RVA = "0x238C104", Offset = "0x238C104", VA = "0x238C104")] get
      {
        return new SystemLanguage();
      }
      [Token(Token = "0x6017B27"), Address(RVA = "0x238C10C", Offset = "0x238C10C", VA = "0x238C10C")] private set
      {
      }
    }

    [Token(Token = "0x6017B28")]
    [Address(RVA = "0x238C0C8", Offset = "0x238C0C8", VA = "0x238C0C8")]
    public LanguageParam(LanguageEnum id, SystemLanguage sysLanguageCode)
    {
    }
  }
}
