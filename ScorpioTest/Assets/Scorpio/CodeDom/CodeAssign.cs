﻿using System;
using System.Collections.Generic;
using System.Text;
using Scorpio.Compiler;
namespace Scorpio.CodeDom {
    //赋值变量 = += -= /= *= %= |= &= ^= >>= <<=
    public class CodeAssign : CodeObject {
        public CodeMember member;
        public CodeObject value;
        public TokenType AssignType;
        public CodeAssign(CodeMember member, CodeObject value, TokenType assignType, int line) : base(line) {
            this.member = member;
            this.value = value;
            this.AssignType = assignType;
        }
        public override string ToString() {
            return $"{member} => {value}  {this.AssignType}";
        }
    }
}
