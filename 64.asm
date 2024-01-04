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