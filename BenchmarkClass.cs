using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace Benchmark;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[MemoryDiagnoser]
public class BenchmarkClass : BenchmarkBase
{
    private static void Add<T>(List<T> list, T value) => list.Add(value);

    [Benchmark(Baseline = true)]
    public List<Class04> GetClass4()
    {
        var list = new List<Class04>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass04(i));
        return list;
    }

    [Benchmark]
    public List<Class08> GetClass8()
    {
        var list = new List<Class08>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass08(i));
        return list;
    }

    [Benchmark]
    public List<Class12> GetClass12()
    {
        var list = new List<Class12>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass12(i));
        return list;
    }

    [Benchmark]
    public List<Class16> GetClass16()
    {
        var list = new List<Class16>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass16(i));
        return list;
    }

    [Benchmark]
    public List<Class20> GetClass20()
    {
        var list = new List<Class20>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass20(i));
        return list;
    }

    [Benchmark]
    public List<Class24> GetClass24()
    {
        var list = new List<Class24>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass24(i));
        return list;
    }

    [Benchmark]
    public List<Class28> GetClass28()
    {
        var list = new List<Class28>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass28(i));
        return list;
    }

    [Benchmark]
    public List<Class32> GetClass32()
    {
        var list = new List<Class32>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass32(i));
        return list;
    }

    [Benchmark]
    public List<Class36> GetClass36()
    {
        var list = new List<Class36>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass36(i));
        return list;
    }

    [Benchmark]
    public List<Class40> GetClass40()
    {
        var list = new List<Class40>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass40(i));
        return list;
    }

    [Benchmark]
    public List<Class44> GetClass44()
    {
        var list = new List<Class44>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass44(i));
        return list;
    }

    [Benchmark]
    public List<Class48> GetClass48()
    {
        var list = new List<Class48>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass48(i));
        return list;
    }

    [Benchmark]
    public List<Class52> GetClass52()
    {
        var list = new List<Class52>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass52(i));
        return list;
    }

    [Benchmark]
    public List<Class56> GetClass56()
    {
        var list = new List<Class56>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass56(i));
        return list;
    }

    [Benchmark]
    public List<Class60> GetClass60()
    {
        var list = new List<Class60>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass60(i));
        return list;
    }

    [Benchmark]
    public List<Class64> GetClass64()
    {
        var list = new List<Class64>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass64(i));
        return list;
    }

    [Benchmark]
    public List<Class68> GetClass68()
    {
        var list = new List<Class68>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass68(i));
        return list;
    }

    [Benchmark]
    public List<Class72> GetClass72()
    {
        var list = new List<Class72>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass72(i));
        return list;
    }

    [Benchmark]
    public List<Class76> GetClass76()
    {
        var list = new List<Class76>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass76(i));
        return list;
    }

    [Benchmark]
    public List<Class80> GetClass80()
    {
        var list = new List<Class80>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass80(i));
        return list;
    }

    [Benchmark]
    public List<Class84> GetClass84()
    {
        var list = new List<Class84>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass84(i));
        return list;
    }

    [Benchmark]
    public List<Class88> GetClass88()
    {
        var list = new List<Class88>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass88(i));
        return list;
    }

    [Benchmark]
    public List<Class92> GetClass92()
    {
        var list = new List<Class92>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass92(i));
        return list;
    }

    [Benchmark]
    public List<Class96> GetClass96()
    {
        var list = new List<Class96>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass96(i));
        return list;
    }

    [Benchmark]
    public List<Class100> GetClass100()
    {
        var list = new List<Class100>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass100(i));
        return list;
    }

    [Benchmark]
    public List<Class104> GetClass104()
    {
        var list = new List<Class104>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass104(i));
        return list;
    }

    [Benchmark]
    public List<Class108> GetClass108()
    {
        var list = new List<Class108>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass108(i));
        return list;
    }

    [Benchmark]
    public List<Class112> GetClass112()
    {
        var list = new List<Class112>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass112(i));
        return list;
    }

    [Benchmark]
    public List<Class116> GetClass116()
    {
        var list = new List<Class116>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass116(i));
        return list;
    }

    [Benchmark]
    public List<Class120> GetClass120()
    {
        var list = new List<Class120>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass120(i));
        return list;
    }
    [Benchmark]
    public List<Class124> GetClass124()
    {
        var list = new List<Class124>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass124(i));
        return list;
    }

    [Benchmark]
    public List<Class128> GetClass128()
    {
        var list = new List<Class128>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass128(i));
        return list;
    }

    [Benchmark]
    public List<Class132> GetClass132()
    {
        var list = new List<Class132>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass132(i));
        return list;
    }

    [Benchmark]
    public List<Class136> GetClass136()
    {
        var list = new List<Class136>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass136(i));
        return list;
    }

    [Benchmark]
    public List<Class140> GetClass140()
    {
        var list = new List<Class140>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass140(i));
        return list;
    }

    [Benchmark]
    public List<Class144> GetClass144()
    {
        var list = new List<Class144>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass144(i));
        return list;
    }

    [Benchmark]
    public List<Class148> GetClass148()
    {
        var list = new List<Class148>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass148(i));
        return list;
    }

    [Benchmark]
    public List<Class152> GetClass152()
    {
        var list = new List<Class152>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass152(i));
        return list;
    }

    [Benchmark]
    public List<Class156> GetClass156()
    {
        var list = new List<Class156>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass156(i));
        return list;
    }

    [Benchmark]
    public List<Class160> GetClass160()
    {
        var list = new List<Class160>(Iterations);
        for (int i = 0; i < Iterations; i++) Add(list, GetClass160(i));
        return list;
    }

    public static Class04 GetClass04(int value) => new(value);
    public static Class08 GetClass08(int value) => new(value, value);
    public static Class12 GetClass12(int value) => new(value, value, value);
    public static Class16 GetClass16(int value) => new(value, value, value, value);
    public static Class20 GetClass20(int value) => new(value, value, value, value, value);
    public static Class24 GetClass24(int value) => new(value, value, value, value, value, value);
    public static Class28 GetClass28(int value) => new(value, value, value, value, value, value, value);
    public static Class32 GetClass32(int value) => new(value, value, value, value, value, value, value, value);
    public static Class36 GetClass36(int value) => new(value, value, value, value, value, value, value, value, value);
    public static Class40 GetClass40(int value) => new(value, value, value, value, value, value, value, value, value, value);
    public static Class44 GetClass44(int value) => new(value, value, value, value, value, value, value, value, value, value, value);
    public static Class48 GetClass48(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class52 GetClass52(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class56 GetClass56(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class60 GetClass60(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class64 GetClass64(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class68 GetClass68(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class72 GetClass72(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class76 GetClass76(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class80 GetClass80(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class84 GetClass84(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class88 GetClass88(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class92 GetClass92(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class96 GetClass96(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class100 GetClass100(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class104 GetClass104(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class108 GetClass108(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class112 GetClass112(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class116 GetClass116(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class120 GetClass120(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class124 GetClass124(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class128 GetClass128(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class132 GetClass132(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class136 GetClass136(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class140 GetClass140(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class144 GetClass144(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class148 GetClass148(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class152 GetClass152(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class156 GetClass156(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);
    public static Class160 GetClass160(int value) => new(value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value, value);

    public record class Class04(int Param);
    public record class Class08(int Param1, int Param2);
    public record class Class12(int Param1, int Param2, int Param3);
    public record class Class16(int Param1, int Param2, int Param3, int Param4);
    public record class Class20(int Param1, int Param2, int Param3, int Param4, int Param5);
    public record class Class24(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6);
    public record class Class28(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7);
    public record class Class32(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8);
    public record class Class36(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9);
    public record class Class40(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10);
    public record class Class44(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11);
    public record class Class48(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12);
    public record class Class52(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13);
    public record class Class56(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14);
    public record class Class60(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15);
    public record class Class64(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16);
    public record class Class68(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17);
    public record class Class72(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18);
    public record class Class76(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19);
    public record class Class80(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20);
    public record class Class84(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21);
    public record class Class88(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22);
    public record class Class92(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23);
    public record class Class96(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24);
    public record class Class100(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25);
    public record class Class104(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26);
    public record class Class108(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27);
    public record class Class112(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28);
    public record class Class116(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29);
    public record class Class120(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30);
    public record class Class124(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31);
    public record class Class128(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32);
    public record class Class132(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33);
    public record class Class136(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34);
    public record class Class140(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35);
    public record class Class144(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36);
    public record class Class148(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37);
    public record class Class152(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37, int Param38);
    public record class Class156(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37, int Param38, int Param39);
    public record class Class160(int Param1, int Param2, int Param3, int Param4, int Param5, int Param6, int Param7, int Param8, int Param9, int Param10, int Param11, int Param12, int Param13, int Param14, int Param15, int Param16, int Param17, int Param18, int Param19, int Param20, int Param21, int Param22, int Param23, int Param24, int Param25, int Param26, int Param27, int Param28, int Param29, int Param30, int Param31, int Param32, int Param33, int Param34, int Param35, int Param36, int Param37, int Param38, int Param39, int Param40);
}