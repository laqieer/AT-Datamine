// Decompiled with JetBrains decompiler
// Type: staq.SaveData.FreeMapNotifySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D12")]
  public class FreeMapNotifySaveData
  {
    [Token(Token = "0x4010CD4")]
    [FieldOffset(Offset = "0x10")]
    private List<FreeMapNotifySaveData.NotifyData> notifyDataList;

    [Token(Token = "0x1700502A")]
    public static string Path
    {
      [Token(Token = "0x60188B2"), Address(RVA = "0x2940394", Offset = "0x2940394", VA = "0x2940394")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700502B")]
    public bool loaded
    {
      [Token(Token = "0x60188B3"), Address(RVA = "0x29403E4", Offset = "0x29403E4", VA = "0x29403E4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60188B4"), Address(RVA = "0x29403EC", Offset = "0x29403EC", VA = "0x29403EC")] private set
      {
      }
    }

    [Token(Token = "0x60188B5")]
    [Address(RVA = "0x29403F8", Offset = "0x29403F8", VA = "0x29403F8")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60188B6")]
    [Address(RVA = "0x2940440", Offset = "0x2940440", VA = "0x2940440")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60188B7")]
    [Address(RVA = "0x2940470", Offset = "0x2940470", VA = "0x2940470")]
    public void Delete()
    {
    }

    [Token(Token = "0x60188B8")]
    [Address(RVA = "0x294048C", Offset = "0x294048C", VA = "0x294048C")]
    public void Load()
    {
    }

    [Token(Token = "0x60188B9")]
    [Address(RVA = "0x294079C", Offset = "0x294079C", VA = "0x294079C")]
    public void Save()
    {
    }

    [Token(Token = "0x60188BA")]
    [Address(RVA = "0x2940A00", Offset = "0x2940A00", VA = "0x2940A00")]
    public bool IsContainsID(StoryNotifyTypeEnum type, int capterID, int id) => new bool();

    [Token(Token = "0x60188BB")]
    [Address(RVA = "0x2940B04", Offset = "0x2940B04", VA = "0x2940B04")]
    public void AddData(StoryNotifyTypeEnum type, int capterID, int id)
    {
    }

    [Token(Token = "0x60188BC")]
    [Address(RVA = "0x2940BE8", Offset = "0x2940BE8", VA = "0x2940BE8")]
    public FreeMapNotifySaveData()
    {
    }

    [Token(Token = "0x2003D13")]
    private struct NotifyData
    {
      [Token(Token = "0x4010CD6")]
      [FieldOffset(Offset = "0x0")]
      public StoryNotifyTypeEnum type;
      [Token(Token = "0x4010CD7")]
      [FieldOffset(Offset = "0x4")]
      public int capterID;
      [Token(Token = "0x4010CD8")]
      [FieldOffset(Offset = "0x8")]
      public int id;
    }
  }
}
