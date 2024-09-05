// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryChapterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012DB")]
  [Serializable]
  public sealed class StoryChapterData : IMasterDataEntity
  {
    [Token(Token = "0x4005981")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005982")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005983")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int startSequenceId;
    [Token(Token = "0x4005984")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int resourceCharaId;
    [Token(Token = "0x4005985")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int charaId;
    [Token(Token = "0x4005986")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int styleId;
    [Token(Token = "0x4005987")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int beginYearID;
    [Token(Token = "0x4005988")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int endYearID;

    [Token(Token = "0x17001022")]
    public int Key
    {
      [Token(Token = "0x6006AC8"), Address(RVA = "0x48DC4A4", Offset = "0x48DC4A4", VA = "0x48DC4A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006AC9")]
    [Address(RVA = "0x48DC4AC", Offset = "0x48DC4AC", VA = "0x48DC4AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006ACA")]
    [Address(RVA = "0x48DC7F8", Offset = "0x48DC7F8", VA = "0x48DC7F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001023")]
    public string SubTitle
    {
      [Token(Token = "0x6006ACB"), Address(RVA = "0x48DC8E0", Offset = "0x48DC8E0", VA = "0x48DC8E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001024")]
    public string Place
    {
      [Token(Token = "0x6006ACC"), Address(RVA = "0x48DC9BC", Offset = "0x48DC9BC", VA = "0x48DC9BC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006ACD")]
    [Address(RVA = "0x48DCA98", Offset = "0x48DCA98", VA = "0x48DCA98")]
    public StoryChapterData()
    {
    }
  }
}
