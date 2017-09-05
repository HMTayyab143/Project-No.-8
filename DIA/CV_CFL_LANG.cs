﻿namespace DIA
{
    /// <summary>
    /// Specifies the source code language of the application or linked module.
    /// </summary>
    public enum CV_CFL_LANG : uint
    {
        /// <summary>
        /// Application language is C.
        /// </summary>
        CV_CFL_C = 0x00,

        /// <summary>
        /// Application language is C++.
        /// </summary>
        CV_CFL_CXX = 0x01,

        /// <summary>
        /// Application language is FORTRAN.
        /// </summary>
        CV_CFL_FORTRAN = 0x02,

        /// <summary>
        /// Application language is Microsoft Macro Assembler.
        /// </summary>
        CV_CFL_MASM = 0x03,

        /// <summary>
        /// Application language is Pascal.
        /// </summary>
        CV_CFL_PASCAL = 0x04,

        /// <summary>
        /// Application language is BASIC.
        /// </summary>
        CV_CFL_BASIC = 0x05,

        /// <summary>
        /// Application language is COBOL.
        /// </summary>
        CV_CFL_COBOL = 0x06,

        /// <summary>
        /// Application is a linker-generated module.
        /// </summary>
        CV_CFL_LINK = 0x07,

        /// <summary>
        /// Application is a resource module converted with CVTRES tool.
        /// </summary>
        CV_CFL_CVTRES = 0x08,

        /// <summary>
        /// Application is a POGO optimized module generated with CVTPGD tool.
        /// </summary>
        CV_CFL_CVTPGD = 0x09,

        /// <summary>
        /// Application language is C#.
        /// </summary>
        CV_CFL_CSHARP = 0x0A,

        /// <summary>
        /// Application language is Visual Basic.
        /// </summary>
        CV_CFL_VB = 0x0B,

        /// <summary>
        /// Application language is intermediate language assembly (that is, Common Language Runtime (CLR) assembly).
        /// </summary>
        CV_CFL_ILASM = 0x0C,

        /// <summary>
        /// Application language is Java.
        /// </summary>
        CV_CFL_JAVA = 0x0D,

        /// <summary>
        /// Application language is Jscript.
        /// </summary>
        CV_CFL_JSCRIPT = 0x0E,

        /// <summary>
        /// Application language is an unknown Microsoft Intermediate Language (MSIL), possibly a result of using the /LTCG (Link-time Code Generation) switch.
        /// </summary>
        CV_CFL_MSIL = 0x0F,
    }
}
