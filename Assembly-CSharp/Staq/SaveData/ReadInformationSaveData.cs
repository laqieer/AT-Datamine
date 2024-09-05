// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ReadInformationSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D3C")]
  public class ReadInformationSaveData
  {
    [Token(Token = "0x4010D4E")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, bool> readInformation;
    [Token(Token = "0x4010D4F")]
    [FieldOffset(Offset = "0x18")]
    private bool isSaveRequest;

    [Token(Token = "0x1700506E")]
    private string Path
    {
      [Token(Token = "0x6018A35"), Address(RVA = "0x263A4D4", Offset = "0x263A4D4", VA = "0x263A4D4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A36")]
    [Address(RVA = "0x263A524", Offset = "0x263A524", VA = "0x263A524")]
    public bool IsRead(int id) => new bool();

    [Token(Token = "0x6018A37")]
    [Address(RVA = "0x263A5A0", Offset = "0x263A5A0", VA = "0x263A5A0")]
    public void SetRead(int id, bool isRead)
    {
    }

    [Token(Token = "0x6018A38")]
    [Address(RVA = "0x263A624", Offset = "0x263A624", VA = "0x263A624")]
    public List<OfficialInformationArticleType> GetNotReadArticles(
      List<OfficialInformationArticleType> articles)
    {
      return (List<OfficialInformationArticleType>) null;
    }

    [Token(Token = "0x6018A39")]
    [Address(RVA = "0x263A848", Offset = "0x263A848", VA = "0x263A848")]
    public void InitReadInformation(List<int> ids)
    {
    }

    [Token(Token = "0x6018A3A")]
    [Address(RVA = "0x263AD80", Offset = "0x263AD80", VA = "0x263AD80")]
    private string GetPath() => (string) null;

    [Token(Token = "0x6018A3B")]
    [Address(RVA = "0x263ADC8", Offset = "0x263ADC8", VA = "0x263ADC8")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A3C")]
    [Address(RVA = "0x263ADE0", Offset = "0x263ADE0", VA = "0x263ADE0")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A3D")]
    [Address(RVA = "0x263AE10", Offset = "0x263AE10", VA = "0x263AE10")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A3E")]
    [Address(RVA = "0x263AAB4", Offset = "0x263AAB4", VA = "0x263AAB4")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A3F")]
    [Address(RVA = "0x263B0B8", Offset = "0x263B0B8", VA = "0x263B0B8")]
    public ReadInformationSaveData()
    {
    }
  }
}
