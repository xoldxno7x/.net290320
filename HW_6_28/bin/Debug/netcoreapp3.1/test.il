
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:2:2:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:1:2:0
}
.assembly HW_6_28
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 33 2E 31 01 00 54 0E 14   // ersion=v3.1..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 48 57 5F 36 5F 32 38 00 00 )             // ...HW_6_28..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 48 57 5F 36 5F 32 38 00 00 )             // ...HW_6_28..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 48 57 5F 36 5F 32 38 00 00 )             // ...HW_6_28..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module HW_6_28.dll
// MVID: {B3E15B78-F112-4162-A945-366B260245E2}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0B680000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit HW_6_28.Game
       extends [System.Runtime]System.Object
{
  .field public string _name
  .field public int32 _numberOfPlayers
  .field public float32 _rating
  .field public string _originCountry
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ret
  } // end of method Game::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string name,
                               [opt] float32 rating) cil managed
  {
    .param [2] = float32(5.5)
    // Code size       23 (0x17)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  stfld      string HW_6_28.Game::_name
    IL_000f:  ldarg.0
    IL_0010:  ldarg.2
    IL_0011:  stfld      float32 HW_6_28.Game::_rating
    IL_0016:  ret
  } // end of method Game::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string name,
                               int32 numberOfPlayers,
                               float32 rating,
                               string originCountry) cil managed
  {
    // Code size       38 (0x26)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  stfld      string HW_6_28.Game::_name
    IL_000f:  ldarg.0
    IL_0010:  ldarg.2
    IL_0011:  stfld      int32 HW_6_28.Game::_numberOfPlayers
    IL_0016:  ldarg.0
    IL_0017:  ldarg.3
    IL_0018:  stfld      float32 HW_6_28.Game::_rating
    IL_001d:  ldarg.0
    IL_001e:  ldarg.s    originCountry
    IL_0020:  stfld      string HW_6_28.Game::_originCountry
    IL_0025:  ret
  } // end of method Game::.ctor

  .method public hidebysig instance int32 
          TellMeHowManyPlayers() cil managed
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 HW_6_28.Game::_numberOfPlayers
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method Game::TellMeHowManyPlayers

  .method public hidebysig virtual instance string 
          ToString() cil managed
  {
    // Code size       68 (0x44)
    .maxstack  5
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "Game: name is {0}, number of players is {1}, ratin"
    + "g is {2}, origin country is {3}"
    IL_0006:  ldc.i4.4
    IL_0007:  newarr     [System.Runtime]System.Object
    IL_000c:  dup
    IL_000d:  ldc.i4.0
    IL_000e:  ldarg.0
    IL_000f:  ldfld      string HW_6_28.Game::_name
    IL_0014:  stelem.ref
    IL_0015:  dup
    IL_0016:  ldc.i4.1
    IL_0017:  ldarg.0
    IL_0018:  ldfld      int32 HW_6_28.Game::_numberOfPlayers
    IL_001d:  box        [System.Runtime]System.Int32
    IL_0022:  stelem.ref
    IL_0023:  dup
    IL_0024:  ldc.i4.2
    IL_0025:  ldarg.0
    IL_0026:  ldfld      float32 HW_6_28.Game::_rating
    IL_002b:  box        [System.Runtime]System.Single
    IL_0030:  stelem.ref
    IL_0031:  dup
    IL_0032:  ldc.i4.3
    IL_0033:  ldarg.0
    IL_0034:  ldfld      string HW_6_28.Game::_originCountry
    IL_0039:  stelem.ref
    IL_003a:  call       string [System.Runtime]System.String::Format(string,
                                                                      object[])
    IL_003f:  stloc.0
    IL_0040:  br.s       IL_0042

    IL_0042:  ldloc.0
    IL_0043:  ret
  } // end of method Game::ToString

} // end of class HW_6_28.Game

.class private auto ansi beforefieldinit HW_6_28.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       177 (0xb1)
    .maxstack  4
    .locals init (class HW_6_28.Game V_0,
             class HW_6_28.Game V_1,
             class HW_6_28.Game V_2,
             class HW_6_28.Game V_3)
    IL_0000:  nop
    IL_0001:  ldstr      "WITCHER 3"
    IL_0006:  ldc.i4.1
    IL_0007:  ldc.r4     5.5
    IL_000c:  ldstr      "Poland"
    IL_0011:  newobj     instance void HW_6_28.Game::.ctor(string,
                                                           int32,
                                                           float32,
                                                           string)
    IL_0016:  stloc.0
    IL_0017:  newobj     instance void HW_6_28.Game::.ctor()
    IL_001c:  dup
    IL_001d:  ldstr      "FALL OUT 3"
    IL_0022:  stfld      string HW_6_28.Game::_name
    IL_0027:  dup
    IL_0028:  ldstr      "USA"
    IL_002d:  stfld      string HW_6_28.Game::_originCountry
    IL_0032:  dup
    IL_0033:  ldc.i4.1
    IL_0034:  stfld      int32 HW_6_28.Game::_numberOfPlayers
    IL_0039:  dup
    IL_003a:  ldc.r4     5.
    IL_003f:  stfld      float32 HW_6_28.Game::_rating
    IL_0044:  stloc.1
    IL_0045:  ldstr      "DOOM INTERNAL"
    IL_004a:  ldc.r4     5.5
    IL_004f:  newobj     instance void HW_6_28.Game::.ctor(string,
                                                           float32)
    IL_0054:  dup
    IL_0055:  ldc.i4.1
    IL_0056:  stfld      int32 HW_6_28.Game::_numberOfPlayers
    IL_005b:  dup
    IL_005c:  ldstr      "USA"
    IL_0061:  stfld      string HW_6_28.Game::_originCountry
    IL_0066:  dup
    IL_0067:  ldc.r4     6.
    IL_006c:  stfld      float32 HW_6_28.Game::_rating
    IL_0071:  stloc.2
    IL_0072:  ldstr      "DARK SOULS 3"
    IL_0077:  ldc.r4     4.5
    IL_007c:  newobj     instance void HW_6_28.Game::.ctor(string,
                                                           float32)
    IL_0081:  dup
    IL_0082:  ldc.i4.1
    IL_0083:  stfld      int32 HW_6_28.Game::_numberOfPlayers
    IL_0088:  dup
    IL_0089:  ldstr      "Japan"
    IL_008e:  stfld      string HW_6_28.Game::_originCountry
    IL_0093:  stloc.3
    IL_0094:  ldloc.0
    IL_0095:  call       void HW_6_28.Program::PrintGame(class HW_6_28.Game)
    IL_009a:  nop
    IL_009b:  ldloc.1
    IL_009c:  call       void HW_6_28.Program::PrintGame(class HW_6_28.Game)
    IL_00a1:  nop
    IL_00a2:  ldloc.2
    IL_00a3:  call       void HW_6_28.Program::PrintGame(class HW_6_28.Game)
    IL_00a8:  nop
    IL_00a9:  ldloc.3
    IL_00aa:  call       void HW_6_28.Program::PrintGame(class HW_6_28.Game)
    IL_00af:  nop
    IL_00b0:  ret
  } // end of method Program::Main

  .method public hidebysig static void  PrintGame(class HW_6_28.Game g) cil managed
  {
    // Code size       16 (0x10)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  callvirt   instance int32 HW_6_28.Game::TellMeHowManyPlayers()
    IL_0007:  stloc.0
    IL_0008:  ldarg.0
    IL_0009:  call       void [System.Console]System.Console::WriteLine(object)
    IL_000e:  nop
    IL_000f:  ret
  } // end of method Program::PrintGame

  .method public hidebysig instance void 
          notStatic() cil managed
  {
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method Program::notStatic

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class HW_6_28.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\xoldx\source\repos\HW_6_28\HW_6_28\bin\Debug\netcoreapp3.1\test.res
