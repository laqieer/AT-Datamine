// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCustom_skillFavoriteResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB8")]
  [Serializable]
  public class APIUnitCustom_skillFavoriteResponse
  {
    [Token(Token = "0x40083FA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerUnitCustomSkillType> custom_skills;

    [Token(Token = "0x170025A3")]
    public List<PlayerUnitCustomSkillType> CustomSkills
    {
      [Token(Token = "0x600B66C"), Address(RVA = "0x22EC850", Offset = "0x22EC850", VA = "0x22EC850")] get
      {
        return (List<PlayerUnitCustomSkillType>) null;
      }
    }

    [Token(Token = "0x600B66D")]
    [Address(RVA = "0x22EC858", Offset = "0x22EC858", VA = "0x22EC858")]
    public APIUnitCustom_skillFavoriteResponse()
    {
    }
  }
}
