﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basix.Interpreter.Commands
{
    public enum CommandType : byte
    {
        NONE,
        NO, // means that interpreter will not add it to bytes

        PUSH_STACK_INTEGER,
        POP_STACK_INTEGER,
        ADD_INTEGER,
        MIN_INTEGER,
        MUL_INTEGER,
        DIV_INTEGER,

        PUSH_STACK_FLOAT,
        POP_STACK_FLOAT,
        ADD_FLOAT,
        MIN_FLOAT,
        MUL_FLOAT,
        DIV_FLOAT,

        //when we deal with group of bytes (etc complex types)

        PUSH_SPAN, 
        POP_SPAN,

        GOTO_SEGMENT,
        GOTO_ABSOLUTE,
        RET
    }
}