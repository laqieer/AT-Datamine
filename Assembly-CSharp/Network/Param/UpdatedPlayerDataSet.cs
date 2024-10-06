// Decompiled with JetBrains decompiler
// Type: Network.Param.UpdatedPlayerDataSet
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
  [Token(Token = "0x2001B15")]
  [Serializable]
  public class UpdatedPlayerDataSet
  {
    [Token(Token = "0x4007460")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;
    [Token(Token = "0x4007461")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerUnits updated_player_units;
    [Token(Token = "0x4007462")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UpdatedPlayerEquipments updated_player_equipments;
    [Token(Token = "0x4007463")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UpdatedPlayerStoryDataSet updated_player_story_data_set;
    [Token(Token = "0x4007464")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Reward> unreceived_rewards;

    [Token(Token = "0x17001CC2")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x6009F04"), Address(RVA = "0x48F3904", Offset = "0x48F3904", VA = "0x48F3904")] get
      {
        return (UpdatedPlayerItems) null;
      }
      [Token(Token = "0x6009F05"), Address(RVA = "0x48F390C", Offset = "0x48F390C", VA = "0x48F390C")] set
      {
      }
    }

    [Token(Token = "0x17001CC3")]
    public UpdatedPlayerUnits UpdatedPlayerUnits
    {
      [Token(Token = "0x6009F06"), Address(RVA = "0x48F3914", Offset = "0x48F3914", VA = "0x48F3914")] get
      {
        return (UpdatedPlayerUnits) null;
      }
      [Token(Token = "0x6009F07"), Address(RVA = "0x48F391C", Offset = "0x48F391C", VA = "0x48F391C")] set
      {
      }
    }

    [Token(Token = "0x17001CC4")]
    public UpdatedPlayerEquipments UpdatedPlayerEquipments
    {
      [Token(Token = "0x6009F08"), Address(RVA = "0x48F3924", Offset = "0x48F3924", VA = "0x48F3924")] get
      {
        return (UpdatedPlayerEquipments) null;
      }
      [Token(Token = "0x6009F09"), Address(RVA = "0x48F392C", Offset = "0x48F392C", VA = "0x48F392C")] set
      {
      }
    }

    [Token(Token = "0x17001CC5")]
    public UpdatedPlayerStoryDataSet UpdatedPlayerStoryDataSet
    {
      [Token(Token = "0x6009F0A"), Address(RVA = "0x48F3934", Offset = "0x48F3934", VA = "0x48F3934")] get
      {
        return (UpdatedPlayerStoryDataSet) null;
      }
      [Token(Token = "0x6009F0B"), Address(RVA = "0x48F393C", Offset = "0x48F393C", VA = "0x48F393C")] set
      {
      }
    }

    [Token(Token = "0x17001CC6")]
    public List<Reward> UnreceivedRewards
    {
      [Token(Token = "0x6009F0C"), Address(RVA = "0x48F3944", Offset = "0x48F3944", VA = "0x48F3944")] get
      {
        return (List<Reward>) null;
      }
      [Token(Token = "0x6009F0D"), Address(RVA = "0x48F394C", Offset = "0x48F394C", VA = "0x48F394C")] set
      {
      }
    }

    [Token(Token = "0x6009F0E")]
    [Address(RVA = "0x48F3954", Offset = "0x48F3954", VA = "0x48F3954")]
    public UpdatedPlayerDataSet()
    {
    }
  }
}
