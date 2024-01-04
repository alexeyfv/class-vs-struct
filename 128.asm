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