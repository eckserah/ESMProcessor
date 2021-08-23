using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ESMProcessor
{
    public class BaseFormComponent
    {
        public long Offset;
        public string Signature;
        public uint Length;
    }
    public class RecordField
    {
        public string Signature;
        public ushort Length;
        public RecordField(BinaryReader reader)
        {
            Signature = new string(reader.ReadChars(4));
            Length = reader.ReadUInt16();
        }
    }
    public class TESForm : BaseFormComponent
    {
        public uint Flags;
        public FormID FormID;
        public ushort TimeStamp;
        public ushort VersionControlInfo;
        public ushort FormVersion;
        public ushort VersionControlVersion;
        public byte[] Data;

        public TESForm(string signature, BinaryReader reader)
        {
            Offset = reader.BaseStream.Position - 4;
            Signature = signature;
            Length = reader.ReadUInt32();
            Flags = reader.ReadUInt32();
            FormID = reader.ReadUInt32();
            TimeStamp = reader.ReadUInt16();
            VersionControlInfo = reader.ReadUInt16();
            FormVersion = reader.ReadUInt16();
            VersionControlVersion = reader.ReadUInt16();
            Data = reader.ReadBytes((int)Length);
        }

        public virtual void Load() { }
    }

    public class TESHeader : TESForm
    {
        public struct HEDR
        {
            public float Version;
            public uint NumberOfRecords;
            public FormID NextObjectID;
            public HEDR(BinaryReader reader)
            {
                Version = reader.ReadSingle();
                NumberOfRecords = reader.ReadUInt32();
                NextObjectID = reader.ReadUInt32();
            }
        }

        public struct MasterFile
        {
            public string FileName;
            public byte[] UnknownBytes;

            public MasterFile(BinaryReader reader)
            {
                FileName = reader.ReadString();
                reader.ReadBytes(6);
                UnknownBytes = reader.ReadBytes(8);
            }
        }

        public struct TransientType
        {
            public uint FormType;
            public List<FormID> References;

            public TransientType(BinaryReader reader)
            {
                FormType = reader.ReadUInt32();
                References = new List<FormID>();

            }
        }


        public HEDR Header;
        public byte[] MMSB;
        public string Author;
        public string Description;
        public List<MasterFile> MasterFiles;
        public List<FormID> OverriddenForms;
        public List<TransientType> TransientTypes;
        public uint INTV;
        public uint InternalCellCount;

        public TESHeader(string signature, BinaryReader reader) : base(signature, reader) { }
        public override void Load()
        {
            using (MemoryStream ms = new MemoryStream(Data))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    MasterFiles = new List<MasterFile>();
                    OverriddenForms = new List<FormID>();
                    TransientTypes = new List<TransientType>();
                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        RecordField field = new RecordField(br);
                        switch(field.Signature)
                        {
                            case "HEDR":
                                Header = new HEDR(br);
                                break;
                            case "MMSB":
                                MMSB = br.ReadBytes(field.Length);
                                break;
                            case "CNAM":
                                Author = br.ReadString();
                                break;
                            case "SNAM":
                                Description = br.ReadString();
                                break;
                            case "MAST":
                                MasterFiles.Add(new MasterFile(br));
                                break;
                            case "ONAM":
                                OverriddenForms.Add(br.ReadUInt32());
                                break;
                            case "TNAM":
                                TransientTypes.Add(new TransientType(br));
                                break;
                            case "INTV":
                                INTV = br.ReadUInt32();
                                break;
                            case "INCC":
                                InternalCellCount = br.ReadUInt32();
                                break;
                            default:
                                br.ReadBytes(field.Length);
                                break;
                        }
                    }
                }
            }
        }
    }

    public class RecordGroup : BaseFormComponent
    {
        public byte[] Label;
        public object TrueLabel;
        public int GroupType;
        public ushort TimeStamp;
        public ushort VersionControlInfo;
        public FormID UnknownVal;
        public byte[] Data;
        BaseFormComponent[] Records;

        public RecordGroup(string signature, BinaryReader reader)
        {
            Offset = reader.BaseStream.Position - 4;
            Signature = signature;
            Length = reader.ReadUInt32();
            Label = reader.ReadBytes(4);
            GroupType = reader.ReadInt32();
            switch (GroupType)
            {
                case 0:
                    TrueLabel = Encoding.ASCII.GetString(Label);
                    break;
                case 1:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    TrueLabel = (FormID)BitConverter.ToUInt32(Label,0);
                    break;
                case 2:
                case 3:
                    TrueLabel = BitConverter.ToInt32(Label, 0);
                    break;
                case 4:
                case 5:
                    TrueLabel = new Tuple<short, short>(BitConverter.ToInt16(Label, 0), BitConverter.ToInt16(Label, 2));
                    break;
                default:
                    TrueLabel = Label;
                    break;
            }
            TimeStamp = reader.ReadUInt16();
            VersionControlInfo = reader.ReadUInt16();
            Data = reader.ReadBytes((int)Length);
            ProcessGrupRecords();
        }
        public void ProcessGrupRecords()
        {

        }
    }
}
