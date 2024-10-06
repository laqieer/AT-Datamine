// Decompiled with JetBrains decompiler
// Type: staq.SaveData.FreeMapSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D15")]
  public class FreeMapSaveData
  {
    [Token(Token = "0x4010CDF")]
    [FieldOffset(Offset = "0x28")]
    public Dictionary<int, FreeMapSaveData.StartPosition> StartPositionDic;
    [Token(Token = "0x4010CE0")]
    [FieldOffset(Offset = "0x30")]
    public HashSet<FreeMapSaveData.AreaIntroduction> WatchedAreaIntroduction;
    [Token(Token = "0x4010CE1")]
    [FieldOffset(Offset = "0x38")]
    public HashSet<FreeMapSaveData.AlreadyRead> AlreadyReadTalkAdvEvents;
    [Token(Token = "0x4010CE2")]
    [FieldOffset(Offset = "0x40")]
    public HashSet<FreeMapSaveData.AlreadyRead> AlreadyReadFlavorEvents;

    [Token(Token = "0x1700502C")]
    private bool isModified
    {
      [Token(Token = "0x60188BF"), Address(RVA = "0x2940C98", Offset = "0x2940C98", VA = "0x2940C98")] set
      {
      }
      [Token(Token = "0x60188C0"), Address(RVA = "0x2940CA4", Offset = "0x2940CA4", VA = "0x2940CA4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700502D")]
    private string saveVersion
    {
      [Token(Token = "0x60188C1"), Address(RVA = "0x2940CAC", Offset = "0x2940CAC", VA = "0x2940CAC")] set
      {
      }
      [Token(Token = "0x60188C2"), Address(RVA = "0x2940CB4", Offset = "0x2940CB4", VA = "0x2940CB4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700502E")]
    public bool loaded
    {
      [Token(Token = "0x60188C3"), Address(RVA = "0x2940CBC", Offset = "0x2940CBC", VA = "0x2940CBC")] private set
      {
      }
      [Token(Token = "0x60188C4"), Address(RVA = "0x2940CC8", Offset = "0x2940CC8", VA = "0x2940CC8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700502F")]
    public static string Path
    {
      [Token(Token = "0x60188C5"), Address(RVA = "0x2940CD0", Offset = "0x2940CD0", VA = "0x2940CD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60188C6")]
    [Address(RVA = "0x2940D20", Offset = "0x2940D20", VA = "0x2940D20")]
    public string getPath() => (string) null;

    [Token(Token = "0x60188C7")]
    [Address(RVA = "0x2940D68", Offset = "0x2940D68", VA = "0x2940D68")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x60188C8")]
    [Address(RVA = "0x2940DD8", Offset = "0x2940DD8", VA = "0x2940DD8")]
    public void delete()
    {
    }

    [Token(Token = "0x60188C9")]
    [Address(RVA = "0x2940DF4", Offset = "0x2940DF4", VA = "0x2940DF4")]
    public void load()
    {
    }

    [Token(Token = "0x60188CA")]
    [Address(RVA = "0x2941738", Offset = "0x2941738", VA = "0x2941738")]
    public void save(bool isForce = false)
    {
    }

    [Token(Token = "0x60188CB")]
    [Address(RVA = "0x2942014", Offset = "0x2942014", VA = "0x2942014")]
    public void UpdatePosition(FreeMapSaveData.StartPosition position)
    {
    }

    [Token(Token = "0x60188CC")]
    [Address(RVA = "0x29420A8", Offset = "0x29420A8", VA = "0x29420A8")]
    public void UpdatePosition(int areaId, string anchorName = "DefaultStartPoint", Vector3 offset = default (Vector3), float rotationY = 0.0f)
    {
    }

    [Token(Token = "0x60188CD")]
    [Address(RVA = "0x294218C", Offset = "0x294218C", VA = "0x294218C")]
    public void ResetPosition()
    {
    }

    [Token(Token = "0x60188CE")]
    [Address(RVA = "0x2942208", Offset = "0x2942208", VA = "0x2942208")]
    public void ResetPosition(int chapterId)
    {
    }

    [Token(Token = "0x60188CF")]
    [Address(RVA = "0x294227C", Offset = "0x294227C", VA = "0x294227C")]
    public bool TryGetStartPosition(
      int chapterId,
      int sequenceId,
      out FreeMapSaveData.StartPosition value)
    {
      return new bool();
    }

    [Token(Token = "0x60188D0")]
    [Address(RVA = "0x2942304", Offset = "0x2942304", VA = "0x2942304")]
    public bool IsWatchedAreaIntroduction(int tableId) => new bool();

    [Token(Token = "0x60188D1")]
    [Address(RVA = "0x294235C", Offset = "0x294235C", VA = "0x294235C")]
    public void AddWatchedAreaIntroduction(int tableId)
    {
    }

    [Token(Token = "0x60188D2")]
    [Address(RVA = "0x29423D0", Offset = "0x29423D0", VA = "0x29423D0")]
    public void ResetAreaIntroduction(int chapterId)
    {
    }

    [Token(Token = "0x60188D3")]
    [Address(RVA = "0x29424C0", Offset = "0x29424C0", VA = "0x29424C0")]
    public bool IsReadTalkAdvEvent(int tableId) => new bool();

    [Token(Token = "0x60188D4")]
    [Address(RVA = "0x2942518", Offset = "0x2942518", VA = "0x2942518")]
    public void AddReadTalkAdvEvent(int tableId)
    {
    }

    [Token(Token = "0x60188D5")]
    [Address(RVA = "0x294258C", Offset = "0x294258C", VA = "0x294258C")]
    public bool IsReadFlavorEvent(int tableId) => new bool();

    [Token(Token = "0x60188D6")]
    [Address(RVA = "0x29425E4", Offset = "0x29425E4", VA = "0x29425E4")]
    public void AddReadFlavorEvent(int tableId)
    {
    }

    [Token(Token = "0x60188D7")]
    [Address(RVA = "0x2942658", Offset = "0x2942658", VA = "0x2942658")]
    public bool Validate() => new bool();

    [Token(Token = "0x60188D8")]
    [Address(RVA = "0x29414D8", Offset = "0x29414D8", VA = "0x29414D8")]
    private static FreeMapSaveData.StartPosition ConvStartPosition(staq.SaveSchema.StartPosition? pos)
    {
      return new FreeMapSaveData.StartPosition();
    }

    [Token(Token = "0x60188D9")]
    [Address(RVA = "0x2941668", Offset = "0x2941668", VA = "0x2941668")]
    private static FreeMapSaveData.AreaIntroduction ConvAreaIntroduction(staq.SaveSchema.AreaIntroduction? intro)
    {
      return new FreeMapSaveData.AreaIntroduction();
    }

    [Token(Token = "0x60188DA")]
    [Address(RVA = "0x29416D0", Offset = "0x29416D0", VA = "0x29416D0")]
    private static FreeMapSaveData.AlreadyRead ConvAlreadyRead(staq.SaveSchema.AlreadyRead? read)
    {
      return new FreeMapSaveData.AlreadyRead();
    }

    [Token(Token = "0x60188DB")]
    [Address(RVA = "0x29426D8", Offset = "0x29426D8", VA = "0x29426D8")]
    private static FreeMapSaveData.TemporaryEnteredArea ConvTemporaryEnteredArea(
      staq.SaveSchema.TemporaryEnteredArea? data)
    {
      return new FreeMapSaveData.TemporaryEnteredArea();
    }

    [Token(Token = "0x60188DC")]
    [Address(RVA = "0x2942768", Offset = "0x2942768", VA = "0x2942768")]
    public FreeMapSaveData()
    {
    }

    [Token(Token = "0x2003D16")]
    public struct StartPosition
    {
      [Token(Token = "0x4010CE3")]
      [FieldOffset(Offset = "0x0")]
      public int ChapterId;
      [Token(Token = "0x4010CE4")]
      [FieldOffset(Offset = "0x4")]
      public int SequenceId;
      [Token(Token = "0x4010CE5")]
      [FieldOffset(Offset = "0x8")]
      public int AreaId;
      [Token(Token = "0x4010CE6")]
      [FieldOffset(Offset = "0x10")]
      public string AnchorName;
      [Token(Token = "0x4010CE7")]
      [FieldOffset(Offset = "0x18")]
      public Vector3 Offset;
      [Token(Token = "0x4010CE8")]
      [FieldOffset(Offset = "0x24")]
      public float RotationY;

      [Token(Token = "0x60188DD")]
      [Address(RVA = "0x2942770", Offset = "0x2942770", VA = "0x2942770", Slot = "3")]
      public override string ToString() => (string) null;
    }

    [Token(Token = "0x2003D17")]
    public struct AreaIntroduction
    {
      [Token(Token = "0x4010CE9")]
      [FieldOffset(Offset = "0x0")]
      public int TableId;

      [Token(Token = "0x60188DE")]
      [Address(RVA = "0x2942B18", Offset = "0x2942B18", VA = "0x2942B18", Slot = "3")]
      public override string ToString() => (string) null;

      [Token(Token = "0x60188DF")]
      [Address(RVA = "0x2942BBC", Offset = "0x2942BBC", VA = "0x2942BBC", Slot = "2")]
      public override int GetHashCode() => new int();
    }

    [Token(Token = "0x2003D18")]
    public struct AlreadyRead
    {
      [Token(Token = "0x4010CEA")]
      [FieldOffset(Offset = "0x0")]
      public int TableId;

      [Token(Token = "0x60188E0")]
      [Address(RVA = "0x2942BC4", Offset = "0x2942BC4", VA = "0x2942BC4", Slot = "3")]
      public override string ToString() => (string) null;

      [Token(Token = "0x60188E1")]
      [Address(RVA = "0x2942C68", Offset = "0x2942C68", VA = "0x2942C68", Slot = "2")]
      public override int GetHashCode() => new int();
    }

    [Token(Token = "0x2003D19")]
    public struct TemporaryEnteredArea
    {
      [Token(Token = "0x4010CEB")]
      [FieldOffset(Offset = "0x0")]
      public int ChapterId;
      [Token(Token = "0x4010CEC")]
      [FieldOffset(Offset = "0x4")]
      public int AreaId;

      [Token(Token = "0x60188E2")]
      [Address(RVA = "0x2942C70", Offset = "0x2942C70", VA = "0x2942C70", Slot = "3")]
      public override string ToString() => (string) null;
    }

    [Token(Token = "0x2003D1A")]
    public struct TemporaryContactedObject
    {
      [Token(Token = "0x4010CED")]
      [FieldOffset(Offset = "0x0")]
      public int ObjectId;

      [Token(Token = "0x60188E3")]
      [Address(RVA = "0x2942D68", Offset = "0x2942D68", VA = "0x2942D68", Slot = "3")]
      public override string ToString() => (string) null;
    }
  }
}
