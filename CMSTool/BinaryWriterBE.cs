using System;
using System.IO;

namespace BETools
{
    class BinaryWriter2 : BinaryWriter
    {
        public BinaryWriter2(Stream stream) : base(stream) { }

        public override void Write(int value)
        {
            var data = BitConverter.GetBytes(value);
            Array.Reverse(data);
            base.Write(data);
        }

        public override void Write(Int16 value)
        {
            var data = BitConverter.GetBytes(value);
            Array.Reverse(data);
            base.Write(data);
        }

        public override void Write(Int64 value)
        {
            var data = BitConverter.GetBytes(value);
            Array.Reverse(data);
            base.Write(data);
        }

        public override void Write(UInt32 value)
        {
            var data = BitConverter.GetBytes(value);
            Array.Reverse(data);
            base.Write(data);
        }
    }
}