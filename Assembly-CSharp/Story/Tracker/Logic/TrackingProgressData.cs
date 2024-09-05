// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.TrackingProgressData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005E6")]
  public class TrackingProgressData
  {
    [Token(Token = "0x170004CF")]
    public Handle Handle
    {
      [Token(Token = "0x600222E"), Address(RVA = "0x2D9E2FC", Offset = "0x2D9E2FC", VA = "0x2D9E2FC")] get
      {
        return new Handle();
      }
      [Token(Token = "0x600222F"), Address(RVA = "0x2D9E304", Offset = "0x2D9E304", VA = "0x2D9E304")] set
      {
      }
    }

    [Token(Token = "0x170004D0")]
    public string Title
    {
      [Token(Token = "0x6002230"), Address(RVA = "0x2D9E30C", Offset = "0x2D9E30C", VA = "0x2D9E30C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6002231"), Address(RVA = "0x2D9E314", Offset = "0x2D9E314", VA = "0x2D9E314")] set
      {
      }
    }

    [Token(Token = "0x170004D1")]
    public int Current
    {
      [Token(Token = "0x6002232"), Address(RVA = "0x2D9E31C", Offset = "0x2D9E31C", VA = "0x2D9E31C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002233"), Address(RVA = "0x2D9E324", Offset = "0x2D9E324", VA = "0x2D9E324")] set
      {
      }
    }

    [Token(Token = "0x170004D2")]
    public int Max
    {
      [Token(Token = "0x6002234"), Address(RVA = "0x2D9E32C", Offset = "0x2D9E32C", VA = "0x2D9E32C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002235"), Address(RVA = "0x2D9E334", Offset = "0x2D9E334", VA = "0x2D9E334")] set
      {
      }
    }

    [Token(Token = "0x170004D3")]
    public bool IsPurpose
    {
      [Token(Token = "0x6002236"), Address(RVA = "0x2D9E33C", Offset = "0x2D9E33C", VA = "0x2D9E33C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004D4")]
    public bool Show
    {
      [Token(Token = "0x6002237"), Address(RVA = "0x2D9E34C", Offset = "0x2D9E34C", VA = "0x2D9E34C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002238"), Address(RVA = "0x2D9E354", Offset = "0x2D9E354", VA = "0x2D9E354")] set
      {
      }
    }

    [Token(Token = "0x170004D5")]
    public bool Complete
    {
      [Token(Token = "0x6002239"), Address(RVA = "0x2D9D988", Offset = "0x2D9D988", VA = "0x2D9D988")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600223A")]
    [Address(RVA = "0x2D9E360", Offset = "0x2D9E360", VA = "0x2D9E360")]
    public void Update(int current, int max)
    {
    }

    [Token(Token = "0x170004D6")]
    public bool IsDirty
    {
      [Token(Token = "0x600223B"), Address(RVA = "0x2D9E370", Offset = "0x2D9E370", VA = "0x2D9E370")] get
      {
        return new bool();
      }
      [Token(Token = "0x600223C"), Address(RVA = "0x2D9E378", Offset = "0x2D9E378", VA = "0x2D9E378")] private set
      {
      }
    }

    [Token(Token = "0x600223D")]
    [Address(RVA = "0x2D9E384", Offset = "0x2D9E384", VA = "0x2D9E384")]
    public void Clean()
    {
    }

    [Token(Token = "0x600223E")]
    [Address(RVA = "0x2D9E38C", Offset = "0x2D9E38C", VA = "0x2D9E38C")]
    public TrackingProgressData()
    {
    }
  }
}
