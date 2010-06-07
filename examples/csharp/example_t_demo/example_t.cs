/* LCM type definition class file
 * This file was automatically generated by lcm-gen
 * DO NOT MODIFY BY HAND!!!!
 */

using System;
using System.Collections.Generic;
using System.IO;
using LCM.LCM;
 
namespace LCMTypes
{
    public sealed class example_t : LCM.LCM.LCMEncodable
    {
        public long timestamp;
        public double[] position;
        public double[] orientation;
        public int num_ranges;
        public short[] ranges;
 
        public example_t()
        {
            position = new double[3];
            orientation = new double[4];
        }
 
        public static readonly ulong LCM_FINGERPRINT;
        public static readonly ulong LCM_FINGERPRINT_BASE = 0x9eb95d2c2f66b618L;
 
        static example_t() {
            LCM_FINGERPRINT = _hashRecursive(new List<String>());
        }
 
        public static ulong _hashRecursive(List<String> classes)
        {
            if (classes.Contains("LCMTypes.example_t"))
                return 0L;
 
            classes.Add("LCMTypes.example_t");
            ulong hash = LCM_FINGERPRINT_BASE
                ;
            classes.RemoveAt(classes.Count - 1);
            return (hash<<1) + ((hash>>63)&1);
        }
 
        public void Encode(BinaryWriter outs)
        {
            outs.Write((long) LCM_FINGERPRINT);
            _encodeRecursive(outs);
        }
 
        public void _encodeRecursive(BinaryWriter outs)
        {
            byte[] __strbuf = null;
            outs.Write(this.timestamp); 
            for (int a = 0; a < 3; a++) {
                outs.Write(this.position[a]); 
            }
            for (int a = 0; a < 4; a++) {
                outs.Write(this.orientation[a]); 
            }
            outs.Write(this.num_ranges); 
            for (int a = 0; a < num_ranges; a++) {
                outs.Write(this.ranges[a]); 
            }
        }
 
        public example_t(byte[] data) : this(new LCMDataInputStream(data))
        {
        }
 
        public example_t(BinaryReader ins)
        {
            if ((ulong) ins.ReadInt64() != LCM_FINGERPRINT)
                throw new System.IO.IOException("LCM Decode error: bad fingerprint");
 
            _decodeRecursive(ins);
        }
 
        public static LCMTypes.example_t _decodeRecursiveFactory(BinaryReader ins)
        {
            LCMTypes.example_t o = new LCMTypes.example_t();
            o._decodeRecursive(ins);
            return o;
        }
 
        public void _decodeRecursive(BinaryReader ins)
        {
            byte[] __strbuf = null;
            this.timestamp = ins.ReadInt64();
            this.position = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                this.position[a] = ins.ReadDouble();
            }
            this.orientation = new double[(int) 4];
            for (int a = 0; a < 4; a++) {
                this.orientation[a] = ins.ReadDouble();
            }
            this.num_ranges = ins.ReadInt32();
            this.ranges = new short[(int) num_ranges];
            for (int a = 0; a < num_ranges; a++) {
                this.ranges[a] = ins.ReadInt16();
            }
        }
 
        public LCMTypes.example_t Copy()
        {
            LCMTypes.example_t outobj = new LCMTypes.example_t();
            outobj.timestamp = this.timestamp;
 
            outobj.position = new double[(int) 3];
            for (int a = 0; a < 3; a++) {
                outobj.position[a] = this.position[a];
            }
 
            outobj.orientation = new double[(int) 4];
            for (int a = 0; a < 4; a++) {
                outobj.orientation[a] = this.orientation[a];
            }
 
            outobj.num_ranges = this.num_ranges;
 
            outobj.ranges = new short[(int) num_ranges];
            for (int a = 0; a < num_ranges; a++) {
                outobj.ranges[a] = this.ranges[a];
            }
 
            return outobj;
        }
    }
}
