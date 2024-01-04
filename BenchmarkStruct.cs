using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[MemoryDiagnoser]
[DisassemblyDiagnoser(syntax: DisassemblySyntax.Intel)]
public class BenchmarkStruct : BenchmarkBase
{
    private static void Add<T>(List<T> list, T value) => list.Add(value);

    [Benchmark(Baseline = true)]
    public List<Struct04> GetStruct4()
    {
        var list = new List<Struct04>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct04(i));
        return list;
    }

    [Benchmark]
    public List<Struct08> GetStruct8()
    {
        var list = new List<Struct08>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct08(i));
        return list;
    }

    [Benchmark]
    public List<Struct12> GetStruct12()
    {
        var list = new List<Struct12>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct12(i));
        return list;
    }

    [Benchmark]
    public List<Struct16> GetStruct16()
    {
        var list = new List<Struct16>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct16(i));
        return list;
    }

    [Benchmark]
    public List<Struct20> GetStruct20()
    {
        var list = new List<Struct20>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct20(i));
        return list;
    }

    [Benchmark]
    public List<Struct24> GetStruct24()
    {
        var list = new List<Struct24>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct24(i));
        return list;
    }

    [Benchmark]
    public List<Struct28> GetStruct28()
    {
        var list = new List<Struct28>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct28(i));
        return list;
    }

    [Benchmark]
    public List<Struct32> GetStruct32()
    {
        var list = new List<Struct32>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct32(i));
        return list;
    }

    [Benchmark]
    public List<Struct36> GetStruct36()
    {
        var list = new List<Struct36>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct36(i));
        return list;
    }

    [Benchmark]
    public List<Struct40> GetStruct40()
    {
        var list = new List<Struct40>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct40(i));
        return list;
    }

    [Benchmark]
    public List<Struct44> GetStruct44()
    {
        var list = new List<Struct44>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct44(i));
        return list;
    }

    [Benchmark]
    public List<Struct48> GetStruct48()
    {
        var list = new List<Struct48>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct48(i));
        return list;
    }

    [Benchmark]
    public List<Struct52> GetStruct52()
    {
        var list = new List<Struct52>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct52(i));
        return list;
    }

    [Benchmark]
    public List<Struct56> GetStruct56()
    {
        var list = new List<Struct56>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct56(i));
        return list;
    }

    [Benchmark]
    public List<Struct60> GetStruct60()
    {
        var list = new List<Struct60>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct60(i));
        return list;
    }

    [Benchmark]
    public List<Struct64> GetStruct64()
    {
        var list = new List<Struct64>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct64(i));
        return list;
    }

    [Benchmark]
    public List<Struct68> GetStruct68()
    {
        var list = new List<Struct68>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct68(i));
        return list;
    }

    [Benchmark]
    public List<Struct72> GetStruct72()
    {
        var list = new List<Struct72>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct72(i));
        return list;
    }

    [Benchmark]
    public List<Struct76> GetStruct76()
    {
        var list = new List<Struct76>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct76(i));
        return list;
    }

    [Benchmark]
    public List<Struct80> GetStruct80()
    {
        var list = new List<Struct80>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct80(i));
        return list;
    }

    [Benchmark]
    public List<Struct84> GetStruct84()
    {
        var list = new List<Struct84>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct84(i));
        return list;
    }

    [Benchmark]
    public List<Struct88> GetStruct88()
    {
        var list = new List<Struct88>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct88(i));
        return list;
    }

    [Benchmark]
    public List<Struct92> GetStruct92()
    {
        var list = new List<Struct92>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct92(i));
        return list;
    }

    [Benchmark]
    public List<Struct96> GetStruct96()
    {
        var list = new List<Struct96>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct96(i));
        return list;
    }

    [Benchmark]
    public List<Struct100> GetStruct100()
    {
        var list = new List<Struct100>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct100(i));
        return list;
    }

    [Benchmark]
    public List<Struct104> GetStruct104()
    {
        var list = new List<Struct104>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct104(i));
        return list;
    }

    [Benchmark]
    public List<Struct108> GetStruct108()
    {
        var list = new List<Struct108>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct108(i));
        return list;
    }

    [Benchmark]
    public List<Struct112> GetStruct112()
    {
        var list = new List<Struct112>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct112(i));
        return list;
    }

    [Benchmark]
    public List<Struct116> GetStruct116()
    {
        var list = new List<Struct116>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct116(i));
        return list;
    }

    [Benchmark]
    public List<Struct120> GetStruct120()
    {
        var list = new List<Struct120>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct120(i));
        return list;
    }
    [Benchmark]
    public List<Struct124> GetStruct124()
    {
        var list = new List<Struct124>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct124(i));
        return list;
    }

    [Benchmark]
    public List<Struct128> GetStruct128()
    {
        var list = new List<Struct128>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct128(i));
        return list;
    }

    [Benchmark]
    public List<Struct132> GetStruct132()
    {
        var list = new List<Struct132>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct132(i));
        return list;
    }

    [Benchmark]
    public List<Struct136> GetStruct136()
    {
        var list = new List<Struct136>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct136(i));
        return list;
    }

    [Benchmark]
    public List<Struct140> GetStruct140()
    {
        var list = new List<Struct140>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct140(i));
        return list;
    }

    [Benchmark]
    public List<Struct144> GetStruct144()
    {
        var list = new List<Struct144>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct144(i));
        return list;
    }

    [Benchmark]
    public List<Struct148> GetStruct148()
    {
        var list = new List<Struct148>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct148(i));
        return list;
    }

    [Benchmark]
    public List<Struct152> GetStruct152()
    {
        var list = new List<Struct152>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct152(i));
        return list;
    }

    [Benchmark]
    public List<Struct156> GetStruct156()
    {
        var list = new List<Struct156>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct156(i));
        return list;
    }

    [Benchmark]
    public List<Struct160> GetStruct160()
    {
        var list = new List<Struct160>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetStruct160(i));
        return list;
    }

    public static Struct04 GetStruct04(int value) => new(value);
    public static Struct08 GetStruct08(int value) => new(value, value);
    public static Struct12 GetStruct12(int value) => new(value, value, value);
    public static Struct16 GetStruct16(int value) => new(value, value, value, value);
    public static Struct20 GetStruct20(int value) => new(value, value, value, value, value);
    public static Struct24 GetStruct24(int value) => new(value, value, value, value, value, value);
    public static Struct28 GetStruct28(int value) => new(value, value, value, value, value, value, value);
    public static Struct32 GetStruct32(int value) => new(value, value, value, value, value, value, value, value);
    public static Struct36 GetStruct36(int value) => new(value, value, value, value, value, value, value, value, value);
    public static Struct40 GetStruct40(int value) => new(value, value, value, value, value, value, value, value, value, value);
    public static Struct44 GetStruct44(int value) => new(value, value, value, value, value, value, value, value, value, value, value);
    public static Struct48 GetStruct48(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct52 GetStruct52(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct56 GetStruct56(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct60 GetStruct60(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct64 GetStruct64(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct68 GetStruct68(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct72 GetStruct72(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct76 GetStruct76(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct80 GetStruct80(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct84 GetStruct84(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct88 GetStruct88(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct92 GetStruct92(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct96 GetStruct96(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct100 GetStruct100(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct104 GetStruct104(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct108 GetStruct108(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct112 GetStruct112(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct116 GetStruct116(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct120 GetStruct120(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct124 GetStruct124(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct128 GetStruct128(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct132 GetStruct132(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct136 GetStruct136(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct140 GetStruct140(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct144 GetStruct144(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct148 GetStruct148(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct152 GetStruct152(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct156 GetStruct156(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Struct160 GetStruct160(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);

    public record struct Struct04(int Param);
    public record struct Struct08(int Param1, int Param2);
    public record struct Struct12(int Param1, int Param2, int Param3);
    public record struct Struct16(int Param1, int Param2, int Param3, int Param4);
    public record struct Struct20(int Param1, int Param2, int Param3, int Param4, int Param5);
    public record struct Struct24(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6);
    public record struct Struct28(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7);
    public record struct Struct32(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8);
    public record struct Struct36(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9);
    public record struct Struct40(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10);
    public record struct Struct44(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11);
    public record struct Struct48(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12);
    public record struct Struct52(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13);
    public record struct Struct56(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14);
    public record struct Struct60(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15);
    public record struct Struct64(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16);
    public record struct Struct68(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17);
    public record struct Struct72(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18);
    public record struct Struct76(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19);
    public record struct Struct80(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20);
    public record struct Struct84(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21);
    public record struct Struct88(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22);
    public record struct Struct92(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23);
    public record struct Struct96(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24);
    public record struct Struct100(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25);
    public record struct Struct104(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26);
    public record struct Struct108(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27);
    public record struct Struct112(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28);
    public record struct Struct116(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29);
    public record struct Struct120(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30);
    public record struct Struct124(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31);
    public record struct Struct128(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32);
    public record struct Struct132(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33);
    public record struct Struct136(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34);
    public record struct Struct140(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35);
    public record struct Struct144(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36);
    public record struct Struct148(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37);
    public record struct Struct152(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37, int Param38);
    public record struct Struct156(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37, int Param38, int Param39);
    public record struct Struct160(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37, int Param38, int Param39, int Param40);
}