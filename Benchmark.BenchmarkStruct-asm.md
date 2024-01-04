## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct4()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct04, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        short M00_L04
       test      edx,edx
       je        short M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct04[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       edx,ebp
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       short M00_L06
       lea       r8d,[rcx+1]
       mov       [rsi+10],r8d
       mov       [rax+rcx*4+10],edx
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21023C01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L00
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBEC10]
       jmp       short M00_L02
; Total bytes of code 202
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct8()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct08, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        short M00_L04
       test      edx,edx
       je        short M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct08[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r8d,ebp
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       short M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       lea       rax,[rax+rcx*8+10]
       mov       [rax],r8d
       mov       [rax+4],r8d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25937801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L00
M00_L06:
       mov       [rsp+20],r8d
       mov       [rsp+24],r8d
       mov       rcx,rsi
       mov       rdx,[rsp+20]
       call      qword ptr [7FF9ABEBEC40]
       jmp       short M00_L02
; Total bytes of code 222
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct12()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct12, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        short M00_L04
       test      edx,edx
       je        short M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct12[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r8d,ebp
       mov       r10d,r8d
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       short M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       lea       rcx,[rcx+rcx*2]
       lea       rax,[rax+rcx*4+10]
       mov       [rax],r10d
       mov       [rax+4],r8d
       mov       [rax+8],r8d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DDEB801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+28],r10d
       mov       [rsp+2C],r8d
       mov       [rsp+30],r8d
       mov       rcx,rsi
       lea       rdx,[rsp+28]
       call      qword ptr [7FF9ABEBEC70]
       jmp       short M00_L02
; Total bytes of code 241
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct16()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct16, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        short M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct16[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       short M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rax],r8d
       mov       [rax+4],r10d
       mov       [rax+8],r14d
       mov       [rax+0C],r14d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C184001E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+20],r8d
       mov       [rsp+24],r10d
       mov       [rsp+28],r14d
       mov       [rsp+2C],r14d
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAECA0]
       jmp       short M00_L02
; Total bytes of code 261
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct20()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct20, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct20[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       short M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       lea       rcx,[rcx+rcx*4]
       lea       rax,[rax+rcx*4+10]
       mov       [rax],r8d
       mov       [rax+4],r10d
       mov       [rax+8],r9d
       mov       [rax+0C],r14d
       mov       [rax+10],r14d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23DEC001E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+28],r8d
       mov       [rsp+2C],r10d
       mov       [rsp+30],r9d
       mov       [rsp+34],r14d
       mov       [rsp+38],r14d
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBECD0]
       jmp       short M00_L02
; Total bytes of code 277
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct24()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct24, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct24[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       short M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       lea       rcx,[rcx+rcx*2]
       lea       rax,[rax+rcx*8+10]
       mov       [rax],r8d
       mov       [rax+4],r10d
       mov       [rax+8],r9d
       mov       [rax+0C],r11d
       mov       [rax+10],r14d
       mov       [rax+14],r14d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2EB1C401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+28],r8d
       mov       [rsp+2C],r10d
       mov       [rsp+30],r9d
       mov       [rsp+34],r11d
       mov       [rsp+38],r14d
       mov       [rsp+3C],r14d
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECED00]
       jmp       M00_L02
; Total bytes of code 292
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct28()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct28, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct28[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,1C
       lea       rax,[rax+rcx+10]
       mov       [rax],r14d
       mov       [rax+4],r14d
       mov       [rax+8],r14d
       mov       [rax+0C],r14d
       mov       [rax+10],r14d
       mov       [rax+14],r14d
       mov       [rax+18],r14d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23845001E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+20],r14d
       mov       [rsp+24],r14d
       mov       [rsp+28],r14d
       mov       [rsp+2C],r14d
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       [rsp+38],r14d
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAED30]
       jmp       M00_L02
; Total bytes of code 293
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct32()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct32, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       shl       rcx,5
       lea       rax,[rax+rcx+10]
       mov       [rax],r14d
       mov       [rax+4],r14d
       mov       [rax+8],r14d
       mov       [rax+0C],r14d
       mov       [rax+10],r14d
       mov       [rax+14],r8d
       mov       [rax+18],r10d
       mov       [rax+1C],r10d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27827401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+20],r14d
       mov       [rsp+24],r14d
       mov       [rsp+28],r14d
       mov       [rsp+2C],r14d
       mov       [rsp+30],r14d
       mov       [rsp+34],r8d
       mov       [rsp+38],r10d
       mov       [rsp+3C],r10d
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDED60]
       jmp       M00_L02
; Total bytes of code 308
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct36()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct36, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct36[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       lea       rcx,[rcx+rcx*8]
       lea       rax,[rax+rcx*4+10]
       mov       [rax],r14d
       mov       [rax+4],r14d
       mov       [rax+8],r14d
       mov       [rax+0C],r14d
       mov       [rax+10],r8d
       mov       [rax+14],r10d
       mov       [rax+18],r9d
       mov       [rax+1C],r11d
       mov       [rax+20],r11d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2586F801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+28],r14d
       mov       [rsp+2C],r14d
       mov       [rsp+30],r14d
       mov       [rsp+34],r14d
       mov       [rsp+38],r8d
       mov       [rsp+3C],r10d
       mov       [rsp+40],r9d
       mov       [rsp+44],r11d
       mov       [rsp+48],r11d
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDED90]
       jmp       M00_L02
; Total bytes of code 323
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct40()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct40, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct40[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       mov       r14d,ebp
       mov       eax,r14d
       mov       ecx,r14d
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       r15d,r14d
       inc       dword ptr [rsi+14]
       mov       rdi,[rsi+8]
       mov       r13d,[rsi+10]
       mov       r12d,[rdi+8]
       cmp       r12d,r13d
       jbe       M00_L06
       lea       r12d,[r13+1]
       mov       [rsi+10],r12d
       lea       r13,[r13+r13*4]
       lea       rdi,[rdi+r13*8+10]
       mov       [rdi],eax
       mov       [rdi+4],ecx
       mov       [rdi+8],r14d
       mov       [rdi+0C],r8d
       mov       [rdi+10],r10d
       mov       [rdi+14],r9d
       mov       [rdi+18],r11d
       mov       [rdi+1C],edx
       mov       [rdi+20],r15d
       mov       [rdi+24],r15d
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27153401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+20],r14d
       mov       [rsp+24],r14d
       mov       [rsp+28],r14d
       mov       [rsp+2C],r8d
       mov       [rsp+30],r10d
       mov       [rsp+34],r9d
       mov       [rsp+38],r11d
       mov       [rsp+3C],edx
       mov       [rsp+40],r15d
       mov       [rsp+44],r15d
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECEDC0]
       jmp       M00_L02
; Total bytes of code 358
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct44()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct44, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+0A0],rbx
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct44[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       ecx,r14d
       mov       eax,r14d
       mov       r15d,r14d
       mov       r13d,r14d
       inc       dword ptr [rsi+14]
       mov       rdi,[rsi+8]
       mov       r12d,[rsi+10]
       mov       ebx,[rdi+8]
       cmp       ebx,r12d
       jbe       M00_L06
       lea       ebx,[r12+1]
       mov       [rsi+10],ebx
       mov       ebx,r12d
       imul      rbx,2C
       lea       rbx,[rdi+rbx+10]
       mov       [rbx],r8d
       mov       [rbx+4],r14d
       mov       [rbx+8],r10d
       mov       [rbx+0C],r9d
       mov       [rbx+10],r11d
       mov       [rbx+14],edx
       mov       [rbx+18],ecx
       mov       [rbx+1C],eax
       mov       [rbx+20],r15d
       mov       [rbx+24],r13d
       mov       [rbx+28],r13d
M00_L02:
       inc       ebp
       mov       rbx,[rsp+0A0]
       cmp       ebp,[rbx+10]
       mov       [rsp+0A0],rbx
       jl        M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A582401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+28],r8d
       mov       [rsp+2C],r14d
       mov       [rsp+30],r10d
       mov       [rsp+34],r9d
       mov       [rsp+38],r11d
       mov       [rsp+3C],edx
       mov       [rsp+40],ecx
       mov       [rsp+44],eax
       mov       [rsp+48],r15d
       mov       [rsp+4C],r13d
       mov       [rsp+50],r13d
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAEDF0]
       jmp       M00_L02
; Total bytes of code 401
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct48()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct48, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+0A0],rbx
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct48[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       ecx,r14d
       mov       eax,r14d
       mov       r15d,r14d
       mov       [rsp+24],r14d
       mov       r12d,r14d
       inc       dword ptr [rsi+14]
       mov       rdi,[rsi+8]
       mov       ebx,[rsi+10]
       mov       r13d,[rdi+8]
       cmp       r13d,ebx
       jbe       M00_L06
       lea       r13d,[rbx+1]
       mov       [rsi+10],r13d
       imul      rbx,30
       lea       rbx,[rdi+rbx+10]
       mov       [rbx],r14d
       mov       [rbx+4],r8d
       mov       [rbx+8],r10d
       mov       [rbx+0C],r9d
       mov       [rbx+10],r11d
       mov       [rbx+14],edx
       mov       [rbx+18],ecx
       mov       [rbx+1C],eax
       mov       [rbx+20],r15d
       mov       r13d,[rsp+24]
       mov       [rbx+24],r13d
       mov       [rbx+28],r12d
       mov       [rbx+2C],r12d
M00_L02:
       inc       ebp
       mov       rbx,[rsp+0A0]
       cmp       ebp,[rbx+10]
       mov       [rsp+0A0],rbx
       jl        M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,21C27C01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+28],r14d
       mov       [rsp+2C],r8d
       mov       [rsp+30],r10d
       mov       [rsp+34],r9d
       mov       [rsp+38],r11d
       mov       [rsp+3C],edx
       mov       [rsp+40],ecx
       mov       [rsp+44],eax
       mov       [rsp+48],r15d
       mov       r13d,[rsp+24]
       mov       [rsp+4C],r13d
       mov       [rsp+50],r12d
       mov       [rsp+54],r12d
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAEE20]
       jmp       M00_L02
; Total bytes of code 422
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct52()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct52, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+0B0],rbx
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct52[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       ecx,r14d
       mov       eax,r14d
       mov       r15d,r14d
       mov       r13d,r14d
       mov       [rsp+2C],r14d
       mov       [rsp+28],r14d
       inc       dword ptr [rsi+14]
       mov       rbx,[rsi+8]
       mov       edi,[rsi+10]
       mov       r12d,[rbx+8]
       cmp       r12d,edi
       jbe       M00_L06
       lea       r12d,[rdi+1]
       mov       [rsi+10],r12d
       imul      rdi,34
       lea       rbx,[rbx+rdi+10]
       mov       [rbx],r8d
       mov       [rbx+4],r10d
       mov       [rbx+8],r9d
       mov       [rbx+0C],r11d
       mov       [rbx+10],edx
       mov       [rbx+14],ecx
       mov       [rbx+18],eax
       mov       [rbx+1C],r15d
       mov       [rbx+20],r13d
       mov       r12d,[rsp+2C]
       mov       [rbx+24],r12d
       mov       edi,[rsp+28]
       mov       [rbx+28],edi
       mov       [rbx+2C],r14d
       mov       [rbx+30],r14d
M00_L02:
       inc       ebp
       mov       rbx,[rsp+0B0]
       cmp       ebp,[rbx+10]
       mov       [rsp+0B0],rbx
       jl        M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D8FA401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+30],r8d
       mov       [rsp+34],r10d
       mov       [rsp+38],r9d
       mov       [rsp+3C],r11d
       mov       [rsp+40],edx
       mov       [rsp+44],ecx
       mov       [rsp+48],eax
       mov       [rsp+4C],r15d
       mov       [rsp+50],r13d
       mov       r12d,[rsp+2C]
       mov       [rsp+54],r12d
       mov       edi,[rsp+28]
       mov       [rsp+58],edi
       mov       [rsp+5C],r14d
       mov       [rsp+60],r14d
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBEE50]
       jmp       M00_L02
; Total bytes of code 442
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct56()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct56, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+0B0],rbx
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct56[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       ecx,r14d
       mov       eax,r14d
       mov       r15d,r14d
       mov       r13d,r14d
       mov       [rsp+2C],r14d
       mov       [rsp+28],r14d
       mov       [rsp+24],r14d
       inc       dword ptr [rsi+14]
       mov       rbx,[rsi+8]
       mov       edi,[rsi+10]
       mov       r12d,[rbx+8]
       cmp       r12d,edi
       jbe       M00_L06
       lea       r12d,[rdi+1]
       mov       [rsi+10],r12d
       imul      rdi,38
       lea       rbx,[rbx+rdi+10]
       mov       [rbx],r8d
       mov       [rbx+4],r10d
       mov       [rbx+8],r9d
       mov       [rbx+0C],r11d
       mov       [rbx+10],edx
       mov       [rbx+14],ecx
       mov       [rbx+18],eax
       mov       [rbx+1C],r15d
       mov       [rbx+20],r13d
       mov       r12d,[rsp+2C]
       mov       [rbx+24],r12d
       mov       edi,[rsp+28]
       mov       [rbx+28],edi
       mov       r8d,[rsp+24]
       mov       [rbx+2C],r8d
       mov       [rbx+30],r14d
       mov       [rbx+34],r14d
M00_L02:
       inc       ebp
       mov       rbx,[rsp+0B0]
       cmp       ebp,[rbx+10]
       mov       [rsp+0B0],rbx
       jl        M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19143C01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+30],r8d
       mov       [rsp+34],r10d
       mov       [rsp+38],r9d
       mov       [rsp+3C],r11d
       mov       [rsp+40],edx
       mov       [rsp+44],ecx
       mov       [rsp+48],eax
       mov       [rsp+4C],r15d
       mov       [rsp+50],r13d
       mov       r12d,[rsp+2C]
       mov       [rsp+54],r12d
       mov       edi,[rsp+28]
       mov       [rsp+58],edi
       mov       r8d,[rsp+24]
       mov       [rsp+5C],r8d
       mov       [rsp+60],r14d
       mov       [rsp+64],r14d
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECEE80]
       jmp       M00_L02
; Total bytes of code 466
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct60()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct60, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+0C0],rbx
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct60[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       ecx,r14d
       mov       eax,r14d
       mov       r15d,r14d
       mov       r13d,r14d
       mov       [rsp+34],r14d
       mov       [rsp+30],r14d
       mov       [rsp+2C],r14d
       mov       [rsp+28],r14d
       inc       dword ptr [rsi+14]
       mov       rbx,[rsi+8]
       mov       edi,[rsi+10]
       mov       r12d,[rbx+8]
       cmp       r12d,edi
       jbe       M00_L06
       lea       r12d,[rdi+1]
       mov       [rsi+10],r12d
       imul      rdi,3C
       lea       rbx,[rbx+rdi+10]
       mov       [rbx],r8d
       mov       [rbx+4],r10d
       mov       [rbx+8],r9d
       mov       [rbx+0C],r11d
       mov       [rbx+10],edx
       mov       [rbx+14],ecx
       mov       [rbx+18],eax
       mov       [rbx+1C],r15d
       mov       [rbx+20],r13d
       mov       r12d,[rsp+34]
       mov       [rbx+24],r12d
       mov       edi,[rsp+30]
       mov       [rbx+28],edi
       mov       r8d,[rsp+2C]
       mov       [rbx+2C],r8d
       mov       r8d,[rsp+28]
       mov       [rbx+30],r8d
       mov       [rbx+34],r14d
       mov       [rbx+38],r14d
M00_L02:
       inc       ebp
       mov       rbx,[rsp+0C0]
       cmp       ebp,[rbx+10]
       mov       [rsp+0C0],rbx
       jl        M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E57EC01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+38],r8d
       mov       [rsp+3C],r10d
       mov       [rsp+40],r9d
       mov       [rsp+44],r11d
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       mov       [rsp+50],eax
       mov       [rsp+54],r15d
       mov       [rsp+58],r13d
       mov       r12d,[rsp+34]
       mov       [rsp+5C],r12d
       mov       edi,[rsp+30]
       mov       [rsp+60],edi
       mov       r8d,[rsp+2C]
       mov       [rsp+64],r8d
       mov       r8d,[rsp+28]
       mov       [rsp+68],r8d
       mov       [rsp+6C],r14d
       mov       [rsp+70],r14d
       lea       rdx,[rsp+38]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECEEB0]
       jmp       M00_L02
; Total bytes of code 490
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct64()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct64, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+0C0],rbx
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct64[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       M00_L03
M00_L01:
       mov       r14d,ebp
       mov       r8d,r14d
       mov       r10d,r14d
       mov       r9d,r14d
       mov       r11d,r14d
       mov       edx,r14d
       mov       ecx,r14d
       mov       eax,r14d
       mov       r15d,r14d
       mov       r13d,r14d
       mov       [rsp+34],r14d
       mov       [rsp+30],r14d
       mov       [rsp+2C],r14d
       mov       [rsp+28],r14d
       mov       [rsp+24],r14d
       inc       dword ptr [rsi+14]
       mov       rbx,[rsi+8]
       mov       edi,[rsi+10]
       mov       r12d,[rbx+8]
       cmp       r12d,edi
       jbe       M00_L06
       lea       r12d,[rdi+1]
       mov       [rsi+10],r12d
       shl       rdi,6
       lea       rbx,[rbx+rdi+10]
       mov       [rbx],r8d
       mov       [rbx+4],r10d
       mov       [rbx+8],r9d
       mov       [rbx+0C],r11d
       mov       [rbx+10],edx
       mov       [rbx+14],ecx
       mov       [rbx+18],eax
       mov       [rbx+1C],r15d
       mov       [rbx+20],r13d
       mov       r12d,[rsp+34]
       mov       [rbx+24],r12d
       mov       edi,[rsp+30]
       mov       [rbx+28],edi
       mov       r8d,[rsp+2C]
       mov       [rbx+2C],r8d
       mov       r8d,[rsp+28]
       mov       [rbx+30],r8d
       mov       r8d,[rsp+24]
       mov       [rbx+34],r8d
       mov       [rbx+38],r14d
       mov       [rbx+3C],r14d
M00_L02:
       inc       ebp
       mov       rbx,[rsp+0C0]
       cmp       ebp,[rbx+10]
       mov       [rsp+0C0],rbx
       jl        M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22462001E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       mov       [rsp+38],r8d
       mov       [rsp+3C],r10d
       mov       [rsp+40],r9d
       mov       [rsp+44],r11d
       mov       [rsp+48],edx
       mov       [rsp+4C],ecx
       mov       [rsp+50],eax
       mov       [rsp+54],r15d
       mov       [rsp+58],r13d
       mov       r12d,[rsp+34]
       mov       [rsp+5C],r12d
       mov       edi,[rsp+30]
       mov       [rsp+60],edi
       mov       r8d,[rsp+2C]
       mov       [rsp+64],r8d
       mov       r8d,[rsp+28]
       mov       [rsp+68],r8d
       mov       r8d,[rsp+24]
       mov       [rsp+6C],r8d
       mov       [rsp+70],r14d
       mov       [rsp+74],r14d
       lea       rdx,[rsp+38]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAEEE0]
       jmp       M00_L02
; Total bytes of code 514
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct68()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct68, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct68[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB5230]; Benchmark.BenchmarkStruct.GetStruct68(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,44
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       mov       edx,[rsp+60]
       mov       [rax+rcx+50],edx
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C4BF401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBEF10]
       jmp       short M00_L02
; Total bytes of code 264
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct68(Int32)
       push      rbp
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+0E0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-50],ymm0
       vmovdqu   [rbp-30],ymm0
       vmovdqu   [rbp-1C],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       lea       rcx,[rbp-50]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct68..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-50]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-30]
       vmovdqu   [rbx+20],ymm0
       mov       eax,[rbp-10]
       mov       [rbx+40],eax
       mov       rax,rbx
       add       rsp,0D8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 158
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct72()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct72, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct72[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEA5248]; Benchmark.BenchmarkStruct.GetStruct72(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       lea       rcx,[rcx+rcx*8]
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx*8+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx*8+30],ymm0
       mov       rdx,[rsp+60]
       mov       [rax+rcx*8+50],rdx
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C17C801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAEF40]
       jmp       short M00_L02
; Total bytes of code 266
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct72(Int32)
       push      rbp
       push      rbx
       sub       rsp,0E8
       vzeroupper
       lea       rbp,[rsp+0F0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-50],ymm0
       vmovdqu   [rbp-30],ymm0
       vmovdqu   [rbp-18],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       lea       rcx,[rbp-50]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEAE910]; Benchmark.BenchmarkStruct+Struct72..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-50]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-30]
       vmovdqu   [rbx+20],ymm0
       mov       rax,[rbp-10]
       mov       [rbx+40],rax
       mov       rax,rbx
       add       rsp,0E8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 167
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct76()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct76, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct76[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB5260]; Benchmark.BenchmarkStruct.GetStruct76(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,4C
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   xmm0,[rsp+64]
       vmovdqu   [rax+rcx+4C],xmm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27565401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBEF70]
       jmp       short M00_L02
; Total bytes of code 268
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct76(Int32)
       push      rbp
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+100]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-58],ymm0
       vmovdqu   [rbp-38],ymm0
       vmovdqu   [rbp-1C],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       lea       rcx,[rbp-58]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct76..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-58]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-38]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   xmm0,[rbp-1C]
       vmovdqu   [rbx+3C],xmm0
       mov       rax,rbx
       add       rsp,0F8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 176
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct80()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct80, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct80[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABED5278]; Benchmark.BenchmarkStruct.GetStruct80(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,50
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   xmm0,[rsp+68]
       vmovdqu   [rax+rcx+50],xmm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E77FC01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDEFA0]
       jmp       short M00_L02
; Total bytes of code 268
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct80(Int32)
       push      rbp
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+100]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-58],ymm0
       vmovdqu   [rbp-38],ymm0
       vmovdqu   [rbp-18],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       lea       rcx,[rbp-58]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct80..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-58]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-38]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   xmm0,[rbp-18]
       vmovdqu   [rbx+40],xmm0
       mov       rax,rbx
       add       rsp,0F8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 183
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct84()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct84, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct84[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEC5290]; Benchmark.BenchmarkStruct.GetStruct84(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,54
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+54]
       vmovdqu   [rax+rcx+44],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,23FCF801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECEFD0]
       jmp       short M00_L02
; Total bytes of code 268
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct84(Int32)
       push      rbp
       push      rbx
       sub       rsp,108
       vzeroupper
       lea       rbp,[rsp+110]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-60],ymm0
       vmovdqu   [rbp-40],ymm0
       vmovdqu   [rbp-2C],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       lea       rcx,[rbp-60]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABECE910]; Benchmark.BenchmarkStruct+Struct84..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-60]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-40]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-2C]
       vmovdqu   [rbx+34],ymm0
       mov       rax,rbx
       add       rsp,108
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 190
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct88()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct88, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct88[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEA52A8]; Benchmark.BenchmarkStruct.GetStruct88(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,58
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+58]
       vmovdqu   [rax+rcx+48],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20BA1C01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAF000]
       jmp       short M00_L02
; Total bytes of code 268
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct88(Int32)
       push      rbp
       push      rbx
       sub       rsp,118
       vzeroupper
       lea       rbp,[rsp+120]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-60],ymm0
       vmovdqu   [rbp-40],ymm0
       vmovdqu   [rbp-28],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       lea       rcx,[rbp-60]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEAE910]; Benchmark.BenchmarkStruct+Struct88..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-60]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-40]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-28]
       vmovdqu   [rbx+38],ymm0
       mov       rax,rbx
       add       rsp,118
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 197
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct92()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct92, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct92[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABED52C0]; Benchmark.BenchmarkStruct.GetStruct92(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,5C
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+64]
       vmovdqu   [rax+rcx+4C],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D72F401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF030]
       jmp       short M00_L02
; Total bytes of code 274
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct92(Int32)
       push      rbp
       push      rbx
       sub       rsp,128
       vzeroupper
       lea       rbp,[rsp+130]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-68],ymm0
       vmovdqu   [rbp-48],ymm0
       vmovdqu   [rbp-2C],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       lea       rcx,[rbp-68]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct92..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-68]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-48]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-2C]
       vmovdqu   [rbx+3C],ymm0
       mov       rax,rbx
       add       rsp,128
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 204
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct96()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct96, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct96[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB52D8]; Benchmark.BenchmarkStruct.GetStruct96(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,60
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+68]
       vmovdqu   [rax+rcx+50],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,278ED401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBF060]
       jmp       short M00_L02
; Total bytes of code 274
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct96(Int32)
       push      rbp
       push      rbx
       sub       rsp,128
       vzeroupper
       lea       rbp,[rsp+130]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-68],ymm0
       vmovdqu   [rbp-48],ymm0
       vmovdqu   [rbp-28],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       lea       rcx,[rbp-68]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct96..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-68]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-48]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-28]
       vmovdqu   [rbx+40],ymm0
       mov       rax,rbx
       add       rsp,128
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 211
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct100()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct100, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct100[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABED52F0]; Benchmark.BenchmarkStruct.GetStruct100(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,64
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+60]
       vmovdqu   [rax+rcx+50],ymm0
       mov       edx,[rsp+80]
       mov       [rax+rcx+70],edx
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B682401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF090]
       jmp       short M00_L02
; Total bytes of code 285
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct100(Int32)
       push      rbp
       push      rbx
       sub       rsp,138
       vzeroupper
       lea       rbp,[rsp+140]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-70],ymm0
       vmovdqu   [rbp-50],ymm0
       vmovdqu   [rbp-30],ymm0
       vmovdqu   [rbp-1C],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       lea       rcx,[rbp-70]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct100..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-70]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-50]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-30]
       vmovdqu   [rbx+40],ymm0
       mov       eax,[rbp-10]
       mov       [rbx+60],eax
       mov       rax,rbx
       add       rsp,138
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 229
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct104()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct104, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct104[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEC5308]; Benchmark.BenchmarkStruct.GetStruct104(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,68
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+60]
       vmovdqu   [rax+rcx+50],ymm0
       mov       rdx,[rsp+80]
       mov       [rax+rcx+70],rdx
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25165801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECF0C0]
       jmp       short M00_L02
; Total bytes of code 287
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct104(Int32)
       push      rbp
       push      rbx
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+150]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-70],ymm0
       vmovdqu   [rbp-50],ymm0
       vmovdqu   [rbp-30],ymm0
       vmovdqu   [rbp-18],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       lea       rcx,[rbp-70]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABECE910]; Benchmark.BenchmarkStruct+Struct104..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-70]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-50]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-30]
       vmovdqu   [rbx+40],ymm0
       mov       rax,[rbp-10]
       mov       [rbx+60],rax
       mov       rax,rbx
       add       rsp,148
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 238
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct108()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct108, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct108[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEC5320]; Benchmark.BenchmarkStruct.GetStruct108(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,6C
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+68]
       vmovdqu   [rax+rcx+50],ymm0
       vmovdqu   xmm0,[rsp+84]
       vmovdqu   [rax+rcx+6C],xmm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE6ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC15120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1DECDC01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABECF0F0]
       jmp       short M00_L02
; Total bytes of code 289
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct108(Int32)
       push      rbp
       push      rbx
       sub       rsp,158
       vzeroupper
       lea       rbp,[rsp+160]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-78],ymm0
       vmovdqu   [rbp-58],ymm0
       vmovdqu   [rbp-38],ymm0
       vmovdqu   [rbp-1C],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       lea       rcx,[rbp-78]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABECE910]; Benchmark.BenchmarkStruct+Struct108..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-78]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-58]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-38]
       vmovdqu   [rbx+40],ymm0
       vmovdqu   xmm0,[rbp-1C]
       vmovdqu   [rbx+5C],xmm0
       mov       rax,rbx
       add       rsp,158
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 247
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct112()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct112, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct112[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB5338]; Benchmark.BenchmarkStruct.GetStruct112(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,70
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+68]
       vmovdqu   [rax+rcx+50],ymm0
       vmovdqu   xmm0,[rsp+88]
       vmovdqu   [rax+rcx+70],xmm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1E635401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBF120]
       jmp       short M00_L02
; Total bytes of code 289
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct112(Int32)
       push      rbp
       push      rbx
       sub       rsp,158
       vzeroupper
       lea       rbp,[rsp+160]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-78],ymm0
       vmovdqu   [rbp-58],ymm0
       vmovdqu   [rbp-38],ymm0
       vmovdqu   [rbp-18],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       lea       rcx,[rbp-78]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct112..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-78]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-58]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-38]
       vmovdqu   [rbx+40],ymm0
       vmovdqu   xmm0,[rbp-18]
       vmovdqu   [rbx+60],xmm0
       mov       rax,rbx
       add       rsp,158
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct116()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct116, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct116[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB5350]; Benchmark.BenchmarkStruct.GetStruct116(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,74
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+60]
       vmovdqu   [rax+rcx+50],ymm0
       vmovdqu   ymm0,[rsp+74]
       vmovdqu   [rax+rcx+64],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F030401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBF150]
       jmp       short M00_L02
; Total bytes of code 286
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct116(Int32)
       push      rbp
       push      rbx
       sub       rsp,168
       vzeroupper
       lea       rbp,[rsp+170]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-80],ymm0
       vmovdqu   [rbp-60],ymm0
       vmovdqu   [rbp-40],ymm0
       vmovdqu   [rbp-2C],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       lea       rcx,[rbp-80]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct116..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-80]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-60]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-40]
       vmovdqu   [rbx+40],ymm0
       vmovdqu   ymm0,[rbp-2C]
       vmovdqu   [rbx+54],ymm0
       mov       rax,rbx
       add       rsp,168
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 261
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct120()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct120, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct120[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABED5368]; Benchmark.BenchmarkStruct.GetStruct120(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,78
       vmovdqu   ymm0,[rsp+20]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+40]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+60]
       vmovdqu   [rax+rcx+50],ymm0
       vmovdqu   ymm0,[rsp+78]
       vmovdqu   [rax+rcx+68],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1C063801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF180]
       jmp       short M00_L02
; Total bytes of code 286
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct120(Int32)
       push      rbp
       push      rbx
       sub       rsp,178
       vzeroupper
       lea       rbp,[rsp+180]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-80],ymm0
       vmovdqu   [rbp-60],ymm0
       vmovdqu   [rbp-40],ymm0
       vmovdqu   [rbp-28],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       lea       rcx,[rbp-80]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct120..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-80]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-60]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-40]
       vmovdqu   [rbx+40],ymm0
       vmovdqu   ymm0,[rbp-28]
       vmovdqu   [rbx+58],ymm0
       mov       rax,rbx
       add       rsp,178
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 268
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct124()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct124, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct124[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABED5380]; Benchmark.BenchmarkStruct.GetStruct124(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       imul      rcx,7C
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+68]
       vmovdqu   [rax+rcx+50],ymm0
       vmovdqu   ymm0,[rsp+84]
       vmovdqu   [rax+rcx+6C],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,299CF001E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF1B0]
       jmp       short M00_L02
; Total bytes of code 289
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct124(Int32)
       push      rbp
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+190]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-88],ymm0
       vmovdqu   [rbp-68],ymm0
       vmovdqu   [rbp-48],ymm0
       vmovdqu   [rbp-2C],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       lea       rcx,[rbp-88]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct124..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-88]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-68]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-48]
       vmovdqu   [rbx+40],ymm0
       vmovdqu   ymm0,[rbp-2C]
       vmovdqu   [rbx+5C],ymm0
       mov       rax,rbx
       add       rsp,188
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct128()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vzeroupper
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct128, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct128[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABED5398]; Benchmark.BenchmarkStruct.GetStruct128(Int32)
       inc       dword ptr [rsi+14]
       mov       rax,[rsi+8]
       mov       ecx,[rsi+10]
       mov       edx,[rax+8]
       cmp       edx,ecx
       jbe       M00_L06
       lea       edx,[rcx+1]
       mov       [rsi+10],edx
       shl       rcx,7
       vmovdqu   ymm0,[rsp+28]
       vmovdqu   [rax+rcx+10],ymm0
       vmovdqu   ymm0,[rsp+48]
       vmovdqu   [rax+rcx+30],ymm0
       vmovdqu   ymm0,[rsp+68]
       vmovdqu   [rax+rcx+50],ymm0
       vmovdqu   ymm0,[rsp+88]
       vmovdqu   [rax+rcx+70],ymm0
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1AD6F401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF1E0]
       jmp       short M00_L02
; Total bytes of code 289
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct128(Int32)
       push      rbp
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+190]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-88],ymm0
       vmovdqu   [rbp-68],ymm0
       vmovdqu   [rbp-48],ymm0
       vmovdqu   [rbp-28],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       lea       rcx,[rbp-88]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct128..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       vmovdqu   ymm0,[rbp-88]
       vmovdqu   [rbx],ymm0
       vmovdqu   ymm0,[rbp-68]
       vmovdqu   [rbx+20],ymm0
       vmovdqu   ymm0,[rbp-48]
       vmovdqu   [rbx+40],ymm0
       vmovdqu   ymm0,[rbp-28]
       vmovdqu   [rbx+60],ymm0
       mov       rax,rbx
       add       rsp,188
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 291
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct132()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct132, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct132[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABED53B0]; Benchmark.BenchmarkStruct.GetStruct132(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,84
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+20]
       mov       r8d,84
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,16508401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF210]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct132(Int32)
       push      rbp
       push      rbx
       sub       rsp,198
       vzeroupper
       lea       rbp,[rsp+1A0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-90],ymm0
       vmovdqu   [rbp-70],ymm0
       vmovdqu   [rbp-50],ymm0
       vmovdqu   [rbp-30],ymm0
       vmovdqu   [rbp-1C],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       lea       rcx,[rbp-90]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct132..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-90]
       mov       r8d,84
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,198
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 282
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct136()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct136, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct136[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEA53C8]; Benchmark.BenchmarkStruct.GetStruct136(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,88
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+20]
       mov       r8d,88
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,28E42C01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAF240]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct136(Int32)
       push      rbp
       push      rbx
       sub       rsp,1A8
       vzeroupper
       lea       rbp,[rsp+1B0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-90],ymm0
       vmovdqu   [rbp-70],ymm0
       vmovdqu   [rbp-50],ymm0
       vmovdqu   [rbp-30],ymm0
       vmovdqu   [rbp-18],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       lea       rcx,[rbp-90]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEAE910]; Benchmark.BenchmarkStruct+Struct136..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-90]
       mov       r8d,88
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1A8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 289
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct140()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct140, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct140[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB53E0]; Benchmark.BenchmarkStruct.GetStruct140(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,8C
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+28]
       mov       r8d,8C
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1BA45801E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBF270]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct140(Int32)
       push      rbp
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1C0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-98],ymm0
       vmovdqu   [rbp-78],ymm0
       vmovdqu   [rbp-58],ymm0
       vmovdqu   [rbp-38],ymm0
       vmovdqu   [rbp-1C],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       mov       [rsp+118],edx
       lea       rcx,[rbp-98]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct140..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-98]
       mov       r8d,8C
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1B8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 296
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct144()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct144, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct144[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABED53F8]; Benchmark.BenchmarkStruct.GetStruct144(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,90
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+28]
       mov       r8d,90
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE7ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC25120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,116B9C01E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEDF2A0]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct144(Int32)
       push      rbp
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1C0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-98],ymm0
       vmovdqu   [rbp-78],ymm0
       vmovdqu   [rbp-58],ymm0
       vmovdqu   [rbp-38],ymm0
       vmovdqu   [rbp-18],xmm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       mov       [rsp+118],edx
       mov       [rsp+120],edx
       lea       rcx,[rbp-98]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEDE910]; Benchmark.BenchmarkStruct+Struct144..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-98]
       mov       r8d,90
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1B8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 303
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct148()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct148, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct148[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEB5410]; Benchmark.BenchmarkStruct.GetStruct148(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,94
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+20]
       mov       r8d,94
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE5ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC05120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FEE2401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEBF2D0]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct148(Int32)
       push      rbp
       push      rbx
       sub       rsp,1C8
       vzeroupper
       lea       rbp,[rsp+1D0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-0A0],ymm0
       vmovdqu   [rbp-80],ymm0
       vmovdqu   [rbp-60],ymm0
       vmovdqu   [rbp-40],ymm0
       vmovdqu   [rbp-2C],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       mov       [rsp+118],edx
       mov       [rsp+120],edx
       mov       [rsp+128],edx
       lea       rcx,[rbp-0A0]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEBE910]; Benchmark.BenchmarkStruct+Struct148..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-0A0]
       mov       r8d,94
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1C8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 310
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct152()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct152, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct152[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+20]
       mov       edx,ebp
       call      qword ptr [7FF9ABEE5428]; Benchmark.BenchmarkStruct.GetStruct152(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,98
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+20]
       mov       r8d,98
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE8ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABC35120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,221FF401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEEF300]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct152(Int32)
       push      rbp
       push      rbx
       sub       rsp,1D8
       vzeroupper
       lea       rbp,[rsp+1E0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-0A0],ymm0
       vmovdqu   [rbp-80],ymm0
       vmovdqu   [rbp-60],ymm0
       vmovdqu   [rbp-40],ymm0
       vmovdqu   [rbp-28],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       mov       [rsp+118],edx
       mov       [rsp+120],edx
       mov       [rsp+128],edx
       mov       [rsp+130],edx
       lea       rcx,[rbp-0A0]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEEE910]; Benchmark.BenchmarkStruct+Struct152..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-0A0]
       mov       r8d,98
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1D8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct156()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct156, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct156[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEA5440]; Benchmark.BenchmarkStruct.GetStruct156(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,9C
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+28]
       mov       r8d,9C
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1B27F401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAF330]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct156(Int32)
       push      rbp
       push      rbx
       sub       rsp,1E8
       vzeroupper
       lea       rbp,[rsp+1F0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-0A8],ymm0
       vmovdqu   [rbp-88],ymm0
       vmovdqu   [rbp-68],ymm0
       vmovdqu   [rbp-48],ymm0
       vmovdqu   [rbp-2C],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       mov       [rsp+118],edx
       mov       [rsp+120],edx
       mov       [rsp+128],edx
       mov       [rsp+130],edx
       mov       [rsp+138],edx
       lea       rcx,[rbp-0A8]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEAE910]; Benchmark.BenchmarkStruct+Struct156..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-0A8]
       mov       r8d,9C
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1E8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 327
```

## .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
```assembly
; Benchmark.BenchmarkStruct.GetStruct160()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       mov       rbx,rcx
       mov       rcx,MT_System.Collections.Generic.List`1[[Benchmark.BenchmarkStruct+Struct160, performance-optimizations]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       edi,[rbx+10]
       mov       edx,edi
       test      edx,edx
       jl        M00_L04
       test      edx,edx
       je        M00_L05
       movsxd    rdx,edx
       mov       rcx,MT_Benchmark.BenchmarkStruct+Struct160[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       xor       ebp,ebp
       test      edi,edi
       jle       short M00_L03
M00_L01:
       lea       rcx,[rsp+28]
       mov       edx,ebp
       call      qword ptr [7FF9ABEA5458]; Benchmark.BenchmarkStruct.GetStruct160(Int32)
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M00_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       imul      rdx,0A0
       lea       rcx,[rcx+rdx+10]
       lea       rdx,[rsp+28]
       mov       r8d,0A0
       call      CORINFO_HELP_MEMCPY
M00_L02:
       inc       ebp
       cmp       ebp,[rbx+10]
       jl        short M00_L01
M00_L03:
       mov       rax,rsi
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF9ABE4ED18]
       int3
M00_L05:
       mov       rcx,7FF9ABBF5120
       mov       edx,0E
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,20E42401E00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       M00_L00
M00_L06:
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       call      qword ptr [7FF9ABEAF360]
       jmp       short M00_L02
; Total bytes of code 259
```
```assembly
; Benchmark.BenchmarkStruct.GetStruct160(Int32)
       push      rbp
       push      rbx
       sub       rsp,1E8
       vzeroupper
       lea       rbp,[rsp+1F0]
       mov       rbx,rcx
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   [rbp-0A8],ymm0
       vmovdqu   [rbp-88],ymm0
       vmovdqu   [rbp-68],ymm0
       vmovdqu   [rbp-48],ymm0
       vmovdqu   [rbp-28],ymm0
       mov       [rsp+20],edx
       mov       [rsp+28],edx
       mov       [rsp+30],edx
       mov       [rsp+38],edx
       mov       [rsp+40],edx
       mov       [rsp+48],edx
       mov       [rsp+50],edx
       mov       [rsp+58],edx
       mov       [rsp+60],edx
       mov       [rsp+68],edx
       mov       [rsp+70],edx
       mov       [rsp+78],edx
       mov       [rsp+80],edx
       mov       [rsp+88],edx
       mov       [rsp+90],edx
       mov       [rsp+98],edx
       mov       [rsp+0A0],edx
       mov       [rsp+0A8],edx
       mov       [rsp+0B0],edx
       mov       [rsp+0B8],edx
       mov       [rsp+0C0],edx
       mov       [rsp+0C8],edx
       mov       [rsp+0D0],edx
       mov       [rsp+0D8],edx
       mov       [rsp+0E0],edx
       mov       [rsp+0E8],edx
       mov       [rsp+0F0],edx
       mov       [rsp+0F8],edx
       mov       [rsp+100],edx
       mov       [rsp+108],edx
       mov       [rsp+110],edx
       mov       [rsp+118],edx
       mov       [rsp+120],edx
       mov       [rsp+128],edx
       mov       [rsp+130],edx
       mov       [rsp+138],edx
       mov       [rsp+140],edx
       lea       rcx,[rbp-0A8]
       mov       r8d,edx
       mov       r9d,edx
       call      qword ptr [7FF9ABEAE910]; Benchmark.BenchmarkStruct+Struct160..ctor(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,rbx
       lea       rdx,[rbp-0A8]
       mov       r8d,0A0
       call      CORINFO_HELP_MEMCPY
       mov       rax,rbx
       add       rsp,1E8
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 334
```

