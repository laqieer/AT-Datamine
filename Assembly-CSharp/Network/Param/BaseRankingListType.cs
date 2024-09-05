// Decompiled with JetBrains decompiler
// Type: Network.Param.BaseRankingListType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A44")]
  [Serializable]
  public class BaseRankingListType
  {
    [Token(Token = "0x4007053")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int style_id;
    [Token(Token = "0x4007054")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<BasePowerRankingType> ranking_list;

    [Token(Token = "0x17001889")]
    public int StyleId
    {
      [Token(Token = "0x60095EC"), Address(RVA = "0x48EED88", Offset = "0x48EED88", VA = "0x48EED88")] get
      {
        return new int();
      }
      [Token(Token = "0x60095ED"), Address(RVA = "0x48EED90", Offset = "0x48EED90", VA = "0x48EED90")] set
      {
      }
    }

    [Token(Token = "0x1700188A")]
    public List<BasePowerRankingType> RankingList
    {
      [Token(Token = "0x60095EE"), Address(RVA = "0x48EED98", Offset = "0x48EED98", VA = "0x48EED98")] get
      {
        return (List<BasePowerRankingType>) null;
      }
      [Token(Token = "0x60095EF"), Address(RVA = "0x48EEDA0", Offset = "0x48EEDA0", VA = "0x48EEDA0")] set
      {
      }
    }

    [Token(Token = "0x60095F0")]
    [Address(RVA = "0x48EEDA8", Offset = "0x48EEDA8", VA = "0x48EEDA8")]
    public BaseRankingListType()
    {
    }
  }
}
