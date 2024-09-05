// Decompiled with JetBrains decompiler
// Type: Network.Param.StoryFacilityPrepareResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B10")]
  [Serializable]
  public class StoryFacilityPrepareResult
  {
    [Token(Token = "0x400743E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int encounter_detail_id;

    [Token(Token = "0x17001CA0")]
    public int EncounterDetailId
    {
      [Token(Token = "0x6009EBB"), Address(RVA = "0x48F36B8", Offset = "0x48F36B8", VA = "0x48F36B8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EBC"), Address(RVA = "0x48F36C0", Offset = "0x48F36C0", VA = "0x48F36C0")] set
      {
      }
    }

    [Token(Token = "0x6009EBD")]
    [Address(RVA = "0x48F36C8", Offset = "0x48F36C8", VA = "0x48F36C8")]
    public StoryFacilityPrepareResult()
    {
    }
  }
}
