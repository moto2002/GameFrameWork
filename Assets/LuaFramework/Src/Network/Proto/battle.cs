// Code generated by protogen.
// DO NOT EDIT!!!
// source:  battle.proto
//
using CitrusNet;
using CitrusNet.Phobos;
using System.Collections.Generic;

namespace battle.proto {
    // 协议id定义
    [ProtoBuf.ProtoContract]
    public enum EMsgIds {
        
        ECS_Tick = 1,
        
        ESC_Tick = 2,
    }


    // 心跳
    [ProtoBuf.ProtoContract]
    public class CS_Tick : NetCommand {
    }

    
    [ProtoBuf.ProtoContract]
    public class SC_Tick : NetCommand {
    }


}