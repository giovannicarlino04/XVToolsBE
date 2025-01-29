using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AURTool
{
    public struct Char
    {
        public int id;
        public int costume;
        public short aurId;
        public short glare;
    }
    public struct Aura
    {
        public int id;
    }
    internal class AUR
    {
        public Int32 Magic = 0x52554123;
        public byte[] Endianness = { 0xFF, 0xFE };
        public short auraCount;
        public short charCount;
        public short startoffset;
        public Aura[] auras;
        public Char[] chars;
        public void Load(string FileName)
        {
            using (BinaryReader br = new BinaryReader(File.OpenRead(FileName)))
            {
                if (br.BaseStream == null)
                    throw new Exception("stream is NULL");

                br.BaseStream.Seek(0, SeekOrigin.Begin);

                if (br.ReadInt32() != Magic)
                    throw new Exception("Wrong file MAGIC");

                br.BaseStream.Seek(4, SeekOrigin.Begin);

                byte[] endianness = br.ReadBytes(2);

                if (!endianness.SequenceEqual(Endianness))
                {
                    string endiannessStr = BitConverter.ToString(endianness).Replace("-", " ");
                    string expectedEndiannessStr = BitConverter.ToString(Endianness).Replace("-", " ");
                    throw new Exception($"Wrong file ENDIANNESS: {endiannessStr} vs expected: {expectedEndiannessStr}");
                }

                br.BaseStream.Seek(10, SeekOrigin.Begin);
                auraCount = ReadReversedInt16(br);

                br.BaseStream.Seek(26, SeekOrigin.Begin);
                charCount = ReadReversedInt16(br);

                br.BaseStream.Seek(30, SeekOrigin.Begin);
                startoffset = ReadReversedInt16(br);


                int sizeOfEntry = 16;

                auras = new Aura[auraCount];
                chars = new Char[charCount];

                for (int i = 0; i < charCount; i++)
                {
                    br.BaseStream.Seek(startoffset + (sizeOfEntry * i), SeekOrigin.Begin);

                    chars[i].id = ReadReversedInt32(br);
                    chars[i].costume = ReadReversedInt32(br);
                    chars[i].aurId = ReadReversedInt16(br);
                    br.BaseStream.Seek(4, SeekOrigin.Current);
                    chars[i].glare = ReadReversedInt16(br);
                } 
            }              
        } 
        public void Save(string fileName)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(fileName, FileMode.Open)))
            {
                if (bw.BaseStream == null)
                    throw new Exception("stream is NULL");

                bw.BaseStream.Seek(0, SeekOrigin.Begin);
                bw.Write(Magic);
                bw.Write(Endianness);
                bw.BaseStream.Seek(10, SeekOrigin.Begin);
                bw.Write(WriteReversedInt16(auraCount));
                bw.BaseStream.Seek(26, SeekOrigin.Begin);
                bw.Write(WriteReversedInt16(charCount));
                bw.BaseStream.Seek(30, SeekOrigin.Begin);
                bw.Write(WriteReversedInt16(startoffset));

                // Write the entries for Aura and Char structures
                int sizeOfEntry = 16;

                for (int i = 0; i < charCount; i++)
                {
                    bw.BaseStream.Seek(startoffset + (sizeOfEntry * i), SeekOrigin.Begin);

                    // Write the Char entries
                    bw.Write(WriteReversedInt32(chars[i].id));
                    bw.Write(WriteReversedInt32(chars[i].costume));
                    bw.Write(WriteReversedInt16(chars[i].aurId));
                    bw.BaseStream.Seek(4, SeekOrigin.Current);
                    bw.Write(WriteReversedInt16(chars[i].glare));
                }

    }

}

 
        private short ReadReversedInt16(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(2);  // Read 2 bytes
            Array.Reverse(bytes);            // Reverse the byte array
            return BitConverter.ToInt16(bytes, 0);  // Convert to Int16
        }

        private int ReadReversedInt32(BinaryReader br)
        {
            byte[] bytes = br.ReadBytes(4);  // Read 4 bytes
            Array.Reverse(bytes);            // Reverse the byte array
            return BitConverter.ToInt32(bytes, 0);  // Convert to Int32
        }

        private byte[] WriteReversedInt16(short value)
        {
            byte[] bytes = BitConverter.GetBytes(value);  // Convert to bytes
            Array.Reverse(bytes);                         // Reverse the byte array
            return bytes;                                 // Return the reversed byte array
        }

        private byte[] WriteReversedInt32(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);  // Convert to bytes
            Array.Reverse(bytes);                         // Reverse the byte array
            return bytes;                                 // Return the reversed byte array
        }

    }

}
