// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionBoxType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA7")]
  [Serializable]
  public class PlayerExpeditionBoxType
  {
    [Token(Token = "0x400723B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x400723C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int stage_item_drop_description_id;

    [Token(Token = "0x17001A88")]
    public string Id
    {
      [Token(Token = "0x6009A37"), Address(RVA = "0x48F10B4", Offset = "0x48F10B4", VA = "0x48F10B4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A38"), Address(RVA = "0x48F10BC", Offset = "0x48F10BC", VA = "0x48F10BC")] set
      {
      }
    }

    [Token(Token = "0x17001A89")]
    public int StageItemDropDescriptionId
    {
      [Token(Token = "0x6009A39"), Address(RVA = "0x48F10C4", Offset = "0x48F10C4", VA = "0x48F10C4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A3A"), Address(RVA = "0x48F10CC", Offset = "0x48F10CC", VA = "0x48F10CC")] set
      {
      }
    }

    [Token(Token = "0x6009A3B")]
    [Address(RVA = "0x48F10D4", Offset = "0x48F10D4", VA = "0x48F10D4")]
    public PlayerExpeditionBoxType()
    {
    }
  }
}
