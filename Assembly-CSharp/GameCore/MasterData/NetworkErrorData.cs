// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.NetworkErrorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E98")]
  [Serializable]
  public sealed class NetworkErrorData : IMasterDataEntity, INetworkErrorData
  {
    [Token(Token = "0x4004694")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004695")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string errorCode;
    [Token(Token = "0x4004696")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string extra;
    [Token(Token = "0x4004697")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string apiPath;
    [Token(Token = "0x4004698")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string httpStatusCode;
    [Token(Token = "0x4004699")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string dialogStringId;
    [Token(Token = "0x400469A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public ErrorViewTypeEnum viewType;
    [Token(Token = "0x400469B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string button1StringId;
    [Token(Token = "0x400469C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public ErrorTransitionTypeEnum button1TransitionType;
    [Token(Token = "0x400469D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string button2StringId;
    [Token(Token = "0x400469E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public ErrorTransitionTypeEnum button2TransitionType;

    [Token(Token = "0x17000D2E")]
    public int Key
    {
      [Token(Token = "0x60058C2"), Address(RVA = "0x3C2D7B0", Offset = "0x3C2D7B0", VA = "0x3C2D7B0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058C3")]
    [Address(RVA = "0x3C2D7B8", Offset = "0x3C2D7B8", VA = "0x3C2D7B8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058C4")]
    [Address(RVA = "0x3C2DC24", Offset = "0x3C2DC24", VA = "0x3C2DC24", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D2F")]
    public string DialogString
    {
      [Token(Token = "0x60058C5"), Address(RVA = "0x3C2DD54", Offset = "0x3C2DD54", VA = "0x3C2DD54", Slot = "11")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D30")]
    public string Button1String
    {
      [Token(Token = "0x60058C6"), Address(RVA = "0x3C2DE14", Offset = "0x3C2DE14", VA = "0x3C2DE14", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D31")]
    public string Button2String
    {
      [Token(Token = "0x60058C7"), Address(RVA = "0x3C2DEC0", Offset = "0x3C2DEC0", VA = "0x3C2DEC0", Slot = "10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D32")]
    public long HttpStatusCode
    {
      [Token(Token = "0x60058C8"), Address(RVA = "0x3C2DF6C", Offset = "0x3C2DF6C", VA = "0x3C2DF6C", Slot = "8")] get
      {
        return new long();
      }
      [Token(Token = "0x60058C9"), Address(RVA = "0x3C2DF74", Offset = "0x3C2DF74", VA = "0x3C2DF74")] private set
      {
      }
    }

    [Token(Token = "0x17000D33")]
    public int ExtraStatusCode
    {
      [Token(Token = "0x60058CA"), Address(RVA = "0x3C2DF7C", Offset = "0x3C2DF7C", VA = "0x3C2DF7C")] get
      {
        return new int();
      }
      [Token(Token = "0x60058CB"), Address(RVA = "0x3C2DF84", Offset = "0x3C2DF84", VA = "0x3C2DF84")] private set
      {
      }
    }

    [Token(Token = "0x17000D34")]
    public ErrorViewTypeEnum ViewType
    {
      [Token(Token = "0x60058CC"), Address(RVA = "0x3C2DF8C", Offset = "0x3C2DF8C", VA = "0x3C2DF8C", Slot = "12")] get
      {
        return new ErrorViewTypeEnum();
      }
    }

    [Token(Token = "0x17000D35")]
    public ErrorTransitionTypeEnum Button1TransitionType
    {
      [Token(Token = "0x60058CD"), Address(RVA = "0x3C2DF94", Offset = "0x3C2DF94", VA = "0x3C2DF94", Slot = "13")] get
      {
        return new ErrorTransitionTypeEnum();
      }
    }

    [Token(Token = "0x17000D36")]
    public ErrorTransitionTypeEnum Button2TransitionType
    {
      [Token(Token = "0x60058CE"), Address(RVA = "0x3C2DF9C", Offset = "0x3C2DF9C", VA = "0x3C2DF9C", Slot = "14")] get
      {
        return new ErrorTransitionTypeEnum();
      }
    }

    [Token(Token = "0x17000D37")]
    public string ErrorCode
    {
      [Token(Token = "0x60058CF"), Address(RVA = "0x3C2DFA4", Offset = "0x3C2DFA4", VA = "0x3C2DFA4", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60058D0")]
    [Address(RVA = "0x3C2DFAC", Offset = "0x3C2DFAC", VA = "0x3C2DFAC", Slot = "15")]
    public string GetDialogString(long httpStatusCode) => (string) null;

    [Token(Token = "0x60058D1")]
    [Address(RVA = "0x3C2D320", Offset = "0x3C2D320", VA = "0x3C2D320")]
    public void OnPostLoadEntity()
    {
    }

    [Token(Token = "0x60058D2")]
    [Address(RVA = "0x3C2E024", Offset = "0x3C2E024", VA = "0x3C2E024")]
    public NetworkErrorData()
    {
    }
  }
}
