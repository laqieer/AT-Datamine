// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildTitleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001010")]
  [Serializable]
  public sealed class GuildTitleData : IMasterDataEntity, ITitleMasterData
  {
    [Token(Token = "0x4004FF4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FF5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int titleType;
    [Token(Token = "0x4004FF6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int size;
    [Token(Token = "0x4004FF7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string colorCode;
    [Token(Token = "0x4004FF8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int spriteId;

    [Token(Token = "0x17000DC6")]
    public int Key
    {
      [Token(Token = "0x6005D90"), Address(RVA = "0x2794D98", Offset = "0x2794D98", VA = "0x2794D98", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D91")]
    [Address(RVA = "0x2794DA0", Offset = "0x2794DA0", VA = "0x2794DA0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D92")]
    [Address(RVA = "0x2794FCC", Offset = "0x2794FCC", VA = "0x2794FCC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DC7")]
    private int GameCore\u002EMasterData\u002EITitleMasterData\u002ETitleId
    {
      [Token(Token = "0x6005D93"), Address(RVA = "0x2795084", Offset = "0x2795084", VA = "0x2795084", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DC8")]
    private TitleTypeEnum GameCore\u002EMasterData\u002EITitleMasterData\u002ETitleType
    {
      [Token(Token = "0x6005D94"), Address(RVA = "0x279508C", Offset = "0x279508C", VA = "0x279508C", Slot = "8")] get
      {
        return new TitleTypeEnum();
      }
    }

    [Token(Token = "0x17000DC9")]
    private string GameCore\u002EMasterData\u002EITitleMasterData\u002EText
    {
      [Token(Token = "0x6005D95"), Address(RVA = "0x2795094", Offset = "0x2795094", VA = "0x2795094", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DCA")]
    private int? GameCore\u002EMasterData\u002EITitleMasterData\u002ESpriteId
    {
      [Token(Token = "0x6005D96"), Address(RVA = "0x2795174", Offset = "0x2795174", VA = "0x2795174", Slot = "10")] get
      {
        return new int?();
      }
    }

    [Token(Token = "0x17000DCB")]
    private int? GameCore\u002EMasterData\u002EITitleMasterData\u002ESize
    {
      [Token(Token = "0x6005D97"), Address(RVA = "0x27951D8", Offset = "0x27951D8", VA = "0x27951D8", Slot = "11")] get
      {
        return new int?();
      }
    }

    [Token(Token = "0x17000DCC")]
    private string GameCore\u002EMasterData\u002EITitleMasterData\u002EColorCode
    {
      [Token(Token = "0x6005D98"), Address(RVA = "0x279523C", Offset = "0x279523C", VA = "0x279523C", Slot = "12")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DCD")]
    private string GameCore\u002EMasterData\u002EITitleMasterData\u002EUnlockDescription
    {
      [Token(Token = "0x6005D99"), Address(RVA = "0x2795244", Offset = "0x2795244", VA = "0x2795244", Slot = "13")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DCE")]
    public string Name
    {
      [Token(Token = "0x6005D9A"), Address(RVA = "0x2795098", Offset = "0x2795098", VA = "0x2795098")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DCF")]
    public string UnlockDescription
    {
      [Token(Token = "0x6005D9B"), Address(RVA = "0x2795248", Offset = "0x2795248", VA = "0x2795248")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005D9C")]
    [Address(RVA = "0x2795324", Offset = "0x2795324", VA = "0x2795324")]
    public GuildTitleData()
    {
    }
  }
}
