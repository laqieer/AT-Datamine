// Decompiled with JetBrains decompiler
// Type: Network.Param.UpdatedPlayerStoryDataSet
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
  [Token(Token = "0x2001B18")]
  [Serializable]
  public class UpdatedPlayerStoryDataSet
  {
    [Token(Token = "0x400747F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerStoryPointType> story_points;
    [Token(Token = "0x4007480")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<int> new_story_ability_ids;
    [Token(Token = "0x4007481")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerStoryHumanParameterType> human_parameters;
    [Token(Token = "0x4007482")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerStoryCommunicationType> communications;

    [Token(Token = "0x17001CE1")]
    public List<PlayerStoryPointType> StoryPoints
    {
      [Token(Token = "0x6009F45"), Address(RVA = "0x46BE6E4", Offset = "0x46BE6E4", VA = "0x46BE6E4")] get
      {
        return (List<PlayerStoryPointType>) null;
      }
      [Token(Token = "0x6009F46"), Address(RVA = "0x46BE6EC", Offset = "0x46BE6EC", VA = "0x46BE6EC")] set
      {
      }
    }

    [Token(Token = "0x17001CE2")]
    public List<int> NewStoryAbilityIds
    {
      [Token(Token = "0x6009F47"), Address(RVA = "0x46BE6F4", Offset = "0x46BE6F4", VA = "0x46BE6F4")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009F48"), Address(RVA = "0x46BE6FC", Offset = "0x46BE6FC", VA = "0x46BE6FC")] set
      {
      }
    }

    [Token(Token = "0x17001CE3")]
    public List<PlayerStoryHumanParameterType> HumanParameters
    {
      [Token(Token = "0x6009F49"), Address(RVA = "0x46BE704", Offset = "0x46BE704", VA = "0x46BE704")] get
      {
        return (List<PlayerStoryHumanParameterType>) null;
      }
      [Token(Token = "0x6009F4A"), Address(RVA = "0x46BE70C", Offset = "0x46BE70C", VA = "0x46BE70C")] set
      {
      }
    }

    [Token(Token = "0x17001CE4")]
    public List<PlayerStoryCommunicationType> Communications
    {
      [Token(Token = "0x6009F4B"), Address(RVA = "0x46BE714", Offset = "0x46BE714", VA = "0x46BE714")] get
      {
        return (List<PlayerStoryCommunicationType>) null;
      }
      [Token(Token = "0x6009F4C"), Address(RVA = "0x46BE71C", Offset = "0x46BE71C", VA = "0x46BE71C")] set
      {
      }
    }

    [Token(Token = "0x6009F4D")]
    [Address(RVA = "0x46BE724", Offset = "0x46BE724", VA = "0x46BE724")]
    public UpdatedPlayerStoryDataSet()
    {
    }
  }
}
