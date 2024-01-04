.method public hidebysig 
    instance class [System.Collections]System.Collections.Generic.List`1<class BenchmarkClass/Class128> GetClass128 () cil managed 
{
    // Method begins at RVA 0x20a4
    // Code size 43 (0x2b)
    .maxstack 2
    .locals init (
        [0] class [System.Collections]System.Collections.Generic.List`1<class BenchmarkClass/Class128> list,
        [1] int32 i
    )

    IL_0000: ldarg.0
    IL_0001: call instance int32 BenchmarkClass::get_Iterations()
    IL_0006: newobj instance void class [System.Collections]System.Collections.Generic.List`1<class BenchmarkClass/Class128>::.ctor(int32)
    IL_000b: stloc.0
    IL_000c: ldc.i4.0
    IL_000d: stloc.1
    // sequence point: hidden
    IL_000e: br.s IL_0020
    // loop start (head: IL_0020)
        IL_0010: ldloc.0
        IL_0011: ldloc.1
        IL_0012: call class BenchmarkClass/Class128 BenchmarkClass::GetClass128(int32)
        IL_0017: call void BenchmarkClass::Add<class BenchmarkClass/Class128>(class [System.Collections]System.Collections.Generic.List`1<!!0>, !!0)
        IL_001c: ldloc.1
        IL_001d: ldc.i4.1
        IL_001e: add
        IL_001f: stloc.1

        IL_0020: ldloc.1
        IL_0021: ldarg.0
        IL_0022: call instance int32 BenchmarkClass::get_Iterations()
        IL_0027: blt.s IL_0010
    // end loop

    IL_0029: ldloc.0
    IL_002a: ret
} // end of method BenchmarkClass::GetClass128